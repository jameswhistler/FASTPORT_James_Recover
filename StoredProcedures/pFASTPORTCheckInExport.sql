if exists (select * from sysobjects where id = object_id(N'pFASTPORTCheckInExport') and sysstat & 0xf = 4) drop procedure pFASTPORTCheckInExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTCheckInExport
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
                N'"CheckInID"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"CheckInCatID"' + @p_separator_str +
                N'"""CheckInCatID"" ItemName"' + @p_separator_str +
                N'"CityID"' + @p_separator_str +
                N'"PointID"' + @p_separator_str +
                N'"""PointID"" AddrName"' + @p_separator_str +
                N'"ReviewedPartyID"' + @p_separator_str +
                N'"""ReviewedPartyID"" Name"' + @p_separator_str +
                N'"ReviewedAdID"' + @p_separator_str +
                N'"""ReviewedAdID"" AdName"' + @p_separator_str +
                N'"ReviewedPartyExperienceID"' + @p_separator_str +
                N'"""ReviewedPartyExperienceID"" ExperienceNotes"' + @p_separator_str +
                N'"StatusSlider"' + @p_separator_str +
                N'"FavoriteItem"' + @p_separator_str +
                N'"HideItem"' + @p_separator_str +
                N'"ThumbsUp"' + @p_separator_str +
                N'"ThumbHits"' + @p_separator_str +
                N'"ReviewStars"' + @p_separator_str +
                N'"IdleAIR"' + @p_separator_str +
                N'"CompleteAt"' + @p_separator_str +
                N'"CheckInNotes"' + @p_separator_str +
                N'"InstanceID"' + @p_separator_str +
                N'"PosLat"' + @p_separator_str +
                N'"PosLong"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, CheckIn_.[CheckInID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[CheckInCatID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[CityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[PointID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[AddrName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[ReviewedPartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[ReviewedAdID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t4.[AdName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[ReviewedPartyExperienceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t5.[ExperienceNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[StatusSlider]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CheckIn_.[FavoriteItem]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CheckIn_.[HideItem]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, CheckIn_.[ThumbsUp]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[ThumbHits]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[ReviewStars]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[IdleAIR]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[CompleteAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(CheckIn_.[CheckInNotes], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[InstanceID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[PosLat]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[PosLong]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, CheckIn_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[CheckIn] CheckIn_ LEFT OUTER JOIN [dbo].[Party] t0 ON (CheckIn_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (CheckIn_.[CheckInCatID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[PartyAddr] t2 ON (CheckIn_.[PointID] =  t2.[AddrID]) LEFT OUTER JOIN [dbo].[Party] t3 ON (CheckIn_.[ReviewedPartyID] =  t3.[PartyID]) LEFT OUTER JOIN [dbo].[CarrierAd] t4 ON (CheckIn_.[ReviewedAdID] =  t4.[AdID]) LEFT OUTER JOIN [dbo].[PartyExperience] t5 ON (CheckIn_.[ReviewedPartyExperienceID] =  t5.[PartyExperienceID])';

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

