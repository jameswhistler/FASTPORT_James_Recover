if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTDocAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Doc] table.
CREATE PROCEDURE pFASTPORTDocAdd
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
    @p_DocID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Doc]
        (
            [CIX],
            [PartyID],
            [FiledAsID],
            [AgreementID],
            [DocName],
            [DocPdf],
            [DocNumber],
            [DocIssued],
            [DocIssuingStateID],
            [DocExpiration],
            [DocEndorsements],
            [DocNotes],
            [FlowStepID],
            [InstanceID],
            [ExecutionID],
            [AttachmentID],
            [EquipID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_CIX,
             @p_PartyID,
             @p_FiledAsID,
             @p_AgreementID,
             @p_DocName,
             @p_DocPdf,
             @p_DocNumber,
             @p_DocIssued,
             @p_DocIssuingStateID,
             @p_DocExpiration,
             @p_DocEndorsements,
             @p_DocNotes,
             @p_FlowStepID,
             @p_InstanceID,
             @p_ExecutionID,
             @p_AttachmentID,
             @p_EquipID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_DocID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Reissued IS NOT NULL
        UPDATE [dbo].[Doc] SET [Reissued] = @p_Reissued WHERE [DocID] = @p_DocID_out

    IF @p_FinishedRecordingDetails IS NOT NULL
        UPDATE [dbo].[Doc] SET [FinishedRecordingDetails] = @p_FinishedRecordingDetails WHERE [DocID] = @p_DocID_out

    IF @p_PrivateFile IS NOT NULL
        UPDATE [dbo].[Doc] SET [PrivateFile] = @p_PrivateFile WHERE [DocID] = @p_DocID_out

    IF @p_ProcessedPages IS NOT NULL
        UPDATE [dbo].[Doc] SET [ProcessedPages] = @p_ProcessedPages WHERE [DocID] = @p_DocID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Doc] SET [CreatedAt] = @p_CreatedAt WHERE [DocID] = @p_DocID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[Doc] SET [UpdatedAt] = @p_UpdatedAt WHERE [DocID] = @p_DocID_out

END

