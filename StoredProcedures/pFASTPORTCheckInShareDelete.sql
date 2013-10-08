if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInShareDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInShareDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CheckInShare] table.
CREATE PROCEDURE pFASTPORTCheckInShareDelete
        @pk_CheckInShareID int
AS
BEGIN
    DELETE [dbo].[CheckInShare]
    WHERE [CheckInShareID] = @pk_CheckInShareID
END

