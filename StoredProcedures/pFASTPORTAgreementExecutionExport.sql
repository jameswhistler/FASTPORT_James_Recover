if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExecutionExport') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExecutionExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTAgreementExecutionExport
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
                N'"ExecutionID"' + @p_separator_str +
                N'"CIX"' + @p_separator_str +
                N'"OIX"' + @p_separator_str +
                N'"AgreementID"' + @p_separator_str +
                N'"""AgreementID"" Agreement"' + @p_separator_str +
                N'"SenderAddrID"' + @p_separator_str +
                N'"""SenderAddrID"" AddrName"' + @p_separator_str +
                N'"SenderSignerID"' + @p_separator_str +
                N'"""SenderSignerID"" Name"' + @p_separator_str +
                N'"RecipientAddrID"' + @p_separator_str +
                N'"""RecipientAddrID"" AddrName"' + @p_separator_str +
                N'"RecipientSignerID"' + @p_separator_str +
                N'"""RecipientSignerID"" Name"' + @p_separator_str +
                N'"SignedOn"' + @p_separator_str +
                N'"ExpiresOn"' + @p_separator_str +
                N'"UseOutsideTemplate"' + @p_separator_str +
                N'"UseOutsidePdf"' + @p_separator_str +
                N'"SenderSignedAt"' + @p_separator_str +
                N'"SenderSignedFrom"' + @p_separator_str +
                N'"RecipientSignedAt"' + @p_separator_str +
                N'"RecipientSignedFrom"' + @p_separator_str +
                N'"AddSignaturePage"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"""FlowStepID"" RefName"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
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
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + ' ';
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
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[ExecutionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[CIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[OIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[AgreementID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[Agreement], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[SenderAddrID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[AddrName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[SenderSignerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[RecipientAddrID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[AddrName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[RecipientSignerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[SignedOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[ExpiresOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, AgreementExecution_.[UseOutsideTemplate]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, AgreementExecution_.[UseOutsidePdf]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[SenderSignedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[SenderSignedFrom], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[RecipientSignedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[RecipientSignedFrom], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, AgreementExecution_.[AddSignaturePage]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t6.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[FirstItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[SecondItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[ThirdItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[FourthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[FifthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[SixthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[SeventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[EighthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[NinthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[TenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[EleventhItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[TwelfthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[ThirteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[FourteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(AgreementExecution_.[FifteenthItem], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, AgreementExecution_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[AgreementExecution] AgreementExecution_ LEFT OUTER JOIN [dbo].[Agreement] t1 ON (AgreementExecution_.[AgreementID] =  t1.[AgreementID]) LEFT OUTER JOIN [dbo].[PartyAddr] t2 ON (AgreementExecution_.[SenderAddrID] =  t2.[AddrID]) LEFT OUTER JOIN [dbo].[Party] t3 ON (AgreementExecution_.[SenderSignerID] =  t3.[PartyID]) LEFT OUTER JOIN [dbo].[PartyAddr] t4 ON (AgreementExecution_.[RecipientAddrID] =  t4.[AddrID]) LEFT OUTER JOIN [dbo].[Party] t5 ON (AgreementExecution_.[RecipientSignerID] =  t5.[PartyID]) LEFT OUTER JOIN [dbo].[FlowStep] t6 ON (AgreementExecution_.[FlowStepID] =  t6.[FlowStepID])';

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

