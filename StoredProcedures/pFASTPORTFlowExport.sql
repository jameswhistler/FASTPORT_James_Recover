if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowExport') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTFlowExport
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
                N'"FlowID"' + @p_separator_str +
                N'"FlowPage"' + @p_separator_str +
                N'"FirstElementDesc"' + @p_separator_str +
                N'"SecondElementDesc"' + @p_separator_str +
                N'"ThirdElementDesc"' + @p_separator_str +
                N'"FourthElementDesc"' + @p_separator_str +
                N'"FifthElementDesc"' + @p_separator_str +
                N'"SixthElementDesc"' + @p_separator_str +
                N'"SeventhElementDesc"' + @p_separator_str +
                N'"EighthElementDesc"' + @p_separator_str +
                N'"NinthElementDesc"' + @p_separator_str +
                N'"TenthElementDesc"' + @p_separator_str +
                N'"EleventhElementDesc"' + @p_separator_str +
                N'"TwelfthElementDesc"' + @p_separator_str +
                N'"ThirteenthElementDesc"' + @p_separator_str +
                N'"FourteenthElementDesc"' + @p_separator_str +
                N'"FifteenthElementDesc"' + @p_separator_str +
                N'"FirstButtonDesc"' + @p_separator_str +
                N'"SecondButtonDesc"' + @p_separator_str +
                N'"ThirdButtonDesc"' + @p_separator_str +
                N'"FourthButtonDesc"' + @p_separator_str +
                N'"FifthButtonDesc"' + @p_separator_str +
                N'"SixthButtonDesc"' + @p_separator_str +
                N'"SeventhButtonDesc"' + @p_separator_str +
                N'"EighthButtonDesc"' + @p_separator_str +
                N'"NinthButtonDesc"' + @p_separator_str +
                N'"TenthButtonDesc"' + @p_separator_str +
                N'"RelatedToID"' + @p_separator_str +
                N'"""RelatedToID"" ItemName"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + ' ';
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
                N'IsNULL(Convert(nvarchar, Flow_.[FlowID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FlowPage], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FirstElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SecondElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[ThirdElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FourthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FifthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SixthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SeventhElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[EighthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[NinthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[TenthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[EleventhElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[TwelfthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[ThirteenthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FourteenthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FifteenthElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FirstButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SecondButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[ThirdButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FourthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[FifthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SixthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[SeventhButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[EighthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[NinthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Flow_.[TenthButtonDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Flow_.[RelatedToID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, Flow_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Flow_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Flow_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Flow_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[Flow] Flow_ LEFT OUTER JOIN [dbo].[Tree] t0 ON (Flow_.[RelatedToID] =  t0.[TreeID])';

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

