if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyWorkHistory] table.
CREATE PROCEDURE pFASTPORTPartyWorkHistoryGet
        @pk_HistoryID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyWorkHistory]
    WHERE [HistoryID] =@pk_HistoryID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [HistoryID],
        [PartyID],
        [StartMonthID],
        [EndMonthID],
        [Employed],
        [DrivingPosition],
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
        [MilesPerWeek],
        [OperatedCommercialMotorVechicle],
        [HadDrugTestingProgram],
        [MayWeContact],
        [FirstJob],
        [Finished],
        [FinishedExp],
        [Notes],
        [TerminalID],
        [HireDate],
        [TermDate],
        [Overlap],
        CAST(BINARY_CHECKSUM([HistoryID],[PartyID],[StartMonthID],[EndMonthID],[Employed],[DrivingPosition],[EmployerID],[EmployerCompany],[EmployerAddr],[EmployerZipID],[EmployerCountryID],[EmployerContact],[EmployerEmail],[EmployerPhone],[EmployerFax],[ReasonForLeavingID],[ReasonForLeavingNotes],[MilesPerWeek],[OperatedCommercialMotorVechicle],[HadDrugTestingProgram],[MayWeContact],[FirstJob],[Finished],[FinishedExp],[Notes],[TerminalID],[HireDate],[TermDate],[Overlap]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyWorkHistory]
    WHERE [HistoryID] =@pk_HistoryID
    SET NOCOUNT OFF
END

