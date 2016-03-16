CREATE PROCEDURE [dbo].[usp_cargo_insert]
(
	@IdCargo     INT           OUT,
  @NombreCargo VARCHAR(50)  = '',
  @Descripcion VARCHAR(150) = '',
  @Estado      INT          = NULL
)
AS
BEGIN
SELECT @IdCargo = (ISNULL(MAX(IdCargo), 0) + 1) FROM Cargo;

  INSERT INTO  Cargo 
    (
     IdCargo, 
     NombreCargo, 
     Descripcion, 
     Estado
    )
  VALUES 
    (
    @IdCargo, 
    @NombreCargo, 
    @Descripcion, 
    @Estado
    );
END