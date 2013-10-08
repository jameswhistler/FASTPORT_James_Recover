if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowConfigAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowConfigAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[FlowConfig] table.
CREATE PROCEDURE pFASTPORTFlowConfigAdd
    @p_FlowStepID int,
    @p_ConfigRank int,
    @p_IntendedForID int,
    @p_RoleID int,
    @p_MustAct bit,
    @p_SkipJump bit,
    @p_SendMessage bit,
    @p_Dashboard bit,
    @p_PageTitle varchar(50),
    @p_Instructions varchar(2000),
    @p_LandingRedirect varchar(1000),
    @p_GoAction varchar(50),
    @p_VideoURL varchar(1000),
    @p_VideoDescription varchar(1000),
    @p_FlowStepOneID int,
    @p_ButtonOneID int,
    @p_FlowStepTwoID int,
    @p_ButtonTwoID int,
    @p_FlowStepThreeID int,
    @p_ButtonThreeID int,
    @p_FlowStepFourID int,
    @p_ButtonFourID int,
    @p_RewindID int,
    @p_FirstElement bit,
    @p_SecondElement bit,
    @p_ThirdElement bit,
    @p_FourthElement bit,
    @p_FifthElement bit,
    @p_SixthElement bit,
    @p_SeventhElement bit,
    @p_EighthElement bit,
    @p_NinthElement bit,
    @p_TenthElement bit,
    @p_EleventhElement bit,
    @p_TwelfthElement bit,
    @p_ThirteenthElement bit,
    @p_FourteenthElement bit,
    @p_FifteenthElement bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CopyConfigID int,
    @p_ConfigID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[FlowConfig]
        (
            [FlowStepID],
            [IntendedForID],
            [RoleID],
            [PageTitle],
            [Instructions],
            [LandingRedirect],
            [GoAction],
            [VideoURL],
            [VideoDescription],
            [FlowStepOneID],
            [ButtonOneID],
            [FlowStepTwoID],
            [ButtonTwoID],
            [FlowStepThreeID],
            [ButtonThreeID],
            [FlowStepFourID],
            [ButtonFourID],
            [RewindID],
            [CreatedByID],
            [UpdatedByID],
            [CopyConfigID]
        )
    VALUES
        (
             @p_FlowStepID,
             @p_IntendedForID,
             @p_RoleID,
             @p_PageTitle,
             @p_Instructions,
             @p_LandingRedirect,
             @p_GoAction,
             @p_VideoURL,
             @p_VideoDescription,
             @p_FlowStepOneID,
             @p_ButtonOneID,
             @p_FlowStepTwoID,
             @p_ButtonTwoID,
             @p_FlowStepThreeID,
             @p_ButtonThreeID,
             @p_FlowStepFourID,
             @p_ButtonFourID,
             @p_RewindID,
             @p_CreatedByID,
             @p_UpdatedByID,
             @p_CopyConfigID
        )

    SET @p_ConfigID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ConfigRank IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [ConfigRank] = @p_ConfigRank WHERE [ConfigID] = @p_ConfigID_out

    IF @p_MustAct IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [MustAct] = @p_MustAct WHERE [ConfigID] = @p_ConfigID_out

    IF @p_SkipJump IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [SkipJump] = @p_SkipJump WHERE [ConfigID] = @p_ConfigID_out

    IF @p_SendMessage IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [SendMessage] = @p_SendMessage WHERE [ConfigID] = @p_ConfigID_out

    IF @p_Dashboard IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [Dashboard] = @p_Dashboard WHERE [ConfigID] = @p_ConfigID_out

    IF @p_FirstElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [FirstElement] = @p_FirstElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_SecondElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [SecondElement] = @p_SecondElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_ThirdElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [ThirdElement] = @p_ThirdElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_FourthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [FourthElement] = @p_FourthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_FifthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [FifthElement] = @p_FifthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_SixthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [SixthElement] = @p_SixthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_SeventhElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [SeventhElement] = @p_SeventhElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_EighthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [EighthElement] = @p_EighthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_NinthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [NinthElement] = @p_NinthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_TenthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [TenthElement] = @p_TenthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_EleventhElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [EleventhElement] = @p_EleventhElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_TwelfthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [TwelfthElement] = @p_TwelfthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_ThirteenthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [ThirteenthElement] = @p_ThirteenthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_FourteenthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [FourteenthElement] = @p_FourteenthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_FifteenthElement IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [FifteenthElement] = @p_FifteenthElement WHERE [ConfigID] = @p_ConfigID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [CreatedAt] = @p_CreatedAt WHERE [ConfigID] = @p_ConfigID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[FlowConfig] SET [UpdatedAt] = @p_UpdatedAt WHERE [ConfigID] = @p_ConfigID_out

END

