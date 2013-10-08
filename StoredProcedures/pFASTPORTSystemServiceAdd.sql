if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemServiceAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemServiceAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SystemService] table.
CREATE PROCEDURE pFASTPORTSystemServiceAdd
    @p_ServiceContextID int,
    @p_ServiceTypeID int,
    @p_ServiceName varchar(50),
    @p_ServiceDescription varchar(2000),
    @p_ServiceImageID int,
    @p_ServiceRequired bit,
    @p_Fee money,
    @p_DurationID int,
    @p_Units int,
    @p_ServiceRank int,
    @p_ServiceID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SystemService]
        (
            [ServiceContextID],
            [ServiceTypeID],
            [ServiceName],
            [ServiceDescription],
            [ServiceImageID],
            [Fee],
            [DurationID]
        )
    VALUES
        (
             @p_ServiceContextID,
             @p_ServiceTypeID,
             @p_ServiceName,
             @p_ServiceDescription,
             @p_ServiceImageID,
             @p_Fee,
             @p_DurationID
        )

    SET @p_ServiceID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ServiceRequired IS NOT NULL
        UPDATE [dbo].[SystemService] SET [ServiceRequired] = @p_ServiceRequired WHERE [ServiceID] = @p_ServiceID_out

    IF @p_Units IS NOT NULL
        UPDATE [dbo].[SystemService] SET [Units] = @p_Units WHERE [ServiceID] = @p_ServiceID_out

    IF @p_ServiceRank IS NOT NULL
        UPDATE [dbo].[SystemService] SET [ServiceRank] = @p_ServiceRank WHERE [ServiceID] = @p_ServiceID_out

END

