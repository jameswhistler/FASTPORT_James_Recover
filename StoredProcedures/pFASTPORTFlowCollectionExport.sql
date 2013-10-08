if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowCollectionExport') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowCollectionExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTFlowCollectionExport
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
                N'"FlowCollectionID"' + @p_separator_str +
                N'"FlowID"' + @p_separator_str +
                N'"""FlowID"" FirstElementDesc"' + @p_separator_str +
                N'"CollectionName"' + @p_separator_str +
                N'"CollectionRank"' + @p_separator_str +
                N'"DefaultURLParams"' + @p_separator_str +
                N'"GoAction"' + @p_separator_str +
                N'"StartingStepID"' + @p_separator_str +
                N'"""StartingStepID"" RefName"' + @p_separator_str +
                N'"ThreadID"' + @p_separator_str +
                N'"""ThreadID"" ThreadName"' + @p_separator_str +
                N'"CollectionDescription"' + @p_separator_str +
                N'"CopyFlowCollectionID"' + @p_separator_str +
                N'"RelatedToID"' + @p_separator_str +
                N'"""RelatedToID"" ItemName"' + ' ';
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
                N'IsNULL(Convert(nvarchar, FlowCollection_.[FlowCollectionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[FlowID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[FirstElementDesc], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowCollection_.[CollectionName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[CollectionRank]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowCollection_.[DefaultURLParams], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowCollection_.[GoAction], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[StartingStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[ThreadID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ThreadName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowCollection_.[CollectionDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[CopyFlowCollectionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowCollection_.[RelatedToID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[FlowCollection] FlowCollection_ LEFT OUTER JOIN [dbo].[Flow] t0 ON (FlowCollection_.[FlowID] =  t0.[FlowID]) LEFT OUTER JOIN [dbo].[FlowStep] t1 ON (FlowCollection_.[StartingStepID] =  t1.[FlowStepID]) LEFT OUTER JOIN [dbo].[Thread] t2 ON (FlowCollection_.[ThreadID] =  t2.[ThreadID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (FlowCollection_.[RelatedToID] =  t3.[TreeID])';

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

