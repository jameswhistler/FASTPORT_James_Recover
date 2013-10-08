if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowCollectionUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowCollectionUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[FlowCollection] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTFlowCollectionUpdate
    @pk_FlowCollectionID int,
    @p_FlowID int,
    @p_CollectionName varchar(50),
    @p_CollectionRank int,
    @p_DefaultURLParams varchar(1000),
    @p_GoAction varchar(50),
    @p_StartingStepID int,
    @p_ThreadID int,
    @p_CollectionDescription varchar(2000),
    @p_CollectionImage image,
    @p_CopyFlowCollectionID int,
    @p_RelatedToID int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[FlowCollection] WHERE [FlowCollectionID] = @pk_FlowCollectionID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[FlowCollection]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[FlowCollection]
            SET 
            [FlowID] = @p_FlowID,
            [CollectionName] = @p_CollectionName,
            [CollectionRank] = @p_CollectionRank,
            [DefaultURLParams] = @p_DefaultURLParams,
            [GoAction] = @p_GoAction,
            [StartingStepID] = @p_StartingStepID,
            [ThreadID] = @p_ThreadID,
            [CollectionDescription] = @p_CollectionDescription,
            [CollectionImage] = @p_CollectionImage,
            [CopyFlowCollectionID] = @p_CopyFlowCollectionID,
            [RelatedToID] = @p_RelatedToID
            WHERE [FlowCollectionID] = @pk_FlowCollectionID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([FlowCollectionID],[FlowID],[CollectionName],[CollectionRank],[DefaultURLParams],[GoAction],[StartingStepID],[ThreadID],[CollectionDescription],[CollectionImage],[CopyFlowCollectionID],[RelatedToID]) AS nvarchar(4000)) 
            FROM [dbo].[FlowCollection] with (rowlock, holdlock)
            WHERE [FlowCollectionID] = @pk_FlowCollectionID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[FlowCollection]
                    SET 
                    [FlowID] = @p_FlowID,
                    [CollectionName] = @p_CollectionName,
                    [CollectionRank] = @p_CollectionRank,
                    [DefaultURLParams] = @p_DefaultURLParams,
                    [GoAction] = @p_GoAction,
                    [StartingStepID] = @p_StartingStepID,
                    [ThreadID] = @p_ThreadID,
                    [CollectionDescription] = @p_CollectionDescription,
                    [CollectionImage] = @p_CollectionImage,
                    [CopyFlowCollectionID] = @p_CopyFlowCollectionID,
                    [RelatedToID] = @p_RelatedToID
                    WHERE [FlowCollectionID] = @pk_FlowCollectionID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[FlowCollection]', 16, 1)

        END
END

