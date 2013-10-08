if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInShareAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInShareAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CheckInShare] table.
CREATE PROCEDURE pFASTPORTCheckInShareAdd
    @p_CheckInID int,
    @p_PartyID int,
    @p_FollowUntilComplete bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CheckInShareID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CheckInShare]
        (
            [CheckInID],
            [PartyID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_CheckInID,
             @p_PartyID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_CheckInShareID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FollowUntilComplete IS NOT NULL
        UPDATE [dbo].[CheckInShare] SET [FollowUntilComplete] = @p_FollowUntilComplete WHERE [CheckInShareID] = @p_CheckInShareID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[CheckInShare] SET [CreatedAt] = @p_CreatedAt WHERE [CheckInShareID] = @p_CheckInShareID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[CheckInShare] SET [UpdatedAt] = @p_UpdatedAt WHERE [CheckInShareID] = @p_CheckInShareID_out

END

