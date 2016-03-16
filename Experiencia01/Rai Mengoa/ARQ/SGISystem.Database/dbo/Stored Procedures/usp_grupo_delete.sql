CREATE PROCEDURE [dbo].[usp_grupo_delete]
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
   SET Estado = 0
 WHERE IDGrupo = @IDGrupo

END