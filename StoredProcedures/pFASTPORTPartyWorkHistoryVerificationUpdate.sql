if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyWorkHistoryVerification] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationUpdate
    @pk_VerificationID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyWorkHistoryVerification] WHERE [VerificationID] = @pk_VerificationID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyWorkHistoryVerification]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyWorkHistoryVerification]
            SET 
            [HistoryID] = @p_HistoryID,
            [FlowStepID] = @p_FlowStepID,
            [RequestedByID] = @p_RequestedByID,
            [RequestedAt] = @p_RequestedAt,
            [RequestAttempts] = @p_RequestAttempts,
            [RequestIntervalID] = @p_RequestIntervalID,
            [DatesYesNo] = @p_DatesYesNo,
            [DatesExplain] = @p_DatesExplain,
            [MotorVehicleYesNo] = @p_MotorVehicleYesNo,
            [FailedTestYesNo] = @p_FailedTestYesNo,
            [FailedTestExplain] = @p_FailedTestExplain,
            [RefusedTestYesNo] = @p_RefusedTestYesNo,
            [RefusedTestExplain] = @p_RefusedTestExplain,
            [ConductYesNo] = @p_ConductYesNo,
            [ConductExplain] = @p_ConductExplain,
            [TruckingInfoYesNo] = @p_TruckingInfoYesNo,
            [TruckingInfoComments] = @p_TruckingInfoComments,
            [GeneralComments] = @p_GeneralComments,
            [SignerID] = @p_SignerID,
            [SignerFreeHand] = @p_SignerFreeHand,
            [SignatureFile] = @p_SignatureFile,
            [InstanceID] = @p_InstanceID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [VerificationID] = @pk_VerificationID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([VerificationID],[HistoryID],[FlowStepID],[RequestedByID],[RequestedAt],[RequestAttempts],[RequestIntervalID],[DatesYesNo],[DatesExplain],[MotorVehicleYesNo],[FailedTestYesNo],[FailedTestExplain],[RefusedTestYesNo],[RefusedTestExplain],[ConductYesNo],[ConductExplain],[TruckingInfoYesNo],[TruckingInfoComments],[GeneralComments],[SignerID],[SignerFreeHand],[SignatureFile],[InstanceID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[PartyWorkHistoryVerification] with (rowlock, holdlock)
            WHERE [VerificationID] = @pk_VerificationID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyWorkHistoryVerification]
                    SET 
                    [HistoryID] = @p_HistoryID,
                    [FlowStepID] = @p_FlowStepID,
                    [RequestedByID] = @p_RequestedByID,
                    [RequestedAt] = @p_RequestedAt,
                    [RequestAttempts] = @p_RequestAttempts,
                    [RequestIntervalID] = @p_RequestIntervalID,
                    [DatesYesNo] = @p_DatesYesNo,
                    [DatesExplain] = @p_DatesExplain,
                    [MotorVehicleYesNo] = @p_MotorVehicleYesNo,
                    [FailedTestYesNo] = @p_FailedTestYesNo,
                    [FailedTestExplain] = @p_FailedTestExplain,
                    [RefusedTestYesNo] = @p_RefusedTestYesNo,
                    [RefusedTestExplain] = @p_RefusedTestExplain,
                    [ConductYesNo] = @p_ConductYesNo,
                    [ConductExplain] = @p_ConductExplain,
                    [TruckingInfoYesNo] = @p_TruckingInfoYesNo,
                    [TruckingInfoComments] = @p_TruckingInfoComments,
                    [GeneralComments] = @p_GeneralComments,
                    [SignerID] = @p_SignerID,
                    [SignerFreeHand] = @p_SignerFreeHand,
                    [SignatureFile] = @p_SignatureFile,
                    [InstanceID] = @p_InstanceID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [VerificationID] = @pk_VerificationID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyWorkHistoryVerification]', 16, 1)

        END
END

