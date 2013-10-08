if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyExperienceAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyExperienceAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyExperience] table.
CREATE PROCEDURE pFASTPORTPartyExperienceAdd
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
    @p_PartyExperienceID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyExperience]
        (
            [HistoryID],
            [PartyID],
            [AdID],
            [ExperienceParentID],
            [ExperienceID],
            [ExperienceNotes]
        )
    VALUES
        (
             @p_HistoryID,
             @p_PartyID,
             @p_AdID,
             @p_ExperienceParentID,
             @p_ExperienceID,
             @p_ExperienceNotes
        )

    SET @p_PartyExperienceID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FocusedOn IS NOT NULL
        UPDATE [dbo].[PartyExperience] SET [FocusedOn] = @p_FocusedOn WHERE [PartyExperienceID] = @p_PartyExperienceID_out

    IF @p_LockFocus IS NOT NULL
        UPDATE [dbo].[PartyExperience] SET [LockFocus] = @p_LockFocus WHERE [PartyExperienceID] = @p_PartyExperienceID_out

    IF @p_Importance IS NOT NULL
        UPDATE [dbo].[PartyExperience] SET [Importance] = @p_Importance WHERE [PartyExperienceID] = @p_PartyExperienceID_out

    IF @p_ExperienceRank IS NOT NULL
        UPDATE [dbo].[PartyExperience] SET [ExperienceRank] = @p_ExperienceRank WHERE [PartyExperienceID] = @p_PartyExperienceID_out

END

