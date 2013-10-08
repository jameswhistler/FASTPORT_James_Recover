if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobLogAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobLogAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SystemJobLog] table.
CREATE PROCEDURE pFASTPORTSystemJobLogAdd
    @p_JobID int,
    @p_JobStarted datetime,
    @p_JobCompleted datetime,
    @p_LogMessage varchar(max),
    @p_JobLogID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SystemJobLog]
        (
            [JobID],
            [JobStarted],
            [JobCompleted],
            [LogMessage]
        )
    VALUES
        (
             @p_JobID,
             @p_JobStarted,
             @p_JobCompleted,
             @p_LogMessage
        )

    SET @p_JobLogID_out = SCOPE_IDENTITY()

END

