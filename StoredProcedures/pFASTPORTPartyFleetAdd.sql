if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyFleetAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyFleetAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyFleet] table.
CREATE PROCEDURE pFASTPORTPartyFleetAdd
    @p_MyPartyID int,
    @p_MyBuddyID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_FleetID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyFleet]
        (
            [MyPartyID],
            [MyBuddyID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_MyPartyID,
             @p_MyBuddyID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_FleetID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyFleet] SET [CreatedAt] = @p_CreatedAt WHERE [FleetID] = @p_FleetID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyFleet] SET [UpdatedAt] = @p_UpdatedAt WHERE [FleetID] = @p_FleetID_out

END

