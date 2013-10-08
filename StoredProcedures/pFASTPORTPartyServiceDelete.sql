if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyServiceDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyServiceDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyService] table.
CREATE PROCEDURE pFASTPORTPartyServiceDelete
        @pk_PartyServiceID int
AS
BEGIN
    DELETE [dbo].[PartyService]
    WHERE [PartyServiceID] = @pk_PartyServiceID
END

