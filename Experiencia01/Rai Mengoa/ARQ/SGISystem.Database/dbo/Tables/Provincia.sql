CREATE TABLE [dbo].[Provincia](
	[IdDepartamento] [char](2) NOT NULL,
	[IdProvincia] [char](2) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC,
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Departamento] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamento] ([IdDepartamento])
GO

ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Departamento]
GO


GO


GO


GO


GO


GO


GO


GO
ALTER TABLE [dbo].[Provincia] ADD  CONSTRAINT [DF_Provincia_Estado]  DEFAULT ((1)) FOR [Estado]