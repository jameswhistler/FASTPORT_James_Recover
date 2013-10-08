if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_HistoryLoadRWGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_HistoryLoadRWGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_HistoryLoadRW] table.
CREATE PROCEDURE pFASTPORTV_HistoryLoadRWGet
        @pk_HistoryID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_HistoryLoadRW]
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
        [StartMonth],
        [EndMonth],
        [PositionTypeID],
        [CurrentPastID],
        [CarrierID],
        [EmployerCompany],
        [EmployerAddr],
        [EmployerZipID],
        [EmployerCitySTZip],
        [EmployerCountryID],
        [EmployerCountry],
        [EmployerEmail],
        [EmployerPhone],
        [EmployerFax],
        [EmployerContact],
        [MilesPerWeek],
        [ReasonForLeavingID],
        [ReasonForLeaving],
        [ReasonForLeavingNotes],
        [OperatedCommercialMotorVechicle],
        [HadDrugTestingProgram],
        [Notes],
        [MayWeContact],
        [FirstJob],
        [ShowFirstJob],
        [Finished]
    FROM [dbo].[v_HistoryLoadRW]
    WHERE [HistoryID] =@pk_HistoryID
    SET NOCOUNT OFF
END

