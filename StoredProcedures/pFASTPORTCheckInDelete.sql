if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CheckIn] table.
CREATE PROCEDURE pFASTPORTCheckInDelete
        @pk_CheckInID int
AS
BEGIN
    DELETE [dbo].[CheckIn]
    WHERE [CheckInID] = @pk_CheckInID
END

