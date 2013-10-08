if exists (select * from sysobjects where id = object_id(N'pFASTPORTPartyUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTPartyUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Party] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTPartyUpdate
    @pk_PartyID int,
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
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Party] WHERE [PartyID] = @pk_PartyID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Party]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Party]
            SET 
            [PartyTypeID] = @p_PartyTypeID,
            [Logo] = @p_Logo,
            [ProfilePicture] = @p_ProfilePicture,
            [Name] = @p_Name,
            [DBA] = @p_DBA,
            [Title] = @p_Title,
            [Handle] = @p_Handle,
            [Email] = @p_Email,
            [Password] = @p_Password,
            [Contact] = @p_Contact,
            [DirectDial] = @p_DirectDial,
            [Mobile] = @p_Mobile,
            [Fax] = @p_Fax,
            [OtherPhone] = @p_OtherPhone,
            [ShareWithFriends] = @p_ShareWithFriends,
            [ShareWithDrivers] = @p_ShareWithDrivers,
            [ShareWithCarrier] = @p_ShareWithCarrier,
            [ShareWithCloseBy] = @p_ShareWithCloseBy,
            [ShareWithLikeMe] = @p_ShareWithLikeMe,
            [AllowInvitations] = @p_AllowInvitations,
            [ThreadEmail] = @p_ThreadEmail,
            [ThreadMobileText] = @p_ThreadMobileText,
            [ThreadFax] = @p_ThreadFax,
            [ThreadInstantMessage] = @p_ThreadInstantMessage,
            [ThreadBoardOnly] = @p_ThreadBoardOnly,
            [FullProfile] = @p_FullProfile,
            [SignatureFile] = @p_SignatureFile,
            [InitialsFile] = @p_InitialsFile,
            [EntityID] = @p_EntityID,
            [SocialSecurityNumber] = @p_SocialSecurityNumber,
            [EINNumber] = @p_EINNumber,
            [SMTPPort] = @p_SMTPPort,
            [SMTPServer] = @p_SMTPServer,
            [SMTPPassword] = @p_SMTPPassword,
            [EnableSSLYN] = @p_EnableSSLYN,
            [FaxCredentials] = @p_FaxCredentials,
            [FaxAccount] = @p_FaxAccount,
            [FaxPassword] = @p_FaxPassword,
            [FaxSMTPPort] = @p_FaxSMTPPort,
            [FaxSMTPServer] = @p_FaxSMTPServer,
            [FaxEnableSSLYN] = @p_FaxEnableSSLYN,
            [RegisteredUserSince] = @p_RegisteredUserSince,
            [AccountFlowStepID] = @p_AccountFlowStepID,
            [PayPalToken] = @p_PayPalToken,
            [StripSearch] = @p_StripSearch,
            [StripSearchDBA] = @p_StripSearchDBA,
            [OutsideID] = @p_OutsideID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [PartyID] = @pk_PartyID

            -- Make sure only one record is affected
            SET @l_rowcount = @@ROWCOUNT
            IF @l_rowcount = 0
                RAISERROR ('The record cannot be updated.', 16, 1)
            IF @l_rowcount > 1
                RAISERROR ('duplicate object instances.', 16, 1)

        END
    ELSE
        BEGIN
            -- Get the checksum value for the record 
            -- and put an update lock on the record to 
            -- ensure transactional integrity.  The lock
            -- will be release when the transaction is 
            -- later committed or rolled back.
            Select @l_newValue = CAST(BINARY_CHECKSUM([PartyID],[PartyTypeID],[Logo],[ProfilePicture],[Name],[DBA],[Title],[Handle],[Email],[Password],[Contact],[DirectDial],[Mobile],[Fax],[OtherPhone],[ShareWithFriends],[ShareWithDrivers],[ShareWithCarrier],[ShareWithCloseBy],[ShareWithLikeMe],[AllowInvitations],[ThreadEmail],[ThreadMobileText],[ThreadFax],[ThreadInstantMessage],[ThreadBoardOnly],[FullProfile],[SignatureFile],[InitialsFile],[EntityID],[SocialSecurityNumber],[EINNumber],[SMTPPort],[SMTPServer],[SMTPPassword],[EnableSSLYN],[FaxCredentials],[FaxAccount],[FaxPassword],[FaxSMTPPort],[FaxSMTPServer],[FaxEnableSSLYN],[RegisteredUserSince],[AccountFlowStepID],[PayPalToken],[StripSearch],[StripSearchDBA],[OutsideID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[Party] with (rowlock, holdlock)
            WHERE [PartyID] = @pk_PartyID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Party]
                    SET 
                    [PartyTypeID] = @p_PartyTypeID,
                    [Logo] = @p_Logo,
                    [ProfilePicture] = @p_ProfilePicture,
                    [Name] = @p_Name,
                    [DBA] = @p_DBA,
                    [Title] = @p_Title,
                    [Handle] = @p_Handle,
                    [Email] = @p_Email,
                    [Password] = @p_Password,
                    [Contact] = @p_Contact,
                    [DirectDial] = @p_DirectDial,
                    [Mobile] = @p_Mobile,
                    [Fax] = @p_Fax,
                    [OtherPhone] = @p_OtherPhone,
                    [ShareWithFriends] = @p_ShareWithFriends,
                    [ShareWithDrivers] = @p_ShareWithDrivers,
                    [ShareWithCarrier] = @p_ShareWithCarrier,
                    [ShareWithCloseBy] = @p_ShareWithCloseBy,
                    [ShareWithLikeMe] = @p_ShareWithLikeMe,
                    [AllowInvitations] = @p_AllowInvitations,
                    [ThreadEmail] = @p_ThreadEmail,
                    [ThreadMobileText] = @p_ThreadMobileText,
                    [ThreadFax] = @p_ThreadFax,
                    [ThreadInstantMessage] = @p_ThreadInstantMessage,
                    [ThreadBoardOnly] = @p_ThreadBoardOnly,
                    [FullProfile] = @p_FullProfile,
                    [SignatureFile] = @p_SignatureFile,
                    [InitialsFile] = @p_InitialsFile,
                    [EntityID] = @p_EntityID,
                    [SocialSecurityNumber] = @p_SocialSecurityNumber,
                    [EINNumber] = @p_EINNumber,
                    [SMTPPort] = @p_SMTPPort,
                    [SMTPServer] = @p_SMTPServer,
                    [SMTPPassword] = @p_SMTPPassword,
                    [EnableSSLYN] = @p_EnableSSLYN,
                    [FaxCredentials] = @p_FaxCredentials,
                    [FaxAccount] = @p_FaxAccount,
                    [FaxPassword] = @p_FaxPassword,
                    [FaxSMTPPort] = @p_FaxSMTPPort,
                    [FaxSMTPServer] = @p_FaxSMTPServer,
                    [FaxEnableSSLYN] = @p_FaxEnableSSLYN,
                    [RegisteredUserSince] = @p_RegisteredUserSince,
                    [AccountFlowStepID] = @p_AccountFlowStepID,
                    [PayPalToken] = @p_PayPalToken,
                    [StripSearch] = @p_StripSearch,
                    [StripSearchDBA] = @p_StripSearchDBA,
                    [OutsideID] = @p_OutsideID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [PartyID] = @pk_PartyID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Party]', 16, 1)

        END
END

