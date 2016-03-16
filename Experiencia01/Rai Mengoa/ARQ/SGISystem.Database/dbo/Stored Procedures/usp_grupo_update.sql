CREATE PROCEDURE [dbo].[usp_grupo_update]
(
 @IDGrupo INT					= NULL	
,@IDGrupoPadre INT				= NULL
,@DescripcionCorta VARCHAR(50)	= ''
,@DescripcionLarga VARCHAR(100) = ''
,@Estado INT					= NULL
)
AS
BEGIN

UPDATE dbo.GrupoProductos
   SET IDGrupoPadre = @IDGrupoPadre
      ,DescripcionCorta = @DescripcionCorta
      ,DescripcionLarga = @DescripcionLarga
      ,Estado = @Estado
 WHERE IDGrupo = @IDGrupo

END