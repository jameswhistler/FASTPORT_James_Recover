if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CarrierSimpleGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CarrierSimpleGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_CarrierSimple] table.
CREATE PROCEDURE pFASTPORTV_CarrierSimpleGet
        @pk_CarrierID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_CarrierSimple]
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
        [Logo],
        [MajorStickers],
        [MinorStickers],
        [Carrier],
        [CarrierHTML],
        [CarrierProfile],
        [ShortStats],
        [GeneralStats],
        [Name],
        [MCNumber],
        [DOTNumber],
        [StripSearch]
    FROM [dbo].[v_CarrierSimple]
    WHERE [CarrierID] =@pk_CarrierID
    SET NOCOUNT OFF
END

