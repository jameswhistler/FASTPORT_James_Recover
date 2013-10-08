﻿if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemServiceGet') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemServiceGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[SystemService] table.
CREATE PROCEDURE pFASTPORTSystemServiceGet
        @pk_ServiceID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[SystemService]
    WHERE [ServiceID] =@pk_ServiceID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ServiceID],
        [ServiceContextID],
        [ServiceTypeID],
        [ServiceName],
        [ServiceDescription],
        [ServiceImageID],
        [ServiceRequired],
        [Fee],
        [DurationID],
        [Units],
        [ServiceRank],
        CAST(BINARY_CHECKSUM([ServiceID],[ServiceContextID],[ServiceTypeID],[ServiceName],[ServiceDescription],[ServiceImageID],[ServiceRequired],[Fee],[DurationID],[Units],[ServiceRank]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[SystemService]
    WHERE [ServiceID] =@pk_ServiceID
    SET NOCOUNT OFF
END

