if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDriverGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDriverGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyDriver] table.
CREATE PROCEDURE pFASTPORTPartyDriverGet
        @pk_DriverID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyDriver]
    WHERE [DriverID] =@pk_DriverID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [DriverID],
        [PartyID],
        [TruckerTypeID],
        [DateOfBirth],
        [SocialSecurityNumber],
        [USCitizen],
        [AuthorizedAlien],
        [AuthorizationTypeID],
        [VisaNumber],
        [CertifiedBrakeInspector],
        [MoreThanOneLicense],
        [PromiseToNotifyIn24Hours],
        [PromiseNeverSuspended],
        [DrugTestedWithLastCarrier],
        [PromisedNeverPostiveOnDrugTest],
        [ReturnedToDuty],
        [ContactInfoComplete],
        [PersonalInfoComplete],
        [RepresentationsComplete],
        [EstAccidentsID],
        [EstTicketsID],
        [EstFailedTestsID],
        [EstFeloniesID],
        [ProgBasic],
        [ProgHistory],
        [ProgExperience],
        [ProgIncidents],
        [ProgDoc],
        [ProgeeEquip],
        [GaugeID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([DriverID],[PartyID],[TruckerTypeID],[DateOfBirth],[SocialSecurityNumber],[USCitizen],[AuthorizedAlien],[AuthorizationTypeID],[VisaNumber],[CertifiedBrakeInspector],[MoreThanOneLicense],[PromiseToNotifyIn24Hours],[PromiseNeverSuspended],[DrugTestedWithLastCarrier],[PromisedNeverPostiveOnDrugTest],[ReturnedToDuty],[ContactInfoComplete],[PersonalInfoComplete],[RepresentationsComplete],[EstAccidentsID],[EstTicketsID],[EstFailedTestsID],[EstFeloniesID],[ProgBasic],[ProgHistory],[ProgExperience],[ProgIncidents],[ProgDoc],[ProgeeEquip],[GaugeID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyDriver]
    WHERE [DriverID] =@pk_DriverID
    SET NOCOUNT OFF
END

