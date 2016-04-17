CREATE TABLE [dbo].[Almacen](
	[CodAlmacen] [char](3) NOT NULL,
	[CodTienda] [char](5) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [nchar](10) NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[CodAlmacen] ASC,
	[CodTienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Almacen_Tienda]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Almacen]  WITH CHECK ADD  CONSTRAINT [FK_Almacen_Tienda] FOREIGN KEY([CodTienda])
REFERENCES [dbo].[Tienda] ([CodTienda])
GO

ALTER TABLE [dbo].[Almacen] CHECK CONSTRAINT [FK_Almacen_Tienda]
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

