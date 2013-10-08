if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemServiceUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemServiceUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[SystemService] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTSystemServiceUpdate
    @pk_ServiceID int,
    @p_ServiceContextID int,
    @p_ServiceTypeID int,
    @p_ServiceName varchar(50),
    @p_ServiceDescription varchar(2000),
    @p_ServiceImageID int,
    @p_ServiceRequired bit,
    @p_Fee money,
    @p_DurationID int,
    @p_Units int,
    @p_ServiceRank int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[SystemService] WHERE [ServiceID] = @pk_ServiceID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[SystemService]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[SystemService]
            SET 
            [ServiceContextID] = @p_ServiceContextID,
            [ServiceTypeID] = @p_ServiceTypeID,
            [ServiceName] = @p_ServiceName,
            [ServiceDescription] = @p_ServiceDescription,
            [ServiceImageID] = @p_ServiceImageID,
            [ServiceRequired] = @p_ServiceRequired,
            [Fee] = @p_Fee,
            [DurationID] = @p_DurationID,
            [Units] = @p_Units,
            [ServiceRank] = @p_ServiceRank
            WHERE [ServiceID] = @pk_ServiceID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ServiceID],[ServiceContextID],[ServiceTypeID],[ServiceName],[ServiceDescription],[ServiceImageID],[ServiceRequired],[Fee],[DurationID],[Units],[ServiceRank]) AS nvarchar(4000)) 
            FROM [dbo].[SystemService] with (rowlock, holdlock)
            WHERE [ServiceID] = @pk_ServiceID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[SystemService]
                    SET 
                    [ServiceContextID] = @p_ServiceContextID,
                    [ServiceTypeID] = @p_ServiceTypeID,
                    [ServiceName] = @p_ServiceName,
                    [ServiceDescription] = @p_ServiceDescription,
                    [ServiceImageID] = @p_ServiceImageID,
                    [ServiceRequired] = @p_ServiceRequired,
                    [Fee] = @p_Fee,
                    [DurationID] = @p_DurationID,
                    [Units] = @p_Units,
                    [ServiceRank] = @p_ServiceRank
                    WHERE [ServiceID] = @pk_ServiceID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[SystemService]', 16, 1)

        END
END

