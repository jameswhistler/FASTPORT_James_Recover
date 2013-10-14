if exists (select * from sysobjects where id = object_id(N'pFASTPORTPaymentMethodPeopleAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPaymentMethodPeopleAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PaymentMethodPeople] table.
CREATE PROCEDURE pFASTPORTPaymentMethodPeopleAdd
    @p_PaymentMethodCompanyID int,
    @p_PaymentMethodID int,
    @p_PersonID int,
    @p_RoleID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PaymentMethodPeopleID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PaymentMethodPeople]
        (
            [PaymentMethodCompanyID],
            [PaymentMethodID],
            [PersonID],
            [RoleID],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_PaymentMethodCompanyID,
             @p_PaymentMethodID,
             @p_PersonID,
             @p_RoleID,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_PaymentMethodPeopleID_out = SCOPE_IDENTITY()

END

