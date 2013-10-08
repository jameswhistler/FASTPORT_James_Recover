if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExecutionAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExecutionAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[AgreementExecution] table.
CREATE PROCEDURE pFASTPORTAgreementExecutionAdd
    @p_CIX int,
    @p_OIX int,
    @p_AgreementID int,
    @p_SenderAddrID int,
    @p_SenderSignerID int,
    @p_RecipientAddrID int,
    @p_RecipientSignerID int,
    @p_SignedOn datetime,
    @p_ExpiresOn datetime,
    @p_UseOutsideTemplate bit,
    @p_UseOutsidePdf bit,
    @p_AgreementFileDoc image,
    @p_AgreementFilePdf image,
    @p_SenderSignature image,
    @p_SenderInitials image,
    @p_SenderSignedAt datetime,
    @p_SenderSignedFrom varchar(25),
    @p_RecipientSignature image,
    @p_RecipientInitials image,
    @p_RecipientSignedAt datetime,
    @p_RecipientSignedFrom varchar(45),
    @p_AddSignaturePage bit,
    @p_FlowStepID int,
    @p_InstanceID int,
    @p_FirstItem varchar(1000),
    @p_SecondItem varchar(1000),
    @p_ThirdItem varchar(1000),
    @p_FourthItem varchar(1000),
    @p_FifthItem varchar(1000),
    @p_SixthItem varchar(1000),
    @p_SeventhItem varchar(1000),
    @p_EighthItem varchar(1000),
    @p_NinthItem varchar(1000),
    @p_TenthItem varchar(1000),
    @p_EleventhItem varchar(1000),
    @p_TwelfthItem varchar(1000),
    @p_ThirteenthItem varchar(1000),
    @p_FourteenthItem varchar(1000),
    @p_FifteenthItem varchar(1000),
    @p_BarCode image,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_ExecutionID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[AgreementExecution]
        (
            [CIX],
            [OIX],
            [AgreementID],
            [SenderAddrID],
            [SenderSignerID],
            [RecipientAddrID],
            [RecipientSignerID],
            [SignedOn],
            [ExpiresOn],
            [UseOutsideTemplate],
            [AgreementFileDoc],
            [AgreementFilePdf],
            [SenderSignature],
            [SenderInitials],
            [SenderSignedAt],
            [SenderSignedFrom],
            [RecipientSignature],
            [RecipientInitials],
            [RecipientSignedAt],
            [RecipientSignedFrom],
            [FlowStepID],
            [InstanceID],
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
            [BarCode],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_CIX,
             @p_OIX,
             @p_AgreementID,
             @p_SenderAddrID,
             @p_SenderSignerID,
             @p_RecipientAddrID,
             @p_RecipientSignerID,
             @p_SignedOn,
             @p_ExpiresOn,
             @p_UseOutsideTemplate,
             @p_AgreementFileDoc,
             @p_AgreementFilePdf,
             @p_SenderSignature,
             @p_SenderInitials,
             @p_SenderSignedAt,
             @p_SenderSignedFrom,
             @p_RecipientSignature,
             @p_RecipientInitials,
             @p_RecipientSignedAt,
             @p_RecipientSignedFrom,
             @p_FlowStepID,
             @p_InstanceID,
             @p_FirstItem,
             @p_SecondItem,
             @p_ThirdItem,
             @p_FourthItem,
             @p_FifthItem,
             @p_SixthItem,
             @p_SeventhItem,
             @p_EighthItem,
             @p_NinthItem,
             @p_TenthItem,
             @p_EleventhItem,
             @p_TwelfthItem,
             @p_ThirteenthItem,
             @p_FourteenthItem,
             @p_FifteenthItem,
             @p_BarCode,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_ExecutionID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_UseOutsidePdf IS NOT NULL
        UPDATE [dbo].[AgreementExecution] SET [UseOutsidePdf] = @p_UseOutsidePdf WHERE [ExecutionID] = @p_ExecutionID_out

    IF @p_AddSignaturePage IS NOT NULL
        UPDATE [dbo].[AgreementExecution] SET [AddSignaturePage] = @p_AddSignaturePage WHERE [ExecutionID] = @p_ExecutionID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[AgreementExecution] SET [CreatedAt] = @p_CreatedAt WHERE [ExecutionID] = @p_ExecutionID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[AgreementExecution] SET [UpdatedAt] = @p_UpdatedAt WHERE [ExecutionID] = @p_ExecutionID_out

END

