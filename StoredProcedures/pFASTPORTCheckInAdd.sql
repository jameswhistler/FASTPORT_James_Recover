if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CheckIn] table.
CREATE PROCEDURE pFASTPORTCheckInAdd
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
    @p_CheckInID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CheckIn]
        (
            [PartyID],
            [CheckInCatID],
            [CityID],
            [PointID],
            [ReviewedPartyID],
            [ReviewedAdID],
            [ReviewedPartyExperienceID],
            [StatusSlider],
            [ReviewStars],
            [IdleAIR],
            [CompleteAt],
            [CheckInNotes],
            [InstanceID],
            [PosLat],
            [PosLong],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyID,
             @p_CheckInCatID,
             @p_CityID,
             @p_PointID,
             @p_ReviewedPartyID,
             @p_ReviewedAdID,
             @p_ReviewedPartyExperienceID,
             @p_StatusSlider,
             @p_ReviewStars,
             @p_IdleAIR,
             @p_CompleteAt,
             @p_CheckInNotes,
             @p_InstanceID,
             @p_PosLat,
             @p_PosLong,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_CheckInID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FavoriteItem IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [FavoriteItem] = @p_FavoriteItem WHERE [CheckInID] = @p_CheckInID_out

    IF @p_HideItem IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [HideItem] = @p_HideItem WHERE [CheckInID] = @p_CheckInID_out

    IF @p_ThumbsUp IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [ThumbsUp] = @p_ThumbsUp WHERE [CheckInID] = @p_CheckInID_out

    IF @p_ThumbHits IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [ThumbHits] = @p_ThumbHits WHERE [CheckInID] = @p_CheckInID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [CreatedAt] = @p_CreatedAt WHERE [CheckInID] = @p_CheckInID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[CheckIn] SET [UpdatedAt] = @p_UpdatedAt WHERE [CheckInID] = @p_CheckInID_out

END

