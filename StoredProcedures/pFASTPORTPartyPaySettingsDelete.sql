if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyPaySettingsDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyPaySettingsDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyPaySettings] table.
CREATE PROCEDURE pFASTPORTPartyPaySettingsDelete
        @pk_PaySettingsID int
AS
BEGIN
    DELETE [dbo].[PartyPaySettings]
    WHERE [PaySettingsID] = @pk_PaySettingsID
END

