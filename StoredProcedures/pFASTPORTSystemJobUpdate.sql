if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SystemJob] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTSystemJobUpdate
    @pk_JobID int,
    @p_SprocName varchar(255),
    @p_HourToRun time,
    @p_Param1 varchar(255),
    @p_Param2 varchar(255),
    @p_Param3 varchar(255),
    @p_Param4 varchar(255),
    @p_Param5 varchar(255),
    @p_Param6 varchar(255),
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SystemJob] WHERE [JobID] = @pk_JobID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SystemJob]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SystemJob]
            SET 
            [SprocName] = @p_SprocName,
            [HourToRun] = @p_HourToRun,
            [Param1] = @p_Param1,
            [Param2] = @p_Param2,
            [Param3] = @p_Param3,
            [Param4] = @p_Param4,
            [Param5] = @p_Param5,
            [Param6] = @p_Param6
            WHERE [JobID] = @pk_JobID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([JobID],[SprocName],[HourToRun],[Param1],[Param2],[Param3],[Param4],[Param5],[Param6]) AS nvarchar(4000)) 
            FROM [dbo].[SystemJob] with (rowlock, holdlock)
            WHERE [JobID] = @pk_JobID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SystemJob]
                    SET 
                    [SprocName] = @p_SprocName,
                    [HourToRun] = @p_HourToRun,
                    [Param1] = @p_Param1,
                    [Param2] = @p_Param2,
                    [Param3] = @p_Param3,
                    [Param4] = @p_Param4,
                    [Param5] = @p_Param5,
                    [Param6] = @p_Param6
                    WHERE [JobID] = @pk_JobID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SystemJob]', 16, 1)

        END
END

