if exists (select * from sysobjects where id = object_id(N'pFASTPORTSprocLogDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTSprocLogDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[SprocLog] table.
CREATE PROCEDURE pFASTPORTSprocLogDelete
        @pk_SprocLogID int
AS
BEGIN
    DELETE [dbo].[SprocLog]
    WHERE [SprocLogID] = @pk_SprocLogID
END

