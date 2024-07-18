USE [EXAMEN]
GO

/****** Object:  Table [dbo].[Equipos]    Script Date: 18/07/2024 1:32:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Equipos](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Ciudad] [varchar](100) NULL,
	[Estadio] [varchar](100) NULL,
	[Fundacion] [date] NULL,
	[Presidente] [varchar](100) NULL,
	[Titulos] [int] NULL,
	[Liga] [varchar](100) NULL,
	[Estado] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


