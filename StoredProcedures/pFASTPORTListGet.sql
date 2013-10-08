if exists (select * from sysobjects where id = object_id(N'pFASTPORTListGet') and sysstat & 0xf = 4) drop procedure pFASTPORTListGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[List] table.
CREATE PROCEDURE pFASTPORTListGet
        @pk_ListID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[List]
    WHERE [ListID] =@pk_ListID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ListID],
        [ListType],
        [ListName],
        [ListRank],
        [ListValue],
        CAST(BINARY_CHECKSUM([ListID],[ListType],[ListName],[ListRank],[ListValue]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[List]
    WHERE [ListID] =@pk_ListID
    SET NOCOUNT OFF
END

