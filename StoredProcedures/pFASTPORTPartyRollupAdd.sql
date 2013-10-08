if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyRollupAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyRollupAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[PartyRollup] table.
CREATE PROCEDURE pFASTPORTPartyRollupAdd
    @p_ParentID int,
    @p_ChildID int,
    @p_FlowStepID int,
    @p_StartDate datetime,
    @p_EndDate datetime,
    @p_DefaultParty bit,
    @p_DefaultSigner bit,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_RollupID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[PartyRollup]
        (
            [ParentID],
            [ChildID],
            [FlowStepID],
            [StartDate],
            [EndDate],
            [DefaultSigner],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_ParentID,
             @p_ChildID,
             @p_FlowStepID,
             @p_StartDate,
             @p_EndDate,
             @p_DefaultSigner,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_RollupID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_DefaultParty IS NOT NULL
        UPDATE [dbo].[PartyRollup] SET [DefaultParty] = @p_DefaultParty WHERE [RollupID] = @p_RollupID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[PartyRollup] SET [CreatedAt] = @p_CreatedAt WHERE [RollupID] = @p_RollupID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[PartyRollup] SET [UpdatedAt] = @p_UpdatedAt WHERE [RollupID] = @p_RollupID_out

END

