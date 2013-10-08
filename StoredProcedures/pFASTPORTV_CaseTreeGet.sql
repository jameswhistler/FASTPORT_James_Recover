if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CaseTreeGet') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CaseTreeGet 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Returns a specific record from the [dbo].[v_CaseTree] table.
CREATE PROCEDURE pFASTPORTV_CaseTreeGet
        @pk_UseCaseID int
AS
DECLARE
    @l_count int
BEGIN

    SET NOCOUNT ON
    -- Get the rowcount first and make sure 
    -- only one row is returned
    SELECT @l_count = count(*) 
    FROM [dbo].[v_CaseTree]
    WHERE [UseCaseID] =@pk_UseCaseID

    IF @l_count = 0
        RAISERROR ('The record no longer exists.', 16, 1)
    IF @l_count > 1
        RAISERROR ('duplicate object instances.', 16, 1)

    -- Get the row from the query.  Checksum value will be
    -- returned along the row data to support concurrency.
    SELECT 
        [UseCaseID],
        [CaseParentID],
        [CaseSort],
        [CaseName],
        [CaseDescription],
        [VideoURL],
        [AppPage],
        [AppPageTitle],
        [Button1],
        [Button1Tip],
        [RedirectURL],
        [Button2],
        [Button2Tip],
        [RedirectURL2],
        [Button3],
        [Button3Tip],
        [RedirectURL3],
        [CrossCaseID],
        [CrossCase],
        [Tallys],
        [OverviewImage],
        [AlternateFlowYN],
        [FlowCount],
        [AltCount],
        [RuleCount],
        [FieldsCount],
        [QuestionsCount],
        [SupportCount],
        [HistoryCount]
    FROM [dbo].[v_CaseTree]
    WHERE [UseCaseID] =@pk_UseCaseID
    SET NOCOUNT OFF
END

