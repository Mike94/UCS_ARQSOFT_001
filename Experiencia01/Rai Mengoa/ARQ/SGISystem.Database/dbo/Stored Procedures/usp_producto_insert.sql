CREATE PROCEDURE [dbo].[usp_producto_insert]
(@IdProducto BIGINT OUT,
@NombreProducto VARCHAR(100) = NULL,
@DescripcionCorta VARCHAR(50) = NULL,
@DescripcionLarga VARCHAR(200) = NULL,
@CantidadMinimaInventario INT = NULL,
@CantidadInventario INT  = NULL,
@PrecioUnitario DECIMAL(6,2)  = NULL,
@IdGrupo INT = NULL,
@Estado INT = NULL)
AS
BEGIN

SELECT @IDProducto = (ISNULL(MAX(IDProducto), 0) + 1) FROM productos;

INSERT   productos
		(IDProducto	
		,NombreProducto	
		,DescripcionCorta	
		,DescripcionLarga	
		,CantidadMinimaInventario
		,CantidadInventario
		,PrecioUnitario
		,IDGrupo
		,Estado)
VALUES	
		(@IDProducto	
		,@NombreProducto	
		,@DescripcionCorta	
		,@DescripcionLarga	
		,@CantidadMinimaInventario
		,@CantidadInventario
		,@PrecioUnitario
		,@IDGrupo
		,@Estado);
END
--select * from productos