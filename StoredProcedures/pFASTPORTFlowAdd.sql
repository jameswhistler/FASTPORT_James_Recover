if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Flow] table.
CREATE PROCEDURE pFASTPORTFlowAdd
    @p_FlowPage varchar(50),
    @p_FirstElementDesc varchar(50),
    @p_SecondElementDesc varchar(50),
    @p_ThirdElementDesc varchar(50),
    @p_FourthElementDesc varchar(50),
    @p_FifthElementDesc varchar(50),
    @p_SixthElementDesc varchar(50),
    @p_SeventhElementDesc varchar(50),
    @p_EighthElementDesc varchar(50),
    @p_NinthElementDesc varchar(50),
    @p_TenthElementDesc varchar(50),
    @p_EleventhElementDesc varchar(50),
    @p_TwelfthElementDesc varchar(50),
    @p_ThirteenthElementDesc varchar(50),
    @p_FourteenthElementDesc varchar(50),
    @p_FifteenthElementDesc varchar(50),
    @p_FirstButtonDesc varchar(50),
    @p_SecondButtonDesc varchar(50),
    @p_ThirdButtonDesc varchar(50),
    @p_FourthButtonDesc varchar(50),
    @p_FifthButtonDesc varchar(50),
    @p_SixthButtonDesc varchar(50),
    @p_SeventhButtonDesc varchar(50),
    @p_EighthButtonDesc varchar(50),
    @p_NinthButtonDesc varchar(50),
    @p_TenthButtonDesc varchar(50),
    @p_RelatedToID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_FlowID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Flow]
        (
            [FlowPage],
            [FirstElementDesc],
            [SecondElementDesc],
            [ThirdElementDesc],
            [FourthElementDesc],
            [FifthElementDesc],
            [SixthElementDesc],
            [SeventhElementDesc],
            [EighthElementDesc],
            [NinthElementDesc],
            [TenthElementDesc],
            [EleventhElementDesc],
            [TwelfthElementDesc],
            [ThirteenthElementDesc],
            [FourteenthElementDesc],
            [FifteenthElementDesc],
            [FirstButtonDesc],
            [SecondButtonDesc],
            [ThirdButtonDesc],
            [FourthButtonDesc],
            [FifthButtonDesc],
            [SixthButtonDesc],
            [SeventhButtonDesc],
            [EighthButtonDesc],
            [NinthButtonDesc],
            [TenthButtonDesc],
            [RelatedToID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_FlowPage,
             @p_FirstElementDesc,
             @p_SecondElementDesc,
             @p_ThirdElementDesc,
             @p_FourthElementDesc,
             @p_FifthElementDesc,
             @p_SixthElementDesc,
             @p_SeventhElementDesc,
             @p_EighthElementDesc,
             @p_NinthElementDesc,
             @p_TenthElementDesc,
             @p_EleventhElementDesc,
             @p_TwelfthElementDesc,
             @p_ThirteenthElementDesc,
             @p_FourteenthElementDesc,
             @p_FifteenthElementDesc,
             @p_FirstButtonDesc,
             @p_SecondButtonDesc,
             @p_ThirdButtonDesc,
             @p_FourthButtonDesc,
             @p_FifthButtonDesc,
             @p_SixthButtonDesc,
             @p_SeventhButtonDesc,
             @p_EighthButtonDesc,
             @p_NinthButtonDesc,
             @p_TenthButtonDesc,
             @p_RelatedToID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_FlowID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Flow] SET [CreatedAt] = @p_CreatedAt WHERE [FlowID] = @p_FlowID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[Flow] SET [UpdatedAt] = @p_UpdatedAt WHERE [FlowID] = @p_FlowID_out

END

