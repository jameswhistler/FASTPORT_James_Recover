﻿if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdContactsUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdContactsUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CarrierAdContacts] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCarrierAdContactsUpdate
    @pk_AdContactsID int,
    @p_AdID int,
    @p_ContactTypeID int,
    @p_RoleID int,
    @p_PartyID int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CarrierAdContacts] WHERE [AdContactsID] = @pk_AdContactsID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CarrierAdContacts]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CarrierAdContacts]
            SET 
            [AdID] = @p_AdID,
            [ContactTypeID] = @p_ContactTypeID,
            [RoleID] = @p_RoleID,
            [PartyID] = @p_PartyID
            WHERE [AdContactsID] = @pk_AdContactsID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AdContactsID],[AdID],[ContactTypeID],[RoleID],[PartyID]) AS nvarchar(4000)) 
            FROM [dbo].[CarrierAdContacts] with (rowlock, holdlock)
            WHERE [AdContactsID] = @pk_AdContactsID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CarrierAdContacts]
                    SET 
                    [AdID] = @p_AdID,
                    [ContactTypeID] = @p_ContactTypeID,
                    [RoleID] = @p_RoleID,
                    [PartyID] = @p_PartyID
                    WHERE [AdContactsID] = @pk_AdContactsID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CarrierAdContacts]', 16, 1)

        END
END

