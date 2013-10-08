if exists (select * from sysobjects where id = object_id(N'pFASTPORTListAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTListAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[List] table.
CREATE PROCEDURE pFASTPORTListAdd
    @p_ListType varchar(50),
    @p_ListName varchar(50),
    @p_ListRank int,
    @p_ListValue int,
    @p_ListID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[List]
        (
            [ListType],
            [ListName],
            [ListValue]
        )
    VALUES
        (
             @p_ListType,
             @p_ListName,
             @p_ListValue
        )

    SET @p_ListID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ListRank IS NOT NULL
        UPDATE [dbo].[List] SET [ListRank] = @p_ListRank WHERE [ListID] = @p_ListID_out

END

