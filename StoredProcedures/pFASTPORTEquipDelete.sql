if exists (select * from sysobjects where id = object_id(N'pFASTPORTEquipDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTEquipDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Equip] table.
CREATE PROCEDURE pFASTPORTEquipDelete
        @pk_EquipID int
AS
BEGIN
    DELETE [dbo].[Equip]
    WHERE [EquipID] = @pk_EquipID
END

