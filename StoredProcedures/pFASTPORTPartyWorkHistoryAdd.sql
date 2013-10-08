if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyWorkHistory] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryAdd
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
    @p_HistoryID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyWorkHistory]
        (
            [PartyID],
            [StartMonthID],
            [EndMonthID],
            [EmployerID],
            [EmployerCompany],
            [EmployerAddr],
            [EmployerZipID],
            [EmployerCountryID],
            [EmployerContact],
            [EmployerEmail],
            [EmployerPhone],
            [EmployerFax],
            [ReasonForLeavingID],
            [ReasonForLeavingNotes],
            [Notes],
            [TerminalID],
            [HireDate],
            [TermDate]
        )
    VALUES
        (
             @p_PartyID,
             @p_StartMonthID,
             @p_EndMonthID,
             @p_EmployerID,
             @p_EmployerCompany,
             @p_EmployerAddr,
             @p_EmployerZipID,
             @p_EmployerCountryID,
             @p_EmployerContact,
             @p_EmployerEmail,
             @p_EmployerPhone,
             @p_EmployerFax,
             @p_ReasonForLeavingID,
             @p_ReasonForLeavingNotes,
             @p_Notes,
             @p_TerminalID,
             @p_HireDate,
             @p_TermDate
        )

    SET @p_HistoryID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Employed IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [Employed] = @p_Employed WHERE [HistoryID] = @p_HistoryID_out

    IF @p_DrivingPosition IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [DrivingPosition] = @p_DrivingPosition WHERE [HistoryID] = @p_HistoryID_out

    IF @p_MilesPerWeek IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [MilesPerWeek] = @p_MilesPerWeek WHERE [HistoryID] = @p_HistoryID_out

    IF @p_OperatedCommercialMotorVechicle IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [OperatedCommercialMotorVechicle] = @p_OperatedCommercialMotorVechicle WHERE [HistoryID] = @p_HistoryID_out

    IF @p_HadDrugTestingProgram IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [HadDrugTestingProgram] = @p_HadDrugTestingProgram WHERE [HistoryID] = @p_HistoryID_out

    IF @p_MayWeContact IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [MayWeContact] = @p_MayWeContact WHERE [HistoryID] = @p_HistoryID_out

    IF @p_FirstJob IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [FirstJob] = @p_FirstJob WHERE [HistoryID] = @p_HistoryID_out

    IF @p_Finished IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [Finished] = @p_Finished WHERE [HistoryID] = @p_HistoryID_out

    IF @p_FinishedExp IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [FinishedExp] = @p_FinishedExp WHERE [HistoryID] = @p_HistoryID_out

    IF @p_Overlap IS NOT NULL
        UPDATE [dbo].[PartyWorkHistory] SET [Overlap] = @p_Overlap WHERE [HistoryID] = @p_HistoryID_out

END

