if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstancePartiesAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstancePartiesAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ThreadInstanceParties] table.
CREATE PROCEDURE pFASTPORTThreadInstancePartiesAdd
    @p_InstanceID int,
    @p_PartyTypeID int,
    @p_UserID int,
    @p_PartyID int,
    @p_RoleID int,
    @p_FreeHand varchar(1000),
    @p_ThreadPriorityID int,
    @p_Email bit,
    @p_MobileText bit,
    @p_Fax bit,
    @p_InstantMessage bit,
    @p_BoardOnly bit,
    @p_FileInstance bit,
    @p_OneTime int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_InstancePartyID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[ThreadInstanceParties]
        (
            [InstanceID],
            [PartyTypeID],
            [UserID],
            [PartyID],
            [RoleID],
            [FreeHand],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_InstanceID,
             @p_PartyTypeID,
             @p_UserID,
             @p_PartyID,
             @p_RoleID,
             @p_FreeHand,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_InstancePartyID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ThreadPriorityID IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [ThreadPriorityID] = @p_ThreadPriorityID WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_Email IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [Email] = @p_Email WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_MobileText IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [MobileText] = @p_MobileText WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_Fax IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [Fax] = @p_Fax WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_InstantMessage IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [InstantMessage] = @p_InstantMessage WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_BoardOnly IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [BoardOnly] = @p_BoardOnly WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_FileInstance IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [FileInstance] = @p_FileInstance WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_OneTime IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [OneTime] = @p_OneTime WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [CreatedAt] = @p_CreatedAt WHERE [InstancePartyID] = @p_InstancePartyID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceParties] SET [UpdatedAt] = @p_UpdatedAt WHERE [InstancePartyID] = @p_InstancePartyID_out

END

