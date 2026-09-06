USE [master];
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'bdsisescolar')
BEGIN
    CREATE DATABASE [bdsisescolar];
END
GO
USE [bdsisescolar];
GO
IF OBJECT_ID(N'[dbo].[alumnos]', N'U') IS NOT NULL DROP TABLE [dbo].[alumnos];
GO
CREATE TABLE [dbo].[alumnos] (
    [idalumno] NVARCHAR(20)  NOT NULL,
    [idcarrera] NVARCHAR(10)  NULL,
    [repetidor] INT  NULL,
    [nombre] NVARCHAR(40)  NULL,
    [apepat] NVARCHAR(30)  NULL,
    [apemat] NVARCHAR(30)  NULL,
    [direccion] NVARCHAR(120)  NULL,
    [municipio] NVARCHAR(40)  NULL,
    [telefono] BIGINT  NULL,
    [curp] NVARCHAR(18)  NULL,
    [rfc] NVARCHAR(13)  NULL,
    [documentacion] INT  NULL,
    [nombret] NVARCHAR(40)  NULL,
    [apepatt] NVARCHAR(30)  NULL,
    [apematt] NVARCHAR(30)  NULL,
    [telefonot] BIGINT  NULL,
    [observaciones] NVARCHAR(1000)  NULL,
    [fechaingreso] NVARCHAR(100)  NULL,
    CONSTRAINT [PK_alumnos] PRIMARY KEY CLUSTERED ([idalumno])
);
GO
INSERT INTO [dbo].[alumnos] ([idalumno], [idcarrera], [repetidor], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [documentacion], [nombret], [apepatt], [apematt], [telefonot], [observaciones], [fechaingreso]) VALUES (N'120220371-5', N'INFO', 0, N'Diego', N'Carmona', N'Bernal', N'Av. Francisco Sarabia #14 Col. Bienestar Social', N'Tuxtla Gutierrez ', 9611387638, N'DDDKDKDK', N'JFJFJFJ', 1, N'Vicenta', N'Bernal', N'Fernandez', 9611799162, NULL, N'25/11/2014');
INSERT INTO [dbo].[alumnos] ([idalumno], [idcarrera], [repetidor], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [documentacion], [nombret], [apepatt], [apematt], [telefonot], [observaciones], [fechaingreso]) VALUES (N'120220371-6', N'INFO', 0, N'Moises', N'Gomez', N'Melendez', N'Conocida', N'Conocida', 961, N'Conocida', N'Conocida', 1, N'Conocida', N'Conocida', N'Conocida', 961, NULL, N'25/11/2014');
INSERT INTO [dbo].[alumnos] ([idalumno], [idcarrera], [repetidor], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [documentacion], [nombret], [apepatt], [apematt], [telefonot], [observaciones], [fechaingreso]) VALUES (N'120220371-7', N'INFO', 0, N'Fabiola', N'Juarez', N'Cadenas', N'Conocida', N'Conocida', 961, N'Conocida', N'Conocida', 1, N'Conocida', N'Conocida', N'Conocida', 961, NULL, N'25/11/2014');
INSERT INTO [dbo].[alumnos] ([idalumno], [idcarrera], [repetidor], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [documentacion], [nombret], [apepatt], [apematt], [telefonot], [observaciones], [fechaingreso]) VALUES (N'120220371-9', N'AUTOM', 0, N'Diego', N'kdkdk', N'ii', N'9', N'9', 9, N'i', N'i', 1, N'9', N'99', N'9', 9, NULL, N'09/12/2014');
GO
IF OBJECT_ID(N'[dbo].[caificaciones]', N'U') IS NOT NULL DROP TABLE [dbo].[caificaciones];
GO
CREATE TABLE [dbo].[caificaciones] (
    [idcalificacion] NVARCHAR(10)  NOT NULL,
    [periodoescolar] NVARCHAR(10)  NULL,
    [idalumno] NVARCHAR(20)  NULL,
    [idgrupo] NVARCHAR(10)  NULL,
    [iddetallecalificacion] NVARCHAR(10)  NULL,
    [promediogeneral] INT  NULL,
    CONSTRAINT [PK_caificaciones] PRIMARY KEY CLUSTERED ([idcalificacion])
);
GO
INSERT INTO [dbo].[caificaciones] ([idcalificacion], [periodoescolar], [idalumno], [idgrupo], [iddetallecalificacion], [promediogeneral]) VALUES (N'1', N'12020', N'120220371-5', N'1204', N'1', 8);
GO
IF OBJECT_ID(N'[dbo].[carreras]', N'U') IS NOT NULL DROP TABLE [dbo].[carreras];
GO
CREATE TABLE [dbo].[carreras] (
    [idcarrera] NVARCHAR(10)  NOT NULL,
    [nombre] NVARCHAR(30)  NULL,
    [descripcion] NVARCHAR(1000)  NULL,
    [plandeestudios] NVARCHAR(120)  NULL,
    CONSTRAINT [PK_carreras] PRIMARY KEY CLUSTERED ([idcarrera])
);
GO
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'INFO', N'Informatica', NULL, NULL);
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'AUTO', N'Autotronica', NULL, NULL);
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'AUTOM', N'Automotriz', NULL, NULL);
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'HOSP', N'Hospitalidad Turistica', NULL, NULL);
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'CONS', N'Construcción', NULL, NULL);
INSERT INTO [dbo].[carreras] ([idcarrera], [nombre], [descripcion], [plandeestudios]) VALUES (N'TRO', N'Tronco Común', NULL, NULL);
GO
IF OBJECT_ID(N'[dbo].[detallecalificaciones]', N'U') IS NOT NULL DROP TABLE [dbo].[detallecalificaciones];
GO
CREATE TABLE [dbo].[detallecalificaciones] (
    [iddetallecalificacion] NVARCHAR(10)  NOT NULL,
    [idmateria] NVARCHAR(10)  NULL,
    [iddocente] NVARCHAR(10)  NULL,
    [calificacion] INT  NULL,
    CONSTRAINT [PK_detallecalificaciones] PRIMARY KEY CLUSTERED ([iddetallecalificacion])
);
GO
INSERT INTO [dbo].[detallecalificaciones] ([iddetallecalificacion], [idmateria], [iddocente], [calificacion]) VALUES (N'1', N'AUTOG', N'100345-7', 9);
GO
IF OBJECT_ID(N'[dbo].[detallegrupos]', N'U') IS NOT NULL DROP TABLE [dbo].[detallegrupos];
GO
CREATE TABLE [dbo].[detallegrupos] (
    [idgrupo] NVARCHAR(10)  NOT NULL,
    [idalumno] NVARCHAR(20)  NULL,
    CONSTRAINT [PK_detallegrupos] PRIMARY KEY CLUSTERED ([idgrupo])
);
GO
INSERT INTO [dbo].[detallegrupos] ([idgrupo], [idalumno]) VALUES (N'1204', N'120220371-5');
GO
IF OBJECT_ID(N'[dbo].[docentes]', N'U') IS NOT NULL DROP TABLE [dbo].[docentes];
GO
CREATE TABLE [dbo].[docentes] (
    [iddocente] NVARCHAR(20)  NOT NULL,
    [nombre] NVARCHAR(40)  NULL,
    [apepat] NVARCHAR(30)  NULL,
    [apemat] NVARCHAR(30)  NULL,
    [direccion] NVARCHAR(120)  NULL,
    [municipio] NVARCHAR(40)  NULL,
    [telefono] BIGINT  NULL,
    [curp] NVARCHAR(18)  NULL,
    [rfc] NVARCHAR(13)  NULL,
    [fechaingreso] DATETIME  NULL,
    [nivelestudios] NVARCHAR(40)  NULL,
    CONSTRAINT [PK_docentes] PRIMARY KEY CLUSTERED ([iddocente])
);
GO
INSERT INTO [dbo].[docentes] ([iddocente], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [fechaingreso], [nivelestudios]) VALUES (N'100345-7', N'Naiver de Jesus', N'Perez', N'Albores', N'Conocida', N'Tuxtla Gutierrez', 9612345678, N'Conocida', N'Conocida', '2014-11-08 00:00:00', N'Doctorado');
GO
IF OBJECT_ID(N'[dbo].[gestionescolar]', N'U') IS NOT NULL DROP TABLE [dbo].[gestionescolar];
GO
CREATE TABLE [dbo].[gestionescolar] (
    [periodoescolar] NVARCHAR(10)  NOT NULL,
    [fechainicio] DATETIME  NULL,
    [fechafinal] DATETIME  NULL,
    CONSTRAINT [PK_gestionescolar] PRIMARY KEY CLUSTERED ([periodoescolar])
);
GO
INSERT INTO [dbo].[gestionescolar] ([periodoescolar], [fechainicio], [fechafinal]) VALUES (N'12020', '2014-11-08 00:00:00', '2015-11-08 00:00:00');
GO
IF OBJECT_ID(N'[dbo].[grupos]', N'U') IS NOT NULL DROP TABLE [dbo].[grupos];
GO
CREATE TABLE [dbo].[grupos] (
    [idgrupo] NVARCHAR(10)  NOT NULL,
    [nombre] NVARCHAR(20)  NULL,
    [idsemestre] NVARCHAR(10)  NULL,
    [idcarrera] NVARCHAR(10)  NULL,
    [curso] INT  NULL,
    [descripcion] NVARCHAR(1000)  NULL,
    CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED ([idgrupo])
);
GO
INSERT INTO [dbo].[grupos] ([idgrupo], [nombre], [idsemestre], [idcarrera], [curso], [descripcion]) VALUES (N'1204', N'1204', N'SEM1', N'INFO', 0, NULL);
GO
IF OBJECT_ID(N'[dbo].[materias]', N'U') IS NOT NULL DROP TABLE [dbo].[materias];
GO
CREATE TABLE [dbo].[materias] (
    [idmateria] NVARCHAR(10)  NOT NULL,
    [nombre] NVARCHAR(40)  NULL,
    [idsemestre] NVARCHAR(10)  NULL,
    [idcarrera] NVARCHAR(10)  NULL,
    [curso] INT  NULL,
    [descripcion] NVARCHAR(1000)  NULL,
    CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED ([idmateria])
);
GO
INSERT INTO [dbo].[materias] ([idmateria], [nombre], [idsemestre], [idcarrera], [curso], [descripcion]) VALUES (N'AUTOG', N'Autogestión del Aprendizaje', N'SEM1', N'TRO', 0, NULL);
GO
IF OBJECT_ID(N'[dbo].[personal]', N'U') IS NOT NULL DROP TABLE [dbo].[personal];
GO
CREATE TABLE [dbo].[personal] (
    [idpersonal] NVARCHAR(20)  NOT NULL,
    [nombre] NVARCHAR(40)  NULL,
    [apepat] NVARCHAR(30)  NULL,
    [apemat] NVARCHAR(30)  NULL,
    [direccion] NVARCHAR(120)  NULL,
    [municipio] NVARCHAR(40)  NULL,
    [telefono] BIGINT  NULL,
    [curp] NVARCHAR(18)  NULL,
    [rfc] NVARCHAR(13)  NULL,
    [fechaingreso] DATETIME  NULL,
    [cargo] NVARCHAR(40)  NULL,
    CONSTRAINT [PK_personal] PRIMARY KEY CLUSTERED ([idpersonal])
);
GO
INSERT INTO [dbo].[personal] ([idpersonal], [nombre], [apepat], [apemat], [direccion], [municipio], [telefono], [curp], [rfc], [fechaingreso], [cargo]) VALUES (N'12034-9', N'Diego', N'Carmona', N'Bernal', N'Conocida', N'Tuxtla Gutierrez', 9617898237, N'Conocida', N'Conocida', '2014-11-08 00:00:00', N'Recursos Humanos');
GO
IF OBJECT_ID(N'[dbo].[semestres]', N'U') IS NOT NULL DROP TABLE [dbo].[semestres];
GO
CREATE TABLE [dbo].[semestres] (
    [idsemestre] NVARCHAR(10)  NOT NULL,
    [nombre] NVARCHAR(20)  NULL,
    [descripcion] NVARCHAR(1000)  NULL,
    CONSTRAINT [PK_semestres] PRIMARY KEY CLUSTERED ([idsemestre])
);
GO
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM1', N'Primer Semestre', NULL);
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM2', N'Segundo Semestre', NULL);
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM3', N'Tercer Semestre', NULL);
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM4', N'Cuarto Semestre', NULL);
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM5', N'Quinto Semestre', NULL);
INSERT INTO [dbo].[semestres] ([idsemestre], [nombre], [descripcion]) VALUES (N'SEM6', N'Sexto Semestre', NULL);
GO
IF OBJECT_ID(N'[dbo].[usuarios]', N'U') IS NOT NULL DROP TABLE [dbo].[usuarios];
GO
CREATE TABLE [dbo].[usuarios] (
    [usuario] NVARCHAR(20)  NOT NULL,
    [contrasena] NVARCHAR(40)  NULL,
    [permisos] INT  NULL,
    [imagen] NVARCHAR(100)  NULL,
    CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED ([usuario])
);
GO
INSERT INTO [dbo].[usuarios] ([usuario], [contrasena], [permisos], [imagen]) VALUES (N'120220371-5', N'120220371-5', 100, N'diego.jpg');
INSERT INTO [dbo].[usuarios] ([usuario], [contrasena], [permisos], [imagen]) VALUES (N'120220371-6', N'120220371-6', 100, N'moises.jpg');
INSERT INTO [dbo].[usuarios] ([usuario], [contrasena], [permisos], [imagen]) VALUES (N'120220371-7', N'120220371-7', 100, N'fabiola.JPG');
GO
