CREATE PROCEDURE [dbo].[usp_empresa_delete]
(
@IDEmpresa INT
)
AS BEGIN
  UPDATE dbo.Empresas 
  SET  Estado = 0
  WHERE
    IDEmpresa = @IDEmpresa;
END