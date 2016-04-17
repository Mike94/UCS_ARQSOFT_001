CREATE PROCEDURE [dbo].[usp_usuario_autenticar]
(@Usuario   VARCHAR(50),
 @Clave     VARCHAR(50))
AS
BEGIN
DECLARE @ClaveEncriptada VARBINARY(8000);
DECLARE @DesClaveDesencriptada VARCHAR(50);

SELECT  @ClaveEncriptada = u.Clave 
FROM	Usuarios  u
WHERE	u.Usuario = @Usuario 
AND		u.Estado = 1;

SET @DesClaveDesencriptada = CAST(DECRYPTBYPASSPHRASE('PASSPHRASE', @ClaveEncriptada) AS VARCHAR);
If @DesClaveDesencriptada = @Clave
        SELECT 1
    Else
        SELECT 0
END