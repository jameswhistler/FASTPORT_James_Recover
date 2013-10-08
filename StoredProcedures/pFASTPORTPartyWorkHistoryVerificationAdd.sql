if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyWorkHistoryVerification] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationAdd
    @p_HistoryID int,
    @p_FlowStepID int,
    @p_RequestedByID int,
    @p_RequestedAt datetime,
    @p_RequestAttempts int,
    @p_RequestIntervalID int,
    @p_DatesYesNo bit,
    @p_DatesExplain varchar(2000),
    @p_MotorVehicleYesNo bit,
    @p_FailedTestYesNo bit,
    @p_FailedTestExplain varchar(2000),
    @p_RefusedTestYesNo bit,
    @p_RefusedTestExplain varchar(2000),
    @p_ConductYesNo bit,
    @p_ConductExplain varchar(2000),
    @p_TruckingInfoYesNo bit,
    @p_TruckingInfoComments varchar(2000),
    @p_GeneralComments varchar(2000),
    @p_SignerID int,
    @p_SignerFreeHand varchar(50),
    @p_SignatureFile image,
    @p_InstanceID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_VerificationID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyWorkHistoryVerification]
        (
            [HistoryID],
            [FlowStepID],
            [RequestedByID],
            [RequestedAt],
            [RequestAttempts],
            [RequestIntervalID],
            [DatesExplain],
            [FailedTestExplain],
            [RefusedTestExplain],
            [ConductExplain],
            [TruckingInfoComments],
            [GeneralComments],
            [SignerID],
            [SignerFreeHand],
            [SignatureFile],
            [InstanceID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_HistoryID,
             @p_FlowStepID,
             @p_RequestedByID,
             @p_RequestedAt,
             @p_RequestAttempts,
             @p_RequestIntervalID,
             @p_DatesExplain,
             @p_FailedTestExplain,
             @p_RefusedTestExplain,
             @p_ConductExplain,
             @p_TruckingInfoComments,
             @p_GeneralComments,
             @p_SignerID,
             @p_SignerFreeHand,
             @p_SignatureFile,
             @p_InstanceID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_VerificationID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_DatesYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [DatesYesNo] = @p_DatesYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_MotorVehicleYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [MotorVehicleYesNo] = @p_MotorVehicleYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_FailedTestYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [FailedTestYesNo] = @p_FailedTestYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_RefusedTestYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [RefusedTestYesNo] = @p_RefusedTestYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_ConductYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [ConductYesNo] = @p_ConductYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_TruckingInfoYesNo IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [TruckingInfoYesNo] = @p_TruckingInfoYesNo WHERE [VerificationID] = @p_VerificationID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [CreatedAt] = @p_CreatedAt WHERE [VerificationID] = @p_VerificationID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyWorkHistoryVerification] SET [UpdatedAt] = @p_UpdatedAt WHERE [VerificationID] = @p_VerificationID_out

END

