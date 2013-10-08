
' This file implements the code-behind class for ShowTreeTable.aspx.
' ShowTreeTable.Controls.vb contains the Table, Row and Record control classes
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

Imports System.Data.SqlClient

#End Region

  
Namespace FASTPORT.UI

    Partial Public Class ShowTreeTable
        Inherits BaseApplicationPage
        Implements System.Web.UI.ICallbackEventHandler

        ' Code-behind class for the ShowTreeTable page.
        ' Place your customizations in Section 1. Do not modify Section 2.

#Region "Section 1: Place your customizations here."

        Protected WithEvents RadAjaxManager1 As RadAjaxManager
        Protected WithEvents RadTreeView1 As RadTreeView
        Protected WithEvents SearchComboBox As RadComboBox
        Protected WithEvents HiddenComboBox As RadComboBox
        Protected WithEvents AdminOnlyComboBox As RadComboBox
        Protected WithEvents RadWindowManager1 As RadWindowManager


        Public Shared connection As String = ConfigurationManager.ConnectionStrings("DatabaseFASTPORT1").ConnectionString
        Private conn As New SqlConnection(connection)
        Public SqlCommand As New SqlCommand()

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

            Dim myReturn As String = "Nothing"
            Dim myPK As String = Replace(myArgs, Left(myArgs, 3), "")
            Dim myLeft As String = Left(myArgs, 3)

            System.Web.HttpContext.Current.Session("CurrentNode") = myPK


            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = " & myPK
            Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
            Dim myTreeName As String = myRec.ItemName.ToString

            If myLeft = "04-" Then
                myPK = myRec.TreeParentID.ToString
            End If

            Dim myMessage As String = "Nothing"

            If myLeft = "01-" Then
                myReturn = "../Tree/AddTree.aspx?TreeParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Title=ADD%20INSIDE%20the%20Branch%20Named:%20" & myTreeName
            ElseIf myLeft = "02-" Then
                myReturn = "../Tree/EditTree.aspx?Tree=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Title=EDIT%20the%20Item%20Named:%20" & myTreeName
            ElseIf myLeft = "02b" Then
                myReturn = "../Tree/EditTreeImage.aspx?Tree=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Title=EDIT%20the%20Item%20Named:%20" & myTreeName
            ElseIf myLeft = "03-" Then
                myMessage = "Are you certain that you wish to delete the item named: " & myTreeName & "?"
                myMessage = HttpUtility.UrlEncode(myMessage)
                myReturn = "../Dialogues/YesNoDialogue.aspx?PK=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Table=Tree" & "&Action=Delete" & "&Title=DELETE%20the%20Item%20Named:%20" & myTreeName & "&Message=" & myMessage
            ElseIf myLeft = "04-" Then
                If myPK = "0" Then
                    myReturn = "../Tree/AddTree.aspx?Title=ADD%20to%20the%20Same%20Level%20As:%20" & myTreeName
                Else
                    myReturn = "../Tree/AddTree.aspx?TreeParent=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Title=ADD%20to%20the%20Same%20Level%20As:%20" & myTreeName
                End If
            Else
                myReturn = "Nothing"
            End If

            If myReturn <> "Nothing" Then
                System.Web.HttpContext.Current.Session("CurrentNode") = myPK
            End If

            Return myReturn

        End Function

        Public Function f_TreeData(ByVal PruneID As String, ByVal CIX As String, ByVal Hide As String, ByVal AdminOnly As String) As DataTable

            SqlCommand.CommandText = "SELECT * " & _
                                        "FROM dbo.v_TreeWithCount " & _
                                        "WHERE " & _
                                            "((@Prune = 0 AND TreeParentID IS NULL) OR (@Prune > 0 AND TreeParentID = @Prune)) " & _
                                              "AND (@CIX = 0 OR @CIX = CIX OR CIX = 1) " & _
                                              "AND @Hide = Hide " & _
                                              "AND (@AdminOnly = 'Both' " & _
                                                 "OR (@AdminOnly = 'Admin' AND AdminOnly = 1) " & _
                                                 "OR (@AdminOnly = 'NonAdmin' AND AdminOnly = 0)) " & _
                                        "ORDER BY ItemRank, ItemName"
            SqlCommand.Parameters.Clear()
            SqlCommand.Parameters.Add(New SqlParameter("@Prune", PruneID))
            SqlCommand.Parameters.Add(New SqlParameter("@CIX", CIX))
            SqlCommand.Parameters.Add(New SqlParameter("@Hide", Hide))
            SqlCommand.Parameters.Add(New SqlParameter("@AdminOnly", AdminOnly))
            SqlCommand.Connection = conn
            Dim dtDocList As New DataTable()
            Dim daDocList As New SqlDataAdapter(SqlCommand)
            daDocList.Fill(dtDocList)
            conn.Close()

            Return dtDocList

        End Function

        Protected Sub s_LoadTree(ByVal PruneID As String, ByVal CIX As String, ByVal Hide As String, ByVal AdminOnly As String)

            Dim dtDocList As New DataTable()
            dtDocList = f_TreeData(PruneID, CIX, Hide, AdminOnly)

            Dim myFolderOnly As String = Nothing
            Dim myImagePath As String = Nothing

            For Each row As DataRow In dtDocList.Rows

                Dim node As New RadTreeNode()
                node.Text = row("ItemName").ToString()
                node.Value = row("TreeID").ToString()

                If Convert.ToInt32(row("ChildCount")) > 0 Then
                    node.ExpandMode = TreeNodeExpandMode.ServerSide
                End If


                myFolderOnly = row("FolderOnly").ToString()
                myImagePath = row("ImagePath").ToString()
                If String.IsNullOrEmpty(myImagePath) = False Then
                    node.ImageUrl = "\Images\Custom\SavedFromApp\Tree\" & myImagePath
                ElseIf myFolderOnly = "True" Then
                    node.ImageUrl = "\Images\Custom\Folder.png"
                End If

                RadTreeView1.Nodes.Add(node)
            Next

        End Sub

        Protected Sub RadTreeView1_NodeExpand(ByVal sender As Object, ByVal e As RadTreeNodeEventArgs)

            s_NodeExpand(e.Node, e.Node.Value)

        End Sub

        Protected Sub s_NodeExpand(ByVal Node As RadTreeNode, ByVal myTreeParentID As String)

            Dim myCIX As String = "0" 'HARD CODE:  NEEDS TO BE CIXCType(HttpContext.Current.Session("ParentPartyID"), String)
            Dim myTreeHidden As String = CType(HttpContext.Current.Session("TreeHidden"), String)
            Dim myTreeAdminOnly As String = CType(HttpContext.Current.Session("TreeAdminOnly"), String)

            Dim dataTable As New DataTable()
            dataTable = f_TreeData(myTreeParentID, myCIX, myTreeHidden, myTreeAdminOnly)

            Dim myFolderOnly As String = Nothing
            Dim myImagePath As String = Nothing

            For Each row As DataRow In dataTable.Rows
                Dim newnode As New RadTreeNode()
                newnode.Text = row("ItemName").ToString()
                newnode.Value = row("TreeID").ToString()

                If Convert.ToInt32(row("ChildCount")) > 0 Then
                    newnode.ExpandMode = TreeNodeExpandMode.ServerSide
                End If


                myFolderOnly = row("FolderOnly").ToString()
                myImagePath = row("ImagePath").ToString()
                If String.IsNullOrEmpty(myImagePath) = False Then
                    newnode.ImageUrl = "\Images\Custom\SavedFromApp\Tree\" & myImagePath
                ElseIf myFolderOnly = "True" Then
                    newnode.ImageUrl = "\Images\Custom\Folder.png"
                End If

                Node.Nodes.Add(newnode)

            Next
            Node.Expanded = True
            Node.ExpandMode = TreeNodeExpandMode.ClientSide

        End Sub
        Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest

            SearchComboBox.DataBind()
            'RadTreeView1.DataBind()

            Dim myNodeID As String = CType(HttpContext.Current.Session("CurrentNode"), String)
            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = " & myNodeID
            Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
            Dim myFolderOnly As String
            Dim myImagePath As String

            Dim node As RadTreeNode = RadTreeView1.FindNodeByValue(myNodeID)
            If Not node Is Nothing Then

                If Not IsNothing(myRec) Then

                    myFolderOnly = myRec.FolderOnly.ToString

                    node.Text = myRec.ItemName.ToString & " (" & myRec.TreeID.ToString & ")"
                    node.Value = myRec.TreeID.ToString

                    If Not IsNothing(myRec.ImagePath) Then
                        myImagePath = myRec.ImagePath.ToString
                        node.ImageUrl = "\Images\Custom\SavedFromApp\Tree\" & myImagePath
                    ElseIf myFolderOnly = "True" Then
                        node.ImageUrl = "\Images\Custom\Folder.png"
                    End If

                    myWhere = TreeTable.TreeParentID.UniqueName & " = " & myNodeID
                    myRec = TreeTable.GetRecord(myWhere)

                    If Not IsNothing(myRec) Then
                        node.ExpandMode = TreeNodeExpandMode.ServerSide
                    End If

                    node.Selected = True

                Else

                    node.Remove()

                End If

            Else

                Dim newnode As New RadTreeNode()
                newnode.Text = myRec.ItemName.ToString & " (" & myRec.TreeID.ToString & ")"
                newnode.Value = myRec.TreeID.ToString

                myFolderOnly = myRec.FolderOnly.ToString

                If Not IsNothing(myRec.ImagePath) Then
                    myImagePath = myRec.ImagePath.ToString
                    node.ImageUrl = "\Images\Custom\SavedFromApp\Tree\" & myImagePath
                ElseIf myFolderOnly = "True" Then
                    node.ImageUrl = "\Images\Custom\Folder.png"
                End If

                Dim parentNode As RadTreeNode = RadTreeView1.FindNodeByValue(myRec.TreeParentID.ToString)

                parentNode.Nodes.Add(newnode)

                parentNode.Expanded = True
                parentNode.ExpandMode = TreeNodeExpandMode.ClientSide

                Dim newnodeSelected As RadTreeNode = RadTreeView1.FindNodeByValue(myRec.TreeID.ToString)
                newnodeSelected.Selected = True

            End If

        End Sub

        Public Sub s_Search(ByVal myNodeToLoad As String, Optional ByVal myParentToLoad As String = Nothing)

            RadTreeView1.Nodes.Clear()

            Dim myCurrentNode As String = CType(HttpContext.Current.Session("CurrentNode"), String)
            Dim myCIX As String = "0" 'HARD CODE:  NEEDS TO BE CIXCType(HttpContext.Current.Session("ParentPartyID"), String)
            Dim myTreeHidden As String = CType(HttpContext.Current.Session("TreeHidden"), String)
            Dim myTreeAdminOnly As String = CType(HttpContext.Current.Session("TreeAdminOnly"), String)

            If Not IsNothing(myParentToLoad) Then
                s_LoadTree(myParentToLoad, myCIX, myTreeHidden, myTreeAdminOnly)
                Dim parentNode As RadTreeNode = RadTreeView1.FindNodeByValue(myNodeToLoad)
                s_NodeExpand(parentNode, myNodeToLoad)
            Else
                s_LoadTree(myNodeToLoad, myCIX, myTreeHidden, myTreeAdminOnly)
            End If

            s_FocusOnNode(myCurrentNode)

        End Sub

        Public Sub s_FocusOnNode(ByVal myNodeID As String)

            ' collapse any open nodes

            ' find the node in the tree view
            Dim node As RadTreeNode = RadTreeView1.FindNodeByValue(myNodeID)
            If Not node Is Nothing Then

                RadTreeView1.CollapseAllNodes()

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

        Public Sub s_SearchIndexChanged() Handles SearchComboBox.SelectedIndexChanged

            Dim myCurrentNode As String = Me.SearchComboBox.SelectedValue
            System.Web.HttpContext.Current.Session("CurrentNode") = myCurrentNode


            Dim myWhere As String = TreeTable.TreeID.UniqueName & " = " & myCurrentNode
            Dim myRec As TreeRecord = TreeTable.GetRecord(myWhere)
            Dim myParentID As String = myRec.TreeParentID.ToString

            myWhere = TreeTable.TreeID.UniqueName & " = " & myParentID
            myRec = TreeTable.GetRecord(myWhere)
            Dim myGrandID As String = Nothing
            If Not IsNothing(myRec) Then
                myGrandID = myRec.TreeParentID.ToString
            End If

            s_Search(myParentID, myGrandID)

        End Sub

        Public Sub s_HiddenIndexChanged() Handles HiddenComboBox.SelectedIndexChanged

            Dim myPK As String = Me.HiddenComboBox.SelectedValue
            System.Web.HttpContext.Current.Session("TreeHidden") = myPK
            s_Search("0")

        End Sub

        Public Sub s_AdminOnlyIndexChanged() Handles AdminOnlyComboBox.SelectedIndexChanged

            Dim myPK As String = Me.AdminOnlyComboBox.SelectedValue
            System.Web.HttpContext.Current.Session("TreeAdminOnly") = myPK
            s_Search("0")

        End Sub

        Public Sub s_NodeSelect(ByVal sender As Object, _
                                ByVal e As RadTreeNodeEventArgs) _
                                Handles RadTreeView1.NodeClick

            Dim myCurrentNode As String = e.Node.Value
            System.Web.HttpContext.Current.Session("CurrentNode") = myCurrentNode

        End Sub


        Protected Sub RadTreeView1_NodeDrop(ByVal sender As Object, ByVal e As RadTreeNodeDragDropEventArgs)
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

            If Not sourceNode.IsAncestorOf(destNode) Then
                destNode.Nodes.Add(newNode)
                destNode.Expanded = True
            End If

            s_DragDrop(mySourceID, myDestID)

            newNode.Selected = False

            System.Web.HttpContext.Current.Session("CurrentNode") = mySourceID

            RadTreeView1.DataBind()

        End Sub

        Public Sub s_DragDrop(ByVal mySourceID As String, ByVal myDestID As String)

            Dim mySproc As String = CustGenClass.f_Sproc("usp_TreeDragDrop", mySourceID, myDestID)
            If mySproc <> "1" Then
                Dim myMessage As String = "WARNING: The database was unable to drag and drop this item.  If the problem continues, please contact support."
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", myMessage)
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
            ' LoadData reads database data and assigns it to UI controls.
            ' Customize by adding code before or after the call to LoadData_Base()
            ' or replace the call to LoadData_Base().
            LoadData_Base()


            System.Web.HttpContext.Current.Session("PruneTreeID") = "0"
            System.Web.HttpContext.Current.Session("TreeHidden") = False
            System.Web.HttpContext.Current.Session("TreeAdminOnly") = "Both"

            Dim myPruneTreeID As String = CType(HttpContext.Current.Session("PruneTreeID"), String)
            Dim myCIX As String = "0" 'HARD CODE:  NEEDS TO BE CIXCType(HttpContext.Current.Session("ParentPartyID"), String)
            Dim myTreeHidden As String = CType(HttpContext.Current.Session("TreeHidden"), String)
            Dim myTreeAdminOnly As String = CType(HttpContext.Current.Session("TreeAdminOnly"), String)

            s_LoadTree("0", myCIX, myTreeHidden, myTreeAdminOnly)

        End Sub

        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
        End Function

        Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
            Me.Page_InitializeEventHandlers_Base(sender, e)
            'Me.EnableViewState = False

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
            RegisterPostback()


        End Sub

        Protected Sub RegisterPostback()
            Base_RegisterPostback()
        End Sub




#End Region

        ' Page Event Handlers - buttons, sort, links


        ' Write out the Set methods


        Public Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Me.Page_PreRender_Base(sender, e)
        End Sub
        Protected Overrides Function SaveViewState() As Object
            Return SaveViewState_Base()
        End Function
        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            LoadViewState_Base(savedState)
        End Sub
        Protected Overrides Sub ClearControlsFromSession()
            ClearControlsFromSession_Base()
        End Sub
        Protected Overrides Sub SaveControlsToSession()
            SaveControlsToSession_Base()
        End Sub
#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents ActiveLabel As System.Web.UI.WebControls.Label
        Public WithEvents AdminLabel As System.Web.UI.WebControls.Label
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents SearchLabel As System.Web.UI.WebControls.Label
        Public WithEvents TreeDatasource As System.Web.UI.WebControls.SqlDataSource
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
        
        
            Page.Title = "Manage Lists"
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
  