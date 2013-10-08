if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowStepUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowStepUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[FlowStep] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTFlowStepUpdate
    @pk_FlowStepID int,
    @p_FlowCollectionID int,
    @p_OverviewID int,
    @p_StepRank int,
    @p_RefName varchar(50),
    @p_FlowStatus varchar(50),
    @p_ReturnedDocStep bit,
    @p_DisableStep bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_CopyFlowStepID int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[FlowStep] WHERE [FlowStepID] = @pk_FlowStepID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[FlowStep]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[FlowStep]
            SET 
            [FlowCollectionID] = @p_FlowCollectionID,
            [OverviewID] = @p_OverviewID,
            [StepRank] = @p_StepRank,
            [RefName] = @p_RefName,
            [FlowStatus] = @p_FlowStatus,
            [ReturnedDocStep] = @p_ReturnedDocStep,
            [DisableStep] = @p_DisableStep,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt,
            [CopyFlowStepID] = @p_CopyFlowStepID
            WHERE [FlowStepID] = @pk_FlowStepID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([FlowStepID],[FlowCollectionID],[OverviewID],[StepRank],[RefName],[FlowStatus],[ReturnedDocStep],[DisableStep],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[CopyFlowStepID]) AS nvarchar(4000)) 
            FROM [dbo].[FlowStep] with (rowlock, holdlock)
            WHERE [FlowStepID] = @pk_FlowStepID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[FlowStep]
                    SET 
                    [FlowCollectionID] = @p_FlowCollectionID,
                    [OverviewID] = @p_OverviewID,
                    [StepRank] = @p_StepRank,
                    [RefName] = @p_RefName,
                    [FlowStatus] = @p_FlowStatus,
                    [ReturnedDocStep] = @p_ReturnedDocStep,
                    [DisableStep] = @p_DisableStep,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt,
                    [CopyFlowStepID] = @p_CopyFlowStepID
                    WHERE [FlowStepID] = @pk_FlowStepID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[FlowStep]', 16, 1)

        END
END

