CREATE PROCEDURE InsertUpdateParametrization
(
	@Username VARCHAR(100), 
	@Password VARCHAR(50), 
	@Email VARCHAR(100),
	@InputPath VARCHAR(200), 
	@OutputPath VARCHAR(200),
	@MinutesBeforeIntegration INT
)	
AS BEGIN
	IF NOT EXISTS (SELECT TOP 1 Username FROM Parametrization) BEGIN
		INSERT INTO Parametrization
           (Username
           ,Password
           ,Email
           ,InputPath
           ,OutputPath
           ,MinutesBeforeIntegration)
		VALUES
           (@Username,
		   @Password,
           @Email,
           @InputPath,
           @OutputPath,
           @MinutesBeforeIntegration) 
	END
	ELSE BEGIN
		UPDATE Parametrization SET
           Username = @Username
           ,Password = @Password
           ,Email = @Email
           ,InputPath = @InputPath
           ,OutputPath = @OutputPath
           ,MinutesBeforeIntegration = @MinutesBeforeIntegration
	END
END
