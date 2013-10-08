if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGet') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CarrierAd] table.
CREATE PROCEDURE pFASTPORTCarrierAdGet
        @pk_AdID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CarrierAd]
    WHERE [AdID] =@pk_AdID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdID],
        [CarrierID],
        [AdTemplate],
        [AdName],
        [TruckerTypeID],
        [ShortDescription],
        [LongDescription],
        [RunOn],
        [ExpireOn],
        [LimitByAge],
        [PositionsAvail],
        [MinAge],
        [HideAd],
        [MapThumbnail],
        [PSPMaximum],
        [LimitByMajorAccidents],
        [MajorByID],
        [MajorCountID],
        [MajorMilesID],
        [MajorYearsID],
        [LimitByMinorAccidents],
        [MinorByID],
        [MinorCountID],
        [MinorMilesID],
        [MinorYearsID],
        [LimitByTickets],
        [TicketsByID],
        [TicketCountID],
        [TicketMilesID],
        [TicketYearsID],
        [LimitBySeriousTickets],
        [SeriousByID],
        [SeriousCountID],
        [SeriousMilesID],
        [SeriousYearsID],
        [LimitByFelonies],
        [FeloniesByID],
        [FelonyCountID],
        [FelonyMilesID],
        [FelonyYearsID],
        [LimitByDrugConvictions],
        [DrugConvictionsByID],
        [DrugCountID],
        [DrugConvictionMilesID],
        [DrugYearsID],
        [LimitByFailedTest],
        [FailedByID],
        [FailedCountID],
        [FailedMilesID],
        [FailedYearsID],
        [LimitByDUICommercial],
        [CommDUIByID],
        [CommDUICountID],
        [CommDUIMilesID],
        [CommDUIYearsID],
        [LimitByDUIPersonal],
        [PersonalDUIByID],
        [PersonalDUICountID],
        [PersonalDUIMilesID],
        [PersonalDUIYearsID],
        [PayTypeID],
        [LineHaulPerc],
        [LoadedPerMile],
        [EmptyPerMile],
        [HourlyRate],
        [AvgPayPerWeek],
        [PayGuaranty],
        [FuelReimbursed],
        [AllFuel],
        [FuelGuaranty],
        [PayNotes],
        [OtherRequirements],
        [LinksToOtherPostings],
        [NoAd],
        CAST(BINARY_CHECKSUM([AdID],[CarrierID],[AdTemplate],[AdName],[TruckerTypeID],[ShortDescription],[LongDescription],[RunOn],[ExpireOn],[LimitByAge],[PositionsAvail],[MinAge],[HideAd],[MapThumbnail],[PSPMaximum],[LimitByMajorAccidents],[MajorByID],[MajorCountID],[MajorMilesID],[MajorYearsID],[LimitByMinorAccidents],[MinorByID],[MinorCountID],[MinorMilesID],[MinorYearsID],[LimitByTickets],[TicketsByID],[TicketCountID],[TicketMilesID],[TicketYearsID],[LimitBySeriousTickets],[SeriousByID],[SeriousCountID],[SeriousMilesID],[SeriousYearsID],[LimitByFelonies],[FeloniesByID],[FelonyCountID],[FelonyMilesID],[FelonyYearsID],[LimitByDrugConvictions],[DrugConvictionsByID],[DrugCountID],[DrugConvictionMilesID],[DrugYearsID],[LimitByFailedTest],[FailedByID],[FailedCountID],[FailedMilesID],[FailedYearsID],[LimitByDUICommercial],[CommDUIByID],[CommDUICountID],[CommDUIMilesID],[CommDUIYearsID],[LimitByDUIPersonal],[PersonalDUIByID],[PersonalDUICountID],[PersonalDUIMilesID],[PersonalDUIYearsID],[PayTypeID],[LineHaulPerc],[LoadedPerMile],[EmptyPerMile],[HourlyRate],[AvgPayPerWeek],[PayGuaranty],[FuelReimbursed],[AllFuel],[FuelGuaranty],[PayNotes],[OtherRequirements],[LinksToOtherPostings],[NoAd]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CarrierAd]
    WHERE [AdID] =@pk_AdID
    SET NOCOUNT OFF
END

