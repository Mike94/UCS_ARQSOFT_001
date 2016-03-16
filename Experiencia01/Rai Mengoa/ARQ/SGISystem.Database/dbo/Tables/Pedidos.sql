CREATE TABLE [dbo].[Pedidos](
	[IDPedido] [int] NOT NULL,
	[IDEmpresa] [int] NOT NULL,
	[CodigoPedido] [varchar](25) NULL,
	[FechaPedido] [datetime] NULL,
	[FechaPago] [datetime] NULL,
	[FechaEntrega] [datetime] NULL,
	[IDEncargado] [int] NULL,
	[TotalBruto] [decimal](18, 2) NULL,
	[Retencion] [decimal](10, 2) NULL,
	[TotalNeto] [decimal](18, 2) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Pedidos_Empleados]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Empleados] FOREIGN KEY([IDEncargado])
REFERENCES [dbo].[Empleados] ([IDEmpleado])
GO

ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Empleados]
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


GO


GO


GO


GO
/****** Object:  ForeignKey [FK_Pedidos_Empresa]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Empresa] FOREIGN KEY([IDEmpresa])
REFERENCES [dbo].[Empresas] ([IDEmpresa])
GO

ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Empresa]
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


GO


GO


GO

