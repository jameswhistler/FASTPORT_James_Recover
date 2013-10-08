if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageAttachmentsAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageAttachmentsAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ThreadInstanceMessageAttachments] table.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageAttachmentsAdd
    @p_MessageID int,
    @p_FileName varchar(50),
    @p_Attachment image,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_AttachmentID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[ThreadInstanceMessageAttachments]
        (
            [MessageID],
            [FileName],
            [Attachment],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_MessageID,
             @p_FileName,
             @p_Attachment,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_AttachmentID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessageAttachments] SET [CreatedAt] = @p_CreatedAt WHERE [AttachmentID] = @p_AttachmentID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstanceMessageAttachments] SET [UpdatedAt] = @p_UpdatedAt WHERE [AttachmentID] = @p_AttachmentID_out

END

