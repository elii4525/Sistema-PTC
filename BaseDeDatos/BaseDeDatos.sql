create database BasePTCC
go
use BasePTCC;
go

-- Tables 
create table Rol (
idRol int identity (1,1) primary key,
tipoRol varchar (50) not null,
descripcionRol varchar (500) not null);
go

create table Usuario (
idUsuario int identity (1,1) primary key,
nombre varchar (50) not null,
fechaNacimiento date not null,
contrase�a varchar(250),
telefono varchar (20),
correo varchar (75) unique,
id_Rol int,
constraint fk_rol Foreign key (id_Rol) references Rol(idRol));
go 

create table Categoria (
idCategoria int identity (1,1) primary key,
nombreCategoria varchar (70), 
descripcionCategoria varchar (300));
go


create table Marca (
idMarca int identity (1,1) primary key,
nombreMarca varchar (70) not null);
go

create table Material (
idMaterial int identity (1,1) primary key,
nombreMaterial varchar (100) not null,
cantidad int not null,
fechaIngreso date,
descripcionMaterial varchar (500),
modelo varchar (100) unique,
id_Categoria int,
id_Marca int,
constraint fk_Categoria Foreign key(id_Categoria) references Categoria(idCategoria) ON DELETE CASCADE,
constraint fk_Marca Foreign key(id_Marca) references Marca(idMarca) ON DELETE CASCADE);
go


create table Solicitud (
idSolicitud int identity (1,1) primary key,
motivo varchar (1000) not null,
fecha date not null,
estado varchar (50) not null,
id_Usuario int,
id_Material int,
constraint fk_Material Foreign key (id_Material) references Material(idMaterial)  ON DELETE CASCADE,
constraint fk_usuario Foreign key (id_Usuario) references Usuario(idUsuario));
go

create table SolicitudMaterial (
    idSolicitudMaterial int identity(1,1) primary key,
    idSolicitud int not null,
    idMaterial int not null,
    cantidad int not null,
    constraint fk_Solicitud foreign key (idSolicitud) references Solicitud(idSolicitud),
    constraint fk_MaterialSolicitud foreign key (idMaterial) references Material(idMaterial)
);

create table HistorialSolicitud (
idHistorialSolicitud int identity (1,1) primary key,
estadoSolicitud varchar (50),
fechaRespuesta date,
id_Solicitud int not null,
constraint fk_solicitud Foreign key (id_Solicitud) references Solicitud(idSolicitud) ON DELETE CASCADE);
go
constraint fk_usuario Foreign key (id_Usuario) references Usuario(idUsuario));
go


create table salidaDeMaterial (
    idSalidamaterial int identity(1,1) primary key,
    id_Material int not null,
    cantidadConsumida int not null,
    fechaConsumo date not null,
    id_Usuario int not null,
    motivoSalida varchar(1000),
    constraint fk_salida_material foreign key (id_Material) references Material(idMaterial) ON DELETE CASCADE,
    constraint fk_salida_usuario foreign key (id_Usuario) references Usuario(idUsuario)
);
go

-- Vistas

create view VerUltimosUsuarios
as
select top 10 
    u.idUsuario,
    u.nombre,
    u.fechaNacimiento,
    u.telefono,
    u.correo,
    r.tipoRol,
    r.descripcionRol
from Usuario u
INNER JOIN Rol r on u.id_Rol = r.idRol
order by u.idUsuario desc;
GO

select *from VerUltimosUsuarios

create view VerUsuarios
as
select 
    u.idUsuario,
    u.correo,
    u.contraseña,
    r.tipoRol
from Usuario u
inner join Rol r on u.id_Rol = r.idRol;
go

select *from VerUsuarios

-- Inserts into
insert into Rol 
values ('Jefatura', 'Este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('Departamento IT', 'Este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');
go

insert into Categoria 
values ('Electrónica', 'Dispositivos electrónicos en general'),
('Muebles', 'Mobiliario de oficina y hogar'),
('Papelería', 'Material de oficina y útiles escolares'),
('Limpieza', 'Productos de limpieza y aseo'),
('Deportes', 'Artículos deportivos'),
('Cocina', 'Utensilios y equipos de cocina'),
('Construcción', 'Materiales de construcción'),
('Ropa', 'Vestimenta y textiles'),
('Calzado', 'Zapatos y sandalias'),
('Tecnología', 'Accesorios tecnológicos'),
('Juguetes', 'Juguetes infantiles'),
('Libros', 'Textos y cuadernos'),
('Herramientas', 'Instrumentos de trabajo manual'),
('Decoración', 'Artículos decorativos'),
('Vehículos', 'Accesorios de autos y motos'),
('Jardinería', 'Productos para jardines'),
('Seguridad', 'Cámaras, candados y alarmas'),
('Belleza', 'Cosméticos y productos de cuidado personal'),
('Medicamentos', 'Fármacos y suplementos'),
('Otros', 'Categoría miscelánea');
go

insert into Marca
values ('Sony'),('Samsung'),('LG'),('Apple'),('Dell'),
('HP'),('Acer'),('Lenovo'),('Adidas'),('Nike'),
('Puma'),('Reebok'),('Clorox'),('Colgate'),('Bic'),
('Pilot'),('Toyota'),('Honda'),('Bosch'),('Makita');
go

insert into Material 
values ('Laptop HP', 10, '2023-01-15', 'Laptop de oficina', 'HP-12345', 10, 6),
('Smartphone Samsung', 25, '2023-02-10', 'Teléfono inteligente', 'SM-A52', 1, 2),
('Monitor LG', 15, '2023-03-12', 'Monitor LED 24 pulgadas', 'LG-24MK', 1, 3),
('Impresora Epson', 5, '2023-04-01', 'Impresora multifuncional', 'EP-TX120', 3, 6),
('Silla Oficina', 20, '2023-05-11', 'Silla ergonómica negra', 'SILLA-ERG', 2, 8),
('Balón Adidas', 30, '2023-06-14', 'Balón de fútbol profesional', 'AD-BALON', 5, 9),
('Zapatos Nike', 50, '2023-07-20', 'Zapatos deportivos', 'NK-SPORT', 9, 10),
('Set Herramientas Bosch', 12, '2023-08-22', 'Kit de herramientas mecánicas', 'BOSCH-SET', 13, 19),
('Detergente Clorox', 60, '2023-09-01', 'Detergente líquido', 'CLX-500', 4, 13),
('Perfume Dior', 40, '2023-09-18', 'Perfume de lujo', 'DIOR-XXL', 18, 20),
('Camisa Polo', 70, '2023-09-25', 'Camisa de algodón', 'POLO-CAM', 8, 11),
('Sandalias Puma', 35, '2023-09-30', 'Sandalias deportivas', 'PM-SAND', 9, 11),
('Cámara Sony', 10, '2023-10-05', 'Cámara digital', 'SONY-CAM', 1, 1),
('Tablet Apple', 8, '2023-10-12', 'iPad de 10 pulgadas', 'APL-TAB', 10, 4),
('Licuadora Oster', 18, '2023-10-20', 'Licuadora de vidrio', 'OST-123', 6, 20),
('Martillo Makita', 22, '2023-10-28', 'Martillo profesional', 'MKT-HAM', 13, 20),
('Carro Toyota Corolla', 2, '2023-11-01', 'Vehículo sedán', 'TOY-COR', 15, 17),
('Moto Honda', 4, '2023-11-05', 'Motocicleta 150cc', 'HON-150', 15, 18),
('Sofá 3 puestos', 6, '2023-11-10', 'Sofá de cuero negro', 'SOFA-NEG', 2, 8),
('Libro SQL Server', 25, '2023-11-15', 'Manual de SQL Server', 'BOOK-SQL', 12, 15);
go

insert into Solicitud 
values ('Requiere laptop para oficina', '2023-02-15', 'Pendiente', 1),
('Solicita impresora nueva', '2023-03-01', 'Aprobada', 2),
('Necesita balones para torneo', '2023-03-10', 'Pendiente', 3),
('Reemplazo de monitor dañado', '2023-03-25', 'Rechazada', 4),
('Compra detergente limpieza', '2023-04-05', 'Pendiente', 5),
('Requiere sillas nuevas', '2023-04-12', 'Aprobada', 6),
('Pide zapatos deportivos', '2023-04-20', 'Pendiente', 7),
('Kit herramientas', '2023-05-01', 'Pendiente', 8),
('Libros de consulta', '2023-05-15', 'Aprobada', 9),
('Solicita tablet para oficina', '2023-05-30', 'Pendiente', 10),
('Solicita perfumes para regalos', '2023-06-10', 'Rechazada', 11),
('Necesita sofás nuevos', '2023-06-20', 'Pendiente', 12),
('Pide camisas para uniformes', '2023-07-01', 'Pendiente', 13),
('Requiere cámara para fotografía', '2023-07-10', 'Aprobada', 14),
('Solicita carro institucional', '2023-07-25', 'Pendiente', 15),
('Necesita moto para repartos', '2023-08-01', 'Pendiente', 16),
('Compra licuadoras', '2023-08-15', 'Pendiente', 17),
('Solicita sandalias deportivas', '2023-08-30', 'Aprobada', 18),
('Solicita artículos de limpieza', '2023-09-10', 'Pendiente', 19),
('Compra martillos para taller', '2023-09-25', 'Pendiente', 20);
go

insert into SolicitudMaterial
values (1, 1, 1),(2, 4, 1),(3, 6, 10),(4, 3, 2),(5, 9, 5),
(6, 5, 10),(7, 7, 5),(8, 8, 2),(9, 20, 10),(10, 14, 1),
(11, 10, 3),(12, 19, 2),(13, 11, 20),(14, 13, 1),(15, 17, 1),
(16, 18, 1),(17, 15, 3),(18, 12, 10),(19, 9, 15),(20, 16, 5);
go

insert into salidaDeMaterial
values (1, 1, '2025-03-01', 1, 'Asignación a oficina'),
(4, 1, '2025-03-05', 2, 'Uso en área de impresión'),
(6, 5, '2025-03-15', 3, 'Torneo deportivo'),
(3, 1, '2025-03-30', 4, 'Reemplazo monitor dañado'),
(9, 10, '2025-04-10', 5, 'Limpieza general'),
(5, 5, '2025-04-20', 6, 'Nueva oficina'),
(7, 2, '2025-04-25', 7, 'Entrenamientos'),
(8, 1, '2025-05-05', 8, 'Mantenimiento'),
(20, 5, '2025-05-15', 9, 'Curso SQL'),
(14, 1, '2025-05-25', 10, 'Asignación a dirección'),
(10, 2, '2025-06-01', 11, 'Regalos institucionales'),
(19, 1, '2025-06-15', 12, 'Sala de reuniones'),
(11, 10, '2025-07-05', 13, 'Uniformes'),
(13, 1, '2025-07-15', 14, 'Fotografía evento'),
(17, 1, '2025-07-30', 15, 'Uso institucional'),
(18, 1, '2025-08-05', 16, 'Repartos'),
(15, 2, '2025-08-20', 17, 'Cocina comedor'),
(12, 5, '2025-09-01', 18, 'Deporte'),
(9, 8, '2025-09-15', 19, 'Limpieza bodega');
go

-- Select
Select *from Usuario
Select *from Rol
Select *from Categoria
Select *from Solicitud
Select *from Marca
Select *from Material
Select *from SolicitudMaterial
go

--Creacion de consultas para el sistema en c#

Create View selectMateriales as 
select 
m.idMaterial as Id,
m.nombreMaterial as [Nombre del Material], 
m.cantidad as Cantidad, 
m.fechaIngreso as [Fecha de Ingreso], 
m.descripcionMaterial as [Descripción], 
m.modelo as [Modelo], 
c.nombreCategoria as [Categoría], 
mar.nombreMarca as [Marca] from Material m
Inner Join
Categoria c on c.idCategoria = m.id_Categoria
Inner Join 
Marca mar on mar.idMarca = m.id_Marca;

select *from selectMateriales;

---No está ejecutada, solo copie la vista para añadir el where y subir el comando a c#
select 
m.nombreMaterial as [Nombre del Material], 
m.cantidad as Cantidad, 
m.fechaIngreso as [Fecha de Ingreso], 
m.descripcionMaterial as [Descripción], 
m.modelo as [Modelo], 
c.nombreCategoria as [Categoría], 
mar.nombreMarca as [Marca] from Material m
Inner Join
Categoria c on c.idCategoria = m.id_Categoria
Inner Join 
Marca mar on mar.idMarca = m.id_Marca Where m.nombreMaterial like '%{@}%';

insert into Marca (nombreMarca) values ('@');
insert into Categoria (nombreCategoria) values ('');
insert into Material (nombreMaterial, cantidad, fechaIngreso, descripcionMaterial, modelo, id_Categoria, id_Marca) values ('');
select top 5 *From Material order by idMaterial desc
go

--Mostrar ultimos 10 registros
create view registrosUlt as 
select Top 10
m.nombreMaterial as [Nombre del Material], 
m.cantidad as Cantidad, 
m.fechaIngreso as [Fecha de Ingreso], 
m.descripcionMaterial as [Descripción], 
m.modelo as [Modelo], 
c.nombreCategoria as [Categoría], 
mar.nombreMarca as [Marca] from Material m
Inner Join
Categoria c on c.idCategoria = m.id_Categoria
Inner Join 
Marca mar on mar.idMarca = m.id_Marca
Order by m.idMaterial desc;

select *from registrosUlt;


--CONSULTAS LENIN
-- ==========================================================

-- PROCEDIMIENTOS ALMACENADOS PARA LAS GRÁFICAS

-- ==========================================================

-- Procedimiento para Chart Inventario (Categorías específicas)
create procedure sp_obtener_inventario_categorias
as
begin
    select 
        m.nombrematerial,
        m.cantidad,
        c.nombrecategoria
    from material m
    inner join categoria c on m.id_categoria = c.idcategoria
    where c.nombrecategoria in ('computación', 'periféricos', 'limpieza', 'papeleria')
    order by c.nombrecategoria, m.nombrematerial;
end
go

CREATE PROCEDURE spu_obtenerinventariomaterial
    @nombrematerial VARCHAR(100)
AS
BEGIN
    -- Selecciona el nombre del material y su cantidad actual
    SELECT
        nombreMaterial,
        cantidad AS cantidadInventario -- Usamos este alias para el C#
    FROM
        Material
    WHERE
        nombreMaterial LIKE '%' + @nombrematerial + '%'
    ORDER BY
        nombreMaterial;
END;
GO
--selects
select * from Rol;
select * from Usuario;
select * from Categoria;
select * from Marca;
select * from Material;
select * from solicitud;
select * from HistorialSolicitud;


-- Procedimiento para Chart Consumo (salida_de_material)
create procedure sp_obtener_consumo_material
as
begin
    select 
        m.nombrematerial,
        sum(s.cantidadconsumida) as total_consumido
    from salida_de_material s
    inner join material m on s.id_material = m.idmaterial
    group by m.nombrematerial
    order by total_consumido desc;
end
go


-- Procedimiento para DataGridView Catálogo
create procedure sp_obtener_catalogo_completo
as
begin
    select 
        m.nombrematerial,
        m.cantidad,
        m.descripcionmaterial,
        m.modelo,
        c.nombrecategoria,
        ma.nombremarca
    from material m
    inner join categoria c on m.id_categoria = c.idcategoria
    inner join marca ma on m.id_marca = ma.idmarca
    order by c.nombrecategoria, m.nombrematerial;
end
go

-- ==========================================================

-- VERIFICACIÓN DE PROCEDIMIENTOS

-- ==========================================================

-- Verificar que los procedimientos se crearon
select name, type_desc 
from sys.procedures 
where name in ('sp_obtener_inventario_categorias', 'sp_obtener_consumo_material', 'sp_obtener_catalogo_completo');
go

-- Probar el procedimiento de inventario
exec sp_obtener_inventario_categorias;
go

-- Probar el procedimiento de consumo
exec sp_obtener_consumo_material;
go

-- Probar el procedimiento de catálogo
exec sp_obtener_catalogo_completo;
go

-- Procedimiento para obtener materiales para ComboBox
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

-- Procedimiento para registrar salida de material
CREATE PROCEDURE sp_registrar_salida_material
    @id_material INT,
    @cantidad_consumida INT,
    @fecha_consumo DATE,
    @id_usuario INT,
    @motivo_salida VARCHAR(1000)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Insertar en salida_de_material
        INSERT INTO salidaDeMaterial (id_Material, cantidadConsumida, fechaConsumo, id_Usuario, motivosalida)
        VALUES (@id_material, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);
        
        -- Actualizar el inventario (restar cantidad)
        UPDATE Material 
        SET cantidad = cantidad - @cantidad_consumida
        WHERE idMaterial = @id_Material;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

-- Procedimiento para mostrar historial de salidas
CREATE PROCEDURE sp_obtener_historial_salidas
AS
BEGIN
    SELECT 
        s.idsalidamaterial,
        m.nombrematerial,
        ma.nombremarca,
        s.cantidadconsumida,
        s.fechaconsumo,
        s.motivosalida,
        u.nombre as usuario_registra
    FROM salidaDeMaterial s
    INNER JOIN Material m ON s.id_Material = m.idMaterial
    INNER JOIN Marca ma ON m.id_Marca = ma.idMarca
    INNER JOIN Usuario u ON s.id_Usuario = u.idUsuario
    ORDER BY s.fechaConsumo DESC;
END
GO
-- Ejecuta ESTO en SSMS, asegurándote de usar la BD BasePTC
-- Si el procedimiento existe, lo modifica. Si no existe, lo crea.
IF OBJECT_ID('sp_registrar_salida_material', 'P') IS NOT NULL
    DROP PROCEDURE sp_registrar_salida_material;
GO


create procedure sp_registrar_salida_material
    -- RECUERDA: Cambiamos @id_material por @nombre_material
    @nombre_material varchar(100), 
    @cantidad_consumida int,
    @fecha_consumo date,
    @id_usuario int,
    @motivo_salida varchar(1000)
as
begin
    -- Variables internas para la validación
    declare @id_material_local int;
    declare @stock_actual int;

    -- 1. Intentar encontrar el material y obtener su stock actual por NOMBRE
    select @id_material_local = idMaterial, @stock_actual = cantidad
    from Material
    where nombreMaterial = @nombre_material;

    -- Validacion 1: El material debe existir
    if @id_material_local is null
    begin
        -- Lanza un error con severidad 16 (lo captura C# como SqlException)
        raiserror('El material especificado no existe en el inventario. Verifique el nombre.', 16, 1);
        return;
    end
    -- Validacion 2: Hay suficiente stock?
    if @stock_actual < @cantidad_consumida
    begin
        raiserror('Stock insuficiente. Solo quedan %d unidades de %s.', 16, 1, @stock_actual, @nombre_material);
        return;
    end

    -- Si las validaciones pasan, se ejecuta la transacción
    begin try
        begin transaction;
        
        -- 3. Insertar en salida_de_material (Registra la salida)
        insert into salidaDeMaterial (id_Material, cantidadConsumida, fechaConsumo, id_Usuario, motivosalida)
        values (@id_material_local, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);
        
        -- 4. Actualizar el inventario (resta la cantidad del inventario principal)
        update Material 
        set cantidad = cantidad - @cantidad_consumida
        where idMaterial = @id_material_local;
        
        commit transaction;
    end try
    begin catch
        if @@trancount > 0
            rollback transaction;
        throw;
    end catch
end
go


--UPDATE DE MATERIAL

--No se debe ejecutar, pero es la que utilizo en c#
Update Material set nombreMaterial = @nombre, cantidad = @cantidad where idMaterial = @id;

