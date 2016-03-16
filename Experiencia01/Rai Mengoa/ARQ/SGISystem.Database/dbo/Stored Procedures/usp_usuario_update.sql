CREATE PROCEDURE [dbo].[usp_usuario_update]
(@IDUsuario  INT		 
,@Usuario	 VARCHAR(50) = ''	
,@Clave	     VARCHAR(50) = ''
,@Estado     INT= null)
AS
BEGIN
DECLARE @VarClave VARBINARY(8000) = ENCRYPTBYPASSPHRASE('PASSPHRASE', @Clave);
UPDATE Usuarios
   SET Usuario = @Usuario
      ,Clave = @VarClave
      ,Estado = @Estado
 WHERE IDUsuario = @IDUsuario
END