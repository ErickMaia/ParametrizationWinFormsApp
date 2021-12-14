CREATE PROCEDURE ReadParametrization AS BEGIN
	SELECT TOP 1 
     [Username]
    ,[Password]
    ,[Email]
    ,[InputPath]
    ,[OutputPath]
    ,[MinutesBeforeIntegration]
    FROM Parametrization
END