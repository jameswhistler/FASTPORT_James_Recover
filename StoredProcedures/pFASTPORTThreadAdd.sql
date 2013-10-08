if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Thread] table.
CREATE PROCEDURE pFASTPORTThreadAdd
    @p_ThreadTreeID int,
    @p_ThreadTypeID int,
    @p_ThreadName varchar(50),
    @p_FlowCollectionID int,
    @p_RelationTypeID int,
    @p_FirstSubject varchar(50),
    @p_FirstAction varchar(2000),
    @p_FirstButtonText varchar(255),
    @p_NoRadWindow bit,
    @p_GoAction varchar(50),
    @p_FirstButtonPage varchar(255),
    @p_FirstBody varchar(4000),
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_ThreadID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Thread]
        (
            [ThreadTreeID],
            [ThreadTypeID],
            [ThreadName],
            [FlowCollectionID],
            [RelationTypeID],
            [FirstSubject],
            [FirstAction],
            [FirstButtonText],
            [GoAction],
            [FirstButtonPage],
            [FirstBody],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_ThreadTreeID,
             @p_ThreadTypeID,
             @p_ThreadName,
             @p_FlowCollectionID,
             @p_RelationTypeID,
             @p_FirstSubject,
             @p_FirstAction,
             @p_FirstButtonText,
             @p_GoAction,
             @p_FirstButtonPage,
             @p_FirstBody,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_ThreadID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_NoRadWindow IS NOT NULL
        UPDATE [dbo].[Thread] SET [NoRadWindow] = @p_NoRadWindow WHERE [ThreadID] = @p_ThreadID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Thread] SET [CreatedAt] = @p_CreatedAt WHERE [ThreadID] = @p_ThreadID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[Thread] SET [UpdatedAt] = @p_UpdatedAt WHERE [ThreadID] = @p_ThreadID_out

END

