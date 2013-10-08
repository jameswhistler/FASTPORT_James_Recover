if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRoleDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRoleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PartyRole] table.
CREATE PROCEDURE pFASTPORTPartyRoleDelete
        @pk_PartyRoleID int
AS
BEGIN
    DELETE [dbo].[PartyRole]
    WHERE [PartyRoleID] = @pk_PartyRoleID
END

