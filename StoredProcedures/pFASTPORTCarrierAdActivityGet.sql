if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdActivityGet') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTCarrierAdActivityGet
        @pk_AdActivityID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CarrierAdActivity]
    WHERE [AdActivityID] =@pk_AdActivityID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdActivityID],
        [AdID],
        [PartyID],
        [CarrierID],
        [FavoriteAd],
        [FileAd],
        [Viewed],
        [FlowStepID],
        [InstanceID],
        [ExecutionID],
        [LinkID],
        [CreatedAt],
        [CreatedByID],
        [UpdatedAt],
        [UpdatedByID],
        CAST(BINARY_CHECKSUM([AdActivityID],[AdID],[PartyID],[CarrierID],[FavoriteAd],[FileAd],[Viewed],[FlowStepID],[InstanceID],[ExecutionID],[LinkID],[CreatedAt],[CreatedByID],[UpdatedAt],[UpdatedByID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CarrierAdActivity]
    WHERE [AdActivityID] =@pk_AdActivityID
    SET NOCOUNT OFF
END

