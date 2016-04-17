CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [char](2) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departamento] ADD  CONSTRAINT [DF_Departamento_Estado]  DEFAULT ((1)) FOR [Estado]