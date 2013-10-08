if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRepsAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRepsAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyReps] table.
CREATE PROCEDURE pFASTPORTPartyRepsAdd
    @p_PartyID int,
    @p_RepID int,
    @p_ReppedOn datetime
AS
BEGIN
    INSERT
    INTO [dbo].[PartyReps]
        (
            [PartyID],
            [RepID],
            [ReppedOn]
        )
    VALUES
        (
             @p_PartyID,
             @p_RepID,
             @p_ReppedOn
        )

END

