USE [master]
GO
/****** Object:  Database [SGRTC1]    Script Date: 10/10/2023 11:20:25 p. m. ******/
CREATE DATABASE [SGRTC1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SGRTC1', FILENAME = N'D:\Programs Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SGRTC1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SGRTC1_log', FILENAME = N'D:\Programs Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SGRTC1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SGRTC1] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SGRTC1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SGRTC1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SGRTC1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SGRTC1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SGRTC1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SGRTC1] SET ARITHABORT OFF 
GO
ALTER DATABASE [SGRTC1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SGRTC1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SGRTC1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SGRTC1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SGRTC1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SGRTC1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SGRTC1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SGRTC1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SGRTC1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SGRTC1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SGRTC1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SGRTC1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SGRTC1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SGRTC1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SGRTC1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SGRTC1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SGRTC1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SGRTC1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SGRTC1] SET  MULTI_USER 
GO
ALTER DATABASE [SGRTC1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SGRTC1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SGRTC1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SGRTC1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SGRTC1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SGRTC1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SGRTC1] SET QUERY_STORE = ON
GO
ALTER DATABASE [SGRTC1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SGRTC1]
GO
/****** Object:  Table [dbo].[BitacoraInicioSesion]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraInicioSesion](
	[BitacoraID] [int] IDENTITY(1,1) NOT NULL,
	[PersonalID] [int] NULL,
	[FechaInicioSesion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BitacoraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Celular]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Celular](
	[CelularID] [int] NOT NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[IMEI] [varchar](15) NULL,
	[Estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CelularID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleReparacion]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleReparacion](
	[DetalleReparacionID] [int] NOT NULL,
	[Folio] [int] NULL,
	[CelularID] [int] NULL,
	[UsuarioID] [int] NULL,
	[Monto] [decimal](10, 2) NULL,
	[FechaReparacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleReparacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalReparacion]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalReparacion](
	[PersonalID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Contrasena] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refaccion]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refaccion](
	[RefaccionID] [int] NOT NULL,
	[CelularID] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Precio] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[RefaccionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/10/2023 11:20:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Direccion] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BitacoraInicioSesion] ON 

INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (1, 1, CAST(N'2023-10-10T18:53:17.570' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (2, 1, CAST(N'2023-10-10T19:02:48.240' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (3, 1, CAST(N'2023-10-10T19:21:00.530' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (4, 1, CAST(N'2023-10-10T20:04:37.337' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (5, 1, CAST(N'2023-10-10T20:13:22.400' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (6, 1, CAST(N'2023-10-10T20:17:08.350' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (7, 1, CAST(N'2023-10-10T21:14:08.970' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (8, 1, CAST(N'2023-10-10T21:17:24.810' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (9, 1, CAST(N'2023-10-10T21:20:41.003' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (10, 1, CAST(N'2023-10-10T21:22:51.510' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (11, 1, CAST(N'2023-10-10T21:24:02.563' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (12, 1, CAST(N'2023-10-10T21:30:07.723' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (13, 1, CAST(N'2023-10-10T21:31:25.940' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (14, 1, CAST(N'2023-10-10T21:34:56.590' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (15, 1, CAST(N'2023-10-10T21:51:23.510' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (16, 1, CAST(N'2023-10-10T22:17:38.263' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (17, 1, CAST(N'2023-10-10T22:23:20.253' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (18, 1, CAST(N'2023-10-10T22:46:28.000' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (19, 1, CAST(N'2023-10-10T22:58:02.790' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (20, 1, CAST(N'2023-10-10T23:05:02.867' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (21, 1, CAST(N'2023-10-10T23:08:16.433' AS DateTime))
INSERT [dbo].[BitacoraInicioSesion] ([BitacoraID], [PersonalID], [FechaInicioSesion]) VALUES (22, 1, CAST(N'2023-10-10T23:17:01.963' AS DateTime))
SET IDENTITY_INSERT [dbo].[BitacoraInicioSesion] OFF
GO
INSERT [dbo].[Celular] ([CelularID], [Marca], [Modelo], [IMEI], [Estado]) VALUES (1, N'Samsung', N'Galaxy S21', N'123456789012345', N'En Reparacion')
INSERT [dbo].[Celular] ([CelularID], [Marca], [Modelo], [IMEI], [Estado]) VALUES (2, N'Apple', N'iPhone 15', N'987654321098765', N'Reparado')
INSERT [dbo].[Celular] ([CelularID], [Marca], [Modelo], [IMEI], [Estado]) VALUES (3, N'Google', N'Pixel 6', N'567890123456789', N'En Reparacion')
INSERT [dbo].[Celular] ([CelularID], [Marca], [Modelo], [IMEI], [Estado]) VALUES (4, N'qqwwe', N'qwee', N'123', N'dsa')
GO
INSERT [dbo].[DetalleReparacion] ([DetalleReparacionID], [Folio], [CelularID], [UsuarioID], [Monto], [FechaReparacion]) VALUES (1, 101, 1, 1, CAST(150.00 AS Decimal(10, 2)), CAST(N'2023-10-01T10:00:00.000' AS DateTime))
INSERT [dbo].[DetalleReparacion] ([DetalleReparacionID], [Folio], [CelularID], [UsuarioID], [Monto], [FechaReparacion]) VALUES (2, 102, 2, 2, CAST(125.00 AS Decimal(10, 2)), CAST(N'2023-10-02T15:30:00.000' AS DateTime))
INSERT [dbo].[DetalleReparacion] ([DetalleReparacionID], [Folio], [CelularID], [UsuarioID], [Monto], [FechaReparacion]) VALUES (3, 103, 3, 3, CAST(75.00 AS Decimal(10, 2)), CAST(N'2023-10-03T09:15:00.000' AS DateTime))
INSERT [dbo].[DetalleReparacion] ([DetalleReparacionID], [Folio], [CelularID], [UsuarioID], [Monto], [FechaReparacion]) VALUES (4, 104, 1, 2, CAST(200.00 AS Decimal(10, 2)), CAST(N'2023-10-04T14:45:00.000' AS DateTime))
GO
INSERT [dbo].[PersonalReparacion] ([PersonalID], [Nombre], [Apellido], [Cargo], [Usuario], [Contrasena]) VALUES (1, N'Marco', N'Gonzalez', N'Administrador', N'MAGJ', N'contrasena123')
GO
INSERT [dbo].[Refaccion] ([RefaccionID], [CelularID], [Nombre], [Precio]) VALUES (1, 1, N'Pantalla', CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[Refaccion] ([RefaccionID], [CelularID], [Nombre], [Precio]) VALUES (2, 1, N'Bateria', CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[Refaccion] ([RefaccionID], [CelularID], [Nombre], [Precio]) VALUES (3, 2, N'Camara Trasera', CAST(75.00 AS Decimal(10, 2)))
INSERT [dbo].[Refaccion] ([RefaccionID], [CelularID], [Nombre], [Precio]) VALUES (4, 3, N'Botones Volumen', CAST(10.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Usuario] ([UsuarioID], [Nombre], [Apellido], [Direccion], [Email]) VALUES (1, N'Juan', N'Perez', N'Calle 123, Ciudad', N'juan@example.com')
INSERT [dbo].[Usuario] ([UsuarioID], [Nombre], [Apellido], [Direccion], [Email]) VALUES (2, N'Marta', N'Gonzalez', N'Avenida XYZ, Pueblo', N'maria@example.com')
INSERT [dbo].[Usuario] ([UsuarioID], [Nombre], [Apellido], [Direccion], [Email]) VALUES (3, N'Pedro', N'Lopez', N'Carrera 456, Villa', N'pedro@example.com')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Celular__8DF371FD3C47E0C1]    Script Date: 10/10/2023 11:20:25 p. m. ******/
ALTER TABLE [dbo].[Celular] ADD UNIQUE NONCLUSTERED 
(
	[IMEI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Personal__E3237CF742CB7ED5]    Script Date: 10/10/2023 11:20:25 p. m. ******/
ALTER TABLE [dbo].[PersonalReparacion] ADD UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BitacoraInicioSesion]  WITH CHECK ADD  CONSTRAINT [FK_PersonalID] FOREIGN KEY([PersonalID])
REFERENCES [dbo].[PersonalReparacion] ([PersonalID])
GO
ALTER TABLE [dbo].[BitacoraInicioSesion] CHECK CONSTRAINT [FK_PersonalID]
GO
ALTER TABLE [dbo].[DetalleReparacion]  WITH CHECK ADD FOREIGN KEY([CelularID])
REFERENCES [dbo].[Celular] ([CelularID])
GO
ALTER TABLE [dbo].[DetalleReparacion]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuario] ([UsuarioID])
GO
ALTER TABLE [dbo].[Refaccion]  WITH CHECK ADD FOREIGN KEY([CelularID])
REFERENCES [dbo].[Celular] ([CelularID])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[IniciarSesionPersonal]    Script Date: 10/10/2023 11:20:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IniciarSesionPersonal]
    @Usuario VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción
        BEGIN TRANSACTION;

        DECLARE @PersonalID INT

        -- Verificar si las credenciales son válidas
        SELECT @PersonalID = PersonalID
        FROM PersonalReparacion
        WHERE Usuario = @Usuario AND Contrasena = @Contraseña
		
		-- Retornamos 1 si es exitoso o 0 si no lo es
		Select top 1 COUNT(*) From PersonalReparacion WHERE Usuario = @Usuario AND Contrasena = @Contraseña
        
		-- Si las credenciales son válidas, permitir el acceso y registrar en la bitácora
        IF @PersonalID IS NOT NULL
        BEGIN
            -- Acceso permitido, imprimir mensaje de inicio de sesión exitoso
            PRINT 'Inicio de sesión exitoso para el usuario ' + @Usuario

            -- Registrar el inicio de sesión en la bitácora
            INSERT INTO BitacoraInicioSesion (PersonalID, FechaInicioSesion)
            VALUES (@PersonalID, GETDATE()) -- Registra la fecha y hora actual

            -- Puedes agregar acciones adicionales aquí, como registrar la hora de inicio de sesión.
        END
        ELSE
        BEGIN
            -- Acceso denegado, imprimir mensaje de inicio de sesión fallido
            PRINT 'Inicio de sesión fallido. Credenciales incorrectas.'
        END

        -- Cometer la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- En caso de error, imprimir mensaje de error y hacer un ROLLBACK
        PRINT 'Se produjo un error durante el inicio de sesión.';
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_AltaCelular]    Script Date: 10/10/2023 11:20:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AltaCelular]
    @CelularID INT,
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @IMEI VARCHAR(15),
    @Estado VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        -- Intentar insertar un nuevo celular en la tabla Celular
        INSERT INTO Celular (CelularID, Marca, Modelo, IMEI, Estado)
        VALUES (@CelularID, @Marca, @Modelo, @IMEI, @Estado);

        PRINT 'Se ha dado de alta un nuevo celular.';
    END TRY
    BEGIN CATCH
        -- En caso de error, imprimir mensaje de error y hacer un ROLLBACK
        PRINT 'Se produjo un error al intentar dar de alta el celular.';
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCelular]    Script Date: 10/10/2023 11:20:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EliminarCelular]
    @CelularID INT
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción
        BEGIN TRANSACTION;

        -- Verificar si el celular con el CelularID proporcionado existe
        IF EXISTS (SELECT 1 FROM Celular WHERE CelularID = @CelularID)
        BEGIN
            -- Eliminar el celular de la tabla Celular
            DELETE FROM Celular WHERE CelularID = @CelularID;

            PRINT 'Se ha eliminado el celular con CelularID ' + CAST(@CelularID AS VARCHAR) + '.';
        END
        ELSE
        BEGIN
            PRINT 'El celular con CelularID ' + CAST(@CelularID AS VARCHAR) + ' no existe en la base de datos.';
        END

        -- Cometer la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- En caso de error, imprimir mensaje de error y hacer un ROLLBACK
        PRINT 'Se produjo un error al intentar eliminar el celular.';
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarCelular]    Script Date: 10/10/2023 11:20:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarCelular]
    @CelularID INT,
    @Marca VARCHAR(50),
    @Modelo VARCHAR(50),
    @IMEI VARCHAR(15),
    @Estado VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción
        BEGIN TRANSACTION;

        -- Verificar si el celular con el CelularID proporcionado existe
        IF EXISTS (SELECT 1 FROM Celular WHERE CelularID = @CelularID)
        BEGIN
            -- Actualizar la información del celular
            UPDATE Celular
            SET Marca = @Marca,
                Modelo = @Modelo,
                IMEI = @IMEI,
                Estado = @Estado
            WHERE CelularID = @CelularID;

            PRINT 'La información del celular se ha actualizado correctamente.';
        END
        ELSE
        BEGIN
            PRINT 'El celular con CelularID ' + CAST(@CelularID AS VARCHAR) + ' no existe.';
        END

        -- Cometer la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- En caso de error, imprimir mensaje de error y hacer un ROLLBACK
        PRINT 'Se produjo un error al intentar modificar la información del celular.';
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
USE [master]
GO
ALTER DATABASE [SGRTC1] SET  READ_WRITE 
GO
