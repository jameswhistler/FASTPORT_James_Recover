if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowButtonUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowButtonUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[FlowButton] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTFlowButtonUpdate
    @pk_ButtonID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[FlowButton] WHERE [ButtonID] = @pk_ButtonID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[FlowButton]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[FlowButton]
            SET 
            [FlowStepID] = @p_FlowStepID,
            [ButtonRank] = @p_ButtonRank,
            [RefName] = @p_RefName,
            [ButtonText] = @p_ButtonText,
            [HideButton] = @p_HideButton,
            [ButtonToolTip] = @p_ButtonToolTip,
            [ImportantCSS] = @p_ImportantCSS,
            [Redirect] = @p_Redirect,
            [RedirectURL] = @p_RedirectURL,
            [GoToCompletion] = @p_GoToCompletion,
            [CompletionMessage] = @p_CompletionMessage,
            [SendMessage] = @p_SendMessage,
            [MessageSubject] = @p_MessageSubject,
            [MessageAction] = @p_MessageAction,
            [MessageButtonText] = @p_MessageButtonText,
            [ActionURL] = @p_ActionURL,
            [ExcludeParams] = @p_ExcludeParams,
            [NoRadWindow] = @p_NoRadWindow,
            [GoAction] = @p_GoAction,
            [MessageBody] = @p_MessageBody,
            [AutoMessage] = @p_AutoMessage,
            [CopySender] = @p_CopySender,
            [IncludeAttachment] = @p_IncludeAttachment,
            [FirstButtonAction] = @p_FirstButtonAction,
            [SecondButtonAction] = @p_SecondButtonAction,
            [ThirdButtonAction] = @p_ThirdButtonAction,
            [FourthButtonAction] = @p_FourthButtonAction,
            [FifthButtonAction] = @p_FifthButtonAction,
            [SixthButtonAction] = @p_SixthButtonAction,
            [SeventhButtonAction] = @p_SeventhButtonAction,
            [EighthButtonAction] = @p_EighthButtonAction,
            [NinthButtonAction] = @p_NinthButtonAction,
            [TenthButtonAction] = @p_TenthButtonAction,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [CopyButtonID] = @p_CopyButtonID
            WHERE [ButtonID] = @pk_ButtonID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([ButtonID],[FlowStepID],[ButtonRank],[RefName],[ButtonText],[HideButton],[ButtonToolTip],[ImportantCSS],[Redirect],[RedirectURL],[GoToCompletion],[CompletionMessage],[SendMessage],[MessageSubject],[MessageAction],[MessageButtonText],[ActionURL],[ExcludeParams],[NoRadWindow],[GoAction],[MessageBody],[AutoMessage],[CopySender],[IncludeAttachment],[FirstButtonAction],[SecondButtonAction],[ThirdButtonAction],[FourthButtonAction],[FifthButtonAction],[SixthButtonAction],[SeventhButtonAction],[EighthButtonAction],[NinthButtonAction],[TenthButtonAction],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyButtonID]) AS nvarchar(4000)) 
            FROM [dbo].[FlowButton] with (rowlock, holdlock)
            WHERE [ButtonID] = @pk_ButtonID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[FlowButton]
                    SET 
                    [FlowStepID] = @p_FlowStepID,
                    [ButtonRank] = @p_ButtonRank,
                    [RefName] = @p_RefName,
                    [ButtonText] = @p_ButtonText,
                    [HideButton] = @p_HideButton,
                    [ButtonToolTip] = @p_ButtonToolTip,
                    [ImportantCSS] = @p_ImportantCSS,
                    [Redirect] = @p_Redirect,
                    [RedirectURL] = @p_RedirectURL,
                    [GoToCompletion] = @p_GoToCompletion,
                    [CompletionMessage] = @p_CompletionMessage,
                    [SendMessage] = @p_SendMessage,
                    [MessageSubject] = @p_MessageSubject,
                    [MessageAction] = @p_MessageAction,
                    [MessageButtonText] = @p_MessageButtonText,
                    [ActionURL] = @p_ActionURL,
                    [ExcludeParams] = @p_ExcludeParams,
                    [NoRadWindow] = @p_NoRadWindow,
                    [GoAction] = @p_GoAction,
                    [MessageBody] = @p_MessageBody,
                    [AutoMessage] = @p_AutoMessage,
                    [CopySender] = @p_CopySender,
                    [IncludeAttachment] = @p_IncludeAttachment,
                    [FirstButtonAction] = @p_FirstButtonAction,
                    [SecondButtonAction] = @p_SecondButtonAction,
                    [ThirdButtonAction] = @p_ThirdButtonAction,
                    [FourthButtonAction] = @p_FourthButtonAction,
                    [FifthButtonAction] = @p_FifthButtonAction,
                    [SixthButtonAction] = @p_SixthButtonAction,
                    [SeventhButtonAction] = @p_SeventhButtonAction,
                    [EighthButtonAction] = @p_EighthButtonAction,
                    [NinthButtonAction] = @p_NinthButtonAction,
                    [TenthButtonAction] = @p_TenthButtonAction,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [CopyButtonID] = @p_CopyButtonID
                    WHERE [ButtonID] = @pk_ButtonID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[FlowButton]', 16, 1)

        END
END

