if exists (select * from sysobjects where id = object_id(N'pFASTPORTV_CaseTreeUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTV_CaseTreeUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[v_CaseTree] table.
CREATE PROCEDURE pFASTPORTV_CaseTreeUpdate
    @p_UseCaseID int,
    @pk_UseCaseID int,
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
DECLARE
    @l_rowcount int
BEGIN

    -- Update the record with the passed parameters
    UPDATE [dbo].[v_CaseTree]
    SET 
            [UseCaseID] = @p_UseCaseID,
            [CaseParentID] = @p_CaseParentID,
            [CaseSort] = @p_CaseSort,
            [CaseName] = @p_CaseName,
            [CaseDescription] = @p_CaseDescription,
            [VideoURL] = @p_VideoURL,
            [AppPage] = @p_AppPage,
            [AppPageTitle] = @p_AppPageTitle,
            [Button1] = @p_Button1,
            [Button1Tip] = @p_Button1Tip,
            [RedirectURL] = @p_RedirectURL,
            [Button2] = @p_Button2,
            [Button2Tip] = @p_Button2Tip,
            [RedirectURL2] = @p_RedirectURL2,
            [Button3] = @p_Button3,
            [Button3Tip] = @p_Button3Tip,
            [RedirectURL3] = @p_RedirectURL3,
            [CrossCaseID] = @p_CrossCaseID,
            [CrossCase] = @p_CrossCase,
            [Tallys] = @p_Tallys,
            [OverviewImage] = @p_OverviewImage,
            [AlternateFlowYN] = @p_AlternateFlowYN,
            [FlowCount] = @p_FlowCount,
            [AltCount] = @p_AltCount,
            [RuleCount] = @p_RuleCount,
            [FieldsCount] = @p_FieldsCount,
            [QuestionsCount] = @p_QuestionsCount,
            [SupportCount] = @p_SupportCount,
            [HistoryCount] = @p_HistoryCount
    WHERE [UseCaseID] = @pk_UseCaseID

    -- Make sure only one record is affected
    SET @l_rowcount = @@ROWCOUNT
    IF @l_rowcount = 0
        RAISERROR ('The record cannot be updated.', 16, 1)
    IF @l_rowcount > 1
        RAISERROR ('duplicate object instances.', 16, 1)

END

