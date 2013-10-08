if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowOverviewAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowOverviewAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[FlowOverview] table.
CREATE PROCEDURE pFASTPORTFlowOverviewAdd
    @p_FlowID int,
    @p_Overview varchar(50),
    @p_OverviewRank int,
    @p_OveriewTypeID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_OverviewID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[FlowOverview]
        (
            [FlowID],
            [Overview],
            [OveriewTypeID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_FlowID,
             @p_Overview,
             @p_OveriewTypeID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_OverviewID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_OverviewRank IS NOT NULL
        UPDATE [dbo].[FlowOverview] SET [OverviewRank] = @p_OverviewRank WHERE [OverviewID] = @p_OverviewID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[FlowOverview] SET [CreatedAt] = @p_CreatedAt WHERE [OverviewID] = @p_OverviewID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[FlowOverview] SET [UpdatedAt] = @p_UpdatedAt WHERE [OverviewID] = @p_OverviewID_out

END

