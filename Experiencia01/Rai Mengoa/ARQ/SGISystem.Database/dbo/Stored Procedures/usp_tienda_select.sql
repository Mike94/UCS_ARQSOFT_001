CREATE PROCEDURE [dbo].[usp_tienda_select](
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
  SELECT  t.CodTienda,
          t.NombreTienda,
          t.Direccion,
          t.IdDistrito,
          t.IdProvincia,
          t.IdRegion,
          t.Referencia,
          t.Estado
    FROM Tienda t
  WHERE  (@CodTienda = '' OR @CodTienda IS NULL OR CodTienda = @CodTienda)
  AND    (@NombreTienda IS NULL OR @NombreTienda = '' OR Direccion   = @NombreTienda)
  AND    (@Direccion IS NULL OR @Direccion = '' OR Direccion   = @Direccion)
  AND    (@IdDistrito IS NULL OR @IdDistrito = 0 OR  IdDistrito   = @IdDistrito)
  AND    (@IdProvincia IS NULL OR @IdProvincia = 0 OR  IdProvincia   = @IdProvincia)
  AND    (@IdRegion IS NULL OR @IdRegion = 0 OR  IdRegion   = @IdRegion)
  AND    (@Referencia IS NULL OR @Referencia = '' OR   Referencia   = @Referencia)
  AND    (@Estado IS NULL OR @Estado = -1 OR   Estado   = @Estado)
END