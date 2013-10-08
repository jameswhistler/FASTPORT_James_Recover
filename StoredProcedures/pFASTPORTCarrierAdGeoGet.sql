if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGeoGet') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGeoGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CarrierAdGeo] table.
CREATE PROCEDURE pFASTPORTCarrierAdGeoGet
        @pk_AdGeoID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CarrierAdGeo]
    WHERE [AdGeoID] =@pk_AdGeoID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdGeoID],
        [AdID],
        [AdGeoTypeID],
        [OriginCityID],
        [OriginRadius],
        [DestRadius],
        [AdGeoNotes],
        CAST(BINARY_CHECKSUM([AdGeoID],[AdID],[AdGeoTypeID],[OriginCityID],[OriginRadius],[DestRadius],[AdGeoNotes]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CarrierAdGeo]
    WHERE [AdGeoID] =@pk_AdGeoID
    SET NOCOUNT OFF
END

