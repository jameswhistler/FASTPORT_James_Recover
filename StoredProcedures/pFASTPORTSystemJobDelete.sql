if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SystemJob] table.
CREATE PROCEDURE pFASTPORTSystemJobDelete
        @pk_JobID int
AS
BEGIN
    DELETE [dbo].[SystemJob]
    WHERE [JobID] = @pk_JobID
END

