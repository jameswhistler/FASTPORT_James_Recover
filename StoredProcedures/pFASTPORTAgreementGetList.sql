if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[Agreement]
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
CREATE PROCEDURE pFASTPORTAgreementGetList
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
    SET @l_from_str = '[dbo].[Agreement] Agreement_'

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
            SET @l_sort_str = N'ORDER BY Agreement_.[AgreementID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [AgreementID] int
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[AgreementID]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'Agreement_.[AgreementID]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'Agreement_.[AgreementID],
            Agreement_.[CIX],
            Agreement_.[DocTreeParentID],
            Agreement_.[RoleID],
            Agreement_.[CustomID],
            Agreement_.[DocIndex],
            Agreement_.[DocSort],
            Agreement_.[Agreement],
            Agreement_.[Description],
            Agreement_.[RequiredDoc],
            Agreement_.[DocRank],
            Agreement_.[Hide],
            Agreement_.[AgreementFile],
            Agreement_.[AgreementFileName],
            Agreement_.[FlowCollectionID],
            Agreement_.[UseStoredSignature],
            Agreement_.[ShowSignatureDate],
            Agreement_.[ShowExpirationDate],
            Agreement_.[InitialsInDocument],
            Agreement_.[DocHasCustomFields],
            Agreement_.[ExecuteFromBoard],
            Agreement_.[SenderInstructions],
            Agreement_.[RecipientInstructions],
            Agreement_.[OtherInstructions],
            Agreement_.[FirstItem],
            Agreement_.[FirstTypeID],
            Agreement_.[FirstDefault],
            Agreement_.[FirstByCIX],
            Agreement_.[FirstByOIX],
            Agreement_.[SecondItem],
            Agreement_.[SecondTypeID],
            Agreement_.[SecondDefault],
            Agreement_.[SecondByCIX],
            Agreement_.[SecondByOIX],
            Agreement_.[ThirdItem],
            Agreement_.[ThirdTypeID],
            Agreement_.[ThirdDefault],
            Agreement_.[ThirdByCIX],
            Agreement_.[ThirdByOIX],
            Agreement_.[FourthItem],
            Agreement_.[FourthTypeID],
            Agreement_.[FourthDefault],
            Agreement_.[FourthByCIX],
            Agreement_.[FourthByOIX],
            Agreement_.[FifthItem],
            Agreement_.[FifthTypeID],
            Agreement_.[FifthDefault],
            Agreement_.[FifthByCIX],
            Agreement_.[FifthByOIX],
            Agreement_.[SixthItem],
            Agreement_.[SixthTypeID],
            Agreement_.[SixthDefault],
            Agreement_.[SixthByCIX],
            Agreement_.[SixthByOIX],
            Agreement_.[SeventhItem],
            Agreement_.[SeventhTypeID],
            Agreement_.[SeventhDefault],
            Agreement_.[SeventhByCIX],
            Agreement_.[SeventhByOIX],
            Agreement_.[EighthItem],
            Agreement_.[EighthTypeID],
            Agreement_.[EighthDefault],
            Agreement_.[EighthByCIX],
            Agreement_.[EighthByOIX],
            Agreement_.[NinthItem],
            Agreement_.[NinthTypeID],
            Agreement_.[NinthDefault],
            Agreement_.[NinthByCIX],
            Agreement_.[NinthByOIX],
            Agreement_.[TenthItem],
            Agreement_.[TenthTypeID],
            Agreement_.[TenthDefault],
            Agreement_.[TenthByCIX],
            Agreement_.[TenthByOIX],
            Agreement_.[EleventhItem],
            Agreement_.[EleventhTypeID],
            Agreement_.[EleventhDefault],
            Agreement_.[EleventhByCIX],
            Agreement_.[EleventhByOIX],
            Agreement_.[TwelfthItem],
            Agreement_.[TwelfthTypeID],
            Agreement_.[TwelfthDefault],
            Agreement_.[TwelfthByCIX],
            Agreement_.[TwelfthByOIX],
            Agreement_.[ThirteenthItem],
            Agreement_.[ThirteenthTypeID],
            Agreement_.[ThirteenthDefault],
            Agreement_.[ThirteenthByCIX],
            Agreement_.[ThirteenthByOIX],
            Agreement_.[FourteenthItem],
            Agreement_.[FourteenthTypeID],
            Agreement_.[FourteenthDefault],
            Agreement_.[FourteenthByCIX],
            Agreement_.[FourteenthByOIX],
            Agreement_.[FifteenthItem],
            Agreement_.[FifteenthTypeID],
            Agreement_.[FifteenthDefault],
            Agreement_.[FifteenthByCIX],
            Agreement_.[FifteenthByOIX], '
        SET @l_query_cols2 = 
            N'            Agreement_.[CreatedByID],
            Agreement_.[CreatedAt],
            Agreement_.[UpdatedByID],
            Agreement_.[UpdatedAt],
            CAST(BINARY_CHECKSUM(Agreement_.[AgreementID],Agreement_.[CIX],Agreement_.[DocTreeParentID],Agreement_.[RoleID],Agreement_.[CustomID],Agreement_.[DocIndex],Agreement_.[DocSort],Agreement_.[Agreement],Agreement_.[Description],Agreement_.[RequiredDoc],Agreement_.[DocRank],Agreement_.[Hide],Agreement_.[AgreementFile],Agreement_.[AgreementFileName],Agreement_.[FlowCollectionID],Agreement_.[UseStoredSignature],Agreement_.[ShowSignatureDate],Agreement_.[ShowExpirationDate],Agreement_.[InitialsInDocument],Agreement_.[DocHasCustomFields],Agreement_.[ExecuteFromBoard],Agreement_.[SenderInstructions],Agreement_.[RecipientInstructions],Agreement_.[OtherInstructions],Agreement_.[FirstItem],Agreement_.[FirstTypeID],Agreement_.[FirstDefault],Agreement_.[FirstByCIX],Agreement_.[FirstByOIX],Agreement_.[SecondItem],Agreement_.[SecondTypeID],Agreement_.[SecondDefault],Agreement_.[SecondByCIX],Agreement_.[SecondByOIX],Agreement_.[ThirdItem],Agreement_.[ThirdTypeID],Agreement_.[ThirdDefault],Agreement_.[ThirdByCIX],Agreement_.[ThirdByOIX],Agreement_.[FourthItem],Agreement_.[FourthTypeID],Agreement_.[FourthDefault],Agreement_.[FourthByCIX],Agreement_.[FourthByOIX],Agreement_.[FifthItem],Agreement_.[FifthTypeID],Agreement_.[FifthDefault],Agreement_.[FifthByCIX],Agreement_.[FifthByOIX],Agreement_.[SixthItem],Agreement_.[SixthTypeID],Agreement_.[SixthDefault],Agreement_.[SixthByCIX],Agreement_.[SixthByOIX],Agreement_.[SeventhItem],Agreement_.[SeventhTypeID],Agreement_.[SeventhDefault],Agreement_.[SeventhByCIX],Agreement_.[SeventhByOIX],Agreement_.[EighthItem],Agreement_.[EighthTypeID],Agreement_.[EighthDefault],Agreement_.[EighthByCIX],Agreement_.[EighthByOIX],Agreement_.[NinthItem],Agreement_.[NinthTypeID],Agreement_.[NinthDefault],Agreement_.[NinthByCIX],Agreement_.[NinthByOIX],Agreement_.[TenthItem],Agreement_.[TenthTypeID],Agreement_.[TenthDefault],Agreement_.[TenthByCIX],Agreement_.[TenthByOIX],Agreement_.[EleventhItem],Agreement_.[EleventhTypeID],Agreement_.[EleventhDefault],Agreement_.[EleventhByCIX],Agreement_.[EleventhByOIX],Agreement_.[TwelfthItem],Agreement_.[TwelfthTypeID],Agreement_.[TwelfthDefault],Agreement_.[TwelfthByCIX],Agreement_.[TwelfthByOIX],Agreement_.[ThirteenthItem],Agreement_.[ThirteenthTypeID],Agreement_.[ThirteenthDefault],Agreement_.[ThirteenthByCIX],Agreement_.[ThirteenthByOIX],Agreement_.[FourteenthItem],Agreement_.[FourteenthTypeID],Agreement_.[FourteenthDefault],Agreement_.[FourteenthByCIX],Agreement_.[FourteenthByOIX],Agreement_.[FifteenthItem],Agreement_.[FifteenthTypeID],Agreement_.[FifteenthDefault],Agreement_.[FifteenthByCIX],Agreement_.[FifteenthByOIX],Agreement_.[CreatedByID],Agreement_.[CreatedAt],Agreement_.[UpdatedByID],Agreement_.[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345 '
        SET @l_query_from = 
            'FROM ( ' +
                N'SELECT TOP 100 PERCENT IS_ROWNUM_COL, [AgreementID] from @IS_TEMP_T_GETLIST ' +
                'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) + 
                ') IS_ALIAS LEFT JOIN ' +
                @l_from_str + ' ';

        SET @l_query_where = 
            N'ON Agreement_.[AgreementID] = IS_ALIAS.[AgreementID] ' 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'Agreement_.[AgreementID],
            Agreement_.[CIX],
            Agreement_.[DocTreeParentID],
            Agreement_.[RoleID],
            Agreement_.[CustomID],
            Agreement_.[DocIndex],
            Agreement_.[DocSort],
            Agreement_.[Agreement],
            Agreement_.[Description],
            Agreement_.[RequiredDoc],
            Agreement_.[DocRank],
            Agreement_.[Hide],
            Agreement_.[AgreementFile],
            Agreement_.[AgreementFileName],
            Agreement_.[FlowCollectionID],
            Agreement_.[UseStoredSignature],
            Agreement_.[ShowSignatureDate],
            Agreement_.[ShowExpirationDate],
            Agreement_.[InitialsInDocument],
            Agreement_.[DocHasCustomFields],
            Agreement_.[ExecuteFromBoard],
            Agreement_.[SenderInstructions],
            Agreement_.[RecipientInstructions],
            Agreement_.[OtherInstructions],
            Agreement_.[FirstItem],
            Agreement_.[FirstTypeID],
            Agreement_.[FirstDefault],
            Agreement_.[FirstByCIX],
            Agreement_.[FirstByOIX],
            Agreement_.[SecondItem],
            Agreement_.[SecondTypeID],
            Agreement_.[SecondDefault],
            Agreement_.[SecondByCIX],
            Agreement_.[SecondByOIX],
            Agreement_.[ThirdItem],
            Agreement_.[ThirdTypeID],
            Agreement_.[ThirdDefault],
            Agreement_.[ThirdByCIX],
            Agreement_.[ThirdByOIX],
            Agreement_.[FourthItem],
            Agreement_.[FourthTypeID],
            Agreement_.[FourthDefault],
            Agreement_.[FourthByCIX],
            Agreement_.[FourthByOIX],
            Agreement_.[FifthItem],
            Agreement_.[FifthTypeID],
            Agreement_.[FifthDefault],
            Agreement_.[FifthByCIX],
            Agreement_.[FifthByOIX],
            Agreement_.[SixthItem],
            Agreement_.[SixthTypeID],
            Agreement_.[SixthDefault],
            Agreement_.[SixthByCIX],
            Agreement_.[SixthByOIX],
            Agreement_.[SeventhItem],
            Agreement_.[SeventhTypeID],
            Agreement_.[SeventhDefault],
            Agreement_.[SeventhByCIX],
            Agreement_.[SeventhByOIX],
            Agreement_.[EighthItem],
            Agreement_.[EighthTypeID],
            Agreement_.[EighthDefault],
            Agreement_.[EighthByCIX],
            Agreement_.[EighthByOIX],
            Agreement_.[NinthItem],
            Agreement_.[NinthTypeID],
            Agreement_.[NinthDefault],
            Agreement_.[NinthByCIX],
            Agreement_.[NinthByOIX],
            Agreement_.[TenthItem],
            Agreement_.[TenthTypeID],
            Agreement_.[TenthDefault],
            Agreement_.[TenthByCIX],
            Agreement_.[TenthByOIX],
            Agreement_.[EleventhItem],
            Agreement_.[EleventhTypeID],
            Agreement_.[EleventhDefault],
            Agreement_.[EleventhByCIX],
            Agreement_.[EleventhByOIX],
            Agreement_.[TwelfthItem],
            Agreement_.[TwelfthTypeID],
            Agreement_.[TwelfthDefault],
            Agreement_.[TwelfthByCIX],
            Agreement_.[TwelfthByOIX],
            Agreement_.[ThirteenthItem],
            Agreement_.[ThirteenthTypeID],
            Agreement_.[ThirteenthDefault],
            Agreement_.[ThirteenthByCIX],
            Agreement_.[ThirteenthByOIX],
            Agreement_.[FourteenthItem],
            Agreement_.[FourteenthTypeID],
            Agreement_.[FourteenthDefault],
            Agreement_.[FourteenthByCIX],
            Agreement_.[FourteenthByOIX],
            Agreement_.[FifteenthItem],
            Agreement_.[FifteenthTypeID],
            Agreement_.[FifteenthDefault],
            Agreement_.[FifteenthByCIX],
            Agreement_.[FifteenthByOIX],'
        SET @l_query_cols2 = 
            N'            Agreement_.[CreatedByID],
            Agreement_.[CreatedAt],
            Agreement_.[UpdatedByID],
            Agreement_.[UpdatedAt],
            CAST(BINARY_CHECKSUM(Agreement_.[AgreementID],Agreement_.[CIX],Agreement_.[DocTreeParentID],Agreement_.[RoleID],Agreement_.[CustomID],Agreement_.[DocIndex],Agreement_.[DocSort],Agreement_.[Agreement],Agreement_.[Description],Agreement_.[RequiredDoc],Agreement_.[DocRank],Agreement_.[Hide],Agreement_.[AgreementFile],Agreement_.[AgreementFileName],Agreement_.[FlowCollectionID],Agreement_.[UseStoredSignature],Agreement_.[ShowSignatureDate],Agreement_.[ShowExpirationDate],Agreement_.[InitialsInDocument],Agreement_.[DocHasCustomFields],Agreement_.[ExecuteFromBoard],Agreement_.[SenderInstructions],Agreement_.[RecipientInstructions],Agreement_.[OtherInstructions],Agreement_.[FirstItem],Agreement_.[FirstTypeID],Agreement_.[FirstDefault],Agreement_.[FirstByCIX],Agreement_.[FirstByOIX],Agreement_.[SecondItem],Agreement_.[SecondTypeID],Agreement_.[SecondDefault],Agreement_.[SecondByCIX],Agreement_.[SecondByOIX],Agreement_.[ThirdItem],Agreement_.[ThirdTypeID],Agreement_.[ThirdDefault],Agreement_.[ThirdByCIX],Agreement_.[ThirdByOIX],Agreement_.[FourthItem],Agreement_.[FourthTypeID],Agreement_.[FourthDefault],Agreement_.[FourthByCIX],Agreement_.[FourthByOIX],Agreement_.[FifthItem],Agreement_.[FifthTypeID],Agreement_.[FifthDefault],Agreement_.[FifthByCIX],Agreement_.[FifthByOIX],Agreement_.[SixthItem],Agreement_.[SixthTypeID],Agreement_.[SixthDefault],Agreement_.[SixthByCIX],Agreement_.[SixthByOIX],Agreement_.[SeventhItem],Agreement_.[SeventhTypeID],Agreement_.[SeventhDefault],Agreement_.[SeventhByCIX],Agreement_.[SeventhByOIX],Agreement_.[EighthItem],Agreement_.[EighthTypeID],Agreement_.[EighthDefault],Agreement_.[EighthByCIX],Agreement_.[EighthByOIX],Agreement_.[NinthItem],Agreement_.[NinthTypeID],Agreement_.[NinthDefault],Agreement_.[NinthByCIX],Agreement_.[NinthByOIX],Agreement_.[TenthItem],Agreement_.[TenthTypeID],Agreement_.[TenthDefault],Agreement_.[TenthByCIX],Agreement_.[TenthByOIX],Agreement_.[EleventhItem],Agreement_.[EleventhTypeID],Agreement_.[EleventhDefault],Agreement_.[EleventhByCIX],Agreement_.[EleventhByOIX],Agreement_.[TwelfthItem],Agreement_.[TwelfthTypeID],Agreement_.[TwelfthDefault],Agreement_.[TwelfthByCIX],Agreement_.[TwelfthByOIX],Agreement_.[ThirteenthItem],Agreement_.[ThirteenthTypeID],Agreement_.[ThirteenthDefault],Agreement_.[ThirteenthByCIX],Agreement_.[ThirteenthByOIX],Agreement_.[FourteenthItem],Agreement_.[FourteenthTypeID],Agreement_.[FourteenthDefault],Agreement_.[FourteenthByCIX],Agreement_.[FourteenthByOIX],Agreement_.[FifteenthItem],Agreement_.[FifteenthTypeID],Agreement_.[FifteenthDefault],Agreement_.[FifteenthByCIX],Agreement_.[FifteenthByOIX],Agreement_.[CreatedByID],Agreement_.[CreatedAt],Agreement_.[UpdatedByID],Agreement_.[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345'
        SET @l_query_from = 
            ' FROM [dbo].[Agreement] Agreement_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from);
    END

    SET NOCOUNT OFF

END

