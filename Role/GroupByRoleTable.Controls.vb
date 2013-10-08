
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' GroupByRoleTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace FASTPORT.UI.Controls.GroupByRoleTable

#Region "Section 1: Place your customizations here."

    
Public Class AgreementTableControlRow
        Inherits BaseAgreementTableControlRow
        ' The BaseAgreementTableControlRow implements code for a ROW within the
        ' the AgreementTableControl table.  The BaseAgreementTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of AgreementTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class AgreementTableControl
        Inherits BaseAgreementTableControl

    ' The BaseAgreementTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The AgreementTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class CarrierAdContactsTableControlRow
        Inherits BaseCarrierAdContactsTableControlRow
        ' The BaseCarrierAdContactsTableControlRow implements code for a ROW within the
        ' the CarrierAdContactsTableControl table.  The BaseCarrierAdContactsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of CarrierAdContactsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class CarrierAdContactsTableControl
        Inherits BaseCarrierAdContactsTableControl

    ' The BaseCarrierAdContactsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The CarrierAdContactsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class DocTreeTableControlRow
        Inherits BaseDocTreeTableControlRow
        ' The BaseDocTreeTableControlRow implements code for a ROW within the
        ' the DocTreeTableControl table.  The BaseDocTreeTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of DocTreeTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class DocTreeTableControl
        Inherits BaseDocTreeTableControl

    ' The BaseDocTreeTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The DocTreeTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class RoleTableControlRow
        Inherits BaseRoleTableControlRow
        ' The BaseRoleTableControlRow implements code for a ROW within the
        ' the RoleTableControl table.  The BaseRoleTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of RoleTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class RoleTableControl
        Inherits BaseRoleTableControl

    ' The BaseRoleTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The RoleTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the AgreementTableControlRow control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in AgreementTableControlRow.
Public Class BaseAgreementTableControlRow
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in AgreementTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
          
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in AgreementTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)
                    
        
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
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseAgreementTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New AgreementRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in AgreementTableControlRow.
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
                SetAgreementFileName()
                SetAgreementFileNameLabel()
                SetAgreementLabel()
                SetCIX()
                SetCIXLabel()
                SetCreatedAt()
                SetCreatedAtLabel()
                SetCreatedByID()
                SetCreatedByIDLabel()
                SetCustomID()
                SetCustomIDLabel()
                SetDescription()
                SetDescriptionLabel()
                SetDocHasCustomFields()
                SetDocHasCustomFieldsLabel()
                SetDocIndex()
                SetDocIndexLabel()
                SetDocRank()
                SetDocRankLabel()
                SetDocSort()
                SetDocSortLabel()
                SetDocTreeParentID()
                SetDocTreeParentIDLabel()
                SetEighthByCIX()
                SetEighthByCIXLabel()
                SetEighthByOIX()
                SetEighthByOIXLabel()
                SetEighthDefault()
                SetEighthDefaultLabel()
                SetEighthItem()
                SetEighthItemLabel()
                SetEighthTypeID()
                SetEighthTypeIDLabel()
                SetEleventhByCIX()
                SetEleventhByCIXLabel()
                SetEleventhByOIX()
                SetEleventhByOIXLabel()
                SetEleventhDefault()
                SetEleventhDefaultLabel()
                SetEleventhItem()
                SetEleventhItemLabel()
                SetEleventhTypeID()
                SetEleventhTypeIDLabel()
                SetExecuteFromBoard()
                SetExecuteFromBoardLabel()
                SetFifteenthByCIX()
                SetFifteenthByCIXLabel()
                SetFifteenthByOIX()
                SetFifteenthByOIXLabel()
                SetFifteenthDefault()
                SetFifteenthDefaultLabel()
                SetFifteenthItem()
                SetFifteenthItemLabel()
                SetFifteenthTypeID()
                SetFifteenthTypeIDLabel()
                SetFifthByCIX()
                SetFifthByCIXLabel()
                SetFifthByOIX()
                SetFifthByOIXLabel()
                SetFifthDefault()
                SetFifthDefaultLabel()
                SetFifthItem()
                SetFifthItemLabel()
                SetFifthTypeID()
                SetFifthTypeIDLabel()
                SetFirstByCIX()
                SetFirstByCIXLabel()
                SetFirstByOIX()
                SetFirstByOIXLabel()
                SetFirstDefault()
                SetFirstDefaultLabel()
                SetFirstItem()
                SetFirstItemLabel()
                SetFirstTypeID()
                SetFirstTypeIDLabel()
                SetFlowCollectionID()
                SetFlowCollectionIDLabel()
                SetFourteenthByCIX()
                SetFourteenthByCIXLabel()
                SetFourteenthByOIX()
                SetFourteenthByOIXLabel()
                SetFourteenthDefault()
                SetFourteenthDefaultLabel()
                SetFourteenthItem()
                SetFourteenthItemLabel()
                SetFourteenthTypeID()
                SetFourteenthTypeIDLabel()
                SetFourthByCIX()
                SetFourthByCIXLabel()
                SetFourthByOIX()
                SetFourthByOIXLabel()
                SetFourthDefault()
                SetFourthDefaultLabel()
                SetFourthItem()
                SetFourthItemLabel()
                SetFourthTypeID()
                SetFourthTypeIDLabel()
                SetHide()
                SetHideLabel()
                SetInitialsInDocument()
                SetInitialsInDocumentLabel()
                SetNinthByCIX()
                SetNinthByCIXLabel()
                SetNinthByOIX()
                SetNinthByOIXLabel()
                SetNinthDefault()
                SetNinthDefaultLabel()
                SetNinthItem()
                SetNinthItemLabel()
                SetNinthTypeID()
                SetNinthTypeIDLabel()
                SetOtherInstructions()
                SetOtherInstructionsLabel()
                SetRecipientInstructions()
                SetRecipientInstructionsLabel()
                SetRequiredDoc()
                SetRequiredDocLabel()
                SetSecondByCIX()
                SetSecondByCIXLabel()
                SetSecondByOIX()
                SetSecondByOIXLabel()
                SetSecondDefault()
                SetSecondDefaultLabel()
                SetSecondItem()
                SetSecondItemLabel()
                SetSecondTypeID()
                SetSecondTypeIDLabel()
                SetSenderInstructions()
                SetSenderInstructionsLabel()
                SetSeventhByCIX()
                SetSeventhByCIXLabel()
                SetSeventhByOIX()
                SetSeventhByOIXLabel()
                SetSeventhDefault()
                SetSeventhDefaultLabel()
                SetSeventhItem()
                SetSeventhItemLabel()
                SetSeventhTypeID()
                SetSeventhTypeIDLabel()
                SetShowExpirationDate()
                SetShowExpirationDateLabel()
                SetShowSignatureDate()
                SetShowSignatureDateLabel()
                SetSixthByCIX()
                SetSixthByCIXLabel()
                SetSixthByOIX()
                SetSixthByOIXLabel()
                SetSixthDefault()
                SetSixthDefaultLabel()
                SetSixthItem()
                SetSixthItemLabel()
                SetSixthTypeID()
                SetSixthTypeIDLabel()
                SetTenthByCIX()
                SetTenthByCIXLabel()
                SetTenthByOIX()
                SetTenthByOIXLabel()
                SetTenthDefault()
                SetTenthDefaultLabel()
                SetTenthItem()
                SetTenthItemLabel()
                SetTenthTypeID()
                SetTenthTypeIDLabel()
                SetThirdByCIX()
                SetThirdByCIXLabel()
                SetThirdByOIX()
                SetThirdByOIXLabel()
                SetThirdDefault()
                SetThirdDefaultLabel()
                SetThirdItem()
                SetThirdItemLabel()
                SetThirdTypeID()
                SetThirdTypeIDLabel()
                SetThirteenthByCIX()
                SetThirteenthByCIXLabel()
                SetThirteenthByOIX()
                SetThirteenthByOIXLabel()
                SetThirteenthDefault()
                SetThirteenthDefaultLabel()
                SetThirteenthItem()
                SetThirteenthItemLabel()
                SetThirteenthTypeID()
                SetThirteenthTypeIDLabel()
                SetTwelfthByCIX()
                SetTwelfthByCIXLabel()
                SetTwelfthByOIX()
                SetTwelfthByOIXLabel()
                SetTwelfthDefault()
                SetTwelfthDefaultLabel()
                SetTwelfthItem()
                SetTwelfthItemLabel()
                SetTwelfthTypeID()
                SetTwelfthTypeIDLabel()
                SetUpdatedAt()
                SetUpdatedAtLabel()
                SetUpdatedByID()
                SetUpdatedByIDLabel()
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
                
                Me.AgreementFile.Text = Page.GetResourceValue("Txt:OpenFile", "FASTPORT")
                        
                Me.AgreementFile.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("Agreement") & _
                            "&Field=" & Me.Page.Encrypt("AgreementFile") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.AgreementFile.Visible = True
            Else
                Me.AgreementFile.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetAgreementFileName()
            
        
            ' Set the AgreementFileName Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.AgreementFileName is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAgreementFileName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AgreementFileNameSpecified Then
                				
                ' If the AgreementFileName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.AgreementFileName)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AgreementFileName.Text = formattedValue
                
            Else 
            
                ' AgreementFileName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.AgreementFileName.Text = AgreementTable.AgreementFileName.Format(AgreementTable.AgreementFileName.DefaultValue)
                        		
                End If
                 
            ' If the AgreementFileName is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AgreementFileName.Text Is Nothing _
                OrElse Me.AgreementFileName.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AgreementFileName.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCIX()
            
        
            ' Set the CIX Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.CIX is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCIX()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CIXSpecified Then
                				
                ' If the CIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.CIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CIX.Text = formattedValue
                
            Else 
            
                ' CIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CIX.Text = AgreementTable.CIX.Format(AgreementTable.CIX.DefaultValue)
                        		
                End If
                 
            ' If the CIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CIX.Text Is Nothing _
                OrElse Me.CIX.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CIX.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCreatedAt()
            
        
            ' Set the CreatedAt Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.CreatedAt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCreatedAt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CreatedAtSpecified Then
                				
                ' If the CreatedAt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.CreatedAt, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CreatedAt.Text = formattedValue
                
            Else 
            
                ' CreatedAt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CreatedAt.Text = AgreementTable.CreatedAt.Format(AgreementTable.CreatedAt.DefaultValue, "g")
                        		
                End If
                 
            ' If the CreatedAt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CreatedAt.Text Is Nothing _
                OrElse Me.CreatedAt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CreatedAt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCreatedByID()
            
        
            ' Set the CreatedByID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.CreatedByID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCreatedByID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CreatedByIDSpecified Then
                				
                ' If the CreatedByID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.CreatedByID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CreatedByID.Text = formattedValue
                
            Else 
            
                ' CreatedByID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CreatedByID.Text = AgreementTable.CreatedByID.Format(AgreementTable.CreatedByID.DefaultValue)
                        		
                End If
                 
            ' If the CreatedByID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CreatedByID.Text Is Nothing _
                OrElse Me.CreatedByID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CreatedByID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCustomID()
            
        
            ' Set the CustomID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.CustomID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCustomID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CustomIDSpecified Then
                				
                ' If the CustomID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.CustomID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.CustomID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.CustomID.ToString(),AgreementTable.CustomID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.CustomID)
                                End If
                                Else
                                formattedValue = Me.DataSource.CustomID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CustomID.Text = formattedValue
                
            Else 
            
                ' CustomID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CustomID.Text = AgreementTable.CustomID.Format(AgreementTable.CustomID.DefaultValue)
                        		
                End If
                 
            ' If the CustomID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CustomID.Text Is Nothing _
                OrElse Me.CustomID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CustomID.Text = "&nbsp;"
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.Description.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""Description\"", \""Description\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                
        Public Overridable Sub SetDocIndex()
            
        
            ' Set the DocIndex Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocIndex is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocIndex()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocIndexSpecified Then
                				
                ' If the DocIndex is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.DocIndex)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocIndex.Text = formattedValue
                
            Else 
            
                ' DocIndex is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocIndex.Text = AgreementTable.DocIndex.Format(AgreementTable.DocIndex.DefaultValue)
                        		
                End If
                 
            ' If the DocIndex is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocIndex.Text Is Nothing _
                OrElse Me.DocIndex.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocIndex.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocRank()
            
        
            ' Set the DocRank Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocRank is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocRank()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocRankSpecified Then
                				
                ' If the DocRank is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.DocRank)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocRank.Text = formattedValue
                
            Else 
            
                ' DocRank is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocRank.Text = AgreementTable.DocRank.Format(AgreementTable.DocRank.DefaultValue)
                        		
                End If
                 
            ' If the DocRank is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocRank.Text Is Nothing _
                OrElse Me.DocRank.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocRank.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocSort()
            
        
            ' Set the DocSort Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocSort is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocSort()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocSortSpecified Then
                				
                ' If the DocSort is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.DocSort)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocSort.Text = formattedValue
                
            Else 
            
                ' DocSort is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocSort.Text = AgreementTable.DocSort.Format(AgreementTable.DocSort.DefaultValue)
                        		
                End If
                 
            ' If the DocSort is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocSort.Text Is Nothing _
                OrElse Me.DocSort.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocSort.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocTreeParentID()
            
        
            ' Set the DocTreeParentID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.DocTreeParentID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocTreeParentID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocTreeParentIDSpecified Then
                				
                ' If the DocTreeParentID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.DocTreeParentID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.DocTreeParentID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.DocTreeParentID.ToString(),AgreementTable.DocTreeParentID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.DocTreeParentID)
                                End If
                                Else
                                formattedValue = Me.DataSource.DocTreeParentID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocTreeParentID.Text = formattedValue
                
            Else 
            
                ' DocTreeParentID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocTreeParentID.Text = AgreementTable.DocTreeParentID.Format(AgreementTable.DocTreeParentID.DefaultValue)
                        		
                End If
                 
            ' If the DocTreeParentID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocTreeParentID.Text Is Nothing _
                OrElse Me.DocTreeParentID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocTreeParentID.Text = "&nbsp;"
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.EighthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""EighthDefault\"", \""EighthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.EighthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""EighthItem\"", \""EighthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.EleventhDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""EleventhDefault\"", \""EleventhDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FifteenthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FifteenthDefault\"", \""FifteenthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FifthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FifthDefault\"", \""FifthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FifthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FifthItem\"", \""FifthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FirstDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FirstDefault\"", \""FirstDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FirstItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FirstItem\"", \""FirstItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                
        Public Overridable Sub SetFlowCollectionID()
            
        
            ' Set the FlowCollectionID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.FlowCollectionID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFlowCollectionID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FlowCollectionIDSpecified Then
                				
                ' If the FlowCollectionID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = AgreementTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(AgreementTable.FlowCollectionID)
                                  If _isExpandableNonCompositeForeignKey AndAlso AgreementTable.FlowCollectionID.IsApplyDisplayAs Then
                                  
                                      formattedValue = AgreementTable.GetDFKA(Me.DataSource.FlowCollectionID.ToString(),AgreementTable.FlowCollectionID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(AgreementTable.FlowCollectionID)
                                End If
                                Else
                                formattedValue = Me.DataSource.FlowCollectionID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FlowCollectionID.Text = formattedValue
                
            Else 
            
                ' FlowCollectionID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.FlowCollectionID.Text = AgreementTable.FlowCollectionID.Format(AgreementTable.FlowCollectionID.DefaultValue)
                        		
                End If
                 
            ' If the FlowCollectionID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FlowCollectionID.Text Is Nothing _
                OrElse Me.FlowCollectionID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FlowCollectionID.Text = "&nbsp;"
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FourteenthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FourteenthDefault\"", \""FourteenthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FourthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FourthDefault\"", \""FourthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.FourthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""FourthItem\"", \""FourthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                
        Public Overridable Sub SetHide()
            
        
            ' Set the Hide Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.Hide is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHide()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HideSpecified Then
                				
                ' If the Hide is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.Hide)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Hide.Text = formattedValue
                
            Else 
            
                ' Hide is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Hide.Text = AgreementTable.Hide.Format(AgreementTable.Hide.DefaultValue)
                        		
                End If
                 
            ' If the Hide is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Hide.Text Is Nothing _
                OrElse Me.Hide.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Hide.Text = "&nbsp;"
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.NinthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""NinthDefault\"", \""NinthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.NinthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""NinthItem\"", \""NinthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.OtherInstructions.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""OtherInstructions\"", \""OtherInstructions\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.RecipientInstructions.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""RecipientInstructions\"", \""RecipientInstructions\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SecondDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SecondDefault\"", \""SecondDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SecondItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SecondItem\"", \""SecondItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SenderInstructions.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SenderInstructions\"", \""SenderInstructions\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SeventhDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SeventhDefault\"", \""SeventhDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SeventhItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SeventhItem\"", \""SeventhItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SixthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SixthDefault\"", \""SixthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.SixthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""SixthItem\"", \""SixthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.TenthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""TenthDefault\"", \""TenthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.TenthItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""TenthItem\"", \""TenthItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.ThirdDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""ThirdDefault\"", \""ThirdDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.ThirdItem.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""ThirdItem\"", \""ThirdItem\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.ThirteenthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""ThirteenthDefault\"", \""ThirteenthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                    
                        Dim name As String = HttpUtility.HtmlEncode(AgreementTable.TwelfthDefault.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""FASTPORT.Business.AgreementTable, FASTPORT.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""TwelfthDefault\"", \""TwelfthDefault\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) &"\"", false, 200," _
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
                
        Public Overridable Sub SetUpdatedAt()
            
        
            ' Set the UpdatedAt Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.UpdatedAt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUpdatedAt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UpdatedAtSpecified Then
                				
                ' If the UpdatedAt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.UpdatedAt, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UpdatedAt.Text = formattedValue
                
            Else 
            
                ' UpdatedAt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.UpdatedAt.Text = AgreementTable.UpdatedAt.Format(AgreementTable.UpdatedAt.DefaultValue, "g")
                        		
                End If
                 
            ' If the UpdatedAt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UpdatedAt.Text Is Nothing _
                OrElse Me.UpdatedAt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UpdatedAt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetUpdatedByID()
            
        
            ' Set the UpdatedByID Literal on the webpage with value from the
            ' Agreement database record.

            ' Me.DataSource is the Agreement record retrieved from the database.
            ' Me.UpdatedByID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUpdatedByID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UpdatedByIDSpecified Then
                				
                ' If the UpdatedByID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(AgreementTable.UpdatedByID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UpdatedByID.Text = formattedValue
                
            Else 
            
                ' UpdatedByID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.UpdatedByID.Text = AgreementTable.UpdatedByID.Format(AgreementTable.UpdatedByID.DefaultValue)
                        		
                End If
                 
            ' If the UpdatedByID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UpdatedByID.Text Is Nothing _
                OrElse Me.UpdatedByID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UpdatedByID.Text = "&nbsp;"
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
                  
                  End Sub
                
        Public Overridable Sub SetAgreementFileNameLabel()
                  
                  End Sub
                
        Public Overridable Sub SetAgreementLabel()
                  
                  End Sub
                
        Public Overridable Sub SetCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetCreatedAtLabel()
                  
                  End Sub
                
        Public Overridable Sub SetCreatedByIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetCustomIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDescriptionLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocHasCustomFieldsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocIndexLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocRankLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocTreeParentIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEighthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEleventhByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEleventhByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEleventhDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEleventhItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEleventhTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetExecuteFromBoardLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifteenthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifteenthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifteenthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifteenthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifteenthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFifthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFirstByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFirstByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFirstDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFirstItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFirstTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFlowCollectionIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourteenthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourteenthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourteenthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourteenthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourteenthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFourthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetHideLabel()
                  
                  End Sub
                
        Public Overridable Sub SetInitialsInDocumentLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNinthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNinthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNinthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNinthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNinthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetOtherInstructionsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRecipientInstructionsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRequiredDocLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSecondByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSecondByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSecondDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSecondItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSecondTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSenderInstructionsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSeventhTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetShowExpirationDateLabel()
                  
                  End Sub
                
        Public Overridable Sub SetShowSignatureDateLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetSixthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTenthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTenthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTenthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTenthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTenthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirdByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirdByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirdDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirdItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirdTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirteenthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirteenthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirteenthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirteenthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetThirteenthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTwelfthByCIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTwelfthByOIXLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTwelfthDefaultLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTwelfthItemLabel()
                  
                  End Sub
                
        Public Overridable Sub SetTwelfthTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetUpdatedAtLabel()
                  
                  End Sub
                
        Public Overridable Sub SetUpdatedByIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetUseStoredSignatureLabel()
                  
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

      
        
        ' To customize, override this method in AgreementTableControlRow.
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
        
        Dim parentCtrl As RoleTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow"), RoleTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "FASTPORT"))
            End If
            
            Me.DataSource.RoleID = parentCtrl.DataSource.RoleID
              
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
              
                DirectCast(GetParentControlObject(Me, "AgreementTableControl"), AgreementTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "AgreementTableControl"), AgreementTableControl).ResetData = True
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

        ' To customize, override this method in AgreementTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAgreement()
            GetAgreementFileName()
            GetCIX()
            GetCreatedAt()
            GetCreatedByID()
            GetCustomID()
            GetDescription()
            GetDocHasCustomFields()
            GetDocIndex()
            GetDocRank()
            GetDocSort()
            GetDocTreeParentID()
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
            GetHide()
            GetInitialsInDocument()
            GetNinthByCIX()
            GetNinthByOIX()
            GetNinthDefault()
            GetNinthItem()
            GetNinthTypeID()
            GetOtherInstructions()
            GetRecipientInstructions()
            GetRequiredDoc()
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
            GetUpdatedAt()
            GetUpdatedByID()
            GetUseStoredSignature()
        End Sub
        
        
        Public Overridable Sub GetAgreement()
            
        End Sub
                
        Public Overridable Sub GetAgreementFileName()
            
        End Sub
                
        Public Overridable Sub GetCIX()
            
        End Sub
                
        Public Overridable Sub GetCreatedAt()
            
        End Sub
                
        Public Overridable Sub GetCreatedByID()
            
        End Sub
                
        Public Overridable Sub GetCustomID()
            
        End Sub
                
        Public Overridable Sub GetDescription()
            
        End Sub
                
        Public Overridable Sub GetDocHasCustomFields()
            
        End Sub
                
        Public Overridable Sub GetDocIndex()
            
        End Sub
                
        Public Overridable Sub GetDocRank()
            
        End Sub
                
        Public Overridable Sub GetDocSort()
            
        End Sub
                
        Public Overridable Sub GetDocTreeParentID()
            
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
                
        Public Overridable Sub GetFlowCollectionID()
            
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
                
        Public Overridable Sub GetHide()
            
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
                
        Public Overridable Sub GetUpdatedAt()
            
        End Sub
                
        Public Overridable Sub GetUpdatedByID()
            
        End Sub
                
        Public Overridable Sub GetUseStoredSignature()
            
        End Sub
                
      
        ' To customize, override this method in AgreementTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in AgreementTableControlRow.
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
          
            DirectCast(GetParentControlObject(Me, "AgreementTableControl"), AgreementTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "AgreementTableControl"), AgreementTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseAgreementTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseAgreementTableControlRow_Rec") = value
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
        
        Public ReadOnly Property AgreementFileName() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementFileName"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AgreementFileNameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementFileNameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AgreementLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CreatedAt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedAt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CreatedAtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedAtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CreatedByID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedByID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CreatedByIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedByIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CustomID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CustomID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CustomIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CustomIDLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property DocIndex() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocIndex"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocIndexLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocIndexLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocRank() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocRank"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocRankLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocRankLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocSort() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocSort"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocSortLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocSortLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocTreeParentID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeParentID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocTreeParentIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeParentIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EighthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EighthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EighthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EleventhTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EleventhTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EleventhTypeIDLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property FifteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FifthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FifthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FifthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FirstTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FirstTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FirstTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FlowCollectionID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FlowCollectionID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FlowCollectionIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FlowCollectionIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FourthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FourthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FourthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Hide() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Hide"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HideLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HideLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property NinthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property NinthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property NinthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property NinthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property NinthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property NinthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NinthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property OtherInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OtherInstructions"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property OtherInstructionsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OtherInstructionsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RecipientInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecipientInstructions"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RecipientInstructionsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecipientInstructionsLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property SecondByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SecondTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SecondTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SecondTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SenderInstructions() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstructions"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SenderInstructionsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SenderInstructionsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SeventhByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SeventhByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SeventhDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SeventhItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SeventhTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SeventhTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SeventhTypeIDLabel"), System.Web.UI.WebControls.Literal)
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
            
        Public ReadOnly Property SixthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SixthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SixthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SixthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirdTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirdTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirdTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ThirteenthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ThirteenthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ThirteenthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthByCIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByCIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthByCIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByCIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthByOIX() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByOIX"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthByOIXLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthByOIXLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthDefault() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthDefault"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthDefaultLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthDefaultLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthItem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthItem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TwelfthTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TwelfthTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TwelfthTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UpdatedAt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedAt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UpdatedAtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedAtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UpdatedByID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedByID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UpdatedByIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedByIDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the AgreementTableControl control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in AgreementTableControl.
Public Class BaseAgreementTableControl
        Inherits FASTPORT.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
                  
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            
    End If

    
    
            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            
        
            
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.AgreementPagination.FirstPage.Click, AddressOf AgreementPagination_FirstPage_Click
              
              AddHandler Me.AgreementPagination.LastPage.Click, AddressOf AgreementPagination_LastPage_Click
              
              AddHandler Me.AgreementPagination.NextPage.Click, AddressOf AgreementPagination_NextPage_Click
              
              AddHandler Me.AgreementPagination.PageSizeButton.Click, AddressOf AgreementPagination_PageSizeButton_Click
            
              AddHandler Me.AgreementPagination.PreviousPage.Click, AddressOf AgreementPagination_PreviousPage_Click
                          
        
            ' Setup the sorting events.
          
            ' Setup the button events.
              
        
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(AgreementRecord)), AgreementRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, AgreementTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As AgreementTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(AgreementRecord)), AgreementRecord())
                Else  ' Get the records from the database	
                        Me.DataSource = AgreementTable.GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      
        
          ' Bind the repeater with the list of records to expand the UI.
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()

          Dim index As Integer = 0
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          ' Loop through all rows in the table, set its DataSource and call DataBind().
          Dim recControl As AgreementTableControlRow = DirectCast(repItem.FindControl("AgreementTableControlRow"), AgreementTableControlRow)
          recControl.DataSource = Me.DataSource(index)
          If Me.UIData.Count > index Then
          recControl.PreviousUIData = Me.UIData(index)
          End If
          recControl.DataBind()
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
          index += 1
          Next
        
    
           
                
            ' Call the Set methods for each controls on the panel
        
                
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(AgreementTable.CustomID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.DocTreeParentID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.EighthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.EleventhTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FifteenthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FifthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FirstTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FlowCollectionID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FourteenthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.FourthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.NinthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.SecondTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.SeventhTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.SixthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.TenthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.ThirdTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.ThirteenthTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(AgreementTable.TwelfthTypeID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
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
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

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




        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.AgreementPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.AgreementPagination.CurrentPage.Text = "0"
            End If
            Me.AgreementPagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for AgreementTableControl pagination.
        
            Me.AgreementPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.AgreementPagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.AgreementPagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.AgreementPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.AgreementPagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.AgreementPagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.AgreementPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.AgreementPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As AgreementTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
        
            Return jFilter

        End Function

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            AgreementTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim roleRecordObj as KeyValue
        roleRecordObj = Nothing
      
              Dim roleTableControlObjRow As RoleTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow") ,RoleTableControlRow)
            
                If (Not IsNothing(roleTableControlObjRow) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord()) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord().RoleID))
                    wc.iAND(AgreementTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, roleTableControlObjRow.GetRecord().RoleID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("AgreementTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            AgreementTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersAgreementTableControl As Boolean = False
        
          Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
        
          Dim hasFiltersDocTreeTableControl As Boolean = False
        
          Dim hasFiltersRoleTableControl As Boolean = False
        
      ' Compose the WHERE clause consiting of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInRoleTableControl as String = DirectCast(HttpContext.Current.Session("AgreementTableControlWhereClause"), String)
            
            If Not selectedRecordInRoleTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInRoleTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInRoleTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(AgreementTable.RoleID) Then
            wc.iAND(AgreementTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(AgreementTable.RoleID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
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
                        if index = Len(resultItem) Then   'Make decision to append "..."
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
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.AgreementPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.AgreementPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As AgreementTableControlRow = DirectCast(repItem.FindControl("AgreementTableControlRow"), AgreementTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As AgreementRecord = New AgreementRecord()
        
                        If recControl.Agreement.Text <> "" Then
                            rec.Parse(recControl.Agreement.Text, AgreementTable.Agreement)
                        End If
                        If recControl.AgreementFile.Text <> "" Then
                            rec.Parse(recControl.AgreementFile.Text, AgreementTable.AgreementFile)
                        End If
                        If recControl.AgreementFileName.Text <> "" Then
                            rec.Parse(recControl.AgreementFileName.Text, AgreementTable.AgreementFileName)
                        End If
                        If recControl.CIX.Text <> "" Then
                            rec.Parse(recControl.CIX.Text, AgreementTable.CIX)
                        End If
                        If recControl.CreatedAt.Text <> "" Then
                            rec.Parse(recControl.CreatedAt.Text, AgreementTable.CreatedAt)
                        End If
                        If recControl.CreatedByID.Text <> "" Then
                            rec.Parse(recControl.CreatedByID.Text, AgreementTable.CreatedByID)
                        End If
                        If recControl.CustomID.Text <> "" Then
                            rec.Parse(recControl.CustomID.Text, AgreementTable.CustomID)
                        End If
                        If recControl.Description.Text <> "" Then
                            rec.Parse(recControl.Description.Text, AgreementTable.Description)
                        End If
                        If recControl.DocHasCustomFields.Text <> "" Then
                            rec.Parse(recControl.DocHasCustomFields.Text, AgreementTable.DocHasCustomFields)
                        End If
                        If recControl.DocIndex.Text <> "" Then
                            rec.Parse(recControl.DocIndex.Text, AgreementTable.DocIndex)
                        End If
                        If recControl.DocRank.Text <> "" Then
                            rec.Parse(recControl.DocRank.Text, AgreementTable.DocRank)
                        End If
                        If recControl.DocSort.Text <> "" Then
                            rec.Parse(recControl.DocSort.Text, AgreementTable.DocSort)
                        End If
                        If recControl.DocTreeParentID.Text <> "" Then
                            rec.Parse(recControl.DocTreeParentID.Text, AgreementTable.DocTreeParentID)
                        End If
                        If recControl.EighthByCIX.Text <> "" Then
                            rec.Parse(recControl.EighthByCIX.Text, AgreementTable.EighthByCIX)
                        End If
                        If recControl.EighthByOIX.Text <> "" Then
                            rec.Parse(recControl.EighthByOIX.Text, AgreementTable.EighthByOIX)
                        End If
                        If recControl.EighthDefault.Text <> "" Then
                            rec.Parse(recControl.EighthDefault.Text, AgreementTable.EighthDefault)
                        End If
                        If recControl.EighthItem.Text <> "" Then
                            rec.Parse(recControl.EighthItem.Text, AgreementTable.EighthItem)
                        End If
                        If recControl.EighthTypeID.Text <> "" Then
                            rec.Parse(recControl.EighthTypeID.Text, AgreementTable.EighthTypeID)
                        End If
                        If recControl.EleventhByCIX.Text <> "" Then
                            rec.Parse(recControl.EleventhByCIX.Text, AgreementTable.EleventhByCIX)
                        End If
                        If recControl.EleventhByOIX.Text <> "" Then
                            rec.Parse(recControl.EleventhByOIX.Text, AgreementTable.EleventhByOIX)
                        End If
                        If recControl.EleventhDefault.Text <> "" Then
                            rec.Parse(recControl.EleventhDefault.Text, AgreementTable.EleventhDefault)
                        End If
                        If recControl.EleventhItem.Text <> "" Then
                            rec.Parse(recControl.EleventhItem.Text, AgreementTable.EleventhItem)
                        End If
                        If recControl.EleventhTypeID.Text <> "" Then
                            rec.Parse(recControl.EleventhTypeID.Text, AgreementTable.EleventhTypeID)
                        End If
                        If recControl.ExecuteFromBoard.Text <> "" Then
                            rec.Parse(recControl.ExecuteFromBoard.Text, AgreementTable.ExecuteFromBoard)
                        End If
                        If recControl.FifteenthByCIX.Text <> "" Then
                            rec.Parse(recControl.FifteenthByCIX.Text, AgreementTable.FifteenthByCIX)
                        End If
                        If recControl.FifteenthByOIX.Text <> "" Then
                            rec.Parse(recControl.FifteenthByOIX.Text, AgreementTable.FifteenthByOIX)
                        End If
                        If recControl.FifteenthDefault.Text <> "" Then
                            rec.Parse(recControl.FifteenthDefault.Text, AgreementTable.FifteenthDefault)
                        End If
                        If recControl.FifteenthItem.Text <> "" Then
                            rec.Parse(recControl.FifteenthItem.Text, AgreementTable.FifteenthItem)
                        End If
                        If recControl.FifteenthTypeID.Text <> "" Then
                            rec.Parse(recControl.FifteenthTypeID.Text, AgreementTable.FifteenthTypeID)
                        End If
                        If recControl.FifthByCIX.Text <> "" Then
                            rec.Parse(recControl.FifthByCIX.Text, AgreementTable.FifthByCIX)
                        End If
                        If recControl.FifthByOIX.Text <> "" Then
                            rec.Parse(recControl.FifthByOIX.Text, AgreementTable.FifthByOIX)
                        End If
                        If recControl.FifthDefault.Text <> "" Then
                            rec.Parse(recControl.FifthDefault.Text, AgreementTable.FifthDefault)
                        End If
                        If recControl.FifthItem.Text <> "" Then
                            rec.Parse(recControl.FifthItem.Text, AgreementTable.FifthItem)
                        End If
                        If recControl.FifthTypeID.Text <> "" Then
                            rec.Parse(recControl.FifthTypeID.Text, AgreementTable.FifthTypeID)
                        End If
                        If recControl.FirstByCIX.Text <> "" Then
                            rec.Parse(recControl.FirstByCIX.Text, AgreementTable.FirstByCIX)
                        End If
                        If recControl.FirstByOIX.Text <> "" Then
                            rec.Parse(recControl.FirstByOIX.Text, AgreementTable.FirstByOIX)
                        End If
                        If recControl.FirstDefault.Text <> "" Then
                            rec.Parse(recControl.FirstDefault.Text, AgreementTable.FirstDefault)
                        End If
                        If recControl.FirstItem.Text <> "" Then
                            rec.Parse(recControl.FirstItem.Text, AgreementTable.FirstItem)
                        End If
                        If recControl.FirstTypeID.Text <> "" Then
                            rec.Parse(recControl.FirstTypeID.Text, AgreementTable.FirstTypeID)
                        End If
                        If recControl.FlowCollectionID.Text <> "" Then
                            rec.Parse(recControl.FlowCollectionID.Text, AgreementTable.FlowCollectionID)
                        End If
                        If recControl.FourteenthByCIX.Text <> "" Then
                            rec.Parse(recControl.FourteenthByCIX.Text, AgreementTable.FourteenthByCIX)
                        End If
                        If recControl.FourteenthByOIX.Text <> "" Then
                            rec.Parse(recControl.FourteenthByOIX.Text, AgreementTable.FourteenthByOIX)
                        End If
                        If recControl.FourteenthDefault.Text <> "" Then
                            rec.Parse(recControl.FourteenthDefault.Text, AgreementTable.FourteenthDefault)
                        End If
                        If recControl.FourteenthItem.Text <> "" Then
                            rec.Parse(recControl.FourteenthItem.Text, AgreementTable.FourteenthItem)
                        End If
                        If recControl.FourteenthTypeID.Text <> "" Then
                            rec.Parse(recControl.FourteenthTypeID.Text, AgreementTable.FourteenthTypeID)
                        End If
                        If recControl.FourthByCIX.Text <> "" Then
                            rec.Parse(recControl.FourthByCIX.Text, AgreementTable.FourthByCIX)
                        End If
                        If recControl.FourthByOIX.Text <> "" Then
                            rec.Parse(recControl.FourthByOIX.Text, AgreementTable.FourthByOIX)
                        End If
                        If recControl.FourthDefault.Text <> "" Then
                            rec.Parse(recControl.FourthDefault.Text, AgreementTable.FourthDefault)
                        End If
                        If recControl.FourthItem.Text <> "" Then
                            rec.Parse(recControl.FourthItem.Text, AgreementTable.FourthItem)
                        End If
                        If recControl.FourthTypeID.Text <> "" Then
                            rec.Parse(recControl.FourthTypeID.Text, AgreementTable.FourthTypeID)
                        End If
                        If recControl.Hide.Text <> "" Then
                            rec.Parse(recControl.Hide.Text, AgreementTable.Hide)
                        End If
                        If recControl.InitialsInDocument.Text <> "" Then
                            rec.Parse(recControl.InitialsInDocument.Text, AgreementTable.InitialsInDocument)
                        End If
                        If recControl.NinthByCIX.Text <> "" Then
                            rec.Parse(recControl.NinthByCIX.Text, AgreementTable.NinthByCIX)
                        End If
                        If recControl.NinthByOIX.Text <> "" Then
                            rec.Parse(recControl.NinthByOIX.Text, AgreementTable.NinthByOIX)
                        End If
                        If recControl.NinthDefault.Text <> "" Then
                            rec.Parse(recControl.NinthDefault.Text, AgreementTable.NinthDefault)
                        End If
                        If recControl.NinthItem.Text <> "" Then
                            rec.Parse(recControl.NinthItem.Text, AgreementTable.NinthItem)
                        End If
                        If recControl.NinthTypeID.Text <> "" Then
                            rec.Parse(recControl.NinthTypeID.Text, AgreementTable.NinthTypeID)
                        End If
                        If recControl.OtherInstructions.Text <> "" Then
                            rec.Parse(recControl.OtherInstructions.Text, AgreementTable.OtherInstructions)
                        End If
                        If recControl.RecipientInstructions.Text <> "" Then
                            rec.Parse(recControl.RecipientInstructions.Text, AgreementTable.RecipientInstructions)
                        End If
                        If recControl.RequiredDoc.Text <> "" Then
                            rec.Parse(recControl.RequiredDoc.Text, AgreementTable.RequiredDoc)
                        End If
                        If recControl.SecondByCIX.Text <> "" Then
                            rec.Parse(recControl.SecondByCIX.Text, AgreementTable.SecondByCIX)
                        End If
                        If recControl.SecondByOIX.Text <> "" Then
                            rec.Parse(recControl.SecondByOIX.Text, AgreementTable.SecondByOIX)
                        End If
                        If recControl.SecondDefault.Text <> "" Then
                            rec.Parse(recControl.SecondDefault.Text, AgreementTable.SecondDefault)
                        End If
                        If recControl.SecondItem.Text <> "" Then
                            rec.Parse(recControl.SecondItem.Text, AgreementTable.SecondItem)
                        End If
                        If recControl.SecondTypeID.Text <> "" Then
                            rec.Parse(recControl.SecondTypeID.Text, AgreementTable.SecondTypeID)
                        End If
                        If recControl.SenderInstructions.Text <> "" Then
                            rec.Parse(recControl.SenderInstructions.Text, AgreementTable.SenderInstructions)
                        End If
                        If recControl.SeventhByCIX.Text <> "" Then
                            rec.Parse(recControl.SeventhByCIX.Text, AgreementTable.SeventhByCIX)
                        End If
                        If recControl.SeventhByOIX.Text <> "" Then
                            rec.Parse(recControl.SeventhByOIX.Text, AgreementTable.SeventhByOIX)
                        End If
                        If recControl.SeventhDefault.Text <> "" Then
                            rec.Parse(recControl.SeventhDefault.Text, AgreementTable.SeventhDefault)
                        End If
                        If recControl.SeventhItem.Text <> "" Then
                            rec.Parse(recControl.SeventhItem.Text, AgreementTable.SeventhItem)
                        End If
                        If recControl.SeventhTypeID.Text <> "" Then
                            rec.Parse(recControl.SeventhTypeID.Text, AgreementTable.SeventhTypeID)
                        End If
                        If recControl.ShowExpirationDate.Text <> "" Then
                            rec.Parse(recControl.ShowExpirationDate.Text, AgreementTable.ShowExpirationDate)
                        End If
                        If recControl.ShowSignatureDate.Text <> "" Then
                            rec.Parse(recControl.ShowSignatureDate.Text, AgreementTable.ShowSignatureDate)
                        End If
                        If recControl.SixthByCIX.Text <> "" Then
                            rec.Parse(recControl.SixthByCIX.Text, AgreementTable.SixthByCIX)
                        End If
                        If recControl.SixthByOIX.Text <> "" Then
                            rec.Parse(recControl.SixthByOIX.Text, AgreementTable.SixthByOIX)
                        End If
                        If recControl.SixthDefault.Text <> "" Then
                            rec.Parse(recControl.SixthDefault.Text, AgreementTable.SixthDefault)
                        End If
                        If recControl.SixthItem.Text <> "" Then
                            rec.Parse(recControl.SixthItem.Text, AgreementTable.SixthItem)
                        End If
                        If recControl.SixthTypeID.Text <> "" Then
                            rec.Parse(recControl.SixthTypeID.Text, AgreementTable.SixthTypeID)
                        End If
                        If recControl.TenthByCIX.Text <> "" Then
                            rec.Parse(recControl.TenthByCIX.Text, AgreementTable.TenthByCIX)
                        End If
                        If recControl.TenthByOIX.Text <> "" Then
                            rec.Parse(recControl.TenthByOIX.Text, AgreementTable.TenthByOIX)
                        End If
                        If recControl.TenthDefault.Text <> "" Then
                            rec.Parse(recControl.TenthDefault.Text, AgreementTable.TenthDefault)
                        End If
                        If recControl.TenthItem.Text <> "" Then
                            rec.Parse(recControl.TenthItem.Text, AgreementTable.TenthItem)
                        End If
                        If recControl.TenthTypeID.Text <> "" Then
                            rec.Parse(recControl.TenthTypeID.Text, AgreementTable.TenthTypeID)
                        End If
                        If recControl.ThirdByCIX.Text <> "" Then
                            rec.Parse(recControl.ThirdByCIX.Text, AgreementTable.ThirdByCIX)
                        End If
                        If recControl.ThirdByOIX.Text <> "" Then
                            rec.Parse(recControl.ThirdByOIX.Text, AgreementTable.ThirdByOIX)
                        End If
                        If recControl.ThirdDefault.Text <> "" Then
                            rec.Parse(recControl.ThirdDefault.Text, AgreementTable.ThirdDefault)
                        End If
                        If recControl.ThirdItem.Text <> "" Then
                            rec.Parse(recControl.ThirdItem.Text, AgreementTable.ThirdItem)
                        End If
                        If recControl.ThirdTypeID.Text <> "" Then
                            rec.Parse(recControl.ThirdTypeID.Text, AgreementTable.ThirdTypeID)
                        End If
                        If recControl.ThirteenthByCIX.Text <> "" Then
                            rec.Parse(recControl.ThirteenthByCIX.Text, AgreementTable.ThirteenthByCIX)
                        End If
                        If recControl.ThirteenthByOIX.Text <> "" Then
                            rec.Parse(recControl.ThirteenthByOIX.Text, AgreementTable.ThirteenthByOIX)
                        End If
                        If recControl.ThirteenthDefault.Text <> "" Then
                            rec.Parse(recControl.ThirteenthDefault.Text, AgreementTable.ThirteenthDefault)
                        End If
                        If recControl.ThirteenthItem.Text <> "" Then
                            rec.Parse(recControl.ThirteenthItem.Text, AgreementTable.ThirteenthItem)
                        End If
                        If recControl.ThirteenthTypeID.Text <> "" Then
                            rec.Parse(recControl.ThirteenthTypeID.Text, AgreementTable.ThirteenthTypeID)
                        End If
                        If recControl.TwelfthByCIX.Text <> "" Then
                            rec.Parse(recControl.TwelfthByCIX.Text, AgreementTable.TwelfthByCIX)
                        End If
                        If recControl.TwelfthByOIX.Text <> "" Then
                            rec.Parse(recControl.TwelfthByOIX.Text, AgreementTable.TwelfthByOIX)
                        End If
                        If recControl.TwelfthDefault.Text <> "" Then
                            rec.Parse(recControl.TwelfthDefault.Text, AgreementTable.TwelfthDefault)
                        End If
                        If recControl.TwelfthItem.Text <> "" Then
                            rec.Parse(recControl.TwelfthItem.Text, AgreementTable.TwelfthItem)
                        End If
                        If recControl.TwelfthTypeID.Text <> "" Then
                            rec.Parse(recControl.TwelfthTypeID.Text, AgreementTable.TwelfthTypeID)
                        End If
                        If recControl.UpdatedAt.Text <> "" Then
                            rec.Parse(recControl.UpdatedAt.Text, AgreementTable.UpdatedAt)
                        End If
                        If recControl.UpdatedByID.Text <> "" Then
                            rec.Parse(recControl.UpdatedByID.Text, AgreementTable.UpdatedByID)
                        End If
                        If recControl.UseStoredSignature.Text <> "" Then
                            rec.Parse(recControl.UseStoredSignature.Text, AgreementTable.UseStoredSignature)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New AgreementRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(AgreementRecord)), AgreementRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As AgreementTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As AgreementTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
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
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
        
            
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
        


    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("AgreementTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            End If
            
    Dim pageIndex As String = CType(ViewState("Page_Index"), String)
    If pageIndex IsNot Nothing Then
    Me.PageIndex = CInt(pageIndex)
    End If

    Dim pageSize As String = CType(ViewState("Page_Size"), String)
    If Not pageSize Is Nothing Then
    Me.PageSize = CInt(pageSize)
    End If

    
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("AgreementTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub AgreementPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub AgreementPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub AgreementPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub AgreementPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.AgreementPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.AgreementPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub AgreementPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Protected _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Protected _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = AgreementTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As AgreementRecord = Nothing
        Public Property DataSource() As AgreementRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As AgreementRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property AgreementPagination() As FASTPORT.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementPagination"), FASTPORT.UI.IPaginationModern)
          End Get
          End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As AgreementTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
                End If
                Dim rec As AgreementRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As AgreementTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As AgreementTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(AgreementTableControlRow)), AgreementTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As AgreementTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
            End If
            
            Dim recCtl As AgreementTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As AgreementTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("AgreementTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
            
                Dim recControl As AgreementTableControlRow = DirectCast(repItem.FindControl("AgreementTableControlRow"), AgreementTableControlRow)
                recList.Add(recControl)
              
            Next

            Return DirectCast(recList.ToArray(GetType(AgreementTableControlRow)), AgreementTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the CarrierAdContactsTableControlRow control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in CarrierAdContactsTableControlRow.
Public Class BaseCarrierAdContactsTableControlRow
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in CarrierAdContactsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
          
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in CarrierAdContactsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)
                    
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource CarrierAdContacts record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = CarrierAdContactsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseCarrierAdContactsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New CarrierAdContactsRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in CarrierAdContactsTableControlRow.
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
        
                SetAdID()
                SetAdIDLabel()
                SetContactTypeID()
                SetContactTypeIDLabel()
                SetPartyID()
                SetPartyIDLabel()
      
      
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
        
        
        Public Overridable Sub SetAdID()
            
        
            ' Set the AdID Literal on the webpage with value from the
            ' CarrierAdContacts database record.

            ' Me.DataSource is the CarrierAdContacts record retrieved from the database.
            ' Me.AdID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAdID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AdIDSpecified Then
                				
                ' If the AdID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = CarrierAdContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CarrierAdContactsTable.AdID)
                                  If _isExpandableNonCompositeForeignKey AndAlso CarrierAdContactsTable.AdID.IsApplyDisplayAs Then
                                  
                                      formattedValue = CarrierAdContactsTable.GetDFKA(Me.DataSource.AdID.ToString(),CarrierAdContactsTable.AdID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(CarrierAdContactsTable.AdID)
                                End If
                                Else
                                formattedValue = Me.DataSource.AdID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AdID.Text = formattedValue
                
            Else 
            
                ' AdID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.AdID.Text = CarrierAdContactsTable.AdID.Format(CarrierAdContactsTable.AdID.DefaultValue)
                        		
                End If
                 
            ' If the AdID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AdID.Text Is Nothing _
                OrElse Me.AdID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AdID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetContactTypeID()
            
        
            ' Set the ContactTypeID Literal on the webpage with value from the
            ' CarrierAdContacts database record.

            ' Me.DataSource is the CarrierAdContacts record retrieved from the database.
            ' Me.ContactTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetContactTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ContactTypeIDSpecified Then
                				
                ' If the ContactTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = CarrierAdContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CarrierAdContactsTable.ContactTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso CarrierAdContactsTable.ContactTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = CarrierAdContactsTable.GetDFKA(Me.DataSource.ContactTypeID.ToString(),CarrierAdContactsTable.ContactTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(CarrierAdContactsTable.ContactTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.ContactTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ContactTypeID.Text = formattedValue
                
            Else 
            
                ' ContactTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ContactTypeID.Text = CarrierAdContactsTable.ContactTypeID.Format(CarrierAdContactsTable.ContactTypeID.DefaultValue)
                        		
                End If
                 
            ' If the ContactTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ContactTypeID.Text Is Nothing _
                OrElse Me.ContactTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ContactTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetPartyID()
            
        
            ' Set the PartyID Literal on the webpage with value from the
            ' CarrierAdContacts database record.

            ' Me.DataSource is the CarrierAdContacts record retrieved from the database.
            ' Me.PartyID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPartyID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PartyIDSpecified Then
                				
                ' If the PartyID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = CarrierAdContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(CarrierAdContactsTable.PartyID)
                                  If _isExpandableNonCompositeForeignKey AndAlso CarrierAdContactsTable.PartyID.IsApplyDisplayAs Then
                                  
                                      formattedValue = CarrierAdContactsTable.GetDFKA(Me.DataSource.PartyID.ToString(),CarrierAdContactsTable.PartyID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(CarrierAdContactsTable.PartyID)
                                End If
                                Else
                                formattedValue = Me.DataSource.PartyID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PartyID.Text = formattedValue
                
            Else 
            
                ' PartyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.PartyID.Text = CarrierAdContactsTable.PartyID.Format(CarrierAdContactsTable.PartyID.DefaultValue)
                        		
                End If
                 
            ' If the PartyID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PartyID.Text Is Nothing _
                OrElse Me.PartyID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PartyID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetAdIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetContactTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetPartyIDLabel()
                  
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

      
        
        ' To customize, override this method in CarrierAdContactsTableControlRow.
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
        
        Dim parentCtrl As RoleTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow"), RoleTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "FASTPORT"))
            End If
            
            Me.DataSource.RoleID = parentCtrl.DataSource.RoleID
              
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
              
                DirectCast(GetParentControlObject(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl).ResetData = True
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

        ' To customize, override this method in CarrierAdContactsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAdID()
            GetContactTypeID()
            GetPartyID()
        End Sub
        
        
        Public Overridable Sub GetAdID()
            
        End Sub
                
        Public Overridable Sub GetContactTypeID()
            
        End Sub
                
        Public Overridable Sub GetPartyID()
            
        End Sub
                
      
        ' To customize, override this method in CarrierAdContactsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in CarrierAdContactsTableControlRow.
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
          CarrierAdContactsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseCarrierAdContactsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseCarrierAdContactsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As CarrierAdContactsRecord
        Public Property DataSource() As CarrierAdContactsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As CarrierAdContactsRecord)
            
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
        
        Public ReadOnly Property AdID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AdID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AdIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AdIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ContactTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ContactTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ContactTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ContactTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PartyID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PartyIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As CarrierAdContactsRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As CarrierAdContactsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return CarrierAdContactsTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the CarrierAdContactsTableControl control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in CarrierAdContactsTableControl.
Public Class BaseCarrierAdContactsTableControl
        Inherits FASTPORT.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
                  
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            
    End If

    
    
            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            
        
            
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.CarrierAdContactsPagination.FirstPage.Click, AddressOf CarrierAdContactsPagination_FirstPage_Click
              
              AddHandler Me.CarrierAdContactsPagination.LastPage.Click, AddressOf CarrierAdContactsPagination_LastPage_Click
              
              AddHandler Me.CarrierAdContactsPagination.NextPage.Click, AddressOf CarrierAdContactsPagination_NextPage_Click
              
              AddHandler Me.CarrierAdContactsPagination.PageSizeButton.Click, AddressOf CarrierAdContactsPagination_PageSizeButton_Click
            
              AddHandler Me.CarrierAdContactsPagination.PreviousPage.Click, AddressOf CarrierAdContactsPagination_PreviousPage_Click
                          
        
            ' Setup the sorting events.
          
            ' Setup the button events.
              
        
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(CarrierAdContactsRecord)), CarrierAdContactsRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, CarrierAdContactsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As CarrierAdContactsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(CarrierAdContactsRecord)), CarrierAdContactsRecord())
                Else  ' Get the records from the database	
                        Me.DataSource = CarrierAdContactsTable.GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      
        
          ' Bind the repeater with the list of records to expand the UI.
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CarrierAdContactsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()

          Dim index As Integer = 0
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          ' Loop through all rows in the table, set its DataSource and call DataBind().
          Dim recControl As CarrierAdContactsTableControlRow = DirectCast(repItem.FindControl("CarrierAdContactsTableControlRow"), CarrierAdContactsTableControlRow)
          recControl.DataSource = Me.DataSource(index)
          If Me.UIData.Count > index Then
          recControl.PreviousUIData = Me.UIData(index)
          End If
          recControl.DataBind()
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
          index += 1
          Next
        
    
           
                
            ' Call the Set methods for each controls on the panel
        
                
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(CarrierAdContactsTable.AdID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(CarrierAdContactsTable.ContactTypeID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(CarrierAdContactsTable.PartyID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
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
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

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




        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.CarrierAdContactsPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.CarrierAdContactsPagination.CurrentPage.Text = "0"
            End If
            Me.CarrierAdContactsPagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for CarrierAdContactsTableControl pagination.
        
            Me.CarrierAdContactsPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.CarrierAdContactsPagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.CarrierAdContactsPagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.CarrierAdContactsPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.CarrierAdContactsPagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.CarrierAdContactsPagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.CarrierAdContactsPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.CarrierAdContactsPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As CarrierAdContactsTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
        
            Return jFilter

        End Function

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            CarrierAdContactsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim roleRecordObj as KeyValue
        roleRecordObj = Nothing
      
              Dim roleTableControlObjRow As RoleTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow") ,RoleTableControlRow)
            
                If (Not IsNothing(roleTableControlObjRow) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord()) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord().RoleID))
                    wc.iAND(CarrierAdContactsTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, roleTableControlObjRow.GetRecord().RoleID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("CarrierAdContactsTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CarrierAdContactsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersAgreementTableControl As Boolean = False
        
          Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
        
          Dim hasFiltersDocTreeTableControl As Boolean = False
        
          Dim hasFiltersRoleTableControl As Boolean = False
        
      ' Compose the WHERE clause consiting of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInRoleTableControl as String = DirectCast(HttpContext.Current.Session("CarrierAdContactsTableControlWhereClause"), String)
            
            If Not selectedRecordInRoleTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInRoleTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInRoleTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(CarrierAdContactsTable.RoleID) Then
            wc.iAND(CarrierAdContactsTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(CarrierAdContactsTable.RoleID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
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
                        if index = Len(resultItem) Then   'Make decision to append "..."
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
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.CarrierAdContactsPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.CarrierAdContactsPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CarrierAdContactsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As CarrierAdContactsTableControlRow = DirectCast(repItem.FindControl("CarrierAdContactsTableControlRow"), CarrierAdContactsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As CarrierAdContactsRecord = New CarrierAdContactsRecord()
        
                        If recControl.AdID.Text <> "" Then
                            rec.Parse(recControl.AdID.Text, CarrierAdContactsTable.AdID)
                        End If
                        If recControl.ContactTypeID.Text <> "" Then
                            rec.Parse(recControl.ContactTypeID.Text, CarrierAdContactsTable.ContactTypeID)
                        End If
                        If recControl.PartyID.Text <> "" Then
                            rec.Parse(recControl.PartyID.Text, CarrierAdContactsTable.PartyID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New CarrierAdContactsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(CarrierAdContactsRecord)), CarrierAdContactsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As CarrierAdContactsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As CarrierAdContactsTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
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
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
        
            
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
        


    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("CarrierAdContactsTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            End If
            
    Dim pageIndex As String = CType(ViewState("Page_Index"), String)
    If pageIndex IsNot Nothing Then
    Me.PageIndex = CInt(pageIndex)
    End If

    Dim pageSize As String = CType(ViewState("Page_Size"), String)
    If Not pageSize Is Nothing Then
    Me.PageSize = CInt(pageSize)
    End If

    
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("CarrierAdContactsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub CarrierAdContactsPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub CarrierAdContactsPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub CarrierAdContactsPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub CarrierAdContactsPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.CarrierAdContactsPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.CarrierAdContactsPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub CarrierAdContactsPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Protected _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Protected _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = CarrierAdContactsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As CarrierAdContactsRecord = Nothing
        Public Property DataSource() As CarrierAdContactsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As CarrierAdContactsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property CarrierAdContactsPagination() As FASTPORT.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CarrierAdContactsPagination"), FASTPORT.UI.IPaginationModern)
          End Get
          End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As CarrierAdContactsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
                End If
                Dim rec As CarrierAdContactsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As CarrierAdContactsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As CarrierAdContactsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(CarrierAdContactsTableControlRow)), CarrierAdContactsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As CarrierAdContactsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
            End If
            
            Dim recCtl As CarrierAdContactsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As CarrierAdContactsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("CarrierAdContactsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
            
                Dim recControl As CarrierAdContactsTableControlRow = DirectCast(repItem.FindControl("CarrierAdContactsTableControlRow"), CarrierAdContactsTableControlRow)
                recList.Add(recControl)
              
            Next

            Return DirectCast(recList.ToArray(GetType(CarrierAdContactsTableControlRow)), CarrierAdContactsTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the DocTreeTableControlRow control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in DocTreeTableControlRow.
Public Class BaseDocTreeTableControlRow
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in DocTreeTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
          
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in DocTreeTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)
                    
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DocTree record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = DocTreeTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseDocTreeTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New DocTreeRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in DocTreeTableControlRow.
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
        
                SetAlwaysShow()
                SetAlwaysShowLabel()
                SetCIX1()
                SetCIXLabel1()
                SetCreatedAt1()
                SetCreatedAtLabel1()
                SetCreatedByID1()
                SetCreatedByIDLabel1()
                SetDocDescription()
                SetDocDescriptionLabel()
                SetDocIndex1()
                SetDocIndexLabel1()
                SetDocName()
                SetDocNameLabel()
                SetDocSort1()
                SetDocSortLabel1()
                SetDocTreeParentID1()
                SetDocTreeParentIDLabel1()
                SetDocTypeID()
                SetDocTypeIDLabel()
                SetFolder()
                SetFolderLabel()
                SetHide1()
                SetHideLabel1()
                SetItemRank()
                SetItemRankLabel()
                SetOnApp()
                SetOnAppLabel()
                SetOneActiveCopy()
                SetOneActiveCopyLabel()
                SetPrivateFolder()
                SetPrivateFolderLabel()
                SetRecordDocDetails()
                SetRecordDocDetailsLabel()
                SetUpdatedAt1()
                SetUpdatedAtLabel1()
                SetUpdatedByID1()
                SetUpdatedByIDLabel1()
      
      
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
        
        
        Public Overridable Sub SetAlwaysShow()
            
        
            ' Set the AlwaysShow Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.AlwaysShow is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAlwaysShow()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AlwaysShowSpecified Then
                				
                ' If the AlwaysShow is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.AlwaysShow)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AlwaysShow.Text = formattedValue
                
            Else 
            
                ' AlwaysShow is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.AlwaysShow.Text = DocTreeTable.AlwaysShow.Format(DocTreeTable.AlwaysShow.DefaultValue)
                        		
                End If
                 
            ' If the AlwaysShow is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AlwaysShow.Text Is Nothing _
                OrElse Me.AlwaysShow.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AlwaysShow.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCIX1()
            
        
            ' Set the CIX Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.CIX1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCIX1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CIXSpecified Then
                				
                ' If the CIX is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.CIX)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CIX1.Text = formattedValue
                
            Else 
            
                ' CIX is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CIX1.Text = DocTreeTable.CIX.Format(DocTreeTable.CIX.DefaultValue)
                        		
                End If
                 
            ' If the CIX is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CIX1.Text Is Nothing _
                OrElse Me.CIX1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CIX1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCreatedAt1()
            
        
            ' Set the CreatedAt Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.CreatedAt1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCreatedAt1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CreatedAtSpecified Then
                				
                ' If the CreatedAt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.CreatedAt, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CreatedAt1.Text = formattedValue
                
            Else 
            
                ' CreatedAt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CreatedAt1.Text = DocTreeTable.CreatedAt.Format(DocTreeTable.CreatedAt.DefaultValue, "g")
                        		
                End If
                 
            ' If the CreatedAt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CreatedAt1.Text Is Nothing _
                OrElse Me.CreatedAt1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CreatedAt1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetCreatedByID1()
            
        
            ' Set the CreatedByID Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.CreatedByID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCreatedByID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CreatedByIDSpecified Then
                				
                ' If the CreatedByID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.CreatedByID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CreatedByID1.Text = formattedValue
                
            Else 
            
                ' CreatedByID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.CreatedByID1.Text = DocTreeTable.CreatedByID.Format(DocTreeTable.CreatedByID.DefaultValue)
                        		
                End If
                 
            ' If the CreatedByID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CreatedByID1.Text Is Nothing _
                OrElse Me.CreatedByID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CreatedByID1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocDescription()
            
        
            ' Set the DocDescription Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocDescription is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocDescription()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocDescriptionSpecified Then
                				
                ' If the DocDescription is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.DocDescription)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocDescription.Text = formattedValue
                
            Else 
            
                ' DocDescription is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocDescription.Text = DocTreeTable.DocDescription.Format(DocTreeTable.DocDescription.DefaultValue)
                        		
                End If
                 
            ' If the DocDescription is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocDescription.Text Is Nothing _
                OrElse Me.DocDescription.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocDescription.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocIndex1()
            
        
            ' Set the DocIndex Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocIndex1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocIndex1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocIndexSpecified Then
                				
                ' If the DocIndex is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.DocIndex)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocIndex1.Text = formattedValue
                
            Else 
            
                ' DocIndex is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocIndex1.Text = DocTreeTable.DocIndex.Format(DocTreeTable.DocIndex.DefaultValue)
                        		
                End If
                 
            ' If the DocIndex is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocIndex1.Text Is Nothing _
                OrElse Me.DocIndex1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocIndex1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocName()
            
        
            ' Set the DocName Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocName is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocNameSpecified Then
                				
                ' If the DocName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.DocName)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocName.Text = formattedValue
                
            Else 
            
                ' DocName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocName.Text = DocTreeTable.DocName.Format(DocTreeTable.DocName.DefaultValue)
                        		
                End If
                 
            ' If the DocName is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocName.Text Is Nothing _
                OrElse Me.DocName.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocName.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocSort1()
            
        
            ' Set the DocSort Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocSort1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocSort1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocSortSpecified Then
                				
                ' If the DocSort is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.DocSort)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocSort1.Text = formattedValue
                
            Else 
            
                ' DocSort is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocSort1.Text = DocTreeTable.DocSort.Format(DocTreeTable.DocSort.DefaultValue)
                        		
                End If
                 
            ' If the DocSort is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocSort1.Text Is Nothing _
                OrElse Me.DocSort1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocSort1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocTreeParentID1()
            
        
            ' Set the DocTreeParentID Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocTreeParentID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocTreeParentID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocTreeParentIDSpecified Then
                				
                ' If the DocTreeParentID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = DocTreeTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(DocTreeTable.DocTreeParentID)
                                  If _isExpandableNonCompositeForeignKey AndAlso DocTreeTable.DocTreeParentID.IsApplyDisplayAs Then
                                  
                                      formattedValue = DocTreeTable.GetDFKA(Me.DataSource.DocTreeParentID.ToString(),DocTreeTable.DocTreeParentID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(DocTreeTable.DocTreeParentID)
                                End If
                                Else
                                formattedValue = Me.DataSource.DocTreeParentID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocTreeParentID1.Text = formattedValue
                
            Else 
            
                ' DocTreeParentID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocTreeParentID1.Text = DocTreeTable.DocTreeParentID.Format(DocTreeTable.DocTreeParentID.DefaultValue)
                        		
                End If
                 
            ' If the DocTreeParentID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocTreeParentID1.Text Is Nothing _
                OrElse Me.DocTreeParentID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocTreeParentID1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetDocTypeID()
            
        
            ' Set the DocTypeID Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.DocTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDocTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DocTypeIDSpecified Then
                				
                ' If the DocTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = DocTreeTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(DocTreeTable.DocTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso DocTreeTable.DocTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = DocTreeTable.GetDFKA(Me.DataSource.DocTypeID.ToString(),DocTreeTable.DocTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(DocTreeTable.DocTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.DocTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DocTypeID.Text = formattedValue
                
            Else 
            
                ' DocTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DocTypeID.Text = DocTreeTable.DocTypeID.Format(DocTreeTable.DocTypeID.DefaultValue)
                        		
                End If
                 
            ' If the DocTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DocTypeID.Text Is Nothing _
                OrElse Me.DocTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DocTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetFolder()
            
        
            ' Set the Folder Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.Folder is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFolder()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FolderSpecified Then
                				
                ' If the Folder is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.Folder)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Folder.Text = formattedValue
                
            Else 
            
                ' Folder is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Folder.Text = DocTreeTable.Folder.Format(DocTreeTable.Folder.DefaultValue)
                        		
                End If
                 
            ' If the Folder is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Folder.Text Is Nothing _
                OrElse Me.Folder.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Folder.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetHide1()
            
        
            ' Set the Hide Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.Hide1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHide1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HideSpecified Then
                				
                ' If the Hide is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.Hide)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Hide1.Text = formattedValue
                
            Else 
            
                ' Hide is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Hide1.Text = DocTreeTable.Hide.Format(DocTreeTable.Hide.DefaultValue)
                        		
                End If
                 
            ' If the Hide is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Hide1.Text Is Nothing _
                OrElse Me.Hide1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Hide1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetItemRank()
            
        
            ' Set the ItemRank Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.ItemRank is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetItemRank()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ItemRankSpecified Then
                				
                ' If the ItemRank is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.ItemRank)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ItemRank.Text = formattedValue
                
            Else 
            
                ' ItemRank is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ItemRank.Text = DocTreeTable.ItemRank.Format(DocTreeTable.ItemRank.DefaultValue)
                        		
                End If
                 
            ' If the ItemRank is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ItemRank.Text Is Nothing _
                OrElse Me.ItemRank.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ItemRank.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetOnApp()
            
        
            ' Set the OnApp Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.OnApp is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetOnApp()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.OnAppSpecified Then
                				
                ' If the OnApp is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.OnApp)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.OnApp.Text = formattedValue
                
            Else 
            
                ' OnApp is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.OnApp.Text = DocTreeTable.OnApp.Format(DocTreeTable.OnApp.DefaultValue)
                        		
                End If
                 
            ' If the OnApp is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.OnApp.Text Is Nothing _
                OrElse Me.OnApp.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.OnApp.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetOneActiveCopy()
            
        
            ' Set the OneActiveCopy Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.OneActiveCopy is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetOneActiveCopy()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.OneActiveCopySpecified Then
                				
                ' If the OneActiveCopy is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.OneActiveCopy)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.OneActiveCopy.Text = formattedValue
                
            Else 
            
                ' OneActiveCopy is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.OneActiveCopy.Text = DocTreeTable.OneActiveCopy.Format(DocTreeTable.OneActiveCopy.DefaultValue)
                        		
                End If
                 
            ' If the OneActiveCopy is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.OneActiveCopy.Text Is Nothing _
                OrElse Me.OneActiveCopy.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.OneActiveCopy.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetPrivateFolder()
            
        
            ' Set the PrivateFolder Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.PrivateFolder is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPrivateFolder()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PrivateFolderSpecified Then
                				
                ' If the PrivateFolder is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.PrivateFolder)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PrivateFolder.Text = formattedValue
                
            Else 
            
                ' PrivateFolder is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.PrivateFolder.Text = DocTreeTable.PrivateFolder.Format(DocTreeTable.PrivateFolder.DefaultValue)
                        		
                End If
                 
            ' If the PrivateFolder is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PrivateFolder.Text Is Nothing _
                OrElse Me.PrivateFolder.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PrivateFolder.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRecordDocDetails()
            
        
            ' Set the RecordDocDetails Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.RecordDocDetails is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRecordDocDetails()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RecordDocDetailsSpecified Then
                				
                ' If the RecordDocDetails is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.RecordDocDetails)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RecordDocDetails.Text = formattedValue
                
            Else 
            
                ' RecordDocDetails is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RecordDocDetails.Text = DocTreeTable.RecordDocDetails.Format(DocTreeTable.RecordDocDetails.DefaultValue)
                        		
                End If
                 
            ' If the RecordDocDetails is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RecordDocDetails.Text Is Nothing _
                OrElse Me.RecordDocDetails.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RecordDocDetails.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetUpdatedAt1()
            
        
            ' Set the UpdatedAt Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.UpdatedAt1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUpdatedAt1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UpdatedAtSpecified Then
                				
                ' If the UpdatedAt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.UpdatedAt, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UpdatedAt1.Text = formattedValue
                
            Else 
            
                ' UpdatedAt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.UpdatedAt1.Text = DocTreeTable.UpdatedAt.Format(DocTreeTable.UpdatedAt.DefaultValue, "g")
                        		
                End If
                 
            ' If the UpdatedAt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UpdatedAt1.Text Is Nothing _
                OrElse Me.UpdatedAt1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UpdatedAt1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetUpdatedByID1()
            
        
            ' Set the UpdatedByID Literal on the webpage with value from the
            ' DocTree database record.

            ' Me.DataSource is the DocTree record retrieved from the database.
            ' Me.UpdatedByID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUpdatedByID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UpdatedByIDSpecified Then
                				
                ' If the UpdatedByID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(DocTreeTable.UpdatedByID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UpdatedByID1.Text = formattedValue
                
            Else 
            
                ' UpdatedByID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.UpdatedByID1.Text = DocTreeTable.UpdatedByID.Format(DocTreeTable.UpdatedByID.DefaultValue)
                        		
                End If
                 
            ' If the UpdatedByID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UpdatedByID1.Text Is Nothing _
                OrElse Me.UpdatedByID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UpdatedByID1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetAlwaysShowLabel()
                  
                  End Sub
                
        Public Overridable Sub SetCIXLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetCreatedAtLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetCreatedByIDLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetDocDescriptionLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocIndexLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetDocNameLabel()
                  
                  End Sub
                
        Public Overridable Sub SetDocSortLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetDocTreeParentIDLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetDocTypeIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetFolderLabel()
                  
                  End Sub
                
        Public Overridable Sub SetHideLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetItemRankLabel()
                  
                  End Sub
                
        Public Overridable Sub SetOnAppLabel()
                  
                  End Sub
                
        Public Overridable Sub SetOneActiveCopyLabel()
                  
                  End Sub
                
        Public Overridable Sub SetPrivateFolderLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRecordDocDetailsLabel()
                  
                  End Sub
                
        Public Overridable Sub SetUpdatedAtLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetUpdatedByIDLabel1()
                  
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

      
        
        ' To customize, override this method in DocTreeTableControlRow.
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
        
        Dim parentCtrl As RoleTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow"), RoleTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "FASTPORT"))
            End If
            
            Me.DataSource.RoleID = parentCtrl.DataSource.RoleID
              
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
              
                DirectCast(GetParentControlObject(Me, "DocTreeTableControl"), DocTreeTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "DocTreeTableControl"), DocTreeTableControl).ResetData = True
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

        ' To customize, override this method in DocTreeTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAlwaysShow()
            GetCIX1()
            GetCreatedAt1()
            GetCreatedByID1()
            GetDocDescription()
            GetDocIndex1()
            GetDocName()
            GetDocSort1()
            GetDocTreeParentID1()
            GetDocTypeID()
            GetFolder()
            GetHide1()
            GetItemRank()
            GetOnApp()
            GetOneActiveCopy()
            GetPrivateFolder()
            GetRecordDocDetails()
            GetUpdatedAt1()
            GetUpdatedByID1()
        End Sub
        
        
        Public Overridable Sub GetAlwaysShow()
            
        End Sub
                
        Public Overridable Sub GetCIX1()
            
        End Sub
                
        Public Overridable Sub GetCreatedAt1()
            
        End Sub
                
        Public Overridable Sub GetCreatedByID1()
            
        End Sub
                
        Public Overridable Sub GetDocDescription()
            
        End Sub
                
        Public Overridable Sub GetDocIndex1()
            
        End Sub
                
        Public Overridable Sub GetDocName()
            
        End Sub
                
        Public Overridable Sub GetDocSort1()
            
        End Sub
                
        Public Overridable Sub GetDocTreeParentID1()
            
        End Sub
                
        Public Overridable Sub GetDocTypeID()
            
        End Sub
                
        Public Overridable Sub GetFolder()
            
        End Sub
                
        Public Overridable Sub GetHide1()
            
        End Sub
                
        Public Overridable Sub GetItemRank()
            
        End Sub
                
        Public Overridable Sub GetOnApp()
            
        End Sub
                
        Public Overridable Sub GetOneActiveCopy()
            
        End Sub
                
        Public Overridable Sub GetPrivateFolder()
            
        End Sub
                
        Public Overridable Sub GetRecordDocDetails()
            
        End Sub
                
        Public Overridable Sub GetUpdatedAt1()
            
        End Sub
                
        Public Overridable Sub GetUpdatedByID1()
            
        End Sub
                
      
        ' To customize, override this method in DocTreeTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in DocTreeTableControlRow.
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
          DocTreeTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "DocTreeTableControl"), DocTreeTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "DocTreeTableControl"), DocTreeTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseDocTreeTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseDocTreeTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As DocTreeRecord
        Public Property DataSource() As DocTreeRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As DocTreeRecord)
            
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
        
        Public ReadOnly Property AlwaysShow() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AlwaysShow"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AlwaysShowLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AlwaysShowLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CIX1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CIX1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CIXLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CIXLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CreatedAt1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedAt1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CreatedAtLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedAtLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CreatedByID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedByID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CreatedByIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CreatedByIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocDescription() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocDescription"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocDescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocDescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocIndex1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocIndex1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocIndexLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocIndexLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocName() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocName"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocNameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocNameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocSort1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocSort1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocSortLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocSortLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocTreeParentID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeParentID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocTreeParentIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeParentIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DocTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DocTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Folder() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Folder"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FolderLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FolderLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Hide1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Hide1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HideLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HideLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ItemRank() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemRank"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ItemRankLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemRankLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property OnApp() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OnApp"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property OnAppLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OnAppLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property OneActiveCopy() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OneActiveCopy"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property OneActiveCopyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "OneActiveCopyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PrivateFolder() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PrivateFolder"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PrivateFolderLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PrivateFolderLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RecordDocDetails() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecordDocDetails"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RecordDocDetailsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RecordDocDetailsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UpdatedAt1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedAt1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UpdatedAtLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedAtLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UpdatedByID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedByID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UpdatedByIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UpdatedByIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As DocTreeRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As DocTreeRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return DocTreeTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the DocTreeTableControl control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in DocTreeTableControl.
Public Class BaseDocTreeTableControl
        Inherits FASTPORT.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
                  
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            
    End If

    
    
            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            
        
            
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.DocTreePagination.FirstPage.Click, AddressOf DocTreePagination_FirstPage_Click
              
              AddHandler Me.DocTreePagination.LastPage.Click, AddressOf DocTreePagination_LastPage_Click
              
              AddHandler Me.DocTreePagination.NextPage.Click, AddressOf DocTreePagination_NextPage_Click
              
              AddHandler Me.DocTreePagination.PageSizeButton.Click, AddressOf DocTreePagination_PageSizeButton_Click
            
              AddHandler Me.DocTreePagination.PreviousPage.Click, AddressOf DocTreePagination_PreviousPage_Click
                          
        
            ' Setup the sorting events.
          
            ' Setup the button events.
              
        
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(DocTreeRecord)), DocTreeRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, DocTreeTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As DocTreeTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(DocTreeRecord)), DocTreeRecord())
                Else  ' Get the records from the database	
                        Me.DataSource = DocTreeTable.GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      
        
          ' Bind the repeater with the list of records to expand the UI.
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()

          Dim index As Integer = 0
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          ' Loop through all rows in the table, set its DataSource and call DataBind().
          Dim recControl As DocTreeTableControlRow = DirectCast(repItem.FindControl("DocTreeTableControlRow"), DocTreeTableControlRow)
          recControl.DataSource = Me.DataSource(index)
          If Me.UIData.Count > index Then
          recControl.PreviousUIData = Me.UIData(index)
          End If
          recControl.DataBind()
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
          index += 1
          Next
        
    
           
                
            ' Call the Set methods for each controls on the panel
        
                
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(DocTreeTable.DocTreeParentID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(DocTreeTable.DocTypeID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
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
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

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




        Public Overridable Sub ResetControl()
                    
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.DocTreePagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.DocTreePagination.CurrentPage.Text = "0"
            End If
            Me.DocTreePagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for DocTreeTableControl pagination.
        
            Me.DocTreePagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.DocTreePagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.DocTreePagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.DocTreePagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.DocTreePagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.DocTreePagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.DocTreePagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.DocTreePagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As DocTreeTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
        
            Return jFilter

        End Function

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            DocTreeTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim roleRecordObj as KeyValue
        roleRecordObj = Nothing
      
              Dim roleTableControlObjRow As RoleTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControlRow") ,RoleTableControlRow)
            
                If (Not IsNothing(roleTableControlObjRow) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord()) AndAlso Not IsNothing(roleTableControlObjRow.GetRecord().RoleID))
                    wc.iAND(DocTreeTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, roleTableControlObjRow.GetRecord().RoleID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("DocTreeTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            DocTreeTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersAgreementTableControl As Boolean = False
        
          Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
        
          Dim hasFiltersDocTreeTableControl As Boolean = False
        
          Dim hasFiltersRoleTableControl As Boolean = False
        
      ' Compose the WHERE clause consiting of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInRoleTableControl as String = DirectCast(HttpContext.Current.Session("DocTreeTableControlWhereClause"), String)
            
            If Not selectedRecordInRoleTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInRoleTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInRoleTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(DocTreeTable.RoleID) Then
            wc.iAND(DocTreeTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(DocTreeTable.RoleID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
            Return wc
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
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
                        if index = Len(resultItem) Then   'Make decision to append "..."
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
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.DocTreePagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.DocTreePagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As DocTreeTableControlRow = DirectCast(repItem.FindControl("DocTreeTableControlRow"), DocTreeTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As DocTreeRecord = New DocTreeRecord()
        
                        If recControl.AlwaysShow.Text <> "" Then
                            rec.Parse(recControl.AlwaysShow.Text, DocTreeTable.AlwaysShow)
                        End If
                        If recControl.CIX1.Text <> "" Then
                            rec.Parse(recControl.CIX1.Text, DocTreeTable.CIX)
                        End If
                        If recControl.CreatedAt1.Text <> "" Then
                            rec.Parse(recControl.CreatedAt1.Text, DocTreeTable.CreatedAt)
                        End If
                        If recControl.CreatedByID1.Text <> "" Then
                            rec.Parse(recControl.CreatedByID1.Text, DocTreeTable.CreatedByID)
                        End If
                        If recControl.DocDescription.Text <> "" Then
                            rec.Parse(recControl.DocDescription.Text, DocTreeTable.DocDescription)
                        End If
                        If recControl.DocIndex1.Text <> "" Then
                            rec.Parse(recControl.DocIndex1.Text, DocTreeTable.DocIndex)
                        End If
                        If recControl.DocName.Text <> "" Then
                            rec.Parse(recControl.DocName.Text, DocTreeTable.DocName)
                        End If
                        If recControl.DocSort1.Text <> "" Then
                            rec.Parse(recControl.DocSort1.Text, DocTreeTable.DocSort)
                        End If
                        If recControl.DocTreeParentID1.Text <> "" Then
                            rec.Parse(recControl.DocTreeParentID1.Text, DocTreeTable.DocTreeParentID)
                        End If
                        If recControl.DocTypeID.Text <> "" Then
                            rec.Parse(recControl.DocTypeID.Text, DocTreeTable.DocTypeID)
                        End If
                        If recControl.Folder.Text <> "" Then
                            rec.Parse(recControl.Folder.Text, DocTreeTable.Folder)
                        End If
                        If recControl.Hide1.Text <> "" Then
                            rec.Parse(recControl.Hide1.Text, DocTreeTable.Hide)
                        End If
                        If recControl.ItemRank.Text <> "" Then
                            rec.Parse(recControl.ItemRank.Text, DocTreeTable.ItemRank)
                        End If
                        If recControl.OnApp.Text <> "" Then
                            rec.Parse(recControl.OnApp.Text, DocTreeTable.OnApp)
                        End If
                        If recControl.OneActiveCopy.Text <> "" Then
                            rec.Parse(recControl.OneActiveCopy.Text, DocTreeTable.OneActiveCopy)
                        End If
                        If recControl.PrivateFolder.Text <> "" Then
                            rec.Parse(recControl.PrivateFolder.Text, DocTreeTable.PrivateFolder)
                        End If
                        If recControl.RecordDocDetails.Text <> "" Then
                            rec.Parse(recControl.RecordDocDetails.Text, DocTreeTable.RecordDocDetails)
                        End If
                        If recControl.UpdatedAt1.Text <> "" Then
                            rec.Parse(recControl.UpdatedAt1.Text, DocTreeTable.UpdatedAt)
                        End If
                        If recControl.UpdatedByID1.Text <> "" Then
                            rec.Parse(recControl.UpdatedByID1.Text, DocTreeTable.UpdatedByID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New DocTreeRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(DocTreeRecord)), DocTreeRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As DocTreeTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As DocTreeTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
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
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
        
            
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
        


    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("DocTreeTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            End If
            
    Dim pageIndex As String = CType(ViewState("Page_Index"), String)
    If pageIndex IsNot Nothing Then
    Me.PageIndex = CInt(pageIndex)
    End If

    Dim pageSize As String = CType(ViewState("Page_Size"), String)
    If Not pageSize Is Nothing Then
    Me.PageSize = CInt(pageSize)
    End If

    
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("DocTreeTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub DocTreePagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DocTreePagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DocTreePagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub DocTreePagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.DocTreePagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.DocTreePagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub DocTreePagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Protected _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Protected _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = DocTreeTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As DocTreeRecord = Nothing
        Public Property DataSource() As DocTreeRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As DocTreeRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property DocTreePagination() As FASTPORT.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreePagination"), FASTPORT.UI.IPaginationModern)
          End Get
          End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As DocTreeTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
                End If
                Dim rec As DocTreeRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As DocTreeTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As DocTreeTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(DocTreeTableControlRow)), DocTreeTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As DocTreeTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
            End If
            
            Dim recCtl As DocTreeTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As DocTreeTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("DocTreeTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
            
                Dim recControl As DocTreeTableControlRow = DirectCast(repItem.FindControl("DocTreeTableControlRow"), DocTreeTableControlRow)
                recList.Add(recControl)
              
            Next

            Return DirectCast(recList.ToArray(GetType(DocTreeTableControlRow)), DocTreeTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the RoleTableControlRow control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in RoleTableControlRow.
Public Class BaseRoleTableControlRow
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in RoleTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
          
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in RoleTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)
        
              ' Show confirmation message on Click
              Me.RoleRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "FASTPORT") & "'));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.RoleRowDeleteButton.Click, AddressOf RoleRowDeleteButton_Click
              
              AddHandler Me.RoleRowEditButton.Click, AddressOf RoleRowEditButton_Click
              
              AddHandler Me.RoleRowExpandCollapseRowButton.Click, AddressOf RoleRowExpandCollapseRowButton_Click
              
              AddHandler Me.GeneralRoleID.Click, AddressOf GeneralRoleID_Click
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource Role record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = RoleTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseRoleTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New RoleRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in RoleTableControlRow.
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
        
                
                
                
                
                
                
                SetGeneralRoleID()
                SetGeneralRoleIDLabel()
                SetRole()
                SetRoleDescription()
                SetRoleDescriptionLabel()
                SetRoleLabel()
                SetRoleRank()
                SetRoleRankLabel()
                
                
                
                
                SetRoleTypeID()
                SetRoleTypeIDLabel()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        Dim recAgreementTableControl as AgreementTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "AgreementTableControl"), AgreementTableControl)
          
        recAgreementTableControl.LoadData()
        recAgreementTableControl.DataBind()
        
        Dim recCarrierAdContactsTableControl as CarrierAdContactsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl)
          
        recCarrierAdContactsTableControl.LoadData()
        recCarrierAdContactsTableControl.DataBind()
        
        Dim recDocTreeTableControl as DocTreeTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "DocTreeTableControl"), DocTreeTableControl)
          
        recDocTreeTableControl.LoadData()
        recDocTreeTableControl.DataBind()
              
        End Sub
        
        
        Public Overridable Sub SetGeneralRoleID()
            
        
            ' Set the GeneralRoleID LinkButton on the webpage with value from the
            ' Role database record.

            ' Me.DataSource is the Role record retrieved from the database.
            ' Me.GeneralRoleID is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetGeneralRoleID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.GeneralRoleIDSpecified Then
                				
                ' If the GeneralRoleID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.GeneralRoleID)
                                  If _isExpandableNonCompositeForeignKey AndAlso RoleTable.GeneralRoleID.IsApplyDisplayAs Then
                                  
                                      formattedValue = RoleTable.GetDFKA(Me.DataSource.GeneralRoleID.ToString(),RoleTable.GeneralRoleID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(RoleTable.GeneralRoleID)
                                End If
                                Else
                                formattedValue = Me.DataSource.GeneralRoleID.ToString()
                                  End If
                                
                Me.GeneralRoleID.Text = formattedValue
                
                Me.GeneralRoleID.ToolTip = "Go to " & Me.GeneralRoleID.Text.Replace("<wbr/>", "")
                
            Else 
            
                ' GeneralRoleID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.GeneralRoleID.Text = RoleTable.GeneralRoleID.Format(RoleTable.GeneralRoleID.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetRole()
            
        
            ' Set the Role Literal on the webpage with value from the
            ' Role database record.

            ' Me.DataSource is the Role record retrieved from the database.
            ' Me.Role is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRole()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RoleSpecified Then
                				
                ' If the Role is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(RoleTable.Role)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Role.Text = formattedValue
                
            Else 
            
                ' Role is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Role.Text = RoleTable.Role.Format(RoleTable.Role.DefaultValue)
                        		
                End If
                 
            ' If the Role is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Role.Text Is Nothing _
                OrElse Me.Role.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Role.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRoleDescription()
            
        
            ' Set the RoleDescription Literal on the webpage with value from the
            ' Role database record.

            ' Me.DataSource is the Role record retrieved from the database.
            ' Me.RoleDescription is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRoleDescription()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RoleDescriptionSpecified Then
                				
                ' If the RoleDescription is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(RoleTable.RoleDescription)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RoleDescription.Text = formattedValue
                
            Else 
            
                ' RoleDescription is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RoleDescription.Text = RoleTable.RoleDescription.Format(RoleTable.RoleDescription.DefaultValue)
                        		
                End If
                 
            ' If the RoleDescription is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RoleDescription.Text Is Nothing _
                OrElse Me.RoleDescription.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RoleDescription.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRoleRank()
            
        
            ' Set the RoleRank Literal on the webpage with value from the
            ' Role database record.

            ' Me.DataSource is the Role record retrieved from the database.
            ' Me.RoleRank is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRoleRank()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RoleRankSpecified Then
                				
                ' If the RoleRank is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(RoleTable.RoleRank)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RoleRank.Text = formattedValue
                
            Else 
            
                ' RoleRank is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RoleRank.Text = RoleTable.RoleRank.Format(RoleTable.RoleRank.DefaultValue)
                        		
                End If
                 
            ' If the RoleRank is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RoleRank.Text Is Nothing _
                OrElse Me.RoleRank.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RoleRank.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetRoleTypeID()
            
        
            ' Set the RoleTypeID Literal on the webpage with value from the
            ' Role database record.

            ' Me.DataSource is the Role record retrieved from the database.
            ' Me.RoleTypeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetRoleTypeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.RoleTypeIDSpecified Then
                				
                ' If the RoleTypeID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                  Dim formattedValue As String = ""
                                  Dim _isExpandableNonCompositeForeignKey As Boolean = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.RoleTypeID)
                                  If _isExpandableNonCompositeForeignKey AndAlso RoleTable.RoleTypeID.IsApplyDisplayAs Then
                                  
                                      formattedValue = RoleTable.GetDFKA(Me.DataSource.RoleTypeID.ToString(),RoleTable.RoleTypeID, Nothing)
                                    
                                  if (formattedValue Is Nothing) Then
                                  formattedValue = Me.DataSource.Format(RoleTable.RoleTypeID)
                                End If
                                Else
                                formattedValue = Me.DataSource.RoleTypeID.ToString()
                                  End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.RoleTypeID.Text = formattedValue
                
            Else 
            
                ' RoleTypeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.RoleTypeID.Text = RoleTable.RoleTypeID.Format(RoleTable.RoleTypeID.DefaultValue)
                        		
                End If
                 
            ' If the RoleTypeID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.RoleTypeID.Text Is Nothing _
                OrElse Me.RoleTypeID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.RoleTypeID.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetGeneralRoleIDLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleDescriptionLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleRankLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleTypeIDLabel()
                  
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

      
        
        ' To customize, override this method in RoleTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "RoleTableControl"), RoleTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "RoleTableControl"), RoleTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recAgreementTableControl as AgreementTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "AgreementTableControl"), AgreementTableControl)
        recAgreementTableControl.SaveData()
        
        Dim recCarrierAdContactsTableControl as CarrierAdContactsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl)
        recCarrierAdContactsTableControl.SaveData()
        
        Dim recDocTreeTableControl as DocTreeTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "DocTreeTableControl"), DocTreeTableControl)
        recDocTreeTableControl.SaveData()
        
        End Sub

        ' To customize, override this method in RoleTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetGeneralRoleID()
            GetRole()
            GetRoleDescription()
            GetRoleRank()
            GetRoleTypeID()
        End Sub
        
        
        Public Overridable Sub GetGeneralRoleID()
            
        End Sub
                
        Public Overridable Sub GetRole()
            
        End Sub
                
        Public Overridable Sub GetRoleDescription()
            
        End Sub
                
        Public Overridable Sub GetRoleRank()
            
        End Sub
                
        Public Overridable Sub GetRoleTypeID()
            
        End Sub
                
      
        ' To customize, override this method in RoleTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in RoleTableControlRow.
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
          RoleTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "RoleTableControl"), RoleTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "RoleTableControl"), RoleTableControl).ResetData = True
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
        
        
        ' event handler for ImageButton
        Public Overridable Sub RoleRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                  Me.Delete()
              
            End If
      Me.Page.CommitTransaction(sender)
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleRowExpandCollapseRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
          Dim panelControl as RoleTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "RoleTableControl"), RoleTableControl)

          Dim repeatedRows() as RoleTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as RoleTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "RoleTableControlAltRow"), System.Web.UI.Control)
              If (altRow IsNot Nothing) Then
                  If (sender Is repeatedRow.RoleRowExpandCollapseRowButton) Then
                      altRow.Visible = Not altRow.Visible
                  
                  End If                      
                  If (altRow.Visible) Then        
                   
                     repeatedRow.RoleRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                                       
                  Else
                   
                     repeatedRow.RoleRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     
                  End If
              Else
                  Me.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx")
              End If
          Next
          
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub GeneralRoleID_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Role/ShowRole.aspx?Role={RoleTableControlRow:FK:FK_Role_Role}"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
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
                Return CType(Me.ViewState("BaseRoleTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseRoleTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As RoleRecord
        Public Property DataSource() As RoleRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As RoleRecord)
            
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
        
        Public ReadOnly Property AgreementTableControl() As AgreementTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AgreementTableControl"), AgreementTableControl)
            End Get
        End Property
        
        Public ReadOnly Property CarrierAdContactsTableControl() As CarrierAdContactsTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CarrierAdContactsTableControl"), CarrierAdContactsTableControl)
            End Get
        End Property
        
        Public ReadOnly Property DocTreeTableControl() As DocTreeTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DocTreeTableControl"), DocTreeTableControl)
            End Get
        End Property
        
        Public ReadOnly Property GeneralRoleID() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GeneralRoleID"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property GeneralRoleIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GeneralRoleIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Role() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Role"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RoleDescription() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleDescription"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RoleDescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleDescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleRank() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRank"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RoleRankLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRankLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleRowExpandCollapseRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRowExpandCollapseRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleTypeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTypeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property RoleTypeIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTypeIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As RoleRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As RoleRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return RoleTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the RoleTableControl control on the GroupByRoleTable page.
' Do not modify this class. Instead override any method in RoleTableControl.
Public Class BaseRoleTableControl
        Inherits FASTPORT.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
                  
           ' Setup the filter and search events.
        
            AddHandler Me.RoleTypeIDFilter.SelectedIndexChanged, AddressOf RoleTypeIDFilter_SelectedIndexChanged
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.RoleSearch) 				
                    initialVal = Me.GetFromSession(Me.RoleSearch)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.RoleSearch.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.RoleTypeIDFilter) 				
                    initialVal = Me.GetFromSession(Me.RoleTypeIDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""RoleTypeID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.RoleTypeIDFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.RoleTypeIDFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            
    End If

    
    
            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            
        
            
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.RolePagination.FirstPage.Click, AddressOf RolePagination_FirstPage_Click
              
              AddHandler Me.RolePagination.LastPage.Click, AddressOf RolePagination_LastPage_Click
              
              AddHandler Me.RolePagination.NextPage.Click, AddressOf RolePagination_NextPage_Click
              
              AddHandler Me.RolePagination.PageSizeButton.Click, AddressOf RolePagination_PageSizeButton_Click
            
              AddHandler Me.RolePagination.PreviousPage.Click, AddressOf RolePagination_PreviousPage_Click
                          
        
            ' Setup the sorting events.
          
              AddHandler Me.GeneralRoleIDSortLabel.Click, AddressOf GeneralRoleIDSortLabel_Click
            
              AddHandler Me.RoleDescriptionSortLabel.Click, AddressOf RoleDescriptionSortLabel_Click
            
              AddHandler Me.RoleRankSortLabel.Click, AddressOf RoleRankSortLabel_Click
            
              AddHandler Me.RoleSortLabel.Click, AddressOf RoleSortLabel_Click
            
              AddHandler Me.RoleTypeIDSortLabel.Click, AddressOf RoleTypeIDSortLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.RoleExportExcelButton.Click, AddressOf RoleExportExcelButton_Click
              							
              Me.RoleImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Role" 
              Me.RoleImportButton.Attributes.Item("onClick") = "window.open('" & Me.Page.EncryptUrlParameter(Me.RoleImportButton.PostBackUrl) & "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;"
                        
              AddHandler Me.RoleImportButton.Click, AddressOf RoleImportButton_Click
              
              AddHandler Me.RoleNewButton.Click, AddressOf RoleNewButton_Click
              
              AddHandler Me.RolePDFButton.Click, AddressOf RolePDFButton_Click
              
              AddHandler Me.RoleResetButton.Click, AddressOf RoleResetButton_Click
              
              AddHandler Me.RoleSearchButton.Click, AddressOf RoleSearchButton_Click
              
              AddHandler Me.RoleWordButton.Click, AddressOf RoleWordButton_Click
              
            AddHandler Me.RoleButtonsButton.Button.Click, AddressOf RoleButtonsButton_Click
        
            AddHandler Me.RoleFilterButton.Button.Click, AddressOf RoleFilterButton_Click
        
            AddHandler Me.RoleFiltersButton.Button.Click, AddressOf RoleFiltersButton_Click
            
        
          ' Setup events for others
            
          Me.RoleSearch.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.RoleSearch.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
          ScriptManager.RegisterStartupScript(Me, Me.GetType(), "SearchBoxTextRoleSearch", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & RoleSearch.ClientID & """);", True)
        
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(RoleRecord)), RoleRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, RoleTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As RoleTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(RoleRecord)), RoleRecord())
                Else  ' Get the records from the database	
                        Me.DataSource = RoleTable.GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      
        
          ' Bind the repeater with the list of records to expand the UI.
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()

          Dim index As Integer = 0
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          ' Loop through all rows in the table, set its DataSource and call DataBind().
          Dim recControl As RoleTableControlRow = DirectCast(repItem.FindControl("RoleTableControlRow"), RoleTableControlRow)
          recControl.DataSource = Me.DataSource(index)
          If Me.UIData.Count > index Then
          recControl.PreviousUIData = Me.UIData(index)
          End If
          recControl.DataBind()
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
          index += 1
          Next
        
    
           
                
            ' Call the Set methods for each controls on the panel
        
                SetGeneralRoleIDSortLabel()
                
                SetRoleDescriptionSortLabel()
                
                
                
                
                
                
                
                SetRoleRankSortLabel()
                
                SetRoleSearch()
                
                SetRoleSortLabel()
                
                
                SetRoleTypeIDFilter()
                SetRoleTypeIDLabel1()
                SetRoleTypeIDSortLabel()
                
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= True
        
            Dim recControls() As RoleTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "RoleTableControlAltRow"), System.Web.UI.Control)
                If (altRow IsNot Nothing) Then
                    If (expandFirstRow AndAlso i = 0) Then                
                        altRow.Visible = True
                   
                        recControls(i).RoleRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                     
                    Else                
                        altRow.Visible = False
                   
                        recControls(i).RoleRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     
                    End If
                End If
            Next
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(RoleTable.GeneralRoleID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(RoleTable.RoleTypeID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"RoleExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"RolePDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"RoleWordButton"))
                        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
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
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

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




        Public Overridable Sub ResetControl()
                    
            Me.RoleTypeIDFilter.ClearSelection()
            
            Me.RoleSearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.RolePagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.RolePagination.CurrentPage.Text = "0"
            End If
            Me.RolePagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for RoleTableControl pagination.
        
            Me.RolePagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.RolePagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.RolePagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.RolePagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.RolePagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.RolePagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.RolePagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.RolePagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As RoleTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
        
            Return jFilter

        End Function

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            RoleTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersAgreementTableControl As Boolean = False
      
        Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
      
        Dim hasFiltersDocTreeTableControl As Boolean = False
      
        Dim hasFiltersRoleTableControl As Boolean = False
      
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.RoleSearch) Then
              If Me.RoleSearch.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.RoleSearch.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.RoleSearch.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.RoleSearch.Text = ""
                Else
              
                    If Me.RoleSearch.Text.StartsWith("...") Then
                        Me.RoleSearch.Text = Me.RoleSearch.Text.SubString(3,Me.RoleSearch.Text.Length-3)
                    End If
                    If Me.RoleSearch.Text.EndsWith("...") then
                        Me.RoleSearch.Text = Me.RoleSearch.Text.SubString(0,Me.RoleSearch.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = RoleSearch.Text.Length - 1
                        While (Not Char.IsWhiteSpace(RoleSearch.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            RoleSearch.Text = RoleSearch.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.RoleSearch, Me.GetFromSession(Me.RoleSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.RoleSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(RoleTable.RoleDescription, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.RoleSearch, Me.GetFromSession(Me.RoleSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            If IsValueSelected(Me.RoleTypeIDFilter) Then
    
              hasFiltersRoleTableControl = True            
    
                wc.iAND(RoleTable.RoleTypeID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.RoleTypeIDFilter, Me.GetFromSession(Me.RoleTypeIDFilter)), False, False)
            
            End If
                  
                
                       
            Dim themeButtonRoleFiltersButton As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "RoleFiltersButton"), IThemeButtonWithArrow)
            If ( IsNothing(themeButtonRoleFiltersButton) ) Then
              	themeButtonRoleFiltersButton = DirectCast(MiscUtils.FindControlRecursively(Me, "_RoleFiltersButton"), IThemeButtonWithArrow)
            End If

            If ( IsNothing(Me.DataSource) AndAlso Not IsNothing(themeButtonRoleFiltersButton) AndAlso Not IsNothing(themeButtonRoleFiltersButton.ArrowImage)) Then
                If (hasFiltersRoleTableControl) Then
                   themeButtonRoleFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
                Else
                   themeButtonRoleFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
                End If
            End If
           
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            RoleTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersAgreementTableControl As Boolean = False
        
          Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
        
          Dim hasFiltersDocTreeTableControl As Boolean = False
        
          Dim hasFiltersRoleTableControl As Boolean = False
        
      ' Compose the WHERE clause consiting of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            If IsValueSelected(searchText) and fromSearchControl = "RoleSearch" Then
                Dim formatedSearchText as String = searchText
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If searchText.StartsWith("...") Then
                    formatedSearchText = searchText.SubString(3,searchText.Length-3)
                End If
                If searchText.EndsWith("...") Then
                    formatedSearchText = searchText.SubString(0,searchText.Length-3)
                    ' Strip the last word as well as it is likely only a partial word
                    Dim endindex As Integer = searchText.Length - 1
                    While (Not Char.IsWhiteSpace(searchText(endindex)) AndAlso endindex > 0)
                        endindex -= 1
                    End While
                    If endindex > 0 Then
                        searchText = searchText.Substring(0, endindex)
                    End If
                End If
                'After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim()
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(formatedSearchText) Then
                      ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    If InvariantLCase(AutoTypeAheadSearch).equals("wordsstartingwithsearchstring") Then
                
                        search.iOR(RoleTable.RoleDescription, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(RoleTable.RoleDescription, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(RoleTable.RoleDescription, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Dim RoleTypeIDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "RoleTypeIDFilter_Ajax"), String)
            If IsValueSelected(RoleTypeIDFilterSelectedValue) Then
    
              hasFiltersRoleTableControl = True            
    
                 wc.iAND(RoleTable.RoleTypeID, BaseFilter.ComparisonOperator.EqualsTo, RoleTypeIDFilterSelectedValue, false, False)
             
             End If
                      
            Dim themeButtonRoleFiltersButton As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "RoleFiltersButton"), IThemeButtonWithArrow)

    
            If ( IsNothing(Me.DataSource) AndAlso Not IsNothing(themeButtonRoleFiltersButton) AndAlso Not IsNothing(themeButtonRoleFiltersButton.ArrowImage)) Then
                If (hasFiltersRoleTableControl) Then
                   themeButtonRoleFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
                Else
                   themeButtonRoleFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
                End If
            End If
    
      
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_RoleSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            Dim wc As WhereClause = CreateWhereClause(prefixText,"RoleSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As FASTPORT.Business.RoleRecord = RoleTable.GetRecords(filterJoin, wc, Nothing, iteration, 100)
                Dim rec As RoleRecord = Nothing
                Dim resultItem As String = ""
                For Each rec In recordList 
                    ' Exit the loop if recordList count has reached AutoTypeAheadListSize.
                    If resultList.Count >= count then
                        Exit For
                    End If
                    ' If the field is configured to Display as Foreign key, Format() method returns the 
                    ' Display as Forien Key value instead of original field value.
                    ' Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                    ' We need to find relevent field to display which matches the prefixText and is not already present in the result list.
                
                    resultItem = rec.Format(RoleTable.RoleDescription)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 80, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                Next
                ' Exit the loop if number of records found is less as further iteration will not return any more records
                If recordList .Length < 100 Then
                    Exit While
                End If
                iteration += 1
            End While
             
            resultList.Sort()
            Dim result() As String = New String(resultList.Count - 1) {}
            Array.Copy(resultList.ToArray, result, resultList.Count)
            Return result
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
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
                        if index = Len(resultItem) Then   'Make decision to append "..."
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
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.RolePagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.RolePagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As RoleTableControlRow = DirectCast(repItem.FindControl("RoleTableControlRow"), RoleTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As RoleRecord = New RoleRecord()
        
                        If recControl.GeneralRoleID.Text <> "" Then
                            rec.Parse(recControl.GeneralRoleID.Text, RoleTable.GeneralRoleID)
                        End If
                        If recControl.Role.Text <> "" Then
                            rec.Parse(recControl.Role.Text, RoleTable.Role)
                        End If
                        If recControl.RoleDescription.Text <> "" Then
                            rec.Parse(recControl.RoleDescription.Text, RoleTable.RoleDescription)
                        End If
                        If recControl.RoleRank.Text <> "" Then
                            rec.Parse(recControl.RoleRank.Text, RoleTable.RoleRank)
                        End If
                        If recControl.RoleTypeID.Text <> "" Then
                            rec.Parse(recControl.RoleTypeID.Text, RoleTable.RoleTypeID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New RoleRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(RoleRecord)), RoleRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As RoleTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As RoleTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetGeneralRoleIDSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleDescriptionSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleRankSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleTypeIDLabel1()
                  
                  End Sub
                
        Public Overridable Sub SetRoleTypeIDSortLabel()
                  
                  End Sub
                
        Public Overridable Sub SetRoleSearch()
            
        End Sub	
            
        Public Overridable Sub SetRoleTypeIDFilter()
            
                Me.PopulateRoleTypeIDFilter(GetSelectedValue(Me.RoleTypeIDFilter,  GetFromSession(Me.RoleTypeIDFilter)), 500)					
                    
        End Sub	
            
        ' Get the filters' data for RoleTypeIDFilter
        Protected Overridable Sub PopulateRoleTypeIDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.RoleTypeIDFilter.Items.Clear()
            
                    
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RoleTypeIDFilter function.
            ' It is better to customize the where clause there.
                	  
                    

            'Setup the WHERE clause.
            Dim wc As WhereClause = Me.CreateWhereClause_RoleTypeIDFilter()
            
            ' Setup the static list items        
            
            ' Add the All item.
            Me.RoleTypeIDFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "FASTPORT"), "--ANY--"))
                            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(TreeTable.ItemName, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "FASTPORT")
            

            Dim itemValues() As TreeRecord = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = TreeTable.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As TreeRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.TreeIDSpecified Then
                            cvalue = itemValue.TreeID.ToString()

                            If counter < maxItems AndAlso Me.RoleTypeIDFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.RoleTypeID)
                                If _isExpandableNonCompositeForeignKey AndAlso RoleTable.RoleTypeID.IsApplyDisplayAs Then
                                    fvalue = RoleTable.GetDFKA(itemValue, RoleTable.RoleTypeID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(TreeTable.ItemName)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.RoleTypeIDFilter.Items.FindByText(fvalue)
								
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.RoleTypeIDFilter.Items.Add(newItem)

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
            


                 

                
            ' Set the selected value.
            SetSelectedValue(Me.RoleTypeIDFilter, selectedValue)

                
        End Sub
            
        Public Overridable Function CreateWhereClause_RoleTypeIDFilter() As WhereClause
          
              Dim hasFiltersAgreementTableControl As Boolean = False
            
              Dim hasFiltersCarrierAdContactsTableControl As Boolean = False
            
              Dim hasFiltersDocTreeTableControl As Boolean = False
            
              Dim hasFiltersRoleTableControl As Boolean = False
            
            ' Create a where clause for the filter RoleTypeIDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the RoleTypeIDFilterDropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
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
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            Me.SaveToSession(Me.RoleSearch, Me.RoleSearch.Text)
                  
            Me.SaveToSession(Me.RoleTypeIDFilter, Me.RoleTypeIDFilter.SelectedValue)
                  
        
            'Save pagination state to session.
        
            
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("RoleSearch_Ajax", Me.RoleSearch.Text)
              
      Me.SaveToSession("RoleTypeIDFilter_Ajax", Me.RoleTypeIDFilter.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.RoleSearch)
            Me.RemoveFromSession(Me.RoleTypeIDFilter)
    
            ' Clear pagination state from session.
        


    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("RoleTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
            End If
            
    Dim pageIndex As String = CType(ViewState("Page_Index"), String)
    If pageIndex IsNot Nothing Then
    Me.PageIndex = CInt(pageIndex)
    End If

    Dim pageSize As String = CType(ViewState("Page_Size"), String)
    If Not pageSize Is Nothing Then
    Me.PageSize = CInt(pageSize)
    End If

    
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("RoleTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub RolePagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RolePagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RolePagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub RolePagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.RolePagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.RolePagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub RolePagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        
        Public Overridable Sub GeneralRoleIDSortLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by GeneralRoleID when clicked.
              
            ' Get previous sorting state for GeneralRoleID.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(RoleTable.GeneralRoleID)
            If sd Is Nothing OrElse (Me.CurrentSortOrder.Items IsNot Nothing Andalso Me.CurrentSortOrder.Items.Length > 1) Then
                ' First time sort, so add sort order for GeneralRoleID.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(RoleTable.GeneralRoleID, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by GeneralRoleID, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub RoleDescriptionSortLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by RoleDescription when clicked.
              
            ' Get previous sorting state for RoleDescription.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(RoleTable.RoleDescription)
            If sd Is Nothing OrElse (Me.CurrentSortOrder.Items IsNot Nothing Andalso Me.CurrentSortOrder.Items.Length > 1) Then
                ' First time sort, so add sort order for RoleDescription.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(RoleTable.RoleDescription, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by RoleDescription, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub RoleRankSortLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by RoleRank when clicked.
              
            ' Get previous sorting state for RoleRank.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(RoleTable.RoleRank)
            If sd Is Nothing OrElse (Me.CurrentSortOrder.Items IsNot Nothing Andalso Me.CurrentSortOrder.Items.Length > 1) Then
                ' First time sort, so add sort order for RoleRank.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(RoleTable.RoleRank, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by RoleRank, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub RoleSortLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by Role when clicked.
              
            ' Get previous sorting state for Role.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(RoleTable.Role)
            If sd Is Nothing OrElse (Me.CurrentSortOrder.Items IsNot Nothing Andalso Me.CurrentSortOrder.Items.Length > 1) Then
                ' First time sort, so add sort order for Role.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(RoleTable.Role, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by Role, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub RoleTypeIDSortLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by RoleTypeID when clicked.
              
            ' Get previous sorting state for RoleTypeID.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(RoleTable.RoleTypeID)
            If sd Is Nothing OrElse (Me.CurrentSortOrder.Items IsNot Nothing Andalso Me.CurrentSortOrder.Items.Length > 1) Then
                ' First time sort, so add sort order for RoleTypeID.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(RoleTable.RoleTypeID, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by RoleTypeID, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub RoleExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            ' To customize the columns or the format, override this function in Section 1 of the page 
            ' and modify it to your liking.
            ' Build the where clause based on the current filter and search criteria
            ' Create the Order By clause based on the user's current sorting preference.
          
              Dim wc As WhereClause = CreateWhereClause
              Dim orderBy As OrderBy = Nothing
              
              orderBy = CreateOrderBy
              
              Dim done As Boolean = False
              Dim val As Object = ""
              ' Read pageSize records at a time and write out the Excel file.
              Dim totalRowsReturned As Integer = 0
          
              Me.TotalRecords = RoleTable.GetRecordCount(wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         RoleTable.GeneralRoleID, _ 
             RoleTable.RoleTypeID, _ 
             RoleTable.Role, _ 
             RoleTable.RoleDescription, _ 
             RoleTable.RoleRank, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(RoleTable.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(RoleTable.Instance, wc, orderBy, columns)

              '  Read pageSize records at a time and write out the CSV file.
              While (Not done)
                  Dim recList As ArrayList = dataForCSV.GetRows(exportData.pageSize)
                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count
                  For Each rec As BaseRecord In recList
                      For Each col As BaseColumn In dataForCSV.ColumnList
                          If col Is Nothing Then
                              Continue For
                          End If

                          If Not dataForCSV.IncludeInExport(col) Then
                              Continue For
                          End If

                          val = rec.GetValue(col).ToString()
                          exportData.WriteColumnData(val, dataForCSV.IsString(col))

                      Next col
                      exportData.WriteNewRow()
                  Next rec

                  '  If we already are below the pageSize, then we are done.
                  If totalRowsReturned < exportData.pageSize Then
                      done = True
                  End If
              End While
              exportData.FinishExport(Me.Page.Response)
          Else
          
              ' Create an instance of the Excel report class with the table class, where clause and order by.
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(RoleTable.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(RoleTable.Instance, wc, orderBy, Nothing)
                       data.ColumnList.Add(New ExcelColumn(RoleTable.GeneralRoleID, "Default"))
             data.ColumnList.Add(New ExcelColumn(RoleTable.RoleTypeID, "Default"))
             data.ColumnList.Add(New ExcelColumn(RoleTable.Role, "Default"))
             data.ColumnList.Add(New ExcelColumn(RoleTable.RoleDescription, "Default"))
             data.ColumnList.Add(New ExcelColumn(RoleTable.RoleRank, "0"))


              For Each col As ExcelColumn In data.ColumnList
                  width = excelReport.GetExcelCellWidth(col)
                  If data.IncludeInExport(col) Then
                      excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col))
                      columnCounter = columnCounter + 1
                  End If
              Next col
              
              While (Not done)
                  Dim recList As ArrayList = data.GetRows(excelReport.pageSize)

                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count

                  For Each rec As BaseRecord In recList
                      excelReport.AddRowToExcelBook()
                      columnCounter = 0

                      For Each col As ExcelColumn In data.ColumnList
                          If Not data.IncludeInExport(col) Then
                              Continue For
                          End If

                          Dim _isExpandableNonCompositeForeignKey As Boolean = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn)
                          If _isExpandableNonCompositeForeignKey AndAlso col.DisplayColumn.IsApplyDisplayAs Then
                              val = RoleTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
                              If val Is Nothing Then
                                  val = rec.Format(col.DisplayColumn)
                              End If
                          Else
                              val = excelReport.GetValueForExcelExport(col, rec)
                          End If
                          excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat)

                          columnCounter = columnCounter + 1
                      Next col
                  Next rec

                  ' If we already are below the pageSize, then we are done.
                  If totalRowsReturned < excelReport.pageSize Then
                      done = True
                  End If
              End While

              excelReport.SaveExcelBook(Me.Page.Response)
          End If
        
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleNewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Role/AddRole.aspx"
                
        Dim shouldRedirect As Boolean = True
        Dim TargetKey As String = Nothing
        Dim DFKA As String = TargetKey
        Dim id As String = DFKA
        Dim value As String = id
      
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RolePDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("GroupByRoleTable.RolePDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Role"
                ' If GroupByRoleTable.RolePDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(RoleTable.GeneralRoleID.Name, ReportEnum.Align.Left, "${GeneralRoleID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleTypeID.Name, ReportEnum.Align.Left, "${RoleTypeID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.Role.Name, ReportEnum.Align.Left, "${Role}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleDescription.Name, ReportEnum.Align.Left, "${RoleDescription}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleRank.Name, ReportEnum.Align.Right, "${RoleRank}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "FASTPORT")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = RoleTable.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = RoleTable.GetColumnList()
                Dim records As RoleRecord() = Nothing
            
                Do 
                    
                    records = RoleTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As RoleRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         If BaseClasses.Utils.MiscUtils.IsNull(record.GeneralRoleID) Then
                                 report.AddData("${GeneralRoleID}", "",ReportEnum.Align.Left)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.GeneralRoleID)
                                 _DFKA = RoleTable.GetDFKA(record.GeneralRoleID.ToString(), RoleTable.GeneralRoleID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  RoleTable.GeneralRoleID.IsApplyDisplayAs Then
                                     report.AddData("${GeneralRoleID}", _DFKA,ReportEnum.Align.Left)
                                 Else 
                                     report.AddData("${GeneralRoleID}", record.Format(RoleTable.GeneralRoleID), ReportEnum.Align.Left)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.RoleTypeID) Then
                                 report.AddData("${RoleTypeID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.RoleTypeID)
                                 _DFKA = RoleTable.GetDFKA(record.RoleTypeID.ToString(), RoleTable.RoleTypeID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  RoleTable.RoleTypeID.IsApplyDisplayAs Then
                                     report.AddData("${RoleTypeID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${RoleTypeID}", record.Format(RoleTable.RoleTypeID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${Role}", record.Format(RoleTable.Role), ReportEnum.Align.Left, 300)
                             report.AddData("${RoleDescription}", record.Format(RoleTable.RoleDescription), ReportEnum.Align.Left, 300)
                             report.AddData("${RoleRank}", record.Format(RoleTable.RoleRank), ReportEnum.Align.Right, 300)

                            report.WriteRow 
                        Next 
                        pageNum = pageNum + 1
                        recordCount += records.Length 
                    End If 
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows  AndAlso whereClause.RunQuery 
                
                report.Close 
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
              Me.RoleTypeIDFilter.ClearSelection()
              Me.RoleSearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, False)
                  

              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleSearchButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
          Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub RoleWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("GroupByRoleTable.RoleWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Role"
                ' If GroupByRoleTable.RoleWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(RoleTable.GeneralRoleID.Name, ReportEnum.Align.Left, "${GeneralRoleID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleTypeID.Name, ReportEnum.Align.Left, "${RoleTypeID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.Role.Name, ReportEnum.Align.Left, "${Role}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleDescription.Name, ReportEnum.Align.Left, "${RoleDescription}", ReportEnum.Align.Left, 28)
                 report.AddColumn(RoleTable.RoleRank.Name, ReportEnum.Align.Right, "${RoleRank}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = RoleTable.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "FASTPORT")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = RoleTable.GetColumnList()
                Dim records As RoleRecord() = Nothing
                Do
                    records = RoleTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As RoleRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             If BaseClasses.Utils.MiscUtils.IsNull(record.GeneralRoleID) Then
                                 report.AddData("${GeneralRoleID}", "",ReportEnum.Align.Left)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.GeneralRoleID)
                                 _DFKA = RoleTable.GetDFKA(record.GeneralRoleID.ToString(), RoleTable.GeneralRoleID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  RoleTable.GeneralRoleID.IsApplyDisplayAs Then
                                     report.AddData("${GeneralRoleID}", _DFKA,ReportEnum.Align.Left)
                                 Else 
                                     report.AddData("${GeneralRoleID}", record.Format(RoleTable.GeneralRoleID), ReportEnum.Align.Left)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.RoleTypeID) Then
                                 report.AddData("${RoleTypeID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = RoleTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(RoleTable.RoleTypeID)
                                 _DFKA = RoleTable.GetDFKA(record.RoleTypeID.ToString(), RoleTable.RoleTypeID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  RoleTable.RoleTypeID.IsApplyDisplayAs Then
                                     report.AddData("${RoleTypeID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${RoleTypeID}", record.Format(RoleTable.RoleTypeID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${Role}", record.Format(RoleTable.Role), ReportEnum.Align.Left, 300)
                             report.AddData("${RoleDescription}", record.Format(RoleTable.RoleDescription), ReportEnum.Align.Left, 300)
                             report.AddData("${RoleRank}", record.Format(RoleTable.RoleRank), ReportEnum.Align.Right, 300)

                            report.WriteRow
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery 
                report.save
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for Button with Layout
        Public Overridable Sub RoleButtonsButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub RoleFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
          Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub RoleFiltersButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for FieldFilter
        Protected Overridable Sub RoleTypeIDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	   
        End Sub
            
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Protected _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property

        Protected _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property

        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = RoleTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As RoleRecord = Nothing
        Public Property DataSource() As RoleRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As RoleRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property GeneralRoleIDSortLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GeneralRoleIDSortLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleButtonsButton() As FASTPORT.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleButtonsButton"), FASTPORT.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property RoleDescriptionSortLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleDescriptionSortLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleFilterButton() As FASTPORT.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleFilterButton"), FASTPORT.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property RoleFiltersButton() As FASTPORT.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleFiltersButton"), FASTPORT.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property RoleImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleNewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleNewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RolePagination() As FASTPORT.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RolePagination"), FASTPORT.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property RolePDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RolePDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleRankSortLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleRankSortLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property RoleSearchButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleSearchButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleSortLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleSortLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleTypeIDFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTypeIDFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property RoleTypeIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTypeIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property RoleTypeIDSortLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleTypeIDSortLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property RoleWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "RoleWordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As RoleTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
                End If
                Dim rec As RoleRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As RoleTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As RoleTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(RoleTableControlRow)), RoleTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As RoleTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "FASTPORT"))
            End If
            
            Dim recCtl As RoleTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As RoleTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("RoleTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
            
                Dim recControl As RoleTableControlRow = DirectCast(repItem.FindControl("RoleTableControlRow"), RoleTableControlRow)
                recList.Add(recControl)
              
            Next

            Return DirectCast(recList.ToArray(GetType(RoleTableControlRow)), RoleTableControlRow())
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

  