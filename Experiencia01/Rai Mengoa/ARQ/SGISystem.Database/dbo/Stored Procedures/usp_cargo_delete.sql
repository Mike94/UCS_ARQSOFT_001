CREATE PROCEDURE [dbo].[usp_cargo_delete]
(
	@IdCargo     INT          = NULL
)
AS
BEGIN
UPDATE Cargo 
SET   Estado = 0
WHERE IdCargo = @IdCargo;  
END