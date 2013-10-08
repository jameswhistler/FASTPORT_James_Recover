if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Agreement] table.
CREATE PROCEDURE pFASTPORTAgreementAdd
    @p_CIX int,
    @p_DocTreeParentID int,
    @p_RoleID int,
    @p_CustomID int,
    @p_DocIndex varchar(50),
    @p_DocSort varchar(50),
    @p_Agreement varchar(50),
    @p_Description varchar(500),
    @p_RequiredDoc bit,
    @p_DocRank int,
    @p_Hide bit,
    @p_AgreementFile image,
    @p_AgreementFileName varchar(100),
    @p_FlowCollectionID int,
    @p_UseStoredSignature bit,
    @p_ShowSignatureDate bit,
    @p_ShowExpirationDate bit,
    @p_InitialsInDocument bit,
    @p_DocHasCustomFields bit,
    @p_ExecuteFromBoard bit,
    @p_SenderInstructions varchar(4000),
    @p_RecipientInstructions varchar(4000),
    @p_OtherInstructions varchar(4000),
    @p_FirstItem varchar(2000),
    @p_FirstTypeID int,
    @p_FirstDefault varchar(2000),
    @p_FirstByCIX bit,
    @p_FirstByOIX bit,
    @p_SecondItem varchar(2000),
    @p_SecondTypeID int,
    @p_SecondDefault varchar(2000),
    @p_SecondByCIX bit,
    @p_SecondByOIX bit,
    @p_ThirdItem varchar(2000),
    @p_ThirdTypeID int,
    @p_ThirdDefault varchar(2000),
    @p_ThirdByCIX bit,
    @p_ThirdByOIX bit,
    @p_FourthItem varchar(2000),
    @p_FourthTypeID int,
    @p_FourthDefault varchar(2000),
    @p_FourthByCIX bit,
    @p_FourthByOIX bit,
    @p_FifthItem varchar(2000),
    @p_FifthTypeID int,
    @p_FifthDefault varchar(2000),
    @p_FifthByCIX bit,
    @p_FifthByOIX bit,
    @p_SixthItem varchar(2000),
    @p_SixthTypeID int,
    @p_SixthDefault varchar(2000),
    @p_SixthByCIX bit,
    @p_SixthByOIX bit,
    @p_SeventhItem varchar(2000),
    @p_SeventhTypeID int,
    @p_SeventhDefault varchar(2000),
    @p_SeventhByCIX bit,
    @p_SeventhByOIX bit,
    @p_EighthItem varchar(2000),
    @p_EighthTypeID int,
    @p_EighthDefault varchar(2000),
    @p_EighthByCIX bit,
    @p_EighthByOIX bit,
    @p_NinthItem varchar(2000),
    @p_NinthTypeID int,
    @p_NinthDefault varchar(2000),
    @p_NinthByCIX bit,
    @p_NinthByOIX bit,
    @p_TenthItem varchar(2000),
    @p_TenthTypeID int,
    @p_TenthDefault varchar(2000),
    @p_TenthByCIX bit,
    @p_TenthByOIX bit,
    @p_EleventhItem varchar(2000),
    @p_EleventhTypeID int,
    @p_EleventhDefault varchar(2000),
    @p_EleventhByCIX bit,
    @p_EleventhByOIX bit,
    @p_TwelfthItem varchar(2000),
    @p_TwelfthTypeID int,
    @p_TwelfthDefault varchar(2000),
    @p_TwelfthByCIX bit,
    @p_TwelfthByOIX bit,
    @p_ThirteenthItem varchar(2000),
    @p_ThirteenthTypeID int,
    @p_ThirteenthDefault varchar(2000),
    @p_ThirteenthByCIX bit,
    @p_ThirteenthByOIX bit,
    @p_FourteenthItem varchar(2000),
    @p_FourteenthTypeID int,
    @p_FourteenthDefault varchar(2000),
    @p_FourteenthByCIX bit,
    @p_FourteenthByOIX bit,
    @p_FifteenthItem varchar(2000),
    @p_FifteenthTypeID int,
    @p_FifteenthDefault varchar(2000),
    @p_FifteenthByCIX bit,
    @p_FifteenthByOIX bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_AgreementID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Agreement]
        (
            [CIX],
            [DocTreeParentID],
            [RoleID],
            [CustomID],
            [DocIndex],
            [DocSort],
            [Agreement],
            [Description],
            [AgreementFile],
            [AgreementFileName],
            [FlowCollectionID],
            [SenderInstructions],
            [RecipientInstructions],
            [OtherInstructions],
            [FirstItem],
            [FirstTypeID],
            [FirstDefault],
            [SecondItem],
            [SecondTypeID],
            [SecondDefault],
            [ThirdItem],
            [ThirdTypeID],
            [ThirdDefault],
            [FourthItem],
            [FourthTypeID],
            [FourthDefault],
            [FifthItem],
            [FifthTypeID],
            [FifthDefault],
            [SixthItem],
            [SixthTypeID],
            [SixthDefault],
            [SeventhItem],
            [SeventhTypeID],
            [SeventhDefault],
            [EighthItem],
            [EighthTypeID],
            [EighthDefault],
            [NinthItem],
            [NinthTypeID],
            [NinthDefault],
            [TenthItem],
            [TenthTypeID],
            [TenthDefault],
            [EleventhItem],
            [EleventhTypeID],
            [EleventhDefault],
            [TwelfthItem],
            [TwelfthTypeID],
            [TwelfthDefault],
            [ThirteenthItem],
            [ThirteenthTypeID],
            [ThirteenthDefault],
            [FourteenthItem],
            [FourteenthTypeID],
            [FourteenthDefault],
            [FifteenthItem],
            [FifteenthTypeID],
            [FifteenthDefault],
            [CreatedByID],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_CIX,
             @p_DocTreeParentID,
             @p_RoleID,
             @p_CustomID,
             @p_DocIndex,
             @p_DocSort,
             @p_Agreement,
             @p_Description,
             @p_AgreementFile,
             @p_AgreementFileName,
             @p_FlowCollectionID,
             @p_SenderInstructions,
             @p_RecipientInstructions,
             @p_OtherInstructions,
             @p_FirstItem,
             @p_FirstTypeID,
             @p_FirstDefault,
             @p_SecondItem,
             @p_SecondTypeID,
             @p_SecondDefault,
             @p_ThirdItem,
             @p_ThirdTypeID,
             @p_ThirdDefault,
             @p_FourthItem,
             @p_FourthTypeID,
             @p_FourthDefault,
             @p_FifthItem,
             @p_FifthTypeID,
             @p_FifthDefault,
             @p_SixthItem,
             @p_SixthTypeID,
             @p_SixthDefault,
             @p_SeventhItem,
             @p_SeventhTypeID,
             @p_SeventhDefault,
             @p_EighthItem,
             @p_EighthTypeID,
             @p_EighthDefault,
             @p_NinthItem,
             @p_NinthTypeID,
             @p_NinthDefault,
             @p_TenthItem,
             @p_TenthTypeID,
             @p_TenthDefault,
             @p_EleventhItem,
             @p_EleventhTypeID,
             @p_EleventhDefault,
             @p_TwelfthItem,
             @p_TwelfthTypeID,
             @p_TwelfthDefault,
             @p_ThirteenthItem,
             @p_ThirteenthTypeID,
             @p_ThirteenthDefault,
             @p_FourteenthItem,
             @p_FourteenthTypeID,
             @p_FourteenthDefault,
             @p_FifteenthItem,
             @p_FifteenthTypeID,
             @p_FifteenthDefault,
             @p_CreatedByID,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_AgreementID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_RequiredDoc IS NOT NULL
        UPDATE [dbo].[Agreement] SET [RequiredDoc] = @p_RequiredDoc WHERE [AgreementID] = @p_AgreementID_out

    IF @p_DocRank IS NOT NULL
        UPDATE [dbo].[Agreement] SET [DocRank] = @p_DocRank WHERE [AgreementID] = @p_AgreementID_out

    IF @p_Hide IS NOT NULL
        UPDATE [dbo].[Agreement] SET [Hide] = @p_Hide WHERE [AgreementID] = @p_AgreementID_out

    IF @p_UseStoredSignature IS NOT NULL
        UPDATE [dbo].[Agreement] SET [UseStoredSignature] = @p_UseStoredSignature WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ShowSignatureDate IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ShowSignatureDate] = @p_ShowSignatureDate WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ShowExpirationDate IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ShowExpirationDate] = @p_ShowExpirationDate WHERE [AgreementID] = @p_AgreementID_out

    IF @p_InitialsInDocument IS NOT NULL
        UPDATE [dbo].[Agreement] SET [InitialsInDocument] = @p_InitialsInDocument WHERE [AgreementID] = @p_AgreementID_out

    IF @p_DocHasCustomFields IS NOT NULL
        UPDATE [dbo].[Agreement] SET [DocHasCustomFields] = @p_DocHasCustomFields WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ExecuteFromBoard IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ExecuteFromBoard] = @p_ExecuteFromBoard WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FirstByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FirstByCIX] = @p_FirstByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FirstByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FirstByOIX] = @p_FirstByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SecondByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SecondByCIX] = @p_SecondByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SecondByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SecondByOIX] = @p_SecondByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ThirdByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ThirdByCIX] = @p_ThirdByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ThirdByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ThirdByOIX] = @p_ThirdByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FourthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FourthByCIX] = @p_FourthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FourthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FourthByOIX] = @p_FourthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FifthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FifthByCIX] = @p_FifthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FifthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FifthByOIX] = @p_FifthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SixthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SixthByCIX] = @p_SixthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SixthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SixthByOIX] = @p_SixthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SeventhByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SeventhByCIX] = @p_SeventhByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_SeventhByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [SeventhByOIX] = @p_SeventhByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_EighthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [EighthByCIX] = @p_EighthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_EighthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [EighthByOIX] = @p_EighthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_NinthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [NinthByCIX] = @p_NinthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_NinthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [NinthByOIX] = @p_NinthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_TenthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [TenthByCIX] = @p_TenthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_TenthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [TenthByOIX] = @p_TenthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_EleventhByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [EleventhByCIX] = @p_EleventhByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_EleventhByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [EleventhByOIX] = @p_EleventhByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_TwelfthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [TwelfthByCIX] = @p_TwelfthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_TwelfthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [TwelfthByOIX] = @p_TwelfthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ThirteenthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ThirteenthByCIX] = @p_ThirteenthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_ThirteenthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [ThirteenthByOIX] = @p_ThirteenthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FourteenthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FourteenthByCIX] = @p_FourteenthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FourteenthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FourteenthByOIX] = @p_FourteenthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FifteenthByCIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FifteenthByCIX] = @p_FifteenthByCIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_FifteenthByOIX IS NOT NULL
        UPDATE [dbo].[Agreement] SET [FifteenthByOIX] = @p_FifteenthByOIX WHERE [AgreementID] = @p_AgreementID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Agreement] SET [CreatedAt] = @p_CreatedAt WHERE [AgreementID] = @p_AgreementID_out

END

