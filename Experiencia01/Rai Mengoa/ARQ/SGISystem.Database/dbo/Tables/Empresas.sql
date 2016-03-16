CREATE TABLE [dbo].[Empresas](
	[IDEmpresa] [int] NOT NULL,
	[CodigoEmpresa] [varchar](100) NULL,
	[RazonComercial] [varchar](250) NULL,
	[RazonSocial] [varchar](250) NULL,
	[RUC] [varchar](11) NULL,
	[Contacto] [varchar](200) NULL,
	[Telefono] [varchar](20) NULL,
	[Direccion] [varchar](150) NULL,
	[IDTipoEmpresa] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IDEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empresas]  WITH CHECK ADD  CONSTRAINT [FK_Empresas_TipoEmpresa] FOREIGN KEY([IDTipoEmpresa])
REFERENCES [dbo].[TipoEmpresa] ([IDTipoEmpresa])
GO

ALTER TABLE [dbo].[Empresas] CHECK CONSTRAINT [FK_Empresas_TipoEmpresa]
GO


GO


GO


GO


GO


GO


GO


GO


GO


GO

