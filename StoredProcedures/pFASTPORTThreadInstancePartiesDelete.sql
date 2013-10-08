if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstancePartiesDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstancePartiesDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ThreadInstanceParties] table.
CREATE PROCEDURE pFASTPORTThreadInstancePartiesDelete
        @pk_InstancePartyID int
AS
BEGIN
    DELETE [dbo].[ThreadInstanceParties]
    WHERE [InstancePartyID] = @pk_InstancePartyID
END

