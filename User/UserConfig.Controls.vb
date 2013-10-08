
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' UserConfig.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace FASTPORT.UI.Controls.UserConfig

#Region "Section 1: Place your customizations here."

    
Public Class PartyRecordControl
        Inherits BasePartyRecordControl
        ' The BasePartyRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ' Setup the pagination events.	  


            ' Register the event handlers.

            'AddHandler Me.DirectDial.TextChanged, AddressOf DirectDial_TextChanged

            'AddHandler Me.Email.TextChanged, AddressOf Email_TextChanged

            'AddHandler Me.Fax.TextChanged, AddressOf Fax_TextChanged

            'AddHandler Me.Mobile.TextChanged, AddressOf Mobile_TextChanged

            'AddHandler Me.Name.TextChanged, AddressOf Name_TextChanged

            'AddHandler Me.Password.TextChanged, AddressOf Password_TextChanged


        End Sub

        Public Overrides Sub SetDirectDial()


            ' Set the DirectDial TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.DirectDial is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDirectDial()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DirectDialSpecified Then

                ' If the DirectDial is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.DirectDial)

                Me.DirectDial.Text = formattedValue


            Else

                ' DirectDial is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.DirectDial.Text = PartyTable.DirectDial.Format(PartyTable.DirectDial.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetEmail()


            ' Set the Email TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Email is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEmail()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EmailSpecified Then

                ' If the Email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Email)

                Me.Email.Text = formattedValue

            Else

                ' Email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Email.Text = PartyTable.Email.Format(PartyTable.Email.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetFax()


            ' Set the Fax TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Fax is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFax()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FaxSpecified Then

                ' If the Fax is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Fax)

                Me.Fax.Text = formattedValue

            Else

                ' Fax is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Fax.Text = PartyTable.Fax.Format(PartyTable.Fax.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetMobile()


            ' Set the Mobile TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Mobile is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetMobile()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.MobileSpecified Then

                ' If the Mobile is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Mobile)

                Me.Mobile.Text = formattedValue

            Else

                ' Mobile is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Mobile.Text = PartyTable.Mobile.Format(PartyTable.Mobile.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetName()


            ' Set the Name TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Name is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetName()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NameSpecified Then

                ' If the Name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Name)

                Me.Name.Text = formattedValue

            Else

                ' Name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Name.Text = PartyTable.Name.Format(PartyTable.Name.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetPassword()


            ' Set the Password TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Password is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPassword()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PasswordSpecified Then

                ' If the Password is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Password)

                Me.Password.Text = formattedValue

            Else

                ' Password is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.Password.Text = PartyTable.Password.Format(PartyTable.Password.DefaultValue)

            End If

        End Sub

    End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the PartyRecordControl control on the UserConfig page.
' Do not modify this class. Instead override any method in PartyRecordControl.
Public Class BasePartyRecordControl
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in PartyRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
            
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in PartyRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.DirectDial.TextChanged, AddressOf DirectDial_TextChanged
            
              AddHandler Me.Email.TextChanged, AddressOf Email_TextChanged
            
              AddHandler Me.Fax.TextChanged, AddressOf Fax_TextChanged
            
              AddHandler Me.Mobile.TextChanged, AddressOf Mobile_TextChanged
            
              AddHandler Me.Name.TextChanged, AddressOf Name_TextChanged
            
              AddHandler Me.Password.TextChanged, AddressOf Password_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource Party record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = PartyTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New PartyRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As PartyRecord = PartyTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = PartyTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in PartyRecordControl.
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
        
                SetAddrDeleteIB()
                SetAddrDS()
                SetDirectDial()
                SetDirectDialLabel()
                SetEmail()
                SetEmailLabel()
                SetemailValidator()
                SetFax()
                SetFaxLabel()
                SetMobile()
                SetMobileLabel()
                SetName()
                SetNameLabel()
                SetPassword()
                SetPasswordLabel()
      
      
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
        
        
        Public Overridable Sub SetDirectDial()
            
        
            ' Set the DirectDial TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.DirectDial is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDirectDial()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DirectDialSpecified Then
                				
                ' If the DirectDial is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.DirectDial)
                              
                Me.DirectDial.Text = formattedValue
                
            Else 
            
                ' DirectDial is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DirectDial.Text = PartyTable.DirectDial.Format(PartyTable.DirectDial.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEmail()
            
        
            ' Set the Email TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Email is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEmail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EmailSpecified Then
                				
                ' If the Email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Email)
                              
                Me.Email.Text = formattedValue
                
            Else 
            
                ' Email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Email.Text = PartyTable.Email.Format(PartyTable.Email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFax()
            
        
            ' Set the Fax TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Fax is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFax()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FaxSpecified Then
                				
                ' If the Fax is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Fax)
                              
                Me.Fax.Text = formattedValue
                
            Else 
            
                ' Fax is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Fax.Text = PartyTable.Fax.Format(PartyTable.Fax.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetMobile()
            
        
            ' Set the Mobile TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Mobile is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetMobile()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.MobileSpecified Then
                				
                ' If the Mobile is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Mobile)
                              
                Me.Mobile.Text = formattedValue
                
            Else 
            
                ' Mobile is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Mobile.Text = PartyTable.Mobile.Format(PartyTable.Mobile.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetName()
            
        
            ' Set the Name TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.NameSpecified Then
                				
                ' If the Name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Name)
                              
                Me.Name.Text = formattedValue
                
            Else 
            
                ' Name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Name.Text = PartyTable.Name.Format(PartyTable.Name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetPassword()
            
        
            ' Set the Password TextBox on the webpage with value from the
            ' Party database record.

            ' Me.DataSource is the Party record retrieved from the database.
            ' Me.Password is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPassword()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PasswordSpecified Then
                				
                ' If the Password is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.Password)
                              
                Me.Password.Text = formattedValue
                
            Else 
            
                ' Password is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Password.Text = PartyTable.Password.Format(PartyTable.Password.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAddrDeleteIB()
                  
                  End Sub
                
        Public Overridable Sub SetAddrDS()
                  
                  End Sub
                
        Public Overridable Sub SetDirectDialLabel()
                  
                  End Sub
                
        Public Overridable Sub SetEmailLabel()
                  
                  End Sub
                
        Public Overridable Sub SetemailValidator()
                  
                  End Sub
                
        Public Overridable Sub SetFaxLabel()
                  
                  End Sub
                
        Public Overridable Sub SetMobileLabel()
                  
                  End Sub
                
        Public Overridable Sub SetNameLabel()
                  
                  End Sub
                
        Public Overridable Sub SetPasswordLabel()
                  
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

      
        
        ' To customize, override this method in PartyRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyRecordControlPanel"), System.Web.UI.WebControls.Panel)

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

        ' To customize, override this method in PartyRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetDirectDial()
            GetEmail()
            GetFax()
            GetMobile()
            GetName()
            GetPassword()
        End Sub
        
        
        Public Overridable Sub GetDirectDial()
            
            ' Retrieve the value entered by the user on the DirectDial ASP:TextBox, and
            ' save it into the DirectDial field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.DirectDial.Text, PartyTable.DirectDial)			

                      
        End Sub
                
        Public Overridable Sub GetEmail()
            
            ' Retrieve the value entered by the user on the Email ASP:TextBox, and
            ' save it into the Email field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Email.Text, PartyTable.Email)			

                      
        End Sub
                
        Public Overridable Sub GetFax()
            
            ' Retrieve the value entered by the user on the Fax ASP:TextBox, and
            ' save it into the Fax field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Fax.Text, PartyTable.Fax)			

                      
        End Sub
                
        Public Overridable Sub GetMobile()
            
            ' Retrieve the value entered by the user on the Mobile ASP:TextBox, and
            ' save it into the Mobile field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Mobile.Text, PartyTable.Mobile)			

                      
        End Sub
                
        Public Overridable Sub GetName()
            
            ' Retrieve the value entered by the user on the Name ASP:TextBox, and
            ' save it into the Name field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Name.Text, PartyTable.Name)			

                      
        End Sub
                
        Public Overridable Sub GetPassword()
            
            ' Retrieve the value entered by the user on the Password ASP:TextBox, and
            ' save it into the Password field in DataSource Party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            If  (Not Me.Password.TextMode = TextBoxMode.Password) OrElse (Not Me.Password.Text.Trim() = "") Then
                        
                Dim PasswordformattedValue As String = Me.DataSource.Format(PartyTable.Password)
                          
                If Me.Password.Text.Trim() <> PasswordformattedValue Then
                    'Save the value to data source
                    Me.DataSource.Parse(Me.Password.Text, PartyTable.Password)			
                
                End If
            End If
                      
        End Sub
                
      
        ' To customize, override this method in PartyRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersPartyRecordControl As Boolean = False
      
            Dim wc As WhereClause
            PartyTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Get the static clause defined at design time on the Record Panel Wizard
            
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc)
            End If
            
            Return wc
          
        End Function
        
        Protected Overridable Function CreateQueryClause() As WhereClause
            ' Create a where clause for the Static clause defined at design time.
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
        Dim whereClause As WhereClause = New WhereClause()

            If EvaluateFormula("Session(""PartyID"")", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("FASTPORT.Business.PartyTable, FASTPORT.Business").TableDefinition.ColumnList.GetByUniqueName("Party_.PartyID"), EvaluateFormula("Session(""PartyID"")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("Session(""PartyID"")", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("Session(""PartyID"")", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)

            Return whereClause

        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            PartyTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersPartyRecordControl As Boolean = False
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

            
            ' Get the static clause defined at design time on the Table Panel Wizard
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc) ''nope nothing
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
        
    

        ' To customize, override this method in PartyRecordControl.
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
          PartyTable.DeleteRecord(pkValue)
          
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
            
        Protected Overridable Sub DirectDial_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Fax_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Mobile_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Password_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BasePartyRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePartyRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As PartyRecord
        Public Property DataSource() As PartyRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As PartyRecord)
            
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
        
        Public ReadOnly Property AddrDeleteIB() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrDeleteIB"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property AddrDS() As System.Web.UI.WebControls.SqlDataSource
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrDS"), System.Web.UI.WebControls.SqlDataSource)
            End Get
        End Property
        
        Public ReadOnly Property DirectDial() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DirectDial"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property DirectDialLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DirectDialLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Email() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Email"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property EmailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EmailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property emailValidator() As System.Web.UI.WebControls.RegularExpressionValidator
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailValidator"), System.Web.UI.WebControls.RegularExpressionValidator)
            End Get
        End Property
        
        Public ReadOnly Property Fax() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Fax"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property FaxLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FaxLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Mobile() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Mobile"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property MobileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MobileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property NameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Password() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Password"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property PasswordLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PasswordLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As PartyRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As PartyRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return PartyTable.GetRecord(Me.RecordUniqueId, True)
                
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

  