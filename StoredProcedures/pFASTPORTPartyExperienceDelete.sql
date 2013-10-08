if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyExperienceDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyExperienceDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyExperience] table.
CREATE PROCEDURE pFASTPORTPartyExperienceDelete
        @pk_PartyExperienceID int
AS
BEGIN
    DELETE [dbo].[PartyExperience]
    WHERE [PartyExperienceID] = @pk_PartyExperienceID
END

