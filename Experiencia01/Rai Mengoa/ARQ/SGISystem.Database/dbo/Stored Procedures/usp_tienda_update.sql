CREATE PROCEDURE [dbo].[usp_tienda_update](
 @CodTienda CHAR(5) = '',
 @NombreTienda VARCHAR(150) = '',
 @Direccion VARCHAR(200) = '',
 @IdDistrito CHAR(2) = '',
 @IdProvincia CHAR(2) = '',
 @IdRegion CHAR(2) = '',
 @Referencia VARCHAR(50) = '',
 @Estado INT = NULL
)
AS
BEGIN
  UPDATE dbo.Tienda
  SET
    NombreTienda = @NombreTienda
   ,Direccion   = @Direccion
   ,IdDistrito    = @IdDistrito
   ,IdProvincia   = @IdProvincia
   ,IdRegion      = @IdRegion
   ,Referencia  = @Referencia
   ,Estado      = @Estado
  WHERE  
    CodTienda   = @CodTienda
END