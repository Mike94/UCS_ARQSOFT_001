CREATE PROCEDURE [dbo].[usp_cargo_select_paging]
(@IDCargo     INT          = NULL
,@NombreCargo VARCHAR(50)  = ''
,@Descripcion VARCHAR(150) = ''
,@Estado         INT = -1
,@PageIndex		 INT = NULL
,@PageSize		 INT = NULL
,@TotalRows		 INT   OUT)
AS
BEGIN
SET @TotalRows = (SELECT ISNULL(COUNT(1),0) FROM Cargo c  
                  WHERE   (c.IdCargo = @IDCargo OR @IDCargo IS NULL OR @IDCargo = -1)  
                  AND     (c.NombreCargo LIKE '%' + @NombreCargo + '%' OR @NombreCargo = '' OR @NombreCargo IS NULL)
                  AND     (c.Descripcion LIKE '%' + @Descripcion + '%' OR @Descripcion = '' OR @Descripcion IS NULL)
                  AND     (c.Estado = @Estado OR @Estado = -1));

SELECT   Fila
         IdCargo,
         NombreCargo,
         Descripcion,
         Estado,
         EstadoNombre
  FROM (
   SELECT  ROW_NUMBER() OVER (ORDER BY c.IDCargo) AS Fila,
           c.IdCargo,
           c.NombreCargo,
           c.Descripcion,
           c.Estado,
           (CASE 
           	WHEN c.Estado = 1 THEN 'Activo'
            WHEN c.Estado = 0 THEN 'Inactivo'
           	ELSE ''
           END) AS EstadoNombre
    FROM Cargo c  
    WHERE   (c.IdCargo = @IDCargo OR @IDCargo IS NULL OR @IDCargo = -1)  
    AND     (c.NombreCargo LIKE '%' + @NombreCargo + '%' OR @NombreCargo = '' OR @NombreCargo IS NULL)
    AND     (c.Descripcion LIKE '%' + @Descripcion + '%' OR @Descripcion = '' OR @Descripcion IS NULL)
    AND     (c.Estado = @Estado OR @Estado = -1)) AS T_CARGO
  WHERE Fila BETWEEN (@PageIndex) * @PageSize + 1 AND (@PageIndex + 1) * @PageSize; 

END