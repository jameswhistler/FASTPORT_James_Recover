if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignOwnerGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignOwnerGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_SignOwner] table.
CREATE PROCEDURE pFASTPORTV_SignOwnerGet
        @pk_PartyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_SignOwner]
    WHERE [PartyID] =@pk_PartyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PartyID],
        [O_Name],
        [O_DBA],
        [O_DBAOrName],
        [O_AddrHTML],
        [O_Addr],
        [O_CitySTZip],
        [O_City],
        [O_ST],
        [O_Zip],
        [O_Country],
        [O_SSNorEIN],
        [O_SSN],
        [O_EIN],
        [O_Entity],
        [O_EntitySole],
        [O_EntityCCorp],
        [O_EntitySCorp],
        [O_EntityPartner],
        [O_EntityTrustEstate],
        [O_EntityLLC],
        [O_EntityOther]
    FROM [dbo].[v_SignOwner]
    WHERE [PartyID] =@pk_PartyID
    SET NOCOUNT OFF
END

