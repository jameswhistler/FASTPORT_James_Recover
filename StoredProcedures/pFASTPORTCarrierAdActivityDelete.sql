if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdActivityDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTCarrierAdActivityDelete
        @pk_AdActivityID int
AS
BEGIN
    DELETE [dbo].[CarrierAdActivity]
    WHERE [AdActivityID] = @pk_AdActivityID
END

