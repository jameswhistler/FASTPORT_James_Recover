if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_AgreementGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTV_AgreementGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[v_Agreement]
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
CREATE PROCEDURE pFASTPORTV_AgreementGetList
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
    @l_query_cols nvarchar(4000),
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
    SET @l_from_str = '[dbo].[v_Agreement] V_Agreement_'

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
            SET @l_sort_str = ' '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [ExecutionID] int,
    [AgreementID] int,
    [CIX] int,
    [OIX] int,
    [DateToExecute] datetime,
    [MakerAddrID] int,
    [MakerName] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerLogo] image,
    [MakerAddr] varchar(3000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerCityST] nvarchar(88) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerCountry] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerSignerID] int,
    [MakerSigner] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerSignerTitle] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [MakerSignature] image,
    [OffereeAddrID] int,
    [OffereeName] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeAddr] varchar(3000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeCityST] nvarchar(88) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeCountry] nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeSignerID] int,
    [OffereeSigner] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeSignerTitle] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [OffereeSignature] image,
    [FirstItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [FirstItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SecondItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SecondItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [ThirdItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [ThirdItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [FourthItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [FourthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [FifthItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [FifthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SixthItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SixthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SeventhItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [SeventhItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [EightItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [EighthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [NinthItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [NinthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [TenthItemLabel] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS,
    [TenthItem] varchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[ExecutionID],
            [AgreementID],
            [CIX],
            [OIX],
            [DateToExecute],
            [MakerAddrID],
            [MakerName],
            [MakerLogo],
            [MakerAddr],
            [MakerCityST],
            [MakerCountry],
            [MakerSignerID],
            [MakerSigner],
            [MakerSignerTitle],
            [MakerSignature],
            [OffereeAddrID],
            [OffereeName],
            [OffereeAddr],
            [OffereeCityST],
            [OffereeCountry],
            [OffereeSignerID],
            [OffereeSigner],
            [OffereeSignerTitle],
            [OffereeSignature],
            [FirstItemLabel],
            [FirstItem],
            [SecondItemLabel],
            [SecondItem],
            [ThirdItemLabel],
            [ThirdItem],
            [FourthItemLabel],
            [FourthItem],
            [FifthItemLabel],
            [FifthItem],
            [SixthItemLabel],
            [SixthItem],
            [SeventhItemLabel],
            [SeventhItem],
            [EightItemLabel],
            [EighthItem],
            [NinthItemLabel],
            [NinthItem],
            [TenthItemLabel],
            [TenthItem]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'V_Agreement_.[ExecutionID],
            V_Agreement_.[AgreementID],
            V_Agreement_.[CIX],
            V_Agreement_.[OIX],
            V_Agreement_.[DateToExecute],
            V_Agreement_.[MakerAddrID],
            V_Agreement_.[MakerName],
            V_Agreement_.[MakerLogo],
            V_Agreement_.[MakerAddr],
            V_Agreement_.[MakerCityST],
            V_Agreement_.[MakerCountry],
            V_Agreement_.[MakerSignerID],
            V_Agreement_.[MakerSigner],
            V_Agreement_.[MakerSignerTitle],
            V_Agreement_.[MakerSignature],
            V_Agreement_.[OffereeAddrID],
            V_Agreement_.[OffereeName],
            V_Agreement_.[OffereeAddr],
            V_Agreement_.[OffereeCityST],
            V_Agreement_.[OffereeCountry],
            V_Agreement_.[OffereeSignerID],
            V_Agreement_.[OffereeSigner],
            V_Agreement_.[OffereeSignerTitle],
            V_Agreement_.[OffereeSignature],
            V_Agreement_.[FirstItemLabel],
            V_Agreement_.[FirstItem],
            V_Agreement_.[SecondItemLabel],
            V_Agreement_.[SecondItem],
            V_Agreement_.[ThirdItemLabel],
            V_Agreement_.[ThirdItem],
            V_Agreement_.[FourthItemLabel],
            V_Agreement_.[FourthItem],
            V_Agreement_.[FifthItemLabel],
            V_Agreement_.[FifthItem],
            V_Agreement_.[SixthItemLabel],
            V_Agreement_.[SixthItem],
            V_Agreement_.[SeventhItemLabel],
            V_Agreement_.[SeventhItem],
            V_Agreement_.[EightItemLabel],
            V_Agreement_.[EighthItem],
            V_Agreement_.[NinthItemLabel],
            V_Agreement_.[NinthItem],
            V_Agreement_.[TenthItemLabel],
            V_Agreement_.[TenthItem]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'[ExecutionID],
            [AgreementID],
            [CIX],
            [OIX],
            [DateToExecute],
            [MakerAddrID],
            [MakerName],
            [MakerLogo],
            [MakerAddr],
            [MakerCityST],
            [MakerCountry],
            [MakerSignerID],
            [MakerSigner],
            [MakerSignerTitle],
            [MakerSignature],
            [OffereeAddrID],
            [OffereeName],
            [OffereeAddr],
            [OffereeCityST],
            [OffereeCountry],
            [OffereeSignerID],
            [OffereeSigner],
            [OffereeSignerTitle],
            [OffereeSignature],
            [FirstItemLabel],
            [FirstItem],
            [SecondItemLabel],
            [SecondItem],
            [ThirdItemLabel],
            [ThirdItem],
            [FourthItemLabel],
            [FourthItem],
            [FifthItemLabel],
            [FifthItem],
            [SixthItemLabel],
            [SixthItem],
            [SeventhItemLabel],
            [SeventhItem],
            [EightItemLabel],
            [EighthItem],
            [NinthItemLabel],
            [NinthItem],
            [TenthItemLabel],
            [TenthItem]'

        SET @l_query_from = 
            'FROM @IS_TEMP_T_GETLIST ' +
            'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'V_Agreement_.[ExecutionID],
            V_Agreement_.[AgreementID],
            V_Agreement_.[CIX],
            V_Agreement_.[OIX],
            V_Agreement_.[DateToExecute],
            V_Agreement_.[MakerAddrID],
            V_Agreement_.[MakerName],
            V_Agreement_.[MakerLogo],
            V_Agreement_.[MakerAddr],
            V_Agreement_.[MakerCityST],
            V_Agreement_.[MakerCountry],
            V_Agreement_.[MakerSignerID],
            V_Agreement_.[MakerSigner],
            V_Agreement_.[MakerSignerTitle],
            V_Agreement_.[MakerSignature],
            V_Agreement_.[OffereeAddrID],
            V_Agreement_.[OffereeName],
            V_Agreement_.[OffereeAddr],
            V_Agreement_.[OffereeCityST],
            V_Agreement_.[OffereeCountry],
            V_Agreement_.[OffereeSignerID],
            V_Agreement_.[OffereeSigner],
            V_Agreement_.[OffereeSignerTitle],
            V_Agreement_.[OffereeSignature],
            V_Agreement_.[FirstItemLabel],
            V_Agreement_.[FirstItem],
            V_Agreement_.[SecondItemLabel],
            V_Agreement_.[SecondItem],
            V_Agreement_.[ThirdItemLabel],
            V_Agreement_.[ThirdItem],
            V_Agreement_.[FourthItemLabel],
            V_Agreement_.[FourthItem],
            V_Agreement_.[FifthItemLabel],
            V_Agreement_.[FifthItem],
            V_Agreement_.[SixthItemLabel],
            V_Agreement_.[SixthItem],
            V_Agreement_.[SeventhItemLabel],
            V_Agreement_.[SeventhItem],
            V_Agreement_.[EightItemLabel],
            V_Agreement_.[EighthItem],
            V_Agreement_.[NinthItemLabel],
            V_Agreement_.[NinthItem],
            V_Agreement_.[TenthItemLabel],
            V_Agreement_.[TenthItem]'
        SET @l_query_from = 
            ' FROM [dbo].[v_Agreement] V_Agreement_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

