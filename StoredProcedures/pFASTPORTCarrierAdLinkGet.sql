if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdLinkGet') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdLinkGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[CarrierAdLink] table.
CREATE PROCEDURE pFASTPORTCarrierAdLinkGet
        @pk_LinkID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[CarrierAdLink]
    WHERE [LinkID] =@pk_LinkID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [LinkID],
        [AdID],
        [LinkName],
        [LinkNotes],
        [OrangeButton],
        [BlueButton],
        [LinkButton],
        [FullLink],
        [LinksHTML],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([LinkID],[AdID],[LinkName],[LinkNotes],[OrangeButton],[BlueButton],[LinkButton],[FullLink],[LinksHTML],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[CarrierAdLink]
    WHERE [LinkID] =@pk_LinkID
    SET NOCOUNT OFF
END

