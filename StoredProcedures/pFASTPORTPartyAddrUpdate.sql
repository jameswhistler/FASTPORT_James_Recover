if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyAddrUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyAddrUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[PartyAddr] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyAddrUpdate
    @pk_AddrID int,
    @p_PartyID int,
    @p_AddrName varchar(150),
    @p_Addr varchar(500),
    @p_Addr2 varchar(500),
    @p_AddrZipID int,
    @p_CountryID int,
    @p_Headquarters bit,
    @p_DirectDail varchar(50),
    @p_OtherPhone varchar(50),
    @p_Fax varchar(50),
    @p_Email varchar(100),
    @p_Website varchar(50),
    @p_Directions varchar(4000),
    @p_Lat float,
    @p_Long float,
    @p_MovedIn datetime,
    @p_MovedOut bit,
    @p_MovedOutOn datetime,
    @p_FuelTypeID int,
    @p_OutsideID varchar(50),
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
    IF NOT EXISTS (SELECT * FROM [dbo].[PartyAddr] WHERE [AddrID] = @pk_AddrID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[PartyAddr]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[PartyAddr]
            SET 
            [PartyID] = @p_PartyID,
            [AddrName] = @p_AddrName,
            [Addr] = @p_Addr,
            [Addr2] = @p_Addr2,
            [AddrZipID] = @p_AddrZipID,
            [CountryID] = @p_CountryID,
            [Headquarters] = @p_Headquarters,
            [DirectDail] = @p_DirectDail,
            [OtherPhone] = @p_OtherPhone,
            [Fax] = @p_Fax,
            [Email] = @p_Email,
            [Website] = @p_Website,
            [Directions] = @p_Directions,
            [Lat] = @p_Lat,
            [Long] = @p_Long,
            [MovedIn] = @p_MovedIn,
            [MovedOut] = @p_MovedOut,
            [MovedOutOn] = @p_MovedOutOn,
            [FuelTypeID] = @p_FuelTypeID,
            [OutsideID] = @p_OutsideID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [AddrID] = @pk_AddrID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([AddrID],[PartyID],[AddrName],[Addr],[Addr2],[AddrZipID],[CountryID],[Headquarters],[DirectDail],[OtherPhone],[Fax],[Email],[Website],[Directions],[Lat],[Long],[MovedIn],[MovedOut],[MovedOutOn],[FuelTypeID],[OutsideID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[PartyAddr] with (rowlock, holdlock)
            WHERE [AddrID] = @pk_AddrID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[PartyAddr]
                    SET 
                    [PartyID] = @p_PartyID,
                    [AddrName] = @p_AddrName,
                    [Addr] = @p_Addr,
                    [Addr2] = @p_Addr2,
                    [AddrZipID] = @p_AddrZipID,
                    [CountryID] = @p_CountryID,
                    [Headquarters] = @p_Headquarters,
                    [DirectDail] = @p_DirectDail,
                    [OtherPhone] = @p_OtherPhone,
                    [Fax] = @p_Fax,
                    [Email] = @p_Email,
                    [Website] = @p_Website,
                    [Directions] = @p_Directions,
                    [Lat] = @p_Lat,
                    [Long] = @p_Long,
                    [MovedIn] = @p_MovedIn,
                    [MovedOut] = @p_MovedOut,
                    [MovedOutOn] = @p_MovedOutOn,
                    [FuelTypeID] = @p_FuelTypeID,
                    [OutsideID] = @p_OutsideID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [AddrID] = @pk_AddrID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[PartyAddr]', 16, 1)

        END
END

