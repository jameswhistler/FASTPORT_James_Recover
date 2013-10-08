if exists (select * from sysobjects where id = object_id(N'pFASTPORTGlobalDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTGlobalDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Global] table.
CREATE PROCEDURE pFASTPORTGlobalDelete
        @pk_GlobalID int
AS
BEGIN
    DELETE [dbo].[Global]
    WHERE [GlobalID] = @pk_GlobalID
END

