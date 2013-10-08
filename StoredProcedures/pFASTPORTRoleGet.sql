if exists (select * from sysobjects where id = object_id(N'pFASTPORTRoleGet') and sysstat & 0xf = 4) drop procedure pFASTPORTRoleGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Role] table.
CREATE PROCEDURE pFASTPORTRoleGet
        @pk_RoleID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Role]
    WHERE [RoleID] =@pk_RoleID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [RoleID],
        [GeneralRoleID],
        [RoleTypeID],
        [Role],
        [RoleDescription],
        [RoleRank],
        CAST(BINARY_CHECKSUM([RoleID],[GeneralRoleID],[RoleTypeID],[Role],[RoleDescription],[RoleRank]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Role]
    WHERE [RoleID] =@pk_RoleID
    SET NOCOUNT OFF
END

