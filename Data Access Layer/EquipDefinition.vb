﻿Namespace FASTPORT.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="EquipTable">FASTPORT.EquipTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="EquipTable"></seealso>

Public Class EquipDefinition

#Region "Definition (XML) for EquipDefinition table"
	'Next 499 lines contain Table Definition (XML) for table "EquipDefinition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="EquipTable"></see>
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
         tbf.Append(      "<columnName>EquipID</columnName>")
         tbf.Append(      "<columnUIName>Equipment</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>Y</columnIndex>")
         tbf.Append(      "<columnUnique>Y</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>Y</columnPK>")
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
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_Equip_Party</columnFKName>")
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
         tbf.Append(      "<columnName>OwnerID</columnName>")
         tbf.Append(      "<columnUIName>Owner</columnUIName>")
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
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_Equip_Party1</columnFKName>")
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
         tbf.Append(    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">")
         tbf.Append(      "<columnName>YearID</columnName>")
         tbf.Append(      "<columnUIName>Year</columnUIName>")
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
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>FK_Equip_Tree</columnFKName>")
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
         tbf.Append(    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">")
         tbf.Append(      "<columnName>Make</columnName>")
         tbf.Append(      "<columnUIName>Make</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
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
         tbf.Append(    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">")
         tbf.Append(      "<columnName>Model</columnName>")
         tbf.Append(      "<columnUIName>Model</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
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
         tbf.Append(    "<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">")
         tbf.Append(      "<columnName>Axels</columnName>")
         tbf.Append(      "<columnUIName>Axels</columnUIName>")
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
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">")
         tbf.Append(      "<columnName>UnladenWeight</columnName>")
         tbf.Append(      "<columnUIName>Unladen Weight</columnUIName>")
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
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">")
         tbf.Append(      "<columnName>HeightFeet</columnName>")
         tbf.Append(      "<columnUIName>Height Feet</columnUIName>")
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
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">")
         tbf.Append(      "<columnName>HeightInches</columnName>")
         tbf.Append(      "<columnUIName>Height Inches</columnUIName>")
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
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(    "<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">")
         tbf.Append(      "<columnName>PurchasedDate</columnName>")
         tbf.Append(      "<columnUIName>Purchased Date</columnUIName>")
         tbf.Append(      "<columnType>Date</columnType>")
         tbf.Append(      "<columnDBType>datetime</columnDBType>")
         tbf.Append(      "<columnLengthSet></columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
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
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(    "<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">")
         tbf.Append(      "<columnName>PurchasedValue</columnName>")
         tbf.Append(      "<columnUIName>Purchased Value</columnUIName>")
         tbf.Append(      "<columnType>Currency</columnType>")
         tbf.Append(      "<columnDBType>money</columnDBType>")
         tbf.Append(      "<columnLengthSet>19.4</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnFormat>C</columnFormat>")
         tbf.Append(      "<columnDBFormat>C</columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
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
         tbf.Append(  "<TableName>Equip</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableCodeName>Equip</TableCodeName>")
         tbf.Append(  "<TableAliasName>Equip_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseFASTPORT1</ConnectionName>")
         tbf.Append(  "<canCreateRecords Source=""Database"">Y</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""Database"">Y</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""Database"">Y</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">Y</canViewRecords>")
         tbf.Append(  "<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>")
         tbf.Append(  "<AppShortName>FASTPORT</AppShortName>")
         tbf.Append(  "<TableStoredProcPrefix>pFASTPORTEquip</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
