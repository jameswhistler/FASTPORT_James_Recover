if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRollupGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRollupGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyRollup] table.
CREATE PROCEDURE pFASTPORTPartyRollupGet
        @pk_RollupID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyRollup]
    WHERE [RollupID] =@pk_RollupID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [RollupID],
        [ParentID],
        [ChildID],
        [FlowStepID],
        [StartDate],
        [EndDate],
        [DefaultParty],
        [DefaultSigner],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([RollupID],[ParentID],[ChildID],[FlowStepID],[StartDate],[EndDate],[DefaultParty],[DefaultSigner],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyRollup]
    WHERE [RollupID] =@pk_RollupID
    SET NOCOUNT OFF
END

