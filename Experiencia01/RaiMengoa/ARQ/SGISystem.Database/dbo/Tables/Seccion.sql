CREATE TABLE [dbo].[Seccion](
	[CodSeccion] [char](3) NOT NULL,
	[CodAlmacen] [char](3) NOT NULL,
	[CodTienda] [char](5) NOT NULL,
	[NombreSeccion] [varchar](50) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Seccion] PRIMARY KEY CLUSTERED 
(
	[CodSeccion] ASC,
	[CodAlmacen] ASC,
	[CodTienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Seccion_Almacen]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Seccion]  WITH CHECK ADD  CONSTRAINT [FK_Seccion_Almacen] FOREIGN KEY([CodAlmacen], [CodTienda])
REFERENCES [dbo].[Almacen] ([CodAlmacen], [CodTienda])
GO

ALTER TABLE [dbo].[Seccion] CHECK CONSTRAINT [FK_Seccion_Almacen]
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

