if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodPartyDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodPartyDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PaymentMethodParty] table.
CREATE PROCEDURE pFASTPORTPaymentMethodPartyDelete
        @pk_PaymentMethodPartyID int
AS
BEGIN
    DELETE [dbo].[PaymentMethodParty]
    WHERE [PaymentMethodPartyID] = @pk_PaymentMethodPartyID
END

