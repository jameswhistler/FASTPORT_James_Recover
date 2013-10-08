if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocGet') and sysstat & 0xf = 4) drop procedure pFASTPORTDocGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Doc] table.
CREATE PROCEDURE pFASTPORTDocGet
        @pk_DocID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Doc]
    WHERE [DocID] =@pk_DocID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [DocID],
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
        [Reissued],
        [DocEndorsements],
        [DocNotes],
        [FinishedRecordingDetails],
        [PrivateFile],
        [FlowStepID],
        [InstanceID],
        [ExecutionID],
        [AttachmentID],
        [EquipID],
        [ProcessedPages],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([DocID],[CIX],[PartyID],[FiledAsID],[AgreementID],[DocName],[DocPdf],[DocNumber],[DocIssued],[DocIssuingStateID],[DocExpiration],[Reissued],[DocEndorsements],[DocNotes],[FinishedRecordingDetails],[PrivateFile],[FlowStepID],[InstanceID],[ExecutionID],[AttachmentID],[EquipID],[ProcessedPages],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Doc]
    WHERE [DocID] =@pk_DocID
    SET NOCOUNT OFF
END

