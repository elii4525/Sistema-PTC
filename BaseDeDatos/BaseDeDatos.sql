
USE master;
GO

IF DB_ID('BasePTC') IS NOT NULL
    DROP DATABASE BasePTC;
GO
CREATE DATABASE BasePTC;
GO
USE BasePTC;
GO

-- Tablas
CREATE TABLE Rol (
    idRol INT IDENTITY (1,1) PRIMARY KEY,
    tipoRol VARCHAR (50) NOT NULL,
    descripcionRol VARCHAR (500) NOT NULL
);
GO

CREATE TABLE Usuario (
    idUsuario INT IDENTITY (1,1) PRIMARY KEY,
    nombre VARCHAR (50) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    contraseña VARCHAR(250),
    telefono VARCHAR (20),
    correo VARCHAR (75) UNIQUE,
    id_Rol INT,
    CONSTRAINT fk_rol FOREIGN KEY (id_Rol) REFERENCES Rol(idRol)
);
insert into Usuario values ('Daniel', '2007-10-03', '$2y$10$ja9D65NqxCm3ZwaCeyA1FeiqFAzdYZufkU1LKdWZ7ReFEmXn2Whce', 12345678, 'danielorlandoperezvasquez@gmail.com', 1)
GO 

CREATE TABLE Categoria (
    idCategoria INT IDENTITY (1,1) PRIMARY KEY,
    nombreCategoria VARCHAR (70), 
    descripcionCategoria VARCHAR (300)
);
GO

CREATE TABLE Marca (
    idMarca INT IDENTITY (1,1) PRIMARY KEY,
    nombreMarca VARCHAR (70) NOT NULL
);
GO

CREATE TABLE Material (
    idMaterial INT IDENTITY (1,1) PRIMARY KEY,
    nombreMaterial VARCHAR (100) NOT NULL,
    cantidad INT NOT NULL,
    fechaIngreso DATE,
    descripcionMaterial VARCHAR (500),
    modelo VARCHAR (100) UNIQUE,
    id_Categoria INT,
    id_Marca INT,
    CONSTRAINT fk_Categoria FOREIGN KEY(id_Categoria) REFERENCES Categoria(idCategoria) ON DELETE CASCADE,
    CONSTRAINT fk_Marca FOREIGN KEY(id_Marca) REFERENCES Marca(idMarca) ON DELETE CASCADE
);
GO

CREATE TABLE Solicitud (
    idSolicitud INT IDENTITY (1,1) PRIMARY KEY,
    motivo VARCHAR (1000) NOT NULL,
    fecha DATE NOT NULL,
    estado VARCHAR (50) NOT NULL,
    id_Usuario INT,
    id_Material INT,
    CONSTRAINT fk_Material FOREIGN KEY (id_Material) REFERENCES Material(idMaterial) ON DELETE CASCADE,
    CONSTRAINT fk_usuario FOREIGN KEY (id_Usuario) REFERENCES Usuario(idUsuario)
);
GO

CREATE TABLE SolicitudMaterial (
    idSolicitudMaterial INT IDENTITY(1,1) PRIMARY KEY,
    idSolicitud INT NOT NULL,
    idMaterial INT NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT fk_Solicitud FOREIGN KEY (idSolicitud) REFERENCES Solicitud(idSolicitud),
    CONSTRAINT fk_MaterialSolicitud FOREIGN KEY (idMaterial) REFERENCES Material(idMaterial)
);
GO

CREATE TABLE salidaDeMaterial (
    idSalidamaterial INT IDENTITY(1,1) PRIMARY KEY,
    id_Material INT NOT NULL,
    cantidadConsumida INT NOT NULL,
    fechaConsumo DATE NOT NULL,
    id_Usuario INT NOT NULL,
    motivoSalida VARCHAR(1000),
    CONSTRAINT fk_salida_material FOREIGN KEY (id_Material) REFERENCES Material(idMaterial) ON DELETE CASCADE,
    CONSTRAINT fk_salida_usuario FOREIGN KEY (id_Usuario) REFERENCES Usuario(idUsuario)
);
GO

-- Vistas
CREATE VIEW VerUltimosUsuarios
AS
SELECT TOP 10 
    u.idUsuario AS Codigo,
    u.nombre AS Nombre,
    u.fechaNacimiento AS [Fecha de Nacimiento],
    u.telefono AS Telefono,
    u.correo AS Correo,
    r.tipoRol AS Rol,
    r.descripcionRol AS DescripcionRol
FROM Usuario u
INNER JOIN Rol r ON u.id_Rol = r.idRol
ORDER BY u.idUsuario DESC;
GO

CREATE VIEW VerUsuarios
AS
SELECT 
    u.idUsuario AS Codigo,
    u.correo AS Correo,
    u.contraseña AS Contraseña,
    r.tipoRol AS Rol
FROM Usuario u
INNER JOIN Rol r ON u.id_Rol = r.idRol;
GO

CREATE VIEW selectMateriales AS 
SELECT 
    m.idMaterial AS Codigo,
    m.nombreMaterial AS [Nombre del Material], 
    m.cantidad AS Cantidad, 
    m.fechaIngreso AS [Fecha de Ingreso], 
    m.descripcionMaterial AS [Descripción], 
    m.modelo AS [Modelo], 
    c.nombreCategoria AS [Categoría], 
    mar.nombreMarca AS [Marca]
FROM Material m
INNER JOIN Categoria c ON c.idCategoria = m.id_Categoria
INNER JOIN Marca mar ON mar.idMarca = m.id_Marca;
GO

CREATE VIEW registrosUlt AS 
SELECT TOP 10
    m.nombreMaterial AS [Nombre del Material], 
    m.cantidad AS Cantidad, 
    m.fechaIngreso AS [Fecha de Ingreso], 
    m.descripcionMaterial AS [Descripción], 
    m.modelo AS [Modelo], 
    c.nombreCategoria AS [Categoría], 
    mar.nombreMarca AS [Marca]
FROM Material m
INNER JOIN Categoria c ON c.idCategoria = m.id_Categoria
INNER JOIN Marca mar ON mar.idMarca = m.id_Marca
ORDER BY m.idMaterial DESC;
GO

-- Procedimientos
IF OBJECT_ID('sp_obtener_inventario_categorias','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_inventario_categorias;
GO
CREATE PROCEDURE sp_obtener_inventario_categorias
AS
BEGIN
    SELECT 
        m.nombreMaterial,
        m.cantidad,
        c.nombreCategoria
    FROM Material m
    INNER JOIN Categoria c ON m.id_Categoria = c.idCategoria
    WHERE c.nombreCategoria IN ('computación', 'periféricos', 'limpieza', 'papeleria')
    ORDER BY c.nombreCategoria, m.nombreMaterial;
END
GO

IF OBJECT_ID('sp_obtener_stock_material','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_stock_material;
GO
CREATE PROCEDURE sp_obtener_stock_material
    @id_material INT
AS
BEGIN
    SELECT cantidad
    FROM Material
    WHERE idMaterial = @id_material;
END
GO

IF OBJECT_ID('spu_obtenerinventariomaterial','P') IS NOT NULL
    DROP PROCEDURE spu_obtenerinventariomaterial;
GO
CREATE PROCEDURE spu_obtenerinventariomaterial
    @nombrematerial VARCHAR(100)
AS
BEGIN
    SELECT
        nombreMaterial,
        cantidad AS cantidadInventario
    FROM Material
    WHERE nombreMaterial LIKE '%' + @nombrematerial + '%'
    ORDER BY nombreMaterial;
END;
GO

IF OBJECT_ID('sp_obtener_consumo_material','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_consumo_material;
GO
CREATE PROCEDURE sp_obtener_consumo_material
AS
BEGIN
    SELECT 
        m.nombreMaterial,
        SUM(s.cantidadConsumida) AS total_consumido
    FROM salidaDeMaterial s
    INNER JOIN Material m ON s.id_Material = m.idMaterial
    GROUP BY m.nombreMaterial
    ORDER BY total_consumido DESC;
END
GO

IF OBJECT_ID('sp_obtener_catalogo_completo','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_catalogo_completo;
GO
CREATE PROCEDURE sp_obtener_catalogo_completo
AS
BEGIN
    SELECT 
        m.nombreMaterial,
        m.cantidad,
        m.descripcionMaterial,
        m.modelo,
        c.nombreCategoria,
        ma.nombreMarca
    FROM Material m
    INNER JOIN Categoria c ON m.id_Categoria = c.idCategoria
    INNER JOIN Marca ma ON m.id_Marca = ma.idMarca
    ORDER BY c.nombreCategoria, m.nombreMaterial;
END
GO

IF OBJECT_ID('sp_obtener_materiales_combo','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_materiales_combo;
GO
CREATE PROCEDURE sp_obtener_materiales_combo
AS
BEGIN
    SELECT 
        m.idMaterial,
        m.nombreMaterial,
        ma.nombreMarca,
        m.cantidad
    FROM Material m
    INNER JOIN Marca ma ON m.id_Marca = ma.idMarca
    ORDER BY m.nombreMaterial;
END
GO

IF OBJECT_ID('sp_registrar_salida_materialll','P') IS NOT NULL
    DROP PROCEDURE sp_registrar_salida_materialll;
GO
CREATE PROCEDURE sp_registrar_salida_materialll
    @id_material INT = NULL,
    @nombre_material VARCHAR(100) = NULL,
    @cantidad_consumida INT,
    @fecha_consumo DATE,
    @id_usuario INT,
    @motivo_salida VARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_material_local INT;
    DECLARE @stock_actual INT;

    IF @id_material IS NULL AND @nombre_material IS NOT NULL
    BEGIN
        SELECT TOP 1 @id_material_local = idMaterial
        FROM Material
        WHERE nombreMaterial = @nombre_material;
    END
    ELSE
        SET @id_material_local = @id_material;

    SELECT @stock_actual = cantidad
    FROM Material
    WHERE idMaterial = @id_material_local;

    IF @stock_actual < @cantidad_consumida
    BEGIN
        RAISERROR ('No hay suficiente stock para realizar la salida. Stock actual: %d', 16, 1, @stock_actual);
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO salidaDeMaterial (id_Material, cantidadConsumida, fechaConsumo, id_Usuario, motivoSalida)
        VALUES (@id_material_local, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);

        UPDATE Material
        SET cantidad = cantidad - @cantidad_consumida
        WHERE idMaterial = @id_material_local;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

IF OBJECT_ID('sp_obtener_historial_salidas','P') IS NOT NULL
    DROP PROCEDURE sp_obtener_historial_salidas;
GO
CREATE PROCEDURE sp_obtener_historial_salidas
AS
BEGIN
    SELECT 
        s.idSalidamaterial,
        m.nombreMaterial,
        ma.nombreMarca,
        s.cantidadConsumida,
        s.fechaConsumo,
        s.motivoSalida,
        u.nombre AS usuario_registra
    FROM salidaDeMaterial s
    INNER JOIN Material m ON s.id_Material = m.idMaterial
    INNER JOIN Marca ma ON m.id_Marca = ma.idMarca
    INNER JOIN Usuario u ON s.id_Usuario = u.idUsuario
    ORDER BY s.fechaConsumo DESC;
END
GO

IF OBJECT_ID('spu_registrarconsumo','P') IS NOT NULL
    DROP PROCEDURE spu_registrarconsumo;
GO
CREATE PROCEDURE spu_registrarconsumo
    @id_material INT = NULL,
    @nombre_material VARCHAR(100) = NULL,
    @cantidad_consumida INT,
    @fecha_consumo DATE,
    @id_usuario INT,
    @motivo_salida VARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_material_local INT;
    DECLARE @stock_actual INT;

    IF @id_material IS NOT NULL
    BEGIN
        SELECT @id_material_local = idMaterial, @stock_actual = cantidad
        FROM Material
        WHERE idMaterial = @id_material;
    END
    ELSE IF @nombre_material IS NOT NULL
    BEGIN
        SELECT @id_material_local = idMaterial, @stock_actual = cantidad
        FROM Material
        WHERE nombreMaterial = @nombre_material;
    END
    ELSE
    BEGIN
        RAISERROR('Se requiere id_material o nombre_material.', 16, 1);
        RETURN;
    END

    IF @id_material_local IS NULL
    BEGIN
        RAISERROR('El material especificado no existe en el inventario.', 16, 1);
        RETURN;
    END

    IF @stock_actual < @cantidad_consumida
    BEGIN
        RAISERROR('Stock insuficiente. Solo quedan %d unidades.', 16, 1, @stock_actual);
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO salidaDeMaterial (id_Material, cantidadConsumida, fechaConsumo, id_Usuario, motivoSalida)
        VALUES (@id_material_local, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);

        UPDATE Material
        SET cantidad = cantidad - @cantidad_consumida
        WHERE idMaterial = @id_material_local;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Inserts
INSERT INTO Rol (tipoRol, descripcionRol)
VALUES 
('Jefatura', 'Este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('Departamento IT', 'Este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');
GO

-- Selects 
SELECT * FROM Rol;
SELECT * FROM Usuario;
SELECT * FROM Categoria;
SELECT * FROM Marca;
SELECT * FROM Material;
SELECT * FROM Solicitud;
SELECT * FROM SolicitudMaterial;
SELECT * FROM salidaDeMaterial;
SELECT * FROM VerUltimosUsuarios;
SELECT * FROM VerUsuarios;
SELECT * FROM selectMateriales;
SELECT * FROM registrosUlt;
