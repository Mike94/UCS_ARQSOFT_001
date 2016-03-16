-- usp_Producto_select_paging '',1,1,1
CREATE PROCEDURE [dbo].[usp_Producto_select_paging]
(@NombreProducto		 VARCHAR(500) = ''
,@IDGrupo	     INT = -1
,@Estado         INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
--5select @NombreProducto 
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) FROM	Productos 
			      WHERE (@NombreProducto IS NULL OR NombreProducto   LIKE '%' + @NombreProducto + '%' )
				  AND     (IDGrupo = @IDGrupo OR @IDGrupo = -1)
				  AND     (Estado = @Estado OR @Estado = -1));
				 -- select @TotalRows 

SELECT   Fila
		,IDProducto 
		,NombreProducto 
		,DescripcionCorta 
		,DescripcionLarga 
		,CantidadMinimaInventario 
		,CantidadInventario 
		,PrecioUnitario 
		,IDGrupo 
		,Estado  
		,GrupoNombre
		,EstadoNombre
FROM	(
		SELECT   ROW_NUMBER() OVER(ORDER BY IDProducto ASC) AS Fila
				,pro.IDProducto 
				,pro.NombreProducto 
				,pro.DescripcionCorta 
				,pro.DescripcionLarga 
				,pro.CantidadMinimaInventario
				,pro.CantidadInventario 
				,pro.PrecioUnitario 
				,pro.IDGrupo 
				,pro.Estado
				,gp.DescripcionCorta as GrupoNombre
				,case when pro.Estado =0 then 'Inactivo' else 'Activo' end as EstadoNombre
				
		FROM	Productos  AS pro inner join GrupoProductos gp on gp.IDGrupo =pro.IDGrupo
		WHERE 	(@NombreProducto  IS NULL OR NombreProducto  LIKE '%' + @NombreProducto + '%' )
		AND     (pro.IDGrupo = @IDGrupo OR @IDGrupo = -1)
		AND     (pro.Estado = @Estado OR @Estado = -1)) AS T_Producto
WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize;
END