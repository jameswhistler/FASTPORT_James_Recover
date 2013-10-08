if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyCarrierGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyCarrierGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[PartyCarrier] table.
CREATE PROCEDURE pFASTPORTPartyCarrierGet
        @pk_CarrierID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[PartyCarrier]
    WHERE [CarrierID] =@pk_CarrierID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [CarrierID],
        [PartyID],
        [CarrierFullName],
        [DOTNumber],
        [MCNumber],
        [Drivers],
        [Certified],
        [PayCertified],
        CAST(BINARY_CHECKSUM([CarrierID],[PartyID],[CarrierFullName],[DOTNumber],[MCNumber],[Drivers],[Certified],[PayCertified]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[PartyCarrier]
    WHERE [CarrierID] =@pk_CarrierID
    SET NOCOUNT OFF
END

