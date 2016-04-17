-- usp_producto_select '','','','',null
CREATE PROCEDURE [dbo].[usp_grupo_producto_select]
(@IDGrupo				INT = NULL
,@IdGrupoPadre			INT = NULL	
,@DescripcionCorta		  VARCHAR(200) = NULL
,@DescripcionLarga  	  VARCHAR(200) = NULL
,@Estado					INT		   = NULL)
AS
BEGIN
SELECT   gpro.IDGrupo
		,gpro.IDGrupoPadre
		,gpro.DescripcionCorta 
		,gpro.DescripcionLarga
		,gpro.Estado
FROM	grupoproductos AS gpro 
WHERE	(@IDGrupo= '' OR @IDGrupo IS NULL OR @IDGrupo = gpro.IDGrupo)
AND 	(@IdGrupoPadre= '' OR @IdGrupoPadre IS NULL OR gpro.IDGrupoPadre  = gpro.IDGrupoPadre )
AND 	(@DescripcionCorta= '' OR @DescripcionCorta IS NULL OR gpro.DescripcionCorta  LIKE '%' + @DescripcionCorta + '%')
AND 	(@DescripcionLarga= '' OR @DescripcionLarga IS NULL OR gpro.DescripcionLarga  LIKE '%' + @DescripcionLarga + '%')
AND 	(@Estado IS NULL OR @Estado = gpro.Estado OR @Estado = -1)
END

--select * from grupoproductos