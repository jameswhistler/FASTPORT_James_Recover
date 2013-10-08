if exists (select * from sysobjects where id = object_id(N'pFASTPORTSystemJobAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTSystemJobAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SystemJob] table.
CREATE PROCEDURE pFASTPORTSystemJobAdd
    @p_SprocName varchar(255),
    @p_HourToRun time,
    @p_Param1 varchar(255),
    @p_Param2 varchar(255),
    @p_Param3 varchar(255),
    @p_Param4 varchar(255),
    @p_Param5 varchar(255),
    @p_Param6 varchar(255),
    @p_JobID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SystemJob]
        (
            [SprocName],
            [HourToRun],
            [Param1],
            [Param2],
            [Param3],
            [Param4],
            [Param5],
            [Param6]
        )
    VALUES
        (
             @p_SprocName,
             @p_HourToRun,
             @p_Param1,
             @p_Param2,
             @p_Param3,
             @p_Param4,
             @p_Param5,
             @p_Param6
        )

    SET @p_JobID_out = SCOPE_IDENTITY()

END

