if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyWorkHistory] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryUpdate
    @pk_HistoryID int,
    @p_PartyID int,
    @p_StartMonthID int,
    @p_EndMonthID int,
    @p_Employed bit,
    @p_DrivingPosition bit,
    @p_EmployerID int,
    @p_EmployerCompany varchar(255),
    @p_EmployerAddr varchar(255),
    @p_EmployerZipID int,
    @p_EmployerCountryID int,
    @p_EmployerContact varchar(50),
    @p_EmployerEmail varchar(50),
    @p_EmployerPhone varchar(50),
    @p_EmployerFax varchar(50),
    @p_ReasonForLeavingID int,
    @p_ReasonForLeavingNotes varchar(2000),
    @p_MilesPerWeek int,
    @p_OperatedCommercialMotorVechicle bit,
    @p_HadDrugTestingProgram bit,
    @p_MayWeContact bit,
    @p_FirstJob bit,
    @p_Finished bit,
    @p_FinishedExp bit,
    @p_Notes varchar(2000),
    @p_TerminalID int,
    @p_HireDate datetime,
    @p_TermDate datetime,
    @p_Overlap int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyWorkHistory] WHERE [HistoryID] = @pk_HistoryID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyWorkHistory]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyWorkHistory]
            SET 
            [PartyID] = @p_PartyID,
            [StartMonthID] = @p_StartMonthID,
            [EndMonthID] = @p_EndMonthID,
            [Employed] = @p_Employed,
            [DrivingPosition] = @p_DrivingPosition,
            [EmployerID] = @p_EmployerID,
            [EmployerCompany] = @p_EmployerCompany,
            [EmployerAddr] = @p_EmployerAddr,
            [EmployerZipID] = @p_EmployerZipID,
            [EmployerCountryID] = @p_EmployerCountryID,
            [EmployerContact] = @p_EmployerContact,
            [EmployerEmail] = @p_EmployerEmail,
            [EmployerPhone] = @p_EmployerPhone,
            [EmployerFax] = @p_EmployerFax,
            [ReasonForLeavingID] = @p_ReasonForLeavingID,
            [ReasonForLeavingNotes] = @p_ReasonForLeavingNotes,
            [MilesPerWeek] = @p_MilesPerWeek,
            [OperatedCommercialMotorVechicle] = @p_OperatedCommercialMotorVechicle,
            [HadDrugTestingProgram] = @p_HadDrugTestingProgram,
            [MayWeContact] = @p_MayWeContact,
            [FirstJob] = @p_FirstJob,
            [Finished] = @p_Finished,
            [FinishedExp] = @p_FinishedExp,
            [Notes] = @p_Notes,
            [TerminalID] = @p_TerminalID,
            [HireDate] = @p_HireDate,
            [TermDate] = @p_TermDate,
            [Overlap] = @p_Overlap
            WHERE [HistoryID] = @pk_HistoryID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([HistoryID],[PartyID],[StartMonthID],[EndMonthID],[Employed],[DrivingPosition],[EmployerID],[EmployerCompany],[EmployerAddr],[EmployerZipID],[EmployerCountryID],[EmployerContact],[EmployerEmail],[EmployerPhone],[EmployerFax],[ReasonForLeavingID],[ReasonForLeavingNotes],[MilesPerWeek],[OperatedCommercialMotorVechicle],[HadDrugTestingProgram],[MayWeContact],[FirstJob],[Finished],[FinishedExp],[Notes],[TerminalID],[HireDate],[TermDate],[Overlap]) AS nvarchar(4000)) 
            FROM [dbo].[PartyWorkHistory] with (rowlock, holdlock)
            WHERE [HistoryID] = @pk_HistoryID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyWorkHistory]
                    SET 
                    [PartyID] = @p_PartyID,
                    [StartMonthID] = @p_StartMonthID,
                    [EndMonthID] = @p_EndMonthID,
                    [Employed] = @p_Employed,
                    [DrivingPosition] = @p_DrivingPosition,
                    [EmployerID] = @p_EmployerID,
                    [EmployerCompany] = @p_EmployerCompany,
                    [EmployerAddr] = @p_EmployerAddr,
                    [EmployerZipID] = @p_EmployerZipID,
                    [EmployerCountryID] = @p_EmployerCountryID,
                    [EmployerContact] = @p_EmployerContact,
                    [EmployerEmail] = @p_EmployerEmail,
                    [EmployerPhone] = @p_EmployerPhone,
                    [EmployerFax] = @p_EmployerFax,
                    [ReasonForLeavingID] = @p_ReasonForLeavingID,
                    [ReasonForLeavingNotes] = @p_ReasonForLeavingNotes,
                    [MilesPerWeek] = @p_MilesPerWeek,
                    [OperatedCommercialMotorVechicle] = @p_OperatedCommercialMotorVechicle,
                    [HadDrugTestingProgram] = @p_HadDrugTestingProgram,
                    [MayWeContact] = @p_MayWeContact,
                    [FirstJob] = @p_FirstJob,
                    [Finished] = @p_Finished,
                    [FinishedExp] = @p_FinishedExp,
                    [Notes] = @p_Notes,
                    [TerminalID] = @p_TerminalID,
                    [HireDate] = @p_HireDate,
                    [TermDate] = @p_TermDate,
                    [Overlap] = @p_Overlap
                    WHERE [HistoryID] = @pk_HistoryID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyWorkHistory]', 16, 1)

        END
END

