if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignLicGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignLicGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


