if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CaseTreeAdd') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CaseTreeAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[v_CaseTree] table.
CREATE PROCEDURE pFASTPORTV_CaseTreeAdd
    @p_UseCaseID int,
    @p_CaseParentID int,
    @p_CaseSort nvarchar(2000),
    @p_CaseName nvarchar(4000),
    @p_CaseDescription nvarchar(4000),
    @p_VideoURL nvarchar(1000),
    @p_AppPage bit,
    @p_AppPageTitle varchar(50),
    @p_Button1 varchar(50),
    @p_Button1Tip varchar(255),
    @p_RedirectURL varchar(255),
    @p_Button2 varchar(50),
    @p_Button2Tip varchar(255),
    @p_RedirectURL2 varchar(255),
    @p_Button3 varchar(50),
    @p_Button3Tip varchar(255),
    @p_RedirectURL3 varchar(255),
    @p_CrossCaseID int,
    @p_CrossCase nvarchar(4000),
    @p_Tallys varchar(237),
    @p_OverviewImage image,
    @p_AlternateFlowYN int,
    @p_FlowCount int,
    @p_AltCount int,
    @p_RuleCount int,
    @p_FieldsCount int,
    @p_QuestionsCount int,
    @p_SupportCount int,
    @p_HistoryCount int
AS
BEGIN
    INSERT
    INTO [dbo].[v_CaseTree]
        (
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
        )
    VALUES
        (
             @p_UseCaseID,
             @p_CaseParentID,
             @p_CaseSort,
             @p_CaseName,
             @p_CaseDescription,
             @p_VideoURL,
             @p_AppPage,
             @p_AppPageTitle,
             @p_Button1,
             @p_Button1Tip,
             @p_RedirectURL,
             @p_Button2,
             @p_Button2Tip,
             @p_RedirectURL2,
             @p_Button3,
             @p_Button3Tip,
             @p_RedirectURL3,
             @p_CrossCaseID,
             @p_CrossCase,
             @p_Tallys,
             @p_OverviewImage,
             @p_AlternateFlowYN,
             @p_FlowCount,
             @p_AltCount,
             @p_RuleCount,
             @p_FieldsCount,
             @p_QuestionsCount,
             @p_SupportCount,
             @p_HistoryCount
        )

END

