if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceMessageAttachmentsDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceMessageAttachmentsDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ThreadInstanceMessageAttachments] table.
CREATE PROCEDURE pFASTPORTThreadInstanceMessageAttachmentsDelete
        @pk_AttachmentID int
AS
BEGIN
    DELETE [dbo].[ThreadInstanceMessageAttachments]
    WHERE [AttachmentID] = @pk_AttachmentID
END

