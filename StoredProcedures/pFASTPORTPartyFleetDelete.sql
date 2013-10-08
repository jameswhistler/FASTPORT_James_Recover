if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyFleetDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyFleetDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyFleet] table.
CREATE PROCEDURE pFASTPORTPartyFleetDelete
        @pk_FleetID int
AS
BEGIN
    DELETE [dbo].[PartyFleet]
    WHERE [FleetID] = @pk_FleetID
END

