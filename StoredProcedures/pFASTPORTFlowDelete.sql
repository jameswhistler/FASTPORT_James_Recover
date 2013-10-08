if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Flow] table.
CREATE PROCEDURE pFASTPORTFlowDelete
        @pk_FlowID int
AS
BEGIN
    DELETE [dbo].[Flow]
    WHERE [FlowID] = @pk_FlowID
END

