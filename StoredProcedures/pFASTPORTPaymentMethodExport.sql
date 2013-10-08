if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodExport') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodExport 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns the query result set in a CSV format
-- so that the data can be exported to a CSV file
CREATE PROCEDURE pFASTPORTPaymentMethodExport
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
                N'"PaymentMethodID"' + @p_separator_str +
                N'"PartyID"' + @p_separator_str +
                N'"""PartyID"" Title"' + @p_separator_str +
                N'"CreditCardTypeID"' + @p_separator_str +
                N'"""CreditCardTypeID"" ListName"' + @p_separator_str +
                N'"CreditCardNumber"' + @p_separator_str +
                N'"CreditCardName"' + @p_separator_str +
                N'"StartDate"' + @p_separator_str +
                N'"ExpiryDate"' + @p_separator_str +
                N'"CVV"' + @p_separator_str +
                N'"BankAccountNumber"' + @p_separator_str +
                N'"BankSortCode"' + @p_separator_str +
                N'"BankAccountName"' + @p_separator_str +
                N'"BankPaymentReference"' + @p_separator_str +
                N'"Preferred"' + @p_separator_str +
                N'"CarrierAvailabilityID"' + @p_separator_str +
                N'"""CarrierAvailabilityID"" ItemName"' + @p_separator_str +
                N'"PartyAvailabilityID"' + @p_separator_str +
                N'"""PartyAvailabilityID"" ItemName"' + @p_separator_str +
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
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[PaymentMethodID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[PartyID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t0.[Title], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[CreditCardTypeID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t1.[ListName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[CreditCardNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[CreditCardName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[StartDate], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[ExpiryDate], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[CVV], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[BankAccountNumber], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[BankSortCode], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[BankAccountName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL(PaymentMethod_.[BankPaymentReference], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'N''"'' + IsNULL(Convert(nvarchar, PaymentMethod_.[Preferred]), '''') + N''"'' + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[CarrierAvailabilityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t2.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[PartyAvailabilityID]), '''') + ''' + @p_separator_str + ''' +' +
                N'N''"'' + REPLACE(IsNULL( t3.[ItemName], ''''), N''"'', N''""'') + N''"''  + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[CreatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[CreatedAt], 21), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[UpdatedByID]), '''') + ''' + @p_separator_str + ''' +' +
                N'IsNULL(Convert(nvarchar, PaymentMethod_.[UpdatedAt], 21), '''') + '' ''';
            END

        -- Set up the from string (with table alias) and the join string
        SET @l_from_str = '[dbo].[PaymentMethod] PaymentMethod_ LEFT OUTER JOIN [dbo].[Party] t0 ON (PaymentMethod_.[PartyID] =  t0.[PartyID]) LEFT OUTER JOIN [dbo].[List] t1 ON (PaymentMethod_.[CreditCardTypeID] =  t1.[ListID]) LEFT OUTER JOIN [dbo].[Tree] t2 ON (PaymentMethod_.[CarrierAvailabilityID] =  t2.[TreeID]) LEFT OUTER JOIN [dbo].[Tree] t3 ON (PaymentMethod_.[PartyAvailabilityID] =  t3.[TreeID])';

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

