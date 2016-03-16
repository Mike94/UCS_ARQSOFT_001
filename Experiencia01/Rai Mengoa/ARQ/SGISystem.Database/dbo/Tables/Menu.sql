CREATE TABLE [dbo].[Menu](
	[IDMenu] [char](3) NOT NULL,
	[IDMenuPadre] [char](3) NULL,
	[DescripcionCorta] [varchar](50) NULL,
	[DescripcionLarga] [varchar](150) NULL,
	[RefProgramaWeb] [varchar](100) NULL,
	[RefProgramaMovil] [varchar](100) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[IDMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Menu_MenuRecursivo]    Script Date: 11/22/2014 19:31:15 ******/
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_MenuRecursivo] FOREIGN KEY([IDMenuPadre])
REFERENCES [dbo].[Menu] ([IDMenu])
GO

ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_MenuRecursivo]
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

