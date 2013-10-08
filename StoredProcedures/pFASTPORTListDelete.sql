if exists (select * from sysobjects where id = object_id(N'pFASTPORTListDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTListDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[List] table.
CREATE PROCEDURE pFASTPORTListDelete
        @pk_ListID int
AS
BEGIN
    DELETE [dbo].[List]
    WHERE [ListID] = @pk_ListID
END

