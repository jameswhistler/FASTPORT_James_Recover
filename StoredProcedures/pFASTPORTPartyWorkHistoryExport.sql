if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPartyWorkHistoryExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(4000),
        @p_select_str nvarchar(4000),
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(4000),
        @l_select_str1 nvarchar(4000),
        @l_select_str2 nvarchar(4000),
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
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"StartMonthID"' + @p_separator_str +
                N'"EndMonthID"' + @p_separator_str +
                N'"Employed"' + @p_separator_str +
                N'"DrivingPosition"' + @p_separator_str +
                N'"EmployerID"' + @p_separator_str +
                N'"""EmployerID"" Name"' + @p_separator_str +
                N'"EmployerCompany"' + @p_separator_str +
                N'"EmployerAddr"' + @p_separator_str +
                N'"EmployerZipID"' + @p_separator_str +
                N'"EmployerCountryID"' + @p_separator_str +
                N'"EmployerContact"' + @p_separator_str +
                N'"EmployerEmail"' + @p_separator_str +
                N'"EmployerPhone"' + @p_separator_str +
                N'"EmployerFax"' + @p_separator_str +
                N'"ReasonForLeavingID"' + @p_separator_str +
                N'"""ReasonForLeavingID"" ItemName"' + @p_separator_str +
                N'"ReasonForLeavingNotes"' + @p_separator_str +
                N'"MilesPerWeek"' + @p_separator_str +
                N'"OperatedCommercialMotorVechicle"' + @p_separator_str +
                N'"HadDrugTestingProgram"' + @p_separator_str +
                N'"MayWeContact"' + @p_separator_str +
                N'"FirstJob"' + @p_separator_str +
                N'"Finished"' + @p_separator_str +
                N'"FinishedExp"' + @p_separator_str +
                N'"Notes"' + @p_separator_str +
                N'"TerminalID"' + @p_separator_str +
                N'"""TerminalID"" AddrName"' + @p_separator_str +
                N'"HireDate"' + @p_separator_str +
                N'"TermDate"' + @p_separator_str +
                N'"Overlap"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str, 1, 2) = 'ID'
            SET @l_title_str = 
                '"' + 
                SUBSTRING(@l_title_str, 1, PATINDEX('%,%', @l_title_str)-1) + 
                '"' + 
                SUBSTRING(@l_title_str, PATINDEX('%,%', @l_title_str), LEN(@l_title_str)); 

        -- Set up the select string
        SET @l_select_str1 = @p_select_str
        SET @l_select_str2 = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[HistoryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[StartMonthID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[EndMonthID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[Employed]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[DrivingPosition]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[EmployerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerCompany], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerAddr], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[EmployerZipID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[EmployerCountryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerContact], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerEmail], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerPhone], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[EmployerFax], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[ReasonForLeavingID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[ReasonForLeavingNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[MilesPerWeek]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[OperatedCommercialMotorVechicle]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[HadDrugTestingProgram]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[MayWeContact]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[FirstJob]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[Finished]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistory_.[FinishedExp]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistory_.[Notes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[TerminalID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL( t5.[AddrName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[HireDate], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[TermDate], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistory_.[Overlap]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[PartyWorkHistory] PartyWorkHistory_ LEFT OUTER JOIN [dbo].[Party] t0 ON (PartyWorkHistory_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[Party] t3 ON (PartyWorkHistory_.[EmployerID] =  t3.[PartyID]) LEFT OUTER JOIN [dbo].[Tree] t4 ON (PartyWorkHistory_.[ReasonForLeavingID] =  t4.[TreeID]) LEFT OUTER JOIN [dbo].[PartyAddr] t5 ON (PartyWorkHistory_.[TerminalID] =  t5.[AddrID])';

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
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str1 + @l_select_str2+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

