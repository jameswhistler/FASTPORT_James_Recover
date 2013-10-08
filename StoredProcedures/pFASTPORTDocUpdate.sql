if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTDocUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Doc] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTDocUpdate
    @pk_DocID int,
    @p_CIX int,
    @p_PartyID int,
    @p_FiledAsID int,
    @p_AgreementID int,
    @p_DocName varchar(50),
    @p_DocPdf image,
    @p_DocNumber varchar(50),
    @p_DocIssued datetime,
    @p_DocIssuingStateID int,
    @p_DocExpiration datetime,
    @p_Reissued bit,
    @p_DocEndorsements varchar(255),
    @p_DocNotes varchar(2000),
    @p_FinishedRecordingDetails bit,
    @p_PrivateFile bit,
    @p_FlowStepID int,
    @p_InstanceID int,
    @p_ExecutionID int,
    @p_AttachmentID int,
    @p_EquipID int,
    @p_ProcessedPages bit,
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
    IF NOT EXISTS (SELECT * FROM [dbo].[Doc] WHERE [DocID] = @pk_DocID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Doc]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Doc]
            SET 
            [CIX] = @p_CIX,
            [PartyID] = @p_PartyID,
            [FiledAsID] = @p_FiledAsID,
            [AgreementID] = @p_AgreementID,
            [DocName] = @p_DocName,
            [DocPdf] = @p_DocPdf,
            [DocNumber] = @p_DocNumber,
            [DocIssued] = @p_DocIssued,
            [DocIssuingStateID] = @p_DocIssuingStateID,
            [DocExpiration] = @p_DocExpiration,
            [Reissued] = @p_Reissued,
            [DocEndorsements] = @p_DocEndorsements,
            [DocNotes] = @p_DocNotes,
            [FinishedRecordingDetails] = @p_FinishedRecordingDetails,
            [PrivateFile] = @p_PrivateFile,
            [FlowStepID] = @p_FlowStepID,
            [InstanceID] = @p_InstanceID,
            [ExecutionID] = @p_ExecutionID,
            [AttachmentID] = @p_AttachmentID,
            [EquipID] = @p_EquipID,
            [ProcessedPages] = @p_ProcessedPages,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [DocID] = @pk_DocID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([DocID],[CIX],[PartyID],[FiledAsID],[AgreementID],[DocName],[DocPdf],[DocNumber],[DocIssued],[DocIssuingStateID],[DocExpiration],[Reissued],[DocEndorsements],[DocNotes],[FinishedRecordingDetails],[PrivateFile],[FlowStepID],[InstanceID],[ExecutionID],[AttachmentID],[EquipID],[ProcessedPages],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[Doc] with (rowlock, holdlock)
            WHERE [DocID] = @pk_DocID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Doc]
                    SET 
                    [CIX] = @p_CIX,
                    [PartyID] = @p_PartyID,
                    [FiledAsID] = @p_FiledAsID,
                    [AgreementID] = @p_AgreementID,
                    [DocName] = @p_DocName,
                    [DocPdf] = @p_DocPdf,
                    [DocNumber] = @p_DocNumber,
                    [DocIssued] = @p_DocIssued,
                    [DocIssuingStateID] = @p_DocIssuingStateID,
                    [DocExpiration] = @p_DocExpiration,
                    [Reissued] = @p_Reissued,
                    [DocEndorsements] = @p_DocEndorsements,
                    [DocNotes] = @p_DocNotes,
                    [FinishedRecordingDetails] = @p_FinishedRecordingDetails,
                    [PrivateFile] = @p_PrivateFile,
                    [FlowStepID] = @p_FlowStepID,
                    [InstanceID] = @p_InstanceID,
                    [ExecutionID] = @p_ExecutionID,
                    [AttachmentID] = @p_AttachmentID,
                    [EquipID] = @p_EquipID,
                    [ProcessedPages] = @p_ProcessedPages,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [DocID] = @pk_DocID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Doc]', 16, 1)

        END
END

