if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationLogDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationLogDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyWorkHistoryVerificationLog] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationLogDelete
        @pk_VerificationLogID int
AS
BEGIN
    DELETE [dbo].[PartyWorkHistoryVerificationLog]
    WHERE [VerificationLogID] = @pk_VerificationLogID
END

