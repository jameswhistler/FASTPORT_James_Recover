if exists (select * from sysobjects where id = object_id(N'pFASTPORTFlowUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTFlowUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Flow] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTFlowUpdate
    @pk_FlowID int,
    @p_FlowPage varchar(50),
    @p_FirstElementDesc varchar(50),
    @p_SecondElementDesc varchar(50),
    @p_ThirdElementDesc varchar(50),
    @p_FourthElementDesc varchar(50),
    @p_FifthElementDesc varchar(50),
    @p_SixthElementDesc varchar(50),
    @p_SeventhElementDesc varchar(50),
    @p_EighthElementDesc varchar(50),
    @p_NinthElementDesc varchar(50),
    @p_TenthElementDesc varchar(50),
    @p_EleventhElementDesc varchar(50),
    @p_TwelfthElementDesc varchar(50),
    @p_ThirteenthElementDesc varchar(50),
    @p_FourteenthElementDesc varchar(50),
    @p_FifteenthElementDesc varchar(50),
    @p_FirstButtonDesc varchar(50),
    @p_SecondButtonDesc varchar(50),
    @p_ThirdButtonDesc varchar(50),
    @p_FourthButtonDesc varchar(50),
    @p_FifthButtonDesc varchar(50),
    @p_SixthButtonDesc varchar(50),
    @p_SeventhButtonDesc varchar(50),
    @p_EighthButtonDesc varchar(50),
    @p_NinthButtonDesc varchar(50),
    @p_TenthButtonDesc varchar(50),
    @p_RelatedToID int,
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
    IF NOT EXISTS (SELECT * FROM [dbo].[Flow] WHERE [FlowID] = @pk_FlowID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Flow]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Flow]
            SET 
            [FlowPage] = @p_FlowPage,
            [FirstElementDesc] = @p_FirstElementDesc,
            [SecondElementDesc] = @p_SecondElementDesc,
            [ThirdElementDesc] = @p_ThirdElementDesc,
            [FourthElementDesc] = @p_FourthElementDesc,
            [FifthElementDesc] = @p_FifthElementDesc,
            [SixthElementDesc] = @p_SixthElementDesc,
            [SeventhElementDesc] = @p_SeventhElementDesc,
            [EighthElementDesc] = @p_EighthElementDesc,
            [NinthElementDesc] = @p_NinthElementDesc,
            [TenthElementDesc] = @p_TenthElementDesc,
            [EleventhElementDesc] = @p_EleventhElementDesc,
            [TwelfthElementDesc] = @p_TwelfthElementDesc,
            [ThirteenthElementDesc] = @p_ThirteenthElementDesc,
            [FourteenthElementDesc] = @p_FourteenthElementDesc,
            [FifteenthElementDesc] = @p_FifteenthElementDesc,
            [FirstButtonDesc] = @p_FirstButtonDesc,
            [SecondButtonDesc] = @p_SecondButtonDesc,
            [ThirdButtonDesc] = @p_ThirdButtonDesc,
            [FourthButtonDesc] = @p_FourthButtonDesc,
            [FifthButtonDesc] = @p_FifthButtonDesc,
            [SixthButtonDesc] = @p_SixthButtonDesc,
            [SeventhButtonDesc] = @p_SeventhButtonDesc,
            [EighthButtonDesc] = @p_EighthButtonDesc,
            [NinthButtonDesc] = @p_NinthButtonDesc,
            [TenthButtonDesc] = @p_TenthButtonDesc,
            [RelatedToID] = @p_RelatedToID,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [FlowID] = @pk_FlowID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([FlowID],[FlowPage],[FirstElementDesc],[SecondElementDesc],[ThirdElementDesc],[FourthElementDesc],[FifthElementDesc],[SixthElementDesc],[SeventhElementDesc],[EighthElementDesc],[NinthElementDesc],[TenthElementDesc],[EleventhElementDesc],[TwelfthElementDesc],[ThirteenthElementDesc],[FourteenthElementDesc],[FifteenthElementDesc],[FirstButtonDesc],[SecondButtonDesc],[ThirdButtonDesc],[FourthButtonDesc],[FifthButtonDesc],[SixthButtonDesc],[SeventhButtonDesc],[EighthButtonDesc],[NinthButtonDesc],[TenthButtonDesc],[RelatedToID],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[Flow] with (rowlock, holdlock)
            WHERE [FlowID] = @pk_FlowID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Flow]
                    SET 
                    [FlowPage] = @p_FlowPage,
                    [FirstElementDesc] = @p_FirstElementDesc,
                    [SecondElementDesc] = @p_SecondElementDesc,
                    [ThirdElementDesc] = @p_ThirdElementDesc,
                    [FourthElementDesc] = @p_FourthElementDesc,
                    [FifthElementDesc] = @p_FifthElementDesc,
                    [SixthElementDesc] = @p_SixthElementDesc,
                    [SeventhElementDesc] = @p_SeventhElementDesc,
                    [EighthElementDesc] = @p_EighthElementDesc,
                    [NinthElementDesc] = @p_NinthElementDesc,
                    [TenthElementDesc] = @p_TenthElementDesc,
                    [EleventhElementDesc] = @p_EleventhElementDesc,
                    [TwelfthElementDesc] = @p_TwelfthElementDesc,
                    [ThirteenthElementDesc] = @p_ThirteenthElementDesc,
                    [FourteenthElementDesc] = @p_FourteenthElementDesc,
                    [FifteenthElementDesc] = @p_FifteenthElementDesc,
                    [FirstButtonDesc] = @p_FirstButtonDesc,
                    [SecondButtonDesc] = @p_SecondButtonDesc,
                    [ThirdButtonDesc] = @p_ThirdButtonDesc,
                    [FourthButtonDesc] = @p_FourthButtonDesc,
                    [FifthButtonDesc] = @p_FifthButtonDesc,
                    [SixthButtonDesc] = @p_SixthButtonDesc,
                    [SeventhButtonDesc] = @p_SeventhButtonDesc,
                    [EighthButtonDesc] = @p_EighthButtonDesc,
                    [NinthButtonDesc] = @p_NinthButtonDesc,
                    [TenthButtonDesc] = @p_TenthButtonDesc,
                    [RelatedToID] = @p_RelatedToID,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [FlowID] = @pk_FlowID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Flow]', 16, 1)

        END
END

