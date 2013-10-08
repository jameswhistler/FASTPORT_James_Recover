if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdActivityAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTCarrierAdActivityAdd
    @p_AdID int,
    @p_PartyID int,
    @p_CarrierID int,
    @p_FavoriteAd bit,
    @p_FileAd bit,
    @p_Viewed bit,
    @p_FlowStepID int,
    @p_InstanceID int,
    @p_ExecutionID int,
    @p_LinkID int,
    @p_CreatedAt datetime,
    @p_CreatedByID int,
    @p_UpdatedAt datetime,
    @p_UpdatedByID int,
    @p_AdActivityID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CarrierAdActivity]
        (
            [AdID],
            [PartyID],
            [CarrierID],
            [FlowStepID],
            [InstanceID],
            [ExecutionID],
            [LinkID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_AdID,
             @p_PartyID,
             @p_CarrierID,
             @p_FlowStepID,
             @p_InstanceID,
             @p_ExecutionID,
             @p_LinkID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_AdActivityID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FavoriteAd IS NOT NULL
        UPDATE [dbo].[CarrierAdActivity] SET [FavoriteAd] = @p_FavoriteAd WHERE [AdActivityID] = @p_AdActivityID_out

    IF @p_FileAd IS NOT NULL
        UPDATE [dbo].[CarrierAdActivity] SET [FileAd] = @p_FileAd WHERE [AdActivityID] = @p_AdActivityID_out

    IF @p_Viewed IS NOT NULL
        UPDATE [dbo].[CarrierAdActivity] SET [Viewed] = @p_Viewed WHERE [AdActivityID] = @p_AdActivityID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[CarrierAdActivity] SET [CreatedAt] = @p_CreatedAt WHERE [AdActivityID] = @p_AdActivityID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[CarrierAdActivity] SET [UpdatedAt] = @p_UpdatedAt WHERE [AdActivityID] = @p_AdActivityID_out

END

