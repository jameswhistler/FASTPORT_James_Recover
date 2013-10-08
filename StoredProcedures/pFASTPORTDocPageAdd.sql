if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocPageAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTDocPageAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[DocPage] table.
CREATE PROCEDURE pFASTPORTDocPageAdd
    @p_DocID int,
    @p_DocThumbnail image,
    @p_DocFile image,
    @p_PageNumber int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PageID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[DocPage]
        (
            [DocID],
            [DocThumbnail],
            [DocFile],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_DocID,
             @p_DocThumbnail,
             @p_DocFile,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_PageID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_PageNumber IS NOT NULL
        UPDATE [dbo].[DocPage] SET [PageNumber] = @p_PageNumber WHERE [PageID] = @p_PageID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[DocPage] SET [CreatedAt] = @p_CreatedAt WHERE [PageID] = @p_PageID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[DocPage] SET [UpdatedAt] = @p_UpdatedAt WHERE [PageID] = @p_PageID_out

END

