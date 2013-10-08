if exists (select * from sysobjects where id = object_id(N'pFASTPORTThreadDefaultReceiverDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTThreadDefaultReceiverDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[ThreadDefaultReceiver] table.
CREATE PROCEDURE pFASTPORTThreadDefaultReceiverDelete
        @pk_DefaultReceiverID int
AS
BEGIN
    DELETE [dbo].[ThreadDefaultReceiver]
    WHERE [DefaultReceiverID] = @pk_DefaultReceiverID
END

