
' This file implements the code-behind class for EditIncident.aspx.
' EditIncident.Controls.vb contains the Table, Row and Record control classes
' for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
        
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls
        
Imports FASTPORT.Business
Imports FASTPORT.Data
Imports Telerik.Web.UI

#End Region

  
Namespace FASTPORT.UI
  
Partial Public Class EditIncident
        Inherits BaseApplicationPage
        Implements System.Web.UI.ICallbackEventHandler
' Code-behind class for the EditIncident page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."

        Protected WithEvents OccurredOnTB As RadMaskedTextBox
        Protected WithEvents DescriptionRadEditor As RadEditor
        Protected WithEvents AccidentLocationRadCombo As RadComboBox
        Protected WithEvents ReinstatedOnTB As RadMaskedTextBox
        Protected WithEvents EquipCombobox As RadComboBox
        Protected WithEvents CargoCombobox As RadComboBox
        Protected WithEvents SAPReleaseDateTB As RadMaskedTextBox
        Protected WithEvents IncidentExpirationTB As RadMaskedTextBox
        Protected WithEvents IncidentRTS As RadTabStrip
        Protected WithEvents IncidentRMP As RadMultiPage
        Protected WithEvents PhysicalLimitationExpirationTB As RadMaskedTextBox

        ' hold callback return value
        Private returnValue As String

        Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
            'Paul -- Step 6:  Procedure sends result back to JavaScript.
            Return returnValue
        End Function

        Public Sub RaiseCallbackEvent(ByVal args As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
            'encrypt whatever is passed to args and pass to returnValue
            'Paul -- Step 5:  Code behind gets and processes value sent by ISD.  Function below provides encryption and whatever else is needed (could even set session variables.  awesome.)
            returnValue = f_ProcessURL(args)
        End Sub

        Public Function f_ProcessURL(ByVal myArgs As String) As String

            Dim myAction As String = CustGenClass.f_Split_ByComma(myArgs, 1)
            Dim my1st As String = CustGenClass.f_Split_ByComma(myArgs, 2)
            Dim my2nd As String = CustGenClass.f_Split_ByComma(myArgs, 3)

            Dim myMessage As String = "Nothing"
            Dim myReturn As String = "Nothing"
            Dim mySproc As String = "0"

            'Actions for general tab.
            If myAction = "deleteRACItem" Then
                myReturn = CustGenClass.f_Sproc("usp_ExpDelete_ByPartyExperienceID", my1st, my2nd)
            End If

            Return myReturn

        End Function

        Public Sub s_Vis()

            Dim myIncidentID As String = Me.PartyIncidentRecordControl.IncidentID.Text

            Dim myIncidentCategoryID As String = Me.PartyIncidentRecordControl.IncidentCategoryID.Text

            Dim myCheckboxParentID As String = CustGenClass.f_Decrypt(Me.Page.Request.QueryString("CheckboxParent"))

            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = " & myIncidentCategoryID
            Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
            Dim myParentID As String = CStr(myRec.TreeParentID)

            Try

                Dim data As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_TicketedFor", myIncidentID)

                Dim endOffset As Integer = data.Rows.Count

                Dim i As Integer = 0
                While i < endOffset
                    Dim myNodeText As String = data.Rows(i)("TicketedFor").ToString()
                    Dim myNodeID As String = data.Rows(i)("TicketedForID").ToString()
                    TicketedForRAC.Entries.Add(New AutoCompleteBoxEntry(myNodeText, myNodeID))
                    i = i + 1
                End While

            Catch ex As Exception

            End Try

            If myParentID = "823" Then
                IncidentRTS.Tabs.FindTabByText("Accident Info").Visible = True
            Else
                IncidentRTS.Tabs.FindTabByText("Accident Info").Visible = False
            End If

            If myParentID = "823" Or myParentID = "2123" Or myParentID = "824" Or myParentID = "826" Or myParentID = "825" Then
                MiscUtils.FindControlRecursively(Me, "AccidentLocationRow").Visible = True
                If myParentID = "823" Then
                    Me.PartyIncidentRecordControl.AccidentLocationIDLabel.Text = "City, ST Where Accident Occurred"
                ElseIf myParentID = "2123" Then
                    Me.PartyIncidentRecordControl.AccidentLocationIDLabel.Text = "City, ST Where Cargo was Discovered Damaged"
                ElseIf myParentID = "824" Then
                    Me.PartyIncidentRecordControl.AccidentLocationIDLabel.Text = "City, ST Where Ticketed"
                ElseIf myParentID = "826" Then
                    Me.PartyIncidentRecordControl.AccidentLocationIDLabel.Text = "City, ST Where Inspection was Performed"
                ElseIf myParentID = "825" Then
                    Me.PartyIncidentRecordControl.AccidentLocationIDLabel.Text = "City, ST Where Felony/Misdemeanor Occurred"
                End If
            Else
                MiscUtils.FindControlRecursively(Me, "AccidentLocationRow").Visible = False
            End If

            If myParentID = "823" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the details concerning this accident below, in as much detail as possible.  Also, if you do not feel you were at fault, please explain."
            ElseIf myParentID = "2123" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the circumstances surrounding this cargo claim, paying close attention to how the cargo became damaged.  Also, please describe any action that you have taken to avoid similar cargo damage in the future."
            ElseIf myParentID = "824" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the circumstances surrounding this ticket.  Also, if you were ticketed for things not listed on the 'Ticketed For' tab, please list those items.  Please remember carriers will see this ticket on your DAC report, so provide a complete and honest description."
            ElseIf myParentID = "826" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please list the issues identified in this roadside inspection, and please provide your opinion as to whether the issues were properly/fairly  assessed."
            ElseIf myParentID = "825" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the circumstances concerning this felony or misdemeanor incident, including whether or not a conviction was issued.  Please be as honest as possible in this section, because the incident will be discovered with a simple background check."
            ElseIf myIncidentCategoryID = "828" Or myIncidentCategoryID = "829" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the circumstances surrounding this failed or refused drug/alcohol test.  Also, understand that until you get a release from a SAP ('Substance Abuse Professional'), that you will be entirely disqualified from most trucking jobs until at least 3 years after the incident."
            ElseIf myIncidentCategoryID = "830" Or myIncidentCategoryID = "2126" Then
                Me.PartyIncidentRecordControl.DescInstructionsLiteral.Text = "Please describe the reason for your failed or limited physical.  Also, please describe the physical condition to the degree with which you feel comfortable.  Finally, if your physical is a 'limited,' please confirm the date or conditions with which the limitation will be lifted."
                Me.PartyIncidentRecordControl.IncidentExpirationLabel.Text = "Date of Overruling Physical"
            End If

            If myParentID = "823" Then
                MiscUtils.FindControlRecursively(Me, "AtFaultRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "FatalitiesOccuredRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "TowAWayAccidentRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "InjuriesOccuredRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "TicketedRow").Visible = True
                Me.PartyIncidentRecordControl.EstimatedCostLabel.Text = "Estimated Cost of Damage (1) to Property, (2) to Cargo, and (3) for Personal Injuries"
            Else
                MiscUtils.FindControlRecursively(Me, "AtFaultRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "FatalitiesOccuredRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "TowAWayAccidentRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "InjuriesOccuredRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "TicketedRow").Visible = False
            End If

            If myParentID = "823" Or myParentID = "2123" Then
                MiscUtils.FindControlRecursively(Me, "EstimatedCostRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "FileClosedRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "EstimatedCostRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "FileClosedRow").Visible = False
            End If

            If myParentID = "2123" Then
                MiscUtils.FindControlRecursively(Me, "EquipRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "CargoRow").Visible = True
                Me.PartyIncidentRecordControl.EstimatedCostLabel.Text = "Estimated Cost of Damage to Cargo"
            Else
                MiscUtils.FindControlRecursively(Me, "EquipRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "CargoRow").Visible = False
            End If

            If myParentID = "824" Or _
                (myParentID = "823" And Me.PartyIncidentRecordControl.Ticketed.Checked = True) Then
                MiscUtils.FindControlRecursively(Me, "RecklessDrivingRow").Visible = True
                MiscUtils.FindControlRecursively(Me, "FelonyIssuedRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "RecklessDrivingRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "FelonyIssuedRow").Visible = False
            End If


            If myParentID = "824" Or _
                (myParentID = "823" And Me.PartyIncidentRecordControl.Ticketed.Checked = True) Or _
                myCheckboxParentID = "2140" Or myCheckboxParentID = "2141" Or myCheckboxParentID = "2142" Then
                MiscUtils.FindControlRecursively(Me, "TicketedForRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "TicketedForRow").Visible = False
            End If

            If myParentID = "825" Or _
                myParentID = "2130" Or _
                myParentID = "825" Or _
                (myParentID = "824" And Me.PartyIncidentRecordControl.FelonyIssued.Checked = True) Or _
                (myParentID = "823" And Me.PartyIncidentRecordControl.Ticketed.Checked = True) Then
                If myParentID <> "2130" Then
                    MiscUtils.FindControlRecursively(Me, "LicenseSuspendedRow").Visible = True
                Else
                    MiscUtils.FindControlRecursively(Me, "LicenseSuspendedRow").Visible = False
                End If
                If Me.PartyIncidentRecordControl.LicenseSuspended.Checked = True Then
                    MiscUtils.FindControlRecursively(Me, "ReinstatedOnRow").Visible = True
                Else
                    MiscUtils.FindControlRecursively(Me, "ReinstatedOnRow").Visible = False
                End If
            Else
                MiscUtils.FindControlRecursively(Me, "LicenseSuspendedRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "ReinstatedOnRow").Visible = False
            End If

            If myIncidentCategoryID = "828" Or myIncidentCategoryID = "829" Then
                MiscUtils.FindControlRecursively(Me, "SAPReleaseRow").Visible = True
                If Me.PartyIncidentRecordControl.SAPRelease.Checked = True Then
                    MiscUtils.FindControlRecursively(Me, "SAPReleaseDateRow").Visible = True
                Else
                    MiscUtils.FindControlRecursively(Me, "SAPReleaseDateRow").Visible = False
                End If
            Else
                MiscUtils.FindControlRecursively(Me, "SAPReleaseRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "SAPReleaseDateRow").Visible = False
            End If

            If myIncidentCategoryID = "2126" Then
                MiscUtils.FindControlRecursively(Me, "PhysicalLimitationExpirationRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "PhysicalLimitationExpirationRow").Visible = False
            End If

            If myIncidentCategoryID = "830" Or myIncidentCategoryID = "2126" Then
                MiscUtils.FindControlRecursively(Me, "PhysicalObsoleteRow").Visible = True
                If Me.PartyIncidentRecordControl.PhysicalObsolete.Checked = True Then
                    MiscUtils.FindControlRecursively(Me, "IncidentExpirationRow").Visible = True
                Else
                    MiscUtils.FindControlRecursively(Me, "IncidentExpirationRow").Visible = False
                End If
            Else
                MiscUtils.FindControlRecursively(Me, "PhysicalObsoleteRow").Visible = False
                MiscUtils.FindControlRecursively(Me, "IncidentExpirationRow").Visible = False
            End If

            OccurredOnTB.Text = Me.PartyIncidentRecordControl.OccurredOn.Text

            DescriptionRadEditor.Content = Me.PartyIncidentRecordControl.DetailedDescription.Text

            Dim myCityID As String = Me.PartyIncidentRecordControl.AccidentLocationID.Text
            If String.IsNullOrEmpty(myCityID) = False Then
                Dim myCityST As String = CustGenClass.f_Sproc("usp_GetCityST", myCityID)
                AccidentLocationRadCombo.SelectedValue = myCityID
                AccidentLocationRadCombo.Text = myCityST
            End If

            ReinstatedOnTB.Text = Me.PartyIncidentRecordControl.ReinstatedOn.Text

            Dim myEquipTypeID As String = CStr(Me.PartyIncidentRecordControl.EqiupTypeID.Text)
            Dim myCargoTypeID As String = CStr(Me.PartyIncidentRecordControl.CargoTypeID.Text)

            If BaseApplicationPage.f_StringEmpty(myEquipTypeID) = "No" Then
                EquipCombobox.SelectedValue = myEquipTypeID
                EquipCombobox.Text = CustGenClass.f_Sproc("usp_TreeFullName", "389", myEquipTypeID)
            End If

            If BaseApplicationPage.f_StringEmpty(myCargoTypeID) = "No" Then
                CargoCombobox.SelectedValue = myCargoTypeID
                CargoCombobox.Text = CustGenClass.f_Sproc("usp_TreeFullName", "666", myCargoTypeID)
            End If

            SAPReleaseDateTB.Text = Me.PartyIncidentRecordControl.SAPReleaseDate.Text
            IncidentExpirationTB.Text = Me.PartyIncidentRecordControl.IncidentExpiration.Text
            PhysicalLimitationExpirationTB.Text = Me.PartyIncidentRecordControl.PhysicalLimitationExpiration.Text


        End Sub

        Private Const ItemsPerRequest As Integer = 10

        Protected Sub s_CityRadCombo_ItemsRequested(ByVal sender As Object, ByVal e As RadComboBoxItemsRequestedEventArgs) Handles AccidentLocationRadCombo.ItemsRequested

            Try

                Dim data As DataTable = f_CityCombo_GetData(e.Text)

                Dim itemOffset As Integer = e.NumberOfItems
                Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
                e.EndOfItems = endOffset = data.Rows.Count

                Dim i As Integer = itemOffset
                While i < endOffset
                    AccidentLocationRadCombo.Items.Add(New RadComboBoxItem(data.Rows(i)("Info").ToString(), data.Rows(i)("PK").ToString()))
                    System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                End While

            Catch ex As Exception

            End Try

        End Sub


        Public Function f_CityCombo_GetData(ByVal text As String) As DataTable

            Dim myDataTable As DataTable = CustGenClass.f_Sproc_DataTableOut("usp_PickCity", text)
            Return myDataTable

        End Function

        Public Sub SetPageFocus()
            'load scripts to all controls on page so that they will retain focus on PostBack
            Me.LoadFocusScripts(Me.Page)
            'To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of  a control
            'use FindControlRecursively method. For example:
            'Dim controlToFocus As System.Web.UI.WebControls.TextBox = DirectCast(Me.FindControlRecursively("ProductsSearch"), System.Web.UI.WebControls.TextBox)
            'Me.SetFocusOnLoad(controlToFocus)
            'If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
            Me.SetFocusOnLoad()
        End Sub

        Public Sub LoadData()
            ' LoadData reads database data and assigns it to UI controls.
            ' Customize by adding code before or after the call to LoadData_Base()
            ' or replace the call to LoadData_Base().
            LoadData_Base()
            s_Vis()
        End Sub

        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
        End Function

        Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
            Me.Page_InitializeEventHandlers_Base(sender, e)
        End Sub

        Protected Overrides Sub SaveControlsToSession()
            SaveControlsToSession_Base()
        End Sub


        Protected Overrides Sub ClearControlsFromSession()
            ClearControlsFromSession_Base()
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            LoadViewState_Base(savedState)
        End Sub


        Protected Overrides Function SaveViewState() As Object
            Return SaveViewState_Base()
        End Function

        Public Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Me.Page_PreRender_Base(sender, e)
        End Sub

        Public Overrides Sub SaveData()
            Me.SaveData_Base()
        End Sub

        Public Overrides Sub SetChartControl(ByVal chartCtrlName As String)
            Me.SetChartControl_Base(chartCtrlName)
        End Sub


        Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
            'Override call to PreInit_Base() here to change top level master page used by this page.
            'For example for SharePoint applications uncomment next line to use Microsoft SharePoint default master page
            'If Not Me.Master Is Nothing Then Me.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl	
            'You may change here assignment of application theme
            Try
                Me.PreInit_Base()
            Catch ex As Exception

            End Try
        End Sub

#Region "Ajax Functions"

        <Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal fieldName As String, _
                                                  ByVal title As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, fieldName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        <Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        Protected Overloads Overrides Sub BasePage_PreRender(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.BasePage_PreRender(sender, e)
            Base_RegisterPostback()
        End Sub

#End Region

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents AccidentLocationIDLabel As System.Web.UI.WebControls.Literal
        Public WithEvents BackToMainButton As ThemeButton
        Public WithEvents BackToPreviousTabButton As ThemeButton
        Public WithEvents CargoDS As System.Web.UI.WebControls.SqlDataSource
        Public WithEvents CargoTypeIDLabel As System.Web.UI.WebControls.Literal
        Public WithEvents DescInstructionsLiteral As System.Web.UI.WebControls.Literal
        Public WithEvents EqiupTypeIDLabel As System.Web.UI.WebControls.Literal
        Public WithEvents EquipDS As System.Web.UI.WebControls.SqlDataSource
        Public WithEvents EstimatedCostLabel As System.Web.UI.WebControls.Literal
        Public WithEvents EstimatedCost As System.Web.UI.WebControls.TextBox
        Public WithEvents FatalitiesOccured As System.Web.UI.WebControls.CheckBox
        Public WithEvents FatalitiesOccuredLabel As System.Web.UI.WebControls.Literal
        Public WithEvents FelonyIssued As System.Web.UI.WebControls.CheckBox
        Public WithEvents FelonyIssuedLabel As System.Web.UI.WebControls.Literal
        Public WithEvents FileClosed As System.Web.UI.WebControls.CheckBox
        Public WithEvents FileClosedLabel As System.Web.UI.WebControls.Literal
        Public WithEvents IncidentExpirationLabel As System.Web.UI.WebControls.Literal
        Public WithEvents IncidentID As System.Web.UI.WebControls.Literal
        Public WithEvents IncidentPathLiteral As System.Web.UI.WebControls.Literal
        Public WithEvents InjuriesOccured As System.Web.UI.WebControls.CheckBox
        Public WithEvents InjuriesOccuredLabel As System.Web.UI.WebControls.Literal
        Public WithEvents IWasAtFault As System.Web.UI.WebControls.CheckBox
        Public WithEvents IWasAtFaultLabel As System.Web.UI.WebControls.Literal
        Public WithEvents LicenseSuspended As System.Web.UI.WebControls.CheckBox
        Public WithEvents LicenseSuspendedLabel As System.Web.UI.WebControls.Literal
        Public WithEvents MainScrollPanel As System.Web.UI.WebControls.Panel
        Public WithEvents OccurredOnLabel As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents PartyIncidentRecordControl As FASTPORT.UI.Controls.EditIncident.PartyIncidentRecordControl
        Public WithEvents PhysicalLimitationExpirationLabel As System.Web.UI.WebControls.Literal
        Public WithEvents PhysicalObsolete As System.Web.UI.WebControls.CheckBox
        Public WithEvents PhysicalObsoleteLabel As System.Web.UI.WebControls.Literal
        Public WithEvents ReinstatedOnLabel As System.Web.UI.WebControls.Literal
        Public WithEvents RuledAsRecklessDriving As System.Web.UI.WebControls.CheckBox
        Public WithEvents RuledAsRecklessDrivingLabel As System.Web.UI.WebControls.Literal
        Public WithEvents SAPRelease As System.Web.UI.WebControls.CheckBox
        Public WithEvents SAPReleaseDateLabel As System.Web.UI.WebControls.Literal
        Public WithEvents SAPReleaseLabel As System.Web.UI.WebControls.Literal
        Public WithEvents SaveIncidentButton As ThemeButton
        Public WithEvents CancelIncidentButton As ThemeButton
        Public WithEvents Ticketed As System.Web.UI.WebControls.CheckBox
        Public WithEvents TicketedLabel As System.Web.UI.WebControls.Literal
        Public WithEvents TicketedForLabel As System.Web.UI.WebControls.Literal
        Public WithEvents TicketedForRAC As Telerik.Web.UI.RadAutoCompleteBox
        Public WithEvents TowAWayAccident As System.Web.UI.WebControls.CheckBox
        Public WithEvents TowAWayAccidentLabel As System.Web.UI.WebControls.Literal
        Public WithEvents ValidationSummary1 As ValidationSummary


        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)

            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype


            ' the following code for accordion is necessary or the Me.{ControlName} will return Nothing

            ' Register the Event handler for any Events.


            ' Setup the pagination events.

            Me.ClearControlsFromSession()
        End Sub

        Private Sub Base_RegisterPostback()

        End Sub



        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.SetPageFocus()

            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("NOT_ANONYMOUS")

            If (Not Me.IsPostBack) Then

                ' Setup the header text for the validation summary control.
                Me.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "FASTPORT")

            End If

            'set value of the hidden control depending on the postback. It will be used by SetFocus script on the client side.	
            Dim clientSideIsPostBack As System.Web.UI.HtmlControls.HtmlInputHidden = DirectCast(Me.FindControlRecursively("_clientSideIsPostBack"), System.Web.UI.HtmlControls.HtmlInputHidden)
            If Not clientSideIsPostBack Is Nothing Then
                If Me.IsPostBack AndAlso Not Me.Request("__EVENTTARGET") = "ChildWindowPostBack" Then
                    clientSideIsPostBack.Value = "Y"
                Else
                    clientSideIsPostBack.Value = "N"
                End If
            End If

            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If

            Dim myIncidentCategoryID As String = Me.PartyIncidentRecordControl.IncidentCategoryID.Text
            Dim myIncidentPath As String = CustGenClass.f_Sproc("usp_TreeFullName", "742", myIncidentCategoryID)
            Page.Title = myIncidentPath
        End Sub

        Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
                                                    ByVal recordID As String, _
                                                    ByVal columnName As String, _
                                                    ByVal fieldName As String, _
                                                    ByVal title As String, _
                                                    ByVal persist As Boolean, _
                                                    ByVal popupWindowHeight As Integer, _
                                                    ByVal popupWindowWidth As Integer, _
                                                    ByVal popupWindowScrollBar As Boolean _
                                                    ) As Object()
            If Not IsNothing(recordID) Then
                recordID = System.Web.HttpUtility.UrlDecode(recordID)
            End If
            Dim content As String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)

            content = NetUtils.EncodeStringForHtmlDisplay(content)

            'returnValue is an array of string values.
            'returnValue(0) represents title of the pop up window
            'returnValue(1) represents content of the pop up window
            ' retrunValue(2) represents whether pop up window should be made persistant
            ' or it should closes as soon as mouse moved out.
            ' returnValue(5) represents whether pop up window should contain scroll bar.
            ' returnValue(3), (4) represents pop up window height and width respectivly
            ' (0),(2),(3),(4) and (5)  is initially set as pass through attribute.
            ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
            Dim returnValue(6) As Object
            returnValue(0) = title
            returnValue(1) = content
            returnValue(2) = persist
            returnValue(3) = popupWindowWidth
            returnValue(4) = popupWindowHeight
            returnValue(5) = popupWindowScrollBar
            Return returnValue
        End Function


        Public Shared Function GetImage_Base(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            Dim content As String = "<IMG alt =""" & title & """ src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
            'returnValue is an array of string values.
            'returnValue(0) represents title of the pop up window.
            'returnValue(1) represents content ie, image url.
            ' retrunValue(2) represents whether pop up window should be made persistant
            ' or it should closes as soon as mouse moved out.
            ' returnValue(3), (4) represents pop up window height and width respectivly
            ' returnValue(5) represents whether pop up window should contain scroll bar.
            ' (0),(2),(3),(4) and (5) is initially set as pass through attribute.
            ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
            Dim returnValue(6) As Object
            returnValue(0) = title
            returnValue(1) = content
            returnValue(2) = persist
            returnValue(3) = popupWindowWidth
            returnValue(4) = popupWindowHeight
            returnValue(5) = popupWindowScrollBar
            Return returnValue
        End Function

        Public Sub SetChartControl_Base(ByVal chartCtrlName As String)
            ' Load data for each record and table UI control.

        End Sub

        Public Sub SaveData_Base()

            Me.PartyIncidentRecordControl.SaveData()

        End Sub

        Protected Sub SaveControlsToSession_Base()
            MyBase.SaveControlsToSession()

        End Sub


        Protected Sub ClearControlsFromSession_Base()
            MyBase.ClearControlsFromSession()

        End Sub

        Protected Sub LoadViewState_Base(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

        End Sub


        Protected Function SaveViewState_Base() As Object

            Return MyBase.SaveViewState()
        End Function


        Public Sub PreInit_Base()
            'If it is SharePoint application this function performs dynamic Master Page assignment.

        End Sub

        Public Sub Page_PreRender_Base(ByVal sender As Object, ByVal e As System.EventArgs)

            ' Load data for each record and table UI control.

            ' Data bind for each chart UI control.

        End Sub


        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try

                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If



                Me.DataBind()

                ' Load and bind data for each record and table UI control.

                Me.PartyIncidentRecordControl.LoadData()
                Me.PartyIncidentRecordControl.DataBind()


                ' Load data for chart.


                ' initialize aspx controls



            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                    ' End database transaction
                    DbUtils.EndTransaction()
                End If
            End Try
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula_Base(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS Then

            End If


            e.CallingControl = Me

            e.DataSource = dataSourceForEvaluate


            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function

        Public Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True)
        End Function


        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True)
        End Function

        Public Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS)
        End Function

        Public Function EvaluateFormula(ByVal formula As String) As String
            Return EvaluateFormula(formula, Nothing, Nothing, Nothing, True)
        End Function



        ' Write out the Set methods


        ' Write out the DataSource properties and methods


        ' Write out event methods for the page events


#End Region

        'LP: CONTROLS FILE ONLY.


#Region "Section 2: Do not modify this section."


        ' Base class for the PartyIncidentRecordControl control on the EditIncident page.
        ' Do not modify this class. Instead override any method in PartyIncidentRecordControl.
        Public Class BasePartyIncidentRecordControl
            Inherits FASTPORT.UI.BaseApplicationRecordControl

            '  To customize, override this method in PartyIncidentRecordControl.
            Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

                ' Setup the filter and search events.

                Me.ClearControlsFromSession()
            End Sub

            '  To customize, override this method in PartyIncidentRecordControl.
            Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

                ' Setup the pagination events.    


                ' Register the event handlers.

                AddHandler Me.SaveIncidentButton.Button.Click, AddressOf SaveIncidentButton_Click

                Me.SaveIncidentButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.Page.GetResourceValue("Txt:SaveRecord", "FASTPORT") & """);")

                AddHandler Me.CancelIncidentButton.Button.Click, AddressOf CancelIncidentButton_Click

                AddHandler Me.FatalitiesOccured.CheckedChanged, AddressOf FatalitiesOccured_CheckedChanged

                AddHandler Me.FelonyIssued.CheckedChanged, AddressOf FelonyIssued_CheckedChanged

                AddHandler Me.FileClosed.CheckedChanged, AddressOf FileClosed_CheckedChanged

                AddHandler Me.InjuriesOccured.CheckedChanged, AddressOf InjuriesOccured_CheckedChanged

                AddHandler Me.IWasAtFault.CheckedChanged, AddressOf IWasAtFault_CheckedChanged

                AddHandler Me.LicenseSuspended.CheckedChanged, AddressOf LicenseSuspended_CheckedChanged

                AddHandler Me.PhysicalObsolete.CheckedChanged, AddressOf PhysicalObsolete_CheckedChanged

                AddHandler Me.RuledAsRecklessDriving.CheckedChanged, AddressOf RuledAsRecklessDriving_CheckedChanged

                AddHandler Me.SAPRelease.CheckedChanged, AddressOf SAPRelease_CheckedChanged

                AddHandler Me.Ticketed.CheckedChanged, AddressOf Ticketed_CheckedChanged

                AddHandler Me.TowAWayAccident.CheckedChanged, AddressOf TowAWayAccident_CheckedChanged

                AddHandler Me.AccidentLocationID.TextChanged, AddressOf AccidentLocationID_TextChanged

                AddHandler Me.CargoTypeID.TextChanged, AddressOf CargoTypeID_TextChanged

                AddHandler Me.DetailedDescription.TextChanged, AddressOf DetailedDescription_TextChanged

                AddHandler Me.EqiupTypeID.TextChanged, AddressOf EqiupTypeID_TextChanged

                AddHandler Me.EstimatedCost.TextChanged, AddressOf EstimatedCost_TextChanged

                AddHandler Me.IncidentCategoryID.TextChanged, AddressOf IncidentCategoryID_TextChanged

                AddHandler Me.IncidentExpiration.TextChanged, AddressOf IncidentExpiration_TextChanged

                AddHandler Me.OccurredOn.TextChanged, AddressOf OccurredOn_TextChanged

                AddHandler Me.PartyID.TextChanged, AddressOf PartyID_TextChanged

                AddHandler Me.PhysicalLimitationExpiration.TextChanged, AddressOf PhysicalLimitationExpiration_TextChanged

                AddHandler Me.ReinstatedOn.TextChanged, AddressOf ReinstatedOn_TextChanged

                AddHandler Me.SAPReleaseDate.TextChanged, AddressOf SAPReleaseDate_TextChanged


            End Sub


            Public Overridable Sub LoadData()

                ' Load the data from the database into the DataSource PartyIncident record.
                ' It is better to make changes to functions called by LoadData such as
                ' CreateWhereClause, rather than making changes here.

                ' The RecordUniqueId is set the first time a record is loaded, and is
                ' used during a PostBack to load the record.

                If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                    Me.DataSource = PartyIncidentTable.GetRecord(Me.RecordUniqueId, True)

                    Return
                End If

                ' This is the first time a record is being retrieved from the database.
                ' So create a Where Clause based on the staic Where clause specified
                ' on the Query wizard and the dynamic part specified by the end user
                ' on the search and filter controls (if any).

                Dim wc As WhereClause = Me.CreateWhereClause()

                Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyIncidentRecordControlPanel"), System.Web.UI.WebControls.Panel)
                If Not Panel Is Nothing Then
                    Panel.Visible = True
                End If

                ' If there is no Where clause, then simply create a new, blank record.

                If wc Is Nothing OrElse Not wc.RunQuery Then
                    Me.DataSource = New PartyIncidentRecord()

                    If Not Panel Is Nothing Then
                        Panel.Visible = False
                    End If

                    Return
                End If

                ' Retrieve the record from the database.  It is possible

                Dim recList() As PartyIncidentRecord = PartyIncidentTable.GetRecords(wc, Nothing, 0, 2)
                If recList.Length = 0 Then
                    ' There is no data for this Where clause.
                    wc.RunQuery = False

                    If Not Panel Is Nothing Then
                        Panel.Visible = False
                    End If

                    Return
                End If

                ' Set DataSource based on record retrieved from the database.
                Me.DataSource = PartyIncidentTable.GetRecord(recList(0).GetID.ToXmlString(), True)



            End Sub

            ' Populate the UI controls using the DataSource.  To customize, override this method in PartyIncidentRecordControl.
            Public Overrides Sub DataBind()
                ' The DataBind method binds the user interface controls to the values
                ' from the database record.  To do this, it calls the Set methods for 
                ' each of the field displayed on the webpage.  It is better to make 
                ' changes in the Set methods, rather than making changes here.

                MyBase.DataBind()

                ' Make sure that the DataSource is initialized.
                If Me.DataSource Is Nothing Then

                    Return
                End If


                'LoadData for DataSource for chart and report if they exist

                ' Store the checksum. The checksum is used to
                ' ensure the record was not changed by another user.
                If Not Me.DataSource.GetCheckSumValue() Is Nothing Then
                    Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
                End If



                ' Call the Set methods for each controls on the panel

                SetAccidentLocationID()
                SetAccidentLocationIDLabel()


                SetCargoDS()
                SetCargoTypeID()
                SetCargoTypeIDLabel()
                SetDescInstructionsLiteral()
                SetDetailedDescription()
                SetEqiupTypeID()
                SetEqiupTypeIDLabel()
                SetEquipDS()
                SetEstimatedCost()
                SetEstimatedCostLabel()
                SetFatalitiesOccured()
                SetFatalitiesOccuredLabel()
                SetFelonyIssued()
                SetFelonyIssuedLabel()
                SetFileClosed()
                SetFileClosedLabel()

                SetIncidentCategoryID()
                SetIncidentExpiration()
                SetIncidentExpirationLabel()
                SetIncidentID()
                SetIncidentPathLiteral()
                SetInjuriesOccured()
                SetInjuriesOccuredLabel()
                SetIWasAtFault()
                SetIWasAtFaultLabel()
                SetLicenseSuspended()
                SetLicenseSuspendedLabel()
                SetMainScrollPanel()


                SetOccurredOn()
                SetOccurredOnLabel()
                SetPartyID()
                SetPhysicalLimitationExpiration()
                SetPhysicalLimitationExpirationLabel()
                SetPhysicalObsolete()
                SetPhysicalObsoleteLabel()
                SetReinstatedOn()
                SetReinstatedOnLabel()
                SetRuledAsRecklessDriving()
                SetRuledAsRecklessDrivingLabel()
                SetSAPRelease()
                SetSAPReleaseDate()
                SetSAPReleaseDateLabel()
                SetSAPReleaseLabel()

                SetTicketed()
                SetTicketedLabel()
                SetTowAWayAccident()
                SetTowAWayAccidentLabel()


                Me.IsNewRecord = True

                If Me.DataSource.IsCreated Then
                    Me.IsNewRecord = False

                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If

                ' Now load data for each record and table child UI controls.
                ' Ordering is important because child controls get 
                ' their parent ids from their parent UI controls.
                Dim shouldResetControl As Boolean = False

            End Sub


            Public Overridable Sub SetAccidentLocationID()


                ' Set the AccidentLocationID TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.AccidentLocationID is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetAccidentLocationID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AccidentLocationIDSpecified Then

                    ' If the AccidentLocationID is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.AccidentLocationID)

                    Me.AccidentLocationID.Text = formattedValue

                Else

                    ' AccidentLocationID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.AccidentLocationID.Text = PartyIncidentTable.AccidentLocationID.Format(PartyIncidentTable.AccidentLocationID.DefaultValue)

                End If

            End Sub

            Public Overridable Sub SetCargoTypeID()


                ' Set the CargoTypeID TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.CargoTypeID is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetCargoTypeID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CargoTypeIDSpecified Then

                    ' If the CargoTypeID is non-NULL, then format the value.

                    ' The Format method will return the Display Foreign Key As (DFKA) value
                    Dim formattedValue As String = Me.DataSource.CargoTypeID.ToString()


                    Me.CargoTypeID.Text = formattedValue

                Else

                    ' CargoTypeID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.CargoTypeID.Text = PartyIncidentTable.CargoTypeID.DefaultValue
                End If

            End Sub

            Public Overridable Sub SetDetailedDescription()


                ' Set the DetailedDescription TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.DetailedDescription is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetDetailedDescription()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DetailedDescriptionSpecified Then

                    ' If the DetailedDescription is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.DetailedDescription)

                    Me.DetailedDescription.Text = formattedValue

                Else

                    ' DetailedDescription is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.DetailedDescription.Text = PartyIncidentTable.DetailedDescription.Format(PartyIncidentTable.DetailedDescription.DefaultValue)

                End If

            End Sub

            Public Overridable Sub SetEqiupTypeID()


                ' Set the EqiupTypeID TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.EqiupTypeID is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetEqiupTypeID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EqiupTypeIDSpecified Then

                    ' If the EqiupTypeID is non-NULL, then format the value.

                    ' The Format method will return the Display Foreign Key As (DFKA) value
                    Dim formattedValue As String = Me.DataSource.EqiupTypeID.ToString()


                    Me.EqiupTypeID.Text = formattedValue

                Else

                    ' EqiupTypeID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.EqiupTypeID.Text = PartyIncidentTable.EqiupTypeID.DefaultValue
                End If

            End Sub

            Public Overridable Sub SetEstimatedCost()


                ' Set the EstimatedCost TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.EstimatedCost is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetEstimatedCost()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EstimatedCostSpecified Then

                    ' If the EstimatedCost is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.EstimatedCost, "C")

                    Me.EstimatedCost.Text = formattedValue

                Else

                    ' EstimatedCost is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.EstimatedCost.Text = PartyIncidentTable.EstimatedCost.Format(PartyIncidentTable.EstimatedCost.DefaultValue, "C")

                End If

            End Sub

            Public Overridable Sub SetFatalitiesOccured()


                ' Set the FatalitiesOccured CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.FatalitiesOccured is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetFatalitiesOccured()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FatalitiesOccuredSpecified Then

                    ' If the FatalitiesOccured is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.FatalitiesOccured.Checked = Me.DataSource.FatalitiesOccured
                Else

                    ' FatalitiesOccured is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.FatalitiesOccured.Checked = PartyIncidentTable.FatalitiesOccured.ParseValue(PartyIncidentTable.FatalitiesOccured.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetFelonyIssued()


                ' Set the FelonyIssued CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.FelonyIssued is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetFelonyIssued()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FelonyIssuedSpecified Then

                    ' If the FelonyIssued is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.FelonyIssued.Checked = Me.DataSource.FelonyIssued
                Else

                    ' FelonyIssued is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.FelonyIssued.Checked = PartyIncidentTable.FelonyIssued.ParseValue(PartyIncidentTable.FelonyIssued.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetFileClosed()


                ' Set the FileClosed CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.FileClosed is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetFileClosed()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FileClosedSpecified Then

                    ' If the FileClosed is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.FileClosed.Checked = Me.DataSource.FileClosed
                Else

                    ' FileClosed is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.FileClosed.Checked = PartyIncidentTable.FileClosed.ParseValue(PartyIncidentTable.FileClosed.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetIncidentCategoryID()


                ' Set the IncidentCategoryID TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.IncidentCategoryID is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetIncidentCategoryID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IncidentCategoryIDSpecified Then

                    ' If the IncidentCategoryID is non-NULL, then format the value.

                    ' The Format method will return the Display Foreign Key As (DFKA) value
                    Dim formattedValue As String = Me.DataSource.IncidentCategoryID.ToString()


                    Me.IncidentCategoryID.Text = formattedValue

                Else

                    ' IncidentCategoryID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.IncidentCategoryID.Text = PartyIncidentTable.IncidentCategoryID.DefaultValue
                End If

            End Sub

            Public Overridable Sub SetIncidentExpiration()


                ' Set the IncidentExpiration TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.IncidentExpiration is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetIncidentExpiration()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IncidentExpirationSpecified Then

                    ' If the IncidentExpiration is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.IncidentExpiration, "g")

                    Me.IncidentExpiration.Text = formattedValue

                Else

                    ' IncidentExpiration is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.IncidentExpiration.Text = PartyIncidentTable.IncidentExpiration.Format(PartyIncidentTable.IncidentExpiration.DefaultValue, "g")

                End If

            End Sub

            Public Overridable Sub SetIncidentID()


                ' Set the IncidentID Literal on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.IncidentID is the ASP:Literal on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetIncidentID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IncidentIDSpecified Then

                    ' If the IncidentID is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.IncidentID)

                    formattedValue = HttpUtility.HtmlEncode(formattedValue)
                    Me.IncidentID.Text = formattedValue

                Else

                    ' IncidentID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.IncidentID.Text = PartyIncidentTable.IncidentID.Format(PartyIncidentTable.IncidentID.DefaultValue)

                End If

            End Sub

            Public Overridable Sub SetInjuriesOccured()


                ' Set the InjuriesOccured CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.InjuriesOccured is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetInjuriesOccured()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.InjuriesOccuredSpecified Then

                    ' If the InjuriesOccured is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.InjuriesOccured.Checked = Me.DataSource.InjuriesOccured
                Else

                    ' InjuriesOccured is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.InjuriesOccured.Checked = PartyIncidentTable.InjuriesOccured.ParseValue(PartyIncidentTable.InjuriesOccured.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetIWasAtFault()


                ' Set the IWasAtFault CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.IWasAtFault is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetIWasAtFault()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IWasAtFaultSpecified Then

                    ' If the IWasAtFault is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.IWasAtFault.Checked = Me.DataSource.IWasAtFault
                Else

                    ' IWasAtFault is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.IWasAtFault.Checked = PartyIncidentTable.IWasAtFault.ParseValue(PartyIncidentTable.IWasAtFault.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetLicenseSuspended()


                ' Set the LicenseSuspended CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.LicenseSuspended is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetLicenseSuspended()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LicenseSuspendedSpecified Then

                    ' If the LicenseSuspended is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.LicenseSuspended.Checked = Me.DataSource.LicenseSuspended
                Else

                    ' LicenseSuspended is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.LicenseSuspended.Checked = PartyIncidentTable.LicenseSuspended.ParseValue(PartyIncidentTable.LicenseSuspended.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetOccurredOn()


                ' Set the OccurredOn TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.OccurredOn is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetOccurredOn()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.OccurredOnSpecified Then

                    ' If the OccurredOn is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.OccurredOn, "g")

                    Me.OccurredOn.Text = formattedValue

                Else

                    ' OccurredOn is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.OccurredOn.Text = PartyIncidentTable.OccurredOn.Format(PartyIncidentTable.OccurredOn.DefaultValue, "g")

                End If

            End Sub

            Public Overridable Sub SetPartyID()


                ' Set the PartyID TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.PartyID is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetPartyID()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PartyIDSpecified Then

                    ' If the PartyID is non-NULL, then format the value.

                    ' The Format method will return the Display Foreign Key As (DFKA) value
                    Dim formattedValue As String = Me.DataSource.PartyID.ToString()


                    Me.PartyID.Text = formattedValue

                Else

                    ' PartyID is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.PartyID.Text = PartyIncidentTable.PartyID.DefaultValue
                End If

            End Sub

            Public Overridable Sub SetPhysicalLimitationExpiration()


                ' Set the PhysicalLimitationExpiration TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.PhysicalLimitationExpiration is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetPhysicalLimitationExpiration()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PhysicalLimitationExpirationSpecified Then

                    ' If the PhysicalLimitationExpiration is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.PhysicalLimitationExpiration, "g")

                    Me.PhysicalLimitationExpiration.Text = formattedValue

                Else

                    ' PhysicalLimitationExpiration is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.PhysicalLimitationExpiration.Text = PartyIncidentTable.PhysicalLimitationExpiration.Format(PartyIncidentTable.PhysicalLimitationExpiration.DefaultValue, "g")

                End If

            End Sub

            Public Overridable Sub SetPhysicalObsolete()


                ' Set the PhysicalObsolete CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.PhysicalObsolete is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetPhysicalObsolete()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PhysicalObsoleteSpecified Then

                    ' If the PhysicalObsolete is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.PhysicalObsolete.Checked = Me.DataSource.PhysicalObsolete
                Else

                    ' PhysicalObsolete is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.PhysicalObsolete.Checked = PartyIncidentTable.PhysicalObsolete.ParseValue(PartyIncidentTable.PhysicalObsolete.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetReinstatedOn()


                ' Set the ReinstatedOn TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.ReinstatedOn is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetReinstatedOn()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ReinstatedOnSpecified Then

                    ' If the ReinstatedOn is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.ReinstatedOn, "g")

                    Me.ReinstatedOn.Text = formattedValue

                Else

                    ' ReinstatedOn is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.ReinstatedOn.Text = PartyIncidentTable.ReinstatedOn.Format(PartyIncidentTable.ReinstatedOn.DefaultValue, "g")

                End If

            End Sub

            Public Overridable Sub SetRuledAsRecklessDriving()


                ' Set the RuledAsRecklessDriving CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.RuledAsRecklessDriving is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetRuledAsRecklessDriving()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RuledAsRecklessDrivingSpecified Then

                    ' If the RuledAsRecklessDriving is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.RuledAsRecklessDriving.Checked = Me.DataSource.RuledAsRecklessDriving
                Else

                    ' RuledAsRecklessDriving is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.RuledAsRecklessDriving.Checked = PartyIncidentTable.RuledAsRecklessDriving.ParseValue(PartyIncidentTable.RuledAsRecklessDriving.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetSAPRelease()


                ' Set the SAPRelease CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.SAPRelease is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetSAPRelease()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SAPReleaseSpecified Then

                    ' If the SAPRelease is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.SAPRelease.Checked = Me.DataSource.SAPRelease
                Else

                    ' SAPRelease is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.SAPRelease.Checked = PartyIncidentTable.SAPRelease.ParseValue(PartyIncidentTable.SAPRelease.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetSAPReleaseDate()


                ' Set the SAPReleaseDate TextBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.SAPReleaseDate is the ASP:TextBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                '     MyBase.SetSAPReleaseDate()
                ' and add your own code before or after the call to the MyBase function.



                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SAPReleaseDateSpecified Then

                    ' If the SAPReleaseDate is non-NULL, then format the value.

                    ' The Format method will use the Display Format
                    Dim formattedValue As String = Me.DataSource.Format(PartyIncidentTable.SAPReleaseDate, "g")

                    Me.SAPReleaseDate.Text = formattedValue

                Else

                    ' SAPReleaseDate is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.

                    Me.SAPReleaseDate.Text = PartyIncidentTable.SAPReleaseDate.Format(PartyIncidentTable.SAPReleaseDate.DefaultValue, "g")

                End If

            End Sub

            Public Overridable Sub SetTicketed()


                ' Set the Ticketed CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.Ticketed is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetTicketed()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TicketedSpecified Then

                    ' If the Ticketed is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.Ticketed.Checked = Me.DataSource.Ticketed
                Else

                    ' Ticketed is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.Ticketed.Checked = PartyIncidentTable.Ticketed.ParseValue(PartyIncidentTable.Ticketed.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetTowAWayAccident()


                ' Set the TowAWayAccident CheckBox on the webpage with value from the
                ' PartyIncident database record.

                ' Me.DataSource is the PartyIncident record retrieved from the database.
                ' Me.TowAWayAccident is the ASP:CheckBox on the webpage.

                ' You can modify this method directly, or replace it with a call to
                ' MyBase.SetTowAWayAccident()
                ' and add your own code before or after the call to the MyBase function.


                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TowAWayAccidentSpecified Then

                    ' If the TowAWayAccident is non-NULL, then format the value.
                    ' The Format method will use the Display Format
                    Me.TowAWayAccident.Checked = Me.DataSource.TowAWayAccident
                Else

                    ' TowAWayAccident is NULL in the database, so use the Default Value.  
                    ' Default Value could also be NULL.
                    If Not Me.DataSource.IsCreated Then
                        Me.TowAWayAccident.Checked = PartyIncidentTable.TowAWayAccident.ParseValue(PartyIncidentTable.TowAWayAccident.DefaultValue).ToBoolean()
                    End If

                End If

            End Sub

            Public Overridable Sub SetAccidentLocationIDLabel()

            End Sub

            Public Overridable Sub SetCargoDS()

            End Sub

            Public Overridable Sub SetCargoTypeIDLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.CargoTypeIDLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetDescInstructionsLiteral()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.DescInstructionsLiteral.Text = "Some value"

            End Sub

            Public Overridable Sub SetEqiupTypeIDLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.EqiupTypeIDLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetEquipDS()

            End Sub

            Public Overridable Sub SetEstimatedCostLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.EstimatedCostLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetFatalitiesOccuredLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.FatalitiesOccuredLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetFelonyIssuedLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.FelonyIssuedLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetFileClosedLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.FileClosedLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetIncidentExpirationLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.IncidentExpirationLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetIncidentPathLiteral()

            End Sub

            Public Overridable Sub SetInjuriesOccuredLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.InjuriesOccuredLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetIWasAtFaultLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.IWasAtFaultLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetLicenseSuspendedLabel()

            End Sub

            Public Overridable Sub SetMainScrollPanel()

            End Sub

            Public Overridable Sub SetOccurredOnLabel()

            End Sub

            Public Overridable Sub SetPhysicalLimitationExpirationLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.PhysicalLimitationExpirationLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetPhysicalObsoleteLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.PhysicalObsoleteLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetReinstatedOnLabel()

            End Sub

            Public Overridable Sub SetRuledAsRecklessDrivingLabel()

            End Sub

            Public Overridable Sub SetSAPReleaseDateLabel()

            End Sub

            Public Overridable Sub SetSAPReleaseLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.SAPReleaseLabel.Text = "Some value"

            End Sub

            Public Overridable Sub SetTicketedLabel()

            End Sub

            Public Overridable Sub SetTowAWayAccidentLabel()

                'Code for the text property is generated inside the .aspx file.
                'To override this property you can uncomment the following property and add your own value.
                'Me.TowAWayAccidentLabel.Text = "Some value"

            End Sub

            Public Overridable Sub ResetControl()

            End Sub


            Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
                If e Is Nothing Then
                    e = New FormulaEvaluator()
                End If

                e.Variables.Clear()


                ' add variables for formula evaluation
                If variables IsNot Nothing Then
                    Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                    While enumerator.MoveNext()
                        e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                    End While
                End If

                If includeDS Then

                End If


                ' Other variables referred to in the formula are expected to be
                ' properties of the DataSource.  For example, referring to
                ' UnitPrice as a variable will refer to DataSource.UnitPrice
                If dataSourceForEvaluate Is Nothing Then

                    e.DataSource = Me.DataSource

                Else
                    e.DataSource = dataSourceForEvaluate
                End If

                ' Define the calling control.  This is used to add other 
                ' related table and record controls as variables.
                e.CallingControl = Me

                Dim resultObj As Object = e.Evaluate(formula)
                If resultObj Is Nothing Then
                    Return ""
                End If

                If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                    Return FormulaUtils.Format(resultObj, format)
                Else
                    Return resultObj.ToString()
                End If
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
                Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
            End Function


            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
                Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
                Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
                Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
                Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
                Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
            End Function

            Public Overridable Function EvaluateFormula(ByVal formula As String) As String
                Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
            End Function


            Public Overridable Sub RegisterPostback()

                Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me, "SaveIncidentButton"))

            End Sub



            ' To customize, override this method in PartyIncidentRecordControl.
            Public Overridable Sub SaveData()
                ' Saves the associated record in the database.
                ' SaveData calls Validate and Get methods - so it may be more appropriate to
                ' customize those methods.

                ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
                ' that fields that are not displayed are also properly initialized.
                Me.LoadData()

                ' The checksum is used to ensure the record was not changed by another user.
                If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                    If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                        Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "FASTPORT"))
                    End If
                End If

                Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyIncidentRecordControlPanel"), System.Web.UI.WebControls.Panel)

                If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
                    Return
                End If


                ' 2. Perform any custom validation.
                Me.Validate()


                ' 3. Set the values in the record with data from UI controls.
                ' This calls the Get() method for each of the user interface controls.
                Me.GetUIData()

                ' 4. Save in the database.
                ' We should not save the record if the data did not change. This
                ' will save a database hit and avoid triggering any database triggers.

                If Me.DataSource.IsAnyValueChanged Then
                    ' Save record to database but do not commit yet.
                    ' Auto generated ids are available after saving for use by child (dependent) records.
                    Me.DataSource.Save()

                End If

                ' update session or cookie by formula


                ' Setting the DataChanged to True results in the page being refreshed with
                ' the most recent data from the database.  This happens in PreRender event
                ' based on the current sort, search and filter criteria.
                Me.DataChanged = True
                Me.ResetData = True

                Me.CheckSum = ""
                ' For Master-Detail relationships, save data on the Detail table(s)

                Dim recHeaderButtonsInclude As BaseApplicationUserControl = DirectCast(MiscUtils.FindControlRecursively(Me, "HeaderButtonsInclude"), BaseApplicationUserControl)
                recHeaderButtonsInclude.SaveData()

            End Sub

            ' To customize, override this method in PartyIncidentRecordControl.
            Public Overridable Sub GetUIData()
                ' The GetUIData method retrieves the updated values from the user interface 
                ' controls into a database record in preparation for saving or updating.
                ' To do this, it calls the Get methods for each of the field displayed on 
                ' the webpage.  It is better to make changes in the Get methods, rather 
                ' than making changes here.

                ' Call the Get methods for each of the user interface controls.

                GetAccidentLocationID()
                GetCargoTypeID()
                GetDetailedDescription()
                GetEqiupTypeID()
                GetEstimatedCost()
                GetFatalitiesOccured()
                GetFelonyIssued()
                GetFileClosed()
                GetIncidentCategoryID()
                GetIncidentExpiration()
                GetIncidentID()
                GetInjuriesOccured()
                GetIWasAtFault()
                GetLicenseSuspended()
                GetOccurredOn()
                GetPartyID()
                GetPhysicalLimitationExpiration()
                GetPhysicalObsolete()
                GetReinstatedOn()
                GetRuledAsRecklessDriving()
                GetSAPRelease()
                GetSAPReleaseDate()
                GetTicketed()
                GetTowAWayAccident()
            End Sub


            Public Overridable Sub GetAccidentLocationID()

                ' Retrieve the value entered by the user on the AccidentLocationID ASP:TextBox, and
                ' save it into the AccidentLocationID field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.AccidentLocationID.Text, PartyIncidentTable.AccidentLocationID)


            End Sub

            Public Overridable Sub GetCargoTypeID()

                ' Retrieve the value entered by the user on the CargoTypeID ASP:TextBox, and
                ' save it into the CargoTypeID field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.CargoTypeID.Text, PartyIncidentTable.CargoTypeID)


            End Sub

            Public Overridable Sub GetDetailedDescription()

                ' Retrieve the value entered by the user on the DetailedDescription ASP:TextBox, and
                ' save it into the DetailedDescription field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.DetailedDescription.Text, PartyIncidentTable.DetailedDescription)


            End Sub

            Public Overridable Sub GetEqiupTypeID()

                ' Retrieve the value entered by the user on the EqiupTypeID ASP:TextBox, and
                ' save it into the EqiupTypeID field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.EqiupTypeID.Text, PartyIncidentTable.EqiupTypeID)


            End Sub

            Public Overridable Sub GetEstimatedCost()

                ' Retrieve the value entered by the user on the EstimatedCost ASP:TextBox, and
                ' save it into the EstimatedCost field in DataSource PartyIncident record.
                ' Parse will also validate the amount to ensure it is of the proper format
                ' and valid.  The format is verified based on the current culture 
                ' settings including the currency symbol and decimal separator
                ' (no currency conversion is performed).
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.EstimatedCost.Text, PartyIncidentTable.EstimatedCost)


            End Sub

            Public Overridable Sub GetFatalitiesOccured()


                ' Retrieve the value entered by the user on the FatalitiesOccured ASP:CheckBox, and
                ' save it into the FatalitiesOccured field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.FatalitiesOccured = Me.FatalitiesOccured.Checked

            End Sub

            Public Overridable Sub GetFelonyIssued()


                ' Retrieve the value entered by the user on the FelonyIssued ASP:CheckBox, and
                ' save it into the FelonyIssued field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.FelonyIssued = Me.FelonyIssued.Checked

            End Sub

            Public Overridable Sub GetFileClosed()


                ' Retrieve the value entered by the user on the FileClosed ASP:CheckBox, and
                ' save it into the FileClosed field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.FileClosed = Me.FileClosed.Checked

            End Sub

            Public Overridable Sub GetIncidentCategoryID()

                ' Retrieve the value entered by the user on the IncidentCategoryID ASP:TextBox, and
                ' save it into the IncidentCategoryID field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.IncidentCategoryID.Text, PartyIncidentTable.IncidentCategoryID)


            End Sub

            Public Overridable Sub GetIncidentExpiration()

                ' Retrieve the value entered by the user on the IncidentExpiration ASP:TextBox, and
                ' save it into the IncidentExpiration field in DataSource PartyIncident record.
                ' Parse will also validate the date to ensure it is of the proper format
                ' and a valid date.  The format is verified based on the current culture 
                ' settings including the order of month, day and year and the separator character.
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.IncidentExpiration.Text, PartyIncidentTable.IncidentExpiration)


            End Sub

            Public Overridable Sub GetIncidentID()

            End Sub

            Public Overridable Sub GetInjuriesOccured()


                ' Retrieve the value entered by the user on the InjuriesOccured ASP:CheckBox, and
                ' save it into the InjuriesOccured field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.InjuriesOccured = Me.InjuriesOccured.Checked

            End Sub

            Public Overridable Sub GetIWasAtFault()


                ' Retrieve the value entered by the user on the IWasAtFault ASP:CheckBox, and
                ' save it into the IWasAtFault field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.IWasAtFault = Me.IWasAtFault.Checked

            End Sub

            Public Overridable Sub GetLicenseSuspended()


                ' Retrieve the value entered by the user on the LicenseSuspended ASP:CheckBox, and
                ' save it into the LicenseSuspended field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.LicenseSuspended = Me.LicenseSuspended.Checked

            End Sub

            Public Overridable Sub GetOccurredOn()

                ' Retrieve the value entered by the user on the OccurredOn ASP:TextBox, and
                ' save it into the OccurredOn field in DataSource PartyIncident record.
                ' Parse will also validate the date to ensure it is of the proper format
                ' and a valid date.  The format is verified based on the current culture 
                ' settings including the order of month, day and year and the separator character.
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.OccurredOn.Text, PartyIncidentTable.OccurredOn)


            End Sub

            Public Overridable Sub GetPartyID()

                ' Retrieve the value entered by the user on the PartyID ASP:TextBox, and
                ' save it into the PartyID field in DataSource PartyIncident record.

                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.PartyID.Text, PartyIncidentTable.PartyID)


            End Sub

            Public Overridable Sub GetPhysicalLimitationExpiration()

                ' Retrieve the value entered by the user on the PhysicalLimitationExpiration ASP:TextBox, and
                ' save it into the PhysicalLimitationExpiration field in DataSource PartyIncident record.
                ' Parse will also validate the date to ensure it is of the proper format
                ' and a valid date.  The format is verified based on the current culture 
                ' settings including the order of month, day and year and the separator character.
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.PhysicalLimitationExpiration.Text, PartyIncidentTable.PhysicalLimitationExpiration)


            End Sub

            Public Overridable Sub GetPhysicalObsolete()


                ' Retrieve the value entered by the user on the PhysicalObsolete ASP:CheckBox, and
                ' save it into the PhysicalObsolete field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.PhysicalObsolete = Me.PhysicalObsolete.Checked

            End Sub

            Public Overridable Sub GetReinstatedOn()

                ' Retrieve the value entered by the user on the ReinstatedOn ASP:TextBox, and
                ' save it into the ReinstatedOn field in DataSource PartyIncident record.
                ' Parse will also validate the date to ensure it is of the proper format
                ' and a valid date.  The format is verified based on the current culture 
                ' settings including the order of month, day and year and the separator character.
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.ReinstatedOn.Text, PartyIncidentTable.ReinstatedOn)


            End Sub

            Public Overridable Sub GetRuledAsRecklessDriving()


                ' Retrieve the value entered by the user on the RuledAsRecklessDriving ASP:CheckBox, and
                ' save it into the RuledAsRecklessDriving field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.RuledAsRecklessDriving = Me.RuledAsRecklessDriving.Checked

            End Sub

            Public Overridable Sub GetSAPRelease()


                ' Retrieve the value entered by the user on the SAPRelease ASP:CheckBox, and
                ' save it into the SAPRelease field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.SAPRelease = Me.SAPRelease.Checked

            End Sub

            Public Overridable Sub GetSAPReleaseDate()

                ' Retrieve the value entered by the user on the SAPReleaseDate ASP:TextBox, and
                ' save it into the SAPReleaseDate field in DataSource PartyIncident record.
                ' Parse will also validate the date to ensure it is of the proper format
                ' and a valid date.  The format is verified based on the current culture 
                ' settings including the order of month, day and year and the separator character.
                ' Parse throws an exception if the date is invalid.
                ' Custom validation should be performed in Validate, not here.

                'Save the value to data source
                Me.DataSource.Parse(Me.SAPReleaseDate.Text, PartyIncidentTable.SAPReleaseDate)


            End Sub

            Public Overridable Sub GetTicketed()


                ' Retrieve the value entered by the user on the Ticketed ASP:CheckBox, and
                ' save it into the Ticketed field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.Ticketed = Me.Ticketed.Checked

            End Sub

            Public Overridable Sub GetTowAWayAccident()


                ' Retrieve the value entered by the user on the TowAWayAccident ASP:CheckBox, and
                ' save it into the TowAWayAccident field in DataSource PartyIncident record.
                ' Custom validation should be performed in Validate, not here.


                Me.DataSource.TowAWayAccident = Me.TowAWayAccident.Checked

            End Sub


            ' To customize, override this method in PartyIncidentRecordControl.

            Public Overridable Function CreateWhereClause() As WhereClause

                Dim wc As WhereClause
                PartyIncidentTable.Instance.InnerFilter = Nothing
                wc = New WhereClause()

                ' Compose the WHERE clause consiting of:
                ' 1. Static clause defined at design time.
                ' 2. User selected filter criteria.
                ' 3. User selected search criteria.


                ' Retrieve the record id from the URL parameter.

                Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("PartyIncident"))

                If recId Is Nothing OrElse recId.Trim = "" Then
                    ' Get the error message from the application resource file.
                    Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "FASTPORT").Replace("{URL}", "PartyIncident"))
                End If
                HttpContext.Current.Session("QueryString in EditIncident") = recId

                If KeyValue.IsXmlKey(recId) Then
                    ' Keys are typically passed as XML structures to handle composite keys.
                    ' If XML, then add a Where clause based on the Primary Key in the XML.
                    Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)

                    wc.iAND(PartyIncidentTable.IncidentID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(PartyIncidentTable.IncidentID))

                Else
                    ' The URL parameter contains the actual value, not an XML structure.

                    wc.iAND(PartyIncidentTable.IncidentID, BaseFilter.ComparisonOperator.EqualsTo, recId)

                End If

                Return wc

            End Function

            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.

            Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
                PartyIncidentTable.Instance.InnerFilter = Nothing
                Dim wc As WhereClause = New WhereClause()

                ' Compose the WHERE clause consiting of:
                ' 1. Static clause defined at design time.
                ' 2. User selected filter criteria.
                ' 3. User selected search criteria.
                Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)


                ' Adds clauses if values are selected in Filter controls which are configured in the page.



                Return wc
            End Function


            'Formats the resultItem and adds it to the list of suggestions.
            Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                     ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                     ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                     ByVal resultList As ArrayList) As Boolean
                Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
                Dim itemToAdd As String = ""
                Dim isFound As Boolean = False
                Dim isAdded As Boolean = False
                ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
                If InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") And Not index = 0 Then
                    ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex1.IsMatch(resultItem) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                    If Not resultItem(index).ToString() = " " Then
                        ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                        If regex.IsMatch(resultItem) Then
                            index = regex.Match(resultItem).Index
                            isFound = True
                        End If
                    End If
                End If
                ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
                ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
                If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                    If InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring") Then
                        ' Expression to find beginning of the word which contains prefixText
                        Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                        '  Find the beginning of the word which contains prefexText
                        If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                            index = regex1.Match(resultItem).Index
                            isFound = True
                        End If
                        ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                        If Len(resultItem) - index <= columnLength Then
                            If index = 0 Then
                                itemToAdd = resultItem
                            Else
                                itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index)
                            End If
                        Else
                            If index = 0 Then
                                itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                            Else
                                'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                                itemToAdd = "..." & resultItem.Substring(index, columnLength - 6) & "..."
                            End If
                        End If
                    ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring") Then
                        Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                        If Len(resultItem) <= columnLength Then
                            itemToAdd = resultItem
                        Else
                            ' Sanity check at end of the string
                            If index + Len(prefixText) = columnLength Then
                                itemToAdd = "..." & resultItem.Substring(index - columnLength, index)
                            ElseIf Len(resultItem) - index < subStringBeginIndex Then
                                ' Display string from the end till columnLength value if, index is closer to the end of the string.
                                itemToAdd = "..." & resultItem.Substring(Len(resultItem) - columnLength, Len(resultItem))
                            ElseIf index <= subStringBeginIndex Then
                                ' Sanity chet at beginning of the string
                                itemToAdd = resultItem.Substring(0, columnLength) & "..."
                            Else
                                ' Display string containing text before the prefixText occures and text after the prefixText
                                itemToAdd = "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..."
                            End If
                        End If
                    ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring") Then
                        ' Expression to find ending of the word which contains prefexText
                        Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                        ' Find the ending of the word which contains prefexText
                        If regex1.IsMatch(resultItem, index + 1) Then
                            index = regex1.Match(resultItem, index + 1).Index
                        Else
                            ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                            index = resultItem.Length
                        End If
                        If index > Len(resultItem) Then
                            index = Len(resultItem)
                        End If
                        ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                        If index <= columnLength Then
                            If index = Len(resultItem) Then   'Make decision to append "..."
                                itemToAdd = resultItem.Substring(0, index)
                            Else
                                itemToAdd = resultItem.Substring(0, index) & "..."
                            End If
                        Else
                            If index = Len(resultItem) Then
                                itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                            Else
                                'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                                itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..."
                            End If
                        End If
                    End If

                    ' Remove newline character from itemToAdd
                    Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                    ' If itemToAdd contains any newline after the search text then show text only till newline
                    Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    Dim newLineIndexAfterPrefix As Integer = -1
                    If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                        newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                    End If
                    If (newLineIndexAfterPrefix > -1) Then
                        If itemToAdd.EndsWith("...") Then
                            itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                        Else
                            itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                        End If
                    End If
                    ' If itemToAdd contains any newline before search text then show text which comes after newline
                    Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                    Dim newLineIndexBeforePrefix As Integer = -1
                    If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                        newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                    End If
                    If (newLineIndexBeforePrefix > -1) Then
                        If itemToAdd.StartsWith("...") Then
                            itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                        Else
                            itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                        End If
                    End If

                    If Not itemToAdd Is Nothing AndAlso Not resultList.Contains(itemToAdd) Then
                        resultList.Add(itemToAdd)
                        isAdded = True
                    End If
                End If
                Return isAdded
            End Function



            ' To customize, override this method in PartyIncidentRecordControl.
            Public Overridable Sub Validate()
                ' Add custom validation for any control within this panel.
                ' Example.  If you have a State ASP:Textbox control
                ' If Me.State.Text <> "CA" Then
                '    Throw New Exception("State must be CA (California).")
                ' End If

                ' The Validate method is common across all controls within
                ' this panel so you can validate multiple fields, but report
                ' one error message.


            End Sub

            Public Overridable Sub Delete()

                If Me.IsNewRecord() Then
                    Return
                End If

                Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
                PartyIncidentTable.DeleteRecord(pkValue)

            End Sub

            Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
                ' PreRender event is raised just before page is being displayed.
                Try
                    DbUtils.StartTransaction()
                    Me.RegisterPostback()

                    If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then


                        ' Re-load the data and update the web page if necessary.
                        ' This is typically done during a postback (filter, search button, sort, pagination button).
                        ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                        Me.LoadData()
                        Me.DataBind()
                    End If


                Catch ex As Exception
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
                Finally
                    DbUtils.EndTransaction()
                End Try
            End Sub


            Protected Overrides Sub SaveControlsToSession()
                MyBase.SaveControlsToSession()


                'Save pagination state to session.

            End Sub



            Protected Overrides Sub ClearControlsFromSession()
                MyBase.ClearControlsFromSession()



                ' Clear pagination state from session.

            End Sub

            Protected Overrides Sub LoadViewState(ByVal savedState As Object)
                MyBase.LoadViewState(savedState)
                Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
                If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                    Me.IsNewRecord = Boolean.Parse(isNewRecord)
                End If

                Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
                If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                    Me.CheckSum = myCheckSum
                End If


                ' Load view state for pagination control.

            End Sub

            Protected Overrides Function SaveViewState() As Object
                ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
                ViewState("CheckSum") = Me.CheckSum


                ' Load view state for pagination control.

                Return MyBase.SaveViewState()
            End Function


            ' Generate the event handling functions for pagination events.


            ' Generate the event handling functions for filter and search events.

            ' event handler for Button with Layout
            Public Overridable Sub BackToMainButton_Click(ByVal sender As Object, ByVal args As EventArgs)

                Try

                Catch ex As Exception
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally

                End Try

            End Sub

            ' event handler for Button with Layout
            Public Overridable Sub BackToPreviousTabButton_Click(ByVal sender As Object, ByVal args As EventArgs)

                Try

                Catch ex As Exception
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally

                End Try

            End Sub

            ' event handler for Button with Layout
            Public Overridable Sub Next2Button_Click(ByVal sender As Object, ByVal args As EventArgs)

                Try

                Catch ex As Exception
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally

                End Try

            End Sub

            ' event handler for Button with Layout
            Public Overridable Sub NextButton_Click(ByVal sender As Object, ByVal args As EventArgs)

                Try

                Catch ex As Exception
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally

                End Try

            End Sub

            ' event handler for Button with Layout
            Public Overridable Sub SaveIncidentButton_Click(ByVal sender As Object, ByVal args As EventArgs)

                Dim shouldRedirect As Boolean = True
                Dim TargetKey As String = Nothing
                Dim DFKA As String = TargetKey
                Dim id As String = DFKA
                Dim value As String = id

                Try
                    ' Enclose all database retrieval/update code within a Transaction boundary
                    DbUtils.StartTransaction()


                    If (Not Me.Page.IsPageRefresh) Then
                        Me.Page.SaveData()
                    End If

                    Me.Page.CommitTransaction(sender)
                    TargetKey = Me.Page.Request.QueryString.Item("Target")

                    If Not TargetKey Is Nothing Then

                        DFKA = NetUtils.GetUrlParam(Me, "DFKA", False)
                        If Not Me Is Nothing AndAlso Not Me.DataSource Is Nothing Then

                            id = Me.DataSource.IncidentID.ToString
                            If Not String.IsNullOrEmpty(DFKA) Then
                                If DFKA.Trim().StartsWith("=") Then
                                    Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)()
                                    variables.Add(Me.DataSource.TableAccess.TableDefinition.TableCodeName, Me.DataSource)
                                    value = EvaluateFormula(DFKA, Me.DataSource, Nothing, variables)
                                Else
                                    value = Me.DataSource.GetValue(Me.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(DFKA)).ToString
                                End If
                            End If
                            If value Is Nothing Then
                                value = id
                            End If

                            Dim Formula As String = Me.Page.Request.QueryString.Item("Formula")
                            If Not Formula Is Nothing Then
                                Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)()
                                variables.Add(Me.DataSource.TableAccess.TableDefinition.TableCodeName, Me.DataSource)
                                value = EvaluateFormula(Formula, Me.DataSource, Nothing, variables)
                            End If

                            BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(Me, TargetKey, id, value)
                        End If
                        shouldRedirect = False
                    End If

                Catch ex As Exception
                    ' Upon error, rollback the transaction
                    Me.Page.RollBackTransaction(sender)
                    shouldRedirect = False
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally
                    DbUtils.EndTransaction()
                End Try

                If shouldRedirect Then
                    Me.Page.ShouldSaveControlsToSession = True
                    Me.Page.CloseWindow(True)
                ElseIf Not TargetKey Is Nothing AndAlso _
                            Not shouldRedirect Then
                    Me.Page.ShouldSaveControlsToSession = True
                    Me.Page.CloseWindow(True)

                End If
            End Sub

            Protected Overridable Sub CancelIncidentButton_Click(ByVal sender As Object, ByVal args As EventArgs)

                Me.Page.CloseWindow(True)

            End Sub

            Protected Overridable Sub FatalitiesOccured_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub FelonyIssued_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub FileClosed_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub InjuriesOccured_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub IWasAtFault_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub LicenseSuspended_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub PhysicalObsolete_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub RuledAsRecklessDriving_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub SAPRelease_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub Ticketed_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub TowAWayAccident_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)


            End Sub

            Protected Overridable Sub AccidentLocationID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub CargoTypeID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub DetailedDescription_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub EqiupTypeID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub EstimatedCost_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub IncidentCategoryID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub IncidentExpiration_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub OccurredOn_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub PartyID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub PhysicalLimitationExpiration_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub ReinstatedOn_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub

            Protected Overridable Sub SAPReleaseDate_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

            End Sub


            Private _PreviousUIData As New Hashtable
            Public Overridable Property PreviousUIData() As Hashtable
                Get
                    Return _PreviousUIData
                End Get
                Set(ByVal value As Hashtable)
                    _PreviousUIData = value
                End Set
            End Property

            Private _IsNewRecord As Boolean = True
            Public Overridable Property IsNewRecord() As Boolean
                Get
                    Return Me._IsNewRecord
                End Get
                Set(ByVal value As Boolean)
                    Me._IsNewRecord = value
                End Set
            End Property

            Private _DataChanged As Boolean = False
            Public Overridable Property DataChanged() As Boolean
                Get
                    Return Me._DataChanged
                End Get
                Set(ByVal Value As Boolean)
                    Me._DataChanged = Value
                End Set
            End Property

            Private _ResetData As Boolean = False
            Public Overridable Property ResetData() As Boolean
                Get
                    Return Me._ResetData
                End Get
                Set(ByVal Value As Boolean)
                    Me._ResetData = Value
                End Set
            End Property

            Public Property RecordUniqueId() As String
                Get
                    Return CType(Me.ViewState("BasePartyIncidentRecordControl_Rec"), String)
                End Get
                Set(ByVal value As String)
                    Me.ViewState("BasePartyIncidentRecordControl_Rec") = value
                End Set
            End Property

            Private _DataSource As PartyIncidentRecord
            Public Property DataSource() As PartyIncidentRecord
                Get
                    Return Me._DataSource
                End Get

                Set(ByVal value As PartyIncidentRecord)

                    Me._DataSource = value
                End Set
            End Property



            Private _checkSum As String
            Public Overridable Property CheckSum() As String
                Get
                    Return Me._checkSum
                End Get
                Set(ByVal value As String)
                    Me._checkSum = value
                End Set
            End Property

            Private _TotalPages As Integer
            Public Property TotalPages() As Integer
                Get
                    Return Me._TotalPages
                End Get
                Set(ByVal value As Integer)
                    Me._TotalPages = value
                End Set
            End Property

            Private _PageIndex As Integer
            Public Property PageIndex() As Integer
                Get
                    ' Return the PageIndex
                    Return Me._PageIndex
                End Get
                Set(ByVal value As Integer)
                    Me._PageIndex = value
                End Set
            End Property

            Private _PageSize As Integer
            Public Property PageSize() As Integer
                Get
                    Return Me._PageSize
                End Get
                Set(ByVal value As Integer)
                    Me._PageSize = value
                End Set
            End Property

            Private _TotalRecords As Integer
            Public Property TotalRecords() As Integer
                Get
                    Return Me._TotalRecords
                End Get
                Set(ByVal value As Integer)
                    If Me.PageSize > 0 Then
                        Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                    End If

                    Me._TotalRecords = value
                End Set
            End Property

            Private _DisplayLastPage As Boolean
            Public Property DisplayLastPage() As Boolean
                Get
                    Return Me._DisplayLastPage
                End Get
                Set(ByVal value As Boolean)
                    Me._DisplayLastPage = value
                End Set
            End Property



#Region "Helper Properties"

            Public ReadOnly Property AccidentLocationID() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AccidentLocationID"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property AccidentLocationIDLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AccidentLocationIDLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property BackToMainButton() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BackToMainButton"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property BackToPreviousTabButton() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BackToPreviousTabButton"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property CargoDS() As System.Web.UI.WebControls.SqlDataSource
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CargoDS"), System.Web.UI.WebControls.SqlDataSource)
                End Get
            End Property

            Public ReadOnly Property CargoTypeID() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CargoTypeID"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property CargoTypeIDLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CargoTypeIDLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property DescInstructionsLiteral() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DescInstructionsLiteral"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property DetailedDescription() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DetailedDescription"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property EqiupTypeID() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EqiupTypeID"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property EqiupTypeIDLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EqiupTypeIDLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property EquipDS() As System.Web.UI.WebControls.SqlDataSource
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EquipDS"), System.Web.UI.WebControls.SqlDataSource)
                End Get
            End Property

            Public ReadOnly Property EstimatedCost() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EstimatedCost"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property EstimatedCostLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EstimatedCostLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property FatalitiesOccured() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FatalitiesOccured"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property FatalitiesOccuredLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FatalitiesOccuredLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property FelonyIssued() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FelonyIssued"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property FelonyIssuedLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FelonyIssuedLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property FileClosed() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FileClosed"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property FileClosedLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FileClosedLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property IncidentCategoryID() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IncidentCategoryID"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property IncidentExpiration() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IncidentExpiration"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property IncidentExpirationLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IncidentExpirationLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property IncidentID() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IncidentID"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property IncidentPathLiteral() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IncidentPathLiteral"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property InjuriesOccured() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "InjuriesOccured"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property InjuriesOccuredLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "InjuriesOccuredLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property IWasAtFault() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IWasAtFault"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property IWasAtFaultLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "IWasAtFaultLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property LicenseSuspended() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LicenseSuspended"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property LicenseSuspendedLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LicenseSuspendedLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property MainScrollPanel() As System.Web.UI.WebControls.Panel
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MainScrollPanel"), System.Web.UI.WebControls.Panel)
                End Get
            End Property

            Public ReadOnly Property Next2Button() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Next2Button"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property NextButton() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NextButton"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property OccurredOn() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OccurredOn"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property OccurredOnLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OccurredOnLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property PartyID() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyID"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property PhysicalLimitationExpiration() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PhysicalLimitationExpiration"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property PhysicalLimitationExpirationLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PhysicalLimitationExpirationLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property PhysicalObsolete() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PhysicalObsolete"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property PhysicalObsoleteLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PhysicalObsoleteLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property ReinstatedOn() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ReinstatedOn"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property ReinstatedOnLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ReinstatedOnLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property RuledAsRecklessDriving() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RuledAsRecklessDriving"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property RuledAsRecklessDrivingLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RuledAsRecklessDrivingLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property SAPRelease() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SAPRelease"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property SAPReleaseDate() As System.Web.UI.WebControls.TextBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SAPReleaseDate"), System.Web.UI.WebControls.TextBox)
                End Get
            End Property

            Public ReadOnly Property SAPReleaseDateLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SAPReleaseDateLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property SAPReleaseLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SAPReleaseLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property SaveIncidentButton() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SaveIncidentButton"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property CancelIncidentButton() As FASTPORT.UI.IThemeButton
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CancelIncidentButton"), FASTPORT.UI.IThemeButton)
                End Get
            End Property

            Public ReadOnly Property Ticketed() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Ticketed"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property TicketedLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TicketedLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property TicketedForRAC() As Telerik.Web.UI.RadAutoCompleteBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TicketedForRAC"), Telerik.Web.UI.RadAutoCompleteBox)
                End Get
            End Property

            Public ReadOnly Property TicketedForLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TicketedForLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

            Public ReadOnly Property TowAWayAccident() As System.Web.UI.WebControls.CheckBox
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TowAWayAccident"), System.Web.UI.WebControls.CheckBox)
                End Get
            End Property

            Public ReadOnly Property TowAWayAccidentLabel() As System.Web.UI.WebControls.Literal
                Get
                    Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TowAWayAccidentLabel"), System.Web.UI.WebControls.Literal)
                End Get
            End Property

#End Region

#Region "Helper Functions"

            Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
                Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
            End Function

            Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String

                Dim rec As PartyIncidentRecord = Nothing


                Try
                    rec = Me.GetRecord()
                Catch ex As Exception
                    ' Do nothing
                End Try

                If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.

                    Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "FASTPORT"))

                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End Function


            Public Overridable Function GetRecord() As PartyIncidentRecord
                If Not Me.DataSource Is Nothing Then
                    Return Me.DataSource
                End If

                If Not Me.RecordUniqueId Is Nothing Then

                    Return PartyIncidentTable.GetRecord(Me.RecordUniqueId, True)

                End If

                ' Localization.

                Throw New Exception(Page.GetResourceValue("Err:RetrieveRec", "FASTPORT"))

            End Function

            Public Shadows ReadOnly Property Page() As BaseApplicationPage
                Get
                    Return DirectCast(MyBase.Page, BaseApplicationPage)
                End Get
            End Property

#End Region

        End Class



#End Region


    End Class
  
End Namespace
  