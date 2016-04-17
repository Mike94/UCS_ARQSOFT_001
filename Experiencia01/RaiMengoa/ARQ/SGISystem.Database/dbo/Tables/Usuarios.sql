CREATE TABLE [dbo].[Usuarios](
	[IDUsuario] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Clave] [varbinary](8000) NOT NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Usuarios_Empleados]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Empleados] ([IDEmpleado])
GO

ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
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

