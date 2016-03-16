CREATE PROCEDURE [dbo].[usp_grupo_select]
(
  @IDGrupo INT					= NULL	
 ,@IDGrupoPadre INT				= NULL
 ,@DescripcionCorta VARCHAR(50)	= ''
 ,@DescripcionLarga VARCHAR(100) = ''
 ,@Estado INT					= NULL
)
AS
BEGIN
 SELECT     gp.IDGrupo, 
			gp.IDGrupoPadre, 
			gp.DescripcionCorta, 
			gp.DescripcionLarga, 
			gp.Estado
  FROM      GrupoProductos gp  
  WHERE   (gp.IDGrupo = @IDGrupo OR @IDGrupo = -1 OR @IDGrupo IS NULL)
  AND     (gp.IDGrupoPadre = @IDGrupoPadre OR @IDGrupoPadre = -1 OR @IDGrupoPadre IS NULL)
  AND     (gp.DescripcionCorta LIKE '%' + @DescripcionCorta + '%' OR @DescripcionCorta = '' OR @DescripcionCorta IS NULL)
  AND     (gp.DescripcionLarga LIKE '%' + @DescripcionLarga + '%' OR @DescripcionLarga = '' OR @DescripcionLarga IS NULL)
  AND     (gp.Estado = @Estado OR @Estado = -1 OR @Estado IS NULL)
END