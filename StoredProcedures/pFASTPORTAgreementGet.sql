if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementGet') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Agreement] table.
CREATE PROCEDURE pFASTPORTAgreementGet
        @pk_AgreementID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Agreement]
    WHERE [AgreementID] =@pk_AgreementID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AgreementID],
        [CIX],
        [DocTreeParentID],
        [RoleID],
        [CustomID],
        [DocIndex],
        [DocSort],
        [Agreement],
        [Description],
        [RequiredDoc],
        [DocRank],
        [Hide],
        [AgreementFile],
        [AgreementFileName],
        [FlowCollectionID],
        [UseStoredSignature],
        [ShowSignatureDate],
        [ShowExpirationDate],
        [InitialsInDocument],
        [DocHasCustomFields],
        [ExecuteFromBoard],
        [SenderInstructions],
        [RecipientInstructions],
        [OtherInstructions],
        [FirstItem],
        [FirstTypeID],
        [FirstDefault],
        [FirstByCIX],
        [FirstByOIX],
        [SecondItem],
        [SecondTypeID],
        [SecondDefault],
        [SecondByCIX],
        [SecondByOIX],
        [ThirdItem],
        [ThirdTypeID],
        [ThirdDefault],
        [ThirdByCIX],
        [ThirdByOIX],
        [FourthItem],
        [FourthTypeID],
        [FourthDefault],
        [FourthByCIX],
        [FourthByOIX],
        [FifthItem],
        [FifthTypeID],
        [FifthDefault],
        [FifthByCIX],
        [FifthByOIX],
        [SixthItem],
        [SixthTypeID],
        [SixthDefault],
        [SixthByCIX],
        [SixthByOIX],
        [SeventhItem],
        [SeventhTypeID],
        [SeventhDefault],
        [SeventhByCIX],
        [SeventhByOIX],
        [EighthItem],
        [EighthTypeID],
        [EighthDefault],
        [EighthByCIX],
        [EighthByOIX],
        [NinthItem],
        [NinthTypeID],
        [NinthDefault],
        [NinthByCIX],
        [NinthByOIX],
        [TenthItem],
        [TenthTypeID],
        [TenthDefault],
        [TenthByCIX],
        [TenthByOIX],
        [EleventhItem],
        [EleventhTypeID],
        [EleventhDefault],
        [EleventhByCIX],
        [EleventhByOIX],
        [TwelfthItem],
        [TwelfthTypeID],
        [TwelfthDefault],
        [TwelfthByCIX],
        [TwelfthByOIX],
        [ThirteenthItem],
        [ThirteenthTypeID],
        [ThirteenthDefault],
        [ThirteenthByCIX],
        [ThirteenthByOIX],
        [FourteenthItem],
        [FourteenthTypeID],
        [FourteenthDefault],
        [FourteenthByCIX],
        [FourteenthByOIX],
        [FifteenthItem],
        [FifteenthTypeID],
        [FifteenthDefault],
        [FifteenthByCIX],
        [FifteenthByOIX],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([AgreementID],[CIX],[DocTreeParentID],[RoleID],[CustomID],[DocIndex],[DocSort],[Agreement],[Description],[RequiredDoc],[DocRank],[Hide],[AgreementFile],[AgreementFileName],[FlowCollectionID],[UseStoredSignature],[ShowSignatureDate],[ShowExpirationDate],[InitialsInDocument],[DocHasCustomFields],[ExecuteFromBoard],[SenderInstructions],[RecipientInstructions],[OtherInstructions],[FirstItem],[FirstTypeID],[FirstDefault],[FirstByCIX],[FirstByOIX],[SecondItem],[SecondTypeID],[SecondDefault],[SecondByCIX],[SecondByOIX],[ThirdItem],[ThirdTypeID],[ThirdDefault],[ThirdByCIX],[ThirdByOIX],[FourthItem],[FourthTypeID],[FourthDefault],[FourthByCIX],[FourthByOIX],[FifthItem],[FifthTypeID],[FifthDefault],[FifthByCIX],[FifthByOIX],[SixthItem],[SixthTypeID],[SixthDefault],[SixthByCIX],[SixthByOIX],[SeventhItem],[SeventhTypeID],[SeventhDefault],[SeventhByCIX],[SeventhByOIX],[EighthItem],[EighthTypeID],[EighthDefault],[EighthByCIX],[EighthByOIX],[NinthItem],[NinthTypeID],[NinthDefault],[NinthByCIX],[NinthByOIX],[TenthItem],[TenthTypeID],[TenthDefault],[TenthByCIX],[TenthByOIX],[EleventhItem],[EleventhTypeID],[EleventhDefault],[EleventhByCIX],[EleventhByOIX],[TwelfthItem],[TwelfthTypeID],[TwelfthDefault],[TwelfthByCIX],[TwelfthByOIX],[ThirteenthItem],[ThirteenthTypeID],[ThirteenthDefault],[ThirteenthByCIX],[ThirteenthByOIX],[FourteenthItem],[FourteenthTypeID],[FourteenthDefault],[FourteenthByCIX],[FourteenthByOIX],[FifteenthItem],[FifteenthTypeID],[FifteenthDefault],[FifteenthByCIX],[FifteenthByOIX],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Agreement]
    WHERE [AgreementID] =@pk_AgreementID
    SET NOCOUNT OFF
END

