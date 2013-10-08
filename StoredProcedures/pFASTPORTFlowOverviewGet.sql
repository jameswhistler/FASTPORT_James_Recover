if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowOverviewGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowOverviewGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[FlowOverview] table.
CREATE PROCEDURE pFASTPORTFlowOverviewGet
        @pk_OverviewID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[FlowOverview]
    WHERE [OverviewID] =@pk_OverviewID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [OverviewID],
        [FlowID],
        [Overview],
        [OverviewRank],
        [OveriewTypeID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([OverviewID],[FlowID],[Overview],[OverviewRank],[OveriewTypeID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[FlowOverview]
    WHERE [OverviewID] =@pk_OverviewID
    SET NOCOUNT OFF
END

