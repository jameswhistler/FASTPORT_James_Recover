if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_HistoryLoadRWExport') and sysstat & 0xf = 4) drop procedure pFASTPORTV_HistoryLoadRWExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTV_HistoryLoadRWExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(4000),
        @p_select_str nvarchar(4000),
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(4000),
        @l_select_str nvarchar(4000),
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
        SET @l_title_str = @p_title_str + char(13)
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str = 
                N'"HistoryID"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"StartMonth"' + @p_separator_str +
                N'"EndMonth"' + @p_separator_str +
                N'"PositionTypeID"' + @p_separator_str +
                N'"CurrentPastID"' + @p_separator_str +
                N'"CarrierID"' + @p_separator_str +
                N'"EmployerCompany"' + @p_separator_str +
                N'"EmployerAddr"' + @p_separator_str +
                N'"EmployerZipID"' + @p_separator_str +
                N'"EmployerCitySTZip"' + @p_separator_str +
                N'"EmployerCountryID"' + @p_separator_str +
                N'"EmployerCountry"' + @p_separator_str +
                N'"EmployerEmail"' + @p_separator_str +
                N'"EmployerPhone"' + @p_separator_str +
                N'"EmployerFax"' + @p_separator_str +
                N'"EmployerContact"' + @p_separator_str +
                N'"MilesPerWeek"' + @p_separator_str +
                N'"ReasonForLeavingID"' + @p_separator_str +
                N'"ReasonForLeaving"' + @p_separator_str +
                N'"ReasonForLeavingNotes"' + @p_separator_str +
                N'"OperatedCommercialMotorVechicle"' + @p_separator_str +
                N'"HadDrugTestingProgram"' + @p_separator_str +
                N'"Notes"' + @p_separator_str +
                N'"MayWeContact"' + @p_separator_str +
                N'"FirstJob"' + @p_separator_str +
                N'"ShowFirstJob"' + @p_separator_str +
                N'"Finished"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str, 1, 2) = 'ID'
            SET @l_title_str = 
                '"' + 
                SUBSTRING(@l_title_str, 1, PATINDEX('%,%', @l_title_str)-1) + 
                '"' + 
                SUBSTRING(@l_title_str, PATINDEX('%,%', @l_title_str), LEN(@l_title_str)); 

        -- Set up the select string
        SET @l_select_str = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str = 
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[HistoryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[StartMonth], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[EndMonth], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[PositionTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[CurrentPastID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[CarrierID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerCompany], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerAddr], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[EmployerZipID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerCitySTZip], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[EmployerCountryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerCountry], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerEmail], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerPhone], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerFax], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[EmployerContact], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[MilesPerWeek]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[ReasonForLeavingID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[ReasonForLeaving], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[ReasonForLeavingNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[OperatedCommercialMotorVechicle]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[HadDrugTestingProgram]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[Notes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[MayWeContact]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[FirstJob]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_HistoryLoadRW_.[ShowFirstJob], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_HistoryLoadRW_.[Finished]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[v_HistoryLoadRW] V_HistoryLoadRW_';

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
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

