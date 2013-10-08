if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceGet') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[ThreadInstance] table.
CREATE PROCEDURE pFASTPORTThreadInstanceGet
        @pk_InstanceID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[ThreadInstance]
    WHERE [InstanceID] =@pk_InstanceID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [InstanceID],
        [CIX],
        [ThreadID],
        [HostID],
        [ResponsibleID],
        [FlowStepID],
        [ThreadPriorityID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([InstanceID],[CIX],[ThreadID],[HostID],[ResponsibleID],[FlowStepID],[ThreadPriorityID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[ThreadInstance]
    WHERE [InstanceID] =@pk_InstanceID
    SET NOCOUNT OFF
END

