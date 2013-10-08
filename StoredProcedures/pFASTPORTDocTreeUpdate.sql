if exists (select * from sysobjects where id = object_id(N'pFASTPORTDocTreeUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTDocTreeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[DocTree] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTDocTreeUpdate
    @pk_DocTreeID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[DocTree] WHERE [DocTreeID] = @pk_DocTreeID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[DocTree]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[DocTree]
            SET 
            [CIX] = @p_CIX,
            [DocTreeParentID] = @p_DocTreeParentID,
            [RoleID] = @p_RoleID,
            [DocIndex] = @p_DocIndex,
            [DocSort] = @p_DocSort,
            [DocName] = @p_DocName,
            [DocDescription] = @p_DocDescription,
            [DocTypeID] = @p_DocTypeID,
            [Folder] = @p_Folder,
            [PrivateFolder] = @p_PrivateFolder,
            [OneActiveCopy] = @p_OneActiveCopy,
            [OnApp] = @p_OnApp,
            [RecordDocDetails] = @p_RecordDocDetails,
            [AlwaysShow] = @p_AlwaysShow,
            [ItemRank] = @p_ItemRank,
            [Hide] = @p_Hide,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [DocTreeID] = @pk_DocTreeID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([DocTreeID],[CIX],[DocTreeParentID],[RoleID],[DocIndex],[DocSort],[DocName],[DocDescription],[DocTypeID],[Folder],[PrivateFolder],[OneActiveCopy],[OnApp],[RecordDocDetails],[AlwaysShow],[ItemRank],[Hide],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[DocTree] with (rowlock, holdlock)
            WHERE [DocTreeID] = @pk_DocTreeID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[DocTree]
                    SET 
                    [CIX] = @p_CIX,
                    [DocTreeParentID] = @p_DocTreeParentID,
                    [RoleID] = @p_RoleID,
                    [DocIndex] = @p_DocIndex,
                    [DocSort] = @p_DocSort,
                    [DocName] = @p_DocName,
                    [DocDescription] = @p_DocDescription,
                    [DocTypeID] = @p_DocTypeID,
                    [Folder] = @p_Folder,
                    [PrivateFolder] = @p_PrivateFolder,
                    [OneActiveCopy] = @p_OneActiveCopy,
                    [OnApp] = @p_OnApp,
                    [RecordDocDetails] = @p_RecordDocDetails,
                    [AlwaysShow] = @p_AlwaysShow,
                    [ItemRank] = @p_ItemRank,
                    [Hide] = @p_Hide,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [DocTreeID] = @pk_DocTreeID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[DocTree]', 16, 1)

        END
END

