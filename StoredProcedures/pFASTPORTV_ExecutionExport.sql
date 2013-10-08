if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_ExecutionExport') and sysstat & 0xf = 4) drop procedure pFASTPORTV_ExecutionExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTV_ExecutionExport
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
                N'"ExecutionID"' + @p_separator_str +
                N'"CIX"' + @p_separator_str +
                N'"OIX"' + @p_separator_str +
                N'"AgreementID"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"SenderAddrID"' + @p_separator_str +
                N'"SenderSignerID"' + @p_separator_str +
                N'"RecipientAddrID"' + @p_separator_str +
                N'"RecipientSignerID"' + @p_separator_str +
                N'"SignedOn"' + @p_separator_str +
                N'"ExpiresOn"' + @p_separator_str +
                N'"AddSignaturePage"' + @p_separator_str +
                N'"FirstItem"' + @p_separator_str +
                N'"SecondItem"' + @p_separator_str +
                N'"ThirdItem"' + @p_separator_str +
                N'"FourthItem"' + @p_separator_str +
                N'"FifthItem"' + @p_separator_str +
                N'"SixthItem"' + @p_separator_str +
                N'"SeventhItem"' + @p_separator_str +
                N'"EighthItem"' + @p_separator_str +
                N'"NinthItem"' + @p_separator_str +
                N'"TenthItem"' + @p_separator_str +
                N'"EleventhItem"' + @p_separator_str +
                N'"TwelfthItem"' + @p_separator_str +
                N'"ThirteenthItem"' + @p_separator_str +
                N'"FourteenthItem"' + @p_separator_str +
                N'"FifteenthItem"' + @p_separator_str +
                N'"ShowSignatureDate"' + @p_separator_str +
                N'"ShowExpirationDate"' + @p_separator_str +
                N'"ExecuteFromBoard"' + @p_separator_str +
                N'"OtherInstructions"' + @p_separator_str +
                N'"SenderInstructions"' + @p_separator_str +
                N'"RecipientInstructions"' + @p_separator_str +
                N'"FirstItemName"' + @p_separator_str +
                N'"FirstTypeID"' + @p_separator_str +
                N'"FirstDefault"' + @p_separator_str +
                N'"FirstByCIX"' + @p_separator_str +
                N'"FirstByOIX"' + @p_separator_str +
                N'"SecondItemName"' + @p_separator_str +
                N'"SecondTypeID"' + @p_separator_str +
                N'"SecondDefault"' + @p_separator_str +
                N'"SecondByCIX"' + @p_separator_str +
                N'"SecondByOIX"' + @p_separator_str +
                N'"ThirdItemName"' + @p_separator_str +
                N'"ThirdTypeID"' + @p_separator_str +
                N'"ThirdDefault"' + @p_separator_str +
                N'"ThirdByCIX"' + @p_separator_str +
                N'"ThirdByOIX"' + @p_separator_str +
                N'"FourthItemName"' + @p_separator_str +
                N'"FourthTypeID"' + @p_separator_str +
                N'"FourthDefault"' + @p_separator_str +
                N'"FourthByCIX"' + @p_separator_str +
                N'"FourthByOIX"' + @p_separator_str +
                N'"FifthItemName"' + @p_separator_str +
                N'"FifthTypeID"' + @p_separator_str +
                N'"FifthDefault"' + @p_separator_str +
                N'"FifthByCIX"' + @p_separator_str +
                N'"FifthByOIX"' + @p_separator_str +
                N'"SixthItemName"' + @p_separator_str +
                N'"SixthTypeID"' + @p_separator_str +
                N'"SixthDefault"' + @p_separator_str +
                N'"SixthByCIX"' + @p_separator_str +
                N'"SixthByOIX"' + @p_separator_str +
                N'"SeventhItemName"' + @p_separator_str +
                N'"SeventhTypeID"' + @p_separator_str +
                N'"SeventhDefault"' + @p_separator_str +
                N'"SeventhByCIX"' + @p_separator_str +
                N'"SeventhByOIX"' + @p_separator_str +
                N'"EighthItemName"' + @p_separator_str +
                N'"EighthTypeID"' + @p_separator_str +
                N'"EighthDefault"' + @p_separator_str 
            SET @l_title_str2 = 
                N'"EighthByCIX"' + @p_separator_str +
                N'"EighthByOIX"' + @p_separator_str +
                N'"NinthItemName"' + @p_separator_str +
                N'"NinthTypeID"' + @p_separator_str +
                N'"NinthDefault"' + @p_separator_str +
                N'"NinthByCIX"' + @p_separator_str +
                N'"NinthByOIX"' + @p_separator_str +
                N'"TenthItemName"' + @p_separator_str +
                N'"TenthTypeID"' + @p_separator_str +
                N'"TenthDefault"' + @p_separator_str +
                N'"TenthByCIX"' + @p_separator_str +
                N'"TenthByOIX"' + @p_separator_str +
                N'"EleventhItemName"' + @p_separator_str +
                N'"EleventhTypeID"' + @p_separator_str +
                N'"EleventhDefault"' + @p_separator_str +
                N'"EleventhByCIX"' + @p_separator_str +
                N'"EleventhByOIX"' + @p_separator_str +
                N'"TwelfthItemName"' + @p_separator_str +
                N'"TwelfthTypeID"' + @p_separator_str +
                N'"TwelfthDefault"' + @p_separator_str +
                N'"TwelfthByCIX"' + @p_separator_str +
                N'"TwelfthByOIX"' + @p_separator_str +
                N'"ThirteenthItemName"' + @p_separator_str +
                N'"ThirteenthTypeID"' + @p_separator_str +
                N'"ThirteenthDefault"' + @p_separator_str +
                N'"ThirteenthByCIX"' + @p_separator_str +
                N'"ThirteenthByOIX"' + @p_separator_str +
                N'"FourteenthItemName"' + @p_separator_str +
                N'"FourteenthTypeID"' + @p_separator_str +
                N'"FourteenthDefault"' + @p_separator_str +
                N'"FourteenthByCIX"' + @p_separator_str +
                N'"FourteenthByOIX"' + @p_separator_str +
                N'"FifteenthItemName"' + @p_separator_str +
                N'"FifteenthTypeID"' + @p_separator_str +
                N'"FifteenthDefault"' + @p_separator_str +
                N'"FifteenthByCIX"' + @p_separator_str +
                N'"FifteenthByOIX"' + ' ';
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
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str1 = 
                N'IsNULL(Convert(nvarchar, V_Execution_.[ExecutionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[CIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[OIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[AgreementID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[SenderAddrID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[SenderSignerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[RecipientAddrID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[RecipientSignerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[SignedOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[ExpiresOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[AddSignaturePage]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FirstItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SecondItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirdItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SixthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SeventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EighthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[NinthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EleventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TwelfthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ShowSignatureDate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ShowExpirationDate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ExecuteFromBoard]), '''') + N''"'' + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[OtherInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SenderInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[RecipientInstructions], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FirstItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FirstTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FirstDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FirstByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FirstByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SecondItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[SecondTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SecondDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SecondByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SecondByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirdItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[ThirdTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirdDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ThirdByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ThirdByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FourthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FourthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FourthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FifthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FifthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FifthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SixthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str3 = 
                N'IsNULL(Convert(nvarchar, V_Execution_.[SixthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SixthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SixthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SixthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SeventhItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[SeventhTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[SeventhDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SeventhByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[SeventhByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EighthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[EighthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EighthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[EighthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[EighthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[NinthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[NinthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[NinthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[NinthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[NinthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TenthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[TenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[TenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[TenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EleventhItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[EleventhTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[EleventhDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[EleventhByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[EleventhByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' 
            SET @l_select_str4 = 
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TwelfthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[TwelfthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[TwelfthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[TwelfthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[TwelfthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirteenthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[ThirteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[ThirteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ThirteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[ThirteenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourteenthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FourteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FourteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FourteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FourteenthByOIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifteenthItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, V_Execution_.[FifteenthTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(V_Execution_.[FifteenthDefault], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FifteenthByCIX]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, V_Execution_.[FifteenthByOIX]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[v_Execution] V_Execution_';

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
        EXECUTE (@l_query_select + @l_title_str1 + @l_title_str2 + @l_query_union + @l_select_str1 + @l_select_str2 + @l_select_str3 + @l_select_str4+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

