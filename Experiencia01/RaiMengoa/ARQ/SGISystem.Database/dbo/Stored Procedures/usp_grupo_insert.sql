CREATE PROCEDURE [dbo].[usp_grupo_insert]
(
 @IDGrupo INT					  OUT	
,@IDGrupoPadre INT				= NULL
,@DescripcionCorta VARCHAR(50)	= ''
,@DescripcionLarga VARCHAR(100) = ''
,@Estado INT					= NULL
)
AS
BEGIN

SELECT @IDGrupo = (ISNULL(MAX(IDGrupo), 0) + 1) FROM dbo.GrupoProductos;

INSERT INTO dbo.GrupoProductos
           (IDGrupo
           ,IDGrupoPadre
           ,DescripcionCorta
           ,DescripcionLarga
           ,Estado)
     VALUES
           (@IDGrupo
           ,@IDGrupoPadre
           ,@DescripcionCorta
           ,@DescripcionLarga
           ,@Estado)
END