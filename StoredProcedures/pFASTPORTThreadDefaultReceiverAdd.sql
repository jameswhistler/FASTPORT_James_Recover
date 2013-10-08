if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadDefaultReceiverAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadDefaultReceiverAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ThreadDefaultReceiver] table.
CREATE PROCEDURE pFASTPORTThreadDefaultReceiverAdd
    @p_ThreadID int,
    @p_PartyTypeID int,
    @p_PartyID int,
    @p_RoleID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_DefaultReceiverID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[ThreadDefaultReceiver]
        (
            [ThreadID],
            [PartyTypeID],
            [PartyID],
            [RoleID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_ThreadID,
             @p_PartyTypeID,
             @p_PartyID,
             @p_RoleID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_DefaultReceiverID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[ThreadDefaultReceiver] SET [CreatedAt] = @p_CreatedAt WHERE [DefaultReceiverID] = @p_DefaultReceiverID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[ThreadDefaultReceiver] SET [UpdatedAt] = @p_UpdatedAt WHERE [DefaultReceiverID] = @p_DefaultReceiverID_out

END

