CREATE TABLE [dbo].[Usuarios_Menu](
	[IDUsuario] [int] NOT NULL,
	[IDMenu] [char](3) NOT NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Usuarios_Menu] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC,
	[IDMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Usuarios_Menu__Menu]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Usuarios_Menu]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Menu__Menu] FOREIGN KEY([IDMenu])
REFERENCES [dbo].[Menu] ([IDMenu])
GO

ALTER TABLE [dbo].[Usuarios_Menu] CHECK CONSTRAINT [FK_Usuarios_Menu__Menu]
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
/****** Object:  ForeignKey [FK_Usuarios_Menu_Usuarios]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Usuarios_Menu]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Menu_Usuarios] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([IDUsuario])
GO

ALTER TABLE [dbo].[Usuarios_Menu] CHECK CONSTRAINT [FK_Usuarios_Menu_Usuarios]
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

