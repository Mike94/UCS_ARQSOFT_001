CREATE TABLE [dbo].[Empleados](
	[IDEmpleado] [int] NOT NULL,
	[CodTienda] [char](5) NULL,
	[Nombres] [varchar](200) NOT NULL,
	[Apellidos] [varchar](200) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[DNI] [varchar](8) NOT NULL,
	[IdCargo] [int] NULL,
	[Sexo] [char](1) NULL,
	[EstadoCivil] [char](1) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IDEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tienda] FOREIGN KEY([CodTienda])
REFERENCES [dbo].[Tienda] ([CodTienda])
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tienda]
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
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargo] FOREIGN KEY([IdCargo])
REFERENCES [dbo].[Cargo] ([IdCargo])
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargo]
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
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [CHK_Empleados_DNI] CHECK  (([DNI] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [CHK_Empleados_DNI]
GO


GO


GO


GO


GO


GO


GO


GO


GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [CHK_Empleados_EstadoCivil] CHECK  (([EstadoCivil] like '[SCVD]'))
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [CHK_Empleados_EstadoCivil]
GO


GO


GO


GO


GO


GO


GO


GO


GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [CHK_Empleados_Sexo] CHECK  (([Sexo] like '[MF]'))
GO

ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [CHK_Empleados_Sexo]
GO


GO


GO


GO


GO


GO


GO


GO

