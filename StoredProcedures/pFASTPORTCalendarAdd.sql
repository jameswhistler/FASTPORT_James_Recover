if exists (select * from sysobjects where id = object_id(N'pFASTPORTCalendarAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTCalendarAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Calendar] table.
CREATE PROCEDURE pFASTPORTCalendarAdd
    @p_CalType varchar(50),
    @p_CalDate datetime,
    @p_CountryID int,
    @p_Holiday nvarchar(50),
    @p_HolType nvarchar(50),
    @p_CalID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Calendar]
        (
            [CalType],
            [CalDate],
            [CountryID],
            [Holiday],
            [HolType]
        )
    VALUES
        (
             @p_CalType,
             @p_CalDate,
             @p_CountryID,
             @p_Holiday,
             @p_HolType
        )

    SET @p_CalID_out = SCOPE_IDENTITY()

END

