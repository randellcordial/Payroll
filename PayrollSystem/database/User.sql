USE [PayrollDB]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects
    WHERE id = object_id(N'[dbo].[UserInsert]')
    and OBJECTPROPERTY(id, N'IsProcedure') = 1)

    DROP PROCEDURE [dbo].[UserInsert]

GO

CREATE PROC [dbo].[UserInsert]
    @UserID UNIQUEIDENTIFIER,
    @FirstName VARCHAR(50),
    @MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @PositionID SMALLINT
AS

    INSERT INTO [User]
         (
        [UserID], [FirstName], [MiddleName],[LastName],[PositionID]
        )
     VALUES
         (
        @UserID, @FirstName, @MiddleName,@LastName,@PositionID
        )
    
    SELECT @@IDENTITY
GO