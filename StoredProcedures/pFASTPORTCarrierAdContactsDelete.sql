if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdContactsDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdContactsDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CarrierAdContacts] table.
CREATE PROCEDURE pFASTPORTCarrierAdContactsDelete
        @pk_AdContactsID int
AS
BEGIN
    DELETE [dbo].[CarrierAdContacts]
    WHERE [AdContactsID] = @pk_AdContactsID
END

