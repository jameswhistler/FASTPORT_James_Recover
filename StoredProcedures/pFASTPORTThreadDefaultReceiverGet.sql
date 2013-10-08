if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadDefaultReceiverGet') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadDefaultReceiverGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[ThreadDefaultReceiver] table.
CREATE PROCEDURE pFASTPORTThreadDefaultReceiverGet
        @pk_DefaultReceiverID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[ThreadDefaultReceiver]
    WHERE [DefaultReceiverID] =@pk_DefaultReceiverID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [DefaultReceiverID],
        [ThreadID],
        [PartyTypeID],
        [PartyID],
        [RoleID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([DefaultReceiverID],[ThreadID],[PartyTypeID],[PartyID],[RoleID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[ThreadDefaultReceiver]
    WHERE [DefaultReceiverID] =@pk_DefaultReceiverID
    SET NOCOUNT OFF
END

