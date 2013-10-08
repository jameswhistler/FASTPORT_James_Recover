
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditTreeImage.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace FASTPORT.UI.Controls.EditTreeImage

#Region "Section 1: Place your customizations here."

    
Public Class TreeRecordControl
        Inherits BaseTreeRecordControl
        ' The BaseTreeRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.


        Public Overrides Sub UploadButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            s_UploadImage("ItemImage")

        End Sub


        Public Overrides Sub UploadGlowButton_Click(sender As Object, args As System.EventArgs)
          
            s_UploadImage("ItemImageGlow")

        End Sub

        Public Overrides Sub UploadGrayButton_Click(sender As Object, args As System.EventArgs)

            s_UploadImage("ItemImageGray")

        End Sub

        Public Overrides Sub UploadLowResButton_Click(sender As Object, args As System.EventArgs)

            s_UploadImage("ItemImageLowRes")

        End Sub
        Public Sub s_UploadImage(ByVal myImageType As String)

            Try

                Dim myRadUpload1 As RadUpload = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "RadUpload1"), RadUpload)
                Dim myImageControl As String = "ItemRadBinaryImage"
                Dim myOldFile As String = Nothing

                If myImageType = "ItemImage" Then

                    myImageControl = "ItemRadBinaryImage"

                ElseIf myImageType = "ItemImageGlow" Then

                    myImageControl = "ItemGlowRadBinaryImage"

                ElseIf myImageType = "ItemImageGray" Then

                    myImageControl = "ItemGrayRadBinaryImage"

                ElseIf myImageType = "ItemImageLowRes" Then

                    myImageControl = "ItemLowResRadBinaryImage"

                End If

                If myImageType = "ItemImage" Then

                    myOldFile = Me.ImagePath.Text

                ElseIf myImageType = "ItemImageGlow" Then

                    myOldFile = Me.ImageGlowPath.Text

                ElseIf myImageType = "ItemImageGray" Then

                    myOldFile = Me.ImageGrayPath.Text

                ElseIf myImageType = "ItemImageLowRes" Then

                    myOldFile = Me.ImageLowResPath.Text

                End If

                Dim myItemRadBinaryImage As RadBinaryImage = DirectCast(MiscUtils.FindControlRecursively(Me.Page, myImageControl), RadBinaryImage)

                If myRadUpload1.UploadedFiles.Count > 0 Then

                    'Get file as array.
                    Dim myFile As UploadedFile = myRadUpload1.UploadedFiles(0)
                    Dim myFileAsArray As Byte() = New Byte(CInt(myFile.InputStream.Length) - 1) {}
                    myFile.InputStream.Read(myFileAsArray, 0, myFileAsArray.Length)

                    'Show image on page.
                    myItemRadBinaryImage.DataValue = myFileAsArray

                    'Get file path and delete old file.
                    Dim myAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory

                    Dim myFullOldPath As String = myAppPath & "Images\Custom\SavedFromApp\Tree\" & myOldFile


                    If String.IsNullOrEmpty(myOldFile) = False And System.IO.File.Exists(myFullOldPath) = True Then
                        System.IO.File.Delete(myFullOldPath)
                    End If

                    'Save to a specific place.
                    Dim myTreeEncrypt As String = CStr(f_GetRandomNumber())

                    Dim myFileName As String = myTreeEncrypt & "-" & myRadUpload1.UploadedFiles(0).FileName.ToString
                    Dim myFullNewPath As String = myAppPath & "Images\Custom\SavedFromApp\Tree\" & myFileName
                    s_UpdateImage(myFileAsArray, myFileName, myImageType)

                    myRadUpload1.UploadedFiles(0).SaveAs(myFullNewPath, True)

                End If

            Catch ex As Exception

                Dim myMessage As String = "WARNING: The system was unable to update your image.  If the problem continues, please contact support. Detailed error message: " & ex.Message
                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            End Try

        End Sub

        Dim objRandom As New System.Random(CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))

        Public Function f_GetRandomNumber( _
          Optional ByVal Low As Integer = 100, _
          Optional ByVal High As Integer = 100000) As Integer
            ' Returns a random number,
            ' between the optional Low and High parameters
            Return objRandom.Next(Low, High + 1)
        End Function

        Public Sub s_UpdateImage(ByVal myFileAsArray As Byte(), ByVal myFileName As String, ByVal myImageType As String)

            Try

                Dim myPK As String = Me.TreeID.Text
                Dim myRec As New TreeRecord

                DbUtils.StartTransaction()
                myRec = TreeTable.GetRecord(myPK, True)

                If myImageType = "ItemImage" Then

                    myRec.ItemImage = myFileAsArray
                    myRec.ImagePath = myFileName

                ElseIf myImageType = "ItemImageGlow" Then

                    myRec.ItemImageGlow = myFileAsArray
                    myRec.ImageGlowPath = myFileName

                ElseIf myImageType = "ItemImageGray" Then

                    myRec.ItemImageGray = myFileAsArray
                    myRec.ImageGrayPath = myFileName

                ElseIf myImageType = "ItemImageLowRes" Then

                    myRec.ItemImageLowRes = myFileAsArray
                    myRec.ImageLowResPath = myFileName

                End If

                myRec.Save()
                DbUtils.CommitTransaction()


            Catch ex As Exception

                Dim myMessage As String = "WARNING: The system was unable to update your image.  If the problem continues, please contact support. Detailed error message: " & ex.Message
                DbUtils.RollBackTransaction()
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

                DbUtils.EndTransaction()

            End Try



        End Sub

        Public Sub s_DeleteImage(ByVal myImageType As String)

            Dim myPK As String = Me.TreeID.Text & "," & myImageType
            Dim myItem As String = Me.ItemName.Text
            Dim myTitle As String = "Delete Image from " & myItem & "?"
            myTitle = HttpUtility.UrlEncode(myTitle)
            Dim myMessage As String = "Are you certain that you wish to delete the image from item named: " & myItem & "?"
            myMessage = HttpUtility.UrlEncode(myMessage)

            Dim url As String = "../Dialogues/YesNoDialogue.aspx?PK=" & DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(myPK, String)) & "&Table=TreeImage&Title=" & myTitle & "&Message=" & myMessage & "&Action=Delete"

            Dim shouldRedirect As Boolean = True

            Me.Page.Response.Redirect(url)

        End Sub

        Public Overrides Sub DeleteImageButton_Click(sender As Object, args As System.Web.UI.ImageClickEventArgs)

            'JAR

            s_DeleteImage("ItemImage")


        End Sub

        Public Overrides Sub DeleteGlowButton_Click(sender As Object, args As System.Web.UI.ImageClickEventArgs)

            s_DeleteImage("ItemImageGlow")

        End Sub

        Public Overrides Sub DeleteGrayButton_Click(sender As Object, args As System.Web.UI.ImageClickEventArgs)

            s_DeleteImage("ItemImageGray")


        End Sub

        Public Overrides Sub DeleteLowResButton_Click(sender As Object, args As System.Web.UI.ImageClickEventArgs)

            s_DeleteImage("ItemImageLowRes")

        End Sub

    End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the TreeRecordControl control on the EditTreeImage page.
' Do not modify this class. Instead override any method in TreeRecordControl.
Public Class BaseTreeRecordControl
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in TreeRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
            
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in TreeRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.DeleteGlowButton.Click, AddressOf DeleteGlowButton_Click
              
              AddHandler Me.DeleteGrayButton.Click, AddressOf DeleteGrayButton_Click
              
              AddHandler Me.DeleteImageButton.Click, AddressOf DeleteImageButton_Click
              
              AddHandler Me.DeleteLowResButton.Click, AddressOf DeleteLowResButton_Click
              
            AddHandler Me.UploadButton.Button.Click, AddressOf UploadButton_Click
        
            AddHandler Me.UploadGlowButton.Button.Click, AddressOf UploadGlowButton_Click
        
            AddHandler Me.UploadGrayButton.Button.Click, AddressOf UploadGrayButton_Click
        
            AddHandler Me.UploadLowResButton.Button.Click, AddressOf UploadLowResButton_Click
        
              AddHandler Me.Hide.CheckedChanged, AddressOf Hide_CheckedChanged
            
              AddHandler Me.ImageGlowPath.TextChanged, AddressOf ImageGlowPath_TextChanged
            
              AddHandler Me.ImageGrayPath.TextChanged, AddressOf ImageGrayPath_TextChanged
            
              AddHandler Me.ImageLowResPath.TextChanged, AddressOf ImageLowResPath_TextChanged
            
              AddHandler Me.ImagePath.TextChanged, AddressOf ImagePath_TextChanged
            
              AddHandler Me.ItemName.TextChanged, AddressOf ItemName_TextChanged
            
              AddHandler Me.TreeParentID.TextChanged, AddressOf TreeParentID_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource Tree record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = TreeTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "TreeRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New TreeRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As TreeRecord = TreeTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = TreeTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in TreeRecordControl.
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
        
                
                
                
                
                SetGlowLabel()
                SetGrayLabel()
                SetHide()
                SetImageGlowPath()
                SetImageGrayPath()
                SetImageLabel()
                SetImageLowResPath()
                SetImagePath()
                SetItemImageLabel()
                SetItemName()
                SetLowResLabel()
                SetTreeID()
                SetTreeParentID()
                
                
                
                
      
      
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
        
        
        Public Overridable Sub SetHide()
            
        
            ' Set the Hide CheckBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.Hide is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetHide()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HideSpecified Then
                									
                ' If the Hide is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.Hide.Checked = Me.DataSource.Hide
            Else
            
                ' Hide is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.Hide.Checked = TreeTable.Hide.ParseValue(TreeTable.Hide.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetImageGlowPath()
            
        
            ' Set the ImageGlowPath TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.ImageGlowPath is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetImageGlowPath()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ImageGlowPathSpecified Then
                				
                ' If the ImageGlowPath is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.ImageGlowPath)
                              
                Me.ImageGlowPath.Text = formattedValue
                
            Else 
            
                ' ImageGlowPath is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ImageGlowPath.Text = TreeTable.ImageGlowPath.Format(TreeTable.ImageGlowPath.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetImageGrayPath()
            
        
            ' Set the ImageGrayPath TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.ImageGrayPath is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetImageGrayPath()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ImageGrayPathSpecified Then
                				
                ' If the ImageGrayPath is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.ImageGrayPath)
                              
                Me.ImageGrayPath.Text = formattedValue
                
            Else 
            
                ' ImageGrayPath is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ImageGrayPath.Text = TreeTable.ImageGrayPath.Format(TreeTable.ImageGrayPath.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetImageLowResPath()
            
        
            ' Set the ImageLowResPath TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.ImageLowResPath is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetImageLowResPath()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ImageLowResPathSpecified Then
                				
                ' If the ImageLowResPath is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.ImageLowResPath)
                              
                Me.ImageLowResPath.Text = formattedValue
                
            Else 
            
                ' ImageLowResPath is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ImageLowResPath.Text = TreeTable.ImageLowResPath.Format(TreeTable.ImageLowResPath.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetImagePath()
            
        
            ' Set the ImagePath TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.ImagePath is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetImagePath()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ImagePathSpecified Then
                				
                ' If the ImagePath is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.ImagePath)
                              
                Me.ImagePath.Text = formattedValue
                
            Else 
            
                ' ImagePath is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ImagePath.Text = TreeTable.ImagePath.Format(TreeTable.ImagePath.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetItemName()
            
        
            ' Set the ItemName TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.ItemName is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetItemName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ItemNameSpecified Then
                				
                ' If the ItemName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.ItemName)
                              
                Me.ItemName.Text = formattedValue
                
            Else 
            
                ' ItemName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ItemName.Text = TreeTable.ItemName.Format(TreeTable.ItemName.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTreeID()
            
        
            ' Set the TreeID Literal on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.TreeID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTreeID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TreeIDSpecified Then
                				
                ' If the TreeID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(TreeTable.TreeID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TreeID.Text = formattedValue
                
            Else 
            
                ' TreeID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TreeID.Text = TreeTable.TreeID.Format(TreeTable.TreeID.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetTreeParentID()
            
        
            ' Set the TreeParentID TextBox on the webpage with value from the
            ' Tree database record.

            ' Me.DataSource is the Tree record retrieved from the database.
            ' Me.TreeParentID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTreeParentID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TreeParentIDSpecified Then
                				
                ' If the TreeParentID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.TreeParentID.ToString()
                                
                            
                Me.TreeParentID.Text = formattedValue
                
            Else 
            
                ' TreeParentID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.TreeParentID.Text = TreeTable.TreeParentID.DefaultValue		
                End If
                 
        End Sub
                
        Public Overridable Sub SetGlowLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.GlowLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetGrayLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.GrayLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetImageLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ImageLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetItemImageLabel()
                  
                  End Sub
                
        Public Overridable Sub SetLowResLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.LowResLabel.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in TreeRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "TreeRecordControlPanel"), System.Web.UI.WebControls.Panel)

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

        ' To customize, override this method in TreeRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetHide()
            GetImageGlowPath()
            GetImageGrayPath()
            GetImageLowResPath()
            GetImagePath()
            GetItemName()
            GetTreeID()
            GetTreeParentID()
        End Sub
        
        
        Public Overridable Sub GetHide()
        
        
            ' Retrieve the value entered by the user on the Hide ASP:CheckBox, and
            ' save it into the Hide field in DataSource Tree record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.Hide = Me.Hide.Checked
                    
        End Sub
                
        Public Overridable Sub GetImageGlowPath()
            
            ' Retrieve the value entered by the user on the ImageGlowPath ASP:TextBox, and
            ' save it into the ImageGlowPath field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ImageGlowPath.Text, TreeTable.ImageGlowPath)			

                      
        End Sub
                
        Public Overridable Sub GetImageGrayPath()
            
            ' Retrieve the value entered by the user on the ImageGrayPath ASP:TextBox, and
            ' save it into the ImageGrayPath field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ImageGrayPath.Text, TreeTable.ImageGrayPath)			

                      
        End Sub
                
        Public Overridable Sub GetImageLowResPath()
            
            ' Retrieve the value entered by the user on the ImageLowResPath ASP:TextBox, and
            ' save it into the ImageLowResPath field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ImageLowResPath.Text, TreeTable.ImageLowResPath)			

                      
        End Sub
                
        Public Overridable Sub GetImagePath()
            
            ' Retrieve the value entered by the user on the ImagePath ASP:TextBox, and
            ' save it into the ImagePath field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ImagePath.Text, TreeTable.ImagePath)			

                      
        End Sub
                
        Public Overridable Sub GetItemName()
            
            ' Retrieve the value entered by the user on the ItemName ASP:TextBox, and
            ' save it into the ItemName field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ItemName.Text, TreeTable.ItemName)			

                      
        End Sub
                
        Public Overridable Sub GetTreeID()
            
        End Sub
                
        Public Overridable Sub GetTreeParentID()
            
            ' Retrieve the value entered by the user on the TreeParentID ASP:TextBox, and
            ' save it into the TreeParentID field in DataSource Tree record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.TreeParentID.Text, TreeTable.TreeParentID)			

                      
        End Sub
                
      
        ' To customize, override this method in TreeRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            TreeTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("Tree"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "FASTPORT").Replace("{URL}", "Tree"))
            End If
            HttpContext.Current.Session("QueryString in EditTreeImage") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(TreeTable.TreeID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(TreeTable.TreeID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(TreeTable.TreeID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            TreeTable.Instance.InnerFilter = Nothing
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
        
    

        ' To customize, override this method in TreeRecordControl.
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
          TreeTable.DeleteRecord(pkValue)
          
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
            
        ' event handler for ImageButton
        Public Overridable Sub DeleteGlowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DeleteGrayButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DeleteImageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DeleteLowResButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for Button with Layout
        Public Overridable Sub UploadButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub UploadGlowButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub UploadGrayButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub UploadLowResButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
        Protected Overridable Sub Hide_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub ImageGlowPath_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ImageGrayPath_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ImageLowResPath_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ImagePath_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ItemName_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub TreeParentID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseTreeRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseTreeRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As TreeRecord
        Public Property DataSource() As TreeRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As TreeRecord)
            
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
        
        Public ReadOnly Property DeleteGlowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteGlowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property DeleteGrayButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteGrayButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property DeleteImageButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteImageButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property DeleteLowResButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteLowResButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property GlowLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GlowLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property GrayLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "GrayLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Hide() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Hide"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ImageGlowPath() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageGlowPath"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ImageGrayPath() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageGrayPath"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ImageLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ImageLowResPath() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageLowResPath"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ImagePath() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImagePath"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ItemImageLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemImageLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ItemName() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemName"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property LowResLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LowResLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TreeID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TreeID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property TreeParentID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TreeParentID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property UploadButton() As FASTPORT.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UploadButton"), FASTPORT.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property UploadGlowButton() As FASTPORT.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UploadGlowButton"), FASTPORT.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property UploadGrayButton() As FASTPORT.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UploadGrayButton"), FASTPORT.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property UploadLowResButton() As FASTPORT.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UploadLowResButton"), FASTPORT.UI.IThemeButton)
          End Get
          End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As TreeRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As TreeRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return TreeTable.GetRecord(Me.RecordUniqueId, True)
                
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

  