if exists (select * from sysobjects where id = object_id(N'pFASTPORTEquipGet') and sysstat & 0xf = 4) drop procedure pFASTPORTEquipGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Equip] table.
CREATE PROCEDURE pFASTPORTEquipGet
        @pk_EquipID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Equip]
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
        [YearID],
        [Make],
        [Model],
        [Axels],
        [UnladenWeight],
        [HeightFeet],
        [HeightInches],
        [PurchasedDate],
        [PurchasedValue],
        CAST(BINARY_CHECKSUM([EquipID],[PartyID],[OwnerID],[YearID],[Make],[Model],[Axels],[UnladenWeight],[HeightFeet],[HeightInches],[PurchasedDate],[PurchasedValue]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Equip]
    WHERE [EquipID] =@pk_EquipID
    SET NOCOUNT OFF
END

