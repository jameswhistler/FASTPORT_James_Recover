if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyCarrierAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyCarrierAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyCarrier] table.
CREATE PROCEDURE pFASTPORTPartyCarrierAdd
    @p_PartyID int,
    @p_CarrierFullName varchar(150),
    @p_DOTNumber varchar(50),
    @p_MCNumber varchar(50),
    @p_Drivers int,
    @p_Certified bit,
    @p_PayCertified bit,
    @p_CarrierID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyCarrier]
        (
            [PartyID],
            [CarrierFullName],
            [DOTNumber],
            [MCNumber]
        )
    VALUES
        (
             @p_PartyID,
             @p_CarrierFullName,
             @p_DOTNumber,
             @p_MCNumber
        )

    SET @p_CarrierID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Drivers IS NOT NULL
        UPDATE [dbo].[PartyCarrier] SET [Drivers] = @p_Drivers WHERE [CarrierID] = @p_CarrierID_out

    IF @p_Certified IS NOT NULL
        UPDATE [dbo].[PartyCarrier] SET [Certified] = @p_Certified WHERE [CarrierID] = @p_CarrierID_out

    IF @p_PayCertified IS NOT NULL
        UPDATE [dbo].[PartyCarrier] SET [PayCertified] = @p_PayCertified WHERE [CarrierID] = @p_CarrierID_out

END

