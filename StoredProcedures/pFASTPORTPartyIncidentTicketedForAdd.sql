if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentTicketedForAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentTicketedForAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyIncidentTicketedFor] table.
CREATE PROCEDURE pFASTPORTPartyIncidentTicketedForAdd
    @p_IncidentID int,
    @p_TicketedForID int,
    @p_Speed int,
    @p_Limit int,
    @p_TicketedID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyIncidentTicketedFor]
        (
            [IncidentID],
            [TicketedForID],
            [Speed],
            [Limit]
        )
    VALUES
        (
             @p_IncidentID,
             @p_TicketedForID,
             @p_Speed,
             @p_Limit
        )

    SET @p_TicketedID_out = SCOPE_IDENTITY()

END

