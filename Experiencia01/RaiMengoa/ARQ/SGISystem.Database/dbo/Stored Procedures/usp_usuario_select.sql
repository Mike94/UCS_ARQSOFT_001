CREATE PROCEDURE [dbo].[usp_usuario_select](
 @IDUsuario INT          = NULL,
 @Usuario VARCHAR(50)    = '',
 @Estado INT             = -1
  )
 AS
BEGIN
  
SELECT
  us.IDUsuario,
  us.Usuario,
  CAST(DECRYPTBYPASSPHRASE('PASSPHRASE', us.Clave) AS VARCHAR) AS Clave,
  us.Estado
FROM dbo.Usuarios us
WHERE  (@IDUsuario IS NULL OR @IDUsuario = us.IDUsuario OR @IDUsuario = -1 )
AND    (@Usuario IS NULL OR @Usuario = '' OR @Usuario = us.Usuario) 
AND    (@Estado IS NULL OR @Estado = -1 OR @Estado = us.Estado) 
END
GO