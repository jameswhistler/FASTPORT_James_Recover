if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyFleetCircleAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyFleetCircleAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyFleetCircle] table.
CREATE PROCEDURE pFASTPORTPartyFleetCircleAdd
    @p_FleetID int,
    @p_CircleID int,
    @p_StatusID int,
    @p_InstanceID int,
    @p_AllowEditID bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_FleetCircleID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyFleetCircle]
        (
            [FleetID],
            [CircleID],
            [StatusID],
            [InstanceID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_FleetID,
             @p_CircleID,
             @p_StatusID,
             @p_InstanceID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_FleetCircleID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_AllowEditID IS NOT NULL
        UPDATE [dbo].[PartyFleetCircle] SET [AllowEditID] = @p_AllowEditID WHERE [FleetCircleID] = @p_FleetCircleID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyFleetCircle] SET [CreatedAt] = @p_CreatedAt WHERE [FleetCircleID] = @p_FleetCircleID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyFleetCircle] SET [UpdatedAt] = @p_UpdatedAt WHERE [FleetCircleID] = @p_FleetCircleID_out

END

