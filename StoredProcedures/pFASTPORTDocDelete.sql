if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTDocDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Doc] table.
CREATE PROCEDURE pFASTPORTDocDelete
        @pk_DocID int
AS
BEGIN
    DELETE [dbo].[Doc]
    WHERE [DocID] = @pk_DocID
END

