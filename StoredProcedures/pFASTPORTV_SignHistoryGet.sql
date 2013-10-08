if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignHistoryGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignHistoryGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_SignHistory] table.
CREATE PROCEDURE pFASTPORTV_SignHistoryGet
        @pk_HistoryID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_SignHistory]
    WHERE [HistoryID] =@pk_HistoryID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [HistoryID],
        [PartyID],
        [HistoryHTML],
        [ExpGeneral],
        [ExpEquipment],
        [ExpCargo],
        [ExpRegions],
        [FirstSort],
        [StartDate],
        [EndDate]
    FROM [dbo].[v_SignHistory]
    WHERE [HistoryID] =@pk_HistoryID
    SET NOCOUNT OFF
END

