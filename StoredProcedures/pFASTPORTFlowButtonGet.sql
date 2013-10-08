if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowButtonGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowButtonGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[FlowButton] table.
CREATE PROCEDURE pFASTPORTFlowButtonGet
        @pk_ButtonID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[FlowButton]
    WHERE [ButtonID] =@pk_ButtonID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ButtonID],
        [FlowStepID],
        [ButtonRank],
        [RefName],
        [ButtonText],
        [HideButton],
        [ButtonToolTip],
        [ImportantCSS],
        [Redirect],
        [RedirectURL],
        [GoToCompletion],
        [CompletionMessage],
        [SendMessage],
        [MessageSubject],
        [MessageAction],
        [MessageButtonText],
        [ActionURL],
        [ExcludeParams],
        [NoRadWindow],
        [GoAction],
        [MessageBody],
        [AutoMessage],
        [CopySender],
        [IncludeAttachment],
        [FirstButtonAction],
        [SecondButtonAction],
        [ThirdButtonAction],
        [FourthButtonAction],
        [FifthButtonAction],
        [SixthButtonAction],
        [SeventhButtonAction],
        [EighthButtonAction],
        [NinthButtonAction],
        [TenthButtonAction],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        [CopyButtonID],
        CAST(BINARY_CHECKSUM([ButtonID],[FlowStepID],[ButtonRank],[RefName],[ButtonText],[HideButton],[ButtonToolTip],[ImportantCSS],[Redirect],[RedirectURL],[GoToCompletion],[CompletionMessage],[SendMessage],[MessageSubject],[MessageAction],[MessageButtonText],[ActionURL],[ExcludeParams],[NoRadWindow],[GoAction],[MessageBody],[AutoMessage],[CopySender],[IncludeAttachment],[FirstButtonAction],[SecondButtonAction],[ThirdButtonAction],[FourthButtonAction],[FifthButtonAction],[SixthButtonAction],[SeventhButtonAction],[EighthButtonAction],[NinthButtonAction],[TenthButtonAction],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyButtonID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[FlowButton]
    WHERE [ButtonID] =@pk_ButtonID
    SET NOCOUNT OFF
END

