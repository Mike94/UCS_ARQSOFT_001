/*
declare @variable INT
EXEC [usp_tienda_select_paging] '', -1, 0, 10, @variable OUT
SELECT @variable
*/
CREATE PROCEDURE [dbo].[usp_tienda_select_paging] (
 @CodTienda      CHAR(5) = ''
,@Estado         INT = -1
,@PageIndex		   INT = NULL
,@PageSize		   INT = NULL
,@TotalRows		   INT   OUT
)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) FROM Tienda t
					LEFT JOIN Distrito dis
					ON		(t.IdDistrito = dis.IdDistrito)
					AND		(t.IdProvincia = dis.IdProvincia)
					AND		(t.IdRegion = dis.IdDepartamento)
					LEFT JOIN Provincia pro
					ON		(t.IdProvincia = pro.IdProvincia)
					AND		(t.IdRegion = pro.IdDepartamento)
					LEFT JOIN Departamento depa
					ON		(t.IdRegion = depa.IdDepartamento)
					WHERE 	(@CodTienda IS NULL OR @CodTienda = '' OR t.CodTienda LIKE '%' + @CodTienda + '%' )
					AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = t.Estado));

SELECT    Fila,
		  CodTienda,
		  NombreTienda,
          Direccion,
          IdDistrito,
          IdProvincia,
          IdRegion,
		  NombreDistrito,
		  NombreProvincia,
		  NombreDepartamento,
          Referencia,
          Estado,
		  EstadoNombre
FROM	(
  SELECT  ROW_NUMBER() OVER(ORDER BY t.CodTienda ASC) AS Fila,
          t.CodTienda,
		  t.NombreTienda,
          t.Direccion,
          t.IdDistrito,
		  t.IdProvincia,
		  t.IdRegion,
		  dis.Nombre AS 'NombreDistrito',
		  pro.Nombre AS 'NombreProvincia',
		  depa.Nombre AS 'NombreDepartamento',
          t.Referencia,
          t.Estado,
		  (CASE 
			WHEN t.Estado = 1 THEN 'Activo'
			WHEN t.Estado = 0 THEN 'Inactivo'
			ELSE ''
		  END) AS EstadoNombre
    FROM Tienda t
	LEFT JOIN Distrito dis
	ON		(t.IdDistrito = dis.IdDistrito)
	AND		(t.IdProvincia = dis.IdProvincia)
	AND		(t.IdRegion = dis.IdDepartamento)
	LEFT JOIN Provincia pro
	ON		(t.IdProvincia = pro.IdProvincia)
	AND		(t.IdRegion = pro.IdDepartamento)
	LEFT JOIN Departamento depa
	ON		(t.IdRegion = depa.IdDepartamento)
	WHERE 	(@CodTienda IS NULL OR @CodTienda = '' OR t.CodTienda  LIKE '%' + @CodTienda + '%' )
	AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = t.Estado)) AS T_Tienda
WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize;
END