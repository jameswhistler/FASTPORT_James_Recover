if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPartyExport
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
                N'"PartyID"' + @p_separator_str +
                N'"PartyTypeID"' + @p_separator_str +
                N'"""PartyTypeID"" ItemName"' + @p_separator_str +
                N'"Name"' + @p_separator_str +
                N'"DBA"' + @p_separator_str +
                N'"Title"' + @p_separator_str +
                N'"Handle"' + @p_separator_str +
                N'"Email"' + @p_separator_str +
                N'"Contact"' + @p_separator_str +
                N'"DirectDial"' + @p_separator_str +
                N'"Mobile"' + @p_separator_str +
                N'"Fax"' + @p_separator_str +
                N'"OtherPhone"' + @p_separator_str +
                N'"ShareWithFriends"' + @p_separator_str +
                N'"ShareWithDrivers"' + @p_separator_str +
                N'"ShareWithCarrier"' + @p_separator_str +
                N'"ShareWithCloseBy"' + @p_separator_str +
                N'"ShareWithLikeMe"' + @p_separator_str +
                N'"AllowInvitations"' + @p_separator_str +
                N'"ThreadEmail"' + @p_separator_str +
                N'"ThreadMobileText"' + @p_separator_str +
                N'"ThreadFax"' + @p_separator_str +
                N'"ThreadInstantMessage"' + @p_separator_str +
                N'"ThreadBoardOnly"' + @p_separator_str +
                N'"EntityID"' + @p_separator_str +
                N'"""EntityID"" ItemName"' + @p_separator_str +
                N'"SocialSecurityNumber"' + @p_separator_str +
                N'"EINNumber"' + @p_separator_str +
                N'"SMTPPort"' + @p_separator_str +
                N'"SMTPServer"' + @p_separator_str +
                N'"EnableSSLYN"' + @p_separator_str +
                N'"FaxCredentials"' + @p_separator_str +
                N'"FaxAccount"' + @p_separator_str +
                N'"FaxSMTPPort"' + @p_separator_str +
                N'"FaxSMTPServer"' + @p_separator_str +
                N'"FaxEnableSSLYN"' + @p_separator_str +
                N'"RegisteredUserSince"' + @p_separator_str +
                N'"AccountFlowStepID"' + @p_separator_str +
                N'"""AccountFlowStepID"" RefName"' + @p_separator_str +
                N'"PayPalToken"' + @p_separator_str +
                N'"StripSearch"' + @p_separator_str +
                N'"StripSearchDBA"' + @p_separator_str +
                N'"OutsideID"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, Party_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[PartyTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[DBA], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Title], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Handle], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Email], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Contact], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[DirectDial], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Mobile], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[Fax], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[OtherPhone], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ShareWithFriends]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ShareWithDrivers]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ShareWithCarrier]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ShareWithCloseBy]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ShareWithLikeMe]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[AllowInvitations]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ThreadEmail]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ThreadMobileText]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ThreadFax]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ThreadInstantMessage]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, Party_.[ThreadBoardOnly]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[EntityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[SocialSecurityNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[EINNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[SMTPPort]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[SMTPServer], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[EnableSSLYN]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'N''"'' + REPLACE(IsNULL(Party_.[FaxCredentials], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[FaxAccount], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[FaxSMTPPort]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[FaxSMTPServer], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[FaxEnableSSLYN]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[RegisteredUserSince], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[AccountFlowStepID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[RefName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[PayPalToken], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[StripSearch], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[StripSearchDBA], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(Party_.[OutsideID], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, Party_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[Party] Party_ LEFT OUTER JOIN [dbo].[Tree] t0 ON (Party_.[PartyTypeID] =  t0.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (Party_.[EntityID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[FlowStep] t2 ON (Party_.[AccountFlowStepID] =  t2.[FlowStepID])';

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

