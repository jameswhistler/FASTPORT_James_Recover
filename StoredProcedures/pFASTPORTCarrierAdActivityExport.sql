if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdActivityExport') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdActivityExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTCarrierAdActivityExport
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
                N'"AdActivityID"' + @p_separator_str +
                N'"AdID"' + @p_separator_str +
                N'"""AdID"" AdName"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"CarrierID"' + @p_separator_str +
                N'"""CarrierID"" DOTNumber"' + @p_separator_str +
                N'"FavoriteAd"' + @p_separator_str +
                N'"FileAd"' + @p_separator_str +
                N'"Viewed"' + @p_separator_str +
                N'"FlowStepID"' + @p_separator_str +
                N'"""FlowStepID"" RefName"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
                N'"ExecutionID"' + @p_separator_str +
                N'"""ExecutionID"" SenderSignedFrom"' + @p_separator_str +
                N'"LinkID"' + @p_separator_str +
                N'"""LinkID"" LinkName"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + ' ';
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
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[AdActivityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[AdID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[AdName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[CarrierID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[DOTNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAdActivity_.[FavoriteAd]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAdActivity_.[FileAd]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CarrierAdActivity_.[Viewed]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[FlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[ExecutionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[SenderSignedFrom], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[LinkID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[LinkName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[UpdatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CarrierAdActivity_.[UpdatedByID]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[CarrierAdActivity] CarrierAdActivity_ LEFT OUTER JOIN [dbo].[CarrierAd] t0 ON (CarrierAdActivity_.[AdID] =  t0.[AdID]) LEFT OUTER JOIN [dbo].[Party] t1 ON (CarrierAdActivity_.[PartyID] =  t1.[PartyID]) LEFT OUTER JOIN [dbo].[PartyCarrier] t2 ON (CarrierAdActivity_.[CarrierID] =  t2.[CarrierID]) LEFT OUTER JOIN [dbo].[FlowStep] t3 ON (CarrierAdActivity_.[FlowStepID] =  t3.[FlowStepID]) LEFT OUTER JOIN [dbo].[AgreementExecution] t4 ON (CarrierAdActivity_.[ExecutionID] =  t4.[ExecutionID]) LEFT OUTER JOIN [dbo].[CarrierAdLink] t5 ON (CarrierAdActivity_.[LinkID] =  t5.[LinkID])';

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

