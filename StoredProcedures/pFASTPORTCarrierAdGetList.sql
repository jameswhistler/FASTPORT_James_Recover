if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[CarrierAd]
-- given the search criteria and sorting condition.
-- It will return a subset of the data based
-- on the current page number and batch size.  Table joins can
-- be performed if the join clause is specified.
-- 
-- If the resultset is not empty, it will return:
--    1) The total number of rows which match the condition;
--    2) The resultset in the current page
-- If nothing matches the search condition, it will return:
--    1) count is 0 ;
--    2) empty resultset.
CREATE PROCEDURE pFASTPORTCarrierAdGetList
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_sort_str nvarchar(4000),
        @p_page_number int,
        @p_batch_size int
AS
DECLARE
    @l_temp_table nvarchar(4000),
    @l_temp_insert nvarchar(4000),
    @l_temp_select nvarchar(4000),
    @l_temp_from nvarchar(4000),
    @l_final_sort nvarchar(4000),
    @l_temp_cols nvarchar(4000),
    @l_temp_colsWithAlias nvarchar(4000),
    @l_query_select nvarchar(4000),
    @l_query_select2 nvarchar(4000),
    @l_query_rownum nvarchar(4000),
    @l_query_from nvarchar(4000),
    @l_query_where nvarchar(4000),
    @l_query_cols1 nvarchar(4000),
    @l_query_cols2 nvarchar(4000),
    @l_from_str nvarchar(4000),
    @l_join_str nvarchar(4000),
    @l_sort_str nvarchar(4000),
    @l_where_str nvarchar(4000),
    @l_count_query nvarchar(4000),
    @l_end_gen_row_num integer,
    @l_start_gen_row_num integer
BEGIN
    SET NOCOUNT ON

    -- Set up the from string as the base table
    SET @l_from_str = '[dbo].[CarrierAd] CarrierAd_'

    -- Set up the join string
    SET @l_join_str = @p_join_str
    IF @p_join_str is null
        SET @l_join_str = ' '

    -- Set up the where string
    SET @l_where_str = ' '
        IF @p_where_str is not null
        SET @l_where_str = 'WHERE ' + @p_where_str

    -- Get the total count of rows the query will return
    IF @p_page_number > 0 and @p_batch_size >= 0
    BEGIN
        SET @l_count_query = 
            'SELECT count(*) ' +
            'FROM ' + @l_from_str + ' ' + @l_join_str + ' ' +
            @l_where_str + ' '

        -- Run the count query
        EXECUTE (@l_count_query)
    END

    -- Get the list
    IF @p_page_number > 0 AND @p_batch_size > 0
    BEGIN
        -- If the caller did not pass a sort string, use a default value
        IF @p_sort_str IS NOT NULL
            SET @l_sort_str = 'ORDER BY ' + @p_sort_str
        ELSE
            SET @l_sort_str = N'ORDER BY CarrierAd_.[AdID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Construct the main query
        SET @l_query_select = 'WITH CarrierAd_ AS ( SELECT  '
        SET @l_query_rownum = 'ROW_NUMBER() OVER(' + @l_sort_str + ') AS IS_ROWNUM_COL,'
        SET @l_query_cols1 = 
            N'CarrierAd_.[AdID],
            CarrierAd_.[CarrierID],
            CarrierAd_.[AdTemplate],
            CarrierAd_.[AdName],
            CarrierAd_.[TruckerTypeID],
            CarrierAd_.[ShortDescription],
            CarrierAd_.[LongDescription],
            CarrierAd_.[RunOn],
            CarrierAd_.[ExpireOn],
            CarrierAd_.[LimitByAge],
            CarrierAd_.[PositionsAvail],
            CarrierAd_.[MinAge],
            CarrierAd_.[HideAd],
            CarrierAd_.[MapThumbnail],
            CarrierAd_.[PSPMaximum],
            CarrierAd_.[LimitByMajorAccidents],
            CarrierAd_.[MajorByID],
            CarrierAd_.[MajorCountID],
            CarrierAd_.[MajorMilesID],
            CarrierAd_.[MajorYearsID],
            CarrierAd_.[LimitByMinorAccidents],
            CarrierAd_.[MinorByID],
            CarrierAd_.[MinorCountID],
            CarrierAd_.[MinorMilesID],
            CarrierAd_.[MinorYearsID],
            CarrierAd_.[LimitByTickets],
            CarrierAd_.[TicketsByID],
            CarrierAd_.[TicketCountID],
            CarrierAd_.[TicketMilesID],
            CarrierAd_.[TicketYearsID],
            CarrierAd_.[LimitBySeriousTickets],
            CarrierAd_.[SeriousByID],
            CarrierAd_.[SeriousCountID],
            CarrierAd_.[SeriousMilesID],
            CarrierAd_.[SeriousYearsID],
            CarrierAd_.[LimitByFelonies],
            CarrierAd_.[FeloniesByID],
            CarrierAd_.[FelonyCountID],
            CarrierAd_.[FelonyMilesID],
            CarrierAd_.[FelonyYearsID],
            CarrierAd_.[LimitByDrugConvictions],
            CarrierAd_.[DrugConvictionsByID],
            CarrierAd_.[DrugCountID],
            CarrierAd_.[DrugConvictionMilesID],
            CarrierAd_.[DrugYearsID],
            CarrierAd_.[LimitByFailedTest],
            CarrierAd_.[FailedByID],
            CarrierAd_.[FailedCountID],
            CarrierAd_.[FailedMilesID],
            CarrierAd_.[FailedYearsID],
            CarrierAd_.[LimitByDUICommercial],
            CarrierAd_.[CommDUIByID],
            CarrierAd_.[CommDUICountID],
            CarrierAd_.[CommDUIMilesID],
            CarrierAd_.[CommDUIYearsID],
            CarrierAd_.[LimitByDUIPersonal],
            CarrierAd_.[PersonalDUIByID],
            CarrierAd_.[PersonalDUICountID],
            CarrierAd_.[PersonalDUIMilesID],
            CarrierAd_.[PersonalDUIYearsID],
            CarrierAd_.[PayTypeID],
            CarrierAd_.[LineHaulPerc],
            CarrierAd_.[LoadedPerMile],
            CarrierAd_.[EmptyPerMile],
            CarrierAd_.[HourlyRate],
            CarrierAd_.[AvgPayPerWeek],
            CarrierAd_.[PayGuaranty],
            CarrierAd_.[FuelReimbursed],
            CarrierAd_.[AllFuel],
            CarrierAd_.[FuelGuaranty],
            CarrierAd_.[PayNotes],
            CarrierAd_.[OtherRequirements],
            CarrierAd_.[LinksToOtherPostings],
            CarrierAd_.[NoAd], '
        SET @l_query_cols2 = 
            N'            CAST(BINARY_CHECKSUM(CarrierAd_.[AdID],CarrierAd_.[CarrierID],CarrierAd_.[AdTemplate],CarrierAd_.[AdName],CarrierAd_.[TruckerTypeID],CarrierAd_.[ShortDescription],CarrierAd_.[LongDescription],CarrierAd_.[RunOn],CarrierAd_.[ExpireOn],CarrierAd_.[LimitByAge],CarrierAd_.[PositionsAvail],CarrierAd_.[MinAge],CarrierAd_.[HideAd],CarrierAd_.[MapThumbnail],CarrierAd_.[PSPMaximum],CarrierAd_.[LimitByMajorAccidents],CarrierAd_.[MajorByID],CarrierAd_.[MajorCountID],CarrierAd_.[MajorMilesID],CarrierAd_.[MajorYearsID],CarrierAd_.[LimitByMinorAccidents],CarrierAd_.[MinorByID],CarrierAd_.[MinorCountID],CarrierAd_.[MinorMilesID],CarrierAd_.[MinorYearsID],CarrierAd_.[LimitByTickets],CarrierAd_.[TicketsByID],CarrierAd_.[TicketCountID],CarrierAd_.[TicketMilesID],CarrierAd_.[TicketYearsID],CarrierAd_.[LimitBySeriousTickets],CarrierAd_.[SeriousByID],CarrierAd_.[SeriousCountID],CarrierAd_.[SeriousMilesID],CarrierAd_.[SeriousYearsID],CarrierAd_.[LimitByFelonies],CarrierAd_.[FeloniesByID],CarrierAd_.[FelonyCountID],CarrierAd_.[FelonyMilesID],CarrierAd_.[FelonyYearsID],CarrierAd_.[LimitByDrugConvictions],CarrierAd_.[DrugConvictionsByID],CarrierAd_.[DrugCountID],CarrierAd_.[DrugConvictionMilesID],CarrierAd_.[DrugYearsID],CarrierAd_.[LimitByFailedTest],CarrierAd_.[FailedByID],CarrierAd_.[FailedCountID],CarrierAd_.[FailedMilesID],CarrierAd_.[FailedYearsID],CarrierAd_.[LimitByDUICommercial],CarrierAd_.[CommDUIByID],CarrierAd_.[CommDUICountID],CarrierAd_.[CommDUIMilesID],CarrierAd_.[CommDUIYearsID],CarrierAd_.[LimitByDUIPersonal],CarrierAd_.[PersonalDUIByID],CarrierAd_.[PersonalDUICountID],CarrierAd_.[PersonalDUIMilesID],CarrierAd_.[PersonalDUIYearsID],CarrierAd_.[PayTypeID],CarrierAd_.[LineHaulPerc],CarrierAd_.[LoadedPerMile],CarrierAd_.[EmptyPerMile],CarrierAd_.[HourlyRate],CarrierAd_.[AvgPayPerWeek],CarrierAd_.[PayGuaranty],CarrierAd_.[FuelReimbursed],CarrierAd_.[AllFuel],CarrierAd_.[FuelGuaranty],CarrierAd_.[PayNotes],CarrierAd_.[OtherRequirements],CarrierAd_.[LinksToOtherPostings],CarrierAd_.[NoAd]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345 '
        SET @l_query_from = 'FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + @l_where_str + ') '
        SET @l_query_select2 = 'SELECT * FROM CarrierAd_ '
        SET @l_query_where = 'WHERE IS_ROWNUM_COL BETWEEN ' + convert(varchar, @l_start_gen_row_num) + ' AND ' + convert(varchar, @l_end_gen_row_num) +  ';'

        -- Run the query
        EXECUTE (@l_query_select + @l_query_rownum + @l_query_cols1 + @l_query_cols2 + @l_query_from + @l_query_select2 + @l_query_where)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'CarrierAd_.[AdID],
            CarrierAd_.[CarrierID],
            CarrierAd_.[AdTemplate],
            CarrierAd_.[AdName],
            CarrierAd_.[TruckerTypeID],
            CarrierAd_.[ShortDescription],
            CarrierAd_.[LongDescription],
            CarrierAd_.[RunOn],
            CarrierAd_.[ExpireOn],
            CarrierAd_.[LimitByAge],
            CarrierAd_.[PositionsAvail],
            CarrierAd_.[MinAge],
            CarrierAd_.[HideAd],
            CarrierAd_.[MapThumbnail],
            CarrierAd_.[PSPMaximum],
            CarrierAd_.[LimitByMajorAccidents],
            CarrierAd_.[MajorByID],
            CarrierAd_.[MajorCountID],
            CarrierAd_.[MajorMilesID],
            CarrierAd_.[MajorYearsID],
            CarrierAd_.[LimitByMinorAccidents],
            CarrierAd_.[MinorByID],
            CarrierAd_.[MinorCountID],
            CarrierAd_.[MinorMilesID],
            CarrierAd_.[MinorYearsID],
            CarrierAd_.[LimitByTickets],
            CarrierAd_.[TicketsByID],
            CarrierAd_.[TicketCountID],
            CarrierAd_.[TicketMilesID],
            CarrierAd_.[TicketYearsID],
            CarrierAd_.[LimitBySeriousTickets],
            CarrierAd_.[SeriousByID],
            CarrierAd_.[SeriousCountID],
            CarrierAd_.[SeriousMilesID],
            CarrierAd_.[SeriousYearsID],
            CarrierAd_.[LimitByFelonies],
            CarrierAd_.[FeloniesByID],
            CarrierAd_.[FelonyCountID],
            CarrierAd_.[FelonyMilesID],
            CarrierAd_.[FelonyYearsID],
            CarrierAd_.[LimitByDrugConvictions],
            CarrierAd_.[DrugConvictionsByID],
            CarrierAd_.[DrugCountID],
            CarrierAd_.[DrugConvictionMilesID],
            CarrierAd_.[DrugYearsID],
            CarrierAd_.[LimitByFailedTest],
            CarrierAd_.[FailedByID],
            CarrierAd_.[FailedCountID],
            CarrierAd_.[FailedMilesID],
            CarrierAd_.[FailedYearsID],
            CarrierAd_.[LimitByDUICommercial],
            CarrierAd_.[CommDUIByID],
            CarrierAd_.[CommDUICountID],
            CarrierAd_.[CommDUIMilesID],
            CarrierAd_.[CommDUIYearsID],
            CarrierAd_.[LimitByDUIPersonal],
            CarrierAd_.[PersonalDUIByID],
            CarrierAd_.[PersonalDUICountID],
            CarrierAd_.[PersonalDUIMilesID],
            CarrierAd_.[PersonalDUIYearsID],
            CarrierAd_.[PayTypeID],
            CarrierAd_.[LineHaulPerc],
            CarrierAd_.[LoadedPerMile],
            CarrierAd_.[EmptyPerMile],
            CarrierAd_.[HourlyRate],
            CarrierAd_.[AvgPayPerWeek],
            CarrierAd_.[PayGuaranty],
            CarrierAd_.[FuelReimbursed],
            CarrierAd_.[AllFuel],
            CarrierAd_.[FuelGuaranty],
            CarrierAd_.[PayNotes],
            CarrierAd_.[OtherRequirements],
            CarrierAd_.[LinksToOtherPostings],
            CarrierAd_.[NoAd],'
        SET @l_query_cols2 = 
            N'            CAST(BINARY_CHECKSUM(CarrierAd_.[AdID],CarrierAd_.[CarrierID],CarrierAd_.[AdTemplate],CarrierAd_.[AdName],CarrierAd_.[TruckerTypeID],CarrierAd_.[ShortDescription],CarrierAd_.[LongDescription],CarrierAd_.[RunOn],CarrierAd_.[ExpireOn],CarrierAd_.[LimitByAge],CarrierAd_.[PositionsAvail],CarrierAd_.[MinAge],CarrierAd_.[HideAd],CarrierAd_.[MapThumbnail],CarrierAd_.[PSPMaximum],CarrierAd_.[LimitByMajorAccidents],CarrierAd_.[MajorByID],CarrierAd_.[MajorCountID],CarrierAd_.[MajorMilesID],CarrierAd_.[MajorYearsID],CarrierAd_.[LimitByMinorAccidents],CarrierAd_.[MinorByID],CarrierAd_.[MinorCountID],CarrierAd_.[MinorMilesID],CarrierAd_.[MinorYearsID],CarrierAd_.[LimitByTickets],CarrierAd_.[TicketsByID],CarrierAd_.[TicketCountID],CarrierAd_.[TicketMilesID],CarrierAd_.[TicketYearsID],CarrierAd_.[LimitBySeriousTickets],CarrierAd_.[SeriousByID],CarrierAd_.[SeriousCountID],CarrierAd_.[SeriousMilesID],CarrierAd_.[SeriousYearsID],CarrierAd_.[LimitByFelonies],CarrierAd_.[FeloniesByID],CarrierAd_.[FelonyCountID],CarrierAd_.[FelonyMilesID],CarrierAd_.[FelonyYearsID],CarrierAd_.[LimitByDrugConvictions],CarrierAd_.[DrugConvictionsByID],CarrierAd_.[DrugCountID],CarrierAd_.[DrugConvictionMilesID],CarrierAd_.[DrugYearsID],CarrierAd_.[LimitByFailedTest],CarrierAd_.[FailedByID],CarrierAd_.[FailedCountID],CarrierAd_.[FailedMilesID],CarrierAd_.[FailedYearsID],CarrierAd_.[LimitByDUICommercial],CarrierAd_.[CommDUIByID],CarrierAd_.[CommDUICountID],CarrierAd_.[CommDUIMilesID],CarrierAd_.[CommDUIYearsID],CarrierAd_.[LimitByDUIPersonal],CarrierAd_.[PersonalDUIByID],CarrierAd_.[PersonalDUICountID],CarrierAd_.[PersonalDUIMilesID],CarrierAd_.[PersonalDUIYearsID],CarrierAd_.[PayTypeID],CarrierAd_.[LineHaulPerc],CarrierAd_.[LoadedPerMile],CarrierAd_.[EmptyPerMile],CarrierAd_.[HourlyRate],CarrierAd_.[AvgPayPerWeek],CarrierAd_.[PayGuaranty],CarrierAd_.[FuelReimbursed],CarrierAd_.[AllFuel],CarrierAd_.[FuelGuaranty],CarrierAd_.[PayNotes],CarrierAd_.[OtherRequirements],CarrierAd_.[LinksToOtherPostings],CarrierAd_.[NoAd]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM [dbo].[CarrierAd] CarrierAd_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from);
    END

    SET NOCOUNT OFF

END

