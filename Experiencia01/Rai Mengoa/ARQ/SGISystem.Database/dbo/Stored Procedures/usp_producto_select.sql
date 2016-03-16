-- usp_producto_select '-1','','','','0','0','0','-1',null
CREATE PROCEDURE [dbo].[usp_producto_select]
(@IdProducto BIGINT = NULL,
 @NombreProducto VARCHAR(100) = NULL,
 @DescripcionCorta VARCHAR(50) = NULL,
 @DescripcionLarga VARCHAR(200) = NULL,
 @CantidadMinimaInventario INT = NULL,
 @CantidadInventario INT  = NULL,
 @PrecioUnitario DECIMAL(6,2)  = NULL,
 @IdGrupo INT = -1,
 @Estado INT = -1)
AS
BEGIN
SELECT   pro.IDProducto
		,pro.NombreProducto 
		,pro.DescripcionCorta 
		,pro.DescripcionLarga
		,pro.CantidadMinimaInventario 
		,pro.CantidadInventario 
		,pro.PrecioUnitario
		,pro.IDGrupo
		,pro.Estado
FROM	productos AS pro 
WHERE	(@IDProducto = -1 OR @IDProducto IS NULL OR @IDProducto = pro.IDProducto )
AND 	(@NombreProducto= '' OR @NombreProducto IS NULL OR @NombreProducto  = pro.NombreProducto  )
AND 	(@DescripcionCorta= '' OR @DescripcionCorta IS NULL OR DescripcionCorta  LIKE '%' + @DescripcionCorta + '%')
AND 	(@DescripcionLarga= '' OR @DescripcionLarga IS NULL OR DescripcionLarga  LIKE '%' + @DescripcionLarga + '%')
--AND 	(@CantidadMinimaInventario IS NULL OR @CantidadMinimaInventario = pro.CantidadMinimaInventario  )
--AND 	(@CantidadInventario IS NULL OR @CantidadInventario    = pro.CantidadInventario )
--AND 	(@PrecioUnitario IS NULL OR @PrecioUnitario  = pro.PrecioUnitario  )
AND 	(@IdGrupo  IS NULL OR @IDGrupo = pro.IDGrupo OR @IdGrupo = -1)
AND 	(@Estado IS NULL OR @Estado = pro.Estado OR @Estado = -1)
END

--select * from productos