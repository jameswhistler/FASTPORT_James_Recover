if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdLinkAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdLinkAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[CarrierAdLink] table.
CREATE PROCEDURE pFASTPORTCarrierAdLinkAdd
    @p_AdID int,
    @p_LinkName varchar(255),
    @p_LinkNotes varchar(2000),
    @p_OrangeButton bit,
    @p_BlueButton bit,
    @p_LinkButton bit,
    @p_FullLink bit,
    @p_LinksHTML varchar(2000),
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_LinkID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[CarrierAdLink]
        (
            [AdID],
            [LinkName],
            [LinkNotes],
            [LinksHTML],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_AdID,
             @p_LinkName,
             @p_LinkNotes,
             @p_LinksHTML,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_LinkID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_OrangeButton IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [OrangeButton] = @p_OrangeButton WHERE [LinkID] = @p_LinkID_out

    IF @p_BlueButton IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [BlueButton] = @p_BlueButton WHERE [LinkID] = @p_LinkID_out

    IF @p_LinkButton IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [LinkButton] = @p_LinkButton WHERE [LinkID] = @p_LinkID_out

    IF @p_FullLink IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [FullLink] = @p_FullLink WHERE [LinkID] = @p_LinkID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [CreatedAt] = @p_CreatedAt WHERE [LinkID] = @p_LinkID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[CarrierAdLink] SET [UpdatedAt] = @p_UpdatedAt WHERE [LinkID] = @p_LinkID_out

END

