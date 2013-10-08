﻿if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodPartyDeleteRecords') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodPartyDeleteRecords 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a set of rows from the [dbo].[PaymentMethodParty] table
-- that match the specified search criteria.
-- Returns the number of rows deleted as an output parameter.
CREATE PROCEDURE pFASTPORTPaymentMethodPartyDeleteRecords
        @p_where_str nvarchar(4000),
        @p_num_deleted int OUTPUT
AS
DECLARE
    @l_where_str nvarchar(4000),
    @l_query_str nvarchar(4000)
BEGIN

    -- Initialize the where string
    SET @l_where_str = ' '
    IF @p_where_str IS NOT NULL
        SET @l_where_str = ' WHERE ' + @p_where_str;

    SET @p_num_deleted = 0;

    -- Set up the query string
    SET @l_query_str =
        'DELETE [dbo].[PaymentMethodParty] ' +
        'FROM [dbo].[PaymentMethodParty] PaymentMethodParty_' +
        @l_where_str + ' ';

    -- Run the query
    EXECUTE (@l_query_str)

    -- Return the number of rows affected to the output parameter
    SELECT @p_num_deleted = @@ROWCOUNT

END

