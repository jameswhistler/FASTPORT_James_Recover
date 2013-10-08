if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_AddrGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_AddrGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Addr] table.
CREATE PROCEDURE pFASTPORTV_AddrGet
        @pk_AddrID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Addr]
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
        [AddrHTML],
        [TermHTML],
        [SimpleHTML],
        [OneLine],
        [Addr],
        [City],
        [ST],
        [Zip],
        [Country],
        [DeleteDesc],
        [Dates],
        [EditButton],
        [DeleteButton],
        [EditImage],
        [MovedIn],
        [MovedOut],
        [MovedOutOn],
        [Headquarters],
        [AddrName],
        [CitySTZip],
        [CityST]
    FROM [dbo].[v_Addr]
    WHERE [AddrID] =@pk_AddrID
    SET NOCOUNT OFF
END

