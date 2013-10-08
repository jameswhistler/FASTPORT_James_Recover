if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExecutionGet') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExecutionGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[AgreementExecution] table.
CREATE PROCEDURE pFASTPORTAgreementExecutionGet
        @pk_ExecutionID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[AgreementExecution]
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
        [SenderAddrID],
        [SenderSignerID],
        [RecipientAddrID],
        [RecipientSignerID],
        [SignedOn],
        [ExpiresOn],
        [UseOutsideTemplate],
        [UseOutsidePdf],
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
        [AddSignaturePage],
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
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([ExecutionID],[CIX],[OIX],[AgreementID],[SenderAddrID],[SenderSignerID],[RecipientAddrID],[RecipientSignerID],[SignedOn],[ExpiresOn],[UseOutsideTemplate],[UseOutsidePdf],[AgreementFileDoc],[AgreementFilePdf],[SenderSignature],[SenderInitials],[SenderSignedAt],[SenderSignedFrom],[RecipientSignature],[RecipientInitials],[RecipientSignedAt],[RecipientSignedFrom],[AddSignaturePage],[FlowStepID],[InstanceID],[FirstItem],[SecondItem],[ThirdItem],[FourthItem],[FifthItem],[SixthItem],[SeventhItem],[EighthItem],[NinthItem],[TenthItem],[EleventhItem],[TwelfthItem],[ThirteenthItem],[FourteenthItem],[FifteenthItem],[BarCode],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[AgreementExecution]
    WHERE [ExecutionID] =@pk_ExecutionID
    SET NOCOUNT OFF
END

