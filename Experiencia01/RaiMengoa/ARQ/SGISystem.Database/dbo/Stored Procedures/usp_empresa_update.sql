CREATE PROCEDURE [dbo].[usp_empresa_update]
(
@IDEmpresa INT					= NULL,
@CodigoEmpresa VARCHAR(100)		= '',
@RazonComercial VARCHAR(200)	= '',
@RazonSocial VARCHAR(200)		= '',
@RUC VARCHAR(11)				= NULL,
@Contacto VARCHAR(250)			= '',
@Telefono VARCHAR(20)			= '',
@Direccion VARCHAR(200)			= '',
@IDTipoEmpresa INT				= NULL,
@Estado INT						= NULL 
)
AS BEGIN
  UPDATE dbo.Empresas 
  SET
    CodigoEmpresa = @CodigoEmpresa -- CodigoEmpresa - varchar(50)
   ,RazonComercial = @RazonComercial -- RazonComercial - varchar(200) NOT NULL
   ,RazonSocial = @RazonSocial -- RazonSocial - varchar(200)
   ,RUC = @RUC -- RUC - varchar(11)
   ,Contacto = @Contacto -- Contacto - varchar(250)
   ,Telefono = @Telefono -- Telefono - varchar(20)
   ,Direccion = @Direccion -- Direccion - varchar(200)
   ,IDTipoEmpresa = @IDTipoEmpresa -- IDTipoEmpresa - int
   ,Estado = @Estado -- Estado - int
  WHERE
    IDEmpresa = @IDEmpresa;
END