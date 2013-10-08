if exists (select * from sysobjects where id = object_id(N'pFASTPORTTreeUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTTreeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Tree] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTTreeUpdate
    @pk_TreeID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Tree] WHERE [TreeID] = @pk_TreeID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Tree]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Tree]
            SET 
            [CIX] = @p_CIX,
            [TreeParentID] = @p_TreeParentID,
            [ItemName] = @p_ItemName,
            [Description] = @p_Description,
            [Abbreviation] = @p_Abbreviation,
            [ItemImage] = @p_ItemImage,
            [ImagePath] = @p_ImagePath,
            [ItemImageGlow] = @p_ItemImageGlow,
            [ImageGlowPath] = @p_ImageGlowPath,
            [ItemImageGray] = @p_ItemImageGray,
            [ImageGrayPath] = @p_ImageGrayPath,
            [ItemImageLowRes] = @p_ItemImageLowRes,
            [ImageLowResPath] = @p_ImageLowResPath,
            [FolderOnly] = @p_FolderOnly,
            [ItemRank] = @p_ItemRank,
            [Hide] = @p_Hide,
            [AdminOnly] = @p_AdminOnly,
            [GeoStateID] = @p_GeoStateID,
            [GeoMarketID] = @p_GeoMarketID,
            [NoSlide] = @p_NoSlide,
            [YearSlider] = @p_YearSlider,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [ExternalID] = @p_ExternalID
            WHERE [TreeID] = @pk_TreeID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([TreeID],[CIX],[TreeParentID],[ItemName],[Description],[Abbreviation],[ItemImage],[ImagePath],[ItemImageGlow],[ImageGlowPath],[ItemImageGray],[ImageGrayPath],[ItemImageLowRes],[ImageLowResPath],[FolderOnly],[ItemRank],[Hide],[AdminOnly],[GeoStateID],[GeoMarketID],[NoSlide],[YearSlider],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[ExternalID]) AS nvarchar(4000)) 
            FROM [dbo].[Tree] with (rowlock, holdlock)
            WHERE [TreeID] = @pk_TreeID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Tree]
                    SET 
                    [CIX] = @p_CIX,
                    [TreeParentID] = @p_TreeParentID,
                    [ItemName] = @p_ItemName,
                    [Description] = @p_Description,
                    [Abbreviation] = @p_Abbreviation,
                    [ItemImage] = @p_ItemImage,
                    [ImagePath] = @p_ImagePath,
                    [ItemImageGlow] = @p_ItemImageGlow,
                    [ImageGlowPath] = @p_ImageGlowPath,
                    [ItemImageGray] = @p_ItemImageGray,
                    [ImageGrayPath] = @p_ImageGrayPath,
                    [ItemImageLowRes] = @p_ItemImageLowRes,
                    [ImageLowResPath] = @p_ImageLowResPath,
                    [FolderOnly] = @p_FolderOnly,
                    [ItemRank] = @p_ItemRank,
                    [Hide] = @p_Hide,
                    [AdminOnly] = @p_AdminOnly,
                    [GeoStateID] = @p_GeoStateID,
                    [GeoMarketID] = @p_GeoMarketID,
                    [NoSlide] = @p_NoSlide,
                    [YearSlider] = @p_YearSlider,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [ExternalID] = @p_ExternalID
                    WHERE [TreeID] = @pk_TreeID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Tree]', 16, 1)

        END
END

