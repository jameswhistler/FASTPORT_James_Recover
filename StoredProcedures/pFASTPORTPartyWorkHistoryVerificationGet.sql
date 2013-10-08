if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyWorkHistoryVerification] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationGet
        @pk_VerificationID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyWorkHistoryVerification]
    WHERE [VerificationID] =@pk_VerificationID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [VerificationID],
        [HistoryID],
        [FlowStepID],
        [RequestedByID],
        [RequestedAt],
        [RequestAttempts],
        [RequestIntervalID],
        [DatesYesNo],
        [DatesExplain],
        [MotorVehicleYesNo],
        [FailedTestYesNo],
        [FailedTestExplain],
        [RefusedTestYesNo],
        [RefusedTestExplain],
        [ConductYesNo],
        [ConductExplain],
        [TruckingInfoYesNo],
        [TruckingInfoComments],
        [GeneralComments],
        [SignerID],
        [SignerFreeHand],
        [SignatureFile],
        [InstanceID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([VerificationID],[HistoryID],[FlowStepID],[RequestedByID],[RequestedAt],[RequestAttempts],[RequestIntervalID],[DatesYesNo],[DatesExplain],[MotorVehicleYesNo],[FailedTestYesNo],[FailedTestExplain],[RefusedTestYesNo],[RefusedTestExplain],[ConductYesNo],[ConductExplain],[TruckingInfoYesNo],[TruckingInfoComments],[GeneralComments],[SignerID],[SignerFreeHand],[SignatureFile],[InstanceID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyWorkHistoryVerification]
    WHERE [VerificationID] =@pk_VerificationID
    SET NOCOUNT OFF
END

