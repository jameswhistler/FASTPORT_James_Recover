if exists (select * from sysobjects where id = object_id(N'pFASTPORTGlobalAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTGlobalAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Global] table.
CREATE PROCEDURE pFASTPORTGlobalAdd
    @p_GlobalName varchar(50),
    @p_GlobalDescription varchar(255),
    @p_GlobalFile image,
    @p_GlobalValue varchar(max),
    @p_GlobalID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Global]
        (
            [GlobalName],
            [GlobalDescription],
            [GlobalFile],
            [GlobalValue]
        )
    VALUES
        (
             @p_GlobalName,
             @p_GlobalDescription,
             @p_GlobalFile,
             @p_GlobalValue
        )

    SET @p_GlobalID_out = SCOPE_IDENTITY()

END

