if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInActivityDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInActivityDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[CheckInActivity] table.
CREATE PROCEDURE pFASTPORTCheckInActivityDelete
        @pk_CheckInActivityID int
AS
BEGIN
    DELETE [dbo].[CheckInActivity]
    WHERE [CheckInActivityID] = @pk_CheckInActivityID
END

