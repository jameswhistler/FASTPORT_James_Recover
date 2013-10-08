if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocExport') and sysstat & 0xf = 4) drop procedure pFASTPORTDocExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTDocExport
        @p_separator_str nvarchar(15),
        @p_title_str nvarchar(4000),
        @p_select_str nvarchar(4000),
        @p_join_str nvarchar(4000),
        @p_where_str nvarchar(4000),
        @p_num_exported int output
    AS
    DECLARE
        @l_title_str nvarchar(4000),
        @l_select_str nvarchar(4000),
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
                N'"DocID"' + @p_separator_str +
                N'"CIX"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"FiledAsID"' + @p_separator_str +
                N'"""FiledAsID"" DocName"' + @p_separator_str +
                N'"AgreementID"' + @p_separator_str +
                N'"""AgreementID"" Agreement"' + @p_separator_str +
                N'"DocName"' + @p_separator_str +
                N'"DocNumber"' + @p_separator_str +
                N'"DocIssued"' + @p_separator_str +
                N'"DocIssuingStateID"' + @p_separator_str +
                N'"DocExpiration"' + @p_separator_str +
                N'"Reissued"' + @p_separator_str +
                N'"DocEndorsements"' + @p_separator_str +
                N'"DocNotes"' + @p_separator_str +
                N'"FinishedRecordingDetails"' + @p_separator_str +
                N'"PrivateFile"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"""FlowStepID"" RefName"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
                N'"ExecutionID"' + @p_separator_str +
                N'"""ExecutionID"" SenderSignedFrom"' + @p_separator_str +
                N'"AttachmentID"' + @p_separator_str +
                N'"""AttachmentID"" FileName"' + @p_separator_str +
                N'"EquipID"' + @p_separator_str +
                N'"""EquipID"" Make"' + @p_separator_str +
                N'"ProcessedPages"' + @p_separator_str +
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
        SET @l_select_str = @p_select_str
        IF @p_select_str IS NULL
            BEGIN
            SET @l_select_str = 
                N'IsNULL(Convert(nvarchar, Doc_.[DocID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[CIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[FiledAsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[DocName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[AgreementID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[Agreement], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Doc_.[DocName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Doc_.[DocNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[DocIssued], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[DocIssuingStateID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[DocExpiration], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Doc_.[Reissued]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Doc_.[DocEndorsements], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Doc_.[DocNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Doc_.[FinishedRecordingDetails]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Doc_.[PrivateFile]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[ExecutionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[SenderSignedFrom], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[AttachmentID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[FileName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[EquipID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t6.[Make], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Doc_.[ProcessedPages]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Doc_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[Doc] Doc_ LEFT OUTER JOIN [dbo].[Party] t0 ON (Doc_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[DocTree] t1 ON (Doc_.[FiledAsID] =  t1.[DocTreeID]) LEFT OUTER JOIN [dbo].[Agreement] t2 ON (Doc_.[AgreementID] =  t2.[AgreementID]) LEFT OUTER JOIN [dbo].[FlowStep] t3 ON (Doc_.[FlowStepID] =  t3.[FlowStepID]) LEFT OUTER JOIN [dbo].[AgreementExecution] t4 ON (Doc_.[ExecutionID] =  t4.[ExecutionID]) LEFT OUTER JOIN [dbo].[ThreadInstanceMessageAttachments] t5 ON (Doc_.[AttachmentID] =  t5.[AttachmentID]) LEFT OUTER JOIN [dbo].[Equip] t6 ON (Doc_.[EquipID] =  t6.[EquipID])';

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
        EXECUTE (@l_query_select + @l_title_str + @l_query_union + @l_select_str+ @l_query_from)

        -- Return the total number of rows of the query
        SELECT @p_num_exported = @@rowcount
    END

