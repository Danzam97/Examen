create database Tienda;
go
use Tienda;
go
create schema factura;
go

create table cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)
insert into cliente(idCliente, nombre, apellido, direccion)
values('1','Juanito', 'Alcachofa', 'Enrique Segoviano'),
('2','Julio', 'Esteban', 'Animalitos de la creacion'),
('3','Shrek', 'Burro', 'Fiona')
;
select *from cliente;

create table producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)

insert into producto(idProducto, nombreProducto, descripcion)
values('1', 'Cafe', 'En granos'),
('2', 'Cafe instantaneo', 'Nestle'),
('3', 'Leche', 'Sula')
;
select *from producto;

create table Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references cliente(idCliente),
	idProducto int foreign key references producto(idProducto)
);
insert into Venta(fechaVenta, precio, cantidad, idCliente, idProducto)
values('2020/01/28', '32', '2','2','1')
;
select * from Venta;

use Tienda;
go
create procedure consultarTabla
AS
BEGIN
select idVenta, fechaVenta, precio, cantidad, idCliente, idProducto from Venta
END

exec consultarTabla
go
create procedure agregar(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int)
AS
BEGIN
insert into Venta(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto)
values(@idVenta,@fechaVenta,@precio,@cantidad,@idCliente,@idProducto)
END
go
create procedure modificar(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int)
AS
BEGIN
update Venta
set fechaVenta = @fechaVenta, precio = @precio, cantidad = @cantidad, idCliente = @idCliente, idProducto = @idProducto
where idVenta = @idVenta
END
go
create procedure eliminar(
@idVenta int)
AS
BEGIN
delete from Venta
where idVenta = @idVenta
END
