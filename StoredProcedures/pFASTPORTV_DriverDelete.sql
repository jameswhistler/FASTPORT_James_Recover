if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_DriverDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTV_DriverDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[v_Driver] table.
CREATE PROCEDURE pFASTPORTV_DriverDelete
        @pk_PartyID int
AS
BEGIN
    DELETE [dbo].[v_Driver]
    WHERE [PartyID] = @pk_PartyID
END

