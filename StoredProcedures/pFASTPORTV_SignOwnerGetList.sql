if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignOwnerGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignOwnerGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[v_SignOwner]
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
CREATE PROCEDURE pFASTPORTV_SignOwnerGetList
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
    @l_query_select2 nvarchar(4000),
    @l_query_rownum nvarchar(4000),
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
    SET @l_from_str = '[dbo].[v_SignOwner] V_SignOwner_'

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
            SET @l_sort_str = N'ORDER BY V_SignOwner_.[PartyID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Construct the main query
        SET @l_query_select = 'WITH V_SignOwner_ AS ( SELECT  '
        SET @l_query_rownum = 'ROW_NUMBER() OVER(' + @l_sort_str + ') AS IS_ROWNUM_COL,'
        SET @l_query_cols = 
            N'V_SignOwner_.[PartyID],
            V_SignOwner_.[O_Name],
            V_SignOwner_.[O_DBA],
            V_SignOwner_.[O_DBAOrName],
            V_SignOwner_.[O_AddrHTML],
            V_SignOwner_.[O_Addr],
            V_SignOwner_.[O_CitySTZip],
            V_SignOwner_.[O_City],
            V_SignOwner_.[O_ST],
            V_SignOwner_.[O_Zip],
            V_SignOwner_.[O_Country],
            V_SignOwner_.[O_SSNorEIN],
            V_SignOwner_.[O_SSN],
            V_SignOwner_.[O_EIN],
            V_SignOwner_.[O_Entity],
            V_SignOwner_.[O_EntitySole],
            V_SignOwner_.[O_EntityCCorp],
            V_SignOwner_.[O_EntitySCorp],
            V_SignOwner_.[O_EntityPartner],
            V_SignOwner_.[O_EntityTrustEstate],
            V_SignOwner_.[O_EntityLLC],
            V_SignOwner_.[O_EntityOther] '
        SET @l_query_from = 'FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + @l_where_str + ') '
        SET @l_query_select2 = 'SELECT * FROM V_SignOwner_ '
        SET @l_query_where = 'WHERE IS_ROWNUM_COL BETWEEN ' + convert(varchar, @l_start_gen_row_num) + ' AND ' + convert(varchar, @l_end_gen_row_num) +  ';'

        -- Run the query
        EXECUTE (@l_query_select + @l_query_rownum + @l_query_cols + @l_query_from + @l_query_select2 + @l_query_where)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols = 
            N'V_SignOwner_.[PartyID],
            V_SignOwner_.[O_Name],
            V_SignOwner_.[O_DBA],
            V_SignOwner_.[O_DBAOrName],
            V_SignOwner_.[O_AddrHTML],
            V_SignOwner_.[O_Addr],
            V_SignOwner_.[O_CitySTZip],
            V_SignOwner_.[O_City],
            V_SignOwner_.[O_ST],
            V_SignOwner_.[O_Zip],
            V_SignOwner_.[O_Country],
            V_SignOwner_.[O_SSNorEIN],
            V_SignOwner_.[O_SSN],
            V_SignOwner_.[O_EIN],
            V_SignOwner_.[O_Entity],
            V_SignOwner_.[O_EntitySole],
            V_SignOwner_.[O_EntityCCorp],
            V_SignOwner_.[O_EntitySCorp],
            V_SignOwner_.[O_EntityPartner],
            V_SignOwner_.[O_EntityTrustEstate],
            V_SignOwner_.[O_EntityLLC],
            V_SignOwner_.[O_EntityOther]'
        SET @l_query_from = 
            ' FROM [dbo].[v_SignOwner] V_SignOwner_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols + @l_query_from);
    END

    SET NOCOUNT OFF

END

