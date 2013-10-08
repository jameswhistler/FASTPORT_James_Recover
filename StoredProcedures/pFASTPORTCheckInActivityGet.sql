if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInActivityGet') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInActivityGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CheckInActivity] table.
CREATE PROCEDURE pFASTPORTCheckInActivityGet
        @pk_CheckInActivityID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CheckInActivity]
    WHERE [CheckInActivityID] =@pk_CheckInActivityID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CheckInActivityID],
        [CheckInID],
        [ActivityID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([CheckInActivityID],[CheckInID],[ActivityID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CheckInActivity]
    WHERE [CheckInActivityID] =@pk_CheckInActivityID
    SET NOCOUNT OFF
END

