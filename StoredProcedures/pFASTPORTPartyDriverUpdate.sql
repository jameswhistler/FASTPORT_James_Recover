if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDriverUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDriverUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyDriver] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyDriverUpdate
    @pk_DriverID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyDriver] WHERE [DriverID] = @pk_DriverID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyDriver]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyDriver]
            SET 
            [PartyID] = @p_PartyID,
            [TruckerTypeID] = @p_TruckerTypeID,
            [DateOfBirth] = @p_DateOfBirth,
            [SocialSecurityNumber] = @p_SocialSecurityNumber,
            [USCitizen] = @p_USCitizen,
            [AuthorizedAlien] = @p_AuthorizedAlien,
            [AuthorizationTypeID] = @p_AuthorizationTypeID,
            [VisaNumber] = @p_VisaNumber,
            [CertifiedBrakeInspector] = @p_CertifiedBrakeInspector,
            [MoreThanOneLicense] = @p_MoreThanOneLicense,
            [PromiseToNotifyIn24Hours] = @p_PromiseToNotifyIn24Hours,
            [PromiseNeverSuspended] = @p_PromiseNeverSuspended,
            [DrugTestedWithLastCarrier] = @p_DrugTestedWithLastCarrier,
            [PromisedNeverPostiveOnDrugTest] = @p_PromisedNeverPostiveOnDrugTest,
            [ReturnedToDuty] = @p_ReturnedToDuty,
            [ContactInfoComplete] = @p_ContactInfoComplete,
            [PersonalInfoComplete] = @p_PersonalInfoComplete,
            [RepresentationsComplete] = @p_RepresentationsComplete,
            [EstAccidentsID] = @p_EstAccidentsID,
            [EstTicketsID] = @p_EstTicketsID,
            [EstFailedTestsID] = @p_EstFailedTestsID,
            [EstFeloniesID] = @p_EstFeloniesID,
            [ProgBasic] = @p_ProgBasic,
            [ProgHistory] = @p_ProgHistory,
            [ProgExperience] = @p_ProgExperience,
            [ProgIncidents] = @p_ProgIncidents,
            [ProgDoc] = @p_ProgDoc,
            [ProgeeEquip] = @p_ProgeeEquip,
            [GaugeID] = @p_GaugeID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [DriverID] = @pk_DriverID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([DriverID],[PartyID],[TruckerTypeID],[DateOfBirth],[SocialSecurityNumber],[USCitizen],[AuthorizedAlien],[AuthorizationTypeID],[VisaNumber],[CertifiedBrakeInspector],[MoreThanOneLicense],[PromiseToNotifyIn24Hours],[PromiseNeverSuspended],[DrugTestedWithLastCarrier],[PromisedNeverPostiveOnDrugTest],[ReturnedToDuty],[ContactInfoComplete],[PersonalInfoComplete],[RepresentationsComplete],[EstAccidentsID],[EstTicketsID],[EstFailedTestsID],[EstFeloniesID],[ProgBasic],[ProgHistory],[ProgExperience],[ProgIncidents],[ProgDoc],[ProgeeEquip],[GaugeID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[PartyDriver] with (rowlock, holdlock)
            WHERE [DriverID] = @pk_DriverID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyDriver]
                    SET 
                    [PartyID] = @p_PartyID,
                    [TruckerTypeID] = @p_TruckerTypeID,
                    [DateOfBirth] = @p_DateOfBirth,
                    [SocialSecurityNumber] = @p_SocialSecurityNumber,
                    [USCitizen] = @p_USCitizen,
                    [AuthorizedAlien] = @p_AuthorizedAlien,
                    [AuthorizationTypeID] = @p_AuthorizationTypeID,
                    [VisaNumber] = @p_VisaNumber,
                    [CertifiedBrakeInspector] = @p_CertifiedBrakeInspector,
                    [MoreThanOneLicense] = @p_MoreThanOneLicense,
                    [PromiseToNotifyIn24Hours] = @p_PromiseToNotifyIn24Hours,
                    [PromiseNeverSuspended] = @p_PromiseNeverSuspended,
                    [DrugTestedWithLastCarrier] = @p_DrugTestedWithLastCarrier,
                    [PromisedNeverPostiveOnDrugTest] = @p_PromisedNeverPostiveOnDrugTest,
                    [ReturnedToDuty] = @p_ReturnedToDuty,
                    [ContactInfoComplete] = @p_ContactInfoComplete,
                    [PersonalInfoComplete] = @p_PersonalInfoComplete,
                    [RepresentationsComplete] = @p_RepresentationsComplete,
                    [EstAccidentsID] = @p_EstAccidentsID,
                    [EstTicketsID] = @p_EstTicketsID,
                    [EstFailedTestsID] = @p_EstFailedTestsID,
                    [EstFeloniesID] = @p_EstFeloniesID,
                    [ProgBasic] = @p_ProgBasic,
                    [ProgHistory] = @p_ProgHistory,
                    [ProgExperience] = @p_ProgExperience,
                    [ProgIncidents] = @p_ProgIncidents,
                    [ProgDoc] = @p_ProgDoc,
                    [ProgeeEquip] = @p_ProgeeEquip,
                    [GaugeID] = @p_GaugeID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [DriverID] = @pk_DriverID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyDriver]', 16, 1)

        END
END

