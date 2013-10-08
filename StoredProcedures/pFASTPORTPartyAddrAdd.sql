if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyAddrAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyAddrAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyAddr] table.
CREATE PROCEDURE pFASTPORTPartyAddrAdd
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
    @p_AddrID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyAddr]
        (
            [PartyID],
            [AddrName],
            [Addr],
            [Addr2],
            [AddrZipID],
            [DirectDail],
            [OtherPhone],
            [Fax],
            [Email],
            [Website],
            [Directions],
            [Lat],
            [Long],
            [MovedIn],
            [MovedOutOn],
            [FuelTypeID],
            [OutsideID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyID,
             @p_AddrName,
             @p_Addr,
             @p_Addr2,
             @p_AddrZipID,
             @p_DirectDail,
             @p_OtherPhone,
             @p_Fax,
             @p_Email,
             @p_Website,
             @p_Directions,
             @p_Lat,
             @p_Long,
             @p_MovedIn,
             @p_MovedOutOn,
             @p_FuelTypeID,
             @p_OutsideID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_AddrID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_CountryID IS NOT NULL
        UPDATE [dbo].[PartyAddr] SET [CountryID] = @p_CountryID WHERE [AddrID] = @p_AddrID_out

    IF @p_Headquarters IS NOT NULL
        UPDATE [dbo].[PartyAddr] SET [Headquarters] = @p_Headquarters WHERE [AddrID] = @p_AddrID_out

    IF @p_MovedOut IS NOT NULL
        UPDATE [dbo].[PartyAddr] SET [MovedOut] = @p_MovedOut WHERE [AddrID] = @p_AddrID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyAddr] SET [CreatedAt] = @p_CreatedAt WHERE [AddrID] = @p_AddrID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyAddr] SET [UpdatedAt] = @p_UpdatedAt WHERE [AddrID] = @p_AddrID_out

END

