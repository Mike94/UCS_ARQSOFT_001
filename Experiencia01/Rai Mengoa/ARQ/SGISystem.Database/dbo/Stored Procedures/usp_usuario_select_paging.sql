-- usp_usuario_select_paging '',2,5,1
CREATE PROCEDURE [dbo].[usp_usuario_select_paging]
(@Usuario		 VARCHAR(200) = NULL
,@Estado         INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) FROM	Usuarios us
			      WHERE 	(@Usuario IS NULL OR  us.Usuario LIKE '%' + @Usuario + '%' )
				  AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = Estado));
SELECT   Fila
		,IDUsuario	
		,Usuario	
		,Clave		
		,Estado
FROM	(
		SELECT   ROW_NUMBER() OVER(ORDER BY us.IDUsuario ASC) AS Fila
				,us.IDUsuario
				,us.Usuario
				,us.Clave
				,us.Estado
		FROM	Usuarios AS us 
		WHERE 	(@Usuario IS NULL OR  us.Usuario LIKE '%' + @Usuario + '%' )
		AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = Estado)) AS T_Usuario
WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize;

END