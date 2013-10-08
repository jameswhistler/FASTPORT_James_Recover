if exists (select * from sysobjects where id = object_id(N'pFASTPORTCarrierAdLinkUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTCarrierAdLinkUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[CarrierAdLink] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTCarrierAdLinkUpdate
    @pk_LinkID int,
    @p_AdID int,
    @p_LinkName varchar(255),
    @p_LinkNotes varchar(2000),
    @p_OrangeButton bit,
    @p_BlueButton bit,
    @p_LinkButton bit,
    @p_FullLink bit,
    @p_LinksHTML varchar(2000),
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
    IF NOT EXISTS (SELECT * FROM [dbo].[CarrierAdLink] WHERE [LinkID] = @pk_LinkID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[CarrierAdLink]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[CarrierAdLink]
            SET 
            [AdID] = @p_AdID,
            [LinkName] = @p_LinkName,
            [LinkNotes] = @p_LinkNotes,
            [OrangeButton] = @p_OrangeButton,
            [BlueButton] = @p_BlueButton,
            [LinkButton] = @p_LinkButton,
            [FullLink] = @p_FullLink,
            [LinksHTML] = @p_LinksHTML,
            [CreatedByID] = @p_CreatedByID,
            [CreatedAt] = @p_CreatedAt,
            [UpdatedByID] = @p_UpdatedByID,
            [UpdatedAt] = @p_UpdatedAt
            WHERE [LinkID] = @pk_LinkID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([LinkID],[AdID],[LinkName],[LinkNotes],[OrangeButton],[BlueButton],[LinkButton],[FullLink],[LinksHTML],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) AS nvarchar(4000)) 
            FROM [dbo].[CarrierAdLink] with (rowlock, holdlock)
            WHERE [LinkID] = @pk_LinkID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[CarrierAdLink]
                    SET 
                    [AdID] = @p_AdID,
                    [LinkName] = @p_LinkName,
                    [LinkNotes] = @p_LinkNotes,
                    [OrangeButton] = @p_OrangeButton,
                    [BlueButton] = @p_BlueButton,
                    [LinkButton] = @p_LinkButton,
                    [FullLink] = @p_FullLink,
                    [LinksHTML] = @p_LinksHTML,
                    [CreatedByID] = @p_CreatedByID,
                    [CreatedAt] = @p_CreatedAt,
                    [UpdatedByID] = @p_UpdatedByID,
                    [UpdatedAt] = @p_UpdatedAt
                    WHERE [LinkID] = @pk_LinkID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[CarrierAdLink]', 16, 1)

        END
END

