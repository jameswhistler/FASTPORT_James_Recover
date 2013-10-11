﻿' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace FASTPORT.Business

''' <summary>
''' Provides access to the data in a database record from a table (or view) that lacks a primary key.
''' Also provides access to the <see cref="V_PartyUserRolesView"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="V_PartyUserRolesView"></seealso>

<Serializable()> Public Class V_PartyUserRolesRecord
	Inherits BaseV_PartyUserRolesRecord

	' Constructors
 
	Public Sub New()
		MyBase.New()
	End Sub

	
End Class
End Namespace
