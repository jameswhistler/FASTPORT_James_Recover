if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdLinkDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdLinkDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CarrierAdLink] table.
CREATE PROCEDURE pFASTPORTCarrierAdLinkDelete
        @pk_LinkID int
AS
BEGIN
    DELETE [dbo].[CarrierAdLink]
    WHERE [LinkID] = @pk_LinkID
END

