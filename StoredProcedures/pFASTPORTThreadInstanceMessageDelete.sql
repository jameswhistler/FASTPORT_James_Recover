if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ThreadInstanceMessage] table.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageDelete
        @pk_MessageID int
AS
BEGIN
    DELETE [dbo].[ThreadInstanceMessage]
    WHERE [MessageID] = @pk_MessageID
END

