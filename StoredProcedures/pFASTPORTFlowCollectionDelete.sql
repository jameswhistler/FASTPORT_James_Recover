if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowCollectionDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowCollectionDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[FlowCollection] table.
CREATE PROCEDURE pFASTPORTFlowCollectionDelete
        @pk_FlowCollectionID int
AS
BEGIN
    DELETE [dbo].[FlowCollection]
    WHERE [FlowCollectionID] = @pk_FlowCollectionID
END

