if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyExperienceUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyExperienceUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyExperience] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyExperienceUpdate
    @pk_PartyExperienceID int,
    @p_HistoryID int,
    @p_PartyID int,
    @p_AdID int,
    @p_ExperienceParentID int,
    @p_ExperienceID int,
    @p_ExperienceNotes varchar(1000),
    @p_FocusedOn float,
    @p_LockFocus bit,
    @p_Importance int,
    @p_ExperienceRank int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyExperience] WHERE [PartyExperienceID] = @pk_PartyExperienceID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyExperience]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyExperience]
            SET 
            [HistoryID] = @p_HistoryID,
            [PartyID] = @p_PartyID,
            [AdID] = @p_AdID,
            [ExperienceParentID] = @p_ExperienceParentID,
            [ExperienceID] = @p_ExperienceID,
            [ExperienceNotes] = @p_ExperienceNotes,
            [FocusedOn] = @p_FocusedOn,
            [LockFocus] = @p_LockFocus,
            [Importance] = @p_Importance,
            [ExperienceRank] = @p_ExperienceRank
            WHERE [PartyExperienceID] = @pk_PartyExperienceID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([PartyExperienceID],[HistoryID],[PartyID],[AdID],[ExperienceParentID],[ExperienceID],[ExperienceNotes],[FocusedOn],[LockFocus],[Importance],[ExperienceRank]) AS nvarchar(4000)) 
            FROM [dbo].[PartyExperience] with (rowlock, holdlock)
            WHERE [PartyExperienceID] = @pk_PartyExperienceID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyExperience]
                    SET 
                    [HistoryID] = @p_HistoryID,
                    [PartyID] = @p_PartyID,
                    [AdID] = @p_AdID,
                    [ExperienceParentID] = @p_ExperienceParentID,
                    [ExperienceID] = @p_ExperienceID,
                    [ExperienceNotes] = @p_ExperienceNotes,
                    [FocusedOn] = @p_FocusedOn,
                    [LockFocus] = @p_LockFocus,
                    [Importance] = @p_Importance,
                    [ExperienceRank] = @p_ExperienceRank
                    WHERE [PartyExperienceID] = @pk_PartyExperienceID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyExperience]', 16, 1)

        END
END

