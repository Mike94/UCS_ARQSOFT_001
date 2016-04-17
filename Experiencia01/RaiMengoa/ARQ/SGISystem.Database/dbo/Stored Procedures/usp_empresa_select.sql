CREATE PROCEDURE [dbo].[usp_empresa_select]
(
  @IDEmpresa INT = NULL,
  @CodigoEmpresa VARCHAR(100) = '',
  @RazonComercial VARCHAR(200) = '',
  @RazonSocial VARCHAR(200) = '',
  @RUC VARCHAR(11) = '',
  @Contacto VARCHAR(250) = '',
  @Direccion VARCHAR(200) = '',
  @Estado INT  = -1
)
AS
BEGIN
   SELECT     e.IDEmpresa,
              e.CodigoEmpresa,
              e.RazonComercial,
              e.RazonSocial,
              e.RUC,
              e.Contacto,
			  e.Telefono,
              e.Direccion,
			  e.IDTipoEmpresa,
              e.Estado 
    FROM      Empresas e  
    WHERE 	  (@IDEmpresa IS NULL OR IDEmpresa = @IDEmpresa)
    AND 	  (@CodigoEmpresa IS NULL OR @CodigoEmpresa = '' OR CodigoEmpresa = @CodigoEmpresa)
    AND 	  (@RazonComercial IS NULL OR @RazonComercial = '' OR RazonComercial = @RazonComercial)
    AND 	  (@RazonSocial IS NULL OR @RazonSocial = '' OR RazonSocial = @RazonSocial)
    AND 	  (@RUC IS NULL OR @RUC = '' OR RUC = @RUC)
    AND 	  (@Contacto IS NULL OR @Contacto = '' OR Contacto = @Contacto)
    AND 	  (@Direccion IS NULL OR @Direccion = '' OR Direccion = @Direccion)
    AND 	  (@Estado IS NULL OR @Estado = -1 OR Estado = @Estado)
END