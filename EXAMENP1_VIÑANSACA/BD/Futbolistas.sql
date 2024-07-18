USE [EXAMEN]
GO

/****** Object:  Table [dbo].[Futbolista]    Script Date: 18/07/2024 1:35:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Futbolista](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Posicion] [varchar](50) NULL,
	[Altura] [int] NULL,
	[Peso] [int] NULL,
	[Estado] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


