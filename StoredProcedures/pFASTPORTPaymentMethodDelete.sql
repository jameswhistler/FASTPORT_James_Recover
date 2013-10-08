if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PaymentMethod] table.
CREATE PROCEDURE pFASTPORTPaymentMethodDelete
        @pk_PaymentMethodID int
AS
BEGIN
    DELETE [dbo].[PaymentMethod]
    WHERE [PaymentMethodID] = @pk_PaymentMethodID
END

