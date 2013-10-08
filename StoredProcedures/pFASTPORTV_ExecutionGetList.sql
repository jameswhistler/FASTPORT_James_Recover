if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_ExecutionGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTV_ExecutionGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[v_Execution]
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
CREATE PROCEDURE pFASTPORTV_ExecutionGetList
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
    SET @l_from_str = '[dbo].[v_Execution] V_Execution_'

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
            SET @l_sort_str = N'ORDER BY V_Execution_.[ExecutionID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [ExecutionID] int
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[ExecutionID]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'V_Execution_.[ExecutionID]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'V_Execution_.[ExecutionID],
            V_Execution_.[CIX],
            V_Execution_.[OIX],
            V_Execution_.[AgreementID],
            V_Execution_.[FlowStepID],
            V_Execution_.[SenderAddrID],
            V_Execution_.[SenderSignerID],
            V_Execution_.[RecipientAddrID],
            V_Execution_.[RecipientSignerID],
            V_Execution_.[SignedOn],
            V_Execution_.[ExpiresOn],
            V_Execution_.[AddSignaturePage],
            V_Execution_.[FirstItem],
            V_Execution_.[SecondItem],
            V_Execution_.[ThirdItem],
            V_Execution_.[FourthItem],
            V_Execution_.[FifthItem],
            V_Execution_.[SixthItem],
            V_Execution_.[SeventhItem],
            V_Execution_.[EighthItem],
            V_Execution_.[NinthItem],
            V_Execution_.[TenthItem],
            V_Execution_.[EleventhItem],
            V_Execution_.[TwelfthItem],
            V_Execution_.[ThirteenthItem],
            V_Execution_.[FourteenthItem],
            V_Execution_.[FifteenthItem],
            V_Execution_.[ShowSignatureDate],
            V_Execution_.[ShowExpirationDate],
            V_Execution_.[ExecuteFromBoard],
            V_Execution_.[OtherInstructions],
            V_Execution_.[SenderInstructions],
            V_Execution_.[RecipientInstructions],
            V_Execution_.[FirstItemName],
            V_Execution_.[FirstTypeID],
            V_Execution_.[FirstDefault],
            V_Execution_.[FirstByCIX],
            V_Execution_.[FirstByOIX],
            V_Execution_.[SecondItemName],
            V_Execution_.[SecondTypeID],
            V_Execution_.[SecondDefault],
            V_Execution_.[SecondByCIX],
            V_Execution_.[SecondByOIX],
            V_Execution_.[ThirdItemName],
            V_Execution_.[ThirdTypeID],
            V_Execution_.[ThirdDefault],
            V_Execution_.[ThirdByCIX],
            V_Execution_.[ThirdByOIX],
            V_Execution_.[FourthItemName],
            V_Execution_.[FourthTypeID],
            V_Execution_.[FourthDefault],
            V_Execution_.[FourthByCIX],
            V_Execution_.[FourthByOIX],
            V_Execution_.[FifthItemName],
            V_Execution_.[FifthTypeID],
            V_Execution_.[FifthDefault],
            V_Execution_.[FifthByCIX],
            V_Execution_.[FifthByOIX],
            V_Execution_.[SixthItemName],
            V_Execution_.[SixthTypeID],
            V_Execution_.[SixthDefault],
            V_Execution_.[SixthByCIX],
            V_Execution_.[SixthByOIX],
            V_Execution_.[SeventhItemName],
            V_Execution_.[SeventhTypeID],
            V_Execution_.[SeventhDefault],
            V_Execution_.[SeventhByCIX],
            V_Execution_.[SeventhByOIX],
            V_Execution_.[EighthItemName],
            V_Execution_.[EighthTypeID],
            V_Execution_.[EighthDefault],
            V_Execution_.[EighthByCIX],
            V_Execution_.[EighthByOIX],
            V_Execution_.[NinthItemName],
            V_Execution_.[NinthTypeID],
            V_Execution_.[NinthDefault],
            V_Execution_.[NinthByCIX],
            V_Execution_.[NinthByOIX],
            V_Execution_.[TenthItemName],
            V_Execution_.[TenthTypeID],
            V_Execution_.[TenthDefault],
            V_Execution_.[TenthByCIX],
            V_Execution_.[TenthByOIX],
            V_Execution_.[EleventhItemName],
            V_Execution_.[EleventhTypeID],
            V_Execution_.[EleventhDefault],
            V_Execution_.[EleventhByCIX],
            V_Execution_.[EleventhByOIX],
            V_Execution_.[TwelfthItemName],
            V_Execution_.[TwelfthTypeID],
            V_Execution_.[TwelfthDefault],
            V_Execution_.[TwelfthByCIX],
            V_Execution_.[TwelfthByOIX],
            V_Execution_.[ThirteenthItemName],
            V_Execution_.[ThirteenthTypeID], '
        SET @l_query_cols2 = 
            N'            V_Execution_.[ThirteenthDefault],
            V_Execution_.[ThirteenthByCIX],
            V_Execution_.[ThirteenthByOIX],
            V_Execution_.[FourteenthItemName],
            V_Execution_.[FourteenthTypeID],
            V_Execution_.[FourteenthDefault],
            V_Execution_.[FourteenthByCIX],
            V_Execution_.[FourteenthByOIX],
            V_Execution_.[FifteenthItemName],
            V_Execution_.[FifteenthTypeID],
            V_Execution_.[FifteenthDefault],
            V_Execution_.[FifteenthByCIX],
            V_Execution_.[FifteenthByOIX] '
        SET @l_query_from = 
            'FROM ( ' +
                N'SELECT TOP 100 PERCENT IS_ROWNUM_COL, [ExecutionID] from @IS_TEMP_T_GETLIST ' +
                'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) + 
                ') IS_ALIAS LEFT JOIN ' +
                @l_from_str + ' ';

        SET @l_query_where = 
            N'ON V_Execution_.[ExecutionID] = IS_ALIAS.[ExecutionID] ' 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'V_Execution_.[ExecutionID],
            V_Execution_.[CIX],
            V_Execution_.[OIX],
            V_Execution_.[AgreementID],
            V_Execution_.[FlowStepID],
            V_Execution_.[SenderAddrID],
            V_Execution_.[SenderSignerID],
            V_Execution_.[RecipientAddrID],
            V_Execution_.[RecipientSignerID],
            V_Execution_.[SignedOn],
            V_Execution_.[ExpiresOn],
            V_Execution_.[AddSignaturePage],
            V_Execution_.[FirstItem],
            V_Execution_.[SecondItem],
            V_Execution_.[ThirdItem],
            V_Execution_.[FourthItem],
            V_Execution_.[FifthItem],
            V_Execution_.[SixthItem],
            V_Execution_.[SeventhItem],
            V_Execution_.[EighthItem],
            V_Execution_.[NinthItem],
            V_Execution_.[TenthItem],
            V_Execution_.[EleventhItem],
            V_Execution_.[TwelfthItem],
            V_Execution_.[ThirteenthItem],
            V_Execution_.[FourteenthItem],
            V_Execution_.[FifteenthItem],
            V_Execution_.[ShowSignatureDate],
            V_Execution_.[ShowExpirationDate],
            V_Execution_.[ExecuteFromBoard],
            V_Execution_.[OtherInstructions],
            V_Execution_.[SenderInstructions],
            V_Execution_.[RecipientInstructions],
            V_Execution_.[FirstItemName],
            V_Execution_.[FirstTypeID],
            V_Execution_.[FirstDefault],
            V_Execution_.[FirstByCIX],
            V_Execution_.[FirstByOIX],
            V_Execution_.[SecondItemName],
            V_Execution_.[SecondTypeID],
            V_Execution_.[SecondDefault],
            V_Execution_.[SecondByCIX],
            V_Execution_.[SecondByOIX],
            V_Execution_.[ThirdItemName],
            V_Execution_.[ThirdTypeID],
            V_Execution_.[ThirdDefault],
            V_Execution_.[ThirdByCIX],
            V_Execution_.[ThirdByOIX],
            V_Execution_.[FourthItemName],
            V_Execution_.[FourthTypeID],
            V_Execution_.[FourthDefault],
            V_Execution_.[FourthByCIX],
            V_Execution_.[FourthByOIX],
            V_Execution_.[FifthItemName],
            V_Execution_.[FifthTypeID],
            V_Execution_.[FifthDefault],
            V_Execution_.[FifthByCIX],
            V_Execution_.[FifthByOIX],
            V_Execution_.[SixthItemName],
            V_Execution_.[SixthTypeID],
            V_Execution_.[SixthDefault],
            V_Execution_.[SixthByCIX],
            V_Execution_.[SixthByOIX],
            V_Execution_.[SeventhItemName],
            V_Execution_.[SeventhTypeID],
            V_Execution_.[SeventhDefault],
            V_Execution_.[SeventhByCIX],
            V_Execution_.[SeventhByOIX],
            V_Execution_.[EighthItemName],
            V_Execution_.[EighthTypeID],
            V_Execution_.[EighthDefault],
            V_Execution_.[EighthByCIX],
            V_Execution_.[EighthByOIX],
            V_Execution_.[NinthItemName],
            V_Execution_.[NinthTypeID],
            V_Execution_.[NinthDefault],
            V_Execution_.[NinthByCIX],
            V_Execution_.[NinthByOIX],
            V_Execution_.[TenthItemName],
            V_Execution_.[TenthTypeID],
            V_Execution_.[TenthDefault],
            V_Execution_.[TenthByCIX],
            V_Execution_.[TenthByOIX],
            V_Execution_.[EleventhItemName],
            V_Execution_.[EleventhTypeID],
            V_Execution_.[EleventhDefault],
            V_Execution_.[EleventhByCIX],
            V_Execution_.[EleventhByOIX],
            V_Execution_.[TwelfthItemName],
            V_Execution_.[TwelfthTypeID],
            V_Execution_.[TwelfthDefault],
            V_Execution_.[TwelfthByCIX],
            V_Execution_.[TwelfthByOIX],
            V_Execution_.[ThirteenthItemName],
            V_Execution_.[ThirteenthTypeID],'
        SET @l_query_cols2 = 
            N'            V_Execution_.[ThirteenthDefault],
            V_Execution_.[ThirteenthByCIX],
            V_Execution_.[ThirteenthByOIX],
            V_Execution_.[FourteenthItemName],
            V_Execution_.[FourteenthTypeID],
            V_Execution_.[FourteenthDefault],
            V_Execution_.[FourteenthByCIX],
            V_Execution_.[FourteenthByOIX],
            V_Execution_.[FifteenthItemName],
            V_Execution_.[FifteenthTypeID],
            V_Execution_.[FifteenthDefault],
            V_Execution_.[FifteenthByCIX],
            V_Execution_.[FifteenthByOIX]'
        SET @l_query_from = 
            ' FROM [dbo].[v_Execution] V_Execution_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from);
    END

    SET NOCOUNT OFF

END

