CREATE TABLE [dbo].[Tienda](
	[CodTienda] [char](5) NOT NULL,
	[NombreTienda] [varchar](150) NULL,
	[Direccion] [varchar](200) NULL,
	[IdDistrito] [char](2) NULL,
	[idProvincia] [char](2) NULL,
	[IdRegion] [char](2) NULL,
	[Referencia] [varchar](50) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Tienda] PRIMARY KEY CLUSTERED 
(
	[CodTienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tienda]  WITH CHECK ADD  CONSTRAINT [FK_Tienda_Distrito] FOREIGN KEY([IdRegion], [idProvincia], [IdDistrito])
REFERENCES [dbo].[Distrito] ([IdDepartamento], [IdProvincia], [IdDistrito])
GO

ALTER TABLE [dbo].[Tienda] CHECK CONSTRAINT [FK_Tienda_Distrito]
GO


GO


GO


GO


GO


GO

