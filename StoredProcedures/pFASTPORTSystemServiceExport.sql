if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemServiceExport') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemServiceExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTSystemServiceExport
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
                N'"ServiceID"' + @p_separator_str +
                N'"ServiceContextID"' + @p_separator_str +
                N'"""ServiceContextID"" ItemName"' + @p_separator_str +
                N'"ServiceTypeID"' + @p_separator_str +
                N'"""ServiceTypeID"" ItemName"' + @p_separator_str +
                N'"ServiceName"' + @p_separator_str +
                N'"ServiceDescription"' + @p_separator_str +
                N'"ServiceImageID"' + @p_separator_str +
                N'"""ServiceImageID"" ItemName"' + @p_separator_str +
                N'"ServiceRequired"' + @p_separator_str +
                N'"Fee"' + @p_separator_str +
                N'"DurationID"' + @p_separator_str +
                N'"""DurationID"" ItemName"' + @p_separator_str +
                N'"Units"' + @p_separator_str +
                N'"ServiceRank"' + ' ';
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
                N'IsNULL(Convert(nvarchar, SystemService_.[ServiceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[ServiceContextID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[ServiceTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(SystemService_.[ServiceName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(SystemService_.[ServiceDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[ServiceImageID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, SystemService_.[ServiceRequired]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[Fee]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[DurationID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[Units]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, SystemService_.[ServiceRank]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[SystemService] SystemService_ LEFT OUTER JOIN [dbo].[Tree] t0 ON (SystemService_.[ServiceContextID] =  t0.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (SystemService_.[ServiceTypeID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t2 ON (SystemService_.[ServiceImageID] =  t2.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (SystemService_.[DurationID] =  t3.[TreeID])';

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

