if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_DriverAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTV_DriverAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[v_Driver] table.
CREATE PROCEDURE pFASTPORTV_DriverAdd
    @p_PartyID int,
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
BEGIN
    INSERT
    INTO [dbo].[v_Driver]
        (
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
        )
    VALUES
        (
             @p_PartyID,
             @p_FromPic,
             @p_NameHTML,
             @p_MoreHTML,
             @p_AdminHTML,
             @p_Details,
             @p_ProfileSnippet,
             @p_FullProfile,
             @p_MajorStickers,
             @p_MinorStickers,
             @p_GeneralStats,
             @p_YearsTrucking,
             @p_SocialStatus,
             @p_GeneralExperience,
             @p_EquipExperience,
             @p_CargoExperience,
             @p_RegionalExperience,
             @p_Accidents,
             @p_OtherRecords,
             @p_Warnings,
             @p_AllRecords,
             @p_GaugeID
        )

END

