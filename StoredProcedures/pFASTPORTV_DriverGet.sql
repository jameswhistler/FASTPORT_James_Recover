if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_DriverGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_DriverGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Driver] table.
CREATE PROCEDURE pFASTPORTV_DriverGet
        @pk_PartyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Driver]
    WHERE [PartyID] =@pk_PartyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PartyID],
        [FromPic],
        [NameHTML],
        [MoreHTML],
        [AdminHTML],
        [Details],
        [ProfileSnippet],
        [FullProfile],
        [MajorStickers],
        [MinorStickers],
        [GeneralStats],
        [YearsTrucking],
        [SocialStatus],
        [GeneralExperience],
        [EquipExperience],
        [CargoExperience],
        [RegionalExperience],
        [Accidents],
        [OtherRecords],
        [Warnings],
        [AllRecords],
        [GaugeID]
    FROM [dbo].[v_Driver]
    WHERE [PartyID] =@pk_PartyID
    SET NOCOUNT OFF
END

