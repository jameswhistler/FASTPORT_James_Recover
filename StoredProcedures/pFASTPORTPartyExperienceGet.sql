if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyExperienceGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyExperienceGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyExperience] table.
CREATE PROCEDURE pFASTPORTPartyExperienceGet
        @pk_PartyExperienceID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyExperience]
    WHERE [PartyExperienceID] =@pk_PartyExperienceID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PartyExperienceID],
        [HistoryID],
        [PartyID],
        [AdID],
        [ExperienceParentID],
        [ExperienceID],
        [ExperienceNotes],
        [FocusedOn],
        [LockFocus],
        [Importance],
        [ExperienceRank],
        CAST(BINARY_CHECKSUM([PartyExperienceID],[HistoryID],[PartyID],[AdID],[ExperienceParentID],[ExperienceID],[ExperienceNotes],[FocusedOn],[LockFocus],[Importance],[ExperienceRank]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyExperience]
    WHERE [PartyExperienceID] =@pk_PartyExperienceID
    SET NOCOUNT OFF
END

