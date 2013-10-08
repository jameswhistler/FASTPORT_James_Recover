if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_GeoCountryGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_GeoCountryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_GeoCountry] table.
CREATE PROCEDURE pFASTPORTV_GeoCountryGet
        @pk_CountryID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_GeoCountry]
    WHERE [CountryID] =@pk_CountryID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CountryID],
        [Country],
        [CountryAbbr]
    FROM [dbo].[v_GeoCountry]
    WHERE [CountryID] =@pk_CountryID
    SET NOCOUNT OFF
END

