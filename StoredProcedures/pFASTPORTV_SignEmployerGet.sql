if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignEmployerGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignEmployerGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_SignEmployer] table.
CREATE PROCEDURE pFASTPORTV_SignEmployerGet
        @pk_VerificationID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_SignEmployer]
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
        [PartyID],
        [E_Name],
        [E_DBA],
        [E_DBAOrName],
        [E_AddrHTML],
        [E_Addr],
        [E_CitySTZip],
        [E_City],
        [E_ST],
        [E_Zip],
        [E_Country],
        [E_ContactInfoHTML],
        [E_EmploymentDates],
        [E_VerQuestions],
        [E_TruckingInfoYesNo],
        [E_TruckingInfoExplain],
        [E_GeneralComments],
        [E_Signer],
        [E_Signature]
    FROM [dbo].[v_SignEmployer]
    WHERE [VerificationID] =@pk_VerificationID
    SET NOCOUNT OFF
END

