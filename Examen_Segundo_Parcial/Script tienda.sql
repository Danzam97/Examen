create database Tienda
go

create schema factura
go

create table factura.cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)
insert into factura.cliente(idCliente, nombre, apellido, direccion)
values('1','Juanito', 'Alcachofa', 'Enrique Segoviano'),
('2','Julio', 'Esteban', 'Animalitos de la creacion'),
('3','Shrek', 'Burro', 'Fiona')
;
select *from factura.cliente;

create table factura.producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)
insert into factura.producto(idProducto, nombreProducto, descripcion)
values('1', 'Cafe', 'En granos'),
('2', 'Cafe instantaneo', 'Nestle'),
('3', 'Leche', 'Sula')
;
select *from factura.producto;

create table factura.Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)
);
select * from factura.Venta;

create procedure consultar
AS
BEGIN
select case idVenta, fechaVenta, precio, cantidad, idCliente, idProducto from factura.Venta
END
create procedure agregar(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int)
AS
BEGIN
insert into factura.Venta(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto)
values(@idVenta,@fechaVenta,@precio,@cantidad,@idCliente,@idProducto)
END



create procedure modificar(
@idVenta int,
@fechaVenta date,
@precio int,
@cantidad int,
@idCliente int,
@idProducto int)
AS
BEGIN
update factura.Venta
set fechaVenta = @fechaVenta, precio = @precio, cantidad = @cantidad, idCliente = @idCliente, idProducto = @idProducto
where idVenta = @idVenta
END

create procedure eliminar(
@idVenta int)
AS
BEGIN
delete from factura.Venta
where idVenta = @idVenta
END
