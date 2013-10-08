if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdActivityUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdActivityUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CarrierAdActivity] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCarrierAdActivityUpdate
    @pk_AdActivityID int,
    @p_AdID int,
    @p_PartyID int,
    @p_CarrierID int,
    @p_FavoriteAd bit,
    @p_FileAd bit,
    @p_Viewed bit,
    @p_FlowStepID int,
    @p_InstanceID int,
    @p_ExecutionID int,
    @p_LinkID int,
    @p_CreatedAt datetime,
    @p_CreatedByID int,
    @p_UpdatedAt datetime,
    @p_UpdatedByID int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CarrierAdActivity] WHERE [AdActivityID] = @pk_AdActivityID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CarrierAdActivity]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CarrierAdActivity]
            SET 
            [AdID] = @p_AdID,
            [PartyID] = @p_PartyID,
            [CarrierID] = @p_CarrierID,
            [FavoriteAd] = @p_FavoriteAd,
            [FileAd] = @p_FileAd,
            [Viewed] = @p_Viewed,
            [FlowStepID] = @p_FlowStepID,
            [InstanceID] = @p_InstanceID,
            [ExecutionID] = @p_ExecutionID,
            [LinkID] = @p_LinkID,
            [CreatedAt] = @p_CreatedAt,
            [CreatedByID] = @p_CreatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [UpdatedByID] = @p_UpdatedByID
            WHERE [AdActivityID] = @pk_AdActivityID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AdActivityID],[AdID],[PartyID],[CarrierID],[FavoriteAd],[FileAd],[Viewed],[FlowStepID],[InstanceID],[ExecutionID],[LinkID],[CreatedAt],[CreatedByID],[UpdatedAt],[UpdatedByID]) AS nvarchar(4000)) 
            FROM [dbo].[CarrierAdActivity] with (rowlock, holdlock)
            WHERE [AdActivityID] = @pk_AdActivityID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CarrierAdActivity]
                    SET 
                    [AdID] = @p_AdID,
                    [PartyID] = @p_PartyID,
                    [CarrierID] = @p_CarrierID,
                    [FavoriteAd] = @p_FavoriteAd,
                    [FileAd] = @p_FileAd,
                    [Viewed] = @p_Viewed,
                    [FlowStepID] = @p_FlowStepID,
                    [InstanceID] = @p_InstanceID,
                    [ExecutionID] = @p_ExecutionID,
                    [LinkID] = @p_LinkID,
                    [CreatedAt] = @p_CreatedAt,
                    [CreatedByID] = @p_CreatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [UpdatedByID] = @p_UpdatedByID
                    WHERE [AdActivityID] = @pk_AdActivityID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CarrierAdActivity]', 16, 1)

        END
END

