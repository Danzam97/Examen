create database Tienda;
go
use Tienda;
go
create schema factura;
go

create table cliente(
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

create table producto(
	idProducto int primary key not null,
	nombreProducto varchar(40) not null,
	descripcion varchar(50)
)

insert into producto(idProducto, nombreProducto, descripcion)
values('1', 'Cafe', 'En granos'),
('2', 'Cafe instantaneo', 'Nestle'),
('3', 'Leche', 'Sula')
;

create table Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int not null,
	cantidad int not null,
	idCliente int foreign key references cliente(idCliente),
	idProducto int foreign key references producto(idProducto)
);
select * from Venta;
go
create procedure consultarTabla
AS
BEGIN
select idVenta, fechaVenta, precio, cantidad, idCliente, idProducto from Venta
END
go
create procedure recibo
AS
BEGIN
select concat (nombre,apellido), p.nombreProducto, v.cantidad, v.precio, v.fechaVenta from cliente
inner join producto as p
on idProducto = p.idProducto
inner join Venta as v
on idVenta = v.idVenta
END
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
insert into Venta(idVenta,fechaVenta, precio, cantidad, idCliente, idProducto)
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

go
create procedure consultarClientes
AS
BEGIN
select idCliente, nombre, apellido, direccion from cliente
END
go
create procedure agregarClientes(
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(25))
AS
BEGIN
insert into cliente(idCliente,nombre, apellido, direccion)
values(@idCliente,@nombre,@apellido,@direccion)
END
go
create procedure modificarClientes(
@idCliente int,
@nombre varchar(25),
@apellido varchar(25),
@direccion varchar(25))
AS
BEGIN
update cliente
set nombre = @nombre, apellido = @apellido, direccion = @direccion
where idCliente = @idCliente
END
go
create procedure eliminarCliente(
@idCliente int)
AS
BEGIN
delete from cliente
where idCliente = @idCliente
END
go

create procedure consultarProductos
AS
BEGIN
select idProducto, nombreProducto, descripcion from producto
END
go
create procedure agregarProductos(
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50))
AS
BEGIN
insert into producto(idProducto,nombreProducto, descripcion)
values(@idProducto,@nombreProducto,@descripcion)
END
go
create procedure modificarProducto(
@idProducto int,
@nombreProducto varchar(40),
@descripcion varchar(50))
AS
BEGIN
update producto
set nombreProducto = @nombreProducto, descripcion = @descripcion
where idProducto = @idProducto
END
go
create procedure eliminarProducto(
@idProducto int)
AS
BEGIN
delete from producto
where idProducto = @idProducto
END