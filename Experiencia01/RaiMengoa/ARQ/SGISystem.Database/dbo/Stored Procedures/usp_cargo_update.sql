CREATE PROCEDURE [dbo].[usp_cargo_update]
(
	@IdCargo     INT          = NULL,
  @NombreCargo VARCHAR(50)  = '',
  @Descripcion VARCHAR(150) = '',
  @Estado      INT          = NULL
)
AS
BEGIN
UPDATE Cargo 
SET  NombreCargo = @NombreCargo, 
     Descripcion = @Descripcion, 
     Estado = @Estado
WHERE IdCargo = @IdCargo;  
END