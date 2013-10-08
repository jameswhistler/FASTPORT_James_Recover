if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[ThreadInstanceMessage] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageUpdate
    @pk_MessageID int,
    @p_InstanceID int,
    @p_SenderID int,
    @p_MessageAction varchar(2000),
    @p_MessageButtonText varchar(255),
    @p_MessageSubject varchar(1000),
    @p_MessageBody varchar(max),
    @p_ButtonID int,
    @p_Queued int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_ActionCollectionID int,
    @p_LeftPartURL varchar(255),
    @p_ActionURL varchar(500),
    @p_ExcludeParams bit,
    @p_NoRadWindow bit,
    @p_GoAction varchar(50),
    @p_Action varchar(50),
    @p_CloseAction varchar(50),
    @p_SliderValue varchar(50),
    @p_RowOwnerCIX int,
    @p_RowOIX int,
    @p_FlowStep int,
    @p_Party int,
    @p_UserSystem int,
    @p_Message int,
    @p_Instance int,
    @p_FleetCircle int,
    @p_Execution int,
    @p_Ad int,
    @p_AdActivity int,
    @p_CheckIn int,
    @p_DocFiled int,
    @p_Ord int,
    @p_Payment int,
    @p_Carrier int,
    @p_Driver int,
    @p_Addr int,
    @p_Role int,
    @p_History int,
    @p_Parent int,
    @p_Email varchar(50),
    @p_Password varchar(50),
    @p_Button int,
    @p_Verification int,
    @p_Doc int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[ThreadInstanceMessage] WHERE [MessageID] = @pk_MessageID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[ThreadInstanceMessage]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[ThreadInstanceMessage]
            SET 
            [InstanceID] = @p_InstanceID,
            [SenderID] = @p_SenderID,
            [MessageAction] = @p_MessageAction,
            [MessageButtonText] = @p_MessageButtonText,
            [MessageSubject] = @p_MessageSubject,
            [MessageBody] = @p_MessageBody,
            [ButtonID] = @p_ButtonID,
            [Queued] = @p_Queued,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [ActionCollectionID] = @p_ActionCollectionID,
            [LeftPartURL] = @p_LeftPartURL,
            [ActionURL] = @p_ActionURL,
            [ExcludeParams] = @p_ExcludeParams,
            [NoRadWindow] = @p_NoRadWindow,
            [GoAction] = @p_GoAction,
            [Action] = @p_Action,
            [CloseAction] = @p_CloseAction,
            [SliderValue] = @p_SliderValue,
            [RowOwnerCIX] = @p_RowOwnerCIX,
            [RowOIX] = @p_RowOIX,
            [FlowStep] = @p_FlowStep,
            [Party] = @p_Party,
            [UserSystem] = @p_UserSystem,
            [Message] = @p_Message,
            [Instance] = @p_Instance,
            [FleetCircle] = @p_FleetCircle,
            [Execution] = @p_Execution,
            [Ad] = @p_Ad,
            [AdActivity] = @p_AdActivity,
            [CheckIn] = @p_CheckIn,
            [DocFiled] = @p_DocFiled,
            [Ord] = @p_Ord,
            [Payment] = @p_Payment,
            [Carrier] = @p_Carrier,
            [Driver] = @p_Driver,
            [Addr] = @p_Addr,
            [Role] = @p_Role,
            [History] = @p_History,
            [Parent] = @p_Parent,
            [Email] = @p_Email,
            [Password] = @p_Password,
            [Button] = @p_Button,
            [Verification] = @p_Verification,
            [Doc] = @p_Doc
            WHERE [MessageID] = @pk_MessageID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([MessageID],[InstanceID],[SenderID],[MessageAction],[MessageButtonText],[MessageSubject],[MessageBody],[ButtonID],[Queued],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[ActionCollectionID],[LeftPartURL],[ActionURL],[ExcludeParams],[NoRadWindow],[GoAction],[Action],[CloseAction],[SliderValue],[RowOwnerCIX],[RowOIX],[FlowStep],[Party],[UserSystem],[Message],[Instance],[FleetCircle],[Execution],[Ad],[AdActivity],[CheckIn],[DocFiled],[Ord],[Payment],[Carrier],[Driver],[Addr],[Role],[History],[Parent],[Email],[Password],[Button],[Verification],[Doc]) AS nvarchar(4000)) 
            FROM [dbo].[ThreadInstanceMessage] with (rowlock, holdlock)
            WHERE [MessageID] = @pk_MessageID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[ThreadInstanceMessage]
                    SET 
                    [InstanceID] = @p_InstanceID,
                    [SenderID] = @p_SenderID,
                    [MessageAction] = @p_MessageAction,
                    [MessageButtonText] = @p_MessageButtonText,
                    [MessageSubject] = @p_MessageSubject,
                    [MessageBody] = @p_MessageBody,
                    [ButtonID] = @p_ButtonID,
                    [Queued] = @p_Queued,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [ActionCollectionID] = @p_ActionCollectionID,
                    [LeftPartURL] = @p_LeftPartURL,
                    [ActionURL] = @p_ActionURL,
                    [ExcludeParams] = @p_ExcludeParams,
                    [NoRadWindow] = @p_NoRadWindow,
                    [GoAction] = @p_GoAction,
                    [Action] = @p_Action,
                    [CloseAction] = @p_CloseAction,
                    [SliderValue] = @p_SliderValue,
                    [RowOwnerCIX] = @p_RowOwnerCIX,
                    [RowOIX] = @p_RowOIX,
                    [FlowStep] = @p_FlowStep,
                    [Party] = @p_Party,
                    [UserSystem] = @p_UserSystem,
                    [Message] = @p_Message,
                    [Instance] = @p_Instance,
                    [FleetCircle] = @p_FleetCircle,
                    [Execution] = @p_Execution,
                    [Ad] = @p_Ad,
                    [AdActivity] = @p_AdActivity,
                    [CheckIn] = @p_CheckIn,
                    [DocFiled] = @p_DocFiled,
                    [Ord] = @p_Ord,
                    [Payment] = @p_Payment,
                    [Carrier] = @p_Carrier,
                    [Driver] = @p_Driver,
                    [Addr] = @p_Addr,
                    [Role] = @p_Role,
                    [History] = @p_History,
                    [Parent] = @p_Parent,
                    [Email] = @p_Email,
                    [Password] = @p_Password,
                    [Button] = @p_Button,
                    [Verification] = @p_Verification,
                    [Doc] = @p_Doc
                    WHERE [MessageID] = @pk_MessageID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[ThreadInstanceMessage]', 16, 1)

        END
END

