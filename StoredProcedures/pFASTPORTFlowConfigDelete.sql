if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowConfigDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowConfigDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[FlowConfig] table.
CREATE PROCEDURE pFASTPORTFlowConfigDelete
        @pk_ConfigID int
AS
BEGIN
    DELETE [dbo].[FlowConfig]
    WHERE [ConfigID] = @pk_ConfigID
END

