if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyWorkHistory] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryDelete
        @pk_HistoryID int
AS
BEGIN
    DELETE [dbo].[PartyWorkHistory]
    WHERE [HistoryID] = @pk_HistoryID
END

