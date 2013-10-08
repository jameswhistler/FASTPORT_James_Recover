if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyCarrierDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyCarrierDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyCarrier] table.
CREATE PROCEDURE pFASTPORTPartyCarrierDelete
        @pk_CarrierID int
AS
BEGIN
    DELETE [dbo].[PartyCarrier]
    WHERE [CarrierID] = @pk_CarrierID
END

