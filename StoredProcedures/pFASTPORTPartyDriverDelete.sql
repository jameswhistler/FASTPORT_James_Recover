if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDriverDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDriverDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyDriver] table.
CREATE PROCEDURE pFASTPORTPartyDriverDelete
        @pk_DriverID int
AS
BEGIN
    DELETE [dbo].[PartyDriver]
    WHERE [DriverID] = @pk_DriverID
END

