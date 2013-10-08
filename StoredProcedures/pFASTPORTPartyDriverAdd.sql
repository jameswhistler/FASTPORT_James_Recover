if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDriverAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDriverAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyDriver] table.
CREATE PROCEDURE pFASTPORTPartyDriverAdd
    @p_PartyID int,
    @p_TruckerTypeID int,
    @p_DateOfBirth datetime,
    @p_SocialSecurityNumber varchar(50),
    @p_USCitizen bit,
    @p_AuthorizedAlien bit,
    @p_AuthorizationTypeID int,
    @p_VisaNumber varchar(50),
    @p_CertifiedBrakeInspector bit,
    @p_MoreThanOneLicense bit,
    @p_PromiseToNotifyIn24Hours bit,
    @p_PromiseNeverSuspended bit,
    @p_DrugTestedWithLastCarrier bit,
    @p_PromisedNeverPostiveOnDrugTest bit,
    @p_ReturnedToDuty bit,
    @p_ContactInfoComplete bit,
    @p_PersonalInfoComplete bit,
    @p_RepresentationsComplete bit,
    @p_EstAccidentsID int,
    @p_EstTicketsID int,
    @p_EstFailedTestsID int,
    @p_EstFeloniesID int,
    @p_ProgBasic float,
    @p_ProgHistory float,
    @p_ProgExperience float,
    @p_ProgIncidents float,
    @p_ProgDoc float,
    @p_ProgeeEquip float,
    @p_GaugeID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_DriverID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyDriver]
        (
            [PartyID],
            [TruckerTypeID],
            [DateOfBirth],
            [SocialSecurityNumber],
            [AuthorizationTypeID],
            [VisaNumber],
            [EstAccidentsID],
            [EstTicketsID],
            [EstFailedTestsID],
            [EstFeloniesID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyID,
             @p_TruckerTypeID,
             @p_DateOfBirth,
             @p_SocialSecurityNumber,
             @p_AuthorizationTypeID,
             @p_VisaNumber,
             @p_EstAccidentsID,
             @p_EstTicketsID,
             @p_EstFailedTestsID,
             @p_EstFeloniesID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_DriverID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_USCitizen IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [USCitizen] = @p_USCitizen WHERE [DriverID] = @p_DriverID_out

    IF @p_AuthorizedAlien IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [AuthorizedAlien] = @p_AuthorizedAlien WHERE [DriverID] = @p_DriverID_out

    IF @p_CertifiedBrakeInspector IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [CertifiedBrakeInspector] = @p_CertifiedBrakeInspector WHERE [DriverID] = @p_DriverID_out

    IF @p_MoreThanOneLicense IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [MoreThanOneLicense] = @p_MoreThanOneLicense WHERE [DriverID] = @p_DriverID_out

    IF @p_PromiseToNotifyIn24Hours IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [PromiseToNotifyIn24Hours] = @p_PromiseToNotifyIn24Hours WHERE [DriverID] = @p_DriverID_out

    IF @p_PromiseNeverSuspended IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [PromiseNeverSuspended] = @p_PromiseNeverSuspended WHERE [DriverID] = @p_DriverID_out

    IF @p_DrugTestedWithLastCarrier IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [DrugTestedWithLastCarrier] = @p_DrugTestedWithLastCarrier WHERE [DriverID] = @p_DriverID_out

    IF @p_PromisedNeverPostiveOnDrugTest IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [PromisedNeverPostiveOnDrugTest] = @p_PromisedNeverPostiveOnDrugTest WHERE [DriverID] = @p_DriverID_out

    IF @p_ReturnedToDuty IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ReturnedToDuty] = @p_ReturnedToDuty WHERE [DriverID] = @p_DriverID_out

    IF @p_ContactInfoComplete IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ContactInfoComplete] = @p_ContactInfoComplete WHERE [DriverID] = @p_DriverID_out

    IF @p_PersonalInfoComplete IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [PersonalInfoComplete] = @p_PersonalInfoComplete WHERE [DriverID] = @p_DriverID_out

    IF @p_RepresentationsComplete IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [RepresentationsComplete] = @p_RepresentationsComplete WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgBasic IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgBasic] = @p_ProgBasic WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgHistory IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgHistory] = @p_ProgHistory WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgExperience IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgExperience] = @p_ProgExperience WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgIncidents IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgIncidents] = @p_ProgIncidents WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgDoc IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgDoc] = @p_ProgDoc WHERE [DriverID] = @p_DriverID_out

    IF @p_ProgeeEquip IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [ProgeeEquip] = @p_ProgeeEquip WHERE [DriverID] = @p_DriverID_out

    IF @p_GaugeID IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [GaugeID] = @p_GaugeID WHERE [DriverID] = @p_DriverID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [CreatedAt] = @p_CreatedAt WHERE [DriverID] = @p_DriverID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyDriver] SET [UpdatedAt] = @p_UpdatedAt WHERE [DriverID] = @p_DriverID_out

END

