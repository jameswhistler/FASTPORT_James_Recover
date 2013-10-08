if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGeoAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGeoAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CarrierAdGeo] table.
CREATE PROCEDURE pFASTPORTCarrierAdGeoAdd
    @p_AdID int,
    @p_AdGeoTypeID int,
    @p_OriginCityID int,
    @p_OriginRadius int,
    @p_DestRadius int,
    @p_AdGeoNotes varchar(2000),
    @p_AdGeoID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CarrierAdGeo]
        (
            [AdID],
            [AdGeoTypeID],
            [OriginCityID],
            [AdGeoNotes]
        )
    VALUES
        (
             @p_AdID,
             @p_AdGeoTypeID,
             @p_OriginCityID,
             @p_AdGeoNotes
        )

    SET @p_AdGeoID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_OriginRadius IS NOT NULL
        UPDATE [dbo].[CarrierAdGeo] SET [OriginRadius] = @p_OriginRadius WHERE [AdGeoID] = @p_AdGeoID_out

    IF @p_DestRadius IS NOT NULL
        UPDATE [dbo].[CarrierAdGeo] SET [DestRadius] = @p_DestRadius WHERE [AdGeoID] = @p_AdGeoID_out

END

