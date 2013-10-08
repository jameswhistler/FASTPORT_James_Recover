if exists (select * from sysobjects where id = object_id(N'pFASTPORTEquipUpdate') and sysstat & 0xf = 4) drop procedure pFASTPORTEquipUpdate 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Updates a record in the [dbo].[Equip] table.
-- Concurreny is supported by using checksum method.
CREATE PROCEDURE pFASTPORTEquipUpdate
    @pk_EquipID int,
    @p_PartyID int,
    @p_OwnerID int,
    @p_YearID int,
    @p_Make varchar(50),
    @p_Model varchar(50),
    @p_Axels int,
    @p_UnladenWeight int,
    @p_HeightFeet int,
    @p_HeightInches int,
    @p_PurchasedDate datetime,
    @p_PurchasedValue money,
    @p_prevConValue nvarchar(4000),
    @p_force_update  char(1)
AS
DECLARE
    @l_newValue nvarchar(4000),
    @return_status int,
    @l_rowcount int
BEGIN
-- Check whether the record still exists before doing update
    IF NOT EXISTS (SELECT * FROM [dbo].[Equip] WHERE [EquipID] = @pk_EquipID)
        RAISERROR ('Concurrency Error: The record has been deleted by another user. Table [dbo].[Equip]', 16, 1)

    -- If user wants to force update to happen even if 
    -- the record has been modified by a concurrent user,
    -- then we do this.
    IF (@p_force_update = 'Y')
        BEGIN

            -- Update the record with the passed parameters
            UPDATE [dbo].[Equip]
            SET 
            [PartyID] = @p_PartyID,
            [OwnerID] = @p_OwnerID,
            [YearID] = @p_YearID,
            [Make] = @p_Make,
            [Model] = @p_Model,
            [Axels] = @p_Axels,
            [UnladenWeight] = @p_UnladenWeight,
            [HeightFeet] = @p_HeightFeet,
            [HeightInches] = @p_HeightInches,
            [PurchasedDate] = @p_PurchasedDate,
            [PurchasedValue] = @p_PurchasedValue
            WHERE [EquipID] = @pk_EquipID

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
            Select @l_newValue = CAST(BINARY_CHECKSUM([EquipID],[PartyID],[OwnerID],[YearID],[Make],[Model],[Axels],[UnladenWeight],[HeightFeet],[HeightInches],[PurchasedDate],[PurchasedValue]) AS nvarchar(4000)) 
            FROM [dbo].[Equip] with (rowlock, holdlock)
            WHERE [EquipID] = @pk_EquipID


            -- Check concurrency by comparing the checksum values
            IF (@p_prevConValue = @l_newValue)
                SET @return_status = 0     -- pass
            ElSE
                SET @return_status = 1     -- fail

            -- Concurrency check passed.  Go ahead and 
            -- update the record
            IF (@return_status = 0)
                BEGIN

                    UPDATE [dbo].[Equip]
                    SET 
                    [PartyID] = @p_PartyID,
                    [OwnerID] = @p_OwnerID,
                    [YearID] = @p_YearID,
                    [Make] = @p_Make,
                    [Model] = @p_Model,
                    [Axels] = @p_Axels,
                    [UnladenWeight] = @p_UnladenWeight,
                    [HeightFeet] = @p_HeightFeet,
                    [HeightInches] = @p_HeightInches,
                    [PurchasedDate] = @p_PurchasedDate,
                    [PurchasedValue] = @p_PurchasedValue
                    WHERE [EquipID] = @pk_EquipID

                    SET @l_rowcount = @@ROWCOUNT
                    IF @l_rowcount = 0
                        RAISERROR ('The record cannot be updated.', 16, 1)
                    IF @l_rowcount > 1
                        RAISERROR ('duplicate object instances.', 16, 1)

                END
            ELSE
            -- Concurrency check failed.  Inform the user by raising the error
                RAISERROR ('Concurrency Error: The record has been updated by another user. Table [dbo].[Equip]', 16, 1)

        END
END

