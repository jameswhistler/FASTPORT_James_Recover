if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyAddrDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyAddrDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyAddr] table.
CREATE PROCEDURE pFASTPORTPartyAddrDelete
        @pk_AddrID int
AS
BEGIN
    DELETE [dbo].[PartyAddr]
    WHERE [AddrID] = @pk_AddrID
END

