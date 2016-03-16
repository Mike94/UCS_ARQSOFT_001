CREATE PROCEDURE [dbo].[usp_producto_update]
(
@IdProducto BIGINT = NULL,
@NombreProducto VARCHAR(100) = NULL,
@DescripcionCorta VARCHAR(50) = NULL,
@DescripcionLarga VARCHAR(200) = NULL,
@CantidadMinimaInventario INT = NULL,
@CantidadInventario INT  = NULL,
@PrecioUnitario DECIMAL(6,2)  = NULL,
@IdGrupo INT = NULL,
@Estado INT = NULL
)
AS BEGIN
UPDATE dbo.Productos
   SET NombreProducto = @NombreProducto 
      ,DescripcionCorta = @DescripcionCorta
      ,DescripcionLarga = @DescripcionLarga
      ,CantidadMinimaInventario = @CantidadMinimaInventario
      ,CantidadInventario = @CantidadInventario
      ,PrecioUnitario = @PrecioUnitario
      ,IDGrupo = @IDGrupo
      ,Estado = @Estado
 WHERE  IDProducto = @IDProducto 
END