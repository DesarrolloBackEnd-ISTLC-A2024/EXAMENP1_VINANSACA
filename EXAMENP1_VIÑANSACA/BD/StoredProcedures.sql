USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spActualizarFutbolista]    Script Date: 18/07/2024 1:37:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spActualizarFutbolista]
    @Id INT,
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Nacionalidad VARCHAR(50),
    @Posicion VARCHAR(50),
    @Altura INT,
    @Peso INT,
    @Estado VARCHAR(1)
AS
BEGIN
    UPDATE Futbolista
    SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Nacionalidad = @Nacionalidad, Posicion = @Posicion, Altura = @Altura, Peso = @Peso, Estado = @Estado
    WHERE Id = @Id
END
GO






USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spConsultarFutbolista]    Script Date: 18/07/2024 1:37:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spConsultarFutbolista]
    @Id INT
AS
BEGIN
    SELECT * FROM Futbolista WHERE Id = @Id
END
GO



USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spConsultarFutbolistasActivos]    Script Date: 18/07/2024 1:38:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spConsultarFutbolistasActivos]
AS
BEGIN
    SELECT * FROM Futbolista WHERE Estado = 'A'
END
GO




USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spConsultarHistoricoEquipos]    Script Date: 18/07/2024 1:38:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spConsultarHistoricoEquipos]
    @FutbolistaId INT
AS
BEGIN
    SELECT he.*, e.Nombre AS NombreEquipo 
    FROM HistoricoEquipos he
    JOIN Equipos e ON he.EquipoId = e.Id
    WHERE he.FutbolistaId = @FutbolistaId
END
GO




USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spCrearFutbolista]    Script Date: 18/07/2024 1:38:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCrearFutbolista]
    @Id INT,
    @Nombre VARCHAR(100),
    @FechaNacimiento DATE,
    @Nacionalidad VARCHAR(50),
    @Posicion VARCHAR(50),
    @Altura INT,
    @Peso INT,
    @Estado VARCHAR(1)
AS
BEGIN
    INSERT INTO Futbolista (Id, Nombre, FechaNacimiento, Nacionalidad, Posicion, Altura, Peso, Estado)
    VALUES (@Id, @Nombre, @FechaNacimiento, @Nacionalidad, @Posicion, @Altura, @Peso, @Estado)
END
GO




USE [EXAMEN]
GO

/****** Object:  StoredProcedure [dbo].[spEliminarFutbolista]    Script Date: 18/07/2024 1:38:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEliminarFutbolista]
    @Id INT
AS
BEGIN
    UPDATE Futbolista SET Estado = 'I' WHERE Id = @Id
END
GO



