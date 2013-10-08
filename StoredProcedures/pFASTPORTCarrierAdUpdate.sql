if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CarrierAd] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCarrierAdUpdate
    @pk_AdID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CarrierAd] WHERE [AdID] = @pk_AdID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CarrierAd]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CarrierAd]
            SET 
            [CarrierID] = @p_CarrierID,
            [AdTemplate] = @p_AdTemplate,
            [AdName] = @p_AdName,
            [TruckerTypeID] = @p_TruckerTypeID,
            [ShortDescription] = @p_ShortDescription,
            [LongDescription] = @p_LongDescription,
            [RunOn] = @p_RunOn,
            [ExpireOn] = @p_ExpireOn,
            [LimitByAge] = @p_LimitByAge,
            [PositionsAvail] = @p_PositionsAvail,
            [MinAge] = @p_MinAge,
            [HideAd] = @p_HideAd,
            [MapThumbnail] = @p_MapThumbnail,
            [PSPMaximum] = @p_PSPMaximum,
            [LimitByMajorAccidents] = @p_LimitByMajorAccidents,
            [MajorByID] = @p_MajorByID,
            [MajorCountID] = @p_MajorCountID,
            [MajorMilesID] = @p_MajorMilesID,
            [MajorYearsID] = @p_MajorYearsID,
            [LimitByMinorAccidents] = @p_LimitByMinorAccidents,
            [MinorByID] = @p_MinorByID,
            [MinorCountID] = @p_MinorCountID,
            [MinorMilesID] = @p_MinorMilesID,
            [MinorYearsID] = @p_MinorYearsID,
            [LimitByTickets] = @p_LimitByTickets,
            [TicketsByID] = @p_TicketsByID,
            [TicketCountID] = @p_TicketCountID,
            [TicketMilesID] = @p_TicketMilesID,
            [TicketYearsID] = @p_TicketYearsID,
            [LimitBySeriousTickets] = @p_LimitBySeriousTickets,
            [SeriousByID] = @p_SeriousByID,
            [SeriousCountID] = @p_SeriousCountID,
            [SeriousMilesID] = @p_SeriousMilesID,
            [SeriousYearsID] = @p_SeriousYearsID,
            [LimitByFelonies] = @p_LimitByFelonies,
            [FeloniesByID] = @p_FeloniesByID,
            [FelonyCountID] = @p_FelonyCountID,
            [FelonyMilesID] = @p_FelonyMilesID,
            [FelonyYearsID] = @p_FelonyYearsID,
            [LimitByDrugConvictions] = @p_LimitByDrugConvictions,
            [DrugConvictionsByID] = @p_DrugConvictionsByID,
            [DrugCountID] = @p_DrugCountID,
            [DrugConvictionMilesID] = @p_DrugConvictionMilesID,
            [DrugYearsID] = @p_DrugYearsID,
            [LimitByFailedTest] = @p_LimitByFailedTest,
            [FailedByID] = @p_FailedByID,
            [FailedCountID] = @p_FailedCountID,
            [FailedMilesID] = @p_FailedMilesID,
            [FailedYearsID] = @p_FailedYearsID,
            [LimitByDUICommercial] = @p_LimitByDUICommercial,
            [CommDUIByID] = @p_CommDUIByID,
            [CommDUICountID] = @p_CommDUICountID,
            [CommDUIMilesID] = @p_CommDUIMilesID,
            [CommDUIYearsID] = @p_CommDUIYearsID,
            [LimitByDUIPersonal] = @p_LimitByDUIPersonal,
            [PersonalDUIByID] = @p_PersonalDUIByID,
            [PersonalDUICountID] = @p_PersonalDUICountID,
            [PersonalDUIMilesID] = @p_PersonalDUIMilesID,
            [PersonalDUIYearsID] = @p_PersonalDUIYearsID,
            [PayTypeID] = @p_PayTypeID,
            [LineHaulPerc] = @p_LineHaulPerc,
            [LoadedPerMile] = @p_LoadedPerMile,
            [EmptyPerMile] = @p_EmptyPerMile,
            [HourlyRate] = @p_HourlyRate,
            [AvgPayPerWeek] = @p_AvgPayPerWeek,
            [PayGuaranty] = @p_PayGuaranty,
            [FuelReimbursed] = @p_FuelReimbursed,
            [AllFuel] = @p_AllFuel,
            [FuelGuaranty] = @p_FuelGuaranty,
            [PayNotes] = @p_PayNotes,
            [OtherRequirements] = @p_OtherRequirements,
            [LinksToOtherPostings] = @p_LinksToOtherPostings,
            [NoAd] = @p_NoAd
            WHERE [AdID] = @pk_AdID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AdID],[CarrierID],[AdTemplate],[AdName],[TruckerTypeID],[ShortDescription],[LongDescription],[RunOn],[ExpireOn],[LimitByAge],[PositionsAvail],[MinAge],[HideAd],[MapThumbnail],[PSPMaximum],[LimitByMajorAccidents],[MajorByID],[MajorCountID],[MajorMilesID],[MajorYearsID],[LimitByMinorAccidents],[MinorByID],[MinorCountID],[MinorMilesID],[MinorYearsID],[LimitByTickets],[TicketsByID],[TicketCountID],[TicketMilesID],[TicketYearsID],[LimitBySeriousTickets],[SeriousByID],[SeriousCountID],[SeriousMilesID],[SeriousYearsID],[LimitByFelonies],[FeloniesByID],[FelonyCountID],[FelonyMilesID],[FelonyYearsID],[LimitByDrugConvictions],[DrugConvictionsByID],[DrugCountID],[DrugConvictionMilesID],[DrugYearsID],[LimitByFailedTest],[FailedByID],[FailedCountID],[FailedMilesID],[FailedYearsID],[LimitByDUICommercial],[CommDUIByID],[CommDUICountID],[CommDUIMilesID],[CommDUIYearsID],[LimitByDUIPersonal],[PersonalDUIByID],[PersonalDUICountID],[PersonalDUIMilesID],[PersonalDUIYearsID],[PayTypeID],[LineHaulPerc],[LoadedPerMile],[EmptyPerMile],[HourlyRate],[AvgPayPerWeek],[PayGuaranty],[FuelReimbursed],[AllFuel],[FuelGuaranty],[PayNotes],[OtherRequirements],[LinksToOtherPostings],[NoAd]) AS nvarchar(4000)) 
            FROM [dbo].[CarrierAd] with (rowlock, holdlock)
            WHERE [AdID] = @pk_AdID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CarrierAd]
                    SET 
                    [CarrierID] = @p_CarrierID,
                    [AdTemplate] = @p_AdTemplate,
                    [AdName] = @p_AdName,
                    [TruckerTypeID] = @p_TruckerTypeID,
                    [ShortDescription] = @p_ShortDescription,
                    [LongDescription] = @p_LongDescription,
                    [RunOn] = @p_RunOn,
                    [ExpireOn] = @p_ExpireOn,
                    [LimitByAge] = @p_LimitByAge,
                    [PositionsAvail] = @p_PositionsAvail,
                    [MinAge] = @p_MinAge,
                    [HideAd] = @p_HideAd,
                    [MapThumbnail] = @p_MapThumbnail,
                    [PSPMaximum] = @p_PSPMaximum,
                    [LimitByMajorAccidents] = @p_LimitByMajorAccidents,
                    [MajorByID] = @p_MajorByID,
                    [MajorCountID] = @p_MajorCountID,
                    [MajorMilesID] = @p_MajorMilesID,
                    [MajorYearsID] = @p_MajorYearsID,
                    [LimitByMinorAccidents] = @p_LimitByMinorAccidents,
                    [MinorByID] = @p_MinorByID,
                    [MinorCountID] = @p_MinorCountID,
                    [MinorMilesID] = @p_MinorMilesID,
                    [MinorYearsID] = @p_MinorYearsID,
                    [LimitByTickets] = @p_LimitByTickets,
                    [TicketsByID] = @p_TicketsByID,
                    [TicketCountID] = @p_TicketCountID,
                    [TicketMilesID] = @p_TicketMilesID,
                    [TicketYearsID] = @p_TicketYearsID,
                    [LimitBySeriousTickets] = @p_LimitBySeriousTickets,
                    [SeriousByID] = @p_SeriousByID,
                    [SeriousCountID] = @p_SeriousCountID,
                    [SeriousMilesID] = @p_SeriousMilesID,
                    [SeriousYearsID] = @p_SeriousYearsID,
                    [LimitByFelonies] = @p_LimitByFelonies,
                    [FeloniesByID] = @p_FeloniesByID,
                    [FelonyCountID] = @p_FelonyCountID,
                    [FelonyMilesID] = @p_FelonyMilesID,
                    [FelonyYearsID] = @p_FelonyYearsID,
                    [LimitByDrugConvictions] = @p_LimitByDrugConvictions,
                    [DrugConvictionsByID] = @p_DrugConvictionsByID,
                    [DrugCountID] = @p_DrugCountID,
                    [DrugConvictionMilesID] = @p_DrugConvictionMilesID,
                    [DrugYearsID] = @p_DrugYearsID,
                    [LimitByFailedTest] = @p_LimitByFailedTest,
                    [FailedByID] = @p_FailedByID,
                    [FailedCountID] = @p_FailedCountID,
                    [FailedMilesID] = @p_FailedMilesID,
                    [FailedYearsID] = @p_FailedYearsID,
                    [LimitByDUICommercial] = @p_LimitByDUICommercial,
                    [CommDUIByID] = @p_CommDUIByID,
                    [CommDUICountID] = @p_CommDUICountID,
                    [CommDUIMilesID] = @p_CommDUIMilesID,
                    [CommDUIYearsID] = @p_CommDUIYearsID,
                    [LimitByDUIPersonal] = @p_LimitByDUIPersonal,
                    [PersonalDUIByID] = @p_PersonalDUIByID,
                    [PersonalDUICountID] = @p_PersonalDUICountID,
                    [PersonalDUIMilesID] = @p_PersonalDUIMilesID,
                    [PersonalDUIYearsID] = @p_PersonalDUIYearsID,
                    [PayTypeID] = @p_PayTypeID,
                    [LineHaulPerc] = @p_LineHaulPerc,
                    [LoadedPerMile] = @p_LoadedPerMile,
                    [EmptyPerMile] = @p_EmptyPerMile,
                    [HourlyRate] = @p_HourlyRate,
                    [AvgPayPerWeek] = @p_AvgPayPerWeek,
                    [PayGuaranty] = @p_PayGuaranty,
                    [FuelReimbursed] = @p_FuelReimbursed,
                    [AllFuel] = @p_AllFuel,
                    [FuelGuaranty] = @p_FuelGuaranty,
                    [PayNotes] = @p_PayNotes,
                    [OtherRequirements] = @p_OtherRequirements,
                    [LinksToOtherPostings] = @p_LinksToOtherPostings,
                    [NoAd] = @p_NoAd
                    WHERE [AdID] = @pk_AdID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CarrierAd]', 16, 1)

        END
END

