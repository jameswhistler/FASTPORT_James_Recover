if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowConfigExport') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowConfigExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTFlowConfigExport
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
                N'"ConfigID"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"""FlowStepID"" RefName"' + @p_separator_str +
                N'"ConfigRank"' + @p_separator_str +
                N'"IntendedForID"' + @p_separator_str +
                N'"""IntendedForID"" ItemName"' + @p_separator_str +
                N'"RoleID"' + @p_separator_str +
                N'"""RoleID"" Role"' + @p_separator_str +
                N'"MustAct"' + @p_separator_str +
                N'"SkipJump"' + @p_separator_str +
                N'"SendMessage"' + @p_separator_str +
                N'"Dashboard"' + @p_separator_str +
                N'"PageTitle"' + @p_separator_str +
                N'"Instructions"' + @p_separator_str +
                N'"LandingRedirect"' + @p_separator_str +
                N'"GoAction"' + @p_separator_str +
                N'"VideoURL"' + @p_separator_str +
                N'"VideoDescription"' + @p_separator_str +
                N'"FlowStepOneID"' + @p_separator_str +
                N'"""FlowStepOneID"" RefName"' + @p_separator_str +
                N'"ButtonOneID"' + @p_separator_str +
                N'"""ButtonOneID"" RefName"' + @p_separator_str +
                N'"FlowStepTwoID"' + @p_separator_str +
                N'"""FlowStepTwoID"" RefName"' + @p_separator_str +
                N'"ButtonTwoID"' + @p_separator_str +
                N'"""ButtonTwoID"" RefName"' + @p_separator_str +
                N'"FlowStepThreeID"' + @p_separator_str +
                N'"""FlowStepThreeID"" RefName"' + @p_separator_str +
                N'"ButtonThreeID"' + @p_separator_str +
                N'"""ButtonThreeID"" RefName"' + @p_separator_str +
                N'"FlowStepFourID"' + @p_separator_str +
                N'"""FlowStepFourID"" RefName"' + @p_separator_str +
                N'"ButtonFourID"' + @p_separator_str +
                N'"""ButtonFourID"" RefName"' + @p_separator_str +
                N'"RewindID"' + @p_separator_str +
                N'"""RewindID"" RefName"' + @p_separator_str +
                N'"FirstElement"' + @p_separator_str +
                N'"SecondElement"' + @p_separator_str +
                N'"ThirdElement"' + @p_separator_str +
                N'"FourthElement"' + @p_separator_str +
                N'"FifthElement"' + @p_separator_str +
                N'"SixthElement"' + @p_separator_str +
                N'"SeventhElement"' + @p_separator_str +
                N'"EighthElement"' + @p_separator_str +
                N'"NinthElement"' + @p_separator_str +
                N'"TenthElement"' + @p_separator_str +
                N'"EleventhElement"' + @p_separator_str +
                N'"TwelfthElement"' + @p_separator_str +
                N'"ThirteenthElement"' + @p_separator_str +
                N'"FourteenthElement"' + @p_separator_str +
                N'"FifteenthElement"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + @p_separator_str +
                N'"CopyConfigID"' + ' ';
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
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ConfigID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ConfigRank]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[IntendedForID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[RoleID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[Role], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[MustAct]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[SkipJump]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[SendMessage]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[Dashboard]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[PageTitle], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[Instructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[LandingRedirect], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[GoAction], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[VideoURL], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(FlowConfig_.[VideoDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[FlowStepOneID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ButtonOneID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[FlowStepTwoID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ButtonTwoID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t6.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[FlowStepThreeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t7.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ButtonThreeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t8.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[FlowStepFourID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL( t9.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[ButtonFourID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t10.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[RewindID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t11.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[FirstElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[SecondElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[ThirdElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[FourthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[FifthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[SixthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[SeventhElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[EighthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[NinthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[TenthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[EleventhElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[TwelfthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[ThirteenthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[FourteenthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, FlowConfig_.[FifteenthElement]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[UpdatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, FlowConfig_.[CopyConfigID]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[FlowConfig] FlowConfig_ LEFT OUTER JOIN [dbo].[FlowStep] t0 ON (FlowConfig_.[FlowStepID] =  t0.[FlowStepID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (FlowConfig_.[IntendedForID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[Role] t2 ON (FlowConfig_.[RoleID] =  t2.[RoleID]) LEFT OUTER JOIN [dbo].[FlowStep] t3 ON (FlowConfig_.[FlowStepOneID] =  t3.[FlowStepID]) LEFT OUTER JOIN [dbo].[FlowButton] t4 ON (FlowConfig_.[ButtonOneID] =  t4.[ButtonID]) LEFT OUTER JOIN [dbo].[FlowStep] t5 ON (FlowConfig_.[FlowStepTwoID] =  t5.[FlowStepID]) LEFT OUTER JOIN [dbo].[FlowButton] t6 ON (FlowConfig_.[ButtonTwoID] =  t6.[ButtonID]) LEFT OUTER JOIN [dbo].[FlowStep] t7 ON (FlowConfig_.[FlowStepThreeID] =  t7.[FlowStepID]) LEFT OUTER JOIN [dbo].[FlowButton] t8 ON (FlowConfig_.[ButtonThreeID] =  t8.[ButtonID]) LEFT OUTER JOIN [dbo].[FlowStep] t9 ON (FlowConfig_.[FlowStepFourID] =  t9.[FlowStepID]) LEFT OUTER JOIN [dbo].[FlowButton] t10 ON (FlowConfig_.[ButtonFourID] =  t10.[ButtonID]) LEFT OUTER JOIN [dbo].[FlowStep] t11 ON (FlowConfig_.[RewindID] =  t11.[FlowStepID])';

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

