if exists (select * from sysobjects where id = object_id(N'pFASTPORTRefAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTRefAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Ref] table.
CREATE PROCEDURE pFASTPORTRefAdd
    @p_RefTypeID int,
    @p_Ref varchar(50),
    @p_OrdID int,
    @p_PartyID int,
    @p_PartyUserID int,
    @p_DocID int,
    @p_IssuedAt datetime,
    @p_ExpiresOn datetime,
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_RefID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Ref]
        (
            [RefTypeID],
            [Ref],
            [OrdID],
            [PartyID],
            [PartyUserID],
            [DocID],
            [IssuedAt],
            [ExpiresOn],
            [CreatedByID],
            [CreatedAt],
            [UpdatedByID],
            [UpdatedAt]
        )
    VALUES
        (
             @p_RefTypeID,
             @p_Ref,
             @p_OrdID,
             @p_PartyID,
             @p_PartyUserID,
             @p_DocID,
             @p_IssuedAt,
             @p_ExpiresOn,
             @p_CreatedByID,
             @p_CreatedAt,
             @p_UpdatedByID,
             @p_UpdatedAt
        )

    SET @p_RefID_out = SCOPE_IDENTITY()

END

