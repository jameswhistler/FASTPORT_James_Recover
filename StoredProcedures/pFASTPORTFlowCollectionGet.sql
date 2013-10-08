if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowCollectionGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowCollectionGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[FlowCollection] table.
CREATE PROCEDURE pFASTPORTFlowCollectionGet
        @pk_FlowCollectionID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[FlowCollection]
    WHERE [FlowCollectionID] =@pk_FlowCollectionID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [FlowCollectionID],
        [FlowID],
        [CollectionName],
        [CollectionRank],
        [DefaultURLParams],
        [GoAction],
        [StartingStepID],
        [ThreadID],
        [CollectionDescription],
        [CollectionImage],
        [CopyFlowCollectionID],
        [RelatedToID],
        CAST(BINARY_CHECKSUM([FlowCollectionID],[FlowID],[CollectionName],[CollectionRank],[DefaultURLParams],[GoAction],[StartingStepID],[ThreadID],[CollectionDescription],[CollectionImage],[CopyFlowCollectionID],[RelatedToID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[FlowCollection]
    WHERE [FlowCollectionID] =@pk_FlowCollectionID
    SET NOCOUNT OFF
END

