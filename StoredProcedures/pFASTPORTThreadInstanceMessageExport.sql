if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageExport') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTThreadInstanceMessageExport
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
                N'"MessageID"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
                N'"SenderID"' + @p_separator_str +
                N'"""SenderID"" Name"' + @p_separator_str +
                N'"MessageAction"' + @p_separator_str +
                N'"MessageButtonText"' + @p_separator_str +
                N'"MessageSubject"' + @p_separator_str +
                N'"ButtonID"' + @p_separator_str +
                N'"""ButtonID"" RefName"' + @p_separator_str +
                N'"Queued"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + @p_separator_str +
                N'"ActionCollectionID"' + @p_separator_str +
                N'"""ActionCollectionID"" CollectionName"' + @p_separator_str +
                N'"LeftPartURL"' + @p_separator_str +
                N'"ActionURL"' + @p_separator_str +
                N'"ExcludeParams"' + @p_separator_str +
                N'"NoRadWindow"' + @p_separator_str +
                N'"GoAction"' + @p_separator_str +
                N'"Action"' + @p_separator_str +
                N'"CloseAction"' + @p_separator_str +
                N'"SliderValue"' + @p_separator_str +
                N'"RowOwnerCIX"' + @p_separator_str +
                N'"RowOIX"' + @p_separator_str +
                N'"FlowStep"' + @p_separator_str +
                N'"Party"' + @p_separator_str +
                N'"UserSystem"' + @p_separator_str +
                N'"Message"' + @p_separator_str +
                N'"Instance"' + @p_separator_str +
                N'"FleetCircle"' + @p_separator_str +
                N'"Execution"' + @p_separator_str +
                N'"Ad"' + @p_separator_str +
                N'"AdActivity"' + @p_separator_str +
                N'"CheckIn"' + @p_separator_str +
                N'"DocFiled"' + @p_separator_str +
                N'"Ord"' + @p_separator_str +
                N'"Payment"' + @p_separator_str +
                N'"Carrier"' + @p_separator_str +
                N'"Driver"' + @p_separator_str +
                N'"Addr"' + @p_separator_str +
                N'"Role"' + @p_separator_str +
                N'"History"' + @p_separator_str +
                N'"Parent"' + @p_separator_str +
                N'"Email"' + @p_separator_str +
                N'"Button"' + @p_separator_str +
                N'"Verification"' + @p_separator_str +
                N'"Doc"' + ' ';
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
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[MessageID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[SenderID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[MessageAction], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[MessageButtonText], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[MessageSubject], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[ButtonID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Queued]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[UpdatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[ActionCollectionID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[CollectionName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[LeftPartURL], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[ActionURL], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[ExcludeParams]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[NoRadWindow]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[GoAction], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[Action], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[CloseAction], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[SliderValue], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[RowOwnerCIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[RowOIX]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[FlowStep]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Party]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[UserSystem]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Message]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Instance]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[FleetCircle]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Execution]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Ad]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[AdActivity]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[CheckIn]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[DocFiled]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Ord]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Payment]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Carrier]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Driver]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Addr]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Role]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[History]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Parent]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceMessage_.[Email], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Button]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Verification]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceMessage_.[Doc]), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[ThreadInstanceMessage] ThreadInstanceMessage_ LEFT OUTER JOIN [dbo].[Party] t0 ON (ThreadInstanceMessage_.[SenderID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[FlowButton] t1 ON (ThreadInstanceMessage_.[ButtonID] =  t1.[ButtonID]) LEFT OUTER JOIN [dbo].[FlowCollection] t2 ON (ThreadInstanceMessage_.[ActionCollectionID] =  t2.[FlowCollectionID])';

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

