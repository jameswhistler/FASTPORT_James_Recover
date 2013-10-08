if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyDriverExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyDriverExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPartyDriverExport
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
                N'"DriverID"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Name"' + @p_separator_str +
                N'"TruckerTypeID"' + @p_separator_str +
                N'"""TruckerTypeID"" ItemName"' + @p_separator_str +
                N'"DateOfBirth"' + @p_separator_str +
                N'"SocialSecurityNumber"' + @p_separator_str +
                N'"USCitizen"' + @p_separator_str +
                N'"AuthorizedAlien"' + @p_separator_str +
                N'"AuthorizationTypeID"' + @p_separator_str +
                N'"""AuthorizationTypeID"" ItemName"' + @p_separator_str +
                N'"VisaNumber"' + @p_separator_str +
                N'"CertifiedBrakeInspector"' + @p_separator_str +
                N'"MoreThanOneLicense"' + @p_separator_str +
                N'"PromiseToNotifyIn24Hours"' + @p_separator_str +
                N'"PromiseNeverSuspended"' + @p_separator_str +
                N'"DrugTestedWithLastCarrier"' + @p_separator_str +
                N'"PromisedNeverPostiveOnDrugTest"' + @p_separator_str +
                N'"ReturnedToDuty"' + @p_separator_str +
                N'"ContactInfoComplete"' + @p_separator_str +
                N'"PersonalInfoComplete"' + @p_separator_str +
                N'"RepresentationsComplete"' + @p_separator_str +
                N'"EstAccidentsID"' + @p_separator_str +
                N'"EstTicketsID"' + @p_separator_str +
                N'"EstFailedTestsID"' + @p_separator_str +
                N'"EstFeloniesID"' + @p_separator_str +
                N'"ProgBasic"' + @p_separator_str +
                N'"ProgHistory"' + @p_separator_str +
                N'"ProgExperience"' + @p_separator_str +
                N'"ProgIncidents"' + @p_separator_str +
                N'"ProgDoc"' + @p_separator_str +
                N'"ProgeeEquip"' + @p_separator_str +
                N'"GaugeID"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, PartyDriver_.[DriverID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Name], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[TruckerTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[DateOfBirth], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyDriver_.[SocialSecurityNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[USCitizen]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[AuthorizedAlien]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[AuthorizationTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PartyDriver_.[VisaNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[CertifiedBrakeInspector]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[MoreThanOneLicense]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[PromiseToNotifyIn24Hours]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[PromiseNeverSuspended]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[DrugTestedWithLastCarrier]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[PromisedNeverPostiveOnDrugTest]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[ReturnedToDuty]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[ContactInfoComplete]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[PersonalInfoComplete]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PartyDriver_.[RepresentationsComplete]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[EstAccidentsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[EstTicketsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[EstFailedTestsID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[EstFeloniesID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgBasic]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgHistory]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgExperience]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgIncidents]), '''') + ''' + @p_separator_str + ''' +' 
            SET @l_select_str2 = 
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgDoc]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[ProgeeEquip]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[GaugeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PartyDriver_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[PartyDriver] PartyDriver_ LEFT OUTER JOIN [dbo].[Party] t0 ON (PartyDriver_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[Tree] t1 ON (PartyDriver_.[TruckerTypeID] =  t1.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t2 ON (PartyDriver_.[AuthorizationTypeID] =  t2.[TreeID])';

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

