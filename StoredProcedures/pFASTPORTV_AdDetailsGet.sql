if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_AdDetailsGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_AdDetailsGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_AdDetails] table.
CREATE PROCEDURE pFASTPORTV_AdDetailsGet
        @pk_AdID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_AdDetails]
    WHERE [AdID] =@pk_AdID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AdID],
        [PartyID],
        [CarrierID],
        [AdHTML],
        [LongDescription],
        [GeneralExperience],
        [EquipExperience],
        [CargoExperience],
        [RegionalExperience],
        [Requirements],
        [PayHTML]
    FROM [dbo].[v_AdDetails]
    WHERE [AdID] =@pk_AdID
    SET NOCOUNT OFF
END

