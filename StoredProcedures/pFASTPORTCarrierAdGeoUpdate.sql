if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdGeoUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdGeoUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CarrierAdGeo] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCarrierAdGeoUpdate
    @pk_AdGeoID int,
    @p_AdID int,
    @p_AdGeoTypeID int,
    @p_OriginCityID int,
    @p_OriginRadius int,
    @p_DestRadius int,
    @p_AdGeoNotes varchar(2000),
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[CarrierAdGeo] WHERE [AdGeoID] = @pk_AdGeoID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CarrierAdGeo]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CarrierAdGeo]
            SET 
            [AdID] = @p_AdID,
            [AdGeoTypeID] = @p_AdGeoTypeID,
            [OriginCityID] = @p_OriginCityID,
            [OriginRadius] = @p_OriginRadius,
            [DestRadius] = @p_DestRadius,
            [AdGeoNotes] = @p_AdGeoNotes
            WHERE [AdGeoID] = @pk_AdGeoID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AdGeoID],[AdID],[AdGeoTypeID],[OriginCityID],[OriginRadius],[DestRadius],[AdGeoNotes]) AS nvarchar(4000)) 
            FROM [dbo].[CarrierAdGeo] with (rowlock, holdlock)
            WHERE [AdGeoID] = @pk_AdGeoID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CarrierAdGeo]
                    SET 
                    [AdID] = @p_AdID,
                    [AdGeoTypeID] = @p_AdGeoTypeID,
                    [OriginCityID] = @p_OriginCityID,
                    [OriginRadius] = @p_OriginRadius,
                    [DestRadius] = @p_DestRadius,
                    [AdGeoNotes] = @p_AdGeoNotes
                    WHERE [AdGeoID] = @pk_AdGeoID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CarrierAdGeo]', 16, 1)

        END
END

