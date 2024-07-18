USE [EXAMEN]
GO

/****** Object:  Table [dbo].[HistoricoEquipos]    Script Date: 18/07/2024 1:36:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HistoricoEquipos](
	[Id] [int] NOT NULL,
	[FutbolistaId] [int] NULL,
	[EquipoId] [int] NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HistoricoEquipos]  WITH CHECK ADD FOREIGN KEY([EquipoId])
REFERENCES [dbo].[Equipos] ([Id])
GO

ALTER TABLE [dbo].[HistoricoEquipos]  WITH CHECK ADD FOREIGN KEY([FutbolistaId])
REFERENCES [dbo].[Futbolista] ([Id])
GO


