if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRoleAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRoleAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyRole] table.
CREATE PROCEDURE pFASTPORTPartyRoleAdd
    @p_RollupID int,
    @p_PartyID int,
    @p_RoleID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PartyRoleID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyRole]
        (
            [RollupID],
            [PartyID],
            [RoleID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_RollupID,
             @p_PartyID,
             @p_RoleID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_PartyRoleID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyRole] SET [CreatedAt] = @p_CreatedAt WHERE [PartyRoleID] = @p_PartyRoleID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyRole] SET [UpdatedAt] = @p_UpdatedAt WHERE [PartyRoleID] = @p_PartyRoleID_out

END

