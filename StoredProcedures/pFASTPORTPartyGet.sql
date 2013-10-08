if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyGet') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[Party] table.
CREATE PROCEDURE pFASTPORTPartyGet
        @pk_PartyID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[Party]
    WHERE [PartyID] =@pk_PartyID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [PartyID],
        [PartyTypeID],
        [Logo],
        [ProfilePicture],
        [Name],
        [DBA],
        [Title],
        [Handle],
        [Email],
        [Password],
        [Contact],
        [DirectDial],
        [Mobile],
        [Fax],
        [OtherPhone],
        [ShareWithFriends],
        [ShareWithDrivers],
        [ShareWithCarrier],
        [ShareWithCloseBy],
        [ShareWithLikeMe],
        [AllowInvitations],
        [ThreadEmail],
        [ThreadMobileText],
        [ThreadFax],
        [ThreadInstantMessage],
        [ThreadBoardOnly],
        [FullProfile],
        [SignatureFile],
        [InitialsFile],
        [EntityID],
        [SocialSecurityNumber],
        [EINNumber],
        [SMTPPort],
        [SMTPServer],
        [SMTPPassword],
        [EnableSSLYN],
        [FaxCredentials],
        [FaxAccount],
        [FaxPassword],
        [FaxSMTPPort],
        [FaxSMTPServer],
        [FaxEnableSSLYN],
        [RegisteredUserSince],
        [AccountFlowStepID],
        [PayPalToken],
        [StripSearch],
        [StripSearchDBA],
        [OutsideID],
        [CreatedByID],
        [CreatedAt],
        [UpdatedByID],
        [UpdatedAt],
        CAST(BINARY_CHECKSUM([PartyID],[PartyTypeID],[Logo],[ProfilePicture],[Name],[DBA],[Title],[Handle],[Email],[Password],[Contact],[DirectDial],[Mobile],[Fax],[OtherPhone],[ShareWithFriends],[ShareWithDrivers],[ShareWithCarrier],[ShareWithCloseBy],[ShareWithLikeMe],[AllowInvitations],[ThreadEmail],[ThreadMobileText],[ThreadFax],[ThreadInstantMessage],[ThreadBoardOnly],[FullProfile],[SignatureFile],[InitialsFile],[EntityID],[SocialSecurityNumber],[EINNumber],[SMTPPort],[SMTPServer],[SMTPPassword],[EnableSSLYN],[FaxCredentials],[FaxAccount],[FaxPassword],[FaxSMTPPort],[FaxSMTPServer],[FaxEnableSSLYN],[RegisteredUserSince],[AccountFlowStepID],[PayPalToken],[StripSearch],[StripSearchDBA],[OutsideID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) AS IS_CHECKSUM_COLUMN_12345
    FROM [dbo].[Party]
    WHERE [PartyID] =@pk_PartyID
    SET NOCOUNT OFF
END

