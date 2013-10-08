if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyWorkHistoryVerificationExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyWorkHistoryVerificationExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPartyWorkHistoryVerificationExport
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
                N'"VerificationID"' + @p_separator_str +
                N'"HistoryID"' + @p_separator_str +
                N'"""HistoryID"" Notes"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"""FlowStepID"" RefName"' + @p_separator_str +
                N'"RequestedByID"' + @p_separator_str +
                N'"""RequestedByID"" Name"' + @p_separator_str +
                N'"RequestedAt"' + @p_separator_str +
                N'"RequestAttempts"' + @p_separator_str +
                N'"RequestIntervalID"' + @p_separator_str +
                N'"""RequestIntervalID"" ItemName"' + @p_separator_str +
                N'"DatesYesNo"' + @p_separator_str +
                N'"DatesExplain"' + @p_separator_str +
                N'"MotorVehicleYesNo"' + @p_separator_str +
                N'"FailedTestYesNo"' + @p_separator_str +
                N'"FailedTestExplain"' + @p_separator_str +
                N'"RefusedTestYesNo"' + @p_separator_str +
                N'"RefusedTestExplain"' + @p_separator_str +
                N'"ConductYesNo"' + @p_separator_str +
                N'"ConductExplain"' + @p_separator_str +
                N'"TruckingInfoYesNo"' + @p_separator_str +
                N'"TruckingInfoComments"' + @p_separator_str +
                N'"GeneralComments"' + @p_separator_str +
                N'"SignerID"' + @p_separator_str +
                N'"""SignerID"" Name"' + @p_separator_str +
                N'"SignerFreeHand"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[VerificationID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[HistoryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Notes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[RequestedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[RequestedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[RequestAttempts]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[RequestIntervalID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[DatesYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[DatesExplain], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[MotorVehicleYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[FailedTestYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[FailedTestExplain], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[RefusedTestYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[RefusedTestExplain], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[ConductYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[ConductExplain], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[TruckingInfoYesNo]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[TruckingInfoComments], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[GeneralComments], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[SignerID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyWorkHistoryVerification_.[SignerFreeHand], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyWorkHistoryVerification_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[PartyWorkHistoryVerification] PartyWorkHistoryVerification_ LEFT OUTER JOIN [dbo].[PartyWorkHistory] t0 ON (PartyWorkHistoryVerification_.[HistoryID] =  t0.[HistoryID]) LEFT OUTER JOIN [dbo].[FlowStep] t1 ON (PartyWorkHistoryVerification_.[FlowStepID] =  t1.[FlowStepID]) LEFT OUTER JOIN [dbo].[Party] t2 ON (PartyWorkHistoryVerification_.[RequestedByID] =  t2.[PartyID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (PartyWorkHistoryVerification_.[RequestIntervalID] =  t3.[TreeID]) LEFT OUTER JOIN [dbo].[Party] t4 ON (PartyWorkHistoryVerification_.[SignerID] =  t4.[PartyID])';

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

