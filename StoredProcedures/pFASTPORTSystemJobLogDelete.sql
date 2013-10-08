if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobLogDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobLogDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SystemJobLog] table.
CREATE PROCEDURE pFASTPORTSystemJobLogDelete
        @pk_JobLogID int
AS
BEGIN
    DELETE [dbo].[SystemJobLog]
    WHERE [JobLogID] = @pk_JobLogID
END

