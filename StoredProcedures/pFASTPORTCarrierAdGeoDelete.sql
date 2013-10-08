if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGeoDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGeoDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CarrierAdGeo] table.
CREATE PROCEDURE pFASTPORTCarrierAdGeoDelete
        @pk_AdGeoID int
AS
BEGIN
    DELETE [dbo].[CarrierAdGeo]
    WHERE [AdGeoID] = @pk_AdGeoID
END

