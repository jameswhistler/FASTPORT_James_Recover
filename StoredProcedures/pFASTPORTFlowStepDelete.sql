if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowStepDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowStepDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[FlowStep] table.
CREATE PROCEDURE pFASTPORTFlowStepDelete
        @pk_FlowStepID int
AS
BEGIN
    DELETE [dbo].[FlowStep]
    WHERE [FlowStepID] = @pk_FlowStepID
END

