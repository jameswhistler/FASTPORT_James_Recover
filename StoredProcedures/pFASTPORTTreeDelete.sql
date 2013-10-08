if exists (select * from sysobjects where id = object_id(N'pFASTPORTTreeDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTTreeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Tree] table.
CREATE PROCEDURE pFASTPORTTreeDelete
        @pk_TreeID int
AS
BEGIN
    DELETE [dbo].[Tree]
    WHERE [TreeID] = @pk_TreeID
END

