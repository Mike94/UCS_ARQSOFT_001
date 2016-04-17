CREATE PROCEDURE [dbo].[usp_grupo_select_paging]
(@DescripcionCorta VARCHAR(150) = ''
,@Estado         INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) 
				FROM            GrupoProductos gp
				LEFT JOIN		GrupoProductos gpPadre
				ON		(gp.IDGrupoPadre = gpPadre.IDGrupo)
				WHERE   (gp.DescripcionCorta LIKE '%' + @DescripcionCorta + '%' OR @DescripcionCorta = '' OR @DescripcionCorta IS NULL)
				AND     (gp.Estado = @Estado OR @Estado = -1));
				  
SELECT      Fila,
			IDGrupo, 
			IDGrupoPadre, 
			DescripcionCorta, 
			DescripcionLarga, 
			Estado,
			EstadoNombre,
			GrupoPadreNombre
  FROM (
   SELECT   ROW_NUMBER() OVER(ORDER BY gp.IDGrupo ASC) AS Fila,
			gp.IDGrupo, 
			gp.IDGrupoPadre, 
			gp.DescripcionCorta, 
			gp.DescripcionLarga, 
			gp.Estado,
			(CASE 
           	WHEN gp.Estado = 1 THEN 'Activo'
			WHEN gp.Estado = 0 THEN 'Inactivo'
           	ELSE ''
			END) AS EstadoNombre,
			gpPadre.DescripcionCorta AS 'GrupoPadreNombre'
	FROM            GrupoProductos gp
	LEFT JOIN		GrupoProductos gpPadre
	ON		(gp.IDGrupoPadre = gpPadre.IDGrupo)
    WHERE   (gp.DescripcionCorta LIKE '%' + @DescripcionCorta + '%' OR @DescripcionCorta = '' OR @DescripcionCorta IS NULL)
    AND     (gp.Estado = @Estado OR @Estado = -1)) AS T_GRUPO
  WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize; 

END