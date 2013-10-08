if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowButtonDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowButtonDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[FlowButton] table.
CREATE PROCEDURE pFASTPORTFlowButtonDelete
        @pk_ButtonID int
AS
BEGIN
    DELETE [dbo].[FlowButton]
    WHERE [ButtonID] = @pk_ButtonID
END

