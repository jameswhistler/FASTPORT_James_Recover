if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CarrierAd] table.
CREATE PROCEDURE pFASTPORTCarrierAdDelete
        @pk_AdID int
AS
BEGIN
    DELETE [dbo].[CarrierAd]
    WHERE [AdID] = @pk_AdID
END

