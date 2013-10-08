if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowConfigGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowConfigGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[FlowConfig] table.
CREATE PROCEDURE pFASTPORTFlowConfigGet
        @pk_ConfigID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[FlowConfig]
    WHERE [ConfigID] =@pk_ConfigID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ConfigID],
        [FlowStepID],
        [ConfigRank],
        [IntendedForID],
        [RoleID],
        [MustAct],
        [SkipJump],
        [SendMessage],
        [Dashboard],
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
        [FirstElement],
        [SecondElement],
        [ThirdElement],
        [FourthElement],
        [FifthElement],
        [SixthElement],
        [SeventhElement],
        [EighthElement],
        [NinthElement],
        [TenthElement],
        [EleventhElement],
        [TwelfthElement],
        [ThirteenthElement],
        [FourteenthElement],
        [FifteenthElement],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        [CopyConfigID],
        CAST(BINARY_CHECKSUM([ConfigID],[FlowStepID],[ConfigRank],[IntendedForID],[RoleID],[MustAct],[SkipJump],[SendMessage],[Dashboard],[PageTitle],[Instructions],[LandingRedirect],[GoAction],[VideoURL],[VideoDescription],[FlowStepOneID],[ButtonOneID],[FlowStepTwoID],[ButtonTwoID],[FlowStepThreeID],[ButtonThreeID],[FlowStepFourID],[ButtonFourID],[RewindID],[FirstElement],[SecondElement],[ThirdElement],[FourthElement],[FifthElement],[SixthElement],[SeventhElement],[EighthElement],[NinthElement],[TenthElement],[EleventhElement],[TwelfthElement],[ThirteenthElement],[FourteenthElement],[FifteenthElement],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyConfigID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[FlowConfig]
    WHERE [ConfigID] =@pk_ConfigID
    SET NOCOUNT OFF
END

