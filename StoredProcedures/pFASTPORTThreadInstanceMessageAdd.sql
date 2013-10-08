if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ThreadInstanceMessage] table.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageAdd
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
    @p_MessageID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[ThreadInstanceMessage]
        (
            [InstanceID],
            [SenderID],
            [MessageAction],
            [MessageButtonText],
            [MessageSubject],
            [MessageBody],
            [ButtonID],
            [CreatedByID],
            [UpdatedByID],
            [ActionCollectionID],
            [LeftPartURL],
            [ActionURL],
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
            [Doc]
        )
    VALUES
        (
             @p_InstanceID,
             @p_SenderID,
             @p_MessageAction,
             @p_MessageButtonText,
             @p_MessageSubject,
             @p_MessageBody,
             @p_ButtonID,
             @p_CreatedByID,
             @p_UpdatedByID,
             @p_ActionCollectionID,
             @p_LeftPartURL,
             @p_ActionURL,
             @p_GoAction,
             @p_Action,
             @p_CloseAction,
             @p_SliderValue,
             @p_RowOwnerCIX,
             @p_RowOIX,
             @p_FlowStep,
             @p_Party,
             @p_UserSystem,
             @p_Message,
             @p_Instance,
             @p_FleetCircle,
             @p_Execution,
             @p_Ad,
             @p_AdActivity,
             @p_CheckIn,
             @p_DocFiled,
             @p_Ord,
             @p_Payment,
             @p_Carrier,
             @p_Driver,
             @p_Addr,
             @p_Role,
             @p_History,
             @p_Parent,
             @p_Email,
             @p_Password,
             @p_Button,
             @p_Verification,
             @p_Doc
        )

    SET @p_MessageID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Queued IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessage] SET [Queued] = @p_Queued WHERE [MessageID] = @p_MessageID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessage] SET [CreatedAt] = @p_CreatedAt WHERE [MessageID] = @p_MessageID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessage] SET [UpdatedAt] = @p_UpdatedAt WHERE [MessageID] = @p_MessageID_out

    IF @p_ExcludeParams IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessage] SET [ExcludeParams] = @p_ExcludeParams WHERE [MessageID] = @p_MessageID_out

    IF @p_NoRadWindow IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessage] SET [NoRadWindow] = @p_NoRadWindow WHERE [MessageID] = @p_MessageID_out

END

