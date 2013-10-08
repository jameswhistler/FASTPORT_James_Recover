if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Thread] table.
CREATE PROCEDURE pFASTPORTThreadDelete
        @pk_ThreadID int
AS
BEGIN
    DELETE [dbo].[Thread]
    WHERE [ThreadID] = @pk_ThreadID
END

