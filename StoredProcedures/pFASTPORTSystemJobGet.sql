if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobGet') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SystemJob] table.
CREATE PROCEDURE pFASTPORTSystemJobGet
        @pk_JobID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SystemJob]
    WHERE [JobID] =@pk_JobID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [JobID],
        [SprocName],
        [HourToRun],
        [Param1],
        [Param2],
        [Param3],
        [Param4],
        [Param5],
        [Param6],
        CAST(BINARY_CHECKSUM([JobID],[SprocName],[HourToRun],[Param1],[Param2],[Param3],[Param4],[Param5],[Param6]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SystemJob]
    WHERE [JobID] =@pk_JobID
    SET NOCOUNT OFF
END

