if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyIncident] table.
CREATE PROCEDURE pFASTPORTPartyIncidentAdd
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
    @p_IncidentID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyIncident]
        (
            [PartyID],
            [IncidentCategoryID],
            [ShortDescription],
            [DetailedDescription],
            [OccurredOn],
            [AccidentLocationID],
            [EqiupTypeID],
            [CargoTypeID],
            [ReinstatedOn],
            [SAPReleaseDate],
            [PhysicalLimitationExpiration],
            [IncidentExpiration],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyID,
             @p_IncidentCategoryID,
             @p_ShortDescription,
             @p_DetailedDescription,
             @p_OccurredOn,
             @p_AccidentLocationID,
             @p_EqiupTypeID,
             @p_CargoTypeID,
             @p_ReinstatedOn,
             @p_SAPReleaseDate,
             @p_PhysicalLimitationExpiration,
             @p_IncidentExpiration,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_IncidentID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_IWasAtFault IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [IWasAtFault] = @p_IWasAtFault WHERE [IncidentID] = @p_IncidentID_out

    IF @p_EstimatedCost IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [EstimatedCost] = @p_EstimatedCost WHERE [IncidentID] = @p_IncidentID_out

    IF @p_FileClosed IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [FileClosed] = @p_FileClosed WHERE [IncidentID] = @p_IncidentID_out

    IF @p_TowAWayAccident IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [TowAWayAccident] = @p_TowAWayAccident WHERE [IncidentID] = @p_IncidentID_out

    IF @p_FatalitiesOccured IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [FatalitiesOccured] = @p_FatalitiesOccured WHERE [IncidentID] = @p_IncidentID_out

    IF @p_InjuriesOccured IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [InjuriesOccured] = @p_InjuriesOccured WHERE [IncidentID] = @p_IncidentID_out

    IF @p_TestedAfterAccident IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [TestedAfterAccident] = @p_TestedAfterAccident WHERE [IncidentID] = @p_IncidentID_out

    IF @p_PositiveForDrugs IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [PositiveForDrugs] = @p_PositiveForDrugs WHERE [IncidentID] = @p_IncidentID_out

    IF @p_PositiveForAlcohol IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [PositiveForAlcohol] = @p_PositiveForAlcohol WHERE [IncidentID] = @p_IncidentID_out

    IF @p_Ticketed IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [Ticketed] = @p_Ticketed WHERE [IncidentID] = @p_IncidentID_out

    IF @p_RuledAsRecklessDriving IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [RuledAsRecklessDriving] = @p_RuledAsRecklessDriving WHERE [IncidentID] = @p_IncidentID_out

    IF @p_FelonyIssued IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [FelonyIssued] = @p_FelonyIssued WHERE [IncidentID] = @p_IncidentID_out

    IF @p_LicenseSuspended IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [LicenseSuspended] = @p_LicenseSuspended WHERE [IncidentID] = @p_IncidentID_out

    IF @p_SAPRelease IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [SAPRelease] = @p_SAPRelease WHERE [IncidentID] = @p_IncidentID_out

    IF @p_PhysicalObsolete IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [PhysicalObsolete] = @p_PhysicalObsolete WHERE [IncidentID] = @p_IncidentID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [CreatedAt] = @p_CreatedAt WHERE [IncidentID] = @p_IncidentID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [UpdatedAt] = @p_UpdatedAt WHERE [IncidentID] = @p_IncidentID_out

    IF @p_LockIncident IS NOT NULL
        UPDATE [dbo].[PartyIncident] SET [LockIncident] = @p_LockIncident WHERE [IncidentID] = @p_IncidentID_out

END

