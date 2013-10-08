if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Party] table.
CREATE PROCEDURE pFASTPORTPartyDelete
        @pk_PartyID int
AS
BEGIN
    DELETE [dbo].[Party]
    WHERE [PartyID] = @pk_PartyID
END

