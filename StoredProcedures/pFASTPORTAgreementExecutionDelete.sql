if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementExecutionDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementExecutionDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[AgreementExecution] table.
CREATE PROCEDURE pFASTPORTAgreementExecutionDelete
        @pk_ExecutionID int
AS
BEGIN
    DELETE [dbo].[AgreementExecution]
    WHERE [ExecutionID] = @pk_ExecutionID
END

