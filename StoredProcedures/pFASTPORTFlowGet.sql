if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowGet') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Flow] table.
CREATE PROCEDURE pFASTPORTFlowGet
        @pk_FlowID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Flow]
    WHERE [FlowID] =@pk_FlowID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [FlowID],
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
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([FlowID],[FlowPage],[FirstElementDesc],[SecondElementDesc],[ThirdElementDesc],[FourthElementDesc],[FifthElementDesc],[SixthElementDesc],[SeventhElementDesc],[EighthElementDesc],[NinthElementDesc],[TenthElementDesc],[EleventhElementDesc],[TwelfthElementDesc],[ThirteenthElementDesc],[FourteenthElementDesc],[FifteenthElementDesc],[FirstButtonDesc],[SecondButtonDesc],[ThirdButtonDesc],[FourthButtonDesc],[FifthButtonDesc],[SixthButtonDesc],[SeventhButtonDesc],[EighthButtonDesc],[NinthButtonDesc],[TenthButtonDesc],[RelatedToID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Flow]
    WHERE [FlowID] =@pk_FlowID
    SET NOCOUNT OFF
END

