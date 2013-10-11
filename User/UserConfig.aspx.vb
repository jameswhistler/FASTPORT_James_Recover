﻿
' This file implements the code-behind class for UserConfig.aspx.
' UserConfig.Controls.vb contains the Table, Row and Record control classes
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
        

#End Region

  
Namespace FASTPORT.UI
  
Partial Public Class UserConfig
        Inherits BaseApplicationPage
' Code-behind class for the UserConfig page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."

        Protected WithEvents EmailRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents MobileRTB As Global.Telerik.Web.UI.RadMaskedTextBox
        Protected WithEvents PasswordRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents NameRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents DirectDialRTB As Global.Telerik.Web.UI.RadMaskedTextBox
        Protected WithEvents FaxRTB As Global.Telerik.Web.UI.RadMaskedTextBox
        Protected WithEvents HiddenTB_PartyID As System.Web.UI.WebControls.TextBox
        Protected WithEvents HiddenTB_PaymentMethodID As System.Web.UI.WebControls.TextBox
        Protected WithEvents PaymentMethodRadGrid As Global.Telerik.Web.UI.RadGrid
        Protected WithEvents CreditCardPanel As System.Web.UI.WebControls.Panel
        Protected WithEvents BankAccountPanel As System.Web.UI.WebControls.Panel
        Protected WithEvents CarrierPanel As System.Web.UI.WebControls.Panel
        Protected WithEvents RolePanel As System.Web.UI.WebControls.Panel
        Protected WithEvents UserPanel As System.Web.UI.WebControls.Panel
        Protected WithEvents CreditCardTypeRDDL As Global.Telerik.Web.UI.RadDropDownList
        Protected WithEvents CreditCardNumberRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents CreditCardNameRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents StartDateRTB As Global.Telerik.Web.UI.RadMaskedTextBox
        Protected WithEvents EndDateRTB As Global.Telerik.Web.UI.RadMaskedTextBox
        Protected WithEvents CVVRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents BankAccountNumberRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents BankSortCodeRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents BankAccountNameRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents BankPaymentReferenceRTB As Global.Telerik.Web.UI.RadTextBox
        Protected WithEvents AllCarriersRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents SpecificCarriersRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents OnlyMeRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents EveryoneRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents SpecificRolesRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents SpecificPeopleRB As Global.Telerik.Web.UI.RadButton
        Protected WithEvents UserRLB As Global.Telerik.Web.UI.RadListBox
        Protected WithEvents RoleRLB As Global.Telerik.Web.UI.RadListBox
        Protected WithEvents CarrierRLB As Global.Telerik.Web.UI.RadListBox

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

        Protected Sub PaymentMethodRadGrid_ItemCommand(ByVal source As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles PaymentMethodRadGrid.ItemCommand

            If (e.CommandName = "RowClick") Then
                Dim myPaymentMethodID As String = (DirectCast(e.Item, Telerik.Web.UI.GridDataItem)).GetDataKeyValue("PaymentMethodID").ToString()
                Dim myPaymentMethodType As String = (DirectCast(e.Item, Telerik.Web.UI.GridDataItem)).GetDataKeyValue("PaymentMethodType").ToString()

                'Set the hidden text field for this PaymentMethod
                Me.HiddenTB_PaymentMethodID.Text = myPaymentMethodID

                Dim myPaymentMethodRec As PaymentMethodRecord = PaymentMethodTable.GetRecord(myPaymentMethodID, False)
                If myPaymentMethodType = "CC" Then
                    CreditCard_DataBind(myPaymentMethodRec)
                Else
                    BankAccount_DataBind(myPaymentMethodRec)
                End If

            End If
        End Sub

        Protected Sub PaymentMethodRadGrid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaymentMethodRadGrid.SelectedIndexChanged
            Dim myPaymentMethodID As String = DirectCast(PaymentMethodRadGrid.SelectedItems(0), Telerik.Web.UI.GridDataItem).GetDataKeyValue("CustomerID").ToString()
        End Sub

        Public Sub CreditCard_DataBind(ByVal myPaymentMethodRec As PaymentMethodRecord)

            CreditCardPanel.Visible = True
            BankAccountPanel.Visible = False

            Me.CreditCardTypeRDDL.SelectedIndex = Me.CreditCardTypeRDDL.FindItemByValue(myPaymentMethodRec.CreditCardTypeID.ToString).Index
            Me.CreditCardNumberRTB.Text = myPaymentMethodRec.CreditCardNumber
            Me.CreditCardNameRTB.Text = myPaymentMethodRec.CreditCardName
            Me.StartDateRTB.Text = myPaymentMethodRec.StartDate.ToString("mm/yy")
            Me.EndDateRTB.Text = myPaymentMethodRec.ExpiryDate.ToString("mm/yy")
            Me.CVVRTB.Text = myPaymentMethodRec.CVV

            CarriersAndParties_DataBind(myPaymentMethodRec)

        End Sub

        Public Sub BankAccount_DataBind(ByVal myPaymentMethodRec As PaymentMethodRecord)

            CreditCardPanel.Visible = False
            BankAccountPanel.Visible = True

            Me.BankAccountNumberRTB.Text = myPaymentMethodRec.BankAccountNumber
            Me.BankSortCodeRTB.Text = myPaymentMethodRec.BankSortCode
            Me.BankAccountNameRTB.Text = myPaymentMethodRec.BankAccountName
            Me.BankPaymentReferenceRTB.Text = myPaymentMethodRec.BankPaymentReference

            CarriersAndParties_DataBind(myPaymentMethodRec)
        End Sub

        Public Sub CarriersAndParties_DataBind(ByVal myPaymentMethodRec As PaymentMethodRecord)

            Select Case myPaymentMethodRec.CarrierAvailabilityID
                Case 2639
                    Me.AllCarriersRB.Checked = True
                    CarrierPanel.Visible = False
                Case 2640
                    Me.SpecificCarriersRB.Checked = True
                    CarrierRLB.DataBind()
                    CarrierPanel.Visible = True
                Case Else
                    Me.AllCarriersRB.Checked = False
                    Me.SpecificCarriersRB.Checked = False
                    CarrierPanel.Visible = False
            End Select

            Select Case myPaymentMethodRec.PartyAvailabilityID
                Case 2641
                    Me.OnlyMeRB.Checked = True
                    RolePanel.Visible = False
                    UserPanel.Visible = False
                Case 2642
                    Me.EveryoneRB.Checked = True
                    RolePanel.Visible = False
                    UserPanel.Visible = False
                Case 2643
                    Me.SpecificRolesRB.Checked = True
                    RoleRLB.DataBind()
                    RolePanel.Visible = True
                    UserPanel.Visible = False
                Case 2644
                    Me.SpecificPeopleRB.Checked = True
                    UserRLB.DataBind()
                    UserPanel.Visible = True
                    RolePanel.Visible = False
                Case Else
                    Me.OnlyMeRB.Checked = False
                    Me.EveryoneRB.Checked = False
                    Me.SpecificRolesRB.Checked = False
                    Me.SpecificPeopleRB.Checked = False
                    RolePanel.Visible = False
                    UserPanel.Visible = False
            End Select
            
        End Sub

        Protected Sub UserRLB_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadListBoxItemEventArgs)

            Dim dataSourceRow As DataRowView = DirectCast(e.Item.DataItem, DataRowView)

            If Me.HiddenTB_PaymentMethodID.Text <> "" Then

                ' We need to check whether this user has a PaymentMethodParty row for this PaymentMethod.
                ' If so, we check the box

                Dim myPaymentMethodPartyWhereStr As String = PaymentMethodPartyTable.PaymentMethodID.UniqueName & " = " & Me.HiddenTB_PaymentMethodID.Text & " AND " & PaymentMethodPartyTable.PartyID.UniqueName & " = " & dataSourceRow("OtherUserID").ToString
                Dim myPaymentMethodPartyRec As PaymentMethodPartyRecord = PaymentMethodPartyTable.GetRecord(myPaymentMethodPartyWhereStr)

                If Not IsNothing(myPaymentMethodPartyRec) Then
                    e.Item.Checked = True
                Else
                    e.Item.Checked = False
                End If
            End If

        End Sub

        Protected Sub RoleRLB_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadListBoxItemEventArgs)

            Dim dataSourceRow As DataRowView = DirectCast(e.Item.DataItem, DataRowView)

            If Me.HiddenTB_PaymentMethodID.Text <> "" Then

                ' We need to check whether all users with this role, for this ParentParty, have the ability to use this account.
                ' If any of them don't, then we don't check the box

                Dim CheckTheBox As Boolean = True

                Dim myPartyUserRolesWhereStr As String = V_PartyUserRolesView.RoleID.UniqueName & " = " & dataSourceRow("RoleID").ToString & " AND " & V_PartyUserRolesView.PartyID.UniqueName & " = " & dataSourceRow("ParentPartyID").ToString
                For Each myPartyUserRoleRec As V_PartyUserRolesRecord In V_PartyUserRolesView.GetRecords(myPartyUserRolesWhereStr)

                    ' We have a user's party PK.  Read the PaymentMethodParty table to see if it exists

                    Dim myPaymentMethodPartyWhereStr As String = PaymentMethodPartyTable.PaymentMethodID.UniqueName & " = " & Me.HiddenTB_PaymentMethodID.Text & " AND " & PaymentMethodPartyTable.PartyID.UniqueName & " = " & myPartyUserRoleRec.UserId0
                    Dim myPaymentMethodPartyRec As PaymentMethodPartyRecord = PaymentMethodPartyTable.GetRecord(myPaymentMethodPartyWhereStr)

                    If IsNothing(myPaymentMethodPartyRec) Then
                        CheckTheBox = False
                    End If
                Next

                If CheckTheBox Then
                    e.Item.Checked = True
                Else
                    e.Item.Checked = False
                End If

            End If

        End Sub

        Protected Sub CarrierRLB_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadListBoxItemEventArgs)

            Dim dataSourceRow As DataRowView = DirectCast(e.Item.DataItem, DataRowView)

            If Me.HiddenTB_PaymentMethodID.Text <> "" Then

                ' We need to check whether this carrier has a PaymentMethodCarrier row for this PaymentMethod.
                ' If so, we check the box

                Dim myPaymentMethodCarrierWhereStr As String = PaymentMethodCarrierTable.PaymentMethodID.UniqueName & " = " & Me.HiddenTB_PaymentMethodID.Text & " AND " & PaymentMethodCarrierTable.CarrierID.UniqueName & " = " & dataSourceRow("CarrierID").ToString
                For Each myPaymentMethodCarrierRec As PaymentMethodCarrierRecord In PaymentMethodCarrierTable.GetRecords(myPaymentMethodCarrierWhereStr)
                    If Not IsNothing(myPaymentMethodCarrierRec) Then
                        e.Item.Checked = True
                    Else
                        e.Item.Checked = False
                    End If
                Next

            End If

        End Sub

        Public Sub s_Vis()

            EmailRTB.Text = Me.PartyRecordControl.Email.Text
            MobileRTB.Text = Me.PartyRecordControl.Mobile.Text
            PasswordRTB.Text = Me.PartyRecordControl.Password.Text
            NameRTB.Text = Me.PartyRecordControl.Name.Text
            DirectDialRTB.Text = Me.PartyRecordControl.DirectDial.Text
            FaxRTB.Text = Me.PartyRecordControl.Fax.Text

            Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            Dim myPartyID As String = Me.Page.Request.QueryString("Party")
            If Not String.IsNullOrEmpty(myPartyID) Then
                myPartyID = CustGenClass.f_Decrypt(myPartyID)
            Else
                myPartyID = myMeID
            End If

            'If no party from URL, the party for this page is also the user.
            If String.IsNullOrEmpty(myPartyID) Then
                myPartyID = myMeID
            End If

            'Set the hidden text field used by all controls needing the FASTPORT party.
            Me.HiddenTB_PartyID.Text = myPartyID

            ' Hide other panels
            CreditCardPanel.Visible = False
            BankAccountPanel.Visible = False
            CarrierPanel.Visible = False
            RolePanel.Visible = False
            UserPanel.Visible = False

        End Sub
       
      Public Sub LoadData()
          ' LoadData reads database data and assigns it to UI controls.
          ' Customize by adding code before or after the call to LoadData_Base()
          ' or replace the call to LoadData_Base().
            LoadData_Base()
            s_Vis()
                  
      End Sub
      
      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS as Boolean) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
      End Function

      Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
           Me.Page_InitializeEventHandlers_Base(sender,e)
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
          Me.Page_PreRender_Base(sender,e)
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

    ' Page Event Handlers - buttons, sort, links
    

        ' Write out the Set methods
        
        
        ' Write out the methods for DataSource
        

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents AddrDeleteIB As System.Web.UI.WebControls.ImageButton
        Public WithEvents AddrDS As System.Web.UI.WebControls.SqlDataSource
        Public WithEvents DirectDialLabel As System.Web.UI.WebControls.Literal
        Public WithEvents EmailLabel As System.Web.UI.WebControls.Literal
        Public WithEvents emailValidator As System.Web.UI.WebControls.RegularExpressionValidator
        Public WithEvents FaxLabel As System.Web.UI.WebControls.Literal
        Public WithEvents MobileLabel As System.Web.UI.WebControls.Literal
        Public WithEvents NameLabel As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents PartyRecordControl As FASTPORT.UI.Controls.UserConfig.PartyRecordControl
        Public WithEvents PasswordLabel As System.Web.UI.WebControls.Literal
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
            Me.Authorize("")
    
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
        
        
            Page.Title = "Blank page"
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
        Dim content as String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)
    
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
              
        Me.PartyRecordControl.SaveData()
        
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
              
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack")  Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If

              
     
                Me.DataBind()

                ' Load and bind data for each record and table UI control.
                        
        Me.PartyRecordControl.LoadData()
        Me.PartyRecordControl.DataBind()
        
    
                ' Load data for chart.
                
            
                ' initialize aspx controls
                
                

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack")  Then
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

            If includeDS
                
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

  
End Class
  
End Namespace
  