if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_ExecutionGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_ExecutionGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Execution] table.
CREATE PROCEDURE pFASTPORTV_ExecutionGet
        @pk_ExecutionID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Execution]
    WHERE [ExecutionID] =@pk_ExecutionID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ExecutionID],
        [CIX],
        [OIX],
        [AgreementID],
        [FlowStepID],
        [SenderAddrID],
        [SenderSignerID],
        [RecipientAddrID],
        [RecipientSignerID],
        [SignedOn],
        [ExpiresOn],
        [AddSignaturePage],
        [FirstItem],
        [SecondItem],
        [ThirdItem],
        [FourthItem],
        [FifthItem],
        [SixthItem],
        [SeventhItem],
        [EighthItem],
        [NinthItem],
        [TenthItem],
        [EleventhItem],
        [TwelfthItem],
        [ThirteenthItem],
        [FourteenthItem],
        [FifteenthItem],
        [ShowSignatureDate],
        [ShowExpirationDate],
        [ExecuteFromBoard],
        [OtherInstructions],
        [SenderInstructions],
        [RecipientInstructions],
        [FirstItemName],
        [FirstTypeID],
        [FirstDefault],
        [FirstByCIX],
        [FirstByOIX],
        [SecondItemName],
        [SecondTypeID],
        [SecondDefault],
        [SecondByCIX],
        [SecondByOIX],
        [ThirdItemName],
        [ThirdTypeID],
        [ThirdDefault],
        [ThirdByCIX],
        [ThirdByOIX],
        [FourthItemName],
        [FourthTypeID],
        [FourthDefault],
        [FourthByCIX],
        [FourthByOIX],
        [FifthItemName],
        [FifthTypeID],
        [FifthDefault],
        [FifthByCIX],
        [FifthByOIX],
        [SixthItemName],
        [SixthTypeID],
        [SixthDefault],
        [SixthByCIX],
        [SixthByOIX],
        [SeventhItemName],
        [SeventhTypeID],
        [SeventhDefault],
        [SeventhByCIX],
        [SeventhByOIX],
        [EighthItemName],
        [EighthTypeID],
        [EighthDefault],
        [EighthByCIX],
        [EighthByOIX],
        [NinthItemName],
        [NinthTypeID],
        [NinthDefault],
        [NinthByCIX],
        [NinthByOIX],
        [TenthItemName],
        [TenthTypeID],
        [TenthDefault],
        [TenthByCIX],
        [TenthByOIX],
        [EleventhItemName],
        [EleventhTypeID],
        [EleventhDefault],
        [EleventhByCIX],
        [EleventhByOIX],
        [TwelfthItemName],
        [TwelfthTypeID],
        [TwelfthDefault],
        [TwelfthByCIX],
        [TwelfthByOIX],
        [ThirteenthItemName],
        [ThirteenthTypeID],
        [ThirteenthDefault],
        [ThirteenthByCIX],
        [ThirteenthByOIX],
        [FourteenthItemName],
        [FourteenthTypeID],
        [FourteenthDefault],
        [FourteenthByCIX],
        [FourteenthByOIX],
        [FifteenthItemName],
        [FifteenthTypeID],
        [FifteenthDefault],
        [FifteenthByCIX],
        [FifteenthByOIX]
    FROM [dbo].[v_Execution]
    WHERE [ExecutionID] =@pk_ExecutionID
    SET NOCOUNT OFF
END

