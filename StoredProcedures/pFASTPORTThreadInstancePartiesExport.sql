if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstancePartiesExport') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstancePartiesExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTThreadInstancePartiesExport
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
                N'"InstancePartyID"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
                N'"PartyTypeID"' + @p_separator_str +
                N'"""PartyTypeID"" ItemName"' + @p_separator_str +
                N'"UserID"' + @p_separator_str +
                N'"""UserID"" Name"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"RoleID"' + @p_separator_str +
                N'"""RoleID"" Role"' + @p_separator_str +
                N'"FreeHand"' + @p_separator_str +
                N'"ThreadPriorityID"' + @p_separator_str +
                N'"""ThreadPriorityID"" ItemName"' + @p_separator_str +
                N'"Email"' + @p_separator_str +
                N'"MobileText"' + @p_separator_str +
                N'"Fax"' + @p_separator_str +
                N'"InstantMessage"' + @p_separator_str +
                N'"BoardOnly"' + @p_separator_str +
                N'"FileInstance"' + @p_separator_str +
                N'"OneTime"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[InstancePartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[PartyTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[UserID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[RoleID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[Role], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(ThreadInstanceParties_.[FreeHand], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[ThreadPriorityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[Email]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[MobileText]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[Fax]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[InstantMessage]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[BoardOnly]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, ThreadInstanceParties_.[FileInstance]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[OneTime]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, ThreadInstanceParties_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[ThreadInstanceParties] ThreadInstanceParties_ LEFT OUTER JOIN [dbo].[Tree] t0 ON (ThreadInstanceParties_.[PartyTypeID] =  t0.[TreeID]) LEFT OUTER JOIN [dbo].[Party] t1 ON (ThreadInstanceParties_.[UserID] =  t1.[PartyID]) LEFT OUTER JOIN [dbo].[Role] t2 ON (ThreadInstanceParties_.[RoleID] =  t2.[RoleID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (ThreadInstanceParties_.[ThreadPriorityID] =  t3.[TreeID])';

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

