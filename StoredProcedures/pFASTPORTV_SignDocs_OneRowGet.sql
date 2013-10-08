if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignDocs_OneRowGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignDocs_OneRowGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


