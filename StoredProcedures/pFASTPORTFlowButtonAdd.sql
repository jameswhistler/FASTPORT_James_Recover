if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowButtonAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowButtonAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[FlowButton] table.
CREATE PROCEDURE pFASTPORTFlowButtonAdd
    @p_FlowStepID int,
    @p_ButtonRank int,
    @p_RefName varchar(50),
    @p_ButtonText varchar(50),
    @p_HideButton bit,
    @p_ButtonToolTip varchar(255),
    @p_ImportantCSS bit,
    @p_Redirect bit,
    @p_RedirectURL varchar(255),
    @p_GoToCompletion bit,
    @p_CompletionMessage varchar(2000),
    @p_SendMessage bit,
    @p_MessageSubject varchar(150),
    @p_MessageAction varchar(2000),
    @p_MessageButtonText varchar(255),
    @p_ActionURL varchar(255),
    @p_ExcludeParams bit,
    @p_NoRadWindow bit,
    @p_GoAction varchar(50),
    @p_MessageBody varchar(2000),
    @p_AutoMessage bit,
    @p_CopySender bit,
    @p_IncludeAttachment bit,
    @p_FirstButtonAction bit,
    @p_SecondButtonAction bit,
    @p_ThirdButtonAction bit,
    @p_FourthButtonAction bit,
    @p_FifthButtonAction bit,
    @p_SixthButtonAction bit,
    @p_SeventhButtonAction bit,
    @p_EighthButtonAction bit,
    @p_NinthButtonAction bit,
    @p_TenthButtonAction bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CopyButtonID int,
    @p_ButtonID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[FlowButton]
        (
            [FlowStepID],
            [RefName],
            [ButtonText],
            [ButtonToolTip],
            [RedirectURL],
            [CompletionMessage],
            [MessageSubject],
            [MessageAction],
            [MessageButtonText],
            [ActionURL],
            [GoAction],
            [MessageBody],
            [IncludeAttachment],
            [CreatedByID],
            [UpdatedByID],
            [CopyButtonID]
        )
    VALUES
        (
             @p_FlowStepID,
             @p_RefName,
             @p_ButtonText,
             @p_ButtonToolTip,
             @p_RedirectURL,
             @p_CompletionMessage,
             @p_MessageSubject,
             @p_MessageAction,
             @p_MessageButtonText,
             @p_ActionURL,
             @p_GoAction,
             @p_MessageBody,
             @p_IncludeAttachment,
             @p_CreatedByID,
             @p_UpdatedByID,
             @p_CopyButtonID
        )

    SET @p_ButtonID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ButtonRank IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [ButtonRank] = @p_ButtonRank WHERE [ButtonID] = @p_ButtonID_out

    IF @p_HideButton IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [HideButton] = @p_HideButton WHERE [ButtonID] = @p_ButtonID_out

    IF @p_ImportantCSS IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [ImportantCSS] = @p_ImportantCSS WHERE [ButtonID] = @p_ButtonID_out

    IF @p_Redirect IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [Redirect] = @p_Redirect WHERE [ButtonID] = @p_ButtonID_out

    IF @p_GoToCompletion IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [GoToCompletion] = @p_GoToCompletion WHERE [ButtonID] = @p_ButtonID_out

    IF @p_SendMessage IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [SendMessage] = @p_SendMessage WHERE [ButtonID] = @p_ButtonID_out

    IF @p_ExcludeParams IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [ExcludeParams] = @p_ExcludeParams WHERE [ButtonID] = @p_ButtonID_out

    IF @p_NoRadWindow IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [NoRadWindow] = @p_NoRadWindow WHERE [ButtonID] = @p_ButtonID_out

    IF @p_AutoMessage IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [AutoMessage] = @p_AutoMessage WHERE [ButtonID] = @p_ButtonID_out

    IF @p_CopySender IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [CopySender] = @p_CopySender WHERE [ButtonID] = @p_ButtonID_out

    IF @p_FirstButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [FirstButtonAction] = @p_FirstButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_SecondButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [SecondButtonAction] = @p_SecondButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_ThirdButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [ThirdButtonAction] = @p_ThirdButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_FourthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [FourthButtonAction] = @p_FourthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_FifthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [FifthButtonAction] = @p_FifthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_SixthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [SixthButtonAction] = @p_SixthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_SeventhButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [SeventhButtonAction] = @p_SeventhButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_EighthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [EighthButtonAction] = @p_EighthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_NinthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [NinthButtonAction] = @p_NinthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_TenthButtonAction IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [TenthButtonAction] = @p_TenthButtonAction WHERE [ButtonID] = @p_ButtonID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [CreatedAt] = @p_CreatedAt WHERE [ButtonID] = @p_ButtonID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[FlowButton] SET [UpdatedAt] = @p_UpdatedAt WHERE [ButtonID] = @p_ButtonID_out

END

