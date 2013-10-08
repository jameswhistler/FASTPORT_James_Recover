if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_TreeHTMLGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_TreeHTMLGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_TreeHTML] table.
CREATE PROCEDURE pFASTPORTV_TreeHTMLGet
        @pk_TreeID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_TreeHTML]
    WHERE [TreeID] =@pk_TreeID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [TreeID],
        [TreeParentID],
        [ItemName],
        [TreeHTML],
        [ItemRank],
        [FolderOnly]
    FROM [dbo].[v_TreeHTML]
    WHERE [TreeID] =@pk_TreeID
    SET NOCOUNT OFF
END

