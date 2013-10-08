if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocPageDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTDocPageDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[DocPage] table.
CREATE PROCEDURE pFASTPORTDocPageDelete
        @pk_PageID int
AS
BEGIN
    DELETE [dbo].[DocPage]
    WHERE [PageID] = @pk_PageID
END

