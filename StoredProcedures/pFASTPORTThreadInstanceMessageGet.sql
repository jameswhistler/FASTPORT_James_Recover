if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageGet') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[ThreadInstanceMessage] table.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageGet
        @pk_MessageID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[ThreadInstanceMessage]
    WHERE [MessageID] =@pk_MessageID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [MessageID],
        [InstanceID],
        [SenderID],
        [MessageAction],
        [MessageButtonText],
        [MessageSubject],
        [MessageBody],
        [ButtonID],
        [Queued],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        [ActionCollectionID],
        [LeftPartURL],
        [ActionURL],
        [ExcludeParams],
        [NoRadWindow],
        [GoAction],
        [Action],
        [CloseAction],
        [SliderValue],
        [RowOwnerCIX],
        [RowOIX],
        [FlowStep],
        [Party],
        [UserSystem],
        [Message],
        [Instance],
        [FleetCircle],
        [Execution],
        [Ad],
        [AdActivity],
        [CheckIn],
        [DocFiled],
        [Ord],
        [Payment],
        [Carrier],
        [Driver],
        [Addr],
        [Role],
        [History],
        [Parent],
        [Email],
        [Password],
        [Button],
        [Verification],
        [Doc],
        CAST(BINARY_CHECKSUM([MessageID],[InstanceID],[SenderID],[MessageAction],[MessageButtonText],[MessageSubject],[MessageBody],[ButtonID],[Queued],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[ActionCollectionID],[LeftPartURL],[ActionURL],[ExcludeParams],[NoRadWindow],[GoAction],[Action],[CloseAction],[SliderValue],[RowOwnerCIX],[RowOIX],[FlowStep],[Party],[UserSystem],[Message],[Instance],[FleetCircle],[Execution],[Ad],[AdActivity],[CheckIn],[DocFiled],[Ord],[Payment],[Carrier],[Driver],[Addr],[Role],[History],[Parent],[Email],[Password],[Button],[Verification],[Doc]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[ThreadInstanceMessage]
    WHERE [MessageID] =@pk_MessageID
    SET NOCOUNT OFF
END

