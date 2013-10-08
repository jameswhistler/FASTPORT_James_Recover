if exists (select * from sysobjects where id = object_id(N'pFASTPORTAgreementDelete') and sysstat & 0xf = 4) drop procedure pFASTPORTAgreementDelete 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Deletes a record from the [dbo].[Agreement] table.
CREATE PROCEDURE pFASTPORTAgreementDelete
        @pk_AgreementID int
AS
BEGIN
    DELETE [dbo].[Agreement]
    WHERE [AgreementID] = @pk_AgreementID
END

