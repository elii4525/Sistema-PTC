create database BasePTC
go
use BasePTC;
go

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
('Jefatura', 'Este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('Departamento IT', 'Este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');

-- insertar usuarios
insert into usuario values 
('Fatima Ester Medina Gonzales', '2002/4/3',  'Cesa23A5','+503 4554 5285', 'fatimaester.dit@gmail.com', 2), 
('Orlando Josue Pineda Rivas', '2003/8/21', 'X933esD4','+503 4478 2547', 'orlandojosue.jefatura@gmail.com', 1), 
('Michael Steve Murcia Martinez', '2002/5/01', 'AsQQ09211','+503 3385 2265', 'michaelsteve.dit@gmail.com', 2),
('Cristopher Levi Rogger Marin', '2000/11/07', 'Yqm330pX1','+503 4528 0751','cristlevi.dit@gmail.com',2),
('Mariana Verenice Villalobos Duran','2001/05/28','uMP931zXa','+503 7106 4809', 'marianavere.dit@gmail.com',2);

-- insertar categorías
insert into categoria values 
('Computación','objetos de computacion'),
('Perífericos','Aparato auxiliar e independiente conectado a la unidad central de una computadora u otro dispositivo electrónico.'),
('Limpieza','onjetos de limpieza'),
('Redes','conexion de redes'),
('Almacenamiento','almacenamiento del sistema'),
('Papeleria','objetos de papeleria');

-- insertar marcas
insert into marca values 
('Ardone'),
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
('Bic');

-- insertar materiales
insert into material values 
('Laptop Ryzen 7', 10, '2021-03-15', 'Laptop de alto rendimiento para oficina', 'LAP-001', 1, 1),
('Monitor Hp', 25, '2022-07-22', 'Teclado inalámbrico compacto', 'TECL-002',  2, 7),
('Teclado alambrico', 5,  '2023-01-08', 'Aire comprimido para limpieza de computadoras', 'AIRE-003',3, 9),
('Aire comprimido', 20, '2020-11-30', 'Router inalámbrico de alto rendimiento', 'ROUT-004',  4, 3),
('Router 1200Mbps', 12, '2024-05-10', 'Impresora multifuncional con sistema de tinta continua', 'IMPR-005',  1, 10),
('Tinta negra para impresora', 15, '2023-09-05', 'Botellas de tinta negra para impresora EcoTank', 'TINTA-006',  1, 10),
('Switch RB260GS', 18, '2022-02-12', 'Switch de red 5 puertos Gigabit', 'SWITCH-007', 4, 6),
('Cinta Scotch', 30, '2024-12-01', 'Memoria USB 64GB', 'USB-008',  5, 7),
('Laptop core i5', 7,  '2023-06-14', 'Proyector portátil para presentaciones', 'PROY-010',  1, 7),
('Limpiador en spray', 40, '2020-02-20', 'Paquete de hojas tamaño carta', 'PAPEL-011', 6, 5),
('USB 1TB', 9,  '2022-04-25', 'Limpiador multiusos para superficies electrónicas', 'LIMP-012',  3, 11),
('Disco duro externo de 2TB', 5,  '2023-11-30', 'Disco duro externo de 2TB USB 3.0', 'DD-013',  5, 2),
('Cable RJ45', 16, '2024-03-05', 'Cámara de seguridad IP para interiores', 'CAM-014', 4, 3),
('Plumones Artline', 8,  '2021-06-18', 'Computadora de escritorio básica', 'PC-015', 1, 1); 

-- insertar solicitudes
insert into solicitud values
('Quedan pocas latas de aire comprimido, 3 para ser exactos', 3, '2025-07-18', 'Enviada',2, 4),
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
('Se solicitan 1 Cámara IP NXT-CAM para reponer', 1, '2025-03-28', 'Enviada', 5,9);

-- insertar historial de solicitudes
insert into historialsolicitud values
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

-- insertar salida de material
insert into salida_de_material values
(4, 2, '2025-07-26', 2, 'Se entregaron 2 latas de aire comprimido para limpieza'),
(6, 1, '2025-07-27', 3, 'Consumo de una tinta negra Epson en impresora de oficina'),
(2, 1, '2025-07-28', 4, 'Se entregó un monitor HP para nueva estación de trabajo'),
(7, 2, '2025-07-29', 5, 'Se ocuparon 2 switches RB260GS en red de laboratorio'),
(10, 5, '2025-07-30', 1, 'Se entregaron 5 paquetes de papel tamaño carta para oficina'),
(1, 1, '2025-08-01', 3, 'Uso de 1 laptop Ryzen 7 para área administrativa'),
(3, 2, '2025-08-02', 4, 'Se entregaron 2 teclados alámbricos para PCs nuevas'),
(12, 1, '2025-08-03', 5, 'Uso de un disco duro externo 2TB para respaldo de datos'),
(14, 1, '2025-08-04', 2, 'Entrega de computadora de escritorio básica a recepción'),
(5, 1, '2025-08-05', 1, 'Se instaló 1 router Nexxt en laboratorio 1'),
(8, 3, '2025-08-06', 4, 'Se entregaron 3 cintas Scotch a oficina de diseño'),
(11, 2, '2025-08-07', 3, 'Uso de 2 USB 1TB para almacenamiento temporal'),
(9, 1, '2025-08-08', 2, 'Se entregó 1 laptop Core i5 a nuevo empleado'),
(13, 4, '2025-08-09', 5, 'Se ocuparon 4 cables RJ45 en área de redes'),
(15, 2, '2025-08-10', 1, 'Se entregaron 2 plumones Artline a oficina de reuniones');
go

-- crear procedimiento almacenado para obtener catálogo completo
create procedure sp_obtener_catalogo_materiales
as
begin
    select idmaterial, nombrematerial, cantidad, fechaingreso, descripcionmaterial, modelo from material;
end
go

-- crear procedimiento almacenado para obtener inventario filtrado
create procedure sp_obtener_datos_inventario
    @textoBusqueda varchar(100) = null
as
begin
    if @textoBusqueda is null or @textoBusqueda = ''
    begin
        select nombrematerial, cantidad from material;
    end
    else
    begin
        select nombrematerial, cantidad from material
        where nombrematerial like '%' + @textoBusqueda + '%'
        or modelo like '%' + @textoBusqueda + '%';
    end
end
go

-- crear procedimiento almacenado para obtener consumo por mes
create procedure sp_obtener_datos_consumo
    @fechaInicio date,
    @fechaFin date
as
begin
    select  
        datename(month, fechaconsumo) + '-' + cast(year(fechaconsumo) as varchar) as mes,
        sum(cantidadconsumida) as totalconsumido
    from salida_de_material
    where fechaconsumo between @fechaInicio and @fechaFin
    group by year(fechaconsumo), month(fechaconsumo), datename(month, fechaconsumo)
    order by year(fechaconsumo), month(fechaconsumo);
end
go
select * from usuario 
select * from rol 
select * from categoria 
select * from solicitud 
select * from marca 
select * from material 
select * from historialsolicitud 
go
