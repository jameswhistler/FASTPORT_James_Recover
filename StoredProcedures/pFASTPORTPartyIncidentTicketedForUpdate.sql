if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentTicketedForUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentTicketedForUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyIncidentTicketedFor] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyIncidentTicketedForUpdate
    @pk_TicketedID int,
    @p_IncidentID int,
    @p_TicketedForID int,
    @p_Speed int,
    @p_Limit int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyIncidentTicketedFor] WHERE [TicketedID] = @pk_TicketedID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyIncidentTicketedFor]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyIncidentTicketedFor]
            SET 
            [IncidentID] = @p_IncidentID,
            [TicketedForID] = @p_TicketedForID,
            [Speed] = @p_Speed,
            [Limit] = @p_Limit
            WHERE [TicketedID] = @pk_TicketedID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([TicketedID],[IncidentID],[TicketedForID],[Speed],[Limit]) AS nvarchar(4000)) 
            FROM [dbo].[PartyIncidentTicketedFor] with (rowlock, holdlock)
            WHERE [TicketedID] = @pk_TicketedID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyIncidentTicketedFor]
                    SET 
                    [IncidentID] = @p_IncidentID,
                    [TicketedForID] = @p_TicketedForID,
                    [Speed] = @p_Speed,
                    [Limit] = @p_Limit
                    WHERE [TicketedID] = @pk_TicketedID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyIncidentTicketedFor]', 16, 1)

        END
END

