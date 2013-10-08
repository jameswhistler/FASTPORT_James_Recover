if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowCollectionAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowCollectionAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[FlowCollection] table.
CREATE PROCEDURE pFASTPORTFlowCollectionAdd
    @p_FlowID int,
    @p_CollectionName varchar(50),
    @p_CollectionRank int,
    @p_DefaultURLParams varchar(1000),
    @p_GoAction varchar(50),
    @p_StartingStepID int,
    @p_ThreadID int,
    @p_CollectionDescription varchar(2000),
    @p_CollectionImage image,
    @p_CopyFlowCollectionID int,
    @p_RelatedToID int,
    @p_FlowCollectionID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[FlowCollection]
        (
            [FlowID],
            [CollectionName],
            [CollectionRank],
            [DefaultURLParams],
            [GoAction],
            [StartingStepID],
            [ThreadID],
            [CollectionDescription],
            [CollectionImage],
            [CopyFlowCollectionID],
            [RelatedToID]
        )
    VALUES
        (
             @p_FlowID,
             @p_CollectionName,
             @p_CollectionRank,
             @p_DefaultURLParams,
             @p_GoAction,
             @p_StartingStepID,
             @p_ThreadID,
             @p_CollectionDescription,
             @p_CollectionImage,
             @p_CopyFlowCollectionID,
             @p_RelatedToID
        )

    SET @p_FlowCollectionID_out = SCOPE_IDENTITY()

END

