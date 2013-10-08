﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditCarrierAddr.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace FASTPORT.UI.Controls.EditCarrierAddr

#Region "Section 1: Place your customizations here."

    
Public Class PartyAddrRecordControl
        Inherits BasePartyAddrRecordControl
        ' The BasePartyAddrRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the PartyAddrRecordControl control on the EditCarrierAddr page.
' Do not modify this class. Instead override any method in PartyAddrRecordControl.
Public Class BasePartyAddrRecordControl
        Inherits FASTPORT.UI.BaseApplicationRecordControl

        '  To customize, override this method in PartyAddrRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
            
            Me.ClearControlsFromSession()
        End Sub

        '  To customize, override this method in PartyAddrRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.CountryID.SelectedIndexChanged, AddressOf CountryID_SelectedIndexChanged
            
              AddHandler Me.Headquarters.CheckedChanged, AddressOf Headquarters_CheckedChanged
            
              AddHandler Me.MovedOut.CheckedChanged, AddressOf MovedOut_CheckedChanged
            
              AddHandler Me.Addr.TextChanged, AddressOf Addr_TextChanged
            
              AddHandler Me.Addr1.TextChanged, AddressOf Addr1_TextChanged
            
              AddHandler Me.AddrName.TextChanged, AddressOf AddrName_TextChanged
            
              AddHandler Me.AddrZipID.TextChanged, AddressOf AddrZipID_TextChanged
            
              AddHandler Me.DirectDail.TextChanged, AddressOf DirectDail_TextChanged
            
              AddHandler Me.Email.TextChanged, AddressOf Email_TextChanged
            
              AddHandler Me.Fax.TextChanged, AddressOf Fax_TextChanged
            
              AddHandler Me.Lat.TextChanged, AddressOf Lat_TextChanged
            
              AddHandler Me.Long1.TextChanged, AddressOf Long1_TextChanged
            
              AddHandler Me.PartyID.TextChanged, AddressOf PartyID_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource PartyAddr record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = PartyAddrTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyAddrRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New PartyAddrRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As PartyAddrRecord = PartyAddrTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = PartyAddrTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in PartyAddrRecordControl.
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
        
                SetAddr()
                SetAddr1()
                SetAddressHeaderLabel()
                SetAddrLabel()
                SetAddrName()
                SetAddrNameLabel()
                SetAddrZipID()
                SetContactInfoLabel()
                SetCountryID()
                SetDirectDail()
                SetDirectDailLabel()
                SetEmail()
                SetEmailLabel()
                SetemailValidator()
                SetFax()
                SetFaxLabel()
                SetHeadquarters()
                SetHeadquartersLabel()
                SetLat()
                SetLong1()
                SetMovedOut()
                SetMovedOutLabel()
                SetPartyID()
      
      
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
        
        
        Public Overridable Sub SetAddr()
            
        
            ' Set the Addr TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Addr is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAddr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AddrSpecified Then
                				
                ' If the Addr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Addr)
                              
                Me.Addr.Text = formattedValue
                
            Else 
            
                ' Addr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Addr.Text = PartyAddrTable.Addr.Format(PartyAddrTable.Addr.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAddr1()
            
        
            ' Set the Addr2 TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Addr1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAddr1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Addr2Specified Then
                				
                ' If the Addr2 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Addr2)
                              
                Me.Addr1.Text = formattedValue
                
            Else 
            
                ' Addr2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Addr1.Text = PartyAddrTable.Addr2.Format(PartyAddrTable.Addr2.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAddrName()
            
        
            ' Set the AddrName TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.AddrName is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAddrName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AddrNameSpecified Then
                				
                ' If the AddrName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.AddrName)
                              
                Me.AddrName.Text = formattedValue
                
            Else 
            
                ' AddrName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.AddrName.Text = PartyAddrTable.AddrName.Format(PartyAddrTable.AddrName.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAddrZipID()
            
        
            ' Set the AddrZipID TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.AddrZipID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAddrZipID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AddrZipIDSpecified Then
                				
                ' If the AddrZipID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.AddrZipID)
                              
                Me.AddrZipID.Text = formattedValue
                
            Else 
            
                ' AddrZipID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.AddrZipID.Text = PartyAddrTable.AddrZipID.Format(PartyAddrTable.AddrZipID.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetCountryID()
            
        
            ' Set the CountryID DropDownList on the webpage with value from the
            ' PartyAddr database record.
            
            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.CountryID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCountryID()
            ' and add your own code before or after the call to the MyBase function.

            
            ' Default Value could also be NULL.
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                
                Me.PopulateCountryIDDropDownList(Me.DataSource.CountryID.ToString(), 100)
                
            Else
                
            
                Me.PopulateCountryIDDropDownList(EvaluateFormula("3"), 100)
                
            End If

            
        End Sub
                
        Public Overridable Sub SetDirectDail()
            
        
            ' Set the DirectDail TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.DirectDail is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDirectDail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DirectDailSpecified Then
                				
                ' If the DirectDail is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.DirectDail)
                              
                Me.DirectDail.Text = formattedValue
                
            Else 
            
                ' DirectDail is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.DirectDail.Text = PartyAddrTable.DirectDail.Format(PartyAddrTable.DirectDail.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetEmail()
            
        
            ' Set the Email TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Email is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEmail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EmailSpecified Then
                				
                ' If the Email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Email)
                              
                Me.Email.Text = formattedValue
                
            Else 
            
                ' Email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Email.Text = PartyAddrTable.Email.Format(PartyAddrTable.Email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetFax()
            
        
            ' Set the Fax TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Fax is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFax()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FaxSpecified Then
                				
                ' If the Fax is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Fax)
                              
                Me.Fax.Text = formattedValue
                
            Else 
            
                ' Fax is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Fax.Text = PartyAddrTable.Fax.Format(PartyAddrTable.Fax.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetHeadquarters()
            
        
            ' Set the Headquarters CheckBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Headquarters is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetHeadquarters()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HeadquartersSpecified Then
                									
                ' If the Headquarters is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.Headquarters.Checked = Me.DataSource.Headquarters
            Else
            
                ' Headquarters is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.Headquarters.Checked = PartyAddrTable.Headquarters.ParseValue(PartyAddrTable.Headquarters.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetLat()
            
        
            ' Set the Lat TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Lat is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLat()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LatSpecified Then
                				
                ' If the Lat is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Lat)
                              
                Me.Lat.Text = formattedValue
                
            Else 
            
                ' Lat is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Lat.Text = PartyAddrTable.Lat.Format(PartyAddrTable.Lat.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetLong1()
            
        
            ' Set the Long TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.Long1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLong1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Long0Specified Then
                				
                ' If the Long is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyAddrTable.Long0)
                              
                Me.Long1.Text = formattedValue
                
            Else 
            
                ' Long is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.Long1.Text = PartyAddrTable.Long0.Format(PartyAddrTable.Long0.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetMovedOut()
            
        
            ' Set the MovedOut CheckBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.MovedOut is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetMovedOut()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.MovedOutSpecified Then
                									
                ' If the MovedOut is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.MovedOut.Checked = Me.DataSource.MovedOut
            Else
            
                ' MovedOut is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.MovedOut.Checked = PartyAddrTable.MovedOut.ParseValue(PartyAddrTable.MovedOut.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetPartyID()
            
        
            ' Set the PartyID TextBox on the webpage with value from the
            ' PartyAddr database record.

            ' Me.DataSource is the PartyAddr record retrieved from the database.
            ' Me.PartyID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPartyID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the PartyID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.PartyID.ToString()
                                
                            
                Me.PartyID.Text = formattedValue
                
            Else 
            
                ' PartyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.PartyID.Text = EvaluateFormula("URL(""Party"")", Me.DataSource)		
                End If
                 
        End Sub
                
        Public Overridable Sub SetAddressHeaderLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AddressHeaderLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAddrLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AddrLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAddrNameLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AddrNameLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetContactInfoLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ContactInfoLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetDirectDailLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.DirectDailLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetEmailLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.EmailLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetemailValidator()
                  
                  End Sub
                
        Public Overridable Sub SetFaxLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FaxLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHeadquartersLabel()
                  
                  End Sub
                
        Public Overridable Sub SetMovedOutLabel()
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.MovedOutLabel.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in PartyAddrRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "PartyAddrRecordControlPanel"), System.Web.UI.WebControls.Panel)

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

        ' To customize, override this method in PartyAddrRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAddr()
            GetAddr1()
            GetAddrName()
            GetAddrZipID()
            GetCountryID()
            GetDirectDail()
            GetEmail()
            GetFax()
            GetHeadquarters()
            GetLat()
            GetLong1()
            GetMovedOut()
            GetPartyID()
        End Sub
        
        
        Public Overridable Sub GetAddr()
            
            ' Retrieve the value entered by the user on the Addr ASP:TextBox, and
            ' save it into the Addr field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Addr.Text, PartyAddrTable.Addr)			

                      
        End Sub
                
        Public Overridable Sub GetAddr1()
            
            ' Retrieve the value entered by the user on the Addr2 ASP:TextBox, and
            ' save it into the Addr2 field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Addr1.Text, PartyAddrTable.Addr2)			

                      
        End Sub
                
        Public Overridable Sub GetAddrName()
            
            ' Retrieve the value entered by the user on the AddrName ASP:TextBox, and
            ' save it into the AddrName field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.AddrName.Text, PartyAddrTable.AddrName)			

                      
        End Sub
                
        Public Overridable Sub GetAddrZipID()
            
            ' Retrieve the value entered by the user on the AddrZipID ASP:TextBox, and
            ' save it into the AddrZipID field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.AddrZipID.Text, PartyAddrTable.AddrZipID)			

                      
        End Sub
                
        Public Overridable Sub GetCountryID()
         
            ' Retrieve the value entered by the user on the CountryID ASP:DropDownList, and
            ' save it into the CountryID field in DataSource PartyAddr record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.CountryID), PartyAddrTable.CountryID)				
            
        End Sub
                
        Public Overridable Sub GetDirectDail()
            
            ' Retrieve the value entered by the user on the DirectDail ASP:TextBox, and
            ' save it into the DirectDail field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.DirectDail.Text, PartyAddrTable.DirectDail)			

                      
        End Sub
                
        Public Overridable Sub GetEmail()
            
            ' Retrieve the value entered by the user on the Email ASP:TextBox, and
            ' save it into the Email field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Email.Text, PartyAddrTable.Email)			

                      
        End Sub
                
        Public Overridable Sub GetFax()
            
            ' Retrieve the value entered by the user on the Fax ASP:TextBox, and
            ' save it into the Fax field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Fax.Text, PartyAddrTable.Fax)			

                      
        End Sub
                
        Public Overridable Sub GetHeadquarters()
        
        
            ' Retrieve the value entered by the user on the Headquarters ASP:CheckBox, and
            ' save it into the Headquarters field in DataSource PartyAddr record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.Headquarters = Me.Headquarters.Checked
                    
        End Sub
                
        Public Overridable Sub GetLat()
            
            ' Retrieve the value entered by the user on the Lat ASP:TextBox, and
            ' save it into the Lat field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Lat.Text, PartyAddrTable.Lat)			

                      
        End Sub
                
        Public Overridable Sub GetLong1()
            
            ' Retrieve the value entered by the user on the Long ASP:TextBox, and
            ' save it into the Long field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.Long1.Text, PartyAddrTable.Long0)			

                      
        End Sub
                
        Public Overridable Sub GetMovedOut()
        
        
            ' Retrieve the value entered by the user on the MovedOut ASP:CheckBox, and
            ' save it into the MovedOut field in DataSource PartyAddr record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.MovedOut = Me.MovedOut.Checked
                    
        End Sub
                
        Public Overridable Sub GetPartyID()
            
            ' Retrieve the value entered by the user on the PartyID ASP:TextBox, and
            ' save it into the PartyID field in DataSource PartyAddr record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.PartyID.Text, PartyAddrTable.PartyID)			

                      
        End Sub
                
      
        ' To customize, override this method in PartyAddrRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersPartyAddrRecordControl As Boolean = False
      
            Dim wc As WhereClause
            PartyAddrTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("PartyAddr"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "FASTPORT").Replace("{URL}", "PartyAddr"))
            End If
            HttpContext.Current.Session("QueryString in EditCarrierAddr") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(PartyAddrTable.AddrID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(PartyAddrTable.AddrID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(PartyAddrTable.AddrID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            PartyAddrTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersPartyAddrRecordControl As Boolean = False
              
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
        
    

        ' To customize, override this method in PartyAddrRecordControl.
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
          PartyAddrTable.DeleteRecord(pkValue)
          
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
            

        Public Overridable Function CreateWhereClause_CountryIDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the v_GeoCountry table.
            ' Examples:
            ' wc.iAND(V_GeoCountryView.CountryID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(V_GeoCountryView.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the CountryID list.
        Protected Overridable Sub PopulateCountryIDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.CountryID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CountryIDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_CountryIDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(V_GeoCountryView.Country, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As V_GeoCountryRecord = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = V_GeoCountryView.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As V_GeoCountryRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.CountryIDSpecified Then
                            cvalue = itemValue.CountryID.ToString() 
                            
                        If counter < maxItems AndAlso Me.CountryID.Items.FindByValue(cvalue) Is Nothing Then
                      
                          Dim _isExpandableNonCompositeForeignKey As Boolean = PartyAddrTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PartyAddrTable.CountryID)
                          If _isExpandableNonCompositeForeignKey AndAlso PartyAddrTable.CountryID.IsApplyDisplayAs Then
                          fvalue = PartyAddrTable.GetDFKA(itemValue, PartyAddrTable.CountryID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(V_GeoCountryView.CountryID)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                      If (IsNothing(fvalue)) Then
                         fvalue = ""
                      End If

                      fvalue = fvalue.Trim()

                      If ( fvalue.Length > 50 ) Then
                          fvalue = fvalue.Substring(0, 50) & "..."
                      End If

                      Dim dupItem As ListItem = Me.CountryID.Items.FindByText(fvalue)
								
                      If Not IsNothing(dupItem) Then
                          listDuplicates.Add(fvalue)
                          dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                      End If

                      Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                      Me.CountryID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.CountryID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.CountryID, selectedValue)Then

                ' construct a whereclause to query a record with v_GeoCountry.CountryID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(V_GeoCountryView.CountryID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As V_GeoCountryRecord = V_GeoCountryView.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As V_GeoCountryRecord = DirectCast(rc(0), V_GeoCountryRecord)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.CountryIDSpecified Then
                            cvalue = itemValue.CountryID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = PartyAddrTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PartyAddrTable.CountryID)
                          If _isExpandableNonCompositeForeignKey AndAlso PartyAddrTable.CountryID.IsApplyDisplayAs Then
                          fvalue = PartyAddrTable.GetDFKA(itemValue, PartyAddrTable.CountryID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(V_GeoCountryView.CountryID)
                          End If
                        
                      If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                      Dim newItem As New ListItem(fvalue, cvalue)
                      Me.CountryID.Items.Add(newItem)
                      SetSelectedValue(Me.CountryID, selectedValue)
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        Protected Overridable Sub CountryID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(CountryID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(CountryID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.CountryID.Items.Add(New ListItem(displayText, val))
                Me.CountryID.SelectedIndex = Me.CountryID.Items.Count - 1
                Me.Page.Session.Remove(CountryID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(CountryID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub Headquarters_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub MovedOut_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub Addr_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Addr1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub AddrName_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub AddrZipID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub DirectDail_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Fax_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Lat_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub Long1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub PartyID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BasePartyAddrRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePartyAddrRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As PartyAddrRecord
        Public Property DataSource() As PartyAddrRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As PartyAddrRecord)
            
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
        
        Public ReadOnly Property Addr() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Addr"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Addr1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Addr1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property AddressHeaderLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddressHeaderLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property AddrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AddrName() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrName"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property AddrNameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrNameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AddrZipID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddrZipID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ContactInfoLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ContactInfoLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property CountryID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CountryID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property DirectDail() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DirectDail"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property DirectDailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DirectDailLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property Headquarters() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Headquarters"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property HeadquartersLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HeadquartersLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Lat() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Lat"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Long1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Long1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property MovedOut() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MovedOut"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property MovedOutLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MovedOutLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PartyID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As PartyAddrRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As PartyAddrRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return PartyAddrTable.GetRecord(Me.RecordUniqueId, True)
                
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

  