if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Agreement] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTAgreementUpdate
    @pk_AgreementID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Agreement] WHERE [AgreementID] = @pk_AgreementID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Agreement]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Agreement]
            SET 
            [CIX] = @p_CIX,
            [DocTreeParentID] = @p_DocTreeParentID,
            [RoleID] = @p_RoleID,
            [CustomID] = @p_CustomID,
            [DocIndex] = @p_DocIndex,
            [DocSort] = @p_DocSort,
            [Agreement] = @p_Agreement,
            [Description] = @p_Description,
            [RequiredDoc] = @p_RequiredDoc,
            [DocRank] = @p_DocRank,
            [Hide] = @p_Hide,
            [AgreementFile] = @p_AgreementFile,
            [AgreementFileName] = @p_AgreementFileName,
            [FlowCollectionID] = @p_FlowCollectionID,
            [UseStoredSignature] = @p_UseStoredSignature,
            [ShowSignatureDate] = @p_ShowSignatureDate,
            [ShowExpirationDate] = @p_ShowExpirationDate,
            [InitialsInDocument] = @p_InitialsInDocument,
            [DocHasCustomFields] = @p_DocHasCustomFields,
            [ExecuteFromBoard] = @p_ExecuteFromBoard,
            [SenderInstructions] = @p_SenderInstructions,
            [RecipientInstructions] = @p_RecipientInstructions,
            [OtherInstructions] = @p_OtherInstructions,
            [FirstItem] = @p_FirstItem,
            [FirstTypeID] = @p_FirstTypeID,
            [FirstDefault] = @p_FirstDefault,
            [FirstByCIX] = @p_FirstByCIX,
            [FirstByOIX] = @p_FirstByOIX,
            [SecondItem] = @p_SecondItem,
            [SecondTypeID] = @p_SecondTypeID,
            [SecondDefault] = @p_SecondDefault,
            [SecondByCIX] = @p_SecondByCIX,
            [SecondByOIX] = @p_SecondByOIX,
            [ThirdItem] = @p_ThirdItem,
            [ThirdTypeID] = @p_ThirdTypeID,
            [ThirdDefault] = @p_ThirdDefault,
            [ThirdByCIX] = @p_ThirdByCIX,
            [ThirdByOIX] = @p_ThirdByOIX,
            [FourthItem] = @p_FourthItem,
            [FourthTypeID] = @p_FourthTypeID,
            [FourthDefault] = @p_FourthDefault,
            [FourthByCIX] = @p_FourthByCIX,
            [FourthByOIX] = @p_FourthByOIX,
            [FifthItem] = @p_FifthItem,
            [FifthTypeID] = @p_FifthTypeID,
            [FifthDefault] = @p_FifthDefault,
            [FifthByCIX] = @p_FifthByCIX,
            [FifthByOIX] = @p_FifthByOIX,
            [SixthItem] = @p_SixthItem,
            [SixthTypeID] = @p_SixthTypeID,
            [SixthDefault] = @p_SixthDefault,
            [SixthByCIX] = @p_SixthByCIX,
            [SixthByOIX] = @p_SixthByOIX,
            [SeventhItem] = @p_SeventhItem,
            [SeventhTypeID] = @p_SeventhTypeID,
            [SeventhDefault] = @p_SeventhDefault,
            [SeventhByCIX] = @p_SeventhByCIX,
            [SeventhByOIX] = @p_SeventhByOIX,
            [EighthItem] = @p_EighthItem,
            [EighthTypeID] = @p_EighthTypeID,
            [EighthDefault] = @p_EighthDefault,
            [EighthByCIX] = @p_EighthByCIX,
            [EighthByOIX] = @p_EighthByOIX,
            [NinthItem] = @p_NinthItem,
            [NinthTypeID] = @p_NinthTypeID,
            [NinthDefault] = @p_NinthDefault,
            [NinthByCIX] = @p_NinthByCIX,
            [NinthByOIX] = @p_NinthByOIX,
            [TenthItem] = @p_TenthItem,
            [TenthTypeID] = @p_TenthTypeID,
            [TenthDefault] = @p_TenthDefault,
            [TenthByCIX] = @p_TenthByCIX,
            [TenthByOIX] = @p_TenthByOIX,
            [EleventhItem] = @p_EleventhItem,
            [EleventhTypeID] = @p_EleventhTypeID,
            [EleventhDefault] = @p_EleventhDefault,
            [EleventhByCIX] = @p_EleventhByCIX,
            [EleventhByOIX] = @p_EleventhByOIX,
            [TwelfthItem] = @p_TwelfthItem,
            [TwelfthTypeID] = @p_TwelfthTypeID,
            [TwelfthDefault] = @p_TwelfthDefault,
            [TwelfthByCIX] = @p_TwelfthByCIX,
            [TwelfthByOIX] = @p_TwelfthByOIX,
            [ThirteenthItem] = @p_ThirteenthItem,
            [ThirteenthTypeID] = @p_ThirteenthTypeID,
            [ThirteenthDefault] = @p_ThirteenthDefault,
            [ThirteenthByCIX] = @p_ThirteenthByCIX,
            [ThirteenthByOIX] = @p_ThirteenthByOIX,
            [FourteenthItem] = @p_FourteenthItem,
            [FourteenthTypeID] = @p_FourteenthTypeID,
            [FourteenthDefault] = @p_FourteenthDefault,
            [FourteenthByCIX] = @p_FourteenthByCIX,
            [FourteenthByOIX] = @p_FourteenthByOIX,
            [FifteenthItem] = @p_FifteenthItem,
            [FifteenthTypeID] = @p_FifteenthTypeID,
            [FifteenthDefault] = @p_FifteenthDefault,
            [FifteenthByCIX] = @p_FifteenthByCIX,
            [FifteenthByOIX] = @p_FifteenthByOIX,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [AgreementID] = @pk_AgreementID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AgreementID],[CIX],[DocTreeParentID],[RoleID],[CustomID],[DocIndex],[DocSort],[Agreement],[Description],[RequiredDoc],[DocRank],[Hide],[AgreementFile],[AgreementFileName],[FlowCollectionID],[UseStoredSignature],[ShowSignatureDate],[ShowExpirationDate],[InitialsInDocument],[DocHasCustomFields],[ExecuteFromBoard],[SenderInstructions],[RecipientInstructions],[OtherInstructions],[FirstItem],[FirstTypeID],[FirstDefault],[FirstByCIX],[FirstByOIX],[SecondItem],[SecondTypeID],[SecondDefault],[SecondByCIX],[SecondByOIX],[ThirdItem],[ThirdTypeID],[ThirdDefault],[ThirdByCIX],[ThirdByOIX],[FourthItem],[FourthTypeID],[FourthDefault],[FourthByCIX],[FourthByOIX],[FifthItem],[FifthTypeID],[FifthDefault],[FifthByCIX],[FifthByOIX],[SixthItem],[SixthTypeID],[SixthDefault],[SixthByCIX],[SixthByOIX],[SeventhItem],[SeventhTypeID],[SeventhDefault],[SeventhByCIX],[SeventhByOIX],[EighthItem],[EighthTypeID],[EighthDefault],[EighthByCIX],[EighthByOIX],[NinthItem],[NinthTypeID],[NinthDefault],[NinthByCIX],[NinthByOIX],[TenthItem],[TenthTypeID],[TenthDefault],[TenthByCIX],[TenthByOIX],[EleventhItem],[EleventhTypeID],[EleventhDefault],[EleventhByCIX],[EleventhByOIX],[TwelfthItem],[TwelfthTypeID],[TwelfthDefault],[TwelfthByCIX],[TwelfthByOIX],[ThirteenthItem],[ThirteenthTypeID],[ThirteenthDefault],[ThirteenthByCIX],[ThirteenthByOIX],[FourteenthItem],[FourteenthTypeID],[FourteenthDefault],[FourteenthByCIX],[FourteenthByOIX],[FifteenthItem],[FifteenthTypeID],[FifteenthDefault],[FifteenthByCIX],[FifteenthByOIX],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[Agreement] with (rowlock, holdlock)
            WHERE [AgreementID] = @pk_AgreementID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Agreement]
                    SET 
                    [CIX] = @p_CIX,
                    [DocTreeParentID] = @p_DocTreeParentID,
                    [RoleID] = @p_RoleID,
                    [CustomID] = @p_CustomID,
                    [DocIndex] = @p_DocIndex,
                    [DocSort] = @p_DocSort,
                    [Agreement] = @p_Agreement,
                    [Description] = @p_Description,
                    [RequiredDoc] = @p_RequiredDoc,
                    [DocRank] = @p_DocRank,
                    [Hide] = @p_Hide,
                    [AgreementFile] = @p_AgreementFile,
                    [AgreementFileName] = @p_AgreementFileName,
                    [FlowCollectionID] = @p_FlowCollectionID,
                    [UseStoredSignature] = @p_UseStoredSignature,
                    [ShowSignatureDate] = @p_ShowSignatureDate,
                    [ShowExpirationDate] = @p_ShowExpirationDate,
                    [InitialsInDocument] = @p_InitialsInDocument,
                    [DocHasCustomFields] = @p_DocHasCustomFields,
                    [ExecuteFromBoard] = @p_ExecuteFromBoard,
                    [SenderInstructions] = @p_SenderInstructions,
                    [RecipientInstructions] = @p_RecipientInstructions,
                    [OtherInstructions] = @p_OtherInstructions,
                    [FirstItem] = @p_FirstItem,
                    [FirstTypeID] = @p_FirstTypeID,
                    [FirstDefault] = @p_FirstDefault,
                    [FirstByCIX] = @p_FirstByCIX,
                    [FirstByOIX] = @p_FirstByOIX,
                    [SecondItem] = @p_SecondItem,
                    [SecondTypeID] = @p_SecondTypeID,
                    [SecondDefault] = @p_SecondDefault,
                    [SecondByCIX] = @p_SecondByCIX,
                    [SecondByOIX] = @p_SecondByOIX,
                    [ThirdItem] = @p_ThirdItem,
                    [ThirdTypeID] = @p_ThirdTypeID,
                    [ThirdDefault] = @p_ThirdDefault,
                    [ThirdByCIX] = @p_ThirdByCIX,
                    [ThirdByOIX] = @p_ThirdByOIX,
                    [FourthItem] = @p_FourthItem,
                    [FourthTypeID] = @p_FourthTypeID,
                    [FourthDefault] = @p_FourthDefault,
                    [FourthByCIX] = @p_FourthByCIX,
                    [FourthByOIX] = @p_FourthByOIX,
                    [FifthItem] = @p_FifthItem,
                    [FifthTypeID] = @p_FifthTypeID,
                    [FifthDefault] = @p_FifthDefault,
                    [FifthByCIX] = @p_FifthByCIX,
                    [FifthByOIX] = @p_FifthByOIX,
                    [SixthItem] = @p_SixthItem,
                    [SixthTypeID] = @p_SixthTypeID,
                    [SixthDefault] = @p_SixthDefault,
                    [SixthByCIX] = @p_SixthByCIX,
                    [SixthByOIX] = @p_SixthByOIX,
                    [SeventhItem] = @p_SeventhItem,
                    [SeventhTypeID] = @p_SeventhTypeID,
                    [SeventhDefault] = @p_SeventhDefault,
                    [SeventhByCIX] = @p_SeventhByCIX,
                    [SeventhByOIX] = @p_SeventhByOIX,
                    [EighthItem] = @p_EighthItem,
                    [EighthTypeID] = @p_EighthTypeID,
                    [EighthDefault] = @p_EighthDefault,
                    [EighthByCIX] = @p_EighthByCIX,
                    [EighthByOIX] = @p_EighthByOIX,
                    [NinthItem] = @p_NinthItem,
                    [NinthTypeID] = @p_NinthTypeID,
                    [NinthDefault] = @p_NinthDefault,
                    [NinthByCIX] = @p_NinthByCIX,
                    [NinthByOIX] = @p_NinthByOIX,
                    [TenthItem] = @p_TenthItem,
                    [TenthTypeID] = @p_TenthTypeID,
                    [TenthDefault] = @p_TenthDefault,
                    [TenthByCIX] = @p_TenthByCIX,
                    [TenthByOIX] = @p_TenthByOIX,
                    [EleventhItem] = @p_EleventhItem,
                    [EleventhTypeID] = @p_EleventhTypeID,
                    [EleventhDefault] = @p_EleventhDefault,
                    [EleventhByCIX] = @p_EleventhByCIX,
                    [EleventhByOIX] = @p_EleventhByOIX,
                    [TwelfthItem] = @p_TwelfthItem,
                    [TwelfthTypeID] = @p_TwelfthTypeID,
                    [TwelfthDefault] = @p_TwelfthDefault,
                    [TwelfthByCIX] = @p_TwelfthByCIX,
                    [TwelfthByOIX] = @p_TwelfthByOIX,
                    [ThirteenthItem] = @p_ThirteenthItem,
                    [ThirteenthTypeID] = @p_ThirteenthTypeID,
                    [ThirteenthDefault] = @p_ThirteenthDefault,
                    [ThirteenthByCIX] = @p_ThirteenthByCIX,
                    [ThirteenthByOIX] = @p_ThirteenthByOIX,
                    [FourteenthItem] = @p_FourteenthItem,
                    [FourteenthTypeID] = @p_FourteenthTypeID,
                    [FourteenthDefault] = @p_FourteenthDefault,
                    [FourteenthByCIX] = @p_FourteenthByCIX,
                    [FourteenthByOIX] = @p_FourteenthByOIX,
                    [FifteenthItem] = @p_FifteenthItem,
                    [FifteenthTypeID] = @p_FifteenthTypeID,
                    [FifteenthDefault] = @p_FifteenthDefault,
                    [FifteenthByCIX] = @p_FifteenthByCIX,
                    [FifteenthByOIX] = @p_FifteenthByOIX,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [AgreementID] = @pk_AgreementID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Agreement]', 16, 1)

        END
END

