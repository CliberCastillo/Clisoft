use master
go
drop database if exists BDMemoryKings
go
create database BDMemoryKings
go
use BDMemoryKings

go
create table Categoria (
idCategoria varchar(5) primary key,
nombre char(30),
foto varchar(50)
)
go
create table Marca (
idMarca varchar(5) primary key,
nombre char(30) 
)

create table MetodoPago (
idPago varchar(5) primary key,
nombre char(40)
)

create table Rol (
idRol varchar(5) primary key,
nombre char(30)
)


CREATE TABLE Domicilio(
  idDomicilio varchar(5) PRIMARY KEY,
	idUsuario INT ,
  departamento VARCHAR(50) NOT NULL,
  provincia VARCHAR(50)NOT NULL,
  distrito VARCHAR(50)NOT NULL,
  ciudad VARCHAR(50)NOT NULL,
  codigoPostal CHAR(5)NOT NULL,
  calle VARCHAR(100),
  referencia VARCHAR(100)
  )


CREATE TABLE Usuario(
  idUsuario int IDENTITY(1,1) PRIMARY KEY,
  email VARCHAR(100) NOT NULL,
  contraseña VARCHAR(20) NOT NULL,
  apellidoPaterno VARCHAR(50) NOT NULL,
  apellidoMaterno VARCHAR(50) NOT NULL,
  nombres VARCHAR(60) NOT NULL,
  genero CHAR(1)NOT NULL,
  telefono CHAR(9),
	estado CHAR(1),
	idRol varchar(5) NOT NULL
  )
  drop table Usuario

  ALTER TABLE Usuario
ADD FOREIGN KEY (idRol) REFERENCES Rol(idRol);

  alter table Domicilio
  add foreign key (idUsuario) references Usuario(idUsuario);
	
CREATE TABLE Producto (
  idProducto varchar(5) primary key,
  nombres varchar(255)  not null,
	idCategoria varchar(5),
  foto varchar(50),
  descripcion varchar(255)  not NULL,
  precio decimal(5,1) not NULL,
  stock int not NULL
) 

  ALTER TABLE Producto
ADD idMarca varchar(5);

	alter table producto
  add foreign key (idCategoria) references Categoria (idCategoria);
  
  	alter table producto
  add foreign key (idMarca) references Marca (idMarca);

 
CREATE TABLE Compras (
  idCompras int PRIMARY KEY,
  idUsuario int,
  fechaCompras varchar(20),
  monto decimal(4,1),
  estado varchar(50),
  idPago varchar(5)
)

	alter table Compras 
  add foreign key (idUsuario) references Usuario (idUsuario);
  
 	alter table Compras 
  add foreign key (idPago) references MetodoPago (idPago);
  
  
 CREATE TABLE DetalleCompras (
  idDetalle varchar(5) PRIMARY KEY,
  idProducto varchar(5),
  idCompras int,
  cantidad int ,
  precioCompra decimal(4,1) 
) 


	alter table DetalleCompras 
  add foreign key (idProducto) references Producto (idProducto);
  
 	alter table DetalleCompras 
  add foreign key (idCompras) references  Compras (idCompras);

	
  select * from Producto
 

--insert into producto values('PR001','HP LAPTOP 15-DY1004LA','CA001','laptop01_1.png','HP LAPTOP ',2100.00,15);
--insert into producto values('PR002' ,'LAPTOP Aspire 7','CA001','laptop02_1.png','Laptop ACER',4229.00,25);
--insert into producto values('PR003','Laptop G3 15','CA001','laptop03_1.png','Laptop 15"',2300.00,25);
--insert into producto values('PR004','Laptop Lenovo ThinkPad','CA001','laptop04_1.png','Laptop Lenovo',3800.00,15);
--insert into producto values('PR005','ASUS LAPTOP X541UA','CA001','laptop05_1.png','ASUS LAPTOP',825.00,35);
--insert into producto values('PR006','Disco Duro Seagate 2TB','CA002','Disco01_1.png','DISCO DURO ',70.00,50);
--insert into producto values('PR007','Disco Duro WD Purple 2TB','CA002','Disco02_1.png','Disco Duro',288.00,10);
--insert into producto values('PR008','Disco Duro Toshiba 4TB','CA002','Disco03_1.png','Disco',435.00,26);
--insert into producto values('PR009','Disco SSD Gigabyte 240GB','CA002','Disco04_1.png','Disco SDD',140.00,30);
--insert into producto values('PR010','Disco SSD Hyper 240GB','CA002','Disco05_1.png','SSD HD',500.00,15);
--insert into producto values('PR011','Memoria USB Kingston 16GB','CA003','Usb01_1.png','Memoria USB',22.00,60);
--insert into producto values('PR012','Memoria USB Imation 16GB','CA003','Usb02_1.png','Memoria Imation ',70.00,12);
--insert into producto values('PR013','Memoria USB iBlue','CA003','Usb03_1.png','MEMORIA IBLUE',60.00,23);
--insert into producto values('PR014','Memoria USB Imation 16GB','CA003','Usb04_1.png','Memoria USB',40.00,50);
--insert into producto values('PR015','Memoria USB SanDisk 32 GB','CA003','Usb05_1.png','Memoria Sandisk ',120.00,10);
--insert into producto values('PR016','KINGSTON RAM DDR3','CA004','Ram01_1.png','8GB 1600MHZ',170.00,60);
--insert into producto values('PR017','BALLISTIX RAM DDR4','CA004','Ram02_1.png','8GB 2666MHZZ',140.00,50);
--insert into producto values('PR018','RAM HyperX Fury','CA004','Ram03_1.png','8GB DDR4',180.00,30);
--insert into producto values('PR019','KINGSTON RAM DDR4','CA004','Ram04_1.png','4GB 1333MHZ',100.00,10);
--insert into producto values('PR020','RAM G.SKILL','CA004','Ram05_1.png','TRIDENT Z RGB',590.00,20);
--insert into producto values('PR021','Parlante 2.1 Micronics','CA004','Parlan01_1.png','Killer MIC S600 20W',40.00,30);
--insert into producto values('PR022','Parlante 2.0 Gamer','CA005','Parlan02_1.png','Machine Sound',30.00,55);
--insert into producto values('PR023','Wired Altavoces','CA005','Parlan03_1.png','Xtech Speakers',80.00,25);
--insert into producto values('PR024','Parlante Multimedia','CA005','Parlan04_1.png','Gamer Machine Sound',60.00,15);
--insert into producto values('PR025','Parlante Rhapsody','CA005','Parlan05_1.png','Gamer Sound 2.0',27.00,45);
--insert into producto values('PR026','Impresora HP','CA006','Impre01_1.png','HP DeskJet',145.00,30);
--insert into producto values('PR027','Impresora Epson','CA006','Impre02_1.png','XPRESSION HOME',260.00,30);
--insert into producto values('PR028','Impresora A3','CA006','Impre03_1.png','WIFI Rotula CD',800.00,40);
--insert into producto values('PR029','Impresora Láser','CA006','Impre04_1.png','Xerox Phaser',220.00,25);
--insert into producto values('PR030','Impresora Canon','CA006','Impre05_1.png','Canon Pixma',120.00,55);
--insert into producto values('PR031','TARJETA DE VÍDEO MSI','CA007','Tarje01_1.png','GEFORCE NVIDIA',190.00,30);
--insert into producto values('PR032','TARJETA GIGABYTE','CA007','Tarje02_1.png','GTX 1660 Ti',1300.00,30);
--insert into producto values('PR033','TARJETA ASUS','CA007','Tarje03_1.png','GTX 1660 6GB',990.00,30);
--insert into producto values('PR034','Gigabyte Radeon','CA007','Tarje04_1.png','RX 570 4GB',680.00,40);
--insert into producto values('PR035','Nvidia GTX960','CA007','Tarje05_1.png','Video 4GB',260.00,30);
--insert into producto values('PR036','Monitor Teros','CA008','Mon01_1.png','TE-F215W, 21.5"',380.00,30);
--insert into producto values('PR037','Monitor Gamer','CA008','Mon02_1.png','Gaming Curvo 24"',770.00,30);
--insert into producto values('PR038','Monitor Led Curvo','CA008','Mon03_1.png','Samsung 24"- VGA',550.00,30);
--insert into producto values('PR039','VIEWSONIC MONITOR','CA008','Mon04_1.png','LED Pantalla 19"',240.00,30);
--insert into producto values('PR040','Monitor AOC','CA008','Mon05_1.png','E2070SWHN, 19.5"',260.00,40);

--select * from producto;
	

--- Insert en Tabla Marca
--insert into Marca values ('MA001','HP');
--insert into Marca values ('MA002','Asus');
--insert into Marca values ('MA003','Lenovo');
--insert into Marca values( 'MA004', 'Apple');
--insert into Marca values ('MA005','Epson');
--insert into Marca values ('MA006','Micronics');
--select * from Marca;

--- Insert en Tabla Categoria
--insert into Categoria values ('CA001','Laptop','cat.01.png');
--insert into Categoria values ('CA002','Disco Duro','cat.02.png');
--insert into Categoria values ('CA003','USB','cat.03.png');
--insert into Categoria values ('CA004','Memoria RAM','cat.04.png');
--insert into Categoria values ('CA005','Parlante','cat.05.png');
--insert into Categoria values ('CA006','Impresora','cat.06.png');
--insert into Categoria values ('CA007','Tarjeta de vídeo','cat.07.png');
--insert into Categoria values ('CA008','Monitor','cat.08.png');

--select * from Categoria;


--- Insert en Tabla Rol
--insert into Rol values ('RO001','Administrador');
--insert into Rol values ('RO002','Cliente');
--select * from Rol;

--insert into MetodoPago values ('ME001','Crédito');
--select * from MetodoPago
--go


--- Insert en Usuario
--select * from Usuario
--go
--insert into Usuario values ('angel@gmail.com','angel3633','Silva','Luna','Angel Manuel','M','986325104','H','RO001')
--insert into Usuario values ('marko@gmail.com','marko22','Castillo','Ruiz','Marco Antonio','M','925367891','H','RO002')
--insert into Usuario values ('renzo@gmail.com','renzo22','Cruz','Lopez','Renzo','M','925367251','D','RO002')


--Select * from Usuario
--update Usuario set Estado='H'  where idUsuario=2
--select * from producto where Nombres like '%LAP%'

--select * from detalle_compras

--select idDetalle,Nombres,Foto,Descripcion,Cantidad, PrecioCompra  from detalle_compras  INNER JOIN producto ON  detalle_compras.idProducto=producto.idProducto where idCompras=1
--select * from compras where idUsuario=2
--select * from producto
--order by Precio ASC

--select * from producto order by Precio ASC