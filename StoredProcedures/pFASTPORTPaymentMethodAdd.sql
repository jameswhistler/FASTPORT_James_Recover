if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PaymentMethod] table.
CREATE PROCEDURE pFASTPORTPaymentMethodAdd
    @p_PartyID int,
    @p_CreditCardTypeID int,
    @p_CreditCardNumber varchar(25),
    @p_CreditCardName varchar(50),
    @p_StartDate date,
    @p_ExpiryDate date,
    @p_CVV nchar(10),
    @p_BankAccountNumber nvarchar(50),
    @p_BankSortCode nvarchar(50),
    @p_BankAccountName nvarchar(50),
    @p_BankPaymentReference nvarchar(50),
    @p_Preferred bit,
    @p_CarrierAvailabilityID int,
    @p_PartyAvailabilityID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PaymentMethodID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PaymentMethod]
        (
            [PartyID],
            [CreditCardTypeID],
            [CreditCardNumber],
            [CreditCardName],
            [StartDate],
            [ExpiryDate],
            [CVV],
            [BankAccountNumber],
            [BankSortCode],
            [BankAccountName],
            [BankPaymentReference],
            [CarrierAvailabilityID],
            [PartyAvailabilityID],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_PartyID,
             @p_CreditCardTypeID,
             @p_CreditCardNumber,
             @p_CreditCardName,
             @p_StartDate,
             @p_ExpiryDate,
             @p_CVV,
             @p_BankAccountNumber,
             @p_BankSortCode,
             @p_BankAccountName,
             @p_BankPaymentReference,
             @p_CarrierAvailabilityID,
             @p_PartyAvailabilityID,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_PaymentMethodID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Preferred IS NOT NULL
        UPDATE [dbo].[PaymentMethod] SET [Preferred] = @p_Preferred WHERE [PaymentMethodID] = @p_PaymentMethodID_out

END

