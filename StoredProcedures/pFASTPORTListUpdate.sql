if exists (select * from sysobjects where id = object_id(N'pFASTPORTListUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTListUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[List] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTListUpdate
    @pk_ListID int,
    @p_ListType varchar(50),
    @p_ListName varchar(50),
    @p_ListRank int,
    @p_ListValue int,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[List] WHERE [ListID] = @pk_ListID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[List]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[List]
            SET 
            [ListType] = @p_ListType,
            [ListName] = @p_ListName,
            [ListRank] = @p_ListRank,
            [ListValue] = @p_ListValue
            WHERE [ListID] = @pk_ListID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([ListID],[ListType],[ListName],[ListRank],[ListValue]) AS nvarchar(4000)) 
            FROM [dbo].[List] with (rowlock, holdlock)
            WHERE [ListID] = @pk_ListID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[List]
                    SET 
                    [ListType] = @p_ListType,
                    [ListName] = @p_ListName,
                    [ListRank] = @p_ListRank,
                    [ListValue] = @p_ListValue
                    WHERE [ListID] = @pk_ListID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[List]', 16, 1)

        END
END

