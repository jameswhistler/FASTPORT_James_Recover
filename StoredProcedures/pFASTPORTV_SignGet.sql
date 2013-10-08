if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_SignGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_SignGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_Sign] table.
CREATE PROCEDURE pFASTPORTV_SignGet
        @pk_ExecutionID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_Sign]
    WHERE [ExecutionID] =@pk_ExecutionID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [ExecutionID],
        [SignedOn],
        [ExpiresOn],
        [BarCode],
        [C_Logo],
        [C_LogoSmall],
        [C_Name],
        [C_DBA],
        [C_DBAOrName],
        [C_AddrHTML],
        [C_Addr],
        [C_CitySTZip],
        [C_City],
        [C_ST],
        [C_Zip],
        [C_Country],
        [C_Signer],
        [C_SignerTitle],
        [C_SignerContactInfo],
        [C_Phone],
        [C_Mobile],
        [C_OtherPhone],
        [C_Fax],
        [C_Email],
        [C_Signature],
        [C_SignatureSmall],
        [C_Initials],
        [C_DOT],
        [C_MC],
        [C_EIN],
        [C_EIN1],
        [C_EIN2],
        [C_EIN3],
        [C_EIN4],
        [C_EIN5],
        [C_EIN6],
        [C_EIN7],
        [C_EIN8],
        [C_EIN9],
        [D_ProfilePic],
        [D_Name],
        [D_ContactInfo],
        [D_Phone],
        [D_Mobile],
        [D_OtherPhone],
        [D_Fax],
        [D_Email],
        [D_Signature],
        [D_SignatureSmall],
        [D_Initials],
        [D_Overview],
        [D_Incidents],
        [D_ExpGeneral],
        [D_ExpEquipment],
        [D_ExpCargo],
        [D_ExpRegions],
        [D_Gauge],
        [D_AddrHTML],
        [D_Addr],
        [D_CitySTZip],
        [D_City],
        [D_ST],
        [D_Zip],
        [D_Country],
        [D_DOB],
        [D_CDLInfo],
        [D_CDLShort],
        [D_CDLOnly],
        [D_CDLState],
        [D_USCitizen],
        [D_PersonalInfo],
        [D_SSN],
        [D_SSX4],
        [D_SS1],
        [D_SS2],
        [D_SS3],
        [D_SS4],
        [D_SS5],
        [D_SS6],
        [D_SS7],
        [D_SS8],
        [D_SS9],
        [D_PRA],
        [D_PRANumber],
        [D_Passport],
        [D_PassportExpiration],
        [D_TerminalAssigned],
        [D_I9OtherAlien],
        [D_I9a],
        [D_I9b],
        [D_I9c],
        [FirstLabel],
        [FirstValue],
        [SecondLabel],
        [SecondValue],
        [ThirdLabel],
        [ThirdValue],
        [FourthLabel],
        [FourthValue],
        [FifthLabel],
        [FifthValue],
        [SixthLabel],
        [SixthValue],
        [SeventhLabel],
        [SeventhValue],
        [EighthLabel],
        [EighthValue],
        [NinthLabel],
        [NinthValue],
        [TenthLabel],
        [TenthValue],
        [EleventhLabel],
        [EleventhValue],
        [TwelfthLabel],
        [TwelfthValue],
        [ThirteenthLabel],
        [ThirteenthValue],
        [FourteenthLabel],
        [FourteenthValue],
        [FifteenthLabel],
        [FifteenthValue],
        [Cust_Plus1],
        [Cust_Plus2],
        [Cust_Plus3],
        [Cust_Plus4],
        [Cust_Plus5],
        [Cust_Plus6],
        [Cust_HrsTtl]
    FROM [dbo].[v_Sign]
    WHERE [ExecutionID] =@pk_ExecutionID
    SET NOCOUNT OFF
END

