if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyIncidentExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyIncidentExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPartyIncidentExport
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
                N'"IncidentID"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"IncidentCategoryID"' + @p_separator_str +
                N'"""IncidentCategoryID"" ItemName"' + @p_separator_str +
                N'"ShortDescription"' + @p_separator_str +
                N'"OccurredOn"' + @p_separator_str +
                N'"AccidentLocationID"' + @p_separator_str +
                N'"IWasAtFault"' + @p_separator_str +
                N'"EstimatedCost"' + @p_separator_str +
                N'"FileClosed"' + @p_separator_str +
                N'"TowAWayAccident"' + @p_separator_str +
                N'"FatalitiesOccured"' + @p_separator_str +
                N'"InjuriesOccured"' + @p_separator_str +
                N'"TestedAfterAccident"' + @p_separator_str +
                N'"PositiveForDrugs"' + @p_separator_str +
                N'"PositiveForAlcohol"' + @p_separator_str +
                N'"EqiupTypeID"' + @p_separator_str +
                N'"""EqiupTypeID"" ItemName"' + @p_separator_str +
                N'"CargoTypeID"' + @p_separator_str +
                N'"""CargoTypeID"" ItemName"' + @p_separator_str +
                N'"Ticketed"' + @p_separator_str +
                N'"RuledAsRecklessDriving"' + @p_separator_str +
                N'"FelonyIssued"' + @p_separator_str +
                N'"LicenseSuspended"' + @p_separator_str +
                N'"ReinstatedOn"' + @p_separator_str +
                N'"SAPRelease"' + @p_separator_str +
                N'"SAPReleaseDate"' + @p_separator_str +
                N'"PhysicalLimitationExpiration"' + @p_separator_str +
                N'"PhysicalObsolete"' + @p_separator_str +
                N'"IncidentExpiration"' + @p_separator_str +
                N'"CreatedByID"' + @p_separator_str +
                N'"CreatedAt"' + @p_separator_str +
                N'"UpdatedByID"' + @p_separator_str +
                N'"UpdatedAt"' + @p_separator_str +
                N'"LockIncident"' + ' ';
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
                N'IsNULL(Convert(nvarchar, PartyIncident_.[IncidentID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[IncidentCategoryID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyIncident_.[ShortDescription], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[OccurredOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[AccidentLocationID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[IWasAtFault]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[EstimatedCost]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[FileClosed]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[TowAWayAccident]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[FatalitiesOccured]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[InjuriesOccured]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[TestedAfterAccident]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[PositiveForDrugs]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[PositiveForAlcohol]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[EqiupTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[CargoTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[Ticketed]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[RuledAsRecklessDriving]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[FelonyIssued]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[LicenseSuspended]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[ReinstatedOn], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[SAPRelease]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[SAPReleaseDate], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[PhysicalLimitationExpiration], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[PhysicalObsolete]), '''') + N''"'' + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, PartyIncident_.[IncidentExpiration], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyIncident_.[UpdatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyIncident_.[LockIncident]), '''') + N''"'' + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[PartyIncident] PartyIncident_ LEFT OUTER JOIN [dbo].[Party] t0 ON (PartyIncident_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (PartyIncident_.[IncidentCategoryID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t2 ON (PartyIncident_.[EqiupTypeID] =  t2.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (PartyIncident_.[CargoTypeID] =  t3.[TreeID])';

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

