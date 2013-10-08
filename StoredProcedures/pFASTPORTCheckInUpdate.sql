if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CheckIn] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCheckInUpdate
    @pk_CheckInID int,
    @p_PartyID int,
    @p_CheckInCatID int,
    @p_CityID int,
    @p_PointID int,
    @p_ReviewedPartyID int,
    @p_ReviewedAdID int,
    @p_ReviewedPartyExperienceID int,
    @p_StatusSlider int,
    @p_FavoriteItem bit,
    @p_HideItem bit,
    @p_ThumbsUp bit,
    @p_ThumbHits int,
    @p_ReviewStars float,
    @p_IdleAIR float,
    @p_CompleteAt datetime,
    @p_CheckInNotes varchar(4000),
    @p_InstanceID int,
    @p_PosLat float,
    @p_PosLong float,
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
    IF NOT EXISTS (SELECT * FROM [dbo].[CheckIn] WHERE [CheckInID] = @pk_CheckInID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CheckIn]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CheckIn]
            SET 
            [PartyID] = @p_PartyID,
            [CheckInCatID] = @p_CheckInCatID,
            [CityID] = @p_CityID,
            [PointID] = @p_PointID,
            [ReviewedPartyID] = @p_ReviewedPartyID,
            [ReviewedAdID] = @p_ReviewedAdID,
            [ReviewedPartyExperienceID] = @p_ReviewedPartyExperienceID,
            [StatusSlider] = @p_StatusSlider,
            [FavoriteItem] = @p_FavoriteItem,
            [HideItem] = @p_HideItem,
            [ThumbsUp] = @p_ThumbsUp,
            [ThumbHits] = @p_ThumbHits,
            [ReviewStars] = @p_ReviewStars,
            [IdleAIR] = @p_IdleAIR,
            [CompleteAt] = @p_CompleteAt,
            [CheckInNotes] = @p_CheckInNotes,
            [InstanceID] = @p_InstanceID,
            [PosLat] = @p_PosLat,
            [PosLong] = @p_PosLong,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [CheckInID] = @pk_CheckInID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([CheckInID],[PartyID],[CheckInCatID],[CityID],[PointID],[ReviewedPartyID],[ReviewedAdID],[ReviewedPartyExperienceID],[StatusSlider],[FavoriteItem],[HideItem],[ThumbsUp],[ThumbHits],[ReviewStars],[IdleAIR],[CompleteAt],[CheckInNotes],[InstanceID],[PosLat],[PosLong],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[CheckIn] with (rowlock, holdlock)
            WHERE [CheckInID] = @pk_CheckInID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CheckIn]
                    SET 
                    [PartyID] = @p_PartyID,
                    [CheckInCatID] = @p_CheckInCatID,
                    [CityID] = @p_CityID,
                    [PointID] = @p_PointID,
                    [ReviewedPartyID] = @p_ReviewedPartyID,
                    [ReviewedAdID] = @p_ReviewedAdID,
                    [ReviewedPartyExperienceID] = @p_ReviewedPartyExperienceID,
                    [StatusSlider] = @p_StatusSlider,
                    [FavoriteItem] = @p_FavoriteItem,
                    [HideItem] = @p_HideItem,
                    [ThumbsUp] = @p_ThumbsUp,
                    [ThumbHits] = @p_ThumbHits,
                    [ReviewStars] = @p_ReviewStars,
                    [IdleAIR] = @p_IdleAIR,
                    [CompleteAt] = @p_CompleteAt,
                    [CheckInNotes] = @p_CheckInNotes,
                    [InstanceID] = @p_InstanceID,
                    [PosLat] = @p_PosLat,
                    [PosLong] = @p_PosLong,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [CheckInID] = @pk_CheckInID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CheckIn]', 16, 1)

        END
END

