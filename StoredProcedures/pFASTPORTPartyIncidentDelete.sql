if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyIncident] table.
CREATE PROCEDURE pFASTPORTPartyIncidentDelete
        @pk_IncidentID int
AS
BEGIN
    DELETE [dbo].[PartyIncident]
    WHERE [IncidentID] = @pk_IncidentID
END

