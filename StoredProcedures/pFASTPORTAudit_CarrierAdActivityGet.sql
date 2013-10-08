if exists (select * from sysobjects where id = object_id(N'pFASTPORTAudit_CarrierAdActivityGet') and sysstat & 0xf = 4) drop procedure pFASTPORTAudit_CarrierAdActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Audit_CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTAudit_CarrierAdActivityGet
        @pk_AdActivityLogID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Audit_CarrierAdActivity]
    WHERE [AdActivityLogID] =@pk_AdActivityLogID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdActivityLogID],
        [PreAdActivityLogID],
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
        [LoggedAt],
        CAST(BINARY_CHECKSUM([AdActivityLogID],[PreAdActivityLogID],[AdActivityID],[AdID],[PartyID],[CarrierID],[FavoriteAd],[FileAd],[Viewed],[FlowStepID],[InstanceID],[ExecutionID],[LinkID],[CreatedAt],[CreatedByID],[UpdatedAt],[UpdatedByID],[LoggedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Audit_CarrierAdActivity]
    WHERE [AdActivityLogID] =@pk_AdActivityLogID
    SET NOCOUNT OFF
END

