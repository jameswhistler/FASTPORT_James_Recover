if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ThreadInstance] table.
CREATE PROCEDURE pFASTPORTThreadInstanceDelete
        @pk_InstanceID int
AS
BEGIN
    DELETE [dbo].[ThreadInstance]
    WHERE [InstanceID] = @pk_InstanceID
END

