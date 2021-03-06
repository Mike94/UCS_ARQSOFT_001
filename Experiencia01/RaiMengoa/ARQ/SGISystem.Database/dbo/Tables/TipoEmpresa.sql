﻿CREATE TABLE [dbo].[TipoEmpresa](
	[IDTipoEmpresa] [int] NOT NULL,
	[NombreTipo] [varchar](50) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_TipoEmpresa] PRIMARY KEY CLUSTERED 
(
	[IDTipoEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]