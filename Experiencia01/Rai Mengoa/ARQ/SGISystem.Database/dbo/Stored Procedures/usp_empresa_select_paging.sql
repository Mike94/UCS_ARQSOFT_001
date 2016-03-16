-- [usp_empresa_select_paging] '', -1, 0, 10, 0
CREATE PROCEDURE [dbo].[usp_empresa_select_paging]
(@CodigoEmpresa VARCHAR(100) = NULL
,@Estado		 INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) 
            FROM	Empresas e
			LEFT JOIN TipoEmpresa  tipo
			ON		(e.IDTipoEmpresa = tipo.IDTipoEmpresa)
			WHERE (@CodigoEmpresa = '' OR @CodigoEmpresa IS NULL OR e.CodigoEmpresa = @CodigoEmpresa)
			AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = e.Estado));

SELECT  Fila,
		IDEmpresa,
        CodigoEmpresa,
        RazonComercial,
        RazonSocial,
		Telefono,
        RUC,
        Contacto,
        Direccion,
        Estado,
		EstadoNombre,
		IDTipoEmpresa,
		TipoEmpresaNombre
FROM	( SELECT  ROW_NUMBER() OVER(ORDER BY IDEmpresa ASC) AS Fila,
              e.IDEmpresa,
              e.CodigoEmpresa,
              e.RazonComercial,
              e.RazonSocial,
			  e.Telefono,
              e.RUC,
              e.Contacto,
              e.Direccion,
              e.Estado,
			  e.IDTipoEmpresa,
			  (CASE 
           		WHEN e.Estado = 1 THEN 'Activo'
				WHEN e.Estado = 0 THEN 'Inactivo'
           		ELSE ''
				END) AS EstadoNombre,
			  tipo.NombreTipo AS 'TipoEmpresaNombre'
        FROM Empresas e  
		LEFT JOIN TipoEmpresa  tipo
		ON		(e.IDTipoEmpresa = tipo.IDTipoEmpresa)
		WHERE 	(@CodigoEmpresa = '' OR @CodigoEmpresa IS NULL OR CodigoEmpresa = @CodigoEmpresa)
		AND     (@Estado IS NULL OR @Estado = -1 OR @Estado = e.Estado)) AS T_Empresas
WHERE Fila 
  BETWEEN (@PageIndex) * @PageSize + 1 
  AND (@PageIndex + 1) * @PageSize;

END