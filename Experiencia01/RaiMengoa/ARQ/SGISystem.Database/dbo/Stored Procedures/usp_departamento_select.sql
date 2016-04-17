CREATE PROCEDURE [dbo].[usp_departamento_select]
(
 @IdDepartamento	char(2)		 = NULL,
 @Nombre			varchar(150) = '',
 @Estado			int			 = -1
)
AS
BEGIN 

SELECT dep.IdDepartamento
      ,dep.Nombre
      ,dep.Estado
  FROM	   Departamento dep
  WHERE   (dep.IdDepartamento = @IdDepartamento OR @IdDepartamento = '' OR @IdDepartamento IS NULL)  
  AND     (dep.Nombre LIKE '%' + @Nombre + '%' OR @Nombre = '' OR @Nombre IS NULL)
  AND     (dep.Estado = @Estado OR @Estado = -1 OR @Estado IS NULL)	

END