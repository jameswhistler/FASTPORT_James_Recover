if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CaseTreeDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CaseTreeDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[v_CaseTree] table.
CREATE PROCEDURE pFASTPORTV_CaseTreeDelete
        @pk_UseCaseID int
AS
BEGIN
    DELETE [dbo].[v_CaseTree]
    WHERE [UseCaseID] = @pk_UseCaseID
END

