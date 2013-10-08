if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_ServicesGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_ServicesGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Services] table.
CREATE PROCEDURE pFASTPORTV_ServicesGet
        @pk_ServiceID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Services]
    WHERE [ServiceID] =@pk_ServiceID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ServiceID],
        [ServiceContextID],
        [ServiceTypeID],
        [ServiceType],
        [ServiceImage],
        [FastportService],
        [ServiceRequired],
        [Cost],
        [ServiceName],
        [ServiceDescription],
        [Fee],
        [Units],
        [DurationID],
        [Duration],
        [ServiceRank],
        [SubscriptionYesNo]
    FROM [dbo].[v_Services]
    WHERE [ServiceID] =@pk_ServiceID
    SET NOCOUNT OFF
END

