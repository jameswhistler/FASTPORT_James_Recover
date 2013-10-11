if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodCarrierDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodCarrierDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[PaymentMethodCarrier] table.
CREATE PROCEDURE pFASTPORTPaymentMethodCarrierDelete
        @pk_PaymentMethodCarrierID int
AS
BEGIN
    DELETE [dbo].[PaymentMethodCarrier]
    WHERE [PaymentMethodCarrierID] = @pk_PaymentMethodCarrierID
END

