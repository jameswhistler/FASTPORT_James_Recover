if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyWorkHistoryVerification] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationDelete
        @pk_VerificationID int
AS
BEGIN
    DELETE [dbo].[PartyWorkHistoryVerification]
    WHERE [VerificationID] = @pk_VerificationID
END

