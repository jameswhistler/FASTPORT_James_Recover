if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowStepGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowStepGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[FlowStep] table.
CREATE PROCEDURE pFASTPORTFlowStepGet
        @pk_FlowStepID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[FlowStep]
    WHERE [FlowStepID] =@pk_FlowStepID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [FlowStepID],
        [FlowCollectionID],
        [OverviewID],
        [StepRank],
        [RefName],
        [FlowStatus],
        [ReturnedDocStep],
        [DisableStep],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        [CopyFlowStepID],
        CAST(BINARY_CHECKSUM([FlowStepID],[FlowCollectionID],[OverviewID],[StepRank],[RefName],[FlowStatus],[ReturnedDocStep],[DisableStep],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyFlowStepID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[FlowStep]
    WHERE [FlowStepID] =@pk_FlowStepID
    SET NOCOUNT OFF
END

