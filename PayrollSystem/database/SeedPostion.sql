USE PayrollDB
GO

SET IDENTITY_INSERT [dbo].[Position] ON


    IF NOT EXISTS(SELECT PositionID 
                FROM [Position] 
                WHERE PositionID = 1)
    BEGIN

        INSERT INTO [Position]
             (
            [PositionID], [PositionName], [Rate]
            )
         VALUES
             (
            1,'Mason',390
            )
    END
    
    IF NOT EXISTS(SELECT PositionID 
                FROM [Position] 
                WHERE PositionID = 2)
    BEGIN

        INSERT INTO [Position]
             (
            [PositionID], [PositionName], [Rate]
            )
         VALUES
             (
            2,'Helper',280
            )
    END
    
    IF NOT EXISTS(SELECT PositionID 
                FROM [Position] 
                WHERE PositionID = 3)
    BEGIN

        INSERT INTO [Position]
             (
            [PositionID], [PositionName], [Rate]
            )
         VALUES
             (
            3,'Foreman',1000
            )
    END
    
    IF NOT EXISTS(SELECT PositionID 
                FROM [Position] 
                WHERE PositionID = 4)
    BEGIN

        INSERT INTO [Position]
             (
            [PositionID], [PositionName], [Rate]
            )
         VALUES
             (
            4,'Engineer',3500
            )
    END
    
SET IDENTITY_INSERT [dbo].[Position] OFF
