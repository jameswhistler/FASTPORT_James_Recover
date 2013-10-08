if exists (select * from sysobjects where id = object_id(N'pFASTPORTTreeGet') and sysstat & 0xf = 4) drop procedure pFASTPORTTreeGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Tree] table.
CREATE PROCEDURE pFASTPORTTreeGet
        @pk_TreeID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Tree]
    WHERE [TreeID] =@pk_TreeID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [TreeID],
        [CIX],
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
        [FolderOnly],
        [ItemRank],
        [Hide],
        [AdminOnly],
        [GeoStateID],
        [GeoMarketID],
        [NoSlide],
        [YearSlider],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        [ExternalID],
        CAST(BINARY_CHECKSUM([TreeID],[CIX],[TreeParentID],[ItemName],[Description],[Abbreviation],[ItemImage],[ImagePath],[ItemImageGlow],[ImageGlowPath],[ItemImageGray],[ImageGrayPath],[ItemImageLowRes],[ImageLowResPath],[FolderOnly],[ItemRank],[Hide],[AdminOnly],[GeoStateID],[GeoMarketID],[NoSlide],[YearSlider],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[ExternalID]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Tree]
    WHERE [TreeID] =@pk_TreeID
    SET NOCOUNT OFF
END

