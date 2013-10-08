if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowConfigUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowConfigUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[FlowConfig] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTFlowConfigUpdate
    @pk_ConfigID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[FlowConfig] WHERE [ConfigID] = @pk_ConfigID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[FlowConfig]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[FlowConfig]
            SET 
            [FlowStepID] = @p_FlowStepID,
            [ConfigRank] = @p_ConfigRank,
            [IntendedForID] = @p_IntendedForID,
            [RoleID] = @p_RoleID,
            [MustAct] = @p_MustAct,
            [SkipJump] = @p_SkipJump,
            [SendMessage] = @p_SendMessage,
            [Dashboard] = @p_Dashboard,
            [PageTitle] = @p_PageTitle,
            [Instructions] = @p_Instructions,
            [LandingRedirect] = @p_LandingRedirect,
            [GoAction] = @p_GoAction,
            [VideoURL] = @p_VideoURL,
            [VideoDescription] = @p_VideoDescription,
            [FlowStepOneID] = @p_FlowStepOneID,
            [ButtonOneID] = @p_ButtonOneID,
            [FlowStepTwoID] = @p_FlowStepTwoID,
            [ButtonTwoID] = @p_ButtonTwoID,
            [FlowStepThreeID] = @p_FlowStepThreeID,
            [ButtonThreeID] = @p_ButtonThreeID,
            [FlowStepFourID] = @p_FlowStepFourID,
            [ButtonFourID] = @p_ButtonFourID,
            [RewindID] = @p_RewindID,
            [FirstElement] = @p_FirstElement,
            [SecondElement] = @p_SecondElement,
            [ThirdElement] = @p_ThirdElement,
            [FourthElement] = @p_FourthElement,
            [FifthElement] = @p_FifthElement,
            [SixthElement] = @p_SixthElement,
            [SeventhElement] = @p_SeventhElement,
            [EighthElement] = @p_EighthElement,
            [NinthElement] = @p_NinthElement,
            [TenthElement] = @p_TenthElement,
            [EleventhElement] = @p_EleventhElement,
            [TwelfthElement] = @p_TwelfthElement,
            [ThirteenthElement] = @p_ThirteenthElement,
            [FourteenthElement] = @p_FourteenthElement,
            [FifteenthElement] = @p_FifteenthElement,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [CopyConfigID] = @p_CopyConfigID
            WHERE [ConfigID] = @pk_ConfigID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ConfigID],[FlowStepID],[ConfigRank],[IntendedForID],[RoleID],[MustAct],[SkipJump],[SendMessage],[Dashboard],[PageTitle],[Instructions],[LandingRedirect],[GoAction],[VideoURL],[VideoDescription],[FlowStepOneID],[ButtonOneID],[FlowStepTwoID],[ButtonTwoID],[FlowStepThreeID],[ButtonThreeID],[FlowStepFourID],[ButtonFourID],[RewindID],[FirstElement],[SecondElement],[ThirdElement],[FourthElement],[FifthElement],[SixthElement],[SeventhElement],[EighthElement],[NinthElement],[TenthElement],[EleventhElement],[TwelfthElement],[ThirteenthElement],[FourteenthElement],[FifteenthElement],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyConfigID]) AS nvarchar(4000)) 
            FROM [dbo].[FlowConfig] with (rowlock, holdlock)
            WHERE [ConfigID] = @pk_ConfigID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[FlowConfig]
                    SET 
                    [FlowStepID] = @p_FlowStepID,
                    [ConfigRank] = @p_ConfigRank,
                    [IntendedForID] = @p_IntendedForID,
                    [RoleID] = @p_RoleID,
                    [MustAct] = @p_MustAct,
                    [SkipJump] = @p_SkipJump,
                    [SendMessage] = @p_SendMessage,
                    [Dashboard] = @p_Dashboard,
                    [PageTitle] = @p_PageTitle,
                    [Instructions] = @p_Instructions,
                    [LandingRedirect] = @p_LandingRedirect,
                    [GoAction] = @p_GoAction,
                    [VideoURL] = @p_VideoURL,
                    [VideoDescription] = @p_VideoDescription,
                    [FlowStepOneID] = @p_FlowStepOneID,
                    [ButtonOneID] = @p_ButtonOneID,
                    [FlowStepTwoID] = @p_FlowStepTwoID,
                    [ButtonTwoID] = @p_ButtonTwoID,
                    [FlowStepThreeID] = @p_FlowStepThreeID,
                    [ButtonThreeID] = @p_ButtonThreeID,
                    [FlowStepFourID] = @p_FlowStepFourID,
                    [ButtonFourID] = @p_ButtonFourID,
                    [RewindID] = @p_RewindID,
                    [FirstElement] = @p_FirstElement,
                    [SecondElement] = @p_SecondElement,
                    [ThirdElement] = @p_ThirdElement,
                    [FourthElement] = @p_FourthElement,
                    [FifthElement] = @p_FifthElement,
                    [SixthElement] = @p_SixthElement,
                    [SeventhElement] = @p_SeventhElement,
                    [EighthElement] = @p_EighthElement,
                    [NinthElement] = @p_NinthElement,
                    [TenthElement] = @p_TenthElement,
                    [EleventhElement] = @p_EleventhElement,
                    [TwelfthElement] = @p_TwelfthElement,
                    [ThirteenthElement] = @p_ThirteenthElement,
                    [FourteenthElement] = @p_FourteenthElement,
                    [FifteenthElement] = @p_FifteenthElement,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [CopyConfigID] = @p_CopyConfigID
                    WHERE [ConfigID] = @pk_ConfigID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[FlowConfig]', 16, 1)

        END
END

