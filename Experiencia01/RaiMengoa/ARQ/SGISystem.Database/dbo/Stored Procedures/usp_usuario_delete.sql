CREATE PROCEDURE [dbo].[usp_usuario_delete]
(
@IDUsuario INT
)
AS BEGIN
  UPDATE Usuarios 
  SET  Estado = 0
  WHERE
    IDUsuario = @IDUsuario;
END