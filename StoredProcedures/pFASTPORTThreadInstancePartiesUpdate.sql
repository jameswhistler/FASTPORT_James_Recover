if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstancePartiesUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstancePartiesUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[ThreadInstanceParties] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTThreadInstancePartiesUpdate
    @pk_InstancePartyID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[ThreadInstanceParties] WHERE [InstancePartyID] = @pk_InstancePartyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[ThreadInstanceParties]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[ThreadInstanceParties]
            SET 
            [InstanceID] = @p_InstanceID,
            [PartyTypeID] = @p_PartyTypeID,
            [UserID] = @p_UserID,
            [PartyID] = @p_PartyID,
            [RoleID] = @p_RoleID,
            [FreeHand] = @p_FreeHand,
            [ThreadPriorityID] = @p_ThreadPriorityID,
            [Email] = @p_Email,
            [MobileText] = @p_MobileText,
            [Fax] = @p_Fax,
            [InstantMessage] = @p_InstantMessage,
            [BoardOnly] = @p_BoardOnly,
            [FileInstance] = @p_FileInstance,
            [OneTime] = @p_OneTime,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [InstancePartyID] = @pk_InstancePartyID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([InstancePartyID],[InstanceID],[PartyTypeID],[UserID],[PartyID],[RoleID],[FreeHand],[ThreadPriorityID],[Email],[MobileText],[Fax],[InstantMessage],[BoardOnly],[FileInstance],[OneTime],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[ThreadInstanceParties] with (rowlock, holdlock)
            WHERE [InstancePartyID] = @pk_InstancePartyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[ThreadInstanceParties]
                    SET 
                    [InstanceID] = @p_InstanceID,
                    [PartyTypeID] = @p_PartyTypeID,
                    [UserID] = @p_UserID,
                    [PartyID] = @p_PartyID,
                    [RoleID] = @p_RoleID,
                    [FreeHand] = @p_FreeHand,
                    [ThreadPriorityID] = @p_ThreadPriorityID,
                    [Email] = @p_Email,
                    [MobileText] = @p_MobileText,
                    [Fax] = @p_Fax,
                    [InstantMessage] = @p_InstantMessage,
                    [BoardOnly] = @p_BoardOnly,
                    [FileInstance] = @p_FileInstance,
                    [OneTime] = @p_OneTime,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [InstancePartyID] = @pk_InstancePartyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[ThreadInstanceParties]', 16, 1)

        END
END

