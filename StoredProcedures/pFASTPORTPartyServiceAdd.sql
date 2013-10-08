if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyServiceAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyServiceAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyService] table.
CREATE PROCEDURE pFASTPORTPartyServiceAdd
    @p_PartyID int,
    @p_ForPartyID int,
    @p_ServiceID int,
    @p_StartDate datetime,
    @p_MarkedForCancellation bit,
    @p_EndDate datetime,
    @p_InstanceID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PartyServiceID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyService]
        (
            [PartyID],
            [ForPartyID],
            [ServiceID],
            [StartDate],
            [EndDate],
            [InstanceID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyID,
             @p_ForPartyID,
             @p_ServiceID,
             @p_StartDate,
             @p_EndDate,
             @p_InstanceID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_PartyServiceID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_MarkedForCancellation IS NOT NULL
        UPDATE [dbo].[PartyService] SET [MarkedForCancellation] = @p_MarkedForCancellation WHERE [PartyServiceID] = @p_PartyServiceID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyService] SET [CreatedAt] = @p_CreatedAt WHERE [PartyServiceID] = @p_PartyServiceID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyService] SET [UpdatedAt] = @p_UpdatedAt WHERE [PartyServiceID] = @p_PartyServiceID_out

END

