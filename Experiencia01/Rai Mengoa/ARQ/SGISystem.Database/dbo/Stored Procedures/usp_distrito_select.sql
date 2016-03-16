CREATE PROCEDURE [dbo].[usp_distrito_select]
(
 @IdDepartamento	CHAR(2)		 = NULL,
 @IdProvincia		CHAR(2)		 = NULL,
 @IdDistrito		CHAR(2)		 = NULL,
 @Nombre			VARCHAR(150) = '',
 @Estado			INT  		 = -1
)
AS
BEGIN 

SELECT IdDepartamento
      ,IdProvincia
      ,IdDistrito
      ,Nombre
      ,Estado
  FROM dbo.Distrito dist
  WHERE   (dist.IdDepartamento = @IdDepartamento OR @IdDepartamento = '' OR @IdDepartamento IS NULL)  
  AND     (dist.IdProvincia = @IdProvincia OR @IdProvincia = '' OR @IdProvincia IS NULL)
  AND     (dist.IdDistrito = @IdDistrito OR @IdDistrito = '' OR @IdDistrito IS NULL)
  AND     (dist.Nombre LIKE '%' + @Nombre + '%' OR @Nombre = '' OR @Nombre IS NULL)
  AND     (dist.Estado = @Estado OR @Estado = -1 OR @Estado IS NULL)	

END