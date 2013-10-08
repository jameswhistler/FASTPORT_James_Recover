if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyFleetCircleDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyFleetCircleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyFleetCircle] table.
CREATE PROCEDURE pFASTPORTPartyFleetCircleDelete
        @pk_FleetCircleID int
AS
BEGIN
    DELETE [dbo].[PartyFleetCircle]
    WHERE [FleetCircleID] = @pk_FleetCircleID
END

