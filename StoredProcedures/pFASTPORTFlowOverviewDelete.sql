if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowOverviewDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowOverviewDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[FlowOverview] table.
CREATE PROCEDURE pFASTPORTFlowOverviewDelete
        @pk_OverviewID int
AS
BEGIN
    DELETE [dbo].[FlowOverview]
    WHERE [OverviewID] = @pk_OverviewID
END

