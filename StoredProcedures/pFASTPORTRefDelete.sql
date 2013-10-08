if exists (select * from sysobjects where id = object_id(N'pFASTPORTRefDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTRefDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Ref] table.
CREATE PROCEDURE pFASTPORTRefDelete
        @pk_RefID int
AS
BEGIN
    DELETE [dbo].[Ref]
    WHERE [RefID] = @pk_RefID
END

