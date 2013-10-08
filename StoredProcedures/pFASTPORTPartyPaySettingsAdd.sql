if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyPaySettingsAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyPaySettingsAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyPaySettings] table.
CREATE PROCEDURE pFASTPORTPartyPaySettingsAdd
    @p_PartyID int,
    @p_PayPalToken varchar(50),
    @p_FlowStepID int,
    @p_PaySettingsID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyPaySettings]
        (
            [PartyID],
            [PayPalToken],
            [FlowStepID]
        )
    VALUES
        (
             @p_PartyID,
             @p_PayPalToken,
             @p_FlowStepID
        )

    SET @p_PaySettingsID_out = SCOPE_IDENTITY()

END

