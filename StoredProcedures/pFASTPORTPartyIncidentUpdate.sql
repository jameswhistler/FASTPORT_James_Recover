if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyIncident] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyIncidentUpdate
    @pk_IncidentID int,
    @p_PartyID int,
    @p_IncidentCategoryID int,
    @p_ShortDescription varchar(50),
    @p_DetailedDescription varchar(max),
    @p_OccurredOn datetime,
    @p_AccidentLocationID int,
    @p_IWasAtFault bit,
    @p_EstimatedCost money,
    @p_FileClosed bit,
    @p_TowAWayAccident bit,
    @p_FatalitiesOccured bit,
    @p_InjuriesOccured bit,
    @p_TestedAfterAccident bit,
    @p_PositiveForDrugs bit,
    @p_PositiveForAlcohol bit,
    @p_EqiupTypeID int,
    @p_CargoTypeID int,
    @p_Ticketed bit,
    @p_RuledAsRecklessDriving bit,
    @p_FelonyIssued bit,
    @p_LicenseSuspended bit,
    @p_ReinstatedOn datetime,
    @p_SAPRelease bit,
    @p_SAPReleaseDate datetime,
    @p_PhysicalLimitationExpiration datetime,
    @p_PhysicalObsolete bit,
    @p_IncidentExpiration datetime,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_LockIncident bit,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyIncident] WHERE [IncidentID] = @pk_IncidentID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyIncident]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyIncident]
            SET 
            [PartyID] = @p_PartyID,
            [IncidentCategoryID] = @p_IncidentCategoryID,
            [ShortDescription] = @p_ShortDescription,
            [DetailedDescription] = @p_DetailedDescription,
            [OccurredOn] = @p_OccurredOn,
            [AccidentLocationID] = @p_AccidentLocationID,
            [IWasAtFault] = @p_IWasAtFault,
            [EstimatedCost] = @p_EstimatedCost,
            [FileClosed] = @p_FileClosed,
            [TowAWayAccident] = @p_TowAWayAccident,
            [FatalitiesOccured] = @p_FatalitiesOccured,
            [InjuriesOccured] = @p_InjuriesOccured,
            [TestedAfterAccident] = @p_TestedAfterAccident,
            [PositiveForDrugs] = @p_PositiveForDrugs,
            [PositiveForAlcohol] = @p_PositiveForAlcohol,
            [EqiupTypeID] = @p_EqiupTypeID,
            [CargoTypeID] = @p_CargoTypeID,
            [Ticketed] = @p_Ticketed,
            [RuledAsRecklessDriving] = @p_RuledAsRecklessDriving,
            [FelonyIssued] = @p_FelonyIssued,
            [LicenseSuspended] = @p_LicenseSuspended,
            [ReinstatedOn] = @p_ReinstatedOn,
            [SAPRelease] = @p_SAPRelease,
            [SAPReleaseDate] = @p_SAPReleaseDate,
            [PhysicalLimitationExpiration] = @p_PhysicalLimitationExpiration,
            [PhysicalObsolete] = @p_PhysicalObsolete,
            [IncidentExpiration] = @p_IncidentExpiration,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [LockIncident] = @p_LockIncident
            WHERE [IncidentID] = @pk_IncidentID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([IncidentID],[PartyID],[IncidentCategoryID],[ShortDescription],[DetailedDescription],[OccurredOn],[AccidentLocationID],[IWasAtFault],[EstimatedCost],[FileClosed],[TowAWayAccident],[FatalitiesOccured],[InjuriesOccured],[TestedAfterAccident],[PositiveForDrugs],[PositiveForAlcohol],[EqiupTypeID],[CargoTypeID],[Ticketed],[RuledAsRecklessDriving],[FelonyIssued],[LicenseSuspended],[ReinstatedOn],[SAPRelease],[SAPReleaseDate],[PhysicalLimitationExpiration],[PhysicalObsolete],[IncidentExpiration],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[LockIncident]) AS nvarchar(4000)) 
            FROM [dbo].[PartyIncident] with (rowlock, holdlock)
            WHERE [IncidentID] = @pk_IncidentID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyIncident]
                    SET 
                    [PartyID] = @p_PartyID,
                    [IncidentCategoryID] = @p_IncidentCategoryID,
                    [ShortDescription] = @p_ShortDescription,
                    [DetailedDescription] = @p_DetailedDescription,
                    [OccurredOn] = @p_OccurredOn,
                    [AccidentLocationID] = @p_AccidentLocationID,
                    [IWasAtFault] = @p_IWasAtFault,
                    [EstimatedCost] = @p_EstimatedCost,
                    [FileClosed] = @p_FileClosed,
                    [TowAWayAccident] = @p_TowAWayAccident,
                    [FatalitiesOccured] = @p_FatalitiesOccured,
                    [InjuriesOccured] = @p_InjuriesOccured,
                    [TestedAfterAccident] = @p_TestedAfterAccident,
                    [PositiveForDrugs] = @p_PositiveForDrugs,
                    [PositiveForAlcohol] = @p_PositiveForAlcohol,
                    [EqiupTypeID] = @p_EqiupTypeID,
                    [CargoTypeID] = @p_CargoTypeID,
                    [Ticketed] = @p_Ticketed,
                    [RuledAsRecklessDriving] = @p_RuledAsRecklessDriving,
                    [FelonyIssued] = @p_FelonyIssued,
                    [LicenseSuspended] = @p_LicenseSuspended,
                    [ReinstatedOn] = @p_ReinstatedOn,
                    [SAPRelease] = @p_SAPRelease,
                    [SAPReleaseDate] = @p_SAPReleaseDate,
                    [PhysicalLimitationExpiration] = @p_PhysicalLimitationExpiration,
                    [PhysicalObsolete] = @p_PhysicalObsolete,
                    [IncidentExpiration] = @p_IncidentExpiration,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [LockIncident] = @p_LockIncident
                    WHERE [IncidentID] = @pk_IncidentID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyIncident]', 16, 1)

        END
END

