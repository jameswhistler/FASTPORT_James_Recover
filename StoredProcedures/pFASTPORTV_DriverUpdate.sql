if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_DriverUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTV_DriverUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[v_Driver] table.
CREATE PROCEDURE pFASTPORTV_DriverUpdate
    @p_PartyID int,
    @pk_PartyID int,
    @p_FromPic image,
    @p_NameHTML varchar(max),
    @p_MoreHTML varchar(max),
    @p_AdminHTML varchar(max),
    @p_Details varchar(max),
    @p_ProfileSnippet varchar(max),
    @p_FullProfile varchar(max),
    @p_MajorStickers nvarchar(2000),
    @p_MinorStickers nvarchar(2000),
    @p_GeneralStats varchar(max),
    @p_YearsTrucking varchar(max),
    @p_SocialStatus varchar(max),
    @p_GeneralExperience varchar(max),
    @p_EquipExperience varchar(max),
    @p_CargoExperience varchar(max),
    @p_RegionalExperience varchar(max),
    @p_Accidents varchar(max),
    @p_OtherRecords varchar(max),
    @p_Warnings varchar(max),
    @p_AllRecords varchar(max),
    @p_GaugeID int
AS
DECLARE
    @l_rowcount int
BEGIN

    -- Update the record with the passed parameters
    UPDATE [dbo].[v_Driver]
    SET 
            [PartyID] = @p_PartyID,
            [FromPic] = @p_FromPic,
            [NameHTML] = @p_NameHTML,
            [MoreHTML] = @p_MoreHTML,
            [AdminHTML] = @p_AdminHTML,
            [Details] = @p_Details,
            [ProfileSnippet] = @p_ProfileSnippet,
            [FullProfile] = @p_FullProfile,
            [MajorStickers] = @p_MajorStickers,
            [MinorStickers] = @p_MinorStickers,
            [GeneralStats] = @p_GeneralStats,
            [YearsTrucking] = @p_YearsTrucking,
            [SocialStatus] = @p_SocialStatus,
            [GeneralExperience] = @p_GeneralExperience,
            [EquipExperience] = @p_EquipExperience,
            [CargoExperience] = @p_CargoExperience,
            [RegionalExperience] = @p_RegionalExperience,
            [Accidents] = @p_Accidents,
            [OtherRecords] = @p_OtherRecords,
            [Warnings] = @p_Warnings,
            [AllRecords] = @p_AllRecords,
            [GaugeID] = @p_GaugeID
    WHERE [PartyID] = @pk_PartyID

    -- Make sure only one record is affected
    SET @l_rowcount = @@ROWCOUNT
    IF @l_rowcount = 0
        RAISERROR ('The record cannot be updated.', 16, 1)
    IF @l_rowcount > 1
        RAISERROR ('duplicate object instances.', 16, 1)

END

