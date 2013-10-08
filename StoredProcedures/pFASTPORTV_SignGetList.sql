if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignGetList') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignGetList 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a query resultset from table [dbo].[v_Sign]
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
CREATE PROCEDURE pFASTPORTV_SignGetList
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
    SET @l_from_str = '[dbo].[v_Sign] V_Sign_'

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
            SET @l_sort_str = N'ORDER BY V_Sign_.[ExecutionID] asc '

        -- Calculate the rows to be included in the list
        SET @l_end_gen_row_num = @p_page_number * @p_batch_size;
        SET @l_start_gen_row_num = @l_end_gen_row_num - (@p_batch_size-1);

        -- Construct the main query
        SET @l_query_select = 'WITH V_Sign_ AS ( SELECT  '
        SET @l_query_rownum = 'ROW_NUMBER() OVER(' + @l_sort_str + ') AS IS_ROWNUM_COL,'
        SET @l_query_cols1 = 
            N'V_Sign_.[ExecutionID],
            V_Sign_.[SignedOn],
            V_Sign_.[ExpiresOn],
            V_Sign_.[BarCode],
            V_Sign_.[C_Logo],
            V_Sign_.[C_LogoSmall],
            V_Sign_.[C_Name],
            V_Sign_.[C_DBA],
            V_Sign_.[C_DBAOrName],
            V_Sign_.[C_AddrHTML],
            V_Sign_.[C_Addr],
            V_Sign_.[C_CitySTZip],
            V_Sign_.[C_City],
            V_Sign_.[C_ST],
            V_Sign_.[C_Zip],
            V_Sign_.[C_Country],
            V_Sign_.[C_Signer],
            V_Sign_.[C_SignerTitle],
            V_Sign_.[C_SignerContactInfo],
            V_Sign_.[C_Phone],
            V_Sign_.[C_Mobile],
            V_Sign_.[C_OtherPhone],
            V_Sign_.[C_Fax],
            V_Sign_.[C_Email],
            V_Sign_.[C_Signature],
            V_Sign_.[C_SignatureSmall],
            V_Sign_.[C_Initials],
            V_Sign_.[C_DOT],
            V_Sign_.[C_MC],
            V_Sign_.[C_EIN],
            V_Sign_.[C_EIN1],
            V_Sign_.[C_EIN2],
            V_Sign_.[C_EIN3],
            V_Sign_.[C_EIN4],
            V_Sign_.[C_EIN5],
            V_Sign_.[C_EIN6],
            V_Sign_.[C_EIN7],
            V_Sign_.[C_EIN8],
            V_Sign_.[C_EIN9],
            V_Sign_.[D_ProfilePic],
            V_Sign_.[D_Name],
            V_Sign_.[D_ContactInfo],
            V_Sign_.[D_Phone],
            V_Sign_.[D_Mobile],
            V_Sign_.[D_OtherPhone],
            V_Sign_.[D_Fax],
            V_Sign_.[D_Email],
            V_Sign_.[D_Signature],
            V_Sign_.[D_SignatureSmall],
            V_Sign_.[D_Initials],
            V_Sign_.[D_Overview],
            V_Sign_.[D_Incidents],
            V_Sign_.[D_ExpGeneral],
            V_Sign_.[D_ExpEquipment],
            V_Sign_.[D_ExpCargo],
            V_Sign_.[D_ExpRegions],
            V_Sign_.[D_Gauge],
            V_Sign_.[D_AddrHTML],
            V_Sign_.[D_Addr],
            V_Sign_.[D_CitySTZip],
            V_Sign_.[D_City],
            V_Sign_.[D_ST],
            V_Sign_.[D_Zip],
            V_Sign_.[D_Country],
            V_Sign_.[D_DOB],
            V_Sign_.[D_CDLInfo],
            V_Sign_.[D_CDLShort],
            V_Sign_.[D_CDLOnly],
            V_Sign_.[D_CDLState],
            V_Sign_.[D_USCitizen],
            V_Sign_.[D_PersonalInfo],
            V_Sign_.[D_SSN],
            V_Sign_.[D_SSX4],
            V_Sign_.[D_SS1],
            V_Sign_.[D_SS2],
            V_Sign_.[D_SS3],
            V_Sign_.[D_SS4],
            V_Sign_.[D_SS5],
            V_Sign_.[D_SS6],
            V_Sign_.[D_SS7],
            V_Sign_.[D_SS8],
            V_Sign_.[D_SS9],
            V_Sign_.[D_PRA],
            V_Sign_.[D_PRANumber],
            V_Sign_.[D_Passport],
            V_Sign_.[D_PassportExpiration],
            V_Sign_.[D_TerminalAssigned],
            V_Sign_.[D_I9OtherAlien],
            V_Sign_.[D_I9a],
            V_Sign_.[D_I9b],
            V_Sign_.[D_I9c],
            V_Sign_.[FirstLabel],
            V_Sign_.[FirstValue],
            V_Sign_.[SecondLabel],
            V_Sign_.[SecondValue],
            V_Sign_.[ThirdLabel],
            V_Sign_.[ThirdValue],
            V_Sign_.[FourthLabel],
            V_Sign_.[FourthValue],
            V_Sign_.[FifthLabel],
            V_Sign_.[FifthValue],
            V_Sign_.[SixthLabel],
            V_Sign_.[SixthValue],
            V_Sign_.[SeventhLabel],
            V_Sign_.[SeventhValue],
            V_Sign_.[EighthLabel],
            V_Sign_.[EighthValue],
            V_Sign_.[NinthLabel],
            V_Sign_.[NinthValue],
            V_Sign_.[TenthLabel],
            V_Sign_.[TenthValue],
            V_Sign_.[EleventhLabel],
            V_Sign_.[EleventhValue],
            V_Sign_.[TwelfthLabel],
            V_Sign_.[TwelfthValue],
            V_Sign_.[ThirteenthLabel],
            V_Sign_.[ThirteenthValue], '
        SET @l_query_cols2 = 
            N'            V_Sign_.[FourteenthLabel],
            V_Sign_.[FourteenthValue],
            V_Sign_.[FifteenthLabel],
            V_Sign_.[FifteenthValue],
            V_Sign_.[Cust_Plus1],
            V_Sign_.[Cust_Plus2],
            V_Sign_.[Cust_Plus3],
            V_Sign_.[Cust_Plus4],
            V_Sign_.[Cust_Plus5],
            V_Sign_.[Cust_Plus6],
            V_Sign_.[Cust_HrsTtl] '
        SET @l_query_from = 'FROM ' + @l_from_str + ' ' + @l_join_str + ' ' + @l_where_str + ') '
        SET @l_query_select2 = 'SELECT * FROM V_Sign_ '
        SET @l_query_where = 'WHERE IS_ROWNUM_COL BETWEEN ' + convert(varchar, @l_start_gen_row_num) + ' AND ' + convert(varchar, @l_end_gen_row_num) +  ';'

        -- Run the query
        EXECUTE (@l_query_select + @l_query_rownum + @l_query_cols1 + @l_query_cols2 + @l_query_from + @l_query_select2 + @l_query_where)

    END
    ELSE
    BEGIN
        -- If page number and batch size are not valid numbers return an empty result set
        SET @l_query_select = 'SELECT '
        SET @l_query_cols1 = 
            N'V_Sign_.[ExecutionID],
            V_Sign_.[SignedOn],
            V_Sign_.[ExpiresOn],
            V_Sign_.[BarCode],
            V_Sign_.[C_Logo],
            V_Sign_.[C_LogoSmall],
            V_Sign_.[C_Name],
            V_Sign_.[C_DBA],
            V_Sign_.[C_DBAOrName],
            V_Sign_.[C_AddrHTML],
            V_Sign_.[C_Addr],
            V_Sign_.[C_CitySTZip],
            V_Sign_.[C_City],
            V_Sign_.[C_ST],
            V_Sign_.[C_Zip],
            V_Sign_.[C_Country],
            V_Sign_.[C_Signer],
            V_Sign_.[C_SignerTitle],
            V_Sign_.[C_SignerContactInfo],
            V_Sign_.[C_Phone],
            V_Sign_.[C_Mobile],
            V_Sign_.[C_OtherPhone],
            V_Sign_.[C_Fax],
            V_Sign_.[C_Email],
            V_Sign_.[C_Signature],
            V_Sign_.[C_SignatureSmall],
            V_Sign_.[C_Initials],
            V_Sign_.[C_DOT],
            V_Sign_.[C_MC],
            V_Sign_.[C_EIN],
            V_Sign_.[C_EIN1],
            V_Sign_.[C_EIN2],
            V_Sign_.[C_EIN3],
            V_Sign_.[C_EIN4],
            V_Sign_.[C_EIN5],
            V_Sign_.[C_EIN6],
            V_Sign_.[C_EIN7],
            V_Sign_.[C_EIN8],
            V_Sign_.[C_EIN9],
            V_Sign_.[D_ProfilePic],
            V_Sign_.[D_Name],
            V_Sign_.[D_ContactInfo],
            V_Sign_.[D_Phone],
            V_Sign_.[D_Mobile],
            V_Sign_.[D_OtherPhone],
            V_Sign_.[D_Fax],
            V_Sign_.[D_Email],
            V_Sign_.[D_Signature],
            V_Sign_.[D_SignatureSmall],
            V_Sign_.[D_Initials],
            V_Sign_.[D_Overview],
            V_Sign_.[D_Incidents],
            V_Sign_.[D_ExpGeneral],
            V_Sign_.[D_ExpEquipment],
            V_Sign_.[D_ExpCargo],
            V_Sign_.[D_ExpRegions],
            V_Sign_.[D_Gauge],
            V_Sign_.[D_AddrHTML],
            V_Sign_.[D_Addr],
            V_Sign_.[D_CitySTZip],
            V_Sign_.[D_City],
            V_Sign_.[D_ST],
            V_Sign_.[D_Zip],
            V_Sign_.[D_Country],
            V_Sign_.[D_DOB],
            V_Sign_.[D_CDLInfo],
            V_Sign_.[D_CDLShort],
            V_Sign_.[D_CDLOnly],
            V_Sign_.[D_CDLState],
            V_Sign_.[D_USCitizen],
            V_Sign_.[D_PersonalInfo],
            V_Sign_.[D_SSN],
            V_Sign_.[D_SSX4],
            V_Sign_.[D_SS1],
            V_Sign_.[D_SS2],
            V_Sign_.[D_SS3],
            V_Sign_.[D_SS4],
            V_Sign_.[D_SS5],
            V_Sign_.[D_SS6],
            V_Sign_.[D_SS7],
            V_Sign_.[D_SS8],
            V_Sign_.[D_SS9],
            V_Sign_.[D_PRA],
            V_Sign_.[D_PRANumber],
            V_Sign_.[D_Passport],
            V_Sign_.[D_PassportExpiration],
            V_Sign_.[D_TerminalAssigned],
            V_Sign_.[D_I9OtherAlien],
            V_Sign_.[D_I9a],
            V_Sign_.[D_I9b],
            V_Sign_.[D_I9c],
            V_Sign_.[FirstLabel],
            V_Sign_.[FirstValue],
            V_Sign_.[SecondLabel],
            V_Sign_.[SecondValue],
            V_Sign_.[ThirdLabel],
            V_Sign_.[ThirdValue],
            V_Sign_.[FourthLabel],
            V_Sign_.[FourthValue],
            V_Sign_.[FifthLabel],
            V_Sign_.[FifthValue],
            V_Sign_.[SixthLabel],
            V_Sign_.[SixthValue],
            V_Sign_.[SeventhLabel],
            V_Sign_.[SeventhValue],
            V_Sign_.[EighthLabel],
            V_Sign_.[EighthValue],
            V_Sign_.[NinthLabel],
            V_Sign_.[NinthValue],
            V_Sign_.[TenthLabel],
            V_Sign_.[TenthValue],
            V_Sign_.[EleventhLabel],
            V_Sign_.[EleventhValue],
            V_Sign_.[TwelfthLabel],
            V_Sign_.[TwelfthValue],
            V_Sign_.[ThirteenthLabel],
            V_Sign_.[ThirteenthValue],'
        SET @l_query_cols2 = 
            N'            V_Sign_.[FourteenthLabel],
            V_Sign_.[FourteenthValue],
            V_Sign_.[FifteenthLabel],
            V_Sign_.[FifteenthValue],
            V_Sign_.[Cust_Plus1],
            V_Sign_.[Cust_Plus2],
            V_Sign_.[Cust_Plus3],
            V_Sign_.[Cust_Plus4],
            V_Sign_.[Cust_Plus5],
            V_Sign_.[Cust_Plus6],
            V_Sign_.[Cust_HrsTtl]'
        SET @l_query_from = 
            ' FROM [dbo].[v_Sign] V_Sign_ ' + 
            'WHERE 1=2;'
        EXECUTE (@l_query_select + @l_query_cols1 + @l_query_cols2 + @l_query_from);
    END

    SET NOCOUNT OFF

END

