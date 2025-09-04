-- crear la base de datos si no existe
create database BasePTC;
go

-- usar la base de datos
use BasePTC;
go

-- crear tablas en orden
create table rol (
    idrol int identity(1,1) primary key,
    tiporol varchar(50) not null,
    descripcionrol varchar(500) not null
);
go

create table usuario (
    idusuario int identity(1,1) primary key,
    nombre varchar(50) not null,
    fechanacimiento date not null,
    contraseña varchar(30),
    telefono varchar(20),
    correo varchar(75) unique,
    id_rol int,
    constraint fk_rol foreign key (id_rol) references rol(idrol)
);
go

create table categoria (
    idcategoria int identity(1,1) primary key,
    nombrecategoria varchar(70), 
    descripcioncategoria varchar(300)
);
go

create table marca (
    idmarca int identity(1,1) primary key,
    nombremarca varchar(70) not null
);
go

create table material (
    idmaterial int identity(1,1) primary key,
    nombrematerial varchar(100) not null,
    cantidad int not null,
    fechaingreso date,
    descripcionmaterial varchar(500),
    modelo varchar(100) unique,
    id_categoria int,
    id_marca int,
    constraint fk_categoria foreign key(id_categoria) references categoria(idcategoria),
    constraint fk_marca foreign key(id_marca) references marca(idmarca)
);
go


create table solicitud (
    idsolicitud int identity(1,1) primary key,
    motivo varchar(1000) not null,
    cantidadproducto int not null,
    fecha date not null,
    estado varchar(50) not null,
    id_usuario int,
    id_material int,
    constraint fk_material foreign key (id_material) references material(idmaterial),
    constraint fk_usuario foreign key (id_usuario) references usuario(idusuario)
);

go

create table historialsolicitud (
    idhistorialsolicitud int identity(1,1) primary key,
    estadosolicitud varchar(50),
    fecharespuesta date,
    id_solicitud int not null,
    constraint fk_solicitud foreign key (id_solicitud) references solicitud(idsolicitud)
);
go


create table salida_de_material (
    idsalidamaterial int identity(1,1) primary key,
    id_material int not null,
    cantidadconsumida int not null,
    fechaconsumo date not null,
    id_usuario int not null,
    motivosalida varchar(1000),
    constraint fk_salida_material foreign key (id_material) references material(idmaterial),
    constraint fk_salida_usuario foreign key (id_usuario) references usuario(idusuario)
);


go

-- insertar roles
insert into rol values 
('jefatura', 'este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('departamento it', 'este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');
go

-- insertar usuarios
insert into usuario values 
('fatima ester medina gonzales', '2002/4/3',  'cesa23a5','+503 4554 5285', 'fatimaester.dit@gmail.com', 2), 
('orlando josue pineda rivas', '2003/8/21', 'x933esd4','+503 4478 2547', 'orlandojosue.jefatura@gmail.com', 1), 
('michael steve murcia martinez', '2002/5/01', 'asqq09211','+503 3385 2265', 'michaelsteve.dit@gmail.com', 2),
('cristopher levi rogger marin', '2000/11/07', 'yqm330px1','+503 4528 0751','cristlevi.dit@gmail.com',2),
('mariana verenice villalobos duran','2001/05/28','ump931zxa','+503 7106 4809', 'marianavere.dit@gmail.com',2);
go


-- insertar categorías
insert into categoria values 
('computación','objetos de computacion'),
('periféricos','aparato auxiliar e independiente conectado a la unidad central de una computadora u otro dispositivo electrónico.'),
('limpieza','objetos de limpieza'),
('redes','conexion de redes'),
('almacenamiento','almacenamiento del sistema'),
('papeleria','objetos de papeleria');
go

-- insertar marcas
insert into marca values 
('ardone'),
('dell'),
('nexxt solutions'),
('hp'),
('office depot'),
('mikrotik'),
('itouch'),
('3m'),
('sabo'),
('epson'),
('abro'),
('lenovo'),
('logitech'),
('canon'),
('bic');
go

-- insertar materiales
insert into material values 
('tinta negra para impresora', 15, '2023-09-05', 'botellas de tinta negra para impresora ecotank', 'tinta-006', 1, 10),
('impresora multifuncional', 5, '2024-05-10', 'impresora multifuncional con sistema de tinta continua', 'impr-005', 1, 10),
('plumones artline', 8, '2021-06-18', 'plumones para pizarra', 'plum-015', 6, 15),
('cinta scotch', 30, '2024-12-01', 'cinta adhesiva', 'cinta-008', 6, 8),
('aire comprimido', 20, '2020-11-30', 'latas de aire comprimido para limpieza', 'aire-003', 3, 9),
('limpiador en spray', 40, '2020-02-20', 'limpiador para equipos electrónicos', 'spray-012', 3, 11),
('papel bond', 100, '2022-07-22', 'papel tamaño carta', 'papel-011', 6, 5),
('proyector portátil', 3, '2023-06-14', 'proyector para presentaciones', 'proy-010', 2, 7),
('cámara de seguridad ip', 2, '2024-03-05', 'cámara para vigilancia', 'cam-014', 2, 3),
('laptop ryzen 7', 10, '2021-03-15', 'laptop de alto rendimiento', 'lap-001', 1, 1),
('monitor hp', 25, '2022-07-22', 'monitor led', 'mon-002', 2, 4),
('teclado alambrico', 5, '2023-01-08', 'teclado usb', 'tecl-003', 2, 7);
go

-- insertar solicitudes
insert into solicitud values
('quedan pocas latas de aire comprimido, 3 para ser exactos', 3, '2025-07-18', 'enviada',2, 5),
('necesito 10 tintas epson negras para reponer', 10, '2025-02-02', 'enviada', 3, 1),
('me hacen falta 5 teclados itouch para las nuevas pcs', 5, '2025-07-21', 'enviada', 3, 12),
('se necesitan 3 routers nexxt para la red', 3, '2025-07-22', 'enviada', 1, 9),
('se necesitan envíen 7 paquetes de papel tamaño carta', 7, '2025-06-23', 'enviada', 3, 7),
('ya solo quedan 2 latas de aire comprimido sabo para limpieza', 2, '2025-01-12', 'enviada', 2, 5),
('se necesitan 2 monitores hp', 2, '2025-02-12', 'enviada', 4, 11),
('necesito 1 tinta negra para impresora', 1, '2025-03-19', 'enviada', 5, 1),
('solicito 3 switch rb260gs para conectar a la red',3,'2025-01-21','enviada', 4, 9),
('me hacen falta 4 disco duro externo de 2tb',4,'2025-06-17','enviada', 3, 10),
('quedan pocas unidades de laptop core i5 necesito 2',2,'2025-04-01','enviada', 4, 10),
('se solicitan 2 teclados alambricos para reponer', 2, '2025-04-11', 'enviada', 4, 12),
('se necesitan 7 cinta scotch', 7, '2025-06-27', 'enviada', 4, 4),
('necesito 5 usb 1tb', 5, '2025-03-03', 'enviada', 3, 8),
('se solicitan 1 cámara ip nxt-cam para reponer', 1, '2025-03-28', 'enviada', 5, 9);
go

-- insertar historial de solicitudes
insert into historialsolicitud values
('rechazado','2025-07-23', 1),
('rechazado', '2025-02-05', 2),
('aceptado', '2025-07-25', 3),
('aceptado', '2025-07-26', 4),
('aceptado', '2025-06-25', 5),
('aceptado', '2025-01-15', 6),
('rechazado', '2025-02-15', 7),
('aceptado','2025-03-21', 8),
('aceptado', '2025-01-23', 9),
('rechazado', '2025-06-19', 10),
('rechazado', '2025-04-06', 11),
('rechazado', '2025-04-18', 12),
('rechazado', '2025-01-21', 13),
('aceptado', '2025-06-29', 14),
('aceptado', '2025-03-06', 15);
go

-- insertar salida de material (datos para el gráfico de consumo)
insert into salida_de_material values
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

select * from rol;
select * from usuario;
select * from categoria;
select * from marca;
select * from material;
select * from solicitud;
select * from historialsolicitud;
select * from salida_de_material;
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
        m.idmaterial,
        m.nombrematerial,
        ma.nombremarca,
        m.cantidad
    FROM material m
    INNER JOIN marca ma ON m.id_marca = ma.idmarca
    ORDER BY m.nombrematerial;
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
        INSERT INTO salida_de_material (id_material, cantidadconsumida, fechaconsumo, id_usuario, motivosalida)
        VALUES (@id_material, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);
        
        -- Actualizar el inventario (restar cantidad)
        UPDATE material 
        SET cantidad = cantidad - @cantidad_consumida
        WHERE idmaterial = @id_material;
        
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
    FROM salida_de_material s
    INNER JOIN material m ON s.id_material = m.idmaterial
    INNER JOIN marca ma ON m.id_marca = ma.idmarca
    INNER JOIN usuario u ON s.id_usuario = u.idusuario
    ORDER BY s.fechaconsumo DESC;
END
GO


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
