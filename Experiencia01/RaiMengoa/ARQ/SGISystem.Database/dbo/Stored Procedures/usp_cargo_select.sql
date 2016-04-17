CREATE PROCEDURE [dbo].[usp_cargo_select]
(
  @IDCargo     INT          = NULL,
  @NombreCargo VARCHAR(50)  = '',
  @Descripcion VARCHAR(150) = '',
  @Estado      INT          = NULL
)
AS
BEGIN
 SELECT  c.IdCargo,
         c.NombreCargo,
         c.Descripcion,
         c.Estado
  FROM Cargo c  
  WHERE   (c.IdCargo = @IDCargo OR @IDCargo = -1 OR @IDCargo IS NULL)  
  AND     (c.NombreCargo LIKE '%' + @NombreCargo + '%' OR @NombreCargo = '' OR @NombreCargo IS NULL)
  AND     (c.Descripcion LIKE '%' + @Descripcion + '%' OR @Descripcion = '' OR @Descripcion IS NULL)
  AND     (c.Estado = @Estado OR @Estado = -1 OR @Estado IS NULL)
END