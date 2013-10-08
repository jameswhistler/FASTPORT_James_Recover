if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadInstanceAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadInstanceAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ThreadInstance] table.
CREATE PROCEDURE pFASTPORTThreadInstanceAdd
    @p_CIX int,
    @p_ThreadID int,
    @p_HostID int,
    @p_ResponsibleID int,
    @p_FlowStepID int,
    @p_ThreadPriorityID int,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_InstanceID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[ThreadInstance]
        (
            [CIX],
            [ThreadID],
            [HostID],
            [ResponsibleID],
            [FlowStepID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_CIX,
             @p_ThreadID,
             @p_HostID,
             @p_ResponsibleID,
             @p_FlowStepID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_InstanceID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_ThreadPriorityID IS NOT NULL
        UPDATE [dbo].[ThreadInstance] SET [ThreadPriorityID] = @p_ThreadPriorityID WHERE [InstanceID] = @p_InstanceID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstance] SET [CreatedAt] = @p_CreatedAt WHERE [InstanceID] = @p_InstanceID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[ThreadInstance] SET [UpdatedAt] = @p_UpdatedAt WHERE [InstanceID] = @p_InstanceID_out

END

