if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CarrierAd] table.
CREATE PROCEDURE pFASTPORTCarrierAdAdd
    @p_CarrierID int,
    @p_AdTemplate bit,
    @p_AdName varchar(255),
    @p_TruckerTypeID int,
    @p_ShortDescription varchar(2000),
    @p_LongDescription varchar(4000),
    @p_RunOn datetime,
    @p_ExpireOn datetime,
    @p_LimitByAge bit,
    @p_PositionsAvail int,
    @p_MinAge int,
    @p_HideAd bit,
    @p_MapThumbnail image,
    @p_PSPMaximum int,
    @p_LimitByMajorAccidents bit,
    @p_MajorByID int,
    @p_MajorCountID int,
    @p_MajorMilesID int,
    @p_MajorYearsID int,
    @p_LimitByMinorAccidents bit,
    @p_MinorByID int,
    @p_MinorCountID int,
    @p_MinorMilesID int,
    @p_MinorYearsID int,
    @p_LimitByTickets bit,
    @p_TicketsByID int,
    @p_TicketCountID int,
    @p_TicketMilesID int,
    @p_TicketYearsID int,
    @p_LimitBySeriousTickets bit,
    @p_SeriousByID int,
    @p_SeriousCountID int,
    @p_SeriousMilesID int,
    @p_SeriousYearsID int,
    @p_LimitByFelonies bit,
    @p_FeloniesByID int,
    @p_FelonyCountID int,
    @p_FelonyMilesID int,
    @p_FelonyYearsID int,
    @p_LimitByDrugConvictions bit,
    @p_DrugConvictionsByID int,
    @p_DrugCountID int,
    @p_DrugConvictionMilesID int,
    @p_DrugYearsID int,
    @p_LimitByFailedTest bit,
    @p_FailedByID int,
    @p_FailedCountID int,
    @p_FailedMilesID int,
    @p_FailedYearsID int,
    @p_LimitByDUICommercial bit,
    @p_CommDUIByID int,
    @p_CommDUICountID int,
    @p_CommDUIMilesID int,
    @p_CommDUIYearsID int,
    @p_LimitByDUIPersonal bit,
    @p_PersonalDUIByID int,
    @p_PersonalDUICountID int,
    @p_PersonalDUIMilesID int,
    @p_PersonalDUIYearsID int,
    @p_PayTypeID int,
    @p_LineHaulPerc float,
    @p_LoadedPerMile money,
    @p_EmptyPerMile money,
    @p_HourlyRate money,
    @p_AvgPayPerWeek money,
    @p_PayGuaranty bit,
    @p_FuelReimbursed bit,
    @p_AllFuel bit,
    @p_FuelGuaranty bit,
    @p_PayNotes varchar(2000),
    @p_OtherRequirements varchar(4000),
    @p_LinksToOtherPostings varchar(4000),
    @p_NoAd bit,
    @p_AdID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CarrierAd]
        (
            [CarrierID],
            [AdName],
            [TruckerTypeID],
            [ShortDescription],
            [LongDescription],
            [RunOn],
            [ExpireOn],
            [PositionsAvail],
            [MinAge],
            [MapThumbnail],
            [PSPMaximum],
            [PayTypeID],
            [PayNotes],
            [OtherRequirements],
            [LinksToOtherPostings]
        )
    VALUES
        (
             @p_CarrierID,
             @p_AdName,
             @p_TruckerTypeID,
             @p_ShortDescription,
             @p_LongDescription,
             @p_RunOn,
             @p_ExpireOn,
             @p_PositionsAvail,
             @p_MinAge,
             @p_MapThumbnail,
             @p_PSPMaximum,
             @p_PayTypeID,
             @p_PayNotes,
             @p_OtherRequirements,
             @p_LinksToOtherPostings
        )

    SET @p_AdID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_AdTemplate IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [AdTemplate] = @p_AdTemplate WHERE [AdID] = @p_AdID_out

    IF @p_LimitByAge IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByAge] = @p_LimitByAge WHERE [AdID] = @p_AdID_out

    IF @p_HideAd IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [HideAd] = @p_HideAd WHERE [AdID] = @p_AdID_out

    IF @p_LimitByMajorAccidents IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByMajorAccidents] = @p_LimitByMajorAccidents WHERE [AdID] = @p_AdID_out

    IF @p_MajorByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MajorByID] = @p_MajorByID WHERE [AdID] = @p_AdID_out

    IF @p_MajorCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MajorCountID] = @p_MajorCountID WHERE [AdID] = @p_AdID_out

    IF @p_MajorMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MajorMilesID] = @p_MajorMilesID WHERE [AdID] = @p_AdID_out

    IF @p_MajorYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MajorYearsID] = @p_MajorYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByMinorAccidents IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByMinorAccidents] = @p_LimitByMinorAccidents WHERE [AdID] = @p_AdID_out

    IF @p_MinorByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MinorByID] = @p_MinorByID WHERE [AdID] = @p_AdID_out

    IF @p_MinorCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MinorCountID] = @p_MinorCountID WHERE [AdID] = @p_AdID_out

    IF @p_MinorMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MinorMilesID] = @p_MinorMilesID WHERE [AdID] = @p_AdID_out

    IF @p_MinorYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [MinorYearsID] = @p_MinorYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByTickets IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByTickets] = @p_LimitByTickets WHERE [AdID] = @p_AdID_out

    IF @p_TicketsByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [TicketsByID] = @p_TicketsByID WHERE [AdID] = @p_AdID_out

    IF @p_TicketCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [TicketCountID] = @p_TicketCountID WHERE [AdID] = @p_AdID_out

    IF @p_TicketMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [TicketMilesID] = @p_TicketMilesID WHERE [AdID] = @p_AdID_out

    IF @p_TicketYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [TicketYearsID] = @p_TicketYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitBySeriousTickets IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitBySeriousTickets] = @p_LimitBySeriousTickets WHERE [AdID] = @p_AdID_out

    IF @p_SeriousByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [SeriousByID] = @p_SeriousByID WHERE [AdID] = @p_AdID_out

    IF @p_SeriousCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [SeriousCountID] = @p_SeriousCountID WHERE [AdID] = @p_AdID_out

    IF @p_SeriousMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [SeriousMilesID] = @p_SeriousMilesID WHERE [AdID] = @p_AdID_out

    IF @p_SeriousYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [SeriousYearsID] = @p_SeriousYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByFelonies IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByFelonies] = @p_LimitByFelonies WHERE [AdID] = @p_AdID_out

    IF @p_FeloniesByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FeloniesByID] = @p_FeloniesByID WHERE [AdID] = @p_AdID_out

    IF @p_FelonyCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FelonyCountID] = @p_FelonyCountID WHERE [AdID] = @p_AdID_out

    IF @p_FelonyMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FelonyMilesID] = @p_FelonyMilesID WHERE [AdID] = @p_AdID_out

    IF @p_FelonyYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FelonyYearsID] = @p_FelonyYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByDrugConvictions IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByDrugConvictions] = @p_LimitByDrugConvictions WHERE [AdID] = @p_AdID_out

    IF @p_DrugConvictionsByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [DrugConvictionsByID] = @p_DrugConvictionsByID WHERE [AdID] = @p_AdID_out

    IF @p_DrugCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [DrugCountID] = @p_DrugCountID WHERE [AdID] = @p_AdID_out

    IF @p_DrugConvictionMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [DrugConvictionMilesID] = @p_DrugConvictionMilesID WHERE [AdID] = @p_AdID_out

    IF @p_DrugYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [DrugYearsID] = @p_DrugYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByFailedTest IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByFailedTest] = @p_LimitByFailedTest WHERE [AdID] = @p_AdID_out

    IF @p_FailedByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FailedByID] = @p_FailedByID WHERE [AdID] = @p_AdID_out

    IF @p_FailedCountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FailedCountID] = @p_FailedCountID WHERE [AdID] = @p_AdID_out

    IF @p_FailedMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FailedMilesID] = @p_FailedMilesID WHERE [AdID] = @p_AdID_out

    IF @p_FailedYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FailedYearsID] = @p_FailedYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByDUICommercial IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByDUICommercial] = @p_LimitByDUICommercial WHERE [AdID] = @p_AdID_out

    IF @p_CommDUIByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [CommDUIByID] = @p_CommDUIByID WHERE [AdID] = @p_AdID_out

    IF @p_CommDUICountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [CommDUICountID] = @p_CommDUICountID WHERE [AdID] = @p_AdID_out

    IF @p_CommDUIMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [CommDUIMilesID] = @p_CommDUIMilesID WHERE [AdID] = @p_AdID_out

    IF @p_CommDUIYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [CommDUIYearsID] = @p_CommDUIYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LimitByDUIPersonal IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LimitByDUIPersonal] = @p_LimitByDUIPersonal WHERE [AdID] = @p_AdID_out

    IF @p_PersonalDUIByID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [PersonalDUIByID] = @p_PersonalDUIByID WHERE [AdID] = @p_AdID_out

    IF @p_PersonalDUICountID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [PersonalDUICountID] = @p_PersonalDUICountID WHERE [AdID] = @p_AdID_out

    IF @p_PersonalDUIMilesID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [PersonalDUIMilesID] = @p_PersonalDUIMilesID WHERE [AdID] = @p_AdID_out

    IF @p_PersonalDUIYearsID IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [PersonalDUIYearsID] = @p_PersonalDUIYearsID WHERE [AdID] = @p_AdID_out

    IF @p_LineHaulPerc IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LineHaulPerc] = @p_LineHaulPerc WHERE [AdID] = @p_AdID_out

    IF @p_LoadedPerMile IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [LoadedPerMile] = @p_LoadedPerMile WHERE [AdID] = @p_AdID_out

    IF @p_EmptyPerMile IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [EmptyPerMile] = @p_EmptyPerMile WHERE [AdID] = @p_AdID_out

    IF @p_HourlyRate IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [HourlyRate] = @p_HourlyRate WHERE [AdID] = @p_AdID_out

    IF @p_AvgPayPerWeek IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [AvgPayPerWeek] = @p_AvgPayPerWeek WHERE [AdID] = @p_AdID_out

    IF @p_PayGuaranty IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [PayGuaranty] = @p_PayGuaranty WHERE [AdID] = @p_AdID_out

    IF @p_FuelReimbursed IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FuelReimbursed] = @p_FuelReimbursed WHERE [AdID] = @p_AdID_out

    IF @p_AllFuel IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [AllFuel] = @p_AllFuel WHERE [AdID] = @p_AdID_out

    IF @p_FuelGuaranty IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [FuelGuaranty] = @p_FuelGuaranty WHERE [AdID] = @p_AdID_out

    IF @p_NoAd IS NOT NULL
        UPDATE [dbo].[CarrierAd] SET [NoAd] = @p_NoAd WHERE [AdID] = @p_AdID_out

END

