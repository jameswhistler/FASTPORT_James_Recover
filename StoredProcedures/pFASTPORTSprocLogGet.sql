if exists (select * from sysobjects where id = object_id(N'pFASTPORTSprocLogGet') and sysstat & 0xf = 4) drop procedure pFASTPORTSprocLogGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SprocLog] table.
CREATE PROCEDURE pFASTPORTSprocLogGet
        @pk_SprocLogID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SprocLog]
    WHERE [SprocLogID] =@pk_SprocLogID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [SprocLogID],
        [LoggedAt],
        [SprocName],
        [Params],
        [JoinString],
        [WhereString],
        [SortString],
        CAST(BINARY_CHECKSUM([SprocLogID],[LoggedAt],[SprocName],[Params],[JoinString],[WhereString],[SortString]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SprocLog]
    WHERE [SprocLogID] =@pk_SprocLogID
    SET NOCOUNT OFF
END

