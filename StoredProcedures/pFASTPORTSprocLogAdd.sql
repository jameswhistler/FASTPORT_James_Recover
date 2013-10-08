if exists (select * from sysobjects where id = object_id(N'pFASTPORTSprocLogAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTSprocLogAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SprocLog] table.
CREATE PROCEDURE pFASTPORTSprocLogAdd
    @p_LoggedAt datetime,
    @p_SprocName varchar(100),
    @p_Params varchar(255),
    @p_JoinString varchar(1000),
    @p_WhereString varchar(1000),
    @p_SortString varchar(1000),
    @p_SprocLogID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SprocLog]
        (
            [SprocName],
            [Params],
            [JoinString],
            [WhereString],
            [SortString]
        )
    VALUES
        (
             @p_SprocName,
             @p_Params,
             @p_JoinString,
             @p_WhereString,
             @p_SortString
        )

    SET @p_SprocLogID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_LoggedAt IS NOT NULL
        UPDATE [dbo].[SprocLog] SET [LoggedAt] = @p_LoggedAt WHERE [SprocLogID] = @p_SprocLogID_out

END

