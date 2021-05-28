USE [PayrollDB]
GO

IF EXISTS (SELECT * FROM dbo.sysobjects
    WHERE id = object_id(N'[dbo].[PositionInsert]')
    and OBJECTPROPERTY(id, N'IsProcedure') = 1)

    DROP PROCEDURE [dbo].[PositionInsert]

GO

CREATE PROC [dbo].[PositionInsert]
    @PositionName VARCHAR(50),
    @Rate FLOAT
AS

    INSERT INTO [Position]
         (
        [PositionName],[Rate]
        )
     VALUES
         (
        @PositionName, @Rate
        )
    
    SELECT @@IDENTITY
GO