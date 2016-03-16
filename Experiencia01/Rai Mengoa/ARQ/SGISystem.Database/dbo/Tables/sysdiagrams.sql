CREATE TABLE [dbo].[sysdiagrams](
	[name] [sysname] NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [UK_principal_name]    Script Date: 13/12/2014 17:21:20 ******/
/****** Object:  Index [UK_principal_name]    Script Date: 14/12/2014 23:09:07 ******/
/****** Object:  Index [UK_principal_name]    Script Date: 15/12/2014 0:40:10 ******/
/****** Object:  Index [UK_principal_name]    Script Date: 26/12/2014 10:33:48 ******/
/****** Object:  Index [UK_principal_name]    Script Date: 26/12/2014 16:55:02 ******/
/****** Object:  Index [UK_principal_name]    Script Date: 27/12/2014 11:46:43 ******/
ALTER TABLE [dbo].[sysdiagrams] ADD  CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED 
(
	[principal_id] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]