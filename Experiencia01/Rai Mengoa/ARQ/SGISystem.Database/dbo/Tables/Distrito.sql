CREATE TABLE [dbo].[Distrito](
	[IdDepartamento] [char](2) NOT NULL,
	[IdProvincia] [char](2) NOT NULL,
	[IdDistrito] [char](2) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC,
	[IdProvincia] ASC,
	[IdDistrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [FK_Distrito_Provincia] FOREIGN KEY([IdDepartamento], [IdProvincia])
REFERENCES [dbo].[Provincia] ([IdDepartamento], [IdProvincia])
GO

ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [FK_Distrito_Provincia]
GO


GO


GO


GO


GO


GO


GO


GO


GO
ALTER TABLE [dbo].[Distrito] ADD  CONSTRAINT [DF_Distrito_Estado]  DEFAULT ((1)) FOR [Estado]