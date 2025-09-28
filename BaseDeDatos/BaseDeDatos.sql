create database BasePTC
go
use BasePTC;
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
contraseña varchar(30),
telefono varchar (20),
correo varchar (75) unique,
id_Rol int,
constraint fk_rol Foreign key (id_Rol) references Rol(idRol));
go

SELECT m.idMarca, m.nombreMarca
FROM Material mat
INNER JOIN Marca m ON mat.id_Marca = m.idMarca
WHERE mat.idMaterial = 2

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
constraint fk_Categoria Foreign key(id_Categoria) references Categoria(idCategoria),
constraint fk_Marca Foreign key(id_Marca) references Marca(idMarca));
go



create table Solicitud (
idSolicitud int identity (1,1) primary key,
motivo varchar (1000) not null,
fecha date not null,
estado varchar (50) not null,
id_Usuario int,
constraint fk_usuario Foreign key (id_Usuario) references Usuario(idUsuario));
go

-- Nuevas tablas

create table SolicitudMaterial (
    idSolicitudMaterial int identity(1,1) primary key,
    idSolicitud int not null,
    idMaterial int not null,
    cantidad int not null,
    constraint fk_Solicitud foreign key (idSolicitud) references Solicitud(idSolicitud),
    constraint fk_MaterialSolicitud foreign key (idMaterial) references Material(idMaterial)
);

create table salidaDeMaterial (
    idSalidamaterial int identity(1,1) primary key,
    id_Material int not null,
    cantidadConsumida int not null,
    fechaConsumo date not null,
    id_Usuario int not null,
    motivoSalida varchar(1000),
    constraint fk_salida_material foreign key (id_Material) references Material(idMaterial),
    constraint fk_salida_usuario foreign key (id_Usuario) references Usuario(idUsuario)
);
go

-- Vistas

create view VerUltimosUsuarios
as
select 
    u.idUsuario,
    u.nombre,
    u.fechaNacimiento,
    u.contraseña,
    u.telefono,
    u.correo,
    r.idRol
from Usuario u
inner join Rol r on u.id_Rol = r.idRol;
go

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
insert into Usuario 
values ('Fatima Ester Medina Gonzales', '2002/4/3',  'Cesa23A5','+503 4554 5285', 'fatimaester.dit@gmail.com', 2), 
('Orlando Josue Pineda Rivas', '2003/8/21', 'X933esD4','+503 4478 2547', 'orlandojosue.jefatura@gmail.com', 1), 
('Michael Steve Murcia Martinez', '2002/5/01', 'AsQQ09211','+503 3385 2265', 'michaelsteve.dit@gmail.com', 2),
('Cristopher Levi Rogger Marin', '2000/11/07', 'Yqm330pX1','+503 4528 0751','cristlevi.dit@gmail.com',2),
('Mariana Verenice Villalobos Duran','2001/05/28','uMP931zXa','+503 7106 4809', 'marianavere.dit@gmail.com',2)

insert into Rol values ('Jefatura', 'Este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('Departamento IT', 'Este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');

insert into Marca 
values ('Ardone'),
('Dell'),
('Nexxt Solutions'),
('Hp'),
('Office depot'),
('Mikrotik'),
('iTouch'),
('3M'),
('Sabo'),
('Epson'),
('Abro'),
('Lenovo'),
('Logitech'),
('Canon'),
('Bic')

insert into Categoria 
values ('Computación','objetos de computacion'),
('Perífericos','Aparato auxiliar e independiente conectado a la unidad central de una computadora u otro dispositivo electrónico.'),
('Limpieza','onjetos de limpieza'),
('Redes','conexion de redes'),
('Almacenamiento','almacenamiento del sistema'),
('Papeleria','objetos de papeleria');

insert into Material 
values ('Laptop Ryzen 7', 10, '2021-03-15', 'Laptop de alto rendimiento para oficina', 'LAP-001', 1, 1),
('Monitor Hp', 25, '2022-07-22', 'Teclado inalámbrico compacto', 'TECL-002',  2, 7),
('Teclado alambrico', 5,  '2023-01-08', 'Aire comprimido para limpieza de computadoras', 'AIRE-003',3, 9),
('Aire comprimido', 20, '2020-11-30', 'Router inalámbrico de alto rendimiento', 'ROUT-004',  4, 3),
('Router 1200Mbps', 12, '2024-05-10', 'Impresora multifuncional con sistema de tinta continua', 'IMPR-005',  1, 10),
('Tinta negra para impresora', 15, '2023-09-05', 'Botellas de tinta negra para impresora EcoTank', 'TINTA-006',  1, 10),
('Switch RB260GS', 18, '2022-02-12', 'Switch de red 5 puertos Gigabit', 'SWITCH-007', 4, 6),
('Cinta Scotch', 30, '2024-12-01', 'Memoria USB 64GB', 'USB-008',  5, 7),
('Cámara IP NXT-CAM', 50, '2021-08-19', 'Cinta adhesiva transparente de oficina', 'CINTA-009',  6, 8),
('Laptop core i5', 7,  '2023-06-14', 'Proyector portátil para presentaciones', 'PROY-010',  1, 7),
('Limpiador en spray', 40, '2020-02-20', 'Paquete de hojas tamaño carta', 'PAPEL-011', 6, 5),
('USB 1TB', 9,  '2022-04-25', 'Limpiador multiusos para superficies electrónicas', 'LIMP-012',  3, 11),
('Disco duro externo de 2TB', 5,  '2023-11-30', 'Disco duro externo de 2TB USB 3.0', 'DD-013',  5, 2),
('Cable RJ45', 16, '2024-03-05', 'Cámara de seguridad IP para interiores', 'CAM-014', 4, 3),
('Plumones Artline', 8,  '2021-06-18', 'Computadora de escritorio básica', 'PC-015', 1, 1); 

insert into Solicitud 
values ('Quedan pocas latas de aire comprimido, 3 para ser exactos', 3, '2025-07-18', 'Enviada',2, 4),
('Necesito 10 tintas Epson negras para reponer', 10, '2025-02-02', 'Enviada', 3, 6),
('Me hacen falta 5 teclados iTouch para las nuevas PCs', 5, '2025-07-21', 'Enviada', 3, 3),
('Se necesitan 3 routers Nexxt para la red', 3, '2025-07-22', 'Enviada', 1, 5),
('Se necesitan envíen 7 paquetes de papel tamaño carta', 7, '2025-06-23', 'Enviada', 3, 1),
('Ya solo quedan 2 latas de aire comprimido Sabo para limpieza', 2, '2025-01-12', 'Enviada', 2, 4),
('Se necesitan 2 Monitores HP', 2, '2025-02-12', 'Enviada', 4,2),
('Necesito 1 tinta negra para impresora', 1, '2025-03-19', 'Enviada', 5,6),
('Solicito 3 Switch RB260GS para conectar a la red',3,'2025-01-21','Enviada', 4,7),
('Me hacen falta 4 Disco duro externo de 2TB',4,'2025-06-17','Enviada', 3,13),
('Quedan pocas unidades de Laptop core i5 necesito 2',2,'2025-04-01','Enviada', 4,10),
('Se solicitan 2 Teclados alambricos para reponer', 2, '2025-04-11', 'Enviada', 4, 3),
('Se necesitan 7 Cinta Scotch', 7, '2025-06-27', 'Enviada', 4, 8),
('Necesito 5 USB 1TB', 5, '2025-03-03', 'Enviada', 3,12),
('Se solicitan 1 Cámara IP NXT-CAM para reponer', 1, '2025-03-28', 'Enviada', 5,9)

insert into HistorialSolicitud values
('Rechazado','2025-07-23', 1),
('Rechazado', '2025-02-05', 2),
('Aceptado', '2025-07-25', 3),
('Aceptado', '2025-07-26', 4),
('Aceptado', '2025-06-25', 5),
('Aceptado', '2025-01-15', 6),
('Rechazado', '2025-02-15', 7),
('Aceptado','2025-03-21', 8),
('Aceptado', '2025-01-23', 9),
('Rechazado', '2025-06-19', 10),
('Rechazado', '2025-04-06', 11),
('Rechazado', '2025-04-18', 12),
('Rechazado', '2025-01-21', 13),
('Aceptado', '2025-06-29', 14),
('Aceptado', '2025-03-06', 15);

insert into salidaDeMaterial values
(1, 2, '2025-07-26', 2, 'consumo de tinta para impresora'),
(2, 1, '2025-07-27', 3, 'uso de impresora'),
(3, 3, '2025-07-28', 4, 'consumo de plumones'),
(4, 5, '2025-07-29', 5, 'uso de cinta scotch'),
(5, 4, '2025-07-30', 1, 'limpieza con aire comprimido'),
(6, 2, '2025-08-01', 3, 'limpieza con spray'),
(7, 10, '2025-08-02', 4, 'consumo de papel'),
(8, 1, '2025-08-03', 5, 'uso de proyector'),
(9, 1, '2025-08-04', 2, 'instalación de cámara'),
(1, 3, '2025-08-05', 1, 'consumo adicional de tinta'),
(4, 2, '2025-08-06', 4, 'uso adicional de cinta');
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
-- SELECTS PARA VERIFICAR TODOS LOS DATOS
-- ==========================================================

select * from Rol;
select * from Usuario;
select * from Categoria;
select * from Marca;
select * from Material;
select * from solicitud;
select * from SolicitudMaterial;
select * from salidaDeMaterial;
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