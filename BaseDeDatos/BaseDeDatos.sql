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
cantidadProducto int not null,
fecha date not null,
estado varchar (50) not null,
id_Usuario int,
id_Material int,
constraint fk_Material Foreign key (id_Material) references Material(idMaterial),
constraint fk_usuario Foreign key (id_Usuario) references Usuario(idUsuario));
go

create table HistorialSolicitud (
idHistorialSolicitud int identity (1,1) primary key,
estadoSolicitud varchar (50),
fechaRespuesta date,
id_Solicitud int not null,
constraint fk_solicitud Foreign key (id_Solicitud) references Solicitud(idSolicitud));
go

-- Inserts into
insert into Usuario 
values ('Fatima Ester Medina Gonzales', '2002/4/3',  'Cesa23A5','+503 4554 5285', 'fatimaester.dit@gmail.com', 2), 
('Orlando Josue Pineda Rivas', '2003/8/21', 'X933esD4','+503 4478 2547', 'orlandojosue.jefatura@gmail.com', 1), 
('Michael Steve Murcia Martinez', '2002/5/01', 'AsQQ09211','+503 3385 2265', 'michaelsteve.dit@gmail.com', 2),
('Cristopher Levi Rogger Marin', '2000/11/07', 'Yqm330pX1','+503 4528 0751','cristlevi.dit@gmail.com',2),
('Mariana Verenice Villalobos Duran','2001/05/28','uMP931zXa','+503 7106 4809', 'marianavere.dit@gmail.com',2)

insert into Rol values ('Jefatura', 'Este rol tiene acceso al inventario, consumo y al manejo de solicitudes'), 
('Departamento IT', 'Este rol tiene acceso al inventario, consumo y a la realizacion de solicitudes');

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
('Papeleria','objetos de papeleria')

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
('Aceptado', '2025-03-06', 15)

-- Select
Select *from Usuario
Select *from Rol
Select *from Categoria
Select *from Solicitud
Select *from Marca
Select *from Material
Select *from HistorialSolicitud
go


--Creacion de consultas para el sistema en c#



