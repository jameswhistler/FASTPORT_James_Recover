if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignEquipGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignEquipGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_SignEquip] table.
CREATE PROCEDURE pFASTPORTV_SignEquipGet
        @pk_EquipID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_SignEquip]
    WHERE [EquipID] =@pk_EquipID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [EquipID],
        [PartyID],
        [OwnerID],
        [O_Name],
        [V_Info],
        [V_Registration],
        [V_Specs],
        [V_PurchaseInfo],
        [V_Year],
        [V_Make],
        [V_Model],
        [V_Axels],
        [V_UnladenWeight],
        [V_Height],
        [V_PurchasedDate],
        [V_PurchasedValue]
    FROM [dbo].[v_SignEquip]
    WHERE [EquipID] =@pk_EquipID
    SET NOCOUNT OFF
END

