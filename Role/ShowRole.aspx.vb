﻿
' This file implements the code-behind class for ShowRole.aspx.
' ShowRole.Controls.vb contains the Table, Row and Record control classes
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
  
Partial Public Class ShowRole
        Inherits BaseApplicationPage
' Code-behind class for the ShowRole page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."
    
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
    
        Public Sub EditButton_Click(ByVal sender As Object, ByVal args As EventArgs)
          ' Click handler for EditButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          EditButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
            
        Public Sub OKButton_Click(ByVal sender As Object, ByVal args As EventArgs)
          ' Click handler for OKButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          OKButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
            

        ' Write out the Set methods
        
        
        ' Write out the methods for DataSource
        

#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents AdIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents AgreementButtonsButton As ThemeButtonWithArrow
        Public WithEvents AgreementExportExcelButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents AgreementFileNameSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents AgreementFiltersButton As ThemeButtonWithArrow
        Public WithEvents AgreementImportButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents AgreementNewButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents AgreementPagination As PaginationModern
        Public WithEvents AgreementPDFButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents AgreementSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents AgreementTableControl As FASTPORT.UI.Controls.ShowRole.AgreementTableControl
        Public WithEvents AgreementWordButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents AlwaysShowSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents CarrierAdContactsButtonsButton As ThemeButtonWithArrow
        Public WithEvents CarrierAdContactsExportExcelButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents CarrierAdContactsFiltersButton As ThemeButtonWithArrow
        Public WithEvents CarrierAdContactsImportButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents CarrierAdContactsNewButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents CarrierAdContactsPagination As PaginationModern
        Public WithEvents CarrierAdContactsPDFButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents CarrierAdContactsTableControl As FASTPORT.UI.Controls.ShowRole.CarrierAdContactsTableControl
        Public WithEvents CarrierAdContactsWordButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents CIXSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents CIXSortLabel1 As System.Web.UI.WebControls.LinkButton
        Public WithEvents ContactTypeIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents CreatedAtSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents CreatedAtSortLabel1 As System.Web.UI.WebControls.LinkButton
        Public WithEvents CreatedByIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents CustomIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocIndexSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocNameSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocRankSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocSortSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocTreeButtonsButton As ThemeButtonWithArrow
        Public WithEvents DocTreeExportExcelButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents DocTreeFiltersButton As ThemeButtonWithArrow
        Public WithEvents DocTreeImportButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents DocTreeNewButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents DocTreePagination As PaginationModern
        Public WithEvents DocTreeParentIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocTreeParentIDSortLabel1 As System.Web.UI.WebControls.LinkButton
        Public WithEvents DocTreePDFButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents DocTreeTableControl As FASTPORT.UI.Controls.ShowRole.DocTreeTableControl
        Public WithEvents DocTreeWordButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents DocTypeIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents EditButton As ThemeButton
        Public WithEvents FlowCollectionIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents FolderSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents GeneralRoleID As System.Web.UI.WebControls.LinkButton
        Public WithEvents GeneralRoleIDLabel As System.Web.UI.WebControls.Literal
        Public WithEvents OKButton As ThemeButton
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents PartyIDSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents Role As System.Web.UI.WebControls.Literal
        Public WithEvents RoleDescription As System.Web.UI.WebControls.Literal
        Public WithEvents RoleDescriptionLabel As System.Web.UI.WebControls.Literal
        Public WithEvents RoleDialogEditButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents RoleLabel As System.Web.UI.WebControls.Literal
        Public WithEvents RoleRank As System.Web.UI.WebControls.Literal
        Public WithEvents RoleRankLabel As System.Web.UI.WebControls.Literal
        Public WithEvents RoleRecordControl As FASTPORT.UI.Controls.ShowRole.RoleRecordControl
        Public WithEvents RoleTitle As System.Web.UI.WebControls.Literal
        Public WithEvents RoleTypeID As System.Web.UI.WebControls.Literal
        Public WithEvents RoleTypeIDLabel As System.Web.UI.WebControls.Literal
        Public WithEvents UpdatedAtSortLabel As System.Web.UI.WebControls.LinkButton
        Public WithEvents UpdatedAtSortLabel1 As System.Web.UI.WebControls.LinkButton
        Public WithEvents ValidationSummary1 As ValidationSummary
    
  
        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)            		
           
            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
                 
    
            ' the following code for accordion is necessary or the Me.{ControlName} will return Nothing
        
            ' Register the Event handler for any Events.
      

          ' Setup the pagination events.
        
            AddHandler Me.EditButton.Button.Click, AddressOf EditButton_Click
        
            AddHandler Me.OKButton.Button.Click, AddressOf OKButton_Click
        
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
            Me.Authorize("20")
    
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
        
        
            Page.Title = "Role"
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
              
        Me.RoleRecordControl.SaveData()
        
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
                        
        Me.RoleRecordControl.LoadData()
        Me.RoleRecordControl.DataBind()
        
    
                ' Load data for chart.
                
            
                ' initialize aspx controls
                
                'Set the corresponding menu item to be highlighted for this page
                Dim pageMaster As System.Web.UI.MasterPage = Me.Master
                If Not pageMaster is Nothing Then
                    Dim menuComponent As IMenuComponent = CType(Me.Master.FindControl("_Menu"), IMenuComponent)
                    If Not menuComponent is Nothing Then
                        menuComponent.HiliteSettings = "RoleMenuItem"
                    End If
                End If
      
                

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
        
        ' event handler for Button with Layout
        Public Sub EditButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Role/EditRole.aspx?Role={PK}"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
      url = Me.ModifyRedirectUrl(url, "",True)
              
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.RollBackTransaction(sender)
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub OKButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    

                TargetKey = Me.Page.Request.QueryString.Item("Target")
                If Not TargetKey Is Nothing Then
                   shouldRedirect = False
                End If
      
            Catch ex As Exception
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.RedirectBack()
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
                
    
#End Region

  
End Class
  
End Namespace
  