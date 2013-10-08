if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodPartyAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodPartyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PaymentMethodParty] table.
CREATE PROCEDURE pFASTPORTPaymentMethodPartyAdd
    @p_PaymentMethodID int,
    @p_PartyID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PaymentMethodPartyID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PaymentMethodParty]
        (
            [PaymentMethodID],
            [PartyID],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_PaymentMethodID,
             @p_PartyID,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_PaymentMethodPartyID_out = SCOPE_IDENTITY()

END

