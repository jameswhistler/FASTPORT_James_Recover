if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_PartyOrgGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_PartyOrgGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_PartyOrg] table.
CREATE PROCEDURE pFASTPORTV_PartyOrgGet
        @pk_AddrID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_PartyOrg]
    WHERE [AddrID] =@pk_AddrID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [AddrID],
        [PartyID],
        [Logo],
        [Company],
        [AddrName],
        [PointOfInterest],
        [ContactInfo],
        [Pins],
        [PinsSmall],
        [PointStats],
        [CityST]
    FROM [dbo].[v_PartyOrg]
    WHERE [AddrID] =@pk_AddrID
    SET NOCOUNT OFF
END

