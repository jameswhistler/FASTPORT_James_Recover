if exists (select * from sysobjects where id = object_id(N'pFASTPORTAudit_CarrierAdActivityAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTAudit_CarrierAdActivityAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Audit_CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTAudit_CarrierAdActivityAdd
    @p_PreAdActivityLogID int,
    @p_AdActivityID int,
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
    @p_LoggedAt datetime,
    @p_AdActivityLogID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Audit_CarrierAdActivity]
        (
            [PreAdActivityLogID],
            [AdActivityID],
            [AdID],
            [PartyID],
            [CarrierID],
            [FlowStepID],
            [InstanceID],
            [ExecutionID],
            [LinkID],
            [CreatedAt],
            [CreatedByID],
            [UpdatedAt],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PreAdActivityLogID,
             @p_AdActivityID,
             @p_AdID,
             @p_PartyID,
             @p_CarrierID,
             @p_FlowStepID,
             @p_InstanceID,
             @p_ExecutionID,
             @p_LinkID,
             @p_CreatedAt,
             @p_CreatedByID,
             @p_UpdatedAt,
             @p_UpdatedByID
        )

    SET @p_AdActivityLogID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FavoriteAd IS NOT NULL
        UPDATE [dbo].[Audit_CarrierAdActivity] SET [FavoriteAd] = @p_FavoriteAd WHERE [AdActivityLogID] = @p_AdActivityLogID_out

    IF @p_FileAd IS NOT NULL
        UPDATE [dbo].[Audit_CarrierAdActivity] SET [FileAd] = @p_FileAd WHERE [AdActivityLogID] = @p_AdActivityLogID_out

    IF @p_Viewed IS NOT NULL
        UPDATE [dbo].[Audit_CarrierAdActivity] SET [Viewed] = @p_Viewed WHERE [AdActivityLogID] = @p_AdActivityLogID_out

    IF @p_LoggedAt IS NOT NULL
        UPDATE [dbo].[Audit_CarrierAdActivity] SET [LoggedAt] = @p_LoggedAt WHERE [AdActivityLogID] = @p_AdActivityLogID_out

END

