if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdContactsAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdContactsAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CarrierAdContacts] table.
CREATE PROCEDURE pFASTPORTCarrierAdContactsAdd
    @p_AdID int,
    @p_ContactTypeID int,
    @p_RoleID int,
    @p_PartyID int,
    @p_AdContactsID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CarrierAdContacts]
        (
            [AdID],
            [ContactTypeID],
            [RoleID],
            [PartyID]
        )
    VALUES
        (
             @p_AdID,
             @p_ContactTypeID,
             @p_RoleID,
             @p_PartyID
        )

    SET @p_AdContactsID_out = SCOPE_IDENTITY()

END

