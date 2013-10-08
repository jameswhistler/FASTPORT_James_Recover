if exists (select * from sysobjects where id = object_id(N'pFASTPORTRoleDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTRoleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Role] table.
CREATE PROCEDURE pFASTPORTRoleDelete
        @pk_RoleID int
AS
BEGIN
    DELETE [dbo].[Role]
    WHERE [RoleID] = @pk_RoleID
END

