CREATE TABLE [dbo].[DetallePedidos](
	[IDPedido] [int] NOT NULL,
	[IDProducto] [bigint] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[TotalBruto] [decimal](18, 2) NOT NULL,
	[Retencion] [decimal](10, 2) NOT NULL,
	[TotalNeto] [decimal](18, 2) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_DetallePedidos] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC,
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_DetallePedidos_Pedidos]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[DetallePedidos]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidos_Pedidos] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[Pedidos] ([IDPedido])
GO

ALTER TABLE [dbo].[DetallePedidos] CHECK CONSTRAINT [FK_DetallePedidos_Pedidos]
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
/****** Object:  ForeignKey [FK_DetallePedidos_Productos]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[DetallePedidos]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidos_Productos] FOREIGN KEY([IDProducto])
REFERENCES [dbo].[Productos] ([IDProducto])
GO

ALTER TABLE [dbo].[DetallePedidos] CHECK CONSTRAINT [FK_DetallePedidos_Productos]
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

