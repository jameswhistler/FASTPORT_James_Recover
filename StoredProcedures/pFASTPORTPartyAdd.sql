if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[Party] table.
CREATE PROCEDURE pFASTPORTPartyAdd
    @p_PartyTypeID int,
    @p_Logo image,
    @p_ProfilePicture image,
    @p_Name varchar(1000),
    @p_DBA varchar(1000),
    @p_Title varchar(150),
    @p_Handle varchar(50),
    @p_Email varchar(100),
    @p_Password varchar(50),
    @p_Contact varchar(1000),
    @p_DirectDial varchar(50),
    @p_Mobile varchar(50),
    @p_Fax varchar(50),
    @p_OtherPhone varchar(50),
    @p_ShareWithFriends bit,
    @p_ShareWithDrivers bit,
    @p_ShareWithCarrier bit,
    @p_ShareWithCloseBy bit,
    @p_ShareWithLikeMe bit,
    @p_AllowInvitations bit,
    @p_ThreadEmail bit,
    @p_ThreadMobileText bit,
    @p_ThreadFax bit,
    @p_ThreadInstantMessage bit,
    @p_ThreadBoardOnly bit,
    @p_FullProfile varchar(max),
    @p_SignatureFile image,
    @p_InitialsFile image,
    @p_EntityID int,
    @p_SocialSecurityNumber varchar(50),
    @p_EINNumber varchar(50),
    @p_SMTPPort int,
    @p_SMTPServer varchar(50),
    @p_SMTPPassword varchar(50),
    @p_EnableSSLYN int,
    @p_FaxCredentials varchar(50),
    @p_FaxAccount varchar(50),
    @p_FaxPassword varchar(50),
    @p_FaxSMTPPort int,
    @p_FaxSMTPServer varchar(50),
    @p_FaxEnableSSLYN int,
    @p_RegisteredUserSince datetime,
    @p_AccountFlowStepID int,
    @p_PayPalToken varchar(100),
    @p_StripSearch varchar(50),
    @p_StripSearchDBA varchar(50),
    @p_OutsideID varchar(50),
    @p_CreatedByID int,
    @p_CreatedAt datetime,
    @p_UpdatedByID int,
    @p_UpdatedAt datetime,
    @p_PartyID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[Party]
        (
            [PartyTypeID],
            [Logo],
            [ProfilePicture],
            [Name],
            [DBA],
            [Title],
            [Handle],
            [Email],
            [Contact],
            [DirectDial],
            [Mobile],
            [Fax],
            [OtherPhone],
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
            [AccountFlowStepID],
            [PayPalToken],
            [StripSearch],
            [StripSearchDBA],
            [OutsideID],
            [CreatedByID],
            [UpdatedByID]
        )
    VALUES
        (
             @p_PartyTypeID,
             @p_Logo,
             @p_ProfilePicture,
             @p_Name,
             @p_DBA,
             @p_Title,
             @p_Handle,
             @p_Email,
             @p_Contact,
             @p_DirectDial,
             @p_Mobile,
             @p_Fax,
             @p_OtherPhone,
             @p_FullProfile,
             @p_SignatureFile,
             @p_InitialsFile,
             @p_EntityID,
             @p_SocialSecurityNumber,
             @p_EINNumber,
             @p_SMTPPort,
             @p_SMTPServer,
             @p_SMTPPassword,
             @p_EnableSSLYN,
             @p_FaxCredentials,
             @p_FaxAccount,
             @p_FaxPassword,
             @p_FaxSMTPPort,
             @p_FaxSMTPServer,
             @p_FaxEnableSSLYN,
             @p_AccountFlowStepID,
             @p_PayPalToken,
             @p_StripSearch,
             @p_StripSearchDBA,
             @p_OutsideID,
             @p_CreatedByID,
             @p_UpdatedByID
        )

    SET @p_PartyID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_Password IS NOT NULL
        UPDATE [dbo].[Party] SET [Password] = @p_Password WHERE [PartyID] = @p_PartyID_out

    IF @p_ShareWithFriends IS NOT NULL
        UPDATE [dbo].[Party] SET [ShareWithFriends] = @p_ShareWithFriends WHERE [PartyID] = @p_PartyID_out

    IF @p_ShareWithDrivers IS NOT NULL
        UPDATE [dbo].[Party] SET [ShareWithDrivers] = @p_ShareWithDrivers WHERE [PartyID] = @p_PartyID_out

    IF @p_ShareWithCarrier IS NOT NULL
        UPDATE [dbo].[Party] SET [ShareWithCarrier] = @p_ShareWithCarrier WHERE [PartyID] = @p_PartyID_out

    IF @p_ShareWithCloseBy IS NOT NULL
        UPDATE [dbo].[Party] SET [ShareWithCloseBy] = @p_ShareWithCloseBy WHERE [PartyID] = @p_PartyID_out

    IF @p_ShareWithLikeMe IS NOT NULL
        UPDATE [dbo].[Party] SET [ShareWithLikeMe] = @p_ShareWithLikeMe WHERE [PartyID] = @p_PartyID_out

    IF @p_AllowInvitations IS NOT NULL
        UPDATE [dbo].[Party] SET [AllowInvitations] = @p_AllowInvitations WHERE [PartyID] = @p_PartyID_out

    IF @p_ThreadEmail IS NOT NULL
        UPDATE [dbo].[Party] SET [ThreadEmail] = @p_ThreadEmail WHERE [PartyID] = @p_PartyID_out

    IF @p_ThreadMobileText IS NOT NULL
        UPDATE [dbo].[Party] SET [ThreadMobileText] = @p_ThreadMobileText WHERE [PartyID] = @p_PartyID_out

    IF @p_ThreadFax IS NOT NULL
        UPDATE [dbo].[Party] SET [ThreadFax] = @p_ThreadFax WHERE [PartyID] = @p_PartyID_out

    IF @p_ThreadInstantMessage IS NOT NULL
        UPDATE [dbo].[Party] SET [ThreadInstantMessage] = @p_ThreadInstantMessage WHERE [PartyID] = @p_PartyID_out

    IF @p_ThreadBoardOnly IS NOT NULL
        UPDATE [dbo].[Party] SET [ThreadBoardOnly] = @p_ThreadBoardOnly WHERE [PartyID] = @p_PartyID_out

    IF @p_RegisteredUserSince IS NOT NULL
        UPDATE [dbo].[Party] SET [RegisteredUserSince] = @p_RegisteredUserSince WHERE [PartyID] = @p_PartyID_out

    IF @p_CreatedAt IS NOT NULL
        UPDATE [dbo].[Party] SET [CreatedAt] = @p_CreatedAt WHERE [PartyID] = @p_PartyID_out

    IF @p_UpdatedAt IS NOT NULL
        UPDATE [dbo].[Party] SET [UpdatedAt] = @p_UpdatedAt WHERE [PartyID] = @p_PartyID_out

END

