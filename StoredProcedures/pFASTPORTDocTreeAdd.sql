if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocTreeAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTDocTreeAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[DocTree] table.
CREATE PROCEDURE pFASTPORTDocTreeAdd
    @p_CIX int,
    @p_DocTreeParentID int,
    @p_RoleID int,
    @p_DocIndex varchar(50),
    @p_DocSort varchar(50),
    @p_DocName varchar(100),
    @p_DocDescription varchar(255),
    @p_DocTypeID int,
    @p_Folder bit,
    @p_PrivateFolder bit,
    @p_OneActiveCopy bit,
    @p_OnApp bit,
    @p_RecordDocDetails bit,
    @p_AlwaysShow bit,
    @p_ItemRank int,
    @p_Hide bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_DocTreeID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[DocTree]
        (
            [CIX],
            [DocTreeParentID],
            [RoleID],
            [DocIndex],
            [DocSort],
            [DocName],
            [DocDescription],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_CIX,
             @p_DocTreeParentID,
             @p_RoleID,
             @p_DocIndex,
             @p_DocSort,
             @p_DocName,
             @p_DocDescription,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_DocTreeID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_DocTypeID IS NOT NULL
        UPDATE [dbo].[DocTree] SET [DocTypeID] = @p_DocTypeID WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_Folder IS NOT NULL
        UPDATE [dbo].[DocTree] SET [Folder] = @p_Folder WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_PrivateFolder IS NOT NULL
        UPDATE [dbo].[DocTree] SET [PrivateFolder] = @p_PrivateFolder WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_OneActiveCopy IS NOT NULL
        UPDATE [dbo].[DocTree] SET [OneActiveCopy] = @p_OneActiveCopy WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_OnApp IS NOT NULL
        UPDATE [dbo].[DocTree] SET [OnApp] = @p_OnApp WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_RecordDocDetails IS NOT NULL
        UPDATE [dbo].[DocTree] SET [RecordDocDetails] = @p_RecordDocDetails WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_AlwaysShow IS NOT NULL
        UPDATE [dbo].[DocTree] SET [AlwaysShow] = @p_AlwaysShow WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_ItemRank IS NOT NULL
        UPDATE [dbo].[DocTree] SET [ItemRank] = @p_ItemRank WHERE [DocTreeID] = @p_DocTreeID_out

    IF @p_Hide IS NOT NULL
        UPDATE [dbo].[DocTree] SET [Hide] = @p_Hide WHERE [DocTreeID] = @p_DocTreeID_out

END

