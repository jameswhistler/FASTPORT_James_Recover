
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowAgreement.aspx page.  The Row or RecordControl classes are the 
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
        

#End Region

  
Namespace FASTPORT.UI.Controls.ShowAgreement

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

                s_Vis()

            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub

        Public Sub s_Vis()

            If Me.FirstTypeID.Text = "&nbsp;" Then
                Me.FirstByCIX.Visible = False
                Me.FirstByOIX.Visible = False
            Else
                Me.FirstByCIX.Visible = True
                Me.FirstByOIX.Visible = True
            End If

            If Me.SecondTypeID.Text = "&nbsp;" Then
                Me.SecondByCIX.Visible = False
                Me.SecondByOIX.Visible = False
            Else
                Me.SecondByCIX.Visible = True
                Me.SecondByOIX.Visible = True
            End If

            If Me.ThirdTypeID.Text = "&nbsp;" Then
                Me.ThirdByCIX.Visible = False
                Me.ThirdByOIX.Visible = False
            Else
                Me.ThirdByCIX.Visible = True
                Me.ThirdByOIX.Visible = True
            End If

            If Me.FourthTypeID.Text = "&nbsp;" Then
                Me.FourthByCIX.Visible = False
                Me.FourthByOIX.Visible = False
            Else
                Me.FourthByCIX.Visible = True
                Me.FourthByOIX.Visible = True
            End If

            If Me.FifthTypeID.Text = "&nbsp;" Then
                Me.FifthByCIX.Visible = False
                Me.FifthByOIX.Visible = False
            Else
                Me.FifthByCIX.Visible = True
                Me.FifthByOIX.Visible = True
            End If

            If Me.SixthTypeID.Text = "&nbsp;" Then
                Me.SixthByCIX.Visible = False
                Me.SixthByOIX.Visible = False
            Else
                Me.SixthByCIX.Visible = True
                Me.SixthByOIX.Visible = True
            End If

            If Me.SeventhTypeID.Text = "&nbsp;" Then
                Me.SeventhByCIX.Visible = False
                Me.SeventhByOIX.Visible = False
            Else
                Me.SeventhByCIX.Visible = True
                Me.SeventhByOIX.Visible = True
            End If

            If Me.EighthTypeID.Text = "&nbsp;" Then
                Me.EighthByCIX.Visible = False
                Me.EighthByOIX.Visible = False
            Else
                Me.EighthByCIX.Visible = True
                Me.EighthByOIX.Visible = True
            End If

            If Me.NinthTypeID.Text = "&nbsp;" Then
                Me.NinthByCIX.Visible = False
                Me.NinthByOIX.Visible = False
            Else
                Me.NinthByCIX.Visible = True
                Me.NinthByOIX.Visible = True
            End If

            If Me.TenthTypeID.Text = "&nbsp;" Then
                Me.TenthByCIX.Visible = False
                Me.TenthByOIX.Visible = False
            Else
                Me.TenthByCIX.Visible = True
                Me.TenthByOIX.Visible = True
            End If

            If Me.EleventhTypeID.Text = "&nbsp;" Then
                Me.EleventhByCIX.Visible = False
                Me.EleventhByOIX.Visible = False
            Else
                Me.EleventhByCIX.Visible = True
                Me.EleventhByOIX.Visible = True
            End If

            If Me.TwelfthTypeID.Text = "&nbsp;" Then
                Me.TwelfthByCIX.Visible = False
                Me.TwelfthByOIX.Visible = False
            Else
                Me.TwelfthByCIX.Visible = True
                Me.TwelfthByOIX.Visible = True
            End If

            If Me.ThirteenthTypeID.Text = "&nbsp;" Then
                Me.ThirteenthByCIX.Visible = False
                Me.ThirteenthByOIX.Visible = False
            Else
                Me.ThirteenthByCIX.Visible = True
                Me.ThirteenthByOIX.Visible = True
            End If

            If Me.FourteenthTypeID.Text = "&nbsp;" Then
                Me.FourteenthByCIX.Visible = False
                Me.FourteenthByOIX.Visible = False
            Else
                Me.FourteenthByCIX.Visible = True
                Me.FourteenthByOIX.Visible = True
            End If

            If Me.FifteenthTypeID.Text = "&nbsp;" Then
                Me.FifteenthByCIX.Visible = False
                Me.FifteenthByOIX.Visible = False
            Else
                Me.FifteenthByCIX.Visible = True
                Me.FifteenthByOIX.Visible = True
            End If

            Dim myAll As Boolean
            Dim myByCIX As Boolean
            Dim myByOIX As Boolean

            If (Me.FirstTypeID.Text <> "&nbsp;" And FirstByCIX.Text = "No" And FirstByOIX.Text = "No") _
                Or (Me.SecondTypeID.Text <> "&nbsp;" And SecondByCIX.Text = "No" And SecondByOIX.Text = "No") _
                Or (Me.ThirdTypeID.Text <> "&nbsp;" And ThirdByCIX.Text = "No" And ThirdByOIX.Text = "No") _
                Or (Me.FourthTypeID.Text <> "&nbsp;" And FourthByCIX.Text = "No" And FourthByOIX.Text = "No") _
                Or (Me.FifthTypeID.Text <> "&nbsp;" And FifthByCIX.Text = "No" And FifthByOIX.Text = "No") _
                Or (Me.SixthTypeID.Text <> "&nbsp;" And SixthByCIX.Text = "No" And SixthByOIX.Text = "No") _
                Or (Me.SeventhTypeID.Text <> "&nbsp;" And SeventhByCIX.Text = "No" And SeventhByOIX.Text = "No") _
                Or (Me.EighthTypeID.Text <> "&nbsp;" And EighthByCIX.Text = "No" And EighthByOIX.Text = "No") _
                Or (Me.NinthTypeID.Text <> "&nbsp;" And NinthByCIX.Text = "No" And NinthByOIX.Text = "No") _
                Or (Me.TenthTypeID.Text <> "&nbsp;" And TenthByCIX.Text = "No" And TenthByOIX.Text = "No") _
                Or (Me.EleventhTypeID.Text <> "&nbsp;" And EleventhByCIX.Text = "No" And EleventhByOIX.Text = "No") _
                Or (Me.TwelfthTypeID.Text <> "&nbsp;" And TwelfthByCIX.Text = "No" And TwelfthByOIX.Text = "No") _
                Or (Me.ThirteenthTypeID.Text <> "&nbsp;" And ThirteenthByCIX.Text = "No" And ThirteenthByOIX.Text = "No") _
                Or (Me.FourteenthTypeID.Text <> "&nbsp;" And FourteenthByCIX.Text = "No" And FourteenthByOIX.Text = "No") _
                Or (Me.FifteenthTypeID.Text <> "&nbsp;" And FifteenthByCIX.Text = "No" And FifteenthByOIX.Text = "No") Then

                myAll = True

            End If

            If (Me.FirstTypeID.Text <> "&nbsp;" And FirstByCIX.Text = "Yes") _
                Or (Me.SecondTypeID.Text <> "&nbsp;" And SecondByCIX.Text = "Yes") _
                Or (Me.ThirdTypeID.Text <> "&nbsp;" And ThirdByCIX.Text = "Yes") _
                Or (Me.FourthTypeID.Text <> "&nbsp;" And FourthByCIX.Text = "Yes") _
                Or (Me.FifthTypeID.Text <> "&nbsp;" And FifthByCIX.Text = "Yes") _
                Or (Me.SixthTypeID.Text <> "&nbsp;" And SixthByCIX.Text = "Yes") _
                Or (Me.SeventhTypeID.Text <> "&nbsp;" And SeventhByCIX.Text = "Yes") _
                Or (Me.EighthTypeID.Text <> "&nbsp;" And EighthByCIX.Text = "Yes") _
                Or (Me.NinthTypeID.Text <> "&nbsp;" And NinthByCIX.Text = "Yes") _
                Or (Me.TenthTypeID.Text <> "&nbsp;" And TenthByCIX.Text = "Yes") _
                Or (Me.EleventhTypeID.Text <> "&nbsp;" And EleventhByCIX.Text = "Yes") _
                Or (Me.TwelfthTypeID.Text <> "&nbsp;" And TwelfthByCIX.Text = "Yes") _
                Or (Me.ThirteenthTypeID.Text <> "&nbsp;" And ThirteenthByCIX.Text = "Yes") _
                Or (Me.FourteenthTypeID.Text <> "&nbsp;" And FourteenthByCIX.Text = "Yes") _
                Or (Me.FifteenthTypeID.Text <> "&nbsp;" And FifteenthByCIX.Text = "Yes") _
                    Then

                myByCIX = True

            End If

            If (Me.FirstTypeID.Text <> "&nbsp;" And FirstByOIX.Text = "Yes") _
                Or (Me.SecondTypeID.Text <> "&nbsp;" And SecondByOIX.Text = "Yes") _
                Or (Me.ThirdTypeID.Text <> "&nbsp;" And ThirdByOIX.Text = "Yes") _
                Or (Me.FourthTypeID.Text <> "&nbsp;" And FourthByOIX.Text = "Yes") _
                Or (Me.FifthTypeID.Text <> "&nbsp;" And FifthByOIX.Text = "Yes") _
                Or (Me.SixthTypeID.Text <> "&nbsp;" And SixthByOIX.Text = "Yes") _
                Or (Me.SeventhTypeID.Text <> "&nbsp;" And SeventhByOIX.Text = "Yes") _
                Or (Me.EighthTypeID.Text <> "&nbsp;" And EighthByOIX.Text = "Yes") _
                Or (Me.NinthTypeID.Text <> "&nbsp;" And NinthByOIX.Text = "Yes") _
                Or (Me.TenthTypeID.Text <> "&nbsp;" And TenthByOIX.Text = "Yes") _
                Or (Me.EleventhTypeID.Text <> "&nbsp;" And EleventhByOIX.Text = "Yes") _
                Or (Me.TwelfthTypeID.Text <> "&nbsp;" And TwelfthByOIX.Text = "Yes") _
                Or (Me.ThirteenthTypeID.Text <> "&nbsp;" And ThirteenthByOIX.Text = "Yes") _
                Or (Me.FourteenthTypeID.Text <> "&nbsp;" And FourteenthByOIX.Text = "Yes") _
                Or (Me.FifteenthTypeID.Text <> "&nbsp;" And FifteenthByOIX.Text = "Yes") _
                    Then

                myByOIX = True

            End If


            If myAll = True Then
                MiscUtils.FindControlRecursively(Me, "OtherInstructionsRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "OtherInstructionsRow").Visible = False
            End If

            If myByCIX = True Then
                MiscUtils.FindControlRecursively(Me, "SenderInstructionsRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "SenderInstructionsRow").Visible = False
            End If


            If myByOIX = True Then
                MiscUtils.FindControlRecursively(Me, "RecipientInstructionsRow").Visible = True
            Else
                MiscUtils.FindControlRecursively(Me, "RecipientInstructionsRow").Visible = False
            End If

        End Sub

    End Class

  

Public Class FlowCollectionRecordControl
        Inherits BaseFlowCollectionRecordControl
        ' The BaseFlowCollectionRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the AgreementRecordControl control on the ShowAgreement page.
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
                SetAgreementFile()
                SetAgreementFileLabel()
                SetAgreementLabel()
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
                SetEleventhByCIX()
                SetEleventhByOIX()
                SetEleventhDefault()
                SetEleventhItem()
                SetEleventhTypeID()
                SetExecuteFromBoard()
                SetExecuteFromBoardLabel()
                SetFieldTypeLbl()
                SetFifteenthByCIX()
                SetFifteenthByOIX()
                SetFifteenthDefault()
                SetFifteenthItem()
                SetFifteenthTypeID()
                SetFifthByCIX()
                SetFifthByOIX()
                SetFifthDefault()
                SetFifthItem()
                SetFifthTypeID()
                SetFirstByCIX()
                SetFirstByOIX()
                SetFirstDefault()
                SetFirstItem()
                SetFirstTypeID()
                
                SetForLbl()
                SetForLbl1()
                SetFourteenthByCIX()
                SetFourteenthByOIX()
                SetFourteenthDefault()
                SetFourteenthItem()
                SetFourteenthTypeID()
                SetFourthByCIX()
                SetFourthByOIX()
                SetFourthDefault()
                SetFourthItem()
                SetFourthTypeID()
                SetInitialsInDocument()
                SetInitialsInDocumentLabel()
                SetItemLabel()
                SetNinthByCIX()
                SetNinthByOIX()
                SetNinthDefault()
                SetNinthItem()
                SetNinthTypeID()
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
                SetSenderInstrucitonsLbl()
                SetSenderInstructions()
                SetSeventhByCIX()
                SetSeventhByOIX()
                SetSeventhDefault()
                SetSeventhItem()
                SetSeventhTypeID()
                SetShowExpirationDate()
                SetShowExpirationDateLabel()
                SetShowSignatureDate()
                SetShowSignatureDateLabel()
                SetSixthByCIX()
                SetSixthByOIX()
                SetSixthDefault()
                SetSixthItem()
                SetSixthTypeID()
                SetTenthByCIX()
                SetTenthByOIX()
                SetTenthDefault()
                SetTenthItem()
                SetTenthTypeID()
                SetThirdByCIX()
                SetThirdByOIX()
                SetThirdDefault()
                SetThirdItem()
                SetThirdTypeID()
                SetThirteenthByCIX()
                SetThirteenthByOIX()
                SetThirteenthDefault()
                SetThirteenthItem()
                SetThirteenthTypeID()
                SetTwelfthByCIX()
                SetTwelfthByOIX()
                SetTwelfthDefault()
                SetTwelfthItem()
                SetTwelfthTypeID()
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
            
        Dim recFlowCollectionRecordControl as FlowCollectionRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "FlowCollectionRecordControl"), FlowCollectionRecordControl)
          
        recFlowCollectionRecordControl.LoadData()
        recFlowCollectionRecordControl.DataBind()
              
        End Sub
        
        
        Public Overridable Sub SetAgreement()
            
        
            ' Set the Agreement Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.Agreement is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAgreement()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AgreementSpecified Then
                				
                ' If the Agreement is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.Agreement)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Agreement.Text = formattedValue
                
            Else 
            
                ' Agreement is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Agreement.Text = AgreementTable.Agreement.Format(AgreementTable.Agreement.DefaultValue)
                        		
                End If
                 
            ' If the Agreement is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Agreement.Text Is Nothing _
                OrElse Me.Agreement.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Agreement.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetAgreementFile()
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AgreementFileSpecified Then
                
                Me.AgreementFile.Text = Me.DataSource.AgreementFileName
                Me.AgreementFile.ToolTip = "Open " & Me.AgreementFile.Text
				   If String.IsNullOrEmpty(Me.AgreementFile.Text) Then
					      Me.AgreementFile.Text = Page.GetResourceValue("Txt:OpenFile", "FASTPORT")
                Me.AgreementFile.ToolTip = Me.AgreementFile.Text
				   End If
						
                Me.AgreementFile.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("Agreement") & _
                            "&Field=" & Me.Page.Encrypt("AgreementFile") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                            "&Filename=" & Me.DataSource.AgreementFileName & _
                            "','','left=100,top=50,width=400,height=300,resizable, scrollbars=1');return false;"
                   
                Me.AgreementFile.Visible = True
            Else
                Me.AgreementFile.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetDescription()
            
        
            ' Set the Description Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.Description is the ASP:Literal on the webpage.
            
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
                 
            ' If the Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Description.Text Is Nothing _
                OrElse Me.Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Description.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocHasCustomFields()
            
        
            ' Set the DocHasCustomFields Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocHasCustomFields is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocHasCustomFields()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocHasCustomFieldsSpecified Then
                				
                ' If the DocHasCustomFields is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.DocHasCustomFields)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocHasCustomFields.Text = formattedValue
                
            Else 
            
                ' DocHasCustomFields is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocHasCustomFields.Text = AgreementTable.DocHasCustomFields.Format(AgreementTable.DocHasCustomFields.DefaultValue)
                        		
                End If
                 
            ' If the DocHasCustomFields is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocHasCustomFields.Text Is Nothing _
                OrElse Me.DocHasCustomFields.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocHasCustomFields.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEighthByCIX()
            
        
            ' Set the EighthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthByCIXSpecified Then
                				
                ' If the EighthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EighthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EighthByCIX.Text = formattedValue
                
            Else 
            
                ' EighthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EighthByCIX.Text = AgreementTable.EighthByCIX.Format(AgreementTable.EighthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the EighthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EighthByCIX.Text Is Nothing _
                OrElse Me.EighthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EighthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEighthByOIX()
            
        
            ' Set the EighthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthByOIXSpecified Then
                				
                ' If the EighthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EighthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EighthByOIX.Text = formattedValue
                
            Else 
            
                ' EighthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EighthByOIX.Text = AgreementTable.EighthByOIX.Format(AgreementTable.EighthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the EighthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EighthByOIX.Text Is Nothing _
                OrElse Me.EighthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EighthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEighthDefault()
            
        
            ' Set the EighthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the EighthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EighthDefault.Text Is Nothing _
                OrElse Me.EighthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EighthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEighthItem()
            
        
            ' Set the EighthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the EighthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EighthItem.Text Is Nothing _
                OrElse Me.EighthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EighthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEighthTypeID()
            
        
            ' Set the EighthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EighthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEighthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EighthTypeIDSpecified Then
                				
                ' If the EighthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.EighthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.EighthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.EighthTypeID.ToString(),AgreementTable.EighthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.EighthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.EighthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EighthTypeID.Text = formattedValue
                
            Else 
            
                ' EighthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EighthTypeID.Text = AgreementTable.EighthTypeID.Format(AgreementTable.EighthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the EighthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EighthTypeID.Text Is Nothing _
                OrElse Me.EighthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EighthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEleventhByCIX()
            
        
            ' Set the EleventhByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhByCIXSpecified Then
                				
                ' If the EleventhByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EleventhByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EleventhByCIX.Text = formattedValue
                
            Else 
            
                ' EleventhByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhByCIX.Text = AgreementTable.EleventhByCIX.Format(AgreementTable.EleventhByCIX.DefaultValue)
                        		
                End If
                 
            ' If the EleventhByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EleventhByCIX.Text Is Nothing _
                OrElse Me.EleventhByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EleventhByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEleventhByOIX()
            
        
            ' Set the EleventhByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhByOIXSpecified Then
                				
                ' If the EleventhByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EleventhByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EleventhByOIX.Text = formattedValue
                
            Else 
            
                ' EleventhByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhByOIX.Text = AgreementTable.EleventhByOIX.Format(AgreementTable.EleventhByOIX.DefaultValue)
                        		
                End If
                 
            ' If the EleventhByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EleventhByOIX.Text Is Nothing _
                OrElse Me.EleventhByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EleventhByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEleventhDefault()
            
        
            ' Set the EleventhDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the EleventhDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EleventhDefault.Text Is Nothing _
                OrElse Me.EleventhDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EleventhDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEleventhItem()
            
        
            ' Set the EleventhItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhItemSpecified Then
                				
                ' If the EleventhItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.EleventhItem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.EleventhItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""EleventhItem\"", \""EleventhItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.EleventhItem.Text = formattedValue
                
            Else 
            
                ' EleventhItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhItem.Text = AgreementTable.EleventhItem.Format(AgreementTable.EleventhItem.DefaultValue)
                        		
                End If
                 
            ' If the EleventhItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EleventhItem.Text Is Nothing _
                OrElse Me.EleventhItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EleventhItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetEleventhTypeID()
            
        
            ' Set the EleventhTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.EleventhTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEleventhTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EleventhTypeIDSpecified Then
                				
                ' If the EleventhTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.EleventhTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.EleventhTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.EleventhTypeID.ToString(),AgreementTable.EleventhTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.EleventhTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.EleventhTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EleventhTypeID.Text = formattedValue
                
            Else 
            
                ' EleventhTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.EleventhTypeID.Text = AgreementTable.EleventhTypeID.Format(AgreementTable.EleventhTypeID.DefaultValue)
                        		
                End If
                 
            ' If the EleventhTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EleventhTypeID.Text Is Nothing _
                OrElse Me.EleventhTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EleventhTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetExecuteFromBoard()
            
        
            ' Set the ExecuteFromBoard Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ExecuteFromBoard is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetExecuteFromBoard()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ExecuteFromBoardSpecified Then
                				
                ' If the ExecuteFromBoard is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ExecuteFromBoard)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ExecuteFromBoard.Text = formattedValue
                
            Else 
            
                ' ExecuteFromBoard is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ExecuteFromBoard.Text = AgreementTable.ExecuteFromBoard.Format(AgreementTable.ExecuteFromBoard.DefaultValue)
                        		
                End If
                 
            ' If the ExecuteFromBoard is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ExecuteFromBoard.Text Is Nothing _
                OrElse Me.ExecuteFromBoard.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ExecuteFromBoard.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifteenthByCIX()
            
        
            ' Set the FifteenthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthByCIXSpecified Then
                				
                ' If the FifteenthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifteenthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifteenthByCIX.Text = formattedValue
                
            Else 
            
                ' FifteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthByCIX.Text = AgreementTable.FifteenthByCIX.Format(AgreementTable.FifteenthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the FifteenthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifteenthByCIX.Text Is Nothing _
                OrElse Me.FifteenthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifteenthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifteenthByOIX()
            
        
            ' Set the FifteenthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthByOIXSpecified Then
                				
                ' If the FifteenthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifteenthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifteenthByOIX.Text = formattedValue
                
            Else 
            
                ' FifteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthByOIX.Text = AgreementTable.FifteenthByOIX.Format(AgreementTable.FifteenthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the FifteenthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifteenthByOIX.Text Is Nothing _
                OrElse Me.FifteenthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifteenthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifteenthDefault()
            
        
            ' Set the FifteenthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the FifteenthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifteenthDefault.Text Is Nothing _
                OrElse Me.FifteenthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifteenthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifteenthItem()
            
        
            ' Set the FifteenthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthItemSpecified Then
                				
                ' If the FifteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifteenthItem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FifteenthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FifteenthItem\"", \""FifteenthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.FifteenthItem.Text = formattedValue
                
            Else 
            
                ' FifteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthItem.Text = AgreementTable.FifteenthItem.Format(AgreementTable.FifteenthItem.DefaultValue)
                        		
                End If
                 
            ' If the FifteenthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifteenthItem.Text Is Nothing _
                OrElse Me.FifteenthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifteenthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifteenthTypeID()
            
        
            ' Set the FifteenthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifteenthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifteenthTypeIDSpecified Then
                				
                ' If the FifteenthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FifteenthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FifteenthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FifteenthTypeID.ToString(),AgreementTable.FifteenthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FifteenthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FifteenthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifteenthTypeID.Text = formattedValue
                
            Else 
            
                ' FifteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifteenthTypeID.Text = AgreementTable.FifteenthTypeID.Format(AgreementTable.FifteenthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the FifteenthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifteenthTypeID.Text Is Nothing _
                OrElse Me.FifteenthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifteenthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifthByCIX()
            
        
            ' Set the FifthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthByCIXSpecified Then
                				
                ' If the FifthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifthByCIX.Text = formattedValue
                
            Else 
            
                ' FifthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifthByCIX.Text = AgreementTable.FifthByCIX.Format(AgreementTable.FifthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the FifthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifthByCIX.Text Is Nothing _
                OrElse Me.FifthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifthByOIX()
            
        
            ' Set the FifthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthByOIXSpecified Then
                				
                ' If the FifthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FifthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifthByOIX.Text = formattedValue
                
            Else 
            
                ' FifthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifthByOIX.Text = AgreementTable.FifthByOIX.Format(AgreementTable.FifthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the FifthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifthByOIX.Text Is Nothing _
                OrElse Me.FifthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifthDefault()
            
        
            ' Set the FifthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the FifthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifthDefault.Text Is Nothing _
                OrElse Me.FifthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifthItem()
            
        
            ' Set the FifthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the FifthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifthItem.Text Is Nothing _
                OrElse Me.FifthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFifthTypeID()
            
        
            ' Set the FifthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FifthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFifthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FifthTypeIDSpecified Then
                				
                ' If the FifthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FifthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FifthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FifthTypeID.ToString(),AgreementTable.FifthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FifthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FifthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FifthTypeID.Text = formattedValue
                
            Else 
            
                ' FifthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FifthTypeID.Text = AgreementTable.FifthTypeID.Format(AgreementTable.FifthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the FifthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FifthTypeID.Text Is Nothing _
                OrElse Me.FifthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FifthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFirstByCIX()
            
        
            ' Set the FirstByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstByCIXSpecified Then
                				
                ' If the FirstByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FirstByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FirstByCIX.Text = formattedValue
                
            Else 
            
                ' FirstByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FirstByCIX.Text = AgreementTable.FirstByCIX.Format(AgreementTable.FirstByCIX.DefaultValue)
                        		
                End If
                 
            ' If the FirstByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FirstByCIX.Text Is Nothing _
                OrElse Me.FirstByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FirstByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFirstByOIX()
            
        
            ' Set the FirstByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstByOIXSpecified Then
                				
                ' If the FirstByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FirstByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FirstByOIX.Text = formattedValue
                
            Else 
            
                ' FirstByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FirstByOIX.Text = AgreementTable.FirstByOIX.Format(AgreementTable.FirstByOIX.DefaultValue)
                        		
                End If
                 
            ' If the FirstByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FirstByOIX.Text Is Nothing _
                OrElse Me.FirstByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FirstByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFirstDefault()
            
        
            ' Set the FirstDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the FirstDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FirstDefault.Text Is Nothing _
                OrElse Me.FirstDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FirstDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFirstItem()
            
        
            ' Set the FirstItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the FirstItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FirstItem.Text Is Nothing _
                OrElse Me.FirstItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FirstItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFirstTypeID()
            
        
            ' Set the FirstTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FirstTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFirstTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FirstTypeIDSpecified Then
                				
                ' If the FirstTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FirstTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FirstTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FirstTypeID.ToString(),AgreementTable.FirstTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FirstTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FirstTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FirstTypeID.Text = formattedValue
                
            Else 
            
                ' FirstTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FirstTypeID.Text = AgreementTable.FirstTypeID.Format(AgreementTable.FirstTypeID.DefaultValue)
                        		
                End If
                 
            ' If the FirstTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FirstTypeID.Text Is Nothing _
                OrElse Me.FirstTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FirstTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourteenthByCIX()
            
        
            ' Set the FourteenthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthByCIXSpecified Then
                				
                ' If the FourteenthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourteenthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourteenthByCIX.Text = formattedValue
                
            Else 
            
                ' FourteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthByCIX.Text = AgreementTable.FourteenthByCIX.Format(AgreementTable.FourteenthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the FourteenthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourteenthByCIX.Text Is Nothing _
                OrElse Me.FourteenthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourteenthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourteenthByOIX()
            
        
            ' Set the FourteenthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthByOIXSpecified Then
                				
                ' If the FourteenthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourteenthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourteenthByOIX.Text = formattedValue
                
            Else 
            
                ' FourteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthByOIX.Text = AgreementTable.FourteenthByOIX.Format(AgreementTable.FourteenthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the FourteenthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourteenthByOIX.Text Is Nothing _
                OrElse Me.FourteenthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourteenthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourteenthDefault()
            
        
            ' Set the FourteenthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the FourteenthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourteenthDefault.Text Is Nothing _
                OrElse Me.FourteenthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourteenthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourteenthItem()
            
        
            ' Set the FourteenthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthItemSpecified Then
                				
                ' If the FourteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourteenthItem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FourteenthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FourteenthItem\"", \""FourteenthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.FourteenthItem.Text = formattedValue
                
            Else 
            
                ' FourteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthItem.Text = AgreementTable.FourteenthItem.Format(AgreementTable.FourteenthItem.DefaultValue)
                        		
                End If
                 
            ' If the FourteenthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourteenthItem.Text Is Nothing _
                OrElse Me.FourteenthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourteenthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourteenthTypeID()
            
        
            ' Set the FourteenthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourteenthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourteenthTypeIDSpecified Then
                				
                ' If the FourteenthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FourteenthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FourteenthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FourteenthTypeID.ToString(),AgreementTable.FourteenthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FourteenthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FourteenthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourteenthTypeID.Text = formattedValue
                
            Else 
            
                ' FourteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourteenthTypeID.Text = AgreementTable.FourteenthTypeID.Format(AgreementTable.FourteenthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the FourteenthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourteenthTypeID.Text Is Nothing _
                OrElse Me.FourteenthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourteenthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourthByCIX()
            
        
            ' Set the FourthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthByCIXSpecified Then
                				
                ' If the FourthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourthByCIX.Text = formattedValue
                
            Else 
            
                ' FourthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthByCIX.Text = AgreementTable.FourthByCIX.Format(AgreementTable.FourthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the FourthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourthByCIX.Text Is Nothing _
                OrElse Me.FourthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourthByOIX()
            
        
            ' Set the FourthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthByOIXSpecified Then
                				
                ' If the FourthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourthByOIX.Text = formattedValue
                
            Else 
            
                ' FourthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthByOIX.Text = AgreementTable.FourthByOIX.Format(AgreementTable.FourthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the FourthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourthByOIX.Text Is Nothing _
                OrElse Me.FourthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourthDefault()
            
        
            ' Set the FourthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the FourthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourthDefault.Text Is Nothing _
                OrElse Me.FourthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourthItem()
            
        
            ' Set the FourthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthItemSpecified Then
                				
                ' If the FourthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.FourthItem)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(2000, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(2000, Integer)
                        
                          formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FourthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FourthItem\"", \""FourthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(2000, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(2000, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.FourthItem.Text = formattedValue
                
            Else 
            
                ' FourthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthItem.Text = AgreementTable.FourthItem.Format(AgreementTable.FourthItem.DefaultValue)
                        		
                End If
                 
            ' If the FourthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourthItem.Text Is Nothing _
                OrElse Me.FourthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFourthTypeID()
            
        
            ' Set the FourthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FourthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFourthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FourthTypeIDSpecified Then
                				
                ' If the FourthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FourthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FourthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FourthTypeID.ToString(),AgreementTable.FourthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FourthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FourthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FourthTypeID.Text = formattedValue
                
            Else 
            
                ' FourthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FourthTypeID.Text = AgreementTable.FourthTypeID.Format(AgreementTable.FourthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the FourthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FourthTypeID.Text Is Nothing _
                OrElse Me.FourthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FourthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetInitialsInDocument()
            
        
            ' Set the InitialsInDocument Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.InitialsInDocument is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetInitialsInDocument()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.InitialsInDocumentSpecified Then
                				
                ' If the InitialsInDocument is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.InitialsInDocument)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.InitialsInDocument.Text = formattedValue
                
            Else 
            
                ' InitialsInDocument is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.InitialsInDocument.Text = AgreementTable.InitialsInDocument.Format(AgreementTable.InitialsInDocument.DefaultValue)
                        		
                End If
                 
            ' If the InitialsInDocument is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.InitialsInDocument.Text Is Nothing _
                OrElse Me.InitialsInDocument.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.InitialsInDocument.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetNinthByCIX()
            
        
            ' Set the NinthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthByCIXSpecified Then
                				
                ' If the NinthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.NinthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.NinthByCIX.Text = formattedValue
                
            Else 
            
                ' NinthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.NinthByCIX.Text = AgreementTable.NinthByCIX.Format(AgreementTable.NinthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the NinthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.NinthByCIX.Text Is Nothing _
                OrElse Me.NinthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.NinthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetNinthByOIX()
            
        
            ' Set the NinthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthByOIXSpecified Then
                				
                ' If the NinthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.NinthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.NinthByOIX.Text = formattedValue
                
            Else 
            
                ' NinthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.NinthByOIX.Text = AgreementTable.NinthByOIX.Format(AgreementTable.NinthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the NinthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.NinthByOIX.Text Is Nothing _
                OrElse Me.NinthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.NinthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetNinthDefault()
            
        
            ' Set the NinthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the NinthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.NinthDefault.Text Is Nothing _
                OrElse Me.NinthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.NinthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetNinthItem()
            
        
            ' Set the NinthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the NinthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.NinthItem.Text Is Nothing _
                OrElse Me.NinthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.NinthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetNinthTypeID()
            
        
            ' Set the NinthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.NinthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetNinthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NinthTypeIDSpecified Then
                				
                ' If the NinthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.NinthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.NinthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.NinthTypeID.ToString(),AgreementTable.NinthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.NinthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.NinthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.NinthTypeID.Text = formattedValue
                
            Else 
            
                ' NinthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.NinthTypeID.Text = AgreementTable.NinthTypeID.Format(AgreementTable.NinthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the NinthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.NinthTypeID.Text Is Nothing _
                OrElse Me.NinthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.NinthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetOtherInstructions()
            
        
            ' Set the OtherInstructions Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.OtherInstructions is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetOtherInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.OtherInstructionsSpecified Then
                				
                ' If the OtherInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.OtherInstructions)
                              
                Me.OtherInstructions.Text = formattedValue
                
            Else 
            
                ' OtherInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.OtherInstructions.Text = AgreementTable.OtherInstructions.Format(AgreementTable.OtherInstructions.DefaultValue)
                        		
                End If
                 
            ' If the OtherInstructions is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.OtherInstructions.Text Is Nothing _
                OrElse Me.OtherInstructions.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.OtherInstructions.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRecipientInstructions()
            
        
            ' Set the RecipientInstructions Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RecipientInstructions is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRecipientInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RecipientInstructionsSpecified Then
                				
                ' If the RecipientInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.RecipientInstructions)
                              
                Me.RecipientInstructions.Text = formattedValue
                
            Else 
            
                ' RecipientInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RecipientInstructions.Text = AgreementTable.RecipientInstructions.Format(AgreementTable.RecipientInstructions.DefaultValue)
                        		
                End If
                 
            ' If the RecipientInstructions is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RecipientInstructions.Text Is Nothing _
                OrElse Me.RecipientInstructions.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RecipientInstructions.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRequiredDoc()
            
        
            ' Set the RequiredDoc Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RequiredDoc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRequiredDoc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RequiredDocSpecified Then
                				
                ' If the RequiredDoc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.RequiredDoc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RequiredDoc.Text = formattedValue
                
            Else 
            
                ' RequiredDoc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RequiredDoc.Text = AgreementTable.RequiredDoc.Format(AgreementTable.RequiredDoc.DefaultValue)
                        		
                End If
                 
            ' If the RequiredDoc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RequiredDoc.Text Is Nothing _
                OrElse Me.RequiredDoc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RequiredDoc.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRoleID()
            
        
            ' Set the RoleID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.RoleID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRoleID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RoleIDSpecified Then
                				
                ' If the RoleID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.RoleID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.RoleID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.RoleID.ToString(),AgreementTable.RoleID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.RoleID)
                                End If
                                Else
                                formattedValue = Me.DataSource.RoleID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RoleID.Text = formattedValue
                
            Else 
            
                ' RoleID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RoleID.Text = AgreementTable.RoleID.Format(AgreementTable.RoleID.DefaultValue)
                        		
                End If
                 
            ' If the RoleID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RoleID.Text Is Nothing _
                OrElse Me.RoleID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RoleID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSecondByCIX()
            
        
            ' Set the SecondByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondByCIXSpecified Then
                				
                ' If the SecondByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SecondByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SecondByCIX.Text = formattedValue
                
            Else 
            
                ' SecondByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SecondByCIX.Text = AgreementTable.SecondByCIX.Format(AgreementTable.SecondByCIX.DefaultValue)
                        		
                End If
                 
            ' If the SecondByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SecondByCIX.Text Is Nothing _
                OrElse Me.SecondByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SecondByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSecondByOIX()
            
        
            ' Set the SecondByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondByOIXSpecified Then
                				
                ' If the SecondByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SecondByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SecondByOIX.Text = formattedValue
                
            Else 
            
                ' SecondByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SecondByOIX.Text = AgreementTable.SecondByOIX.Format(AgreementTable.SecondByOIX.DefaultValue)
                        		
                End If
                 
            ' If the SecondByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SecondByOIX.Text Is Nothing _
                OrElse Me.SecondByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SecondByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSecondDefault()
            
        
            ' Set the SecondDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the SecondDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SecondDefault.Text Is Nothing _
                OrElse Me.SecondDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SecondDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSecondItem()
            
        
            ' Set the SecondItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the SecondItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SecondItem.Text Is Nothing _
                OrElse Me.SecondItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SecondItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSecondTypeID()
            
        
            ' Set the SecondTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SecondTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSecondTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SecondTypeIDSpecified Then
                				
                ' If the SecondTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.SecondTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.SecondTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.SecondTypeID.ToString(),AgreementTable.SecondTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.SecondTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.SecondTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SecondTypeID.Text = formattedValue
                
            Else 
            
                ' SecondTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SecondTypeID.Text = AgreementTable.SecondTypeID.Format(AgreementTable.SecondTypeID.DefaultValue)
                        		
                End If
                 
            ' If the SecondTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SecondTypeID.Text Is Nothing _
                OrElse Me.SecondTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SecondTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSenderInstructions()
            
        
            ' Set the SenderInstructions Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SenderInstructions is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSenderInstructions()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SenderInstructionsSpecified Then
                				
                ' If the SenderInstructions is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SenderInstructions)
                              
                Me.SenderInstructions.Text = formattedValue
                
            Else 
            
                ' SenderInstructions is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SenderInstructions.Text = AgreementTable.SenderInstructions.Format(AgreementTable.SenderInstructions.DefaultValue)
                        		
                End If
                 
            ' If the SenderInstructions is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SenderInstructions.Text Is Nothing _
                OrElse Me.SenderInstructions.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SenderInstructions.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSeventhByCIX()
            
        
            ' Set the SeventhByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhByCIXSpecified Then
                				
                ' If the SeventhByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SeventhByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SeventhByCIX.Text = formattedValue
                
            Else 
            
                ' SeventhByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SeventhByCIX.Text = AgreementTable.SeventhByCIX.Format(AgreementTable.SeventhByCIX.DefaultValue)
                        		
                End If
                 
            ' If the SeventhByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SeventhByCIX.Text Is Nothing _
                OrElse Me.SeventhByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SeventhByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSeventhByOIX()
            
        
            ' Set the SeventhByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhByOIXSpecified Then
                				
                ' If the SeventhByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SeventhByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SeventhByOIX.Text = formattedValue
                
            Else 
            
                ' SeventhByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SeventhByOIX.Text = AgreementTable.SeventhByOIX.Format(AgreementTable.SeventhByOIX.DefaultValue)
                        		
                End If
                 
            ' If the SeventhByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SeventhByOIX.Text Is Nothing _
                OrElse Me.SeventhByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SeventhByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSeventhDefault()
            
        
            ' Set the SeventhDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the SeventhDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SeventhDefault.Text Is Nothing _
                OrElse Me.SeventhDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SeventhDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSeventhItem()
            
        
            ' Set the SeventhItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the SeventhItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SeventhItem.Text Is Nothing _
                OrElse Me.SeventhItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SeventhItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSeventhTypeID()
            
        
            ' Set the SeventhTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SeventhTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSeventhTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SeventhTypeIDSpecified Then
                				
                ' If the SeventhTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.SeventhTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.SeventhTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.SeventhTypeID.ToString(),AgreementTable.SeventhTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.SeventhTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.SeventhTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SeventhTypeID.Text = formattedValue
                
            Else 
            
                ' SeventhTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SeventhTypeID.Text = AgreementTable.SeventhTypeID.Format(AgreementTable.SeventhTypeID.DefaultValue)
                        		
                End If
                 
            ' If the SeventhTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SeventhTypeID.Text Is Nothing _
                OrElse Me.SeventhTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SeventhTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetShowExpirationDate()
            
        
            ' Set the ShowExpirationDate Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ShowExpirationDate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetShowExpirationDate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ShowExpirationDateSpecified Then
                				
                ' If the ShowExpirationDate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ShowExpirationDate)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ShowExpirationDate.Text = formattedValue
                
            Else 
            
                ' ShowExpirationDate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ShowExpirationDate.Text = AgreementTable.ShowExpirationDate.Format(AgreementTable.ShowExpirationDate.DefaultValue)
                        		
                End If
                 
            ' If the ShowExpirationDate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ShowExpirationDate.Text Is Nothing _
                OrElse Me.ShowExpirationDate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ShowExpirationDate.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetShowSignatureDate()
            
        
            ' Set the ShowSignatureDate Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ShowSignatureDate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetShowSignatureDate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ShowSignatureDateSpecified Then
                				
                ' If the ShowSignatureDate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ShowSignatureDate)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ShowSignatureDate.Text = formattedValue
                
            Else 
            
                ' ShowSignatureDate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ShowSignatureDate.Text = AgreementTable.ShowSignatureDate.Format(AgreementTable.ShowSignatureDate.DefaultValue)
                        		
                End If
                 
            ' If the ShowSignatureDate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ShowSignatureDate.Text Is Nothing _
                OrElse Me.ShowSignatureDate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ShowSignatureDate.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSixthByCIX()
            
        
            ' Set the SixthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthByCIXSpecified Then
                				
                ' If the SixthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SixthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SixthByCIX.Text = formattedValue
                
            Else 
            
                ' SixthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SixthByCIX.Text = AgreementTable.SixthByCIX.Format(AgreementTable.SixthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the SixthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SixthByCIX.Text Is Nothing _
                OrElse Me.SixthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SixthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSixthByOIX()
            
        
            ' Set the SixthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthByOIXSpecified Then
                				
                ' If the SixthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.SixthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SixthByOIX.Text = formattedValue
                
            Else 
            
                ' SixthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SixthByOIX.Text = AgreementTable.SixthByOIX.Format(AgreementTable.SixthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the SixthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SixthByOIX.Text Is Nothing _
                OrElse Me.SixthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SixthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSixthDefault()
            
        
            ' Set the SixthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the SixthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SixthDefault.Text Is Nothing _
                OrElse Me.SixthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SixthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSixthItem()
            
        
            ' Set the SixthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the SixthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SixthItem.Text Is Nothing _
                OrElse Me.SixthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SixthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetSixthTypeID()
            
        
            ' Set the SixthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.SixthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSixthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SixthTypeIDSpecified Then
                				
                ' If the SixthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.SixthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.SixthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.SixthTypeID.ToString(),AgreementTable.SixthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.SixthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.SixthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SixthTypeID.Text = formattedValue
                
            Else 
            
                ' SixthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.SixthTypeID.Text = AgreementTable.SixthTypeID.Format(AgreementTable.SixthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the SixthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SixthTypeID.Text Is Nothing _
                OrElse Me.SixthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SixthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTenthByCIX()
            
        
            ' Set the TenthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthByCIXSpecified Then
                				
                ' If the TenthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TenthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TenthByCIX.Text = formattedValue
                
            Else 
            
                ' TenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TenthByCIX.Text = AgreementTable.TenthByCIX.Format(AgreementTable.TenthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the TenthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TenthByCIX.Text Is Nothing _
                OrElse Me.TenthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TenthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTenthByOIX()
            
        
            ' Set the TenthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthByOIXSpecified Then
                				
                ' If the TenthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TenthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TenthByOIX.Text = formattedValue
                
            Else 
            
                ' TenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TenthByOIX.Text = AgreementTable.TenthByOIX.Format(AgreementTable.TenthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the TenthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TenthByOIX.Text Is Nothing _
                OrElse Me.TenthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TenthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTenthDefault()
            
        
            ' Set the TenthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the TenthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TenthDefault.Text Is Nothing _
                OrElse Me.TenthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TenthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTenthItem()
            
        
            ' Set the TenthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the TenthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TenthItem.Text Is Nothing _
                OrElse Me.TenthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TenthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTenthTypeID()
            
        
            ' Set the TenthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TenthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TenthTypeIDSpecified Then
                				
                ' If the TenthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.TenthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.TenthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.TenthTypeID.ToString(),AgreementTable.TenthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.TenthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.TenthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TenthTypeID.Text = formattedValue
                
            Else 
            
                ' TenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TenthTypeID.Text = AgreementTable.TenthTypeID.Format(AgreementTable.TenthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the TenthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TenthTypeID.Text Is Nothing _
                OrElse Me.TenthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TenthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirdByCIX()
            
        
            ' Set the ThirdByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdByCIXSpecified Then
                				
                ' If the ThirdByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirdByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirdByCIX.Text = formattedValue
                
            Else 
            
                ' ThirdByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirdByCIX.Text = AgreementTable.ThirdByCIX.Format(AgreementTable.ThirdByCIX.DefaultValue)
                        		
                End If
                 
            ' If the ThirdByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirdByCIX.Text Is Nothing _
                OrElse Me.ThirdByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirdByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirdByOIX()
            
        
            ' Set the ThirdByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdByOIXSpecified Then
                				
                ' If the ThirdByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirdByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirdByOIX.Text = formattedValue
                
            Else 
            
                ' ThirdByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirdByOIX.Text = AgreementTable.ThirdByOIX.Format(AgreementTable.ThirdByOIX.DefaultValue)
                        		
                End If
                 
            ' If the ThirdByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirdByOIX.Text Is Nothing _
                OrElse Me.ThirdByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirdByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirdDefault()
            
        
            ' Set the ThirdDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the ThirdDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirdDefault.Text Is Nothing _
                OrElse Me.ThirdDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirdDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirdItem()
            
        
            ' Set the ThirdItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdItem is the ASP:Literal on the webpage.
            
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
                 
            ' If the ThirdItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirdItem.Text Is Nothing _
                OrElse Me.ThirdItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirdItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirdTypeID()
            
        
            ' Set the ThirdTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirdTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirdTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirdTypeIDSpecified Then
                				
                ' If the ThirdTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.ThirdTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.ThirdTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.ThirdTypeID.ToString(),AgreementTable.ThirdTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.ThirdTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.ThirdTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirdTypeID.Text = formattedValue
                
            Else 
            
                ' ThirdTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirdTypeID.Text = AgreementTable.ThirdTypeID.Format(AgreementTable.ThirdTypeID.DefaultValue)
                        		
                End If
                 
            ' If the ThirdTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirdTypeID.Text Is Nothing _
                OrElse Me.ThirdTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirdTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirteenthByCIX()
            
        
            ' Set the ThirteenthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthByCIXSpecified Then
                				
                ' If the ThirteenthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirteenthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirteenthByCIX.Text = formattedValue
                
            Else 
            
                ' ThirteenthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthByCIX.Text = AgreementTable.ThirteenthByCIX.Format(AgreementTable.ThirteenthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the ThirteenthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirteenthByCIX.Text Is Nothing _
                OrElse Me.ThirteenthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirteenthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirteenthByOIX()
            
        
            ' Set the ThirteenthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthByOIXSpecified Then
                				
                ' If the ThirteenthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirteenthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirteenthByOIX.Text = formattedValue
                
            Else 
            
                ' ThirteenthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthByOIX.Text = AgreementTable.ThirteenthByOIX.Format(AgreementTable.ThirteenthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the ThirteenthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirteenthByOIX.Text Is Nothing _
                OrElse Me.ThirteenthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirteenthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirteenthDefault()
            
        
            ' Set the ThirteenthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the ThirteenthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirteenthDefault.Text Is Nothing _
                OrElse Me.ThirteenthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirteenthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirteenthItem()
            
        
            ' Set the ThirteenthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthItemSpecified Then
                				
                ' If the ThirteenthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.ThirteenthItem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.ThirteenthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""ThirteenthItem\"", \""ThirteenthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.ThirteenthItem.Text = formattedValue
                
            Else 
            
                ' ThirteenthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthItem.Text = AgreementTable.ThirteenthItem.Format(AgreementTable.ThirteenthItem.DefaultValue)
                        		
                End If
                 
            ' If the ThirteenthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirteenthItem.Text Is Nothing _
                OrElse Me.ThirteenthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirteenthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetThirteenthTypeID()
            
        
            ' Set the ThirteenthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.ThirteenthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetThirteenthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ThirteenthTypeIDSpecified Then
                				
                ' If the ThirteenthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.ThirteenthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.ThirteenthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.ThirteenthTypeID.ToString(),AgreementTable.ThirteenthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.ThirteenthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.ThirteenthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ThirteenthTypeID.Text = formattedValue
                
            Else 
            
                ' ThirteenthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ThirteenthTypeID.Text = AgreementTable.ThirteenthTypeID.Format(AgreementTable.ThirteenthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the ThirteenthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ThirteenthTypeID.Text Is Nothing _
                OrElse Me.ThirteenthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ThirteenthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTwelfthByCIX()
            
        
            ' Set the TwelfthByCIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthByCIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthByCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthByCIXSpecified Then
                				
                ' If the TwelfthByCIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TwelfthByCIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TwelfthByCIX.Text = formattedValue
                
            Else 
            
                ' TwelfthByCIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthByCIX.Text = AgreementTable.TwelfthByCIX.Format(AgreementTable.TwelfthByCIX.DefaultValue)
                        		
                End If
                 
            ' If the TwelfthByCIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TwelfthByCIX.Text Is Nothing _
                OrElse Me.TwelfthByCIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TwelfthByCIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTwelfthByOIX()
            
        
            ' Set the TwelfthByOIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthByOIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthByOIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthByOIXSpecified Then
                				
                ' If the TwelfthByOIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TwelfthByOIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TwelfthByOIX.Text = formattedValue
                
            Else 
            
                ' TwelfthByOIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthByOIX.Text = AgreementTable.TwelfthByOIX.Format(AgreementTable.TwelfthByOIX.DefaultValue)
                        		
                End If
                 
            ' If the TwelfthByOIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TwelfthByOIX.Text Is Nothing _
                OrElse Me.TwelfthByOIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TwelfthByOIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTwelfthDefault()
            
        
            ' Set the TwelfthDefault Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthDefault is the ASP:Literal on the webpage.
            
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
                 
            ' If the TwelfthDefault is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TwelfthDefault.Text Is Nothing _
                OrElse Me.TwelfthDefault.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TwelfthDefault.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTwelfthItem()
            
        
            ' Set the TwelfthItem Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthItem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthItemSpecified Then
                				
                ' If the TwelfthItem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.TwelfthItem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.TwelfthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""TwelfthItem\"", \""TwelfthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.TwelfthItem.Text = formattedValue
                
            Else 
            
                ' TwelfthItem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthItem.Text = AgreementTable.TwelfthItem.Format(AgreementTable.TwelfthItem.DefaultValue)
                        		
                End If
                 
            ' If the TwelfthItem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TwelfthItem.Text Is Nothing _
                OrElse Me.TwelfthItem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TwelfthItem.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetTwelfthTypeID()
            
        
            ' Set the TwelfthTypeID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.TwelfthTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTwelfthTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TwelfthTypeIDSpecified Then
                				
                ' If the TwelfthTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.TwelfthTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.TwelfthTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.TwelfthTypeID.ToString(),AgreementTable.TwelfthTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.TwelfthTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.TwelfthTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TwelfthTypeID.Text = formattedValue
                
            Else 
            
                ' TwelfthTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TwelfthTypeID.Text = AgreementTable.TwelfthTypeID.Format(AgreementTable.TwelfthTypeID.DefaultValue)
                        		
                End If
                 
            ' If the TwelfthTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TwelfthTypeID.Text Is Nothing _
                OrElse Me.TwelfthTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TwelfthTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetUseStoredSignature()
            
        
            ' Set the UseStoredSignature Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.UseStoredSignature is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUseStoredSignature()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UseStoredSignatureSpecified Then
                				
                ' If the UseStoredSignature is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.UseStoredSignature)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UseStoredSignature.Text = formattedValue
                
            Else 
            
                ' UseStoredSignature is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.UseStoredSignature.Text = AgreementTable.UseStoredSignature.Format(AgreementTable.UseStoredSignature.DefaultValue)
                        		
                End If
                 
            ' If the UseStoredSignature is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UseStoredSignature.Text Is Nothing _
                OrElse Me.UseStoredSignature.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UseStoredSignature.Text = "&nbsp;"
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
                
        Public Overridable Sub SetExecuteFromBoardLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ExecuteFromBoardLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFieldTypeLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FieldTypeLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetForLbl()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ForLbl.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetForLbl1()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ForLbl1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetInitialsInDocumentLabel()
                  
                  End Sub
                
        Public Overridable Sub SetItemLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ItemLabel.Text = "Some value"
                    
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
                
        Public Overridable Sub SetSenderInstrucitonsLbl()
                  
                  End Sub
                
        Public Overridable Sub SetShowExpirationDateLabel()
                  
                  End Sub
                
        Public Overridable Sub SetShowSignatureDateLabel()
                  
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
          
        Dim recFlowCollectionRecordControl as FlowCollectionRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "FlowCollectionRecordControl"), FlowCollectionRecordControl)
        recFlowCollectionRecordControl.SaveData()
        
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
            
        End Sub
                
        Public Overridable Sub GetDescription()
            
        End Sub
                
        Public Overridable Sub GetDocHasCustomFields()
            
        End Sub
                
        Public Overridable Sub GetEighthByCIX()
            
        End Sub
                
        Public Overridable Sub GetEighthByOIX()
            
        End Sub
                
        Public Overridable Sub GetEighthDefault()
            
        End Sub
                
        Public Overridable Sub GetEighthItem()
            
        End Sub
                
        Public Overridable Sub GetEighthTypeID()
            
        End Sub
                
        Public Overridable Sub GetEleventhByCIX()
            
        End Sub
                
        Public Overridable Sub GetEleventhByOIX()
            
        End Sub
                
        Public Overridable Sub GetEleventhDefault()
            
        End Sub
                
        Public Overridable Sub GetEleventhItem()
            
        End Sub
                
        Public Overridable Sub GetEleventhTypeID()
            
        End Sub
                
        Public Overridable Sub GetExecuteFromBoard()
            
        End Sub
                
        Public Overridable Sub GetFifteenthByCIX()
            
        End Sub
                
        Public Overridable Sub GetFifteenthByOIX()
            
        End Sub
                
        Public Overridable Sub GetFifteenthDefault()
            
        End Sub
                
        Public Overridable Sub GetFifteenthItem()
            
        End Sub
                
        Public Overridable Sub GetFifteenthTypeID()
            
        End Sub
                
        Public Overridable Sub GetFifthByCIX()
            
        End Sub
                
        Public Overridable Sub GetFifthByOIX()
            
        End Sub
                
        Public Overridable Sub GetFifthDefault()
            
        End Sub
                
        Public Overridable Sub GetFifthItem()
            
        End Sub
                
        Public Overridable Sub GetFifthTypeID()
            
        End Sub
                
        Public Overridable Sub GetFirstByCIX()
            
        End Sub
                
        Public Overridable Sub GetFirstByOIX()
            
        End Sub
                
        Public Overridable Sub GetFirstDefault()
            
        End Sub
                
        Public Overridable Sub GetFirstItem()
            
        End Sub
                
        Public Overridable Sub GetFirstTypeID()
            
        End Sub
                
        Public Overridable Sub GetFourteenthByCIX()
            
        End Sub
                
        Public Overridable Sub GetFourteenthByOIX()
            
        End Sub
                
        Public Overridable Sub GetFourteenthDefault()
            
        End Sub
                
        Public Overridable Sub GetFourteenthItem()
            
        End Sub
                
        Public Overridable Sub GetFourteenthTypeID()
            
        End Sub
                
        Public Overridable Sub GetFourthByCIX()
            
        End Sub
                
        Public Overridable Sub GetFourthByOIX()
            
        End Sub
                
        Public Overridable Sub GetFourthDefault()
            
        End Sub
                
        Public Overridable Sub GetFourthItem()
            
        End Sub
                
        Public Overridable Sub GetFourthTypeID()
            
        End Sub
                
        Public Overridable Sub GetInitialsInDocument()
            
        End Sub
                
        Public Overridable Sub GetNinthByCIX()
            
        End Sub
                
        Public Overridable Sub GetNinthByOIX()
            
        End Sub
                
        Public Overridable Sub GetNinthDefault()
            
        End Sub
                
        Public Overridable Sub GetNinthItem()
            
        End Sub
                
        Public Overridable Sub GetNinthTypeID()
            
        End Sub
                
        Public Overridable Sub GetOtherInstructions()
            
        End Sub
                
        Public Overridable Sub GetRecipientInstructions()
            
        End Sub
                
        Public Overridable Sub GetRequiredDoc()
            
        End Sub
                
        Public Overridable Sub GetRoleID()
            
        End Sub
                
        Public Overridable Sub GetSecondByCIX()
            
        End Sub
                
        Public Overridable Sub GetSecondByOIX()
            
        End Sub
                
        Public Overridable Sub GetSecondDefault()
            
        End Sub
                
        Public Overridable Sub GetSecondItem()
            
        End Sub
                
        Public Overridable Sub GetSecondTypeID()
            
        End Sub
                
        Public Overridable Sub GetSenderInstructions()
            
        End Sub
                
        Public Overridable Sub GetSeventhByCIX()
            
        End Sub
                
        Public Overridable Sub GetSeventhByOIX()
            
        End Sub
                
        Public Overridable Sub GetSeventhDefault()
            
        End Sub
                
        Public Overridable Sub GetSeventhItem()
            
        End Sub
                
        Public Overridable Sub GetSeventhTypeID()
            
        End Sub
                
        Public Overridable Sub GetShowExpirationDate()
            
        End Sub
                
        Public Overridable Sub GetShowSignatureDate()
            
        End Sub
                
        Public Overridable Sub GetSixthByCIX()
            
        End Sub
                
        Public Overridable Sub GetSixthByOIX()
            
        End Sub
                
        Public Overridable Sub GetSixthDefault()
            
        End Sub
                
        Public Overridable Sub GetSixthItem()
            
        End Sub
                
        Public Overridable Sub GetSixthTypeID()
            
        End Sub
                
        Public Overridable Sub GetTenthByCIX()
            
        End Sub
                
        Public Overridable Sub GetTenthByOIX()
            
        End Sub
                
        Public Overridable Sub GetTenthDefault()
            
        End Sub
                
        Public Overridable Sub GetTenthItem()
            
        End Sub
                
        Public Overridable Sub GetTenthTypeID()
            
        End Sub
                
        Public Overridable Sub GetThirdByCIX()
            
        End Sub
                
        Public Overridable Sub GetThirdByOIX()
            
        End Sub
                
        Public Overridable Sub GetThirdDefault()
            
        End Sub
                
        Public Overridable Sub GetThirdItem()
            
        End Sub
                
        Public Overridable Sub GetThirdTypeID()
            
        End Sub
                
        Public Overridable Sub GetThirteenthByCIX()
            
        End Sub
                
        Public Overridable Sub GetThirteenthByOIX()
            
        End Sub
                
        Public Overridable Sub GetThirteenthDefault()
            
        End Sub
                
        Public Overridable Sub GetThirteenthItem()
            
        End Sub
                
        Public Overridable Sub GetThirteenthTypeID()
            
        End Sub
                
        Public Overridable Sub GetTwelfthByCIX()
            
        End Sub
                
        Public Overridable Sub GetTwelfthByOIX()
            
        End Sub
                
        Public Overridable Sub GetTwelfthDefault()
            
        End Sub
                
        Public Overridable Sub GetTwelfthItem()
            
        End Sub
                
        Public Overridable Sub GetTwelfthTypeID()
            
        End Sub
                
        Public Overridable Sub GetUseStoredSignature()
            
        End Sub
                
      
        ' To customize, override this method in AgreementRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementRecordControl As Boolean = False
      
        Dim hasFiltersFlowCollectionRecordControl As Boolean = False
      
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
            HttpContext.Current.Session("QueryString in ShowAgreement") = recId
              
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
              
                Dim hasFiltersFlowCollectionRecordControl As Boolean = False
              
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
        
        Public ReadOnly Property Agreement() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Agreement"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AgreementFile() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementFile"), System.Web.UI.WebControls.LinkButton)
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
        
        Public ReadOnly Property Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocHasCustomFields() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocHasCustomFields"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocHasCustomFieldsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocHasCustomFieldsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ExecuteFromBoard() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExecuteFromBoard"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ExecuteFromBoardLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExecuteFromBoardLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FieldTypeLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FieldTypeLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FlowCollectionRecordControl() As FlowCollectionRecordControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FlowCollectionRecordControl"), FlowCollectionRecordControl)
            End Get
        End Property
        
        Public ReadOnly Property ForLbl() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ForLbl"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property ForLbl1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ForLbl1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property InitialsInDocument() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "InitialsInDocument"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property NinthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthTypeID"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property OtherInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OtherInstructions"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property RecipientInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecipientInstructions"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RequiredDoc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RequiredDoc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RequiredDocLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RequiredDocLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RoleIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SenderInstrucitonsLbl() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstrucitonsLbl"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SenderInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstructions"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ShowExpirationDate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowExpirationDate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ShowExpirationDateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowExpirationDateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ShowSignatureDate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowSignatureDate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ShowSignatureDateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ShowSignatureDateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UseStoredSignature() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UseStoredSignature"), System.Web.UI.WebControls.Literal)
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

  
' Base class for the FlowCollectionRecordControl control on the ShowAgreement page.
' Do not modify this class. Instead override any method in FlowCollectionRecordControl.
Public Class BaseFlowCollectionRecordControl
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in FlowCollectionRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
            
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in FlowCollectionRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource FlowCollection record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "FlowCollectionRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New FlowCollectionRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As FlowCollectionRecord = FlowCollectionTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = FlowCollectionTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in FlowCollectionRecordControl.
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
        
                SetCollectionDescription()
                SetCollectionImage()
                SetCollectionName()
                SetHeaderCollectionLiteral()
      
      
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
        
        
        Public Overridable Sub SetCollectionDescription()
            
        
            ' Set the CollectionDescription Literal on the webpage with value from the
            ' FlowCollection database record.

            ' Me.DataSource is the FlowCollection record retrieved from the database.
            ' Me.CollectionDescription is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCollectionDescription()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CollectionDescriptionSpecified Then
                				
                ' If the CollectionDescription is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(FlowCollectionTable.CollectionDescription)
                              
                Me.CollectionDescription.Text = formattedValue
                
            Else 
            
                ' CollectionDescription is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CollectionDescription.Text = FlowCollectionTable.CollectionDescription.Format(FlowCollectionTable.CollectionDescription.DefaultValue)
                        		
                End If
                 
            ' If the CollectionDescription is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CollectionDescription.Text Is Nothing _
                OrElse Me.CollectionDescription.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CollectionDescription.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCollectionImage()
            ' Set the CollectionImage Image on the webpage with value from the
            ' FlowCollection database record.
            
            ' Me.DataSource is the FlowCollection record retrieved from the database.
            ' Me.CollectionImage is the ASP:Image on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCollectionImage()
            ' and add your own code before or after the call to the MyBase function.
             
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CollectionImageSpecified Then
            
                ' If the CollectionImage is non-NULL, then format the value.
                ' The Format method will use the Display Format
                ' Shrunk image size specified by ImagePercentSize on Properties.
                Me.CollectionImage.ImageUrl = Me.DataSource.FormatImageUrl(FlowCollectionTable.CollectionImage, Me.Page.Encrypt("FlowCollection"), Me.Page.Encrypt("CollectionImage"), Me.Page.Encrypt(Me.DataSource.GetID().ToXmlString()), 100)
                            				
                Me.CollectionImage.Visible = True
            Else
                ' CollectionImage is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                Me.CollectionImage.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetCollectionName()
            
        
            ' Set the CollectionName Literal on the webpage with value from the
            ' FlowCollection database record.

            ' Me.DataSource is the FlowCollection record retrieved from the database.
            ' Me.CollectionName is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCollectionName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CollectionNameSpecified Then
                				
                ' If the CollectionName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(FlowCollectionTable.CollectionName)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CollectionName.Text = formattedValue
                
            Else 
            
                ' CollectionName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CollectionName.Text = FlowCollectionTable.CollectionName.Format(FlowCollectionTable.CollectionName.DefaultValue)
                        		
                End If
                 
            ' If the CollectionName is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CollectionName.Text Is Nothing _
                OrElse Me.CollectionName.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CollectionName.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetHeaderCollectionLiteral()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HeaderCollectionLiteral.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in FlowCollectionRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "FlowCollectionRecordControlPanel"), System.Web.UI.WebControls.Panel)

          If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
              Return
          End If
          
        Dim parentCtrl As AgreementRecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "AgreementRecordControl"), AgreementRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "FASTPORT"))
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

        ' To customize, override this method in FlowCollectionRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetCollectionDescription()
            GetCollectionName()
        End Sub
        
        
        Public Overridable Sub GetCollectionDescription()
            
        End Sub
                
        Public Overridable Sub GetCollectionName()
            
        End Sub
                
      
        ' To customize, override this method in FlowCollectionRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementRecordControl As Boolean = False
      
        Dim hasFiltersFlowCollectionRecordControl As Boolean = False
      
            Dim wc As WhereClause
            FlowCollectionTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim agreementRecordControlObj as AgreementRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "AgreementRecordControl") ,AgreementRecordControl)
                              
                If (Not IsNothing(agreementRecordControlObj) AndAlso Not IsNothing(agreementRecordControlObj.GetRecord()) AndAlso agreementRecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(agreementRecordControlObj.GetRecord().FlowCollectionID))
                    wc.iAND(FlowCollectionTable.FlowCollectionID, BaseFilter.ComparisonOperator.EqualsTo, agreementRecordControlObj.GetRecord().FlowCollectionID.ToString())
                    selectedRecordKeyValue.AddElement(FlowCollectionTable.FlowCollectionID.InternalName, agreementRecordControlObj.GetRecord().FlowCollectionID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("FlowCollectionRecordControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            FlowCollectionTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersAgreementRecordControl As Boolean = False
              
                Dim hasFiltersFlowCollectionRecordControl As Boolean = False
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

            
            Dim selectedRecordInAgreementRecordControl as String = DirectCast(HttpContext.Current.Session("FlowCollectionRecordControlWhereClause"), String)
            
            If Not selectedRecordInAgreementRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInAgreementRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInAgreementRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(FlowCollectionTable.FlowCollectionID) Then
            wc.iAND(FlowCollectionTable.FlowCollectionID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(FlowCollectionTable.FlowCollectionID).ToString())
       End If
      
            End If
          
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
        
    

        ' To customize, override this method in FlowCollectionRecordControl.
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
          FlowCollectionTable.DeleteRecord(pkValue)
          
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
                Return CType(Me.ViewState("BaseFlowCollectionRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseFlowCollectionRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As FlowCollectionRecord
        Public Property DataSource() As FlowCollectionRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As FlowCollectionRecord)
            
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
        
        Public ReadOnly Property CollectionDescription() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CollectionDescription"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CollectionImage() As System.Web.UI.WebControls.Image
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CollectionImage"), System.Web.UI.WebControls.Image)
            End Get
        End Property
            
        Public ReadOnly Property CollectionName() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CollectionName"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HeaderCollectionLiteral() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HeaderCollectionLiteral"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As FlowCollectionRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As FlowCollectionRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return FlowCollectionTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
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

  