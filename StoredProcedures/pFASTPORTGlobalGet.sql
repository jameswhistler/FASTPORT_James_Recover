if exists (select * from sysobjects where id = object_id(N'pFASTPORTGlobalGet') and sysstat & 0xf = 4) drop procedure pFASTPORTGlobalGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Global] table.
CREATE PROCEDURE pFASTPORTGlobalGet
        @pk_GlobalID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Global]
    WHERE [GlobalID] =@pk_GlobalID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [GlobalID],
        [GlobalName],
        [GlobalDescription],
        [GlobalFile],
        [GlobalValue],
        CAST(BINARY_CHECKSUM([GlobalID],[GlobalName],[GlobalDescription],[GlobalFile],[GlobalValue]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Global]
    WHERE [GlobalID] =@pk_GlobalID
    SET NOCOUNT OFF
END

