CREATE TABLE [dbo].[GrupoProductos](
	[IDGrupo] [int] NOT NULL,
	[IDGrupoPadre] [int] NULL,
	[DescripcionCorta] [varchar](50) NULL,
	[DescripcionLarga] [varchar](100) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_GrupoProductos] PRIMARY KEY CLUSTERED 
(
	[IDGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_GrupoProductos_GrupoProductosRecursivo]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[GrupoProductos]  WITH CHECK ADD  CONSTRAINT [FK_GrupoProductos_GrupoProductosRecursivo] FOREIGN KEY([IDGrupoPadre])
REFERENCES [dbo].[GrupoProductos] ([IDGrupo])
GO

ALTER TABLE [dbo].[GrupoProductos] CHECK CONSTRAINT [FK_GrupoProductos_GrupoProductosRecursivo]
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

