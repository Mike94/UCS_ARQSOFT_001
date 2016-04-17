CREATE PROCEDURE [dbo].[usp_empresa_insert]
(
@IDEmpresa INT OUT,
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
  
SELECT @IDEmpresa = (ISNULL(MAX(IDEmpresa), 0) + 1) FROM Empresas;

INSERT INTO dbo.Empresas
(
  IDEmpresa
 ,CodigoEmpresa
 ,RazonComercial
 ,RazonSocial
 ,RUC
 ,Telefono
 ,Contacto
 ,Direccion
 ,IDTipoEmpresa
 ,Estado
)
VALUES
(
  @IDEmpresa
 ,@CodigoEmpresa
 ,@RazonComercial
 ,@RazonSocial
 ,@Telefono
 ,@RUC
 ,@Contacto
 ,@Direccion
 ,@IDTipoEmpresa
 ,@Estado
)
END