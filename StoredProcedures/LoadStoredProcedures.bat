
@setlocal
@echo off

rem NEED AT LEAST 4 PARAMETERS
if %4 == "" goto :SYNTAX

SET APPLICATION_NAME=%1
SET STORED_PROC_DIR=%2
SET SERVERNAME=%3
SET DATABASENAME=%4

rem IF ONLY 4 PARAMETERS, THIS IS WINDOWS AUTHENTICATION
if "%5" == "" (
    SET AUTHENTICATION=-WindowsAuthentication
) else (
    rem IF MORE THAN 6 PARAM, IT'S INVALID
    if not "%7" == "" goto :SYNTAX

    rem THERE'S NO 6TH PARAMETER, IT'S INVALID
    if "%6" == "" goto :SYNTAX

    rem SQLUSERNAME=%5
    rem SQLPASSWORD=%6
    SET AUTHENTICATION=-username "%5" -password "%6"
)

LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Agreement" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "AgreementExecution" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Audit_CarrierAdActivity" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Calendar" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CarrierAd" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CarrierAdActivity" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CarrierAdContacts" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CarrierAdGeo" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CarrierAdLink" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CheckIn" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CheckInActivity" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "CheckInShare" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Doc" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "DocPage" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "DocTree" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Equip" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Flow" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "FlowButton" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "FlowCollection" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "FlowConfig" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "FlowOverview" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "FlowStep" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "GeoCity" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "GeoCity3" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "GeoCountry" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "GeoState" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Global" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "List" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Party" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyAddr" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyCarrier" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyDriver" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyExperience" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyFleet" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyFleetCircle" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyIncident" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyIncidentTicketedFor" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyPaySettings" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyReps" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyRole" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyRollup" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyService" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyWorkHistory" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyWorkHistoryVerification" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PartyWorkHistoryVerificationLog" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PaymentMethod" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PaymentMethodCarrier" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "PaymentMethodParty" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Ref" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Role" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "SprocLog" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "SystemJob" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "SystemJobLog" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "SystemService" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Thread" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "ThreadDefaultReceiver" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "ThreadInstance" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "ThreadInstanceMessage" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "ThreadInstanceMessageAttachments" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "ThreadInstanceParties" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "Tree" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_AdDetails" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Addr" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Agreement" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_AsposeTest" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_AsposeTestChildren" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_CarrierOneRow" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Carriers" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_CarrierSimple" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Driver" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Execution" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_FellowUserDistinctRoles" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_FellowUsers" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_GeoCity" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_GeoCountry" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_History" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_HistoryLoadRW" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PartyByUser" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PartyCarriers" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PartyOrg" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PartyUserRoles" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PersonSnapshot" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_PersonWithPic" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_RolesGeneral" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SecurityRole" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SecurityUser" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Services" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_Sign" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignAddr" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignDocs" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignDocs_OneRow" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignEmployer" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignEquip" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignHistory" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignLic" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_SignOwner" %AUTHENTICATION%
LoadStoredProcedures.exe -application %APPLICATION_NAME% -directory %STORED_PROC_DIR% -server %SERVERNAME% -database %DATABASENAME% -table "v_TreeHTML" %AUTHENTICATION%

goto :END

:SYNTAX
ECHO.
ECHO USAGE:
ECHO.
ECHO Windows Server Authentication:
ECHO        LoadStoredProcedures.bat [ApplicationName]
ECHO                                 [ApplicationDirectory]
ECHO                                 [ServerName]
ECHO                                 [DatabaseName]
ECHO.
ECHO SQL Server Authentication:
ECHO        LoadStoredProcedures.bat [ApplicationName]
ECHO                                 [ApplicationDirectory]
ECHO                                 [ServerName]
ECHO                                 [DatabaseName]
ECHO                                 [Username]
ECHO                                 [Password]
ECHO.
ECHO Example of Windows Server Authentication:
ECHO        LoadStoredProcedures.bat MyApplication C:\MyApplication
ECHO                                 MySQLServerName MyDatabaseName
ECHO.
ECHO Example of SQL Server Authentication:
ECHO        LoadStoredProcedures.bat MyApplication
ECHO                                 "C:\My Application Folder"
ECHO                                 MySQLServerName MyDatabaseName sa sapassword

:END
