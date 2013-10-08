if exists (select * from sysobjects where id = object_id(N'pFASTPORTCalendarDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCalendarDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Calendar] table.
CREATE PROCEDURE pFASTPORTCalendarDelete
        @pk_CalID int
AS
BEGIN
    DELETE [dbo].[Calendar]
    WHERE [CalID] = @pk_CalID
END

