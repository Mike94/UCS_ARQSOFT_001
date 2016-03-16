CREATE PROCEDURE [dbo].[usp_tienda_insert](
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
  INSERT INTO dbo.Tienda
  (
    CodTienda
   ,NombreTienda
   ,Direccion
   ,IdDistrito
   ,IdProvincia
   ,IdRegion
   ,Referencia
   ,Estado
  )
  VALUES
  (
    @CodTienda
   ,@NombreTienda
   ,@Direccion
   ,@IdDistrito
   ,@IdProvincia
   ,@IdRegion
   ,@Referencia
   ,@Estado
  )
END