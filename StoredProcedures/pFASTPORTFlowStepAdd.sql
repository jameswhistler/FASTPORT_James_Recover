if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowStepAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowStepAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[FlowStep] table.
CREATE PROCEDURE pFASTPORTFlowStepAdd
    @p_FlowCollectionID int,
    @p_OverviewID int,
    @p_StepRank int,
    @p_RefName varchar(50),
    @p_FlowStatus varchar(50),
    @p_ReturnedDocStep bit,
    @p_DisableStep bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CopyFlowStepID int,
    @p_FlowStepID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[FlowStep]
        (
            [FlowCollectionID],
            [OverviewID],
            [RefName],
            [FlowStatus],
            [CreatedByID],
            [UpdatedByID],
            [CopyFlowStepID]
        )
    VALUES
        (
             @p_FlowCollectionID,
             @p_OverviewID,
             @p_RefName,
             @p_FlowStatus,
             @p_CreatedByID,
             @p_UpdatedByID,
             @p_CopyFlowStepID
        )

    SET @p_FlowStepID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_StepRank IS NOT NULL
        UPDATE [dbo].[FlowStep] SET [StepRank] = @p_StepRank WHERE [FlowStepID] = @p_FlowStepID_out

    IF @p_ReturnedDocStep IS NOT NULL
        UPDATE [dbo].[FlowStep] SET [ReturnedDocStep] = @p_ReturnedDocStep WHERE [FlowStepID] = @p_FlowStepID_out

    IF @p_DisableStep IS NOT NULL
        UPDATE [dbo].[FlowStep] SET [DisableStep] = @p_DisableStep WHERE [FlowStepID] = @p_FlowStepID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[FlowStep] SET [CreatedAt] = @p_CreatedAt WHERE [FlowStepID] = @p_FlowStepID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[FlowStep] SET [UpdatedAt] = @p_UpdatedAt WHERE [FlowStepID] = @p_FlowStepID_out

END

