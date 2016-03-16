CREATE PROCEDURE [dbo].[usp_usuario_insert]
(@IDUsuario INT		   = null
,@Usuario	 VARCHAR(50) = ''	
,@Clave	 VARCHAR(50) = ''
,@Estado int=null)
AS
BEGIN

INSERT  Usuarios
		(IDUsuario	
		,Usuario	
		,Clave	
		,Estado)
VALUES	
		(@IDUsuario	
		,@Usuario	
		,ENCRYPTBYPASSPHRASE('PASSPHRASE', @Clave)	
		,@Estado);
END