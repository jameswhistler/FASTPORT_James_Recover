﻿if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignEmployerGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignEmployerGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[v_SignEmployer]
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
CREATE PROCEDURE pFASTPORTV_SignEmployerGetList
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
    SET @l_from_str = '[dbo].[v_SignEmployer] V_SignEmployer_'

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
            SET @l_sort_str = N'ORDER BY V_SignEmployer_.[VerificationID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Create a table variable to keep row numbering
        SET @l_temp_table = 'DECLARE @IS_TEMP_T_GETLIST TABLE
        (
        IS_ROWNUM_COL int identity(1,1),
                [VerificationID] int
        ); '

        -- Copy column data into table variable
        SET @l_temp_insert = 
            'INSERT INTO @IS_TEMP_T_GETLIST ('
        SET @l_temp_cols = 
            N'[VerificationID]'
        SET @l_temp_select = 
            ') ' + 
            'SELECT ' + 
            'TOP ' + convert(varchar, @l_end_gen_row_num) + ' '
        SET @l_temp_colsWithAlias = 
            N'V_SignEmployer_.[VerificationID]'
        SET @l_temp_from = 
            ' FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + 
            @l_where_str + ' ' + 
            @l_sort_str

        -- Construct the main query
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'V_SignEmployer_.[VerificationID],
            V_SignEmployer_.[HistoryID],
            V_SignEmployer_.[PartyID],
            V_SignEmployer_.[E_Name],
            V_SignEmployer_.[E_DBA],
            V_SignEmployer_.[E_DBAOrName],
            V_SignEmployer_.[E_AddrHTML],
            V_SignEmployer_.[E_Addr],
            V_SignEmployer_.[E_CitySTZip],
            V_SignEmployer_.[E_City],
            V_SignEmployer_.[E_ST],
            V_SignEmployer_.[E_Zip],
            V_SignEmployer_.[E_Country],
            V_SignEmployer_.[E_ContactInfoHTML],
            V_SignEmployer_.[E_EmploymentDates],
            V_SignEmployer_.[E_VerQuestions],
            V_SignEmployer_.[E_TruckingInfoYesNo],
            V_SignEmployer_.[E_TruckingInfoExplain],
            V_SignEmployer_.[E_GeneralComments],
            V_SignEmployer_.[E_Signer],
            V_SignEmployer_.[E_Signature] '
        SET @l_query_from = 
            'FROM ( ' +
                N'SELECT TOP 100 PERCENT IS_ROWNUM_COL, [VerificationID] from @IS_TEMP_T_GETLIST ' +
                'WHERE IS_ROWNUM_COL >= '+ convert(varchar, @l_start_gen_row_num) + 
                ') IS_ALIAS LEFT JOIN ' +
                @l_from_str + ' ';

        SET @l_query_where = 
            N'ON V_SignEmployer_.[VerificationID] = IS_ALIAS.[VerificationID] ' 

        SET @l_final_sort = 'ORDER BY IS_ROWNUM_COL Asc '

        -- Run the query
        EXECUTE (@l_temp_table + @l_temp_insert + @l_temp_cols + @l_temp_select + @l_temp_colsWithAlias + @l_temp_from + '; ' + @l_query_select + @l_query_cols + @l_query_from + @l_query_where + @l_final_sort)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'V_SignEmployer_.[VerificationID],
            V_SignEmployer_.[HistoryID],
            V_SignEmployer_.[PartyID],
            V_SignEmployer_.[E_Name],
            V_SignEmployer_.[E_DBA],
            V_SignEmployer_.[E_DBAOrName],
            V_SignEmployer_.[E_AddrHTML],
            V_SignEmployer_.[E_Addr],
            V_SignEmployer_.[E_CitySTZip],
            V_SignEmployer_.[E_City],
            V_SignEmployer_.[E_ST],
            V_SignEmployer_.[E_Zip],
            V_SignEmployer_.[E_Country],
            V_SignEmployer_.[E_ContactInfoHTML],
            V_SignEmployer_.[E_EmploymentDates],
            V_SignEmployer_.[E_VerQuestions],
            V_SignEmployer_.[E_TruckingInfoYesNo],
            V_SignEmployer_.[E_TruckingInfoExplain],
            V_SignEmployer_.[E_GeneralComments],
            V_SignEmployer_.[E_Signer],
            V_SignEmployer_.[E_Signature]'
        SET @l_query_from = 
            ' FROM [dbo].[v_SignEmployer] V_SignEmployer_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

