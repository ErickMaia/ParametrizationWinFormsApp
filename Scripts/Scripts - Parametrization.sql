CREATE TABLE Parametrization(
	Username VARCHAR(100), 
	Password VARCHAR(50), 
	Email VARCHAR(100),
	InputPath VARCHAR(200), 
	OutputPath VARCHAR(200),
	MinutesBeforeIntegration INT
); 

INSERT INTO [dbo].[Parametrization]
           ([Username]
           ,[Password]
           ,[Email]
           ,[InputPath]
           ,[OutputPath]
           ,[MinutesBeforeIntegration])
     VALUES
           ('Admin',
		   '123',
           'admin@gmail.com',
           '/home/admin/input-path/',
           '/home/admin/output-path/',
           30); 