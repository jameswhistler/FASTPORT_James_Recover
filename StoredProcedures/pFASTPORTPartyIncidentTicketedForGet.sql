if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentTicketedForGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentTicketedForGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyIncidentTicketedFor] table.
CREATE PROCEDURE pFASTPORTPartyIncidentTicketedForGet
        @pk_TicketedID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyIncidentTicketedFor]
    WHERE [TicketedID] =@pk_TicketedID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [TicketedID],
        [IncidentID],
        [TicketedForID],
        [Speed],
        [Limit],
        CAST(BINARY_CHECKSUM([TicketedID],[IncidentID],[TicketedForID],[Speed],[Limit]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyIncidentTicketedFor]
    WHERE [TicketedID] =@pk_TicketedID
    SET NOCOUNT OFF
END

