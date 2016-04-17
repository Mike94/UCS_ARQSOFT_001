CREATE TABLE [dbo].[Productos](
	[IDProducto] [bigint] NOT NULL,
	[NombreProducto] [varchar](50) NULL,
	[DescripcionCorta] [varchar](50) NULL,
	[DescripcionLarga] [varchar](250) NULL,
	[CantidadMinimaInventario] [int] NULL,
	[CantidadInventario] [int] NULL,
	[PrecioUnitario] [decimal](6, 2) NULL,
	[IDGrupo] [int] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Productos_GrupoProductos]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_GrupoProductos] FOREIGN KEY([IDGrupo])
REFERENCES [dbo].[GrupoProductos] ([IDGrupo])
GO

ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_GrupoProductos]
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

