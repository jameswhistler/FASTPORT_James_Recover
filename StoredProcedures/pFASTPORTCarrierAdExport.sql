if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdExport') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTCarrierAdExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(4000),
        @p_select_str nvarchar(4000),
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str1 nvarchar(4000),
        @l_title_str2 nvarchar(4000),
        @l_select_str1 nvarchar(4000),
        @l_select_str2 nvarchar(4000),
        @l_select_str3 nvarchar(4000),
        @l_select_str4 nvarchar(4000),
        @l_from_str nvarchar(4000),
        @l_join_str nvarchar(4000),
        @l_where_str nvarchar(4000),
        @l_query_select nvarchar(4000),
        @l_query_union nvarchar(4000),
        @l_query_from nvarchar(4000)
    BEGIN
        -- Set up the title string from the column names.  Excel 
        -- will complain if the first column value is ID. So wrap
        -- the value with "".
        SET @l_title_str1 = @p_title_str + char(13)
        SET @l_title_str2 = ''
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str1 = 
                N'"AdID"' + @p_separator_str +
                N'"CarrierID"' + @p_separator_str +
                N'"""CarrierID"" DOTNumber"' + @p_separator_str +
                N'"AdTemplate"' + @p_separator_str +
                N'"AdName"' + @p_separator_str +
                N'"TruckerTypeID"' + @p_separator_str +
                N'"""TruckerTypeID"" ItemName"' + @p_separator_str +
                N'"ShortDescription"' + @p_separator_str +
                N'"LongDescription"' + @p_separator_str +
                N'"RunOn"' + @p_separator_str +
                N'"ExpireOn"' + @p_separator_str +
                N'"LimitByAge"' + @p_separator_str +
                N'"PositionsAvail"' + @p_separator_str +
                N'"MinAge"' + @p_separator_str +
                N'"HideAd"' + @p_separator_str +
                N'"PSPMaximum"' + @p_separator_str +
                N'"LimitByMajorAccidents"' + @p_separator_str +
                N'"MajorByID"' + @p_separator_str +
                N'"""MajorByID"" ListName"' + @p_separator_str +
                N'"MajorCountID"' + @p_separator_str +
                N'"""MajorCountID"" ListName"' + @p_separator_str +
                N'"MajorMilesID"' + @p_separator_str +
                N'"""MajorMilesID"" ListName"' + @p_separator_str +
                N'"MajorYearsID"' + @p_separator_str +
                N'"""MajorYearsID"" ListName"' + @p_separator_str +
                N'"LimitByMinorAccidents"' + @p_separator_str +
                N'"MinorByID"' + @p_separator_str +
                N'"""MinorByID"" ListName"' + @p_separator_str +
                N'"MinorCountID"' + @p_separator_str +
                N'"""MinorCountID"" ListName"' + @p_separator_str +
                N'"MinorMilesID"' + @p_separator_str +
                N'"""MinorMilesID"" ListName"' + @p_separator_str +
                N'"MinorYearsID"' + @p_separator_str +
                N'"""MinorYearsID"" ListName"' + @p_separator_str +
                N'"LimitByTickets"' + @p_separator_str +
                N'"TicketsByID"' + @p_separator_str +
                N'"""TicketsByID"" ListName"' + @p_separator_str +
                N'"TicketCountID"' + @p_separator_str +
                N'"""TicketCountID"" ListName"' + @p_separator_str +
                N'"TicketMilesID"' + @p_separator_str +
                N'"""TicketMilesID"" ListName"' + @p_separator_str +
                N'"TicketYearsID"' + @p_separator_str +
                N'"""TicketYearsID"" ListName"' + @p_separator_str +
                N'"LimitBySeriousTickets"' + @p_separator_str +
                N'"SeriousByID"' + @p_separator_str +
                N'"""SeriousByID"" ListName"' + @p_separator_str +
                N'"SeriousCountID"' + @p_separator_str +
                N'"""SeriousCountID"" ListName"' + @p_separator_str +
                N'"SeriousMilesID"' + @p_separator_str +
                N'"""SeriousMilesID"" ListName"' + @p_separator_str +
                N'"SeriousYearsID"' + @p_separator_str +
                N'"""SeriousYearsID"" ListName"' + @p_separator_str +
                N'"LimitByFelonies"' + @p_separator_str +
                N'"FeloniesByID"' + @p_separator_str +
                N'"""FeloniesByID"" ListName"' + @p_separator_str +
                N'"FelonyCountID"' + @p_separator_str +
                N'"""FelonyCountID"" ListName"' + @p_separator_str +
                N'"FelonyMilesID"' + @p_separator_str +
                N'"""FelonyMilesID"" ListName"' + @p_separator_str +
                N'"FelonyYearsID"' + @p_separator_str +
                N'"""FelonyYearsID"" ListName"' + @p_separator_str +
                N'"LimitByDrugConvictions"' + @p_separator_str +
                N'"DrugConvictionsByID"' + @p_separator_str +
                N'"""DrugConvictionsByID"" ListName"' + @p_separator_str +
                N'"DrugCountID"' + @p_separator_str 
            SET @l_title_str2 = 
                N'"""DrugCountID"" ListName"' + @p_separator_str +
                N'"DrugConvictionMilesID"' + @p_separator_str +
                N'"""DrugConvictionMilesID"" ListName"' + @p_separator_str +
                N'"DrugYearsID"' + @p_separator_str +
                N'"""DrugYearsID"" ListName"' + @p_separator_str +
                N'"LimitByFailedTest"' + @p_separator_str +
                N'"FailedByID"' + @p_separator_str +
                N'"""FailedByID"" ListName"' + @p_separator_str +
                N'"FailedCountID"' + @p_separator_str +
                N'"""FailedCountID"" ListName"' + @p_separator_str +
                N'"FailedMilesID"' + @p_separator_str +
                N'"""FailedMilesID"" ListName"' + @p_separator_str +
                N'"FailedYearsID"' + @p_separator_str +
                N'"""FailedYearsID"" ListName"' + @p_separator_str +
                N'"LimitByDUICommercial"' + @p_separator_str +
                N'"CommDUIByID"' + @p_separator_str +
                N'"""CommDUIByID"" ListName"' + @p_separator_str +
                N'"CommDUICountID"' + @p_separator_str +
                N'"""CommDUICountID"" ListName"' + @p_separator_str +
                N'"CommDUIMilesID"' + @p_separator_str +
                N'"""CommDUIMilesID"" ListName"' + @p_separator_str +
                N'"CommDUIYearsID"' + @p_separator_str +
                N'"""CommDUIYearsID"" ListName"' + @p_separator_str +
                N'"LimitByDUIPersonal"' + @p_separator_str +
                N'"PersonalDUIByID"' + @p_separator_str +
                N'"""PersonalDUIByID"" ListName"' + @p_separator_str +
                N'"PersonalDUICountID"' + @p_separator_str +
                N'"""PersonalDUICountID"" ListName"' + @p_separator_str +
                N'"PersonalDUIMilesID"' + @p_separator_str +
                N'"""PersonalDUIMilesID"" ListName"' + @p_separator_str +
                N'"PersonalDUIYearsID"' + @p_separator_str +
                N'"""PersonalDUIYearsID"" ListName"' + @p_separator_str +
                N'"PayTypeID"' + @p_separator_str +
                N'"""PayTypeID"" ItemName"' + @p_separator_str +
                N'"LineHaulPerc"' + @p_separator_str +
                N'"LoadedPerMile"' + @p_separator_str +
                N'"EmptyPerMile"' + @p_separator_str +
                N'"HourlyRate"' + @p_separator_str +
                N'"AvgPayPerWeek"' + @p_separator_str +
                N'"PayGuaranty"' + @p_separator_str +
                N'"FuelReimbursed"' + @p_separator_str +
                N'"AllFuel"' + @p_separator_str +
                N'"FuelGuaranty"' + @p_separator_str +
                N'"PayNotes"' + @p_separator_str +
                N'"OtherRequirements"' + @p_separator_str +
                N'"LinksToOtherPostings"' + @p_separator_str +
                N'"NoAd"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str1, 1, 2) = 'ID'
            SET @l_title_str1 = 
                '"' + 
                SUBSTRING(@l_title_str1, 1, PATINDEX('%,%', @l_title_str1)-1) + 
                '"' + 
                SUBSTRING(@l_title_str1, PATINDEX('%,%', @l_title_str1), LEN(@l_title_str1)); 

        -- Set up the select string
        SET @l_select_str1 = @p_select_str
        SET @l_select_str2 = @p_select_str
        SET @l_select_str3 = @p_select_str
        SET @l_select_str4 = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, CarrierAd_.[AdID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[CarrierID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[DOTNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[AdTemplate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[AdName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[TruckerTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[ShortDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[LongDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[RunOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[ExpireOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByAge]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PositionsAvail]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MinAge]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[HideAd]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PSPMaximum]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByMajorAccidents]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MajorByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MajorCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MajorMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MajorYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByMinorAccidents]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MinorByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t6.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MinorCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t7.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MinorMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t8.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, CarrierAd_.[MinorYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t9.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByTickets]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[TicketsByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t10.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[TicketCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t11.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[TicketMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t12.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[TicketYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t13.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitBySeriousTickets]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[SeriousByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t14.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[SeriousCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t15.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[SeriousMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t16.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[SeriousYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t17.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByFelonies]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FeloniesByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t18.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FelonyCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t19.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FelonyMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t20.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FelonyYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t21.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByDrugConvictions]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[DrugConvictionsByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t22.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str3 = 
                N'IsNULL(Convert(nvarchar, CarrierAd_.[DrugCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t23.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[DrugConvictionMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t24.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[DrugYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t25.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByFailedTest]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FailedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t26.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FailedCountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t27.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FailedMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t28.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[FailedYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t29.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByDUICommercial]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[CommDUIByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t30.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[CommDUICountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t31.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[CommDUIMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t32.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[CommDUIYearsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t33.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[LimitByDUIPersonal]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PersonalDUIByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t34.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PersonalDUICountID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t35.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PersonalDUIMilesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t36.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PersonalDUIYearsID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str4 = 
                N'N''"'' + REPLACE(IsNULL( t37.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[PayTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t38.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[LineHaulPerc]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[LoadedPerMile]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[EmptyPerMile]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[HourlyRate]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAd_.[AvgPayPerWeek]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[PayGuaranty]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[FuelReimbursed]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[AllFuel]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[FuelGuaranty]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[PayNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[OtherRequirements], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CarrierAd_.[LinksToOtherPostings], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAd_.[NoAd]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[CarrierAd] CarrierAd_ LEFT OUTER JOIN [dbo].[PartyCarrier] t0 ON (CarrierAd_.[CarrierID] =  t0.[CarrierID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (CarrierAd_.[TruckerTypeID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[List] t2 ON (CarrierAd_.[MajorByID] =  t2.[ListID]) LEFT OUTER JOIN [dbo].[List] t3 ON (CarrierAd_.[MajorCountID] =  t3.[ListID]) LEFT OUTER JOIN [dbo].[List] t4 ON (CarrierAd_.[MajorMilesID] =  t4.[ListID]) LEFT OUTER JOIN [dbo].[List] t5 ON (CarrierAd_.[MajorYearsID] =  t5.[ListID]) LEFT OUTER JOIN [dbo].[List] t6 ON (CarrierAd_.[MinorByID] =  t6.[ListID]) LEFT OUTER JOIN [dbo].[List] t7 ON (CarrierAd_.[MinorCountID] =  t7.[ListID]) LEFT OUTER JOIN [dbo].[List] t8 ON (CarrierAd_.[MinorMilesID] =  t8.[ListID]) LEFT OUTER JOIN [dbo].[List] t9 ON (CarrierAd_.[MinorYearsID] =  t9.[ListID]) LEFT OUTER JOIN [dbo].[List] t10 ON (CarrierAd_.[TicketsByID] =  t10.[ListID]) LEFT OUTER JOIN [dbo].[List] t11 ON (CarrierAd_.[TicketCountID] =  t11.[ListID]) LEFT OUTER JOIN [dbo].[List] t12 ON (CarrierAd_.[TicketMilesID] =  t12.[ListID]) LEFT OUTER JOIN [dbo].[List] t13 ON (CarrierAd_.[TicketYearsID] =  t13.[ListID]) LEFT OUTER JOIN [dbo].[List] t14 ON (CarrierAd_.[SeriousByID] =  t14.[ListID]) LEFT OUTER JOIN [dbo].[List] t15 ON (CarrierAd_.[SeriousCountID] =  t15.[ListID]) LEFT OUTER JOIN [dbo].[List] t16 ON (CarrierAd_.[SeriousMilesID] =  t16.[ListID]) LEFT OUTER JOIN [dbo].[List] t17 ON (CarrierAd_.[SeriousYearsID] =  t17.[ListID]) LEFT OUTER JOIN [dbo].[List] t18 ON (CarrierAd_.[FeloniesByID] =  t18.[ListID]) LEFT OUTER JOIN [dbo].[List] t19 ON (CarrierAd_.[FelonyCountID] =  t19.[ListID]) LEFT OUTER JOIN [dbo].[List] t20 ON (CarrierAd_.[FelonyMilesID] =  t20.[ListID]) LEFT OUTER JOIN [dbo].[List] t21 ON (CarrierAd_.[FelonyYearsID] =  t21.[ListID]) LEFT OUTER JOIN [dbo].[List] t22 ON (CarrierAd_.[DrugConvictionsByID] =  t22.[ListID]) LEFT OUTER JOIN [dbo].[List] t23 ON (CarrierAd_.[DrugCountID] =  t23.[ListID]) LEFT OUTER JOIN [dbo].[List] t24 ON (CarrierAd_.[DrugConvictionMilesID] =  t24.[ListID]) LEFT OUTER JOIN [dbo].[List] t25 ON (CarrierAd_.[DrugYearsID] =  t25.[ListID]) LEFT OUTER JOIN [dbo].[List] t26 ON (CarrierAd_.[FailedByID] =  t26.[ListID]) LEFT OUTER JOIN [dbo].[List] t27 ON (CarrierAd_.[FailedCountID] =  t27.[ListID]) LEFT OUTER JOIN [dbo].[List] t28 ON (CarrierAd_.[FailedMilesID] =  t28.[ListID]) LEFT OUTER JOIN [dbo].[List] t29 ON (CarrierAd_.[FailedYearsID] =  t29.[ListID]) LEFT OUTER JOIN [dbo].[List] t30 ON (CarrierAd_.[CommDUIByID] =  t30.[ListID]) LEFT OUTER JOIN [dbo].[List] t31 ON (CarrierAd_.[CommDUICountID] =  t31.[ListID]) LEFT OUTER JOIN [dbo].[List] t32 ON (CarrierAd_.[CommDUIMilesID] =  t32.[ListID]) LEFT OUTER JOIN [dbo].[List] t33 ON (CarrierAd_.[CommDUIYearsID] =  t33.[ListID]) LEFT OUTER JOIN [dbo].[List] t34 ON (CarrierAd_.[PersonalDUIByID] =  t34.[ListID]) LEFT OUTER JOIN [dbo].[List] t35 ON (CarrierAd_.[PersonalDUICountID] =  t35.[ListID]) LEFT OUTER JOIN [dbo].[List] t36 ON (CarrierAd_.[PersonalDUIMilesID] =  t36.[ListID]) LEFT OUTER JOIN [dbo].[List] t37 ON (CarrierAd_.[PersonalDUIYearsID] =  t37.[ListID]) LEFT OUTER JOIN [dbo].[Tree] t38 ON (CarrierAd_.[PayTypeID] =  t38.[TreeID])';

        SET @l_join_str = @p_join_str
        if @p_join_str is null
            SET @l_join_str = ' ';

        -- Set up the where string
        SET @l_where_str = ' ';
        IF @p_where_str IS NOT NULL
            SET @l_where_str = @l_where_str + 'WHERE ' + @p_where_str;

        -- Construct the query string.  Append the result set with the title.
        SET @l_query_select = 
                'SELECT '''
        SET @l_query_union = 
                ''' UNION ALL ' +
                'SELECT '
        SET @l_query_from = 
                ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' +
                @l_where_str;

        -- Run the query
        EXECUTE (@l_query_select + @l_title_str1 + @l_title_str2 + @l_query_union + @l_select_str1 + @l_select_str2 + @l_select_str3 + @l_select_str4+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

