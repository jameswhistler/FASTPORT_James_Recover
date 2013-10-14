if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodPeopleDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodPeopleDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PaymentMethodPeople] table.
CREATE PROCEDURE pFASTPORTPaymentMethodPeopleDelete
        @pk_PaymentMethodPeopleID int
AS
BEGIN
    DELETE [dbo].[PaymentMethodPeople]
    WHERE [PaymentMethodPeopleID] = @pk_PaymentMethodPeopleID
END

