if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemServiceDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemServiceDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SystemService] table.
CREATE PROCEDURE pFASTPORTSystemServiceDelete
        @pk_ServiceID int
AS
BEGIN
    DELETE [dbo].[SystemService]
    WHERE [ServiceID] = @pk_ServiceID
END

