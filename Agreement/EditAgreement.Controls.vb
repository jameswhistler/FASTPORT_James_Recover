
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditAgreement.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
        
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports FASTPORT.Business
Imports FASTPORT.Data
Imports FASTPORT.UI
Imports Telerik.Web.UI
        

#End Region

  
Namespace FASTPORT.UI.Controls.EditAgreement

#Region "Section 1: Place your customizations here."


    Public Class AgreementRecordControl
        Inherits BaseAgreementRecordControl
        ' The BaseAgreementRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.



        Protected Overrides Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
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

                Dim OtherInstructionsRE As RadEditor = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "OtherInstructionsRE"), RadEditor)
                Dim SenderInstructionsRE As RadEditor = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SenderInstructionsRE"), RadEditor)
                Dim RecipientInstructionsRE As RadEditor = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "RecipientInstructionsRE"), RadEditor)

                OtherInstructionsRE.Content = Me.OtherInstructions.Content
                SenderInstructionsRE.Content = Me.SenderInstructions.Content
                RecipientInstructionsRE.Content = Me.RecipientInstructions.Content

            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try

        End Sub
        Protected Overrides Sub DocHasCustomFields_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)

            Dim myChecked As Boolean = Me.DocHasCustomFields.Checked

            Dim myRTS As RadTabStrip = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "RadTabStrip1"), RadTabStrip)
            Dim myRMP As RadMultiPage = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "RadMultiPage1"), RadMultiPage)

            If myChecked = True Then
                myRTS.Tabs(2).Visible = True
                myRMP.PageViews(2).Visible = True
                myRTS.Tabs(3).Visible = True
                myRMP.PageViews(3).Visible = True
            Else
                myRTS.Tabs(2).Visible = False
                myRMP.PageViews(2).Visible = False
                myRTS.Tabs(3).Visible = False
                myRMP.PageViews(3).Visible = False
            End If

        End Sub

    End Class



'Public Class FlowCollectionTableControl
'        Inherits BaseFlowCollectionTableControl
'
'    ' The BaseFlowCollectionTableControl class implements the LoadData, DataBind, CreateWhereClause
'    ' and other methods to load and display the data in a table control.
'
'    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
'    ' The FlowCollectionTableControlRow class offers another place where you can customize
'    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
'
'End Class
'
'Public Class FlowCollectionTableControlRow
'        Inherits BaseFlowCollectionTableControlRow
'
'
'        Protected Overrides Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
'            ' PreRender event is raised just before page is being displayed.
'            Try
'                DbUtils.StartTransaction()
'                Me.RegisterPostback()
'
'                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
'
'
'                    ' Re-load the data and update the web page if necessary.
'                    ' This is typically done during a postback (filter, search button, sort, pagination button).
'                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
'                    Me.LoadData()
'                    Me.DataBind()
'                End If
'
'                Dim myCtrl As AgreementRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "AgreementRecordControl"), AgreementRecordControl)
'                Dim myFlowCollectionID As String = myCtrl.FlowCollectionID.SelectedValue
'
'                If Me.FlowCollectionID1.Text = myFlowCollectionID Then
'                    Me.FlowCollectionRecordRowSelection.Checked = True
'                End If
'
'            Catch ex As Exception
'                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
'            Finally
'                DbUtils.EndTransaction()
'            End Try
'        End Sub
'
'        '  To customize, override this method in FlowCollectionTableControlRow.
'        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
'
'            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
'            Me.Page.LoadFocusScripts(Me)
'
'
'            ' Register the event handlers.
'
'            AddHandler Me.FlowCollectionID1.TextChanged, AddressOf FlowCollectionID1_TextChanged
'            AddHandler Me.FlowCollectionRecordRowSelection.CheckedChanged, AddressOf FlowCollectionRecordRowSelection_CheckChanged
'
'        End Sub
'
'        Public Sub FlowCollectionRecordRowSelection_CheckChanged(ByVal sender As Object, ByVal e As System.EventArgs)
'
'            Dim myFlowCollectionID As String = Me.FlowCollectionID1.Text
'            Dim myAgreementID As String = CType(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString("Agreement"))
'            Dim myCtrl As AgreementRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "AgreementRecordControl"), AgreementRecordControl)
'            myCtrl.FlowCollectionID.Text = myFlowCollectionID
'
'            Dim myTableCtrl As FlowCollectionTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "FlowCollectionTableControl"), FlowCollectionTableControl)
'            Dim recList() As UI.Controls.EditAgreement.FlowCollectionTableControlRow = myTableCtrl.GetSelectedRecordControls()
'
'            Dim recCtrl As UI.Controls.EditAgreement.FlowCollectionTableControlRow
'
'            For Each recCtrl In recList
'
'                If recCtrl.FlowCollectionID1.Text <> myFlowCollectionID Then
'                    recCtrl.FlowCollectionRecordRowSelection.Checked = False
'                End If
'            Next
'
'        End Sub
'
'    End Class
'
#End Region



#Region "Section 2: Do not modify this section."
    
    
' Base class for the AgreementRecordControl control on the EditAgreement page.
' Do not modify this class. Instead override any method in AgreementRecordControl.
Public Class BaseAgreementRecordControl
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in AgreementRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
            
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in AgreementRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.EighthTypeID.SelectedIndexChanged, AddressOf EighthTypeID_SelectedIndexChanged
            
              AddHandler Me.EleventhTypeID.SelectedIndexChanged, AddressOf EleventhTypeID_SelectedIndexChanged
            
              AddHandler Me.FifteenthTypeID.SelectedIndexChanged, AddressOf FifteenthTypeID_SelectedIndexChanged
            
              AddHandler Me.FifthTypeID.SelectedIndexChanged, AddressOf FifthTypeID_SelectedIndexChanged
            
              AddHandler Me.FirstTypeID.SelectedIndexChanged, AddressOf FirstTypeID_SelectedIndexChanged
            
              AddHandler Me.FlowCollectionID.SelectedIndexChanged, AddressOf FlowCollectionID_SelectedIndexChanged
            
              AddHandler Me.FourteenthTypeID.SelectedIndexChanged, AddressOf FourteenthTypeID_SelectedIndexChanged
            
              AddHandler Me.FourthTypeID.SelectedIndexChanged, AddressOf FourthTypeID_SelectedIndexChanged
            
              AddHandler Me.NinthTypeID.SelectedIndexChanged, AddressOf NinthTypeID_SelectedIndexChanged
            
              AddHandler Me.RoleID.SelectedIndexChanged, AddressOf RoleID_SelectedIndexChanged
            
              AddHandler Me.SecondTypeID.SelectedIndexChanged, AddressOf SecondTypeID_SelectedIndexChanged
            
              AddHandler Me.SeventhTypeID.SelectedIndexChanged, AddressOf SeventhTypeID_SelectedIndexChanged
            
              AddHandler Me.SixthTypeID.SelectedIndexChanged, AddressOf SixthTypeID_SelectedIndexChanged
            
              AddHandler Me.TenthTypeID.SelectedIndexChanged, AddressOf TenthTypeID_SelectedIndexChanged
            
              AddHandler Me.ThirdTypeID.SelectedIndexChanged, AddressOf ThirdTypeID_SelectedIndexChanged
            
              AddHandler Me.ThirteenthTypeID.SelectedIndexChanged, AddressOf ThirteenthTypeID_SelectedIndexChanged
            
              AddHandler Me.TwelfthTypeID.SelectedIndexChanged, AddressOf TwelfthTypeID_SelectedIndexChanged
            
              AddHandler Me.DocHasCustomFields.CheckedChanged, AddressOf DocHasCustomFields_CheckedChanged
            
              AddHandler Me.EighthByCIX.CheckedChanged, AddressOf EighthByCIX_CheckedChanged
            
              AddHandler Me.EighthByOIX.CheckedChanged, AddressOf EighthByOIX_CheckedChanged
            
              AddHandler Me.EleventhByCIX.CheckedChanged, AddressOf EleventhByCIX_CheckedChanged
            
              AddHandler Me.EleventhByOIX.CheckedChanged, AddressOf EleventhByOIX_CheckedChanged
            
              AddHandler Me.ExecuteFromBoard.CheckedChanged, AddressOf ExecuteFromBoard_CheckedChanged
            
              AddHandler Me.FifteenthByCIX.CheckedChanged, AddressOf FifteenthByCIX_CheckedChanged
            
              AddHandler Me.FifteenthByOIX.CheckedChanged, AddressOf FifteenthByOIX_CheckedChanged
            
              AddHandler Me.FifthByCIX.CheckedChanged, AddressOf FifthByCIX_CheckedChanged
            
              AddHandler Me.FifthByOIX.CheckedChanged, AddressOf FifthByOIX_CheckedChanged
            
              AddHandler Me.FirstByCIX.CheckedChanged, AddressOf FirstByCIX_CheckedChanged
            
              AddHandler Me.FirstByOIX.CheckedChanged, AddressOf FirstByOIX_CheckedChanged
            
              AddHandler Me.FourteenthByCIX.CheckedChanged, AddressOf FourteenthByCIX_CheckedChanged
            
              AddHandler Me.FourteenthByOIX.CheckedChanged, AddressOf FourteenthByOIX_CheckedChanged
            
              AddHandler Me.FourthByCIX.CheckedChanged, AddressOf FourthByCIX_CheckedChanged
            
              AddHandler Me.FourthByOIX.CheckedChanged, AddressOf FourthByOIX_CheckedChanged
            
              AddHandler Me.InitialsInDocument.CheckedChanged, AddressOf InitialsInDocument_CheckedChanged
            
              AddHandler Me.NinthByCIX.CheckedChanged, AddressOf NinthByCIX_CheckedChanged
            
              AddHandler Me.NinthByOIX.CheckedChanged, AddressOf NinthByOIX_CheckedChanged
            
              AddHandler Me.RequiredDoc.CheckedChanged, AddressOf RequiredDoc_CheckedChanged
            
              AddHandler Me.SecondByCIX.CheckedChanged, AddressOf SecondByCIX_CheckedChanged
            
              AddHandler Me.SecondByOIX.CheckedChanged, AddressOf SecondByOIX_CheckedChanged
            
              AddHandler Me.SeventhByCIX.CheckedChanged, AddressOf SeventhByCIX_CheckedChanged
            
              AddHandler Me.SeventhByOIX.CheckedChanged, AddressOf SeventhByOIX_CheckedChanged
            
              AddHandler Me.ShowExpirationDate.CheckedChanged, AddressOf ShowExpirationDate_CheckedChanged
            
              AddHandler Me.ShowSignatureDate.CheckedChanged, AddressOf ShowSignatureDate_CheckedChanged
            
              AddHandler Me.SixthByCIX.CheckedChanged, AddressOf SixthByCIX_CheckedChanged
            
              AddHandler Me.SixthByOIX.CheckedChanged, AddressOf SixthByOIX_CheckedChanged
            
              AddHandler Me.TenthByCIX.CheckedChanged, AddressOf TenthByCIX_CheckedChanged
            
              AddHandler Me.TenthByOIX.CheckedChanged, AddressOf TenthByOIX_CheckedChanged
            
              AddHandler Me.ThirdByCIX.CheckedChanged, AddressOf ThirdByCIX_CheckedChanged
            
              AddHandler Me.ThirdByOIX.CheckedChanged, AddressOf ThirdByOIX_CheckedChanged
            
              AddHandler Me.ThirteenthByCIX.CheckedChanged, AddressOf ThirteenthByCIX_CheckedChanged
            
              AddHandler Me.ThirteenthByOIX.CheckedChanged, AddressOf ThirteenthByOIX_CheckedChanged
            
              AddHandler Me.TwelfthByCIX.CheckedChanged, AddressOf TwelfthByCIX_CheckedChanged
            
              AddHandler Me.TwelfthByOIX.CheckedChanged, AddressOf TwelfthByOIX_CheckedChanged
            
              AddHandler Me.UseStoredSignature.CheckedChanged, AddressOf UseStoredSignature_CheckedChanged
            
              AddHandler Me.Agreement.TextChanged, AddressOf Agreement_TextChanged
            
              AddHandler Me.Description.TextChanged, AddressOf Description_TextChanged
            
              AddHandler Me.EighthDefault.TextChanged, AddressOf EighthDefault_TextChanged
            
              AddHandler Me.EighthItem.TextChanged, AddressOf EighthItem_TextChanged
            
              AddHandler Me.EleventhDefault.TextChanged, AddressOf EleventhDefault_TextChanged
            
              AddHandler Me.EleventhItem.TextChanged, AddressOf EleventhItem_TextChanged
            
              AddHandler Me.FifteenthDefault.TextChanged, AddressOf FifteenthDefault_TextChanged
            
              AddHandler Me.FifteenthItem.TextChanged, AddressOf FifteenthItem_TextChanged
            
              AddHandler Me.FifthDefault.TextChanged, AddressOf FifthDefault_TextChanged
            
              AddHandler Me.FifthItem.TextChanged, AddressOf FifthItem_TextChanged
            
              AddHandler Me.FirstDefault.TextChanged, AddressOf FirstDefault_TextChanged
            
              AddHandler Me.FirstItem.TextChanged, AddressOf FirstItem_TextChanged
            
              AddHandler Me.FourteenthDefault.TextChanged, AddressOf FourteenthDefault_TextChanged
            
              AddHandler Me.FourteenthItem.TextChanged, AddressOf FourteenthItem_TextChanged
            
              AddHandler Me.FourthDefault.TextChanged, AddressOf FourthDefault_TextChanged
            
              AddHandler Me.FourthItem.TextChanged, AddressOf FourthItem_TextChanged
            
              AddHandler Me.NinthDefault.TextChanged, AddressOf NinthDefault_TextChanged
            
              AddHandler Me.NinthItem.TextChanged, AddressOf NinthItem_TextChanged
            
              AddHandler Me.SecondDefault.TextChanged, AddressOf SecondDefault_TextChanged
            
              AddHandler Me.SecondItem.TextChanged, AddressOf SecondItem_TextChanged
            
              AddHandler Me.SeventhDefault.TextChanged, AddressOf SeventhDefault_TextChanged
            
              AddHandler Me.SeventhItem.TextChanged, AddressOf SeventhItem_TextChanged
            
              AddHandler Me.SixthDefault.TextChanged, AddressOf SixthDefault_TextChanged
            
              AddHandler Me.SixthItem.TextChanged, AddressOf SixthItem_TextChanged
            
              AddHandler Me.TenthDefault.TextChanged, AddressOf TenthDefault_TextChanged
            
              AddHandler Me.TenthItem.TextChanged, AddressOf TenthItem_TextChanged
            
              AddHandler Me.ThirdDefault.TextChanged, AddressOf ThirdDefault_TextChanged
            
              AddHandler Me.ThirdItem.TextChanged, AddressOf ThirdItem_TextChanged
            
              AddHandler Me.ThirteenthDefault.TextChanged, AddressOf ThirteenthDefault_TextChanged
            
              AddHandler Me.ThirteenthItem.TextChanged, AddressOf ThirteenthItem_TextChanged
            
              AddHandler Me.TwelfthDefault.TextChanged, AddressOf TwelfthDefault_TextChanged
            
              AddHandler Me.TwelfthItem.TextChanged, AddressOf TwelfthItem_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource Agreement record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = AgreementTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "AgreementRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New AgreementRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As AgreementRecord = AgreementTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = AgreementTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in AgreementRecordControl.
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
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetAgreement()
                SetAgreementDownload()
                
                SetAgreementFileLabel()
                SetAgreementLabel()
                SetCustomFieldsSrollPanel()
                SetCustomInstructionsSrollPanel()
                SetDefaultLabel()
                SetDescription()
                SetDescriptionLabel()
                SetDocHasCustomFields()
                SetDocHasCustomFieldsLabel()
                SetEighthByCIX()
                SetEighthByOIX()
                SetEighthDefault()
                SetEighthItem()
                SetEighthTypeID()
                SetEighthTypeIDLabel()
                SetEleventhByCIX()
                SetEleventhByOIX()
                SetEleventhDefault()
                SetEleventhItem()
                SetEleventhTypeID()
                SetEleventhTypeIDLabel()
                SetExecuteFromBoard()
                SetExecuteFromBoardLabel()
                SetFieldLbl()
                SetFieldTypeLbl()
                SetFifteenthByCIX()
                SetFifteenthByOIX()
                SetFifteenthDefault()
                SetFifteenthItem()
                SetFifteenthTypeID()
                SetFifteenthTypeIDLabel()
                SetFifthByCIX()
                SetFifthByOIX()
                SetFifthDefault()
                SetFifthItem()
                SetFifthTypeID()
                SetFifthTypeIDLabel()
                SetFirstByCIX()
                SetFirstByOIX()
                SetFirstDefault()
                SetFirstItem()
                SetFirstTypeID()
                SetFirstTypeIDLabel()
                SetFlowCollectionID()
                SetFlowCollectionIDLabel()
                SetForLbl()
                SetFourteenthByCIX()
                SetFourteenthByOIX()
                SetFourteenthDefault()
                SetFourteenthItem()
                SetFourteenthTypeID()
                SetFourteenthTypeIDLabel()
                SetFourthByCIX()
                SetFourthByOIX()
                SetFourthDefault()
                SetFourthItem()
                SetFourthTypeID()
                SetFourthTypeIDLabel()
                SetInitialsInDocument()
                SetInitialsInDocumentLabel()
                SetItemLabel()
                SetNinthByCIX()
                SetNinthByOIX()
                SetNinthDefault()
                SetNinthItem()
                SetNinthTypeID()
                SetNinthTypeIDLabel()
                SetOnlyCIXLbl()
                SetOnlyOIXLbl()
                SetOtherInstructions()
                SetOtherInstructionsLbl()
                SetRecipientInstrucitonsLbl()
                SetRecipientInstructions()
                SetRequiredDoc()
                SetRequiredDocLabel()
                SetRoleID()
                SetRoleIDLabel()
                SetSecondByCIX()
                SetSecondByOIX()
                SetSecondDefault()
                SetSecondItem()
                SetSecondTypeID()
                SetSecondTypeIDLabel()
                SetSenderInstrucitonsLbl()
                SetSenderInstructions()
                SetSeventhByCIX()
                SetSeventhByOIX()
                SetSeventhDefault()
                SetSeventhItem()
                SetSeventhTypeID()
                SetSeventhTypeIDLabel()
                SetShowExpirationDate()
                SetShowExpirationDateLabel()
                SetShowSignatureDate()
                SetShowSignatureDateLabel()
                SetSixthByCIX()
                SetSixthByOIX()
                SetSixthDefault()
                SetSixthItem()
                SetSixthTypeID()
                SetSixthTypeIDLabel()
                SetTenthByCIX()
                SetTenthByOIX()
                SetTenthDefault()
                SetTenthItem()
                SetTenthTypeID()
                SetTenthTypeIDLabel()
                SetThirdByCIX()
                SetThirdByOIX()
                SetThirdDefault()
                SetThirdItem()
                SetThirdTypeID()
                SetThirdTypeIDLabel()
                SetThirteenthByCIX()
                SetThirteenthByOIX()
                SetThirteenthDefault()
                SetThirteenthItem()
                SetThirteenthTypeID()
                SetThirteenthTypeIDLabel()
                SetTwelfthByCIX()
                SetTwelfthByOIX()
                SetTwelfthDefault()
                SetTwelfthItem()
                SetTwelfthTypeID()
                SetTwelfthTypeIDLabel()
                SetUseStoredSignature()
                SetUseStoredSignatureLabel()
      
      
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
        
        
        Public Overridable Sub SetAgreement()
            
        
            ' Set the Agreement TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.Agreement is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAgreement()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AgreementSpecified Then
                				
                ' If the Agreement is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.Agreement)
                              
                Me.Agreement.Text = formattedValue
                
            Else 
            
                ' Agreement is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Agreement.Text = AgreementTable.Agreement.Format(AgreementTable.Agreement.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAgreementDownload()
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AgreementFileSpecified Then
                
                Me.AgreementDownload.Text = Me.DataSource.AgreementFileName
                Me.AgreementDownload.ToolTip = "Open " & Me.AgreementDownload.Text
				   If String.IsNullOrEmpty(Me.AgreementDownload.Text) Then
					      Me.AgreementDownload.Text = Page.GetResourceValue("Txt:OpenFile", "FASTPORT")
                Me.AgreementDownload.ToolTip = Me.AgreementDownload.Text
				   End If
						
                Me.AgreementDownload.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("Agreement") & _
                            "&Field=" & Me.Page.Encrypt("AgreementFile") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                            "&Filename=" & Me.DataSource.AgreementFileName & _
                            "','','left=100,top=50,width=400,height=300,resizable, scrollbars=1');return false;"
                   
                Me.AgreementDownload.Visible = True
            Else
                Me.AgreementDownload.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetDescription()
            
        
            ' Set the Description TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.Description is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDescription()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DescriptionSpecified Then
                				
                ' If the Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.Description)
                              
                Me.Description.Text = formattedValue
                
            Else 
            
                ' Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Description.Text = AgreementTable.Description.Format(AgreementTable.Description.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetDocHasCustomFields()
            
        
            ' Set the DocHasCustomFields CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocHasCustomFields is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetDocHasCustomFields()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocHasCustomFieldsSpecified Then
                									
                ' If the DocHasCustomFields is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.DocHasCustomFields.Checked = Me.DataSource.DocHasCustomFields
            Else
            
                ' DocHasCustomFields is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.DocHasCustomFields.Checked = AgreementTable.DocHasCustomFields.ParseValue(AgreementTable.DocHasCustomFields.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetEighthByCIX()
            
        
            ' Set the EighthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetEighthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthByCIXSpecified Then
                									
                ' If the EighthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.EighthByCIX.Checked = Me.DataSource.EighthByCIX
            Else
            
                ' EighthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.EighthByCIX.Checked = AgreementTable.EighthByCIX.ParseValue(AgreementTable.EighthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetEighthByOIX()
            
        
            ' Set the EighthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetEighthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthByOIXSpecified Then
                									
                ' If the EighthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.EighthByOIX.Checked = Me.DataSource.EighthByOIX
            Else
            
                ' EighthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.EighthByOIX.Checked = AgreementTable.EighthByOIX.ParseValue(AgreementTable.EighthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetEighthDefault()
            
        
            ' Set the EighthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthDefaultSpecified Then
                				
                ' If the EighthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EighthDefault)
                              
                Me.EighthDefault.Text = formattedValue
                
            Else 
            
                ' EighthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EighthDefault.Text = AgreementTable.EighthDefault.Format(AgreementTable.EighthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEighthItem()
            
        
            ' Set the EighthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthItemSpecified Then
                				
                ' If the EighthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EighthItem)
                              
                Me.EighthItem.Text = formattedValue
                
            Else 
            
                ' EighthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EighthItem.Text = AgreementTable.EighthItem.Format(AgreementTable.EighthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEighthTypeID()
            
        
            ' Set the EighthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthTypeIDSpecified Then
                            
                ' If the EighthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateEighthTypeIDDropDownList(Me.DataSource.EighthTypeID.ToString(), 100)
                
            Else
                
                ' EighthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateEighthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateEighthTypeIDDropDownList(AgreementTable.EighthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetEleventhByCIX()
            
        
            ' Set the EleventhByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetEleventhByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhByCIXSpecified Then
                									
                ' If the EleventhByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.EleventhByCIX.Checked = Me.DataSource.EleventhByCIX
            Else
            
                ' EleventhByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.EleventhByCIX.Checked = AgreementTable.EleventhByCIX.ParseValue(AgreementTable.EleventhByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetEleventhByOIX()
            
        
            ' Set the EleventhByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetEleventhByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhByOIXSpecified Then
                									
                ' If the EleventhByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.EleventhByOIX.Checked = Me.DataSource.EleventhByOIX
            Else
            
                ' EleventhByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.EleventhByOIX.Checked = AgreementTable.EleventhByOIX.ParseValue(AgreementTable.EleventhByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetEleventhDefault()
            
        
            ' Set the EleventhDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhDefaultSpecified Then
                				
                ' If the EleventhDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EleventhDefault)
                              
                Me.EleventhDefault.Text = formattedValue
                
            Else 
            
                ' EleventhDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhDefault.Text = AgreementTable.EleventhDefault.Format(AgreementTable.EleventhDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEleventhItem()
            
        
            ' Set the EleventhItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhItemSpecified Then
                				
                ' If the EleventhItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EleventhItem)
                              
                Me.EleventhItem.Text = formattedValue
                
            Else 
            
                ' EleventhItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhItem.Text = AgreementTable.EleventhItem.Format(AgreementTable.EleventhItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEleventhTypeID()
            
        
            ' Set the EleventhTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhTypeIDSpecified Then
                            
                ' If the EleventhTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateEleventhTypeIDDropDownList(Me.DataSource.EleventhTypeID.ToString(), 100)
                
            Else
                
                ' EleventhTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateEleventhTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateEleventhTypeIDDropDownList(AgreementTable.EleventhTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetExecuteFromBoard()
            
        
            ' Set the ExecuteFromBoard CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ExecuteFromBoard is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetExecuteFromBoard()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ExecuteFromBoardSpecified Then
                									
                ' If the ExecuteFromBoard is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ExecuteFromBoard.Checked = Me.DataSource.ExecuteFromBoard
            Else
            
                ' ExecuteFromBoard is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ExecuteFromBoard.Checked = AgreementTable.ExecuteFromBoard.ParseValue(AgreementTable.ExecuteFromBoard.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFifteenthByCIX()
            
        
            ' Set the FifteenthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFifteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthByCIXSpecified Then
                									
                ' If the FifteenthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FifteenthByCIX.Checked = Me.DataSource.FifteenthByCIX
            Else
            
                ' FifteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FifteenthByCIX.Checked = AgreementTable.FifteenthByCIX.ParseValue(AgreementTable.FifteenthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFifteenthByOIX()
            
        
            ' Set the FifteenthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFifteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthByOIXSpecified Then
                									
                ' If the FifteenthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FifteenthByOIX.Checked = Me.DataSource.FifteenthByOIX
            Else
            
                ' FifteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FifteenthByOIX.Checked = AgreementTable.FifteenthByOIX.ParseValue(AgreementTable.FifteenthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFifteenthDefault()
            
        
            ' Set the FifteenthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthDefaultSpecified Then
                				
                ' If the FifteenthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifteenthDefault)
                              
                Me.FifteenthDefault.Text = formattedValue
                
            Else 
            
                ' FifteenthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthDefault.Text = AgreementTable.FifteenthDefault.Format(AgreementTable.FifteenthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFifteenthItem()
            
        
            ' Set the FifteenthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthItemSpecified Then
                				
                ' If the FifteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifteenthItem)
                              
                Me.FifteenthItem.Text = formattedValue
                
            Else 
            
                ' FifteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthItem.Text = AgreementTable.FifteenthItem.Format(AgreementTable.FifteenthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFifteenthTypeID()
            
        
            ' Set the FifteenthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthTypeIDSpecified Then
                            
                ' If the FifteenthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFifteenthTypeIDDropDownList(Me.DataSource.FifteenthTypeID.ToString(), 100)
                
            Else
                
                ' FifteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFifteenthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFifteenthTypeIDDropDownList(AgreementTable.FifteenthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetFifthByCIX()
            
        
            ' Set the FifthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFifthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthByCIXSpecified Then
                									
                ' If the FifthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FifthByCIX.Checked = Me.DataSource.FifthByCIX
            Else
            
                ' FifthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FifthByCIX.Checked = AgreementTable.FifthByCIX.ParseValue(AgreementTable.FifthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFifthByOIX()
            
        
            ' Set the FifthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFifthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthByOIXSpecified Then
                									
                ' If the FifthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FifthByOIX.Checked = Me.DataSource.FifthByOIX
            Else
            
                ' FifthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FifthByOIX.Checked = AgreementTable.FifthByOIX.ParseValue(AgreementTable.FifthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFifthDefault()
            
        
            ' Set the FifthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthDefaultSpecified Then
                				
                ' If the FifthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifthDefault)
                              
                Me.FifthDefault.Text = formattedValue
                
            Else 
            
                ' FifthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifthDefault.Text = AgreementTable.FifthDefault.Format(AgreementTable.FifthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFifthItem()
            
        
            ' Set the FifthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthItemSpecified Then
                				
                ' If the FifthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifthItem)
                              
                Me.FifthItem.Text = formattedValue
                
            Else 
            
                ' FifthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifthItem.Text = AgreementTable.FifthItem.Format(AgreementTable.FifthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFifthTypeID()
            
        
            ' Set the FifthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthTypeIDSpecified Then
                            
                ' If the FifthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFifthTypeIDDropDownList(Me.DataSource.FifthTypeID.ToString(), 100)
                
            Else
                
                ' FifthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFifthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFifthTypeIDDropDownList(AgreementTable.FifthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetFirstByCIX()
            
        
            ' Set the FirstByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFirstByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstByCIXSpecified Then
                									
                ' If the FirstByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FirstByCIX.Checked = Me.DataSource.FirstByCIX
            Else
            
                ' FirstByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FirstByCIX.Checked = AgreementTable.FirstByCIX.ParseValue(AgreementTable.FirstByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFirstByOIX()
            
        
            ' Set the FirstByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFirstByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstByOIXSpecified Then
                									
                ' If the FirstByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FirstByOIX.Checked = Me.DataSource.FirstByOIX
            Else
            
                ' FirstByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FirstByOIX.Checked = AgreementTable.FirstByOIX.ParseValue(AgreementTable.FirstByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFirstDefault()
            
        
            ' Set the FirstDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstDefaultSpecified Then
                				
                ' If the FirstDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FirstDefault)
                              
                Me.FirstDefault.Text = formattedValue
                
            Else 
            
                ' FirstDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FirstDefault.Text = AgreementTable.FirstDefault.Format(AgreementTable.FirstDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFirstItem()
            
        
            ' Set the FirstItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstItemSpecified Then
                				
                ' If the FirstItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FirstItem)
                              
                Me.FirstItem.Text = formattedValue
                
            Else 
            
                ' FirstItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FirstItem.Text = AgreementTable.FirstItem.Format(AgreementTable.FirstItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFirstTypeID()
            
        
            ' Set the FirstTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstTypeIDSpecified Then
                            
                ' If the FirstTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFirstTypeIDDropDownList(Me.DataSource.FirstTypeID.ToString(), 100)
                
            Else
                
                ' FirstTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFirstTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFirstTypeIDDropDownList(AgreementTable.FirstTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetFlowCollectionID()
            
        
            ' Set the FlowCollectionID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FlowCollectionID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFlowCollectionID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FlowCollectionIDSpecified Then
                            
                ' If the FlowCollectionID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFlowCollectionIDDropDownList(Me.DataSource.FlowCollectionID.ToString(), 100)
                
            Else
                
                ' FlowCollectionID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFlowCollectionIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFlowCollectionIDDropDownList(AgreementTable.FlowCollectionID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetFourteenthByCIX()
            
        
            ' Set the FourteenthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFourteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthByCIXSpecified Then
                									
                ' If the FourteenthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FourteenthByCIX.Checked = Me.DataSource.FourteenthByCIX
            Else
            
                ' FourteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FourteenthByCIX.Checked = AgreementTable.FourteenthByCIX.ParseValue(AgreementTable.FourteenthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFourteenthByOIX()
            
        
            ' Set the FourteenthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFourteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthByOIXSpecified Then
                									
                ' If the FourteenthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FourteenthByOIX.Checked = Me.DataSource.FourteenthByOIX
            Else
            
                ' FourteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FourteenthByOIX.Checked = AgreementTable.FourteenthByOIX.ParseValue(AgreementTable.FourteenthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFourteenthDefault()
            
        
            ' Set the FourteenthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthDefaultSpecified Then
                				
                ' If the FourteenthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourteenthDefault)
                              
                Me.FourteenthDefault.Text = formattedValue
                
            Else 
            
                ' FourteenthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthDefault.Text = AgreementTable.FourteenthDefault.Format(AgreementTable.FourteenthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFourteenthItem()
            
        
            ' Set the FourteenthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthItemSpecified Then
                				
                ' If the FourteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourteenthItem)
                              
                Me.FourteenthItem.Text = formattedValue
                
            Else 
            
                ' FourteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthItem.Text = AgreementTable.FourteenthItem.Format(AgreementTable.FourteenthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFourteenthTypeID()
            
        
            ' Set the FourteenthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthTypeIDSpecified Then
                            
                ' If the FourteenthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFourteenthTypeIDDropDownList(Me.DataSource.FourteenthTypeID.ToString(), 100)
                
            Else
                
                ' FourteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFourteenthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFourteenthTypeIDDropDownList(AgreementTable.FourteenthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetFourthByCIX()
            
        
            ' Set the FourthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFourthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthByCIXSpecified Then
                									
                ' If the FourthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FourthByCIX.Checked = Me.DataSource.FourthByCIX
            Else
            
                ' FourthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FourthByCIX.Checked = AgreementTable.FourthByCIX.ParseValue(AgreementTable.FourthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFourthByOIX()
            
        
            ' Set the FourthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetFourthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthByOIXSpecified Then
                									
                ' If the FourthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.FourthByOIX.Checked = Me.DataSource.FourthByOIX
            Else
            
                ' FourthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.FourthByOIX.Checked = AgreementTable.FourthByOIX.ParseValue(AgreementTable.FourthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetFourthDefault()
            
        
            ' Set the FourthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthDefaultSpecified Then
                				
                ' If the FourthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourthDefault)
                              
                Me.FourthDefault.Text = formattedValue
                
            Else 
            
                ' FourthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthDefault.Text = AgreementTable.FourthDefault.Format(AgreementTable.FourthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFourthItem()
            
        
            ' Set the FourthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthItemSpecified Then
                				
                ' If the FourthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourthItem)
                              
                Me.FourthItem.Text = formattedValue
                
            Else 
            
                ' FourthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthItem.Text = AgreementTable.FourthItem.Format(AgreementTable.FourthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFourthTypeID()
            
        
            ' Set the FourthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthTypeIDSpecified Then
                            
                ' If the FourthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateFourthTypeIDDropDownList(Me.DataSource.FourthTypeID.ToString(), 100)
                
            Else
                
                ' FourthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateFourthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateFourthTypeIDDropDownList(AgreementTable.FourthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetInitialsInDocument()
            
        
            ' Set the InitialsInDocument CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.InitialsInDocument is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetInitialsInDocument()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.InitialsInDocumentSpecified Then
                									
                ' If the InitialsInDocument is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.InitialsInDocument.Checked = Me.DataSource.InitialsInDocument
            Else
            
                ' InitialsInDocument is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.InitialsInDocument.Checked = AgreementTable.InitialsInDocument.ParseValue(AgreementTable.InitialsInDocument.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetNinthByCIX()
            
        
            ' Set the NinthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetNinthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthByCIXSpecified Then
                									
                ' If the NinthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.NinthByCIX.Checked = Me.DataSource.NinthByCIX
            Else
            
                ' NinthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.NinthByCIX.Checked = AgreementTable.NinthByCIX.ParseValue(AgreementTable.NinthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetNinthByOIX()
            
        
            ' Set the NinthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetNinthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthByOIXSpecified Then
                									
                ' If the NinthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.NinthByOIX.Checked = Me.DataSource.NinthByOIX
            Else
            
                ' NinthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.NinthByOIX.Checked = AgreementTable.NinthByOIX.ParseValue(AgreementTable.NinthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetNinthDefault()
            
        
            ' Set the NinthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthDefaultSpecified Then
                				
                ' If the NinthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.NinthDefault)
                              
                Me.NinthDefault.Text = formattedValue
                
            Else 
            
                ' NinthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.NinthDefault.Text = AgreementTable.NinthDefault.Format(AgreementTable.NinthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetNinthItem()
            
        
            ' Set the NinthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthItemSpecified Then
                				
                ' If the NinthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.NinthItem)
                              
                Me.NinthItem.Text = formattedValue
                
            Else 
            
                ' NinthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.NinthItem.Text = AgreementTable.NinthItem.Format(AgreementTable.NinthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetNinthTypeID()
            
        
            ' Set the NinthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthTypeIDSpecified Then
                            
                ' If the NinthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateNinthTypeIDDropDownList(Me.DataSource.NinthTypeID.ToString(), 100)
                
            Else
                
                ' NinthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateNinthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateNinthTypeIDDropDownList(AgreementTable.NinthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetOtherInstructions()
            
        
            ' Set the OtherInstructions TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.OtherInstructions is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetOtherInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.OtherInstructionsSpecified Then
                				
                ' If the OtherInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.OtherInstructions)
                              
                Me.OtherInstructions.Content = formattedValue               
              
            Else 
            
                ' OtherInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
            Me.OtherInstructions.Content = AgreementTable.OtherInstructions.Format(AgreementTable.OtherInstructions.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetRecipientInstructions()
            
        
            ' Set the RecipientInstructions TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RecipientInstructions is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRecipientInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RecipientInstructionsSpecified Then
                				
                ' If the RecipientInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.RecipientInstructions)
                              
                Me.RecipientInstructions.Content = formattedValue               
              
            Else 
            
                ' RecipientInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
            Me.RecipientInstructions.Content = AgreementTable.RecipientInstructions.Format(AgreementTable.RecipientInstructions.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetRequiredDoc()
            
        
            ' Set the RequiredDoc CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RequiredDoc is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetRequiredDoc()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RequiredDocSpecified Then
                									
                ' If the RequiredDoc is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.RequiredDoc.Checked = Me.DataSource.RequiredDoc
            Else
            
                ' RequiredDoc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.RequiredDoc.Checked = AgreementTable.RequiredDoc.ParseValue(AgreementTable.RequiredDoc.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetRoleID()
            
        
            ' Set the RoleID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RoleID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRoleID()
            ' and add your own code before or after the call to the MyBase function.

            
            ' Default Value could also be NULL.
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                
                Me.PopulateRoleIDDropDownList(Me.DataSource.RoleID.ToString(), 100)
                
            Else
                
            
                Me.PopulateRoleIDDropDownList(EvaluateFormula("URL(""Role"")"), 100)
                
            End If

            
        End Sub
                
        Public Overridable Sub SetSecondByCIX()
            
        
            ' Set the SecondByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSecondByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondByCIXSpecified Then
                									
                ' If the SecondByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SecondByCIX.Checked = Me.DataSource.SecondByCIX
            Else
            
                ' SecondByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SecondByCIX.Checked = AgreementTable.SecondByCIX.ParseValue(AgreementTable.SecondByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSecondByOIX()
            
        
            ' Set the SecondByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSecondByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondByOIXSpecified Then
                									
                ' If the SecondByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SecondByOIX.Checked = Me.DataSource.SecondByOIX
            Else
            
                ' SecondByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SecondByOIX.Checked = AgreementTable.SecondByOIX.ParseValue(AgreementTable.SecondByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSecondDefault()
            
        
            ' Set the SecondDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondDefaultSpecified Then
                				
                ' If the SecondDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SecondDefault)
                              
                Me.SecondDefault.Text = formattedValue
                
            Else 
            
                ' SecondDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SecondDefault.Text = AgreementTable.SecondDefault.Format(AgreementTable.SecondDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSecondItem()
            
        
            ' Set the SecondItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondItemSpecified Then
                				
                ' If the SecondItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SecondItem)
                              
                Me.SecondItem.Text = formattedValue
                
            Else 
            
                ' SecondItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SecondItem.Text = AgreementTable.SecondItem.Format(AgreementTable.SecondItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSecondTypeID()
            
        
            ' Set the SecondTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondTypeIDSpecified Then
                            
                ' If the SecondTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateSecondTypeIDDropDownList(Me.DataSource.SecondTypeID.ToString(), 100)
                
            Else
                
                ' SecondTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateSecondTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateSecondTypeIDDropDownList(AgreementTable.SecondTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetSenderInstructions()
            
        
            ' Set the SenderInstructions TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SenderInstructions is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSenderInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SenderInstructionsSpecified Then
                				
                ' If the SenderInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SenderInstructions)
                              
                Me.SenderInstructions.Content = formattedValue               
              
            Else 
            
                ' SenderInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
            Me.SenderInstructions.Content = AgreementTable.SenderInstructions.Format(AgreementTable.SenderInstructions.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSeventhByCIX()
            
        
            ' Set the SeventhByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSeventhByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhByCIXSpecified Then
                									
                ' If the SeventhByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SeventhByCIX.Checked = Me.DataSource.SeventhByCIX
            Else
            
                ' SeventhByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SeventhByCIX.Checked = AgreementTable.SeventhByCIX.ParseValue(AgreementTable.SeventhByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSeventhByOIX()
            
        
            ' Set the SeventhByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSeventhByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhByOIXSpecified Then
                									
                ' If the SeventhByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SeventhByOIX.Checked = Me.DataSource.SeventhByOIX
            Else
            
                ' SeventhByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SeventhByOIX.Checked = AgreementTable.SeventhByOIX.ParseValue(AgreementTable.SeventhByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSeventhDefault()
            
        
            ' Set the SeventhDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhDefaultSpecified Then
                				
                ' If the SeventhDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SeventhDefault)
                              
                Me.SeventhDefault.Text = formattedValue
                
            Else 
            
                ' SeventhDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SeventhDefault.Text = AgreementTable.SeventhDefault.Format(AgreementTable.SeventhDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSeventhItem()
            
        
            ' Set the SeventhItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhItemSpecified Then
                				
                ' If the SeventhItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SeventhItem)
                              
                Me.SeventhItem.Text = formattedValue
                
            Else 
            
                ' SeventhItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SeventhItem.Text = AgreementTable.SeventhItem.Format(AgreementTable.SeventhItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSeventhTypeID()
            
        
            ' Set the SeventhTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhTypeIDSpecified Then
                            
                ' If the SeventhTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateSeventhTypeIDDropDownList(Me.DataSource.SeventhTypeID.ToString(), 100)
                
            Else
                
                ' SeventhTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateSeventhTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateSeventhTypeIDDropDownList(AgreementTable.SeventhTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetShowExpirationDate()
            
        
            ' Set the ShowExpirationDate CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ShowExpirationDate is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetShowExpirationDate()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ShowExpirationDateSpecified Then
                									
                ' If the ShowExpirationDate is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ShowExpirationDate.Checked = Me.DataSource.ShowExpirationDate
            Else
            
                ' ShowExpirationDate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ShowExpirationDate.Checked = AgreementTable.ShowExpirationDate.ParseValue(AgreementTable.ShowExpirationDate.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetShowSignatureDate()
            
        
            ' Set the ShowSignatureDate CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ShowSignatureDate is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetShowSignatureDate()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ShowSignatureDateSpecified Then
                									
                ' If the ShowSignatureDate is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ShowSignatureDate.Checked = Me.DataSource.ShowSignatureDate
            Else
            
                ' ShowSignatureDate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ShowSignatureDate.Checked = AgreementTable.ShowSignatureDate.ParseValue(AgreementTable.ShowSignatureDate.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSixthByCIX()
            
        
            ' Set the SixthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSixthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthByCIXSpecified Then
                									
                ' If the SixthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SixthByCIX.Checked = Me.DataSource.SixthByCIX
            Else
            
                ' SixthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SixthByCIX.Checked = AgreementTable.SixthByCIX.ParseValue(AgreementTable.SixthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSixthByOIX()
            
        
            ' Set the SixthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetSixthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthByOIXSpecified Then
                									
                ' If the SixthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.SixthByOIX.Checked = Me.DataSource.SixthByOIX
            Else
            
                ' SixthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.SixthByOIX.Checked = AgreementTable.SixthByOIX.ParseValue(AgreementTable.SixthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetSixthDefault()
            
        
            ' Set the SixthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthDefaultSpecified Then
                				
                ' If the SixthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SixthDefault)
                              
                Me.SixthDefault.Text = formattedValue
                
            Else 
            
                ' SixthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SixthDefault.Text = AgreementTable.SixthDefault.Format(AgreementTable.SixthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSixthItem()
            
        
            ' Set the SixthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthItemSpecified Then
                				
                ' If the SixthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SixthItem)
                              
                Me.SixthItem.Text = formattedValue
                
            Else 
            
                ' SixthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SixthItem.Text = AgreementTable.SixthItem.Format(AgreementTable.SixthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetSixthTypeID()
            
        
            ' Set the SixthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthTypeIDSpecified Then
                            
                ' If the SixthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateSixthTypeIDDropDownList(Me.DataSource.SixthTypeID.ToString(), 100)
                
            Else
                
                ' SixthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateSixthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateSixthTypeIDDropDownList(AgreementTable.SixthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetTenthByCIX()
            
        
            ' Set the TenthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetTenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthByCIXSpecified Then
                									
                ' If the TenthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.TenthByCIX.Checked = Me.DataSource.TenthByCIX
            Else
            
                ' TenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.TenthByCIX.Checked = AgreementTable.TenthByCIX.ParseValue(AgreementTable.TenthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetTenthByOIX()
            
        
            ' Set the TenthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetTenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthByOIXSpecified Then
                									
                ' If the TenthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.TenthByOIX.Checked = Me.DataSource.TenthByOIX
            Else
            
                ' TenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.TenthByOIX.Checked = AgreementTable.TenthByOIX.ParseValue(AgreementTable.TenthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetTenthDefault()
            
        
            ' Set the TenthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthDefaultSpecified Then
                				
                ' If the TenthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TenthDefault)
                              
                Me.TenthDefault.Text = formattedValue
                
            Else 
            
                ' TenthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TenthDefault.Text = AgreementTable.TenthDefault.Format(AgreementTable.TenthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTenthItem()
            
        
            ' Set the TenthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthItemSpecified Then
                				
                ' If the TenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TenthItem)
                              
                Me.TenthItem.Text = formattedValue
                
            Else 
            
                ' TenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TenthItem.Text = AgreementTable.TenthItem.Format(AgreementTable.TenthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTenthTypeID()
            
        
            ' Set the TenthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthTypeIDSpecified Then
                            
                ' If the TenthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateTenthTypeIDDropDownList(Me.DataSource.TenthTypeID.ToString(), 100)
                
            Else
                
                ' TenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateTenthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateTenthTypeIDDropDownList(AgreementTable.TenthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetThirdByCIX()
            
        
            ' Set the ThirdByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetThirdByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdByCIXSpecified Then
                									
                ' If the ThirdByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ThirdByCIX.Checked = Me.DataSource.ThirdByCIX
            Else
            
                ' ThirdByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ThirdByCIX.Checked = AgreementTable.ThirdByCIX.ParseValue(AgreementTable.ThirdByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetThirdByOIX()
            
        
            ' Set the ThirdByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetThirdByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdByOIXSpecified Then
                									
                ' If the ThirdByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ThirdByOIX.Checked = Me.DataSource.ThirdByOIX
            Else
            
                ' ThirdByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ThirdByOIX.Checked = AgreementTable.ThirdByOIX.ParseValue(AgreementTable.ThirdByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetThirdDefault()
            
        
            ' Set the ThirdDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdDefaultSpecified Then
                				
                ' If the ThirdDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirdDefault)
                              
                Me.ThirdDefault.Text = formattedValue
                
            Else 
            
                ' ThirdDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirdDefault.Text = AgreementTable.ThirdDefault.Format(AgreementTable.ThirdDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetThirdItem()
            
        
            ' Set the ThirdItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdItemSpecified Then
                				
                ' If the ThirdItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirdItem)
                              
                Me.ThirdItem.Text = formattedValue
                
            Else 
            
                ' ThirdItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirdItem.Text = AgreementTable.ThirdItem.Format(AgreementTable.ThirdItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetThirdTypeID()
            
        
            ' Set the ThirdTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdTypeIDSpecified Then
                            
                ' If the ThirdTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateThirdTypeIDDropDownList(Me.DataSource.ThirdTypeID.ToString(), 100)
                
            Else
                
                ' ThirdTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateThirdTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateThirdTypeIDDropDownList(AgreementTable.ThirdTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetThirteenthByCIX()
            
        
            ' Set the ThirteenthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetThirteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthByCIXSpecified Then
                									
                ' If the ThirteenthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ThirteenthByCIX.Checked = Me.DataSource.ThirteenthByCIX
            Else
            
                ' ThirteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ThirteenthByCIX.Checked = AgreementTable.ThirteenthByCIX.ParseValue(AgreementTable.ThirteenthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetThirteenthByOIX()
            
        
            ' Set the ThirteenthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetThirteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthByOIXSpecified Then
                									
                ' If the ThirteenthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.ThirteenthByOIX.Checked = Me.DataSource.ThirteenthByOIX
            Else
            
                ' ThirteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.ThirteenthByOIX.Checked = AgreementTable.ThirteenthByOIX.ParseValue(AgreementTable.ThirteenthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetThirteenthDefault()
            
        
            ' Set the ThirteenthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthDefaultSpecified Then
                				
                ' If the ThirteenthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirteenthDefault)
                              
                Me.ThirteenthDefault.Text = formattedValue
                
            Else 
            
                ' ThirteenthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthDefault.Text = AgreementTable.ThirteenthDefault.Format(AgreementTable.ThirteenthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetThirteenthItem()
            
        
            ' Set the ThirteenthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthItemSpecified Then
                				
                ' If the ThirteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirteenthItem)
                              
                Me.ThirteenthItem.Text = formattedValue
                
            Else 
            
                ' ThirteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthItem.Text = AgreementTable.ThirteenthItem.Format(AgreementTable.ThirteenthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetThirteenthTypeID()
            
        
            ' Set the ThirteenthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthTypeIDSpecified Then
                            
                ' If the ThirteenthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateThirteenthTypeIDDropDownList(Me.DataSource.ThirteenthTypeID.ToString(), 100)
                
            Else
                
                ' ThirteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateThirteenthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateThirteenthTypeIDDropDownList(AgreementTable.ThirteenthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetTwelfthByCIX()
            
        
            ' Set the TwelfthByCIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthByCIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetTwelfthByCIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthByCIXSpecified Then
                									
                ' If the TwelfthByCIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.TwelfthByCIX.Checked = Me.DataSource.TwelfthByCIX
            Else
            
                ' TwelfthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.TwelfthByCIX.Checked = AgreementTable.TwelfthByCIX.ParseValue(AgreementTable.TwelfthByCIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetTwelfthByOIX()
            
        
            ' Set the TwelfthByOIX CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthByOIX is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetTwelfthByOIX()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthByOIXSpecified Then
                									
                ' If the TwelfthByOIX is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.TwelfthByOIX.Checked = Me.DataSource.TwelfthByOIX
            Else
            
                ' TwelfthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.TwelfthByOIX.Checked = AgreementTable.TwelfthByOIX.ParseValue(AgreementTable.TwelfthByOIX.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetTwelfthDefault()
            
        
            ' Set the TwelfthDefault TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthDefault is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthDefault()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthDefaultSpecified Then
                				
                ' If the TwelfthDefault is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TwelfthDefault)
                              
                Me.TwelfthDefault.Text = formattedValue
                
            Else 
            
                ' TwelfthDefault is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthDefault.Text = AgreementTable.TwelfthDefault.Format(AgreementTable.TwelfthDefault.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTwelfthItem()
            
        
            ' Set the TwelfthItem TextBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthItem is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthItemSpecified Then
                				
                ' If the TwelfthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TwelfthItem)
                              
                Me.TwelfthItem.Text = formattedValue
                
            Else 
            
                ' TwelfthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthItem.Text = AgreementTable.TwelfthItem.Format(AgreementTable.TwelfthItem.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTwelfthTypeID()
            
        
            ' Set the TwelfthTypeID DropDownList on the webpage with value from the
            ' Agreement database record.
            
            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthTypeID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthTypeIDSpecified Then
                            
                ' If the TwelfthTypeID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateTwelfthTypeIDDropDownList(Me.DataSource.TwelfthTypeID.ToString(), 100)
                
            Else
                
                ' TwelfthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateTwelfthTypeIDDropDownList(Nothing, 100)
                Else
                    Me.PopulateTwelfthTypeIDDropDownList(AgreementTable.TwelfthTypeID.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub SetUseStoredSignature()
            
        
            ' Set the UseStoredSignature CheckBox on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.UseStoredSignature is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetUseStoredSignature()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UseStoredSignatureSpecified Then
                									
                ' If the UseStoredSignature is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.UseStoredSignature.Checked = Me.DataSource.UseStoredSignature
            Else
            
                ' UseStoredSignature is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.UseStoredSignature.Checked = AgreementTable.UseStoredSignature.ParseValue(AgreementTable.UseStoredSignature.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetAgreementFileLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AgreementFileLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAgreementLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AgreementLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetCustomFieldsSrollPanel()
                  
                  End Sub
                
        Public Overridable Sub SetCustomInstructionsSrollPanel()
                  
                  End Sub
                
        Public Overridable Sub SetDefaultLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.DefaultLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetDescriptionLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocHasCustomFieldsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.EighthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetEleventhTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.EleventhTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetExecuteFromBoardLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ExecuteFromBoardLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFieldLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FieldLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFieldTypeLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FieldTypeLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFifteenthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FifteenthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFifthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FifthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFirstTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FirstTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFlowCollectionIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetForLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ForLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFourteenthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FourteenthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFourthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FourthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetInitialsInDocumentLabel()
                  
                  End Sub
                
        Public Overridable Sub SetItemLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ItemLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetNinthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.NinthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetOnlyCIXLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.OnlyCIXLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetOnlyOIXLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.OnlyOIXLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetOtherInstructionsLbl()
                  
                  End Sub
                
        Public Overridable Sub SetRecipientInstrucitonsLbl()
                  
                  End Sub
                
        Public Overridable Sub SetRequiredDocLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.RoleIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSecondTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SecondTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSenderInstrucitonsLbl()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SeventhTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetShowExpirationDateLabel()
                  
                  End Sub
                
        Public Overridable Sub SetShowSignatureDateLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SixthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTenthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.TenthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetThirdTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ThirdTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetThirteenthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ThirteenthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTwelfthTypeIDLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.TwelfthTypeIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetUseStoredSignatureLabel()
                  
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

            If includeDS
                
            End IF
            
            
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
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()
        
        
        End Sub

      
        
        ' To customize, override this method in AgreementRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "AgreementRecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        End Sub

        ' To customize, override this method in AgreementRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAgreement()
            GetAgreementFile()
            GetDescription()
            GetDocHasCustomFields()
            GetEighthByCIX()
            GetEighthByOIX()
            GetEighthDefault()
            GetEighthItem()
            GetEighthTypeID()
            GetEleventhByCIX()
            GetEleventhByOIX()
            GetEleventhDefault()
            GetEleventhItem()
            GetEleventhTypeID()
            GetExecuteFromBoard()
            GetFifteenthByCIX()
            GetFifteenthByOIX()
            GetFifteenthDefault()
            GetFifteenthItem()
            GetFifteenthTypeID()
            GetFifthByCIX()
            GetFifthByOIX()
            GetFifthDefault()
            GetFifthItem()
            GetFifthTypeID()
            GetFirstByCIX()
            GetFirstByOIX()
            GetFirstDefault()
            GetFirstItem()
            GetFirstTypeID()
            GetFlowCollectionID()
            GetFourteenthByCIX()
            GetFourteenthByOIX()
            GetFourteenthDefault()
            GetFourteenthItem()
            GetFourteenthTypeID()
            GetFourthByCIX()
            GetFourthByOIX()
            GetFourthDefault()
            GetFourthItem()
            GetFourthTypeID()
            GetInitialsInDocument()
            GetNinthByCIX()
            GetNinthByOIX()
            GetNinthDefault()
            GetNinthItem()
            GetNinthTypeID()
            GetOtherInstructions()
            GetRecipientInstructions()
            GetRequiredDoc()
            GetRoleID()
            GetSecondByCIX()
            GetSecondByOIX()
            GetSecondDefault()
            GetSecondItem()
            GetSecondTypeID()
            GetSenderInstructions()
            GetSeventhByCIX()
            GetSeventhByOIX()
            GetSeventhDefault()
            GetSeventhItem()
            GetSeventhTypeID()
            GetShowExpirationDate()
            GetShowSignatureDate()
            GetSixthByCIX()
            GetSixthByOIX()
            GetSixthDefault()
            GetSixthItem()
            GetSixthTypeID()
            GetTenthByCIX()
            GetTenthByOIX()
            GetTenthDefault()
            GetTenthItem()
            GetTenthTypeID()
            GetThirdByCIX()
            GetThirdByOIX()
            GetThirdDefault()
            GetThirdItem()
            GetThirdTypeID()
            GetThirteenthByCIX()
            GetThirteenthByOIX()
            GetThirteenthDefault()
            GetThirteenthItem()
            GetThirteenthTypeID()
            GetTwelfthByCIX()
            GetTwelfthByOIX()
            GetTwelfthDefault()
            GetTwelfthItem()
            GetTwelfthTypeID()
            GetUseStoredSignature()
        End Sub
        
        
        Public Overridable Sub GetAgreement()
            
            ' Retrieve the value entered by the user on the Agreement ASP:TextBox, and
            ' save it into the Agreement field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Agreement.Text, AgreementTable.Agreement)			

                      
        End Sub
                
        Public Overridable Sub GetAgreementFile()
            ' Retrieve the value entered by the user on the AgreementFile ASP:FileUpload, and
            ' save it into the AgreementFile field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
                  
            If Not Me.AgreementFile.PostedFile is Nothing then  
                If Me.AgreementFile.PostedFile.FileName.Length > 0 AndAlso Me.AgreementFile.PostedFile.ContentLength > 0 Then
                      ' Retrieve the file contents and store them in AgreementFile field.
					  Me.DataSource.Parse(MiscUtils.GetFileContent(Me.AgreementFile.PostedFile), AgreementTable.AgreementFile)
                  
                End If
            End If
        End Sub
                
        Public Overridable Sub GetDescription()
            
            ' Retrieve the value entered by the user on the Description ASP:TextBox, and
            ' save it into the Description field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Description.Text, AgreementTable.Description)			

                      
        End Sub
                
        Public Overridable Sub GetDocHasCustomFields()
        
        
            ' Retrieve the value entered by the user on the DocHasCustomFields ASP:CheckBox, and
            ' save it into the DocHasCustomFields field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.DocHasCustomFields = Me.DocHasCustomFields.Checked
                    
        End Sub
                
        Public Overridable Sub GetEighthByCIX()
        
        
            ' Retrieve the value entered by the user on the EighthByCIX ASP:CheckBox, and
            ' save it into the EighthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.EighthByCIX = Me.EighthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetEighthByOIX()
        
        
            ' Retrieve the value entered by the user on the EighthByOIX ASP:CheckBox, and
            ' save it into the EighthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.EighthByOIX = Me.EighthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetEighthDefault()
            
            ' Retrieve the value entered by the user on the EighthDefault ASP:TextBox, and
            ' save it into the EighthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.EighthDefault.Text, AgreementTable.EighthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetEighthItem()
            
            ' Retrieve the value entered by the user on the EighthItem ASP:TextBox, and
            ' save it into the EighthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.EighthItem.Text, AgreementTable.EighthItem)			

                      
        End Sub
                
        Public Overridable Sub GetEighthTypeID()
         
            ' Retrieve the value entered by the user on the EighthTypeID ASP:DropDownList, and
            ' save it into the EighthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.EighthTypeID), AgreementTable.EighthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetEleventhByCIX()
        
        
            ' Retrieve the value entered by the user on the EleventhByCIX ASP:CheckBox, and
            ' save it into the EleventhByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.EleventhByCIX = Me.EleventhByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetEleventhByOIX()
        
        
            ' Retrieve the value entered by the user on the EleventhByOIX ASP:CheckBox, and
            ' save it into the EleventhByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.EleventhByOIX = Me.EleventhByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetEleventhDefault()
            
            ' Retrieve the value entered by the user on the EleventhDefault ASP:TextBox, and
            ' save it into the EleventhDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.EleventhDefault.Text, AgreementTable.EleventhDefault)			

                      
        End Sub
                
        Public Overridable Sub GetEleventhItem()
            
            ' Retrieve the value entered by the user on the EleventhItem ASP:TextBox, and
            ' save it into the EleventhItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.EleventhItem.Text, AgreementTable.EleventhItem)			

                      
        End Sub
                
        Public Overridable Sub GetEleventhTypeID()
         
            ' Retrieve the value entered by the user on the EleventhTypeID ASP:DropDownList, and
            ' save it into the EleventhTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.EleventhTypeID), AgreementTable.EleventhTypeID)				
            
        End Sub
                
        Public Overridable Sub GetExecuteFromBoard()
        
        
            ' Retrieve the value entered by the user on the ExecuteFromBoard ASP:CheckBox, and
            ' save it into the ExecuteFromBoard field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ExecuteFromBoard = Me.ExecuteFromBoard.Checked
                    
        End Sub
                
        Public Overridable Sub GetFifteenthByCIX()
        
        
            ' Retrieve the value entered by the user on the FifteenthByCIX ASP:CheckBox, and
            ' save it into the FifteenthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FifteenthByCIX = Me.FifteenthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFifteenthByOIX()
        
        
            ' Retrieve the value entered by the user on the FifteenthByOIX ASP:CheckBox, and
            ' save it into the FifteenthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FifteenthByOIX = Me.FifteenthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFifteenthDefault()
            
            ' Retrieve the value entered by the user on the FifteenthDefault ASP:TextBox, and
            ' save it into the FifteenthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FifteenthDefault.Text, AgreementTable.FifteenthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetFifteenthItem()
            
            ' Retrieve the value entered by the user on the FifteenthItem ASP:TextBox, and
            ' save it into the FifteenthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FifteenthItem.Text, AgreementTable.FifteenthItem)			

                      
        End Sub
                
        Public Overridable Sub GetFifteenthTypeID()
         
            ' Retrieve the value entered by the user on the FifteenthTypeID ASP:DropDownList, and
            ' save it into the FifteenthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FifteenthTypeID), AgreementTable.FifteenthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetFifthByCIX()
        
        
            ' Retrieve the value entered by the user on the FifthByCIX ASP:CheckBox, and
            ' save it into the FifthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FifthByCIX = Me.FifthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFifthByOIX()
        
        
            ' Retrieve the value entered by the user on the FifthByOIX ASP:CheckBox, and
            ' save it into the FifthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FifthByOIX = Me.FifthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFifthDefault()
            
            ' Retrieve the value entered by the user on the FifthDefault ASP:TextBox, and
            ' save it into the FifthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FifthDefault.Text, AgreementTable.FifthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetFifthItem()
            
            ' Retrieve the value entered by the user on the FifthItem ASP:TextBox, and
            ' save it into the FifthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FifthItem.Text, AgreementTable.FifthItem)			

                      
        End Sub
                
        Public Overridable Sub GetFifthTypeID()
         
            ' Retrieve the value entered by the user on the FifthTypeID ASP:DropDownList, and
            ' save it into the FifthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FifthTypeID), AgreementTable.FifthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetFirstByCIX()
        
        
            ' Retrieve the value entered by the user on the FirstByCIX ASP:CheckBox, and
            ' save it into the FirstByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FirstByCIX = Me.FirstByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFirstByOIX()
        
        
            ' Retrieve the value entered by the user on the FirstByOIX ASP:CheckBox, and
            ' save it into the FirstByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FirstByOIX = Me.FirstByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFirstDefault()
            
            ' Retrieve the value entered by the user on the FirstDefault ASP:TextBox, and
            ' save it into the FirstDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FirstDefault.Text, AgreementTable.FirstDefault)			

                      
        End Sub
                
        Public Overridable Sub GetFirstItem()
            
            ' Retrieve the value entered by the user on the FirstItem ASP:TextBox, and
            ' save it into the FirstItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FirstItem.Text, AgreementTable.FirstItem)			

                      
        End Sub
                
        Public Overridable Sub GetFirstTypeID()
         
            ' Retrieve the value entered by the user on the FirstTypeID ASP:DropDownList, and
            ' save it into the FirstTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FirstTypeID), AgreementTable.FirstTypeID)				
            
        End Sub
                
        Public Overridable Sub GetFlowCollectionID()
         
            ' Retrieve the value entered by the user on the FlowCollectionID ASP:DropDownList, and
            ' save it into the FlowCollectionID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FlowCollectionID), AgreementTable.FlowCollectionID)				
            
        End Sub
                
        Public Overridable Sub GetFourteenthByCIX()
        
        
            ' Retrieve the value entered by the user on the FourteenthByCIX ASP:CheckBox, and
            ' save it into the FourteenthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FourteenthByCIX = Me.FourteenthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFourteenthByOIX()
        
        
            ' Retrieve the value entered by the user on the FourteenthByOIX ASP:CheckBox, and
            ' save it into the FourteenthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FourteenthByOIX = Me.FourteenthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFourteenthDefault()
            
            ' Retrieve the value entered by the user on the FourteenthDefault ASP:TextBox, and
            ' save it into the FourteenthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FourteenthDefault.Text, AgreementTable.FourteenthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetFourteenthItem()
            
            ' Retrieve the value entered by the user on the FourteenthItem ASP:TextBox, and
            ' save it into the FourteenthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FourteenthItem.Text, AgreementTable.FourteenthItem)			

                      
        End Sub
                
        Public Overridable Sub GetFourteenthTypeID()
         
            ' Retrieve the value entered by the user on the FourteenthTypeID ASP:DropDownList, and
            ' save it into the FourteenthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FourteenthTypeID), AgreementTable.FourteenthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetFourthByCIX()
        
        
            ' Retrieve the value entered by the user on the FourthByCIX ASP:CheckBox, and
            ' save it into the FourthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FourthByCIX = Me.FourthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFourthByOIX()
        
        
            ' Retrieve the value entered by the user on the FourthByOIX ASP:CheckBox, and
            ' save it into the FourthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.FourthByOIX = Me.FourthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetFourthDefault()
            
            ' Retrieve the value entered by the user on the FourthDefault ASP:TextBox, and
            ' save it into the FourthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FourthDefault.Text, AgreementTable.FourthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetFourthItem()
            
            ' Retrieve the value entered by the user on the FourthItem ASP:TextBox, and
            ' save it into the FourthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.FourthItem.Text, AgreementTable.FourthItem)			

                      
        End Sub
                
        Public Overridable Sub GetFourthTypeID()
         
            ' Retrieve the value entered by the user on the FourthTypeID ASP:DropDownList, and
            ' save it into the FourthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.FourthTypeID), AgreementTable.FourthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetInitialsInDocument()
        
        
            ' Retrieve the value entered by the user on the InitialsInDocument ASP:CheckBox, and
            ' save it into the InitialsInDocument field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.InitialsInDocument = Me.InitialsInDocument.Checked
                    
        End Sub
                
        Public Overridable Sub GetNinthByCIX()
        
        
            ' Retrieve the value entered by the user on the NinthByCIX ASP:CheckBox, and
            ' save it into the NinthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.NinthByCIX = Me.NinthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetNinthByOIX()
        
        
            ' Retrieve the value entered by the user on the NinthByOIX ASP:CheckBox, and
            ' save it into the NinthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.NinthByOIX = Me.NinthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetNinthDefault()
            
            ' Retrieve the value entered by the user on the NinthDefault ASP:TextBox, and
            ' save it into the NinthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.NinthDefault.Text, AgreementTable.NinthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetNinthItem()
            
            ' Retrieve the value entered by the user on the NinthItem ASP:TextBox, and
            ' save it into the NinthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.NinthItem.Text, AgreementTable.NinthItem)			

                      
        End Sub
                
        Public Overridable Sub GetNinthTypeID()
         
            ' Retrieve the value entered by the user on the NinthTypeID ASP:DropDownList, and
            ' save it into the NinthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.NinthTypeID), AgreementTable.NinthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetOtherInstructions()
            
            ' Retrieve the value entered by the user on the OtherInstructions ASP:TextBox, and
            ' save it into the OtherInstructions field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.OtherInstructions.Content, AgreementTable.OtherInstructions)			

                      
        End Sub
                
        Public Overridable Sub GetRecipientInstructions()
            
            ' Retrieve the value entered by the user on the RecipientInstructions ASP:TextBox, and
            ' save it into the RecipientInstructions field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.RecipientInstructions.Content, AgreementTable.RecipientInstructions)			

                      
        End Sub
                
        Public Overridable Sub GetRequiredDoc()
        
        
            ' Retrieve the value entered by the user on the RequiredDoc ASP:CheckBox, and
            ' save it into the RequiredDoc field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.RequiredDoc = Me.RequiredDoc.Checked
                    
        End Sub
                
        Public Overridable Sub GetRoleID()
         
            ' Retrieve the value entered by the user on the RoleID ASP:DropDownList, and
            ' save it into the RoleID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.RoleID), AgreementTable.RoleID)				
            
        End Sub
                
        Public Overridable Sub GetSecondByCIX()
        
        
            ' Retrieve the value entered by the user on the SecondByCIX ASP:CheckBox, and
            ' save it into the SecondByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SecondByCIX = Me.SecondByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSecondByOIX()
        
        
            ' Retrieve the value entered by the user on the SecondByOIX ASP:CheckBox, and
            ' save it into the SecondByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SecondByOIX = Me.SecondByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSecondDefault()
            
            ' Retrieve the value entered by the user on the SecondDefault ASP:TextBox, and
            ' save it into the SecondDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SecondDefault.Text, AgreementTable.SecondDefault)			

                      
        End Sub
                
        Public Overridable Sub GetSecondItem()
            
            ' Retrieve the value entered by the user on the SecondItem ASP:TextBox, and
            ' save it into the SecondItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SecondItem.Text, AgreementTable.SecondItem)			

                      
        End Sub
                
        Public Overridable Sub GetSecondTypeID()
         
            ' Retrieve the value entered by the user on the SecondTypeID ASP:DropDownList, and
            ' save it into the SecondTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.SecondTypeID), AgreementTable.SecondTypeID)				
            
        End Sub
                
        Public Overridable Sub GetSenderInstructions()
            
            ' Retrieve the value entered by the user on the SenderInstructions ASP:TextBox, and
            ' save it into the SenderInstructions field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SenderInstructions.Content, AgreementTable.SenderInstructions)			

                      
        End Sub
                
        Public Overridable Sub GetSeventhByCIX()
        
        
            ' Retrieve the value entered by the user on the SeventhByCIX ASP:CheckBox, and
            ' save it into the SeventhByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SeventhByCIX = Me.SeventhByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSeventhByOIX()
        
        
            ' Retrieve the value entered by the user on the SeventhByOIX ASP:CheckBox, and
            ' save it into the SeventhByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SeventhByOIX = Me.SeventhByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSeventhDefault()
            
            ' Retrieve the value entered by the user on the SeventhDefault ASP:TextBox, and
            ' save it into the SeventhDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SeventhDefault.Text, AgreementTable.SeventhDefault)			

                      
        End Sub
                
        Public Overridable Sub GetSeventhItem()
            
            ' Retrieve the value entered by the user on the SeventhItem ASP:TextBox, and
            ' save it into the SeventhItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SeventhItem.Text, AgreementTable.SeventhItem)			

                      
        End Sub
                
        Public Overridable Sub GetSeventhTypeID()
         
            ' Retrieve the value entered by the user on the SeventhTypeID ASP:DropDownList, and
            ' save it into the SeventhTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.SeventhTypeID), AgreementTable.SeventhTypeID)				
            
        End Sub
                
        Public Overridable Sub GetShowExpirationDate()
        
        
            ' Retrieve the value entered by the user on the ShowExpirationDate ASP:CheckBox, and
            ' save it into the ShowExpirationDate field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ShowExpirationDate = Me.ShowExpirationDate.Checked
                    
        End Sub
                
        Public Overridable Sub GetShowSignatureDate()
        
        
            ' Retrieve the value entered by the user on the ShowSignatureDate ASP:CheckBox, and
            ' save it into the ShowSignatureDate field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ShowSignatureDate = Me.ShowSignatureDate.Checked
                    
        End Sub
                
        Public Overridable Sub GetSixthByCIX()
        
        
            ' Retrieve the value entered by the user on the SixthByCIX ASP:CheckBox, and
            ' save it into the SixthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SixthByCIX = Me.SixthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSixthByOIX()
        
        
            ' Retrieve the value entered by the user on the SixthByOIX ASP:CheckBox, and
            ' save it into the SixthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.SixthByOIX = Me.SixthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetSixthDefault()
            
            ' Retrieve the value entered by the user on the SixthDefault ASP:TextBox, and
            ' save it into the SixthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SixthDefault.Text, AgreementTable.SixthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetSixthItem()
            
            ' Retrieve the value entered by the user on the SixthItem ASP:TextBox, and
            ' save it into the SixthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.SixthItem.Text, AgreementTable.SixthItem)			

                      
        End Sub
                
        Public Overridable Sub GetSixthTypeID()
         
            ' Retrieve the value entered by the user on the SixthTypeID ASP:DropDownList, and
            ' save it into the SixthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.SixthTypeID), AgreementTable.SixthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetTenthByCIX()
        
        
            ' Retrieve the value entered by the user on the TenthByCIX ASP:CheckBox, and
            ' save it into the TenthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.TenthByCIX = Me.TenthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetTenthByOIX()
        
        
            ' Retrieve the value entered by the user on the TenthByOIX ASP:CheckBox, and
            ' save it into the TenthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.TenthByOIX = Me.TenthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetTenthDefault()
            
            ' Retrieve the value entered by the user on the TenthDefault ASP:TextBox, and
            ' save it into the TenthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.TenthDefault.Text, AgreementTable.TenthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetTenthItem()
            
            ' Retrieve the value entered by the user on the TenthItem ASP:TextBox, and
            ' save it into the TenthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.TenthItem.Text, AgreementTable.TenthItem)			

                      
        End Sub
                
        Public Overridable Sub GetTenthTypeID()
         
            ' Retrieve the value entered by the user on the TenthTypeID ASP:DropDownList, and
            ' save it into the TenthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.TenthTypeID), AgreementTable.TenthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetThirdByCIX()
        
        
            ' Retrieve the value entered by the user on the ThirdByCIX ASP:CheckBox, and
            ' save it into the ThirdByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ThirdByCIX = Me.ThirdByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetThirdByOIX()
        
        
            ' Retrieve the value entered by the user on the ThirdByOIX ASP:CheckBox, and
            ' save it into the ThirdByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ThirdByOIX = Me.ThirdByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetThirdDefault()
            
            ' Retrieve the value entered by the user on the ThirdDefault ASP:TextBox, and
            ' save it into the ThirdDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ThirdDefault.Text, AgreementTable.ThirdDefault)			

                      
        End Sub
                
        Public Overridable Sub GetThirdItem()
            
            ' Retrieve the value entered by the user on the ThirdItem ASP:TextBox, and
            ' save it into the ThirdItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ThirdItem.Text, AgreementTable.ThirdItem)			

                      
        End Sub
                
        Public Overridable Sub GetThirdTypeID()
         
            ' Retrieve the value entered by the user on the ThirdTypeID ASP:DropDownList, and
            ' save it into the ThirdTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.ThirdTypeID), AgreementTable.ThirdTypeID)				
            
        End Sub
                
        Public Overridable Sub GetThirteenthByCIX()
        
        
            ' Retrieve the value entered by the user on the ThirteenthByCIX ASP:CheckBox, and
            ' save it into the ThirteenthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ThirteenthByCIX = Me.ThirteenthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetThirteenthByOIX()
        
        
            ' Retrieve the value entered by the user on the ThirteenthByOIX ASP:CheckBox, and
            ' save it into the ThirteenthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.ThirteenthByOIX = Me.ThirteenthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetThirteenthDefault()
            
            ' Retrieve the value entered by the user on the ThirteenthDefault ASP:TextBox, and
            ' save it into the ThirteenthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ThirteenthDefault.Text, AgreementTable.ThirteenthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetThirteenthItem()
            
            ' Retrieve the value entered by the user on the ThirteenthItem ASP:TextBox, and
            ' save it into the ThirteenthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ThirteenthItem.Text, AgreementTable.ThirteenthItem)			

                      
        End Sub
                
        Public Overridable Sub GetThirteenthTypeID()
         
            ' Retrieve the value entered by the user on the ThirteenthTypeID ASP:DropDownList, and
            ' save it into the ThirteenthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.ThirteenthTypeID), AgreementTable.ThirteenthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetTwelfthByCIX()
        
        
            ' Retrieve the value entered by the user on the TwelfthByCIX ASP:CheckBox, and
            ' save it into the TwelfthByCIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.TwelfthByCIX = Me.TwelfthByCIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetTwelfthByOIX()
        
        
            ' Retrieve the value entered by the user on the TwelfthByOIX ASP:CheckBox, and
            ' save it into the TwelfthByOIX field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.TwelfthByOIX = Me.TwelfthByOIX.Checked
                    
        End Sub
                
        Public Overridable Sub GetTwelfthDefault()
            
            ' Retrieve the value entered by the user on the TwelfthDefault ASP:TextBox, and
            ' save it into the TwelfthDefault field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.TwelfthDefault.Text, AgreementTable.TwelfthDefault)			

                      
        End Sub
                
        Public Overridable Sub GetTwelfthItem()
            
            ' Retrieve the value entered by the user on the TwelfthItem ASP:TextBox, and
            ' save it into the TwelfthItem field in DataSource Agreement record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.TwelfthItem.Text, AgreementTable.TwelfthItem)			

                      
        End Sub
                
        Public Overridable Sub GetTwelfthTypeID()
         
            ' Retrieve the value entered by the user on the TwelfthTypeID ASP:DropDownList, and
            ' save it into the TwelfthTypeID field in DataSource Agreement record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.TwelfthTypeID), AgreementTable.TwelfthTypeID)				
            
        End Sub
                
        Public Overridable Sub GetUseStoredSignature()
        
        
            ' Retrieve the value entered by the user on the UseStoredSignature ASP:CheckBox, and
            ' save it into the UseStoredSignature field in DataSource Agreement record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.UseStoredSignature = Me.UseStoredSignature.Checked
                    
        End Sub
                
      
        ' To customize, override this method in AgreementRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementRecordControl As Boolean = False
      
            Dim wc As WhereClause
            AgreementTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("Agreement"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "FASTPORT").Replace("{URL}", "Agreement"))
            End If
            HttpContext.Current.Session("QueryString in EditAgreement") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(AgreementTable.AgreementID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(AgreementTable.AgreementID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(AgreementTable.AgreementID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            AgreementTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersAgreementRecordControl As Boolean = False
              
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
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") and not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
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
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
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
                    If  index <= columnLength Then
                        if index = Len(resultItem) then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
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

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    resultList.Add(itemToAdd)
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        
    

        ' To customize, override this method in AgreementRecordControl.
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
          AgreementTable.DeleteRecord(pkValue)
          
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
                                
                
			Me.Page.Authorize(Ctype(ExecuteFromBoard, Control), "20")
					
			Me.Page.Authorize(Ctype(ExecuteFromBoardLabel, Control), "20")
					
			Me.Page.Authorize(Ctype(RoleID, Control), "20")
					
			Me.Page.Authorize(Ctype(RoleIDLabel, Control), "20")
											
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
            

        Public Overridable Function CreateWhereClause_EighthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_EleventhTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FifteenthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FifthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FirstTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FlowCollectionIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the FlowCollection table.
            ' Examples:
            ' wc.iAND(FlowCollectionTable.CollectionName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(FlowCollectionTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("1", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.FlowCollectionTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("FlowCollection_.FlowID"), EvaluateFormula("1", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("1", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("1", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FourteenthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_FourthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_NinthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_RoleIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the Role table.
            ' Examples:
            ' wc.iAND(RoleTable.Role, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(RoleTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("URL(""GeneralRole"")", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.RoleTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("Role_.GeneralRoleID"), EvaluateFormula("URL(""GeneralRole"")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("URL(""GeneralRole"")", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("URL(""GeneralRole"")", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_SecondTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_SeventhTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_SixthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_TenthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_ThirdTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("""Field Type""", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.ListTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("List_.ListType"), EvaluateFormula("""Field Type""", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("""Field Type""", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("""Field Type""", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause
				
        End Function
        
                

        Public Overridable Function CreateWhereClause_ThirteenthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_TwelfthTypeIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the List table.
            ' Examples:
            ' wc.iAND(ListTable.ListName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(ListTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the EighthTypeID list.
        Protected Overridable Sub PopulateEighthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.EighthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.EighthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_EighthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_EighthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.EighthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.EighthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.EighthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.EighthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.EighthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.EighthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.EighthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the EleventhTypeID list.
        Protected Overridable Sub PopulateEleventhTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.EleventhTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.EleventhTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_EleventhTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_EleventhTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.EleventhTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.EleventhTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.EleventhTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.EleventhTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.EleventhTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.EleventhTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.EleventhTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.EleventhTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.EleventhTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.EleventhTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.EleventhTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.EleventhTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.EleventhTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FifteenthTypeID list.
        Protected Overridable Sub PopulateFifteenthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FifteenthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FifteenthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FifteenthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FifteenthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FifteenthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FifteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FifteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.FifteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FifteenthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FifteenthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FifteenthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FifteenthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FifteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FifteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.FifteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FifteenthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.FifteenthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FifthTypeID list.
        Protected Overridable Sub PopulateFifthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FifthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FifthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FifthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FifthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FifthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FifthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FifthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FifthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FifthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FifthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.FifthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FirstTypeID list.
        Protected Overridable Sub PopulateFirstTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FirstTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FirstTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FirstTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FirstTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FirstTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FirstTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FirstTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FirstTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FirstTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FirstTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.FirstTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FlowCollectionID list.
        Protected Overridable Sub PopulateFlowCollectionIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FlowCollectionID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FlowCollectionID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FlowCollectionIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FlowCollectionIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(FlowCollectionTable.CollectionName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As FlowCollectionRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = FlowCollectionTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As FlowCollectionRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.FlowCollectionIDSpecified Then
                            cvalue = itemValue.FlowCollectionID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FlowCollectionID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= FlowCollection.CollectionName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FlowCollectionID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FlowCollectionID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FlowCollectionID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FlowCollectionID, selectedValue)Then

                ' construct a whereclause to query a record with FlowCollection.FlowCollectionID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(FlowCollectionTable.FlowCollectionID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As FlowCollectionRecord = FlowCollectionTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As FlowCollectionRecord = DirectCast(rc(0), FlowCollectionRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.FlowCollectionIDSpecified Then
                            cvalue = itemValue.FlowCollectionID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= FlowCollection.CollectionName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FlowCollectionID.Items.Add(newItem)
                      SetSelectedValue(Me.FlowCollectionID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FourteenthTypeID list.
        Protected Overridable Sub PopulateFourteenthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FourteenthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FourteenthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FourteenthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FourteenthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FourteenthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FourteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FourteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.FourteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FourteenthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FourteenthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FourteenthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FourteenthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FourteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FourteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.FourteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FourteenthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.FourteenthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the FourthTypeID list.
        Protected Overridable Sub PopulateFourthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.FourthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.FourthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FourthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_FourthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.FourthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.FourthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.FourthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.FourthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.FourthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.FourthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.FourthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the NinthTypeID list.
        Protected Overridable Sub PopulateNinthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.NinthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.NinthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_NinthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_NinthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.NinthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.NinthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.NinthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.NinthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.NinthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.NinthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.NinthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the RoleID list.
        Protected Overridable Sub PopulateRoleIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.RoleID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            							
            Me.RoleID.Items.Add(New ListItem(Me.Page.ExpandResourceValue("For Everyone"), ""))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RoleIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_RoleIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(RoleTable.RoleTypeID, OrderByItem.OrderDir.Asc)
              orderBy.Add(RoleTable.RoleRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As RoleRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = RoleTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As RoleRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.RoleIDSpecified Then
                            cvalue = itemValue.RoleID.ToString() 
                            
                        If counter < maxItems AndAlso Me.RoleID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= Role.Role", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.RoleID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.RoleID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.RoleID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.RoleID, selectedValue)Then

                ' construct a whereclause to query a record with Role.RoleID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(RoleTable.RoleID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As RoleRecord = RoleTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As RoleRecord = DirectCast(rc(0), RoleRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.RoleIDSpecified Then
                            cvalue = itemValue.RoleID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= Role.Role", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.RoleID.Items.Add(newItem)
                      SetSelectedValue(Me.RoleID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the SecondTypeID list.
        Protected Overridable Sub PopulateSecondTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.SecondTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.SecondTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SecondTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_SecondTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.SecondTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.SecondTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.SecondTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.SecondTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.SecondTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.SecondTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.SecondTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the SeventhTypeID list.
        Protected Overridable Sub PopulateSeventhTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.SeventhTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.SeventhTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SeventhTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_SeventhTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.SeventhTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.SeventhTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.SeventhTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.SeventhTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.SeventhTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.SeventhTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.SeventhTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the SixthTypeID list.
        Protected Overridable Sub PopulateSixthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.SixthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.SixthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_SixthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_SixthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.SixthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.SixthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.SixthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.SixthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.SixthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.SixthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.SixthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the TenthTypeID list.
        Protected Overridable Sub PopulateTenthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.TenthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.TenthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_TenthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_TenthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.TenthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.TenthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.TenthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.TenthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.TenthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.TenthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.TenthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the ThirdTypeID list.
        Protected Overridable Sub PopulateThirdTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.ThirdTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.ThirdTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ThirdTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_ThirdTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListRank, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.ThirdTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.ThirdTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.ThirdTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.ThirdTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.ThirdTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          variables.Clear()
                          


                          variables.Add(itemValue.TableAccess.TableDefinition.TableCodeName, itemValue)
                          
                          fvalue = EvaluateFormula("= List.ListName", itemValue, variables, evaluator)
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.ThirdTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.ThirdTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the ThirteenthTypeID list.
        Protected Overridable Sub PopulateThirteenthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.ThirteenthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.ThirteenthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ThirteenthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_ThirteenthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.ThirteenthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.ThirteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.ThirteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.ThirteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.ThirteenthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.ThirteenthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.ThirteenthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.ThirteenthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.ThirteenthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.ThirteenthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.ThirteenthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.ThirteenthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.ThirteenthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the TwelfthTypeID list.
        Protected Overridable Sub PopulateTwelfthTypeIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.TwelfthTypeID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.TwelfthTypeID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "FASTPORT"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_TwelfthTypeIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_TwelfthTypeIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(ListTable.ListName, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As ListRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = ListTable.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As ListRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                            
                        If counter < maxItems AndAlso Me.TwelfthTypeID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.TwelfthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.TwelfthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.TwelfthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.TwelfthTypeID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.TwelfthTypeID.Items.Add(newItem)

                      If listDuplicates.Contains(fvalue) Then
                          newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                      End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.TwelfthTypeID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.TwelfthTypeID, selectedValue)Then

                ' construct a whereclause to query a record with List.ListID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(ListTable.ListID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As ListRecord = ListTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As ListRecord = DirectCast(rc(0), ListRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.ListIDSpecified Then
                            cvalue = itemValue.ListID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.TwelfthTypeID)
                          If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.TwelfthTypeID.IsApplyDisplayAs Then
                          fvalue = AgreementTable.GetDFKA(itemValue, AgreementTable.TwelfthTypeID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(ListTable.ListName)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.TwelfthTypeID.Items.Add(newItem)
                      SetSelectedValue(Me.TwelfthTypeID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        Protected Overridable Sub EighthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(EighthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(EighthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.EighthTypeID.Items.Add(New ListItem(displayText, val))
                Me.EighthTypeID.SelectedIndex = Me.EighthTypeID.Items.Count - 1
                Me.Page.Session.Remove(EighthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(EighthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub EleventhTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(EleventhTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(EleventhTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.EleventhTypeID.Items.Add(New ListItem(displayText, val))
                Me.EleventhTypeID.SelectedIndex = Me.EleventhTypeID.Items.Count - 1
                Me.Page.Session.Remove(EleventhTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(EleventhTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FifteenthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FifteenthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FifteenthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FifteenthTypeID.Items.Add(New ListItem(displayText, val))
                Me.FifteenthTypeID.SelectedIndex = Me.FifteenthTypeID.Items.Count - 1
                Me.Page.Session.Remove(FifteenthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FifteenthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FifthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FifthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FifthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FifthTypeID.Items.Add(New ListItem(displayText, val))
                Me.FifthTypeID.SelectedIndex = Me.FifthTypeID.Items.Count - 1
                Me.Page.Session.Remove(FifthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FifthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FirstTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FirstTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FirstTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FirstTypeID.Items.Add(New ListItem(displayText, val))
                Me.FirstTypeID.SelectedIndex = Me.FirstTypeID.Items.Count - 1
                Me.Page.Session.Remove(FirstTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FirstTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FlowCollectionID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FlowCollectionID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FlowCollectionID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FlowCollectionID.Items.Add(New ListItem(displayText, val))
                Me.FlowCollectionID.SelectedIndex = Me.FlowCollectionID.Items.Count - 1
                Me.Page.Session.Remove(FlowCollectionID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FlowCollectionID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FourteenthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FourteenthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FourteenthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FourteenthTypeID.Items.Add(New ListItem(displayText, val))
                Me.FourteenthTypeID.SelectedIndex = Me.FourteenthTypeID.Items.Count - 1
                Me.Page.Session.Remove(FourteenthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FourteenthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub FourthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(FourthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(FourthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.FourthTypeID.Items.Add(New ListItem(displayText, val))
                Me.FourthTypeID.SelectedIndex = Me.FourthTypeID.Items.Count - 1
                Me.Page.Session.Remove(FourthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(FourthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub NinthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(NinthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(NinthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.NinthTypeID.Items.Add(New ListItem(displayText, val))
                Me.NinthTypeID.SelectedIndex = Me.NinthTypeID.Items.Count - 1
                Me.Page.Session.Remove(NinthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(NinthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub RoleID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(RoleID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(RoleID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.RoleID.Items.Add(New ListItem(displayText, val))
                Me.RoleID.SelectedIndex = Me.RoleID.Items.Count - 1
                Me.Page.Session.Remove(RoleID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(RoleID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub SecondTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(SecondTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(SecondTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.SecondTypeID.Items.Add(New ListItem(displayText, val))
                Me.SecondTypeID.SelectedIndex = Me.SecondTypeID.Items.Count - 1
                Me.Page.Session.Remove(SecondTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(SecondTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub SeventhTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(SeventhTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(SeventhTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.SeventhTypeID.Items.Add(New ListItem(displayText, val))
                Me.SeventhTypeID.SelectedIndex = Me.SeventhTypeID.Items.Count - 1
                Me.Page.Session.Remove(SeventhTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(SeventhTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub SixthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(SixthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(SixthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.SixthTypeID.Items.Add(New ListItem(displayText, val))
                Me.SixthTypeID.SelectedIndex = Me.SixthTypeID.Items.Count - 1
                Me.Page.Session.Remove(SixthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(SixthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub TenthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(TenthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(TenthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.TenthTypeID.Items.Add(New ListItem(displayText, val))
                Me.TenthTypeID.SelectedIndex = Me.TenthTypeID.Items.Count - 1
                Me.Page.Session.Remove(TenthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(TenthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub ThirdTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(ThirdTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(ThirdTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.ThirdTypeID.Items.Add(New ListItem(displayText, val))
                Me.ThirdTypeID.SelectedIndex = Me.ThirdTypeID.Items.Count - 1
                Me.Page.Session.Remove(ThirdTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(ThirdTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub ThirteenthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(ThirteenthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(ThirteenthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.ThirteenthTypeID.Items.Add(New ListItem(displayText, val))
                Me.ThirteenthTypeID.SelectedIndex = Me.ThirteenthTypeID.Items.Count - 1
                Me.Page.Session.Remove(ThirteenthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(ThirteenthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub TwelfthTypeID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(TwelfthTypeID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(TwelfthTypeID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.TwelfthTypeID.Items.Add(New ListItem(displayText, val))
                Me.TwelfthTypeID.SelectedIndex = Me.TwelfthTypeID.Items.Count - 1
                Me.Page.Session.Remove(TwelfthTypeID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(TwelfthTypeID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub DocHasCustomFields_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub EighthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub EighthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub EleventhByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub EleventhByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ExecuteFromBoard_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FifteenthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FifteenthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FifthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FifthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FirstByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FirstByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FourteenthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FourteenthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FourthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub FourthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub InitialsInDocument_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub NinthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub NinthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub RequiredDoc_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SecondByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SecondByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SeventhByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SeventhByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ShowExpirationDate_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ShowSignatureDate_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SixthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub SixthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub TenthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub TenthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ThirdByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ThirdByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ThirteenthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ThirteenthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub TwelfthByCIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub TwelfthByOIX_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub UseStoredSignature_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub Agreement_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Description_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub EighthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub EighthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub EleventhDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub EleventhItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FifteenthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FifteenthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FifthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FifthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FirstDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FirstItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FourteenthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FourteenthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FourthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub FourthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub NinthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub NinthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub OtherInstructions_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
                ' this event handler is not supported since OtherInstructions is an Ajax HTML Editor.
              
              End Sub
            
        Protected Overridable Sub RecipientInstructions_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
                ' this event handler is not supported since RecipientInstructions is an Ajax HTML Editor.
              
              End Sub
            
        Protected Overridable Sub SecondDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub SecondItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub SenderInstructions_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
                ' this event handler is not supported since SenderInstructions is an Ajax HTML Editor.
              
              End Sub
            
        Protected Overridable Sub SeventhDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub SeventhItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub SixthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub SixthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub TenthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub TenthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ThirdDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ThirdItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ThirteenthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ThirteenthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub TwelfthDefault_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub TwelfthItem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseAgreementRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseAgreementRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As AgreementRecord
        Public Property DataSource() As AgreementRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As AgreementRecord)
            
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
        
        Public ReadOnly Property Agreement() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Agreement"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property AgreementDownload() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementDownload"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property AgreementFile() As System.Web.UI.WebControls.FileUpload
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementFile"), System.Web.UI.WebControls.FileUpload)
            End Get
        End Property
            
        Public ReadOnly Property AgreementFileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementFileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AgreementLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CustomFieldsSrollPanel() As System.Web.UI.WebControls.Panel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CustomFieldsSrollPanel"), System.Web.UI.WebControls.Panel)
            End Get
        End Property
        
        Public ReadOnly Property CustomInstructionsSrollPanel() As System.Web.UI.WebControls.Panel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CustomInstructionsSrollPanel"), System.Web.UI.WebControls.Panel)
            End Get
        End Property
        
        Public ReadOnly Property DefaultLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DefaultLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property Description() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Description"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocHasCustomFields() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocHasCustomFields"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property DocHasCustomFieldsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocHasCustomFieldsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property EighthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property EighthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property EighthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property EighthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property EighthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property EleventhByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property EleventhDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property EleventhItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property EleventhTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property EleventhTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ExecuteFromBoard() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExecuteFromBoard"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ExecuteFromBoardLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExecuteFromBoardLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FieldLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FieldLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property FieldTypeLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FieldTypeLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FifthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FifthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FifthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FifthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FifthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FirstByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FirstDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FirstItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FirstTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FirstTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FlowCollectionID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FlowCollectionID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FlowCollectionIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FlowCollectionIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ForLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ForLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FourthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property FourthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FourthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FourthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property FourthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property InitialsInDocument() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "InitialsInDocument"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property InitialsInDocumentLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "InitialsInDocumentLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ItemLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property NinthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property NinthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property NinthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property NinthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property NinthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property NinthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property OnlyCIXLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OnlyCIXLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property OnlyOIXLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OnlyOIXLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
              Public ReadOnly Property OtherInstructions() As AjaxControlToolkit.HTMLEditor.Editor
              Get
              Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OtherInstructions"), AjaxControlToolkit.HTMLEditor.Editor)
              End Get
              End Property
            
        Public ReadOnly Property OtherInstructionsLbl() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OtherInstructionsLbl"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RecipientInstrucitonsLbl() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecipientInstrucitonsLbl"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property RecipientInstructions() As AjaxControlToolkit.HTMLEditor.Editor
              Get
              Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecipientInstructions"), AjaxControlToolkit.HTMLEditor.Editor)
              End Get
              End Property
            
        Public ReadOnly Property RequiredDoc() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RequiredDoc"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property RequiredDocLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RequiredDocLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property RoleIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SecondByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SecondDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SecondItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SecondTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property SecondTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SenderInstrucitonsLbl() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstrucitonsLbl"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property SenderInstructions() As AjaxControlToolkit.HTMLEditor.Editor
              Get
              Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstructions"), AjaxControlToolkit.HTMLEditor.Editor)
              End Get
              End Property
            
        Public ReadOnly Property SeventhByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SeventhByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SeventhDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SeventhItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SeventhTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property SeventhTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ShowExpirationDate() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowExpirationDate"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ShowExpirationDateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowExpirationDateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ShowSignatureDate() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowSignatureDate"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ShowSignatureDateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowSignatureDateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SixthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SixthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SixthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SixthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property SixthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property TenthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property TenthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property TenthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property TenthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property TenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirdByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirdDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirdItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirdTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property ThirdTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthByCIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByCIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthByOIX() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByOIX"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthDefault() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthDefault"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthItem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthItem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthTypeID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthTypeID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UseStoredSignature() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UseStoredSignature"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property UseStoredSignatureLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UseStoredSignatureLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As AgreementRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As AgreementRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return AgreementTable.GetRecord(Me.RecordUniqueId, True)
                
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


End Namespace

  