if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRollupDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRollupDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyRollup] table.
CREATE PROCEDURE pFASTPORTPartyRollupDelete
        @pk_RollupID int
AS
BEGIN
    DELETE [dbo].[PartyRollup]
    WHERE [RollupID] = @pk_RollupID
END

