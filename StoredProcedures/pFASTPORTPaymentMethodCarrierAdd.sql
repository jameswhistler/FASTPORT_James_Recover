if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodCarrierAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodCarrierAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PaymentMethodCarrier] table.
CREATE PROCEDURE pFASTPORTPaymentMethodCarrierAdd
    @p_PaymentMethodID int,
    @p_CarrierID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PaymentMethodCarrierID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PaymentMethodCarrier]
        (
            [PaymentMethodID],
            [CarrierID],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_PaymentMethodID,
             @p_CarrierID,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_PaymentMethodCarrierID_out = SCOPE_IDENTITY()

END

