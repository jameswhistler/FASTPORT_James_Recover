if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationLogAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationLogAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyWorkHistoryVerificationLog] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationLogAdd
    @p_VerificationID int,
    @p_AttemptAt datetime,
    @p_Attempted bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_VerificationLogID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyWorkHistoryVerificationLog]
        (
            [VerificationID],
            [AttemptAt],
            [Attempted],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_VerificationID,
             @p_AttemptAt,
             @p_Attempted,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_VerificationLogID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerificationLog] SET [CreatedAt] = @p_CreatedAt WHERE [VerificationLogID] = @p_VerificationLogID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerificationLog] SET [UpdatedAt] = @p_UpdatedAt WHERE [VerificationLogID] = @p_VerificationLogID_out

END

