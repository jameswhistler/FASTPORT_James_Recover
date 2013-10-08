if exists (select * from sysobjects where id = object_id(N'pFASTPORTTreeAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTTreeAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Tree] table.
CREATE PROCEDURE pFASTPORTTreeAdd
    @p_CIX int,
    @p_TreeParentID int,
    @p_ItemName varchar(100),
    @p_Description varchar(max),
    @p_Abbreviation varchar(50),
    @p_ItemImage image,
    @p_ImagePath varchar(255),
    @p_ItemImageGlow image,
    @p_ImageGlowPath varchar(255),
    @p_ItemImageGray image,
    @p_ImageGrayPath varchar(255),
    @p_ItemImageLowRes image,
    @p_ImageLowResPath varchar(255),
    @p_FolderOnly bit,
    @p_ItemRank int,
    @p_Hide bit,
    @p_AdminOnly bit,
    @p_GeoStateID int,
    @p_GeoMarketID int,
    @p_NoSlide bit,
    @p_YearSlider bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_ExternalID int,
    @p_TreeID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Tree]
        (
            [TreeParentID],
            [ItemName],
            [Description],
            [Abbreviation],
            [ItemImage],
            [ImagePath],
            [ItemImageGlow],
            [ImageGlowPath],
            [ItemImageGray],
            [ImageGrayPath],
            [ItemImageLowRes],
            [ImageLowResPath],
            [GeoStateID],
            [GeoMarketID],
            [UpdatedByID],
            [UpdatedAt],
            [ExternalID]
        )
    VALUES
        (
             @p_TreeParentID,
             @p_ItemName,
             @p_Description,
             @p_Abbreviation,
             @p_ItemImage,
             @p_ImagePath,
             @p_ItemImageGlow,
             @p_ImageGlowPath,
             @p_ItemImageGray,
             @p_ImageGrayPath,
             @p_ItemImageLowRes,
             @p_ImageLowResPath,
             @p_GeoStateID,
             @p_GeoMarketID,
             @p_UpdatedByID,
             @p_UpdatedAt,
             @p_ExternalID
        )

    SET @p_TreeID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CIX IS NOT NULL
        UPDATE [dbo].[Tree] SET [CIX] = @p_CIX WHERE [TreeID] = @p_TreeID_out

    IF @p_FolderOnly IS NOT NULL
        UPDATE [dbo].[Tree] SET [FolderOnly] = @p_FolderOnly WHERE [TreeID] = @p_TreeID_out

    IF @p_ItemRank IS NOT NULL
        UPDATE [dbo].[Tree] SET [ItemRank] = @p_ItemRank WHERE [TreeID] = @p_TreeID_out

    IF @p_Hide IS NOT NULL
        UPDATE [dbo].[Tree] SET [Hide] = @p_Hide WHERE [TreeID] = @p_TreeID_out

    IF @p_AdminOnly IS NOT NULL
        UPDATE [dbo].[Tree] SET [AdminOnly] = @p_AdminOnly WHERE [TreeID] = @p_TreeID_out

    IF @p_NoSlide IS NOT NULL
        UPDATE [dbo].[Tree] SET [NoSlide] = @p_NoSlide WHERE [TreeID] = @p_TreeID_out

    IF @p_YearSlider IS NOT NULL
        UPDATE [dbo].[Tree] SET [YearSlider] = @p_YearSlider WHERE [TreeID] = @p_TreeID_out

    IF @p_CreatedByID IS NOT NULL
        UPDATE [dbo].[Tree] SET [CreatedByID] = @p_CreatedByID WHERE [TreeID] = @p_TreeID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Tree] SET [CreatedAt] = @p_CreatedAt WHERE [TreeID] = @p_TreeID_out

END

