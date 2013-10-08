if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PaymentMethod] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPaymentMethodUpdate
    @pk_PaymentMethodID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[PaymentMethod] WHERE [PaymentMethodID] = @pk_PaymentMethodID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PaymentMethod]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PaymentMethod]
            SET 
            [PartyID] = @p_PartyID,
            [CreditCardTypeID] = @p_CreditCardTypeID,
            [CreditCardNumber] = @p_CreditCardNumber,
            [CreditCardName] = @p_CreditCardName,
            [StartDate] = @p_StartDate,
            [ExpiryDate] = @p_ExpiryDate,
            [CVV] = @p_CVV,
            [BankAccountNumber] = @p_BankAccountNumber,
            [BankSortCode] = @p_BankSortCode,
            [BankAccountName] = @p_BankAccountName,
            [BankPaymentReference] = @p_BankPaymentReference,
            [Preferred] = @p_Preferred,
            [CarrierAvailabilityID] = @p_CarrierAvailabilityID,
            [PartyAvailabilityID] = @p_PartyAvailabilityID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [PaymentMethodID] = @pk_PaymentMethodID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([PaymentMethodID],[PartyID],[CreditCardTypeID],[CreditCardNumber],[CreditCardName],[StartDate],[ExpiryDate],[CVV],[BankAccountNumber],[BankSortCode],[BankAccountName],[BankPaymentReference],[Preferred],[CarrierAvailabilityID],[PartyAvailabilityID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[PaymentMethod] with (rowlock, holdlock)
            WHERE [PaymentMethodID] = @pk_PaymentMethodID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PaymentMethod]
                    SET 
                    [PartyID] = @p_PartyID,
                    [CreditCardTypeID] = @p_CreditCardTypeID,
                    [CreditCardNumber] = @p_CreditCardNumber,
                    [CreditCardName] = @p_CreditCardName,
                    [StartDate] = @p_StartDate,
                    [ExpiryDate] = @p_ExpiryDate,
                    [CVV] = @p_CVV,
                    [BankAccountNumber] = @p_BankAccountNumber,
                    [BankSortCode] = @p_BankSortCode,
                    [BankAccountName] = @p_BankAccountName,
                    [BankPaymentReference] = @p_BankPaymentReference,
                    [Preferred] = @p_Preferred,
                    [CarrierAvailabilityID] = @p_CarrierAvailabilityID,
                    [PartyAvailabilityID] = @p_PartyAvailabilityID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [PaymentMethodID] = @pk_PaymentMethodID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PaymentMethod]', 16, 1)

        END
END

