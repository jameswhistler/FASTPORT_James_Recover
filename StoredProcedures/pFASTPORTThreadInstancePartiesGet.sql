if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstancePartiesGet') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstancePartiesGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[ThreadInstanceParties] table.
CREATE PROCEDURE pFASTPORTThreadInstancePartiesGet
        @pk_InstancePartyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[ThreadInstanceParties]
    WHERE [InstancePartyID] =@pk_InstancePartyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [InstancePartyID],
        [InstanceID],
        [PartyTypeID],
        [UserID],
        [PartyID],
        [RoleID],
        [FreeHand],
        [ThreadPriorityID],
        [Email],
        [MobileText],
        [Fax],
        [InstantMessage],
        [BoardOnly],
        [FileInstance],
        [OneTime],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([InstancePartyID],[InstanceID],[PartyTypeID],[UserID],[PartyID],[RoleID],[FreeHand],[ThreadPriorityID],[Email],[MobileText],[Fax],[InstantMessage],[BoardOnly],[FileInstance],[OneTime],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[ThreadInstanceParties]
    WHERE [InstancePartyID] =@pk_InstancePartyID
    SET NOCOUNT OFF
END

