if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExecutionUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExecutionUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[AgreementExecution] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTAgreementExecutionUpdate
    @pk_ExecutionID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[AgreementExecution] WHERE [ExecutionID] = @pk_ExecutionID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[AgreementExecution]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[AgreementExecution]
            SET 
            [CIX] = @p_CIX,
            [OIX] = @p_OIX,
            [AgreementID] = @p_AgreementID,
            [SenderAddrID] = @p_SenderAddrID,
            [SenderSignerID] = @p_SenderSignerID,
            [RecipientAddrID] = @p_RecipientAddrID,
            [RecipientSignerID] = @p_RecipientSignerID,
            [SignedOn] = @p_SignedOn,
            [ExpiresOn] = @p_ExpiresOn,
            [UseOutsideTemplate] = @p_UseOutsideTemplate,
            [UseOutsidePdf] = @p_UseOutsidePdf,
            [AgreementFileDoc] = @p_AgreementFileDoc,
            [AgreementFilePdf] = @p_AgreementFilePdf,
            [SenderSignature] = @p_SenderSignature,
            [SenderInitials] = @p_SenderInitials,
            [SenderSignedAt] = @p_SenderSignedAt,
            [SenderSignedFrom] = @p_SenderSignedFrom,
            [RecipientSignature] = @p_RecipientSignature,
            [RecipientInitials] = @p_RecipientInitials,
            [RecipientSignedAt] = @p_RecipientSignedAt,
            [RecipientSignedFrom] = @p_RecipientSignedFrom,
            [AddSignaturePage] = @p_AddSignaturePage,
            [FlowStepID] = @p_FlowStepID,
            [InstanceID] = @p_InstanceID,
            [FirstItem] = @p_FirstItem,
            [SecondItem] = @p_SecondItem,
            [ThirdItem] = @p_ThirdItem,
            [FourthItem] = @p_FourthItem,
            [FifthItem] = @p_FifthItem,
            [SixthItem] = @p_SixthItem,
            [SeventhItem] = @p_SeventhItem,
            [EighthItem] = @p_EighthItem,
            [NinthItem] = @p_NinthItem,
            [TenthItem] = @p_TenthItem,
            [EleventhItem] = @p_EleventhItem,
            [TwelfthItem] = @p_TwelfthItem,
            [ThirteenthItem] = @p_ThirteenthItem,
            [FourteenthItem] = @p_FourteenthItem,
            [FifteenthItem] = @p_FifteenthItem,
            [BarCode] = @p_BarCode,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [ExecutionID] = @pk_ExecutionID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ExecutionID],[CIX],[OIX],[AgreementID],[SenderAddrID],[SenderSignerID],[RecipientAddrID],[RecipientSignerID],[SignedOn],[ExpiresOn],[UseOutsideTemplate],[UseOutsidePdf],[AgreementFileDoc],[AgreementFilePdf],[SenderSignature],[SenderInitials],[SenderSignedAt],[SenderSignedFrom],[RecipientSignature],[RecipientInitials],[RecipientSignedAt],[RecipientSignedFrom],[AddSignaturePage],[FlowStepID],[InstanceID],[FirstItem],[SecondItem],[ThirdItem],[FourthItem],[FifthItem],[SixthItem],[SeventhItem],[EighthItem],[NinthItem],[TenthItem],[EleventhItem],[TwelfthItem],[ThirteenthItem],[FourteenthItem],[FifteenthItem],[BarCode],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[AgreementExecution] with (rowlock, holdlock)
            WHERE [ExecutionID] = @pk_ExecutionID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[AgreementExecution]
                    SET 
                    [CIX] = @p_CIX,
                    [OIX] = @p_OIX,
                    [AgreementID] = @p_AgreementID,
                    [SenderAddrID] = @p_SenderAddrID,
                    [SenderSignerID] = @p_SenderSignerID,
                    [RecipientAddrID] = @p_RecipientAddrID,
                    [RecipientSignerID] = @p_RecipientSignerID,
                    [SignedOn] = @p_SignedOn,
                    [ExpiresOn] = @p_ExpiresOn,
                    [UseOutsideTemplate] = @p_UseOutsideTemplate,
                    [UseOutsidePdf] = @p_UseOutsidePdf,
                    [AgreementFileDoc] = @p_AgreementFileDoc,
                    [AgreementFilePdf] = @p_AgreementFilePdf,
                    [SenderSignature] = @p_SenderSignature,
                    [SenderInitials] = @p_SenderInitials,
                    [SenderSignedAt] = @p_SenderSignedAt,
                    [SenderSignedFrom] = @p_SenderSignedFrom,
                    [RecipientSignature] = @p_RecipientSignature,
                    [RecipientInitials] = @p_RecipientInitials,
                    [RecipientSignedAt] = @p_RecipientSignedAt,
                    [RecipientSignedFrom] = @p_RecipientSignedFrom,
                    [AddSignaturePage] = @p_AddSignaturePage,
                    [FlowStepID] = @p_FlowStepID,
                    [InstanceID] = @p_InstanceID,
                    [FirstItem] = @p_FirstItem,
                    [SecondItem] = @p_SecondItem,
                    [ThirdItem] = @p_ThirdItem,
                    [FourthItem] = @p_FourthItem,
                    [FifthItem] = @p_FifthItem,
                    [SixthItem] = @p_SixthItem,
                    [SeventhItem] = @p_SeventhItem,
                    [EighthItem] = @p_EighthItem,
                    [NinthItem] = @p_NinthItem,
                    [TenthItem] = @p_TenthItem,
                    [EleventhItem] = @p_EleventhItem,
                    [TwelfthItem] = @p_TwelfthItem,
                    [ThirteenthItem] = @p_ThirteenthItem,
                    [FourteenthItem] = @p_FourteenthItem,
                    [FifteenthItem] = @p_FifteenthItem,
                    [BarCode] = @p_BarCode,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [ExecutionID] = @pk_ExecutionID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[AgreementExecution]', 16, 1)

        END
END

