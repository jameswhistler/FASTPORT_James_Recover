if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_RolesGeneralGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_RolesGeneralGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_RolesGeneral] table.
CREATE PROCEDURE pFASTPORTV_RolesGeneralGet
        @pk_RoleID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_RolesGeneral]
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
        [RoleRank]
    FROM [dbo].[v_RolesGeneral]
    WHERE [RoleID] =@pk_RoleID
    SET NOCOUNT OFF
END

