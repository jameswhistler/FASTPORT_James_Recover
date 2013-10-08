if exists (select * from sysobjects where id = object_id(N'pFASTPORTEquipAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTEquipAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Equip] table.
CREATE PROCEDURE pFASTPORTEquipAdd
    @p_PartyID int,
    @p_OwnerID int,
    @p_YearID int,
    @p_Make varchar(50),
    @p_Model varchar(50),
    @p_Axels int,
    @p_UnladenWeight int,
    @p_HeightFeet int,
    @p_HeightInches int,
    @p_PurchasedDate datetime,
    @p_PurchasedValue money,
    @p_EquipID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Equip]
        (
            [PartyID],
            [OwnerID],
            [YearID],
            [Make],
            [Model],
            [Axels],
            [UnladenWeight],
            [HeightFeet],
            [HeightInches],
            [PurchasedDate],
            [PurchasedValue]
        )
    VALUES
        (
             @p_PartyID,
             @p_OwnerID,
             @p_YearID,
             @p_Make,
             @p_Model,
             @p_Axels,
             @p_UnladenWeight,
             @p_HeightFeet,
             @p_HeightInches,
             @p_PurchasedDate,
             @p_PurchasedValue
        )

    SET @p_EquipID_out = SCOPE_IDENTITY()

END

