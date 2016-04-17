-- [usp_provincia_select] '01', '-1', '', 1
CREATE PROCEDURE [dbo].[usp_provincia_select]
(
 @IdDepartamento	CHAR(2)		 = NULL,
 @IdProvincia		CHAR(2)		 = NULL,
 @Nombre			VARCHAR(150) = '',
 @Estado			INT  		 = -1
)
AS
BEGIN 
SELECT IdDepartamento
      ,IdProvincia
      ,Nombre
      ,Estado
  FROM dbo.Provincia pro
  WHERE   (pro.IdDepartamento = @IdDepartamento OR @IdDepartamento = '' OR @IdDepartamento IS NULL)  
  AND     (pro.IdProvincia = @IdProvincia OR @IdProvincia = '' OR @IdProvincia IS NULL)
  AND     (pro.Nombre LIKE '%' + @Nombre + '%' OR @Nombre = '' OR @Nombre IS NULL)
  AND     (pro.Estado = @Estado OR @Estado = -1 OR @Estado IS NULL)	

END