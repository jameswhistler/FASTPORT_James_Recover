if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocTreeDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTDocTreeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[DocTree] table.
CREATE PROCEDURE pFASTPORTDocTreeDelete
        @pk_DocTreeID int
AS
BEGIN
    DELETE [dbo].[DocTree]
    WHERE [DocTreeID] = @pk_DocTreeID
END

