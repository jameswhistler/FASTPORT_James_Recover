if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExport') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTAgreementExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(4000),
        @p_select_str nvarchar(4000),
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str1 nvarchar(4000),
        @l_title_str2 nvarchar(4000),
        @l_select_str1 nvarchar(4000),
        @l_select_str2 nvarchar(4000),
        @l_select_str3 nvarchar(4000),
        @l_select_str4 nvarchar(4000),
        @l_select_str5 nvarchar(4000),
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
        SET @l_title_str1 = @p_title_str + char(13)
        SET @l_title_str2 = ''
        IF @p_title_str IS NULL
            BEGIN
            SET @l_title_str1 = 
                N'"AgreementID"' + @p_separator_str +
                N'"CIX"' + @p_separator_str +
                N'"DocTreeParentID"' + @p_separator_str +
                N'"""DocTreeParentID"" DocName"' + @p_separator_str +
                N'"RoleID"' + @p_separator_str +
                N'"""RoleID"" Role"' + @p_separator_str +
                N'"CustomID"' + @p_separator_str +
                N'"""CustomID"" Agreement"' + @p_separator_str +
                N'"DocIndex"' + @p_separator_str +
                N'"DocSort"' + @p_separator_str +
                N'"Agreement"' + @p_separator_str +
                N'"Description"' + @p_separator_str +
                N'"RequiredDoc"' + @p_separator_str +
                N'"DocRank"' + @p_separator_str +
                N'"Hide"' + @p_separator_str +
                N'"AgreementFileName"' + @p_separator_str +
                N'"FlowCollectionID"' + @p_separator_str +
                N'"""FlowCollectionID"" CollectionName"' + @p_separator_str +
                N'"UseStoredSignature"' + @p_separator_str +
                N'"ShowSignatureDate"' + @p_separator_str +
                N'"ShowExpirationDate"' + @p_separator_str +
                N'"InitialsInDocument"' + @p_separator_str +
                N'"DocHasCustomFields"' + @p_separator_str +
                N'"ExecuteFromBoard"' + @p_separator_str +
                N'"SenderInstructions"' + @p_separator_str +
                N'"RecipientInstructions"' + @p_separator_str +
                N'"OtherInstructions"' + @p_separator_str +
                N'"FirstItem"' + @p_separator_str +
                N'"FirstTypeID"' + @p_separator_str +
                N'"""FirstTypeID"" ListName"' + @p_separator_str +
                N'"FirstDefault"' + @p_separator_str +
                N'"FirstByCIX"' + @p_separator_str +
                N'"FirstByOIX"' + @p_separator_str +
                N'"SecondItem"' + @p_separator_str +
                N'"SecondTypeID"' + @p_separator_str +
                N'"""SecondTypeID"" ListName"' + @p_separator_str +
                N'"SecondDefault"' + @p_separator_str +
                N'"SecondByCIX"' + @p_separator_str +
                N'"SecondByOIX"' + @p_separator_str +
                N'"ThirdItem"' + @p_separator_str +
                N'"ThirdTypeID"' + @p_separator_str +
                N'"""ThirdTypeID"" ListName"' + @p_separator_str +
                N'"ThirdDefault"' + @p_separator_str +
                N'"ThirdByCIX"' + @p_separator_str +
                N'"ThirdByOIX"' + @p_separator_str +
                N'"FourthItem"' + @p_separator_str +
                N'"FourthTypeID"' + @p_separator_str +
                N'"""FourthTypeID"" ListName"' + @p_separator_str +
                N'"FourthDefault"' + @p_separator_str +
                N'"FourthByCIX"' + @p_separator_str +
                N'"FourthByOIX"' + @p_separator_str +
                N'"FifthItem"' + @p_separator_str +
                N'"FifthTypeID"' + @p_separator_str +
                N'"""FifthTypeID"" ListName"' + @p_separator_str +
                N'"FifthDefault"' + @p_separator_str +
                N'"FifthByCIX"' + @p_separator_str +
                N'"FifthByOIX"' + @p_separator_str +
                N'"SixthItem"' + @p_separator_str +
                N'"SixthTypeID"' + @p_separator_str +
                N'"""SixthTypeID"" ListName"' + @p_separator_str +
                N'"SixthDefault"' + @p_separator_str +
                N'"SixthByCIX"' + @p_separator_str +
                N'"SixthByOIX"' + @p_separator_str +
                N'"SeventhItem"' + @p_separator_str +
                N'"SeventhTypeID"' + @p_separator_str +
                N'"""SeventhTypeID"" ListName"' + @p_separator_str +
                N'"SeventhDefault"' + @p_separator_str +
                N'"SeventhByCIX"' + @p_separator_str +
                N'"SeventhByOIX"' + @p_separator_str 
            SET @l_title_str2 = 
                N'"EighthItem"' + @p_separator_str +
                N'"EighthTypeID"' + @p_separator_str +
                N'"""EighthTypeID"" ListName"' + @p_separator_str +
                N'"EighthDefault"' + @p_separator_str +
                N'"EighthByCIX"' + @p_separator_str +
                N'"EighthByOIX"' + @p_separator_str +
                N'"NinthItem"' + @p_separator_str +
                N'"NinthTypeID"' + @p_separator_str +
                N'"""NinthTypeID"" ListName"' + @p_separator_str +
                N'"NinthDefault"' + @p_separator_str +
                N'"NinthByCIX"' + @p_separator_str +
                N'"NinthByOIX"' + @p_separator_str +
                N'"TenthItem"' + @p_separator_str +
                N'"TenthTypeID"' + @p_separator_str +
                N'"""TenthTypeID"" ListName"' + @p_separator_str +
                N'"TenthDefault"' + @p_separator_str +
                N'"TenthByCIX"' + @p_separator_str +
                N'"TenthByOIX"' + @p_separator_str +
                N'"EleventhItem"' + @p_separator_str +
                N'"EleventhTypeID"' + @p_separator_str +
                N'"""EleventhTypeID"" ListName"' + @p_separator_str +
                N'"EleventhDefault"' + @p_separator_str +
                N'"EleventhByCIX"' + @p_separator_str +
                N'"EleventhByOIX"' + @p_separator_str +
                N'"TwelfthItem"' + @p_separator_str +
                N'"TwelfthTypeID"' + @p_separator_str +
                N'"""TwelfthTypeID"" ListName"' + @p_separator_str +
                N'"TwelfthDefault"' + @p_separator_str +
                N'"TwelfthByCIX"' + @p_separator_str +
                N'"TwelfthByOIX"' + @p_separator_str +
                N'"ThirteenthItem"' + @p_separator_str +
                N'"ThirteenthTypeID"' + @p_separator_str +
                N'"""ThirteenthTypeID"" ListName"' + @p_separator_str +
                N'"ThirteenthDefault"' + @p_separator_str +
                N'"ThirteenthByCIX"' + @p_separator_str +
                N'"ThirteenthByOIX"' + @p_separator_str +
                N'"FourteenthItem"' + @p_separator_str +
                N'"FourteenthTypeID"' + @p_separator_str +
                N'"""FourteenthTypeID"" ListName"' + @p_separator_str +
                N'"FourteenthDefault"' + @p_separator_str +
                N'"FourteenthByCIX"' + @p_separator_str +
                N'"FourteenthByOIX"' + @p_separator_str +
                N'"FifteenthItem"' + @p_separator_str +
                N'"FifteenthTypeID"' + @p_separator_str +
                N'"""FifteenthTypeID"" ListName"' + @p_separator_str +
                N'"FifteenthDefault"' + @p_separator_str +
                N'"FifteenthByCIX"' + @p_separator_str +
                N'"FifteenthByOIX"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + ' ';
            END
        ELSE IF SUBSTRING(@l_title_str1, 1, 2) = 'ID'
            SET @l_title_str1 = 
                '"' + 
                SUBSTRING(@l_title_str1, 1, PATINDEX('%,%', @l_title_str1)-1) + 
                '"' + 
                SUBSTRING(@l_title_str1, PATINDEX('%,%', @l_title_str1), LEN(@l_title_str1)); 

        -- Set up the select string
        SET @l_select_str1 = @p_select_str
        SET @l_select_str2 = @p_select_str
        SET @l_select_str3 = @p_select_str
        SET @l_select_str4 = @p_select_str
        SET @l_select_str5 = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, Agreement_.[AgreementID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[CIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[DocTreeParentID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[DocName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[RoleID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[Role], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[CustomID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[Agreement], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[DocIndex], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[DocSort], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[Agreement], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[Description], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[RequiredDoc]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[DocRank]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[Hide]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[AgreementFileName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FlowCollectionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[CollectionName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[UseStoredSignature]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ShowSignatureDate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ShowExpirationDate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[InitialsInDocument]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[DocHasCustomFields]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ExecuteFromBoard]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SenderInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[RecipientInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[OtherInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FirstItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FirstTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FirstDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FirstByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FirstByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SecondItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[SecondTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SecondDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SecondByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SecondByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[ThirdItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[ThirdTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t6.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[ThirdDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ThirdByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ThirdByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FourthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FourthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t7.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FourthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FourthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FourthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FifthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FifthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t8.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FifthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FifthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FifthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SixthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[SixthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t9.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str3 = 
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SixthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SixthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SixthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SeventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[SeventhTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t10.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[SeventhDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SeventhByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[SeventhByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[EighthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[EighthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t11.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[EighthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[EighthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[EighthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[NinthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[NinthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t12.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[NinthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[NinthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[NinthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[TenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[TenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t13.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[TenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[TenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[TenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[EleventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[EleventhTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t14.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str4 = 
                N'N''"'' + REPLACE(IsNULL(Agreement_.[EleventhDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[EleventhByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[EleventhByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[TwelfthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[TwelfthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t15.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[TwelfthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[TwelfthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[TwelfthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[ThirteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[ThirteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t16.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[ThirteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ThirteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[ThirteenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FourteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FourteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t17.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FourteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FourteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FourteenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FifteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[FifteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t18.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Agreement_.[FifteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FifteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Agreement_.[FifteenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Agreement_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str5 = 
                N'IsNULL(Convert(nvarchar, Agreement_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[Agreement] Agreement_ LEFT OUTER JOIN [dbo].[DocTree] t0 ON (Agreement_.[DocTreeParentID] =  t0.[DocTreeID]) LEFT OUTER JOIN [dbo].[Role] t1 ON (Agreement_.[RoleID] =  t1.[RoleID]) LEFT OUTER JOIN [dbo].[Agreement] t2 ON (Agreement_.[CustomID] =  t2.[AgreementID]) LEFT OUTER JOIN [dbo].[FlowCollection] t3 ON (Agreement_.[FlowCollectionID] =  t3.[FlowCollectionID]) LEFT OUTER JOIN [dbo].[List] t4 ON (Agreement_.[FirstTypeID] =  t4.[ListID]) LEFT OUTER JOIN [dbo].[List] t5 ON (Agreement_.[SecondTypeID] =  t5.[ListID]) LEFT OUTER JOIN [dbo].[List] t6 ON (Agreement_.[ThirdTypeID] =  t6.[ListID]) LEFT OUTER JOIN [dbo].[List] t7 ON (Agreement_.[FourthTypeID] =  t7.[ListID]) LEFT OUTER JOIN [dbo].[List] t8 ON (Agreement_.[FifthTypeID] =  t8.[ListID]) LEFT OUTER JOIN [dbo].[List] t9 ON (Agreement_.[SixthTypeID] =  t9.[ListID]) LEFT OUTER JOIN [dbo].[List] t10 ON (Agreement_.[SeventhTypeID] =  t10.[ListID]) LEFT OUTER JOIN [dbo].[List] t11 ON (Agreement_.[EighthTypeID] =  t11.[ListID]) LEFT OUTER JOIN [dbo].[List] t12 ON (Agreement_.[NinthTypeID] =  t12.[ListID]) LEFT OUTER JOIN [dbo].[List] t13 ON (Agreement_.[TenthTypeID] =  t13.[ListID]) LEFT OUTER JOIN [dbo].[List] t14 ON (Agreement_.[EleventhTypeID] =  t14.[ListID]) LEFT OUTER JOIN [dbo].[List] t15 ON (Agreement_.[TwelfthTypeID] =  t15.[ListID]) LEFT OUTER JOIN [dbo].[List] t16 ON (Agreement_.[ThirteenthTypeID] =  t16.[ListID]) LEFT OUTER JOIN [dbo].[List] t17 ON (Agreement_.[FourteenthTypeID] =  t17.[ListID]) LEFT OUTER JOIN [dbo].[List] t18 ON (Agreement_.[FifteenthTypeID] =  t18.[ListID])';

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
        EXECUTE (@l_query_select + @l_title_str1 + @l_title_str2 + @l_query_union + @l_select_str1 + @l_select_str2 + @l_select_str3 + @l_select_str4 + @l_select_str5+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

