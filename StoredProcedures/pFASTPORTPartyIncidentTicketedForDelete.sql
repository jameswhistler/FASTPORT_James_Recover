if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentTicketedForDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentTicketedForDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyIncidentTicketedFor] table.
CREATE PROCEDURE pFASTPORTPartyIncidentTicketedForDelete
        @pk_TicketedID int
AS
BEGIN
    DELETE [dbo].[PartyIncidentTicketedFor]
    WHERE [TicketedID] = @pk_TicketedID
END

