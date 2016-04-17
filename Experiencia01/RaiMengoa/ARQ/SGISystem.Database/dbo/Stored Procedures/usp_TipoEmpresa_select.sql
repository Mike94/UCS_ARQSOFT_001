CREATE PROCEDURE [dbo].[usp_TipoEmpresa_select]
(
 @IDTipoEmpresa int		 = NULL
,@NombreTipo varchar(50) = ''
,@Estado int			 = -1)
AS
BEGIN	
 SELECT [IDTipoEmpresa]
       ,[NombreTipo]
       ,[Estado]
  FROM [dbo].[TipoEmpresa]
  WHERE (IDTipoEmpresa = @IDTipoEmpresa OR @IDTipoEmpresa IS NULL OR @IDTipoEmpresa = -1)
  AND   (@NombreTipo IS NULL OR NombreTipo LIKE '%' + @NombreTipo + '%' OR @NombreTipo = '')
  AND   (Estado = @Estado OR @Estado IS NULL OR @Estado = -1)
END