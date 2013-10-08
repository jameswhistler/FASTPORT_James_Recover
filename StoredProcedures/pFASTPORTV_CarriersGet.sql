if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CarriersGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CarriersGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Carriers] table.
CREATE PROCEDURE pFASTPORTV_CarriersGet
        @pk_PK varchar(60)
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Carriers]
    WHERE [PK] =@pk_PK

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PK],
        [AddrID],
        [PartyID],
        [Logo],
        [Carrier],
        [CarrierHTML],
        [CarrierNos],
        [Name],
        [CarrierName],
        [CarrierDBA],
        [AddrName],
        [Addr],
        [Addr2],
        [AddrZipID],
        [CitySTZip],
        [MCNumber],
        [DOTNumber],
        [StripSearch],
        [StripSearchDBA],
        [Lat],
        [Long]
    FROM [dbo].[v_Carriers]
    WHERE [PK] =@pk_PK
    SET NOCOUNT OFF
END

