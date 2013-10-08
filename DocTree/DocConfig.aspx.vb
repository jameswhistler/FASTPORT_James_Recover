
' This file implements the code-behind class for DocConfig.aspx.
' DocConfig.Controls.vb contains the Table, Row and Record control classes
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
  
Partial Public Class DocConfig
        Inherits BaseApplicationPage
        Implements System.Web.UI.ICallbackEventHandler

        ' Code-behind class for the SigsDashboard page.
        ' Place your customizations in Section 1. Do not modify Section 2.

#Region "Section 1: Place your customizations here."


        Protected WithEvents RadAjaxManager1 As RadAjaxManager
        Protected WithEvents DocConfigRTV As RadTreeView
        Protected WithEvents RadWindowManager1 As RadWindowManager
        Protected WithEvents PartiesRCB As RadComboBox
        Protected WithEvents GeneralRolesRCB As RadComboBox
        Protected WithEvents SearchDocsRCB As RadComboBox

        ' hold callback return value
        Private returnValue As String

        Public Function GetCallbackResult() As String Implements System.Web.UI.ICallbackEventHandler.GetCallbackResult
            'Paul -- Step 6:  Proceedure sends result back to JavaScript.
            Return returnValue
        End Function

        Public Sub RaiseCallbackEvent(ByVal args As String) Implements System.Web.UI.ICallbackEventHandler.RaiseCallbackEvent
            ' encrypt whatever is passed to args and pass to returnValue
            'Paul -- Step 5:  Code behind gets and processes value sent by ISD.  Function below provides encryption and whatever else is needed (could even set session variables.  awesome.)
            returnValue = f_ProcessURL(args)
        End Sub


        Public Function f_ProcessURL(ByVal myArgs As String) As String

            Dim myAction As String = CustGenClass.f_Split_ByComma(myArgs, 1)
            Dim my1st As String = CustGenClass.f_Split_ByComma(myArgs, 2)
            Dim my2nd As String = CustGenClass.f_Split_ByComma(myArgs, 3)
            Dim myReturn As String = "Nothing"
            Dim mySproc As String = "Nothing"
            Dim myMeID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()

            Dim myDocType As String = "DocTree"
            Dim mySourceID As String = my1st

            Dim myCIX As String = PartiesRCB.SelectedValue
            Dim myGeneralRoleID As String = GeneralRolesRCB.SelectedValue

            If Right(mySourceID, 3) = "999" And Len(mySourceID) > 3 Then
                myDocType = "Agreement"
                Dim myLen As Integer = Len(mySourceID) - 3
                mySourceID = Right(Left(mySourceID, myLen), myLen - 1)
            End If

            Dim myParentID As String = mySourceID

            If myAction = "addFolderParent" Or myAction = "deleteFolder" Or myAction = "deleteAll" Or myAction = "revertDoc" Then

                If myDocType = "DocTree" Then
                    Dim myW As String = DocTreeTable.DocTreeID.UniqueName & " = " & mySourceID
                    Dim myR As DocTreeRecord = DocTreeTable.GetRecord(myW)
                    If Not String.IsNullOrEmpty(CStr(myR.DocTreeParentID)) Then
                        myParentID = CStr(myR.DocTreeParentID)
                    End If
                Else
                    Dim myW As String = AgreementTable.AgreementID.UniqueName & " = " & mySourceID
                    Dim myR As AgreementRecord = AgreementTable.GetRecord(myW)
                    If Not String.IsNullOrEmpty(CStr(myR.DocTreeParentID)) Then
                        myParentID = CStr(myR.DocTreeParentID)
                    End If
                End If

            End If

            HttpContext.Current.Session("DocConfigNode") = myParentID

            'DONE
            If myAction = "addFolder" Or myAction = "addFolderParent" Then

                Dim myURLParams As String

                If my1st <> "0" Then
                    Dim myW As String = DocTreeTable.DocTreeID.UniqueName & " = " & myParentID
                    Dim myR As DocTreeRecord = DocTreeTable.GetRecord(myW)
                    Dim myRoleID As String = CStr(myR.RoleID)
                    myRoleID = CustGenClass.f_Encrypt(myRoleID)
                    myURLParams = "../DocTree/AddDocTree.aspx?DocTreeParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myParentID, String)) & _
                                        "&Folder=Yes&Close=Yes&CIX=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myCIX, String)) & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID) & "&Role=" & myRoleID
                Else
                    myGeneralRoleID = CustGenClass.f_Encrypt(myGeneralRoleID)
                    myURLParams = "../DocTree/AddDocTree.aspx?Folder=Yes&Close=Yes&CIX=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myCIX, String)) & _
                                        "&GeneralRole=" & myGeneralRoleID & "&Role=" & myGeneralRoleID
                End If

                myReturn = myURLParams

                'DONE
            ElseIf myAction = "newDoc" Then

                Dim myW As String = DocTreeTable.DocTreeID.UniqueName & " = " & my1st
                Dim myR As DocTreeRecord = DocTreeTable.GetRecord(myW)
                Dim myRoleID As String = CStr(myR.RoleID)
                myRoleID = CustGenClass.f_Encrypt(myRoleID)

                myReturn = "../DocTree/AddDocTree.aspx?DocTreeParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(my1st, String)) & "&Close=Yes&Folder=No&CIX=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myCIX, String)) & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID) & "&Role=" & myRoleID

                'DONE
            ElseIf myAction = "newSignableDoc" Then

                Dim myW As String = DocTreeTable.DocTreeID.UniqueName & " = " & my1st
                Dim myR As DocTreeRecord = DocTreeTable.GetRecord(myW)
                Dim myRoleID As String = CStr(myR.RoleID)
                myRoleID = CustGenClass.f_Encrypt(myRoleID)

                myReturn = "../Agreement/AddAgreement.aspx?DocTreeParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(my1st, String)) & "&Close=Yes&Folder=No&CIX=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myCIX, String)) & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID) & "&Role=" & myRoleID

                'DONE
            ElseIf myAction = "editFolder" Then

                myReturn = "../DocTree/EditDocTree_Folder.aspx?DocTree=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(my1st, String)) & "&Close=Yes" & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID)
                HttpContext.Current.Session("DocConfigNode") = mySourceID

                'DONE
            ElseIf myAction = "deleteFolder" Then

                mySproc = CustGenClass.f_Sproc("usp_DocTreeFolder_Delete", my1st)

                If mySproc <> "1" Then

                    myReturn = "WARNING: The system failed to delete this item.  It is likely that this item CANNOT be deleted, because documents being deleted have already been used.  Here is a detailed error message: " & mySproc

                Else

                    myReturn = "Nothing"

                End If

                'Done
            ElseIf myAction = "copyDoc" Then

                If myDocType = "Agreement" Then

                    mySproc = CustGenClass.f_Sproc("usp_AgreementCopy", mySourceID, myCIX, myMeID)

                    If mySproc = "0" Then
                        myReturn = "WARNING: The system failed to copy your item.  If the problem persists, please contact support."
                    Else
                        HttpContext.Current.Session("DocConfigNode") = mySproc & "999"
                    End If

                Else

                    mySproc = CustGenClass.f_Sproc("usp_DocTree_Copy", mySourceID, myCIX, myMeID)

                    If mySproc = "0" Then
                        myReturn = "WARNING: The system failed to copy your item.  If the problem persists, please contact support."
                    Else
                        HttpContext.Current.Session("DocConfigNode") = mySproc
                    End If

                End If

                'Done
            ElseIf myAction = "viewDoc" Then

                If myDocType = "DocTree" Then
                    myReturn = "../DocTree/ShowDocTree.aspx?DocTree=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(mySourceID, String)) & "&Close=Yes"
                Else
                    myReturn = "../Agreement/ShowAgreement.aspx?Agreement=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(mySourceID, String)) & "&Close=Yes"
                End If

                'Done
            ElseIf myAction = "editDoc" Then

                If myDocType = "DocTree" Then
                    myReturn = "../DocTree/EditDocTree.aspx?DocTree=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(mySourceID, String)) & "&Close=Yes" & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID)
                Else
                    myReturn = "../Agreement/EditAgreement.aspx?Agreement=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(mySourceID, String)) & "&Close=Yes" & _
                                        "&GeneralRole=" & CustGenClass.f_Encrypt(myGeneralRoleID)
                End If

                HttpContext.Current.Session("DocConfigNode") = my1st

                'Done
            ElseIf myAction = "deleteAll" Then

                If myDocType = "DocTree" Then
                    mySproc = CustGenClass.f_Sproc("usp_DocTree_Delete", mySourceID)
                Else
                    mySproc = CustGenClass.f_Sproc("usp_Agreement_Delete", mySourceID)
                End If

                If mySproc <> "1" Then
                    myReturn = "WARNING: The system failed to delete this item.  It is likely that this item CANNOT be deleted, because the document being deleted has already been used.  Here is a detailed error message: " & mySproc
                Else
                    myReturn = "Nothing"
                End If

                'Done
            ElseIf myAction = "customizeDoc" Then

                mySproc = CustGenClass.f_Sproc("usp_AgreementCopy", mySourceID, myCIX, myMeID, "Yes")

                If mySproc = "0" Then
                    myReturn = "WARNING: The system failed to copy your item.  If the problem persists, please contact support."
                Else
                    HttpContext.Current.Session("DocConfigNode") = mySproc & "999"
                End If

                'Done
            ElseIf myAction = "revertDoc" Then

                mySproc = CustGenClass.f_Sproc("usp_Agreement_Delete", mySourceID)

                If mySproc <> "1" Then
                    myReturn = "WARNING: The system failed to REVERT to the stanadard document.  It is likely that this item CANNOT be reverted, because document being deleted has already been used.  Here is a detailed error message: " & mySproc
                Else
                    myReturn = "Nothing"
                End If

            ElseIf myAction = "searchTree" Then

                HttpContext.Current.Session("DocConfigNode") = my1st
                myReturn = "Success"

            End If

            Return myReturn

        End Function


        Protected Sub DocConfigRTV_NodeDataBound(ByVal sender As Object, ByVal e As RadTreeNodeEventArgs)

            Dim myUserID As String = CType(Me.Page, BaseApplicationPage).SystemUtils.GetUserID()
            Dim myFASTPORTER As String = CustGenClass.f_Sproc("usp_IsMyRole", "0", myUserID, "20")

            Dim myFolder As String = (TryCast(e.Node.DataItem, DataRowView))("Folder").ToString()
            Dim myCIX As String = (TryCast(e.Node.DataItem, DataRowView))("CIX").ToString()
            Dim myDocType As String = (TryCast(e.Node.DataItem, DataRowView))("DocType").ToString()
            Dim myCustom As String = (TryCast(e.Node.DataItem, DataRowView))("Custom").ToString()

            If myFolder = "1" Then
                If myFASTPORTER = "Yes" Or myCIX <> "1" Then
                    e.Node.ContextMenuID = "FolderCIXRCM"
                    e.Node.AllowDrag = True
                    e.Node.AllowDrop = True
                Else
                    e.Node.ContextMenuID = "FolderRCM"
                    e.Node.AllowDrag = False
                    e.Node.AllowDrop = False
                End If
            Else
                If myFASTPORTER = "Yes" Or myCIX <> "1" Then
                    If myDocType = "DocTree" Or myCustom = "0" Then
                        e.Node.ContextMenuID = "DocCIXRCM"
                        e.Node.AllowDrag = True
                        e.Node.AllowDrop = False
                    Else
                        e.Node.ContextMenuID = "DocAgreeCIXRCM_Revert"
                        e.Node.AllowDrag = True
                        e.Node.AllowDrop = False
                    End If
                Else
                    If myDocType = "DocTree" Then
                        e.Node.ContextMenuID = "DocRCM"
                        e.Node.AllowDrag = False
                        e.Node.AllowDrop = False
                    Else
                        e.Node.ContextMenuID = "DocAgreeRCM"
                        e.Node.AllowDrag = False
                        e.Node.AllowDrop = False
                    End If
                End If
            End If

        End Sub

        Private Function f_NodeParent(ByVal myCurrentType As String, ByRef myCurrentID As String) As String

            Dim myWith9s As String = "No"

            If Right(myCurrentID, 3) = "999" And Len(myCurrentID) > 3 Then
                Dim myLen As Integer = Len(myCurrentID) - 3
                myCurrentID = Right(Left(myCurrentID, myLen), myLen - 1)
            End If

            If myCurrentType = "DocTree" Then
                Dim myW As String = DocTreeTable.DocTreeID.UniqueName & " = " & myCurrentID
                Dim myR As DocTreeRecord = DocTreeTable.GetRecord(myW)
                If Not String.IsNullOrEmpty(CStr(myR.DocTreeParentID)) Then
                    myCurrentID = CStr(myR.DocTreeParentID)
                End If
            Else
                Dim myW As String = AgreementTable.AgreementID.UniqueName & " = " & myCurrentID
                Dim myR As AgreementRecord = AgreementTable.GetRecord(myW)
                If Not String.IsNullOrEmpty(CStr(myR.DocTreeParentID)) Then
                    myCurrentID = CStr(myR.DocTreeParentID)
                End If
            End If

            If myWith9s = "Yes" Then
                myCurrentID = myCurrentID & "999"
            End If

            Return myCurrentID

        End Function

        Protected Sub DocConfigRTV_NodeDrop(ByVal sender As Object, ByVal e As RadTreeNodeDragDropEventArgs)
            PerformDragDrop(e)
        End Sub

        Private Sub PerformDragDrop(ByVal e As RadTreeNodeDragDropEventArgs)
            Dim sourceNode As RadTreeNode = e.SourceDragNode
            Dim destinationNode As RadTreeNode = e.DestDragNode

            If Not (destinationNode Is Nothing) Then
                MoveNode(e.DropPosition, sourceNode, destinationNode)
            End If
        End Sub

        Private Sub MoveNode(ByVal dropPosition As RadTreeViewDropPosition, ByVal sourceNode As RadTreeNode, ByVal destNode As RadTreeNode)
            If sourceNode Is destNode Then
                Return
            End If
            sourceNode.Owner.Nodes.Remove(sourceNode)
            Dim newNode As RadTreeNode = sourceNode

            Dim mySourceID As String = sourceNode.Value
            Dim myDestID As String = destNode.Value
            Dim myOverUnder As String

            Dim myDestType As String = "DocTree"
            If Right(myDestID, 3) = "999" And Len(myDestID) > 3 Then
                myDestType = "Agreement"
            End If

            Select Case dropPosition
                Case RadTreeViewDropPosition.Over
                    If Not sourceNode.IsAncestorOf(destNode) Then
                        destNode.Nodes.Add(newNode)
                        destNode.Expanded = True
                    End If
                    myOverUnder = "Over"
                    s_DragDrop(mySourceID, myDestID, myOverUnder)
                    HttpContext.Current.Session("DocConfigNode") = myDestID
                    Exit Select
                Case RadTreeViewDropPosition.Above
                    destNode.InsertBefore(newNode)
                    myOverUnder = "Above"
                    s_DragDrop(mySourceID, myDestID, myOverUnder)
                    HttpContext.Current.Session("DocConfigNode") = f_NodeParent(myDestType, myDestID)
                    Exit Select
                Case RadTreeViewDropPosition.Below
                    destNode.InsertAfter(newNode)
                    myOverUnder = "Under"
                    s_DragDrop(mySourceID, myDestID, myOverUnder)
                    HttpContext.Current.Session("DocConfigNode") = f_NodeParent(myDestType, myDestID)
                    Exit Select
            End Select
            newNode.Selected = False

            DocConfigRTV.DataBind()
            SearchDocsRCB.DataBind()

        End Sub

        Public Sub s_DragDrop(ByVal mySourceID As String, ByVal myDestID As String, ByVal myOverUnder As String)

            Dim mySproc As String = CustGenClass.f_Sproc("usp_DocTreeDragDrop", mySourceID, myDestID, myOverUnder)

            If mySproc <> "1" Then
                Dim myMessage As String = "WARNING: The database was unable to drag and drop this item.  If the problem continues, please contact support."
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", myMessage)
            End If

        End Sub


        Public Sub s_ToSignRTV_OnReRender() Handles DocConfigRTV.PreRender

            Dim myCurrentNode As String = CType(HttpContext.Current.Session("DocConfigNode"), String)

            If myCurrentNode IsNot Nothing Then
                s_Search(myCurrentNode)
                HttpContext.Current.Session("DocConfigNode") = Nothing
            End If

        End Sub

        Public Sub s_Search(ByVal myNodeID As String)

            ' collapse any open nodes
            DocConfigRTV.CollapseAllNodes()

            ' find the node in the tree view
            Dim node As RadTreeNode = DocConfigRTV.FindNodeByValue(myNodeID)
            If Not node Is Nothing Then
                ' select the node
                node.Selected = True
                ' traverse the hierarchy upwards, expanding parent nodes
                Dim parentNode As RadTreeNode = node.ParentNode
                While Not parentNode Is Nothing
                    parentNode.Expanded = True
                    parentNode = parentNode.ParentNode
                End While
                ' if this is not a leaf node, expand all child nodes

                s_ExpandChild(node)

            End If

        End Sub

        Protected Sub s_ExpandChild(ByVal node As RadTreeNode)
            ' if the node has no children, we are done
            If node.Nodes.Count > 0 Then
                node.Expanded = True
            End If

        End Sub
        Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest


            Dim myArg As String = CustGenClass.f_Split_ByComma(e.Argument, 1)
            Dim my1st As String = CustGenClass.f_Split_ByComma(e.Argument, 2)

            If myArg = "RebindDocConfig" Then

                DocConfigRTV.DataBind()
                SearchDocsRCB.DataBind()

            End If

        End Sub
        Public Sub s_Vis()

            Dim myCIX As String = CType(HttpContext.Current.Session("ParentPartyID"), String)
            Dim myPartyName As String = CustGenClass.f_GetPartyName(myCIX)
            PartiesRCB.SelectedValue = myCIX
            PartiesRCB.Text = myPartyName

			s_Instructions()
			
        End Sub
	
        Public Sub s_Instructions()

            Dim myCtrl As Literal = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "InstructionsStandard"), Literal)

            If Not IsNothing(myCtrl) Then

                Dim myConfigID As String = myCtrl.Text

                If String.IsNullOrEmpty(myConfigID) = False Then

                    Dim myWhere As String = FlowConfigTable.ConfigID.UniqueName & " = " & myConfigID
                    Dim myRec As FlowConfigRecord = FlowConfigTable.GetRecord(myWhere)
                    If Not IsNothing(myRec) Then
                        Me.InstructionsStandard.Text = myRec.Instructions
                        MiscUtils.FindControlRecursively(Me, "InstructionsRow").Visible = True
                    End If

                End If

            End If

		End Sub
	
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

        ' Page Event Handlers - buttons, sort, links


        ' Write out the Set methods


        ' Write out the methods for DataSource


#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents CustomizedLbl As System.Web.UI.WebControls.Label
        Public WithEvents DocConfigDS As System.Web.UI.WebControls.SqlDataSource
        Public WithEvents GeneralRolesDS As System.Web.UI.WebControls.SqlDataSource
        Public WithEvents InstructionsStandard As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents PartiesDS As System.Web.UI.WebControls.SqlDataSource
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
            Me.Authorize("20;24;25")
    
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
  