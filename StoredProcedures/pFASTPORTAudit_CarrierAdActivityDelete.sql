if exists (select * from sysobjects where id = object_id(N'pFASTPORTAudit_CarrierAdActivityDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTAudit_CarrierAdActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Audit_CarrierAdActivity] table.
CREATE PROCEDURE pFASTPORTAudit_CarrierAdActivityDelete
        @pk_AdActivityLogID int
AS
BEGIN
    DELETE [dbo].[Audit_CarrierAdActivity]
    WHERE [AdActivityLogID] = @pk_AdActivityLogID
END

