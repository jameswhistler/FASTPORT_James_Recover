﻿Namespace FASTPORT.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="PartyRepsTable">FASTPORT.PartyRepsTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="PartyRepsTable"></seealso>

Public Class PartyRepsDefinition

#Region "Definition (XML) for PartyRepsDefinition table"
	'Next 185 lines contain Table Definition (XML) for table "PartyRepsDefinition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="PartyRepsTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		If _DefinitionString = "" Then
			         Dim tbf As System.Text.StringBuilder = New System.Text.StringBuilder()
         tbf.Append("<XMLDefinition Generator=""Iron Speed Designer"" Version=""9.0"" Type=""GENERIC"">")
         tbf.Append(  "<ColumnDefinition>")
         tbf.Append(    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">")
         tbf.Append(      "<columnName>PartyRepsID</columnName>")
         tbf.Append(      "<columnUIName>Party Reps</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>Y</columnComputed>")
         tbf.Append(      "<columnIdentity>Y</columnIdentity>")
         tbf.Append(      "<columnReadOnly>Y</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(      "<applyDFKA>N</applyDFKA>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>PartyID</columnName>")
         tbf.Append(      "<columnUIName>Party</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>Y</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_PartyReps_Party</columnFKName>")
         tbf.Append(        "<columnFKTable>FASTPORT.Business.PartyTable, FASTPORT.Business</columnFKTable>")
         tbf.Append(        "<columnFKOwner>dbo</columnFKOwner>")
         tbf.Append(        "<columnFKColumn>PartyID</columnFKColumn>")
         tbf.Append(        "<columnFKColumnDisplay>Name</columnFKColumnDisplay>")
         tbf.Append(        "<foreignKeyType>Explicit</foreignKeyType>")
         tbf.Append(      "</foreignKey>")
         tbf.Append(      "<applyDFKA>Y</applyDFKA>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">")
         tbf.Append(      "<columnName>RepID</columnName>")
         tbf.Append(      "<columnUIName>Representative</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>Y</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_PartyReps_Tree</columnFKName>")
         tbf.Append(        "<columnFKTable>FASTPORT.Business.TreeTable, FASTPORT.Business</columnFKTable>")
         tbf.Append(        "<columnFKOwner>dbo</columnFKOwner>")
         tbf.Append(        "<columnFKColumn>TreeID</columnFKColumn>")
         tbf.Append(        "<columnFKColumnDisplay>ItemName</columnFKColumnDisplay>")
         tbf.Append(        "<foreignKeyType>Explicit</foreignKeyType>")
         tbf.Append(      "</foreignKey>")
         tbf.Append(      "<applyDFKA>Y</applyDFKA>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">")
         tbf.Append(      "<columnName>ReppedOn</columnName>")
         tbf.Append(      "<columnUIName>Repped On</columnUIName>")
         tbf.Append(      "<columnType>Date</columnType>")
         tbf.Append(      "<columnDBType>datetime</columnDBType>")
         tbf.Append(      "<columnLengthSet></columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault>getdate()</columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnFormat>g</columnFormat>")
         tbf.Append(      "<columnDBFormat>g</columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(      "<applyDFKA>N</applyDFKA>")
         tbf.Append(    "</Column>")
         tbf.Append(  "</ColumnDefinition>")
         tbf.Append(  "<TableName>PartyReps</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableCodeName>PartyReps</TableCodeName>")
         tbf.Append(  "<TableAliasName>PartyReps_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseFASTPORT1</ConnectionName>")
         tbf.Append(  "<canCreateRecords Source=""Database"">Y</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""Database"">N</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""Database"">N</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">N</canViewRecords>")
         tbf.Append(  "<AppShortName>FASTPORT</AppShortName>")
         tbf.Append(  "<TableStoredProcPrefix>pFASTPORTPartyReps</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
