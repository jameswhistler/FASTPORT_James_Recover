if exists (select * from sysobjects where id = object_id(N'pFASTPORTRoleAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTRoleAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Role] table.
CREATE PROCEDURE pFASTPORTRoleAdd
    @p_GeneralRoleID int,
    @p_RoleTypeID int,
    @p_Role varchar(50),
    @p_RoleDescription varchar(255),
    @p_RoleRank int,
    @p_RoleID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Role]
        (
            [GeneralRoleID],
            [RoleTypeID],
            [Role],
            [RoleDescription]
        )
    VALUES
        (
             @p_GeneralRoleID,
             @p_RoleTypeID,
             @p_Role,
             @p_RoleDescription
        )

    SET @p_RoleID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_RoleRank IS NOT NULL
        UPDATE [dbo].[Role] SET [RoleRank] = @p_RoleRank WHERE [RoleID] = @p_RoleID_out

END

