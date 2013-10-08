if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInActivityAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CheckInActivity] table.
CREATE PROCEDURE pFASTPORTCheckInActivityAdd
    @p_CheckInID int,
    @p_ActivityID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CheckInActivityID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CheckInActivity]
        (
            [CheckInID],
            [ActivityID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_CheckInID,
             @p_ActivityID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_CheckInActivityID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[CheckInActivity] SET [CreatedAt] = @p_CreatedAt WHERE [CheckInActivityID] = @p_CheckInActivityID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[CheckInActivity] SET [UpdatedAt] = @p_UpdatedAt WHERE [CheckInActivityID] = @p_CheckInActivityID_out

END

