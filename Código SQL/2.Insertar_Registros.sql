--Activar la Base de Datos
USE db_ventas
GO

--Insertar registros en la tabla Categoria
Insert into categoria (nombre, estado) values('Camisas','A')
Insert into categoria (nombre, estado) values('Zapatillas','A')
Insert into categoria (nombre, estado) values('Pantalones','I')
Insert into categoria (nombre, estado) values('Casacas','A')
Insert into categoria (nombre, estado) values('Polos','A')

--Insertar registros en la tabla Producto
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (1,'Camisa de algodón', 'Vestir,Talla M', 'Jhon Holden',75,50,'A')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (1,'Camisa sintetica', 'Vestir,Talla XL', 'Jhon Holden',75,35,'I')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (1,'Camisa de algodón', 'Sport,Talla L', 'Tommy', 80,25,'A')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (1,'Camisa de algodón', 'Vestir Talla XL', 'Tommy', 90,25,'A')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (1,'Camisade algodón', 'Vestir Talla XL', 'Baronet', 150,100,'I')

Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (2,'Zapatilla deportiva', 'Moderno, color blanco, Talla 41', 'Fila', 180,25,'A')
Insert into producto (idcategoria,nombre,descripcion,marca, precio,stock,estado)
values (2,'Zapatilla deportiva', 'Moderno, color nego con rojo, Talla 42', 'Fila', 250,35,'I')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (2,'Zapatilla sport', 'Clasico, color rojo, Talla 40', 'Reebok', 175,15,'A')

Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (3,'Pantalón de Vestir', 'Pantalón Drill,  Color Azul, Talla 34', 'Dokers', 220,25,'A')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (3,'Pantalón de Vestir', 'Moderno, color nego con negro, Talla 42', 'Jhon Holden', 250,10,'I')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (3,'Pantalaon Jean', 'Clasico, color verde olivo, Talla 30', 'Levis', 200,18,'A')
Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (3,'Pantalon Jean', 'Pantalón Signature Marrón, Talla: 34', 'Dokers', 190.90,41,'A')

Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (4,'Casaca de plumas', 'Spyder Prymo Down Jacket 511373 Roja / Negro, Talla: M', 'Spyder', 440,8,'A')

Insert into producto (idcategoria,nombre,descripcion,marca,precio,stock,estado)
values (5, 'Polo deportivo', 'Caterpillar Natural Dye Fashion', 'Caterpillar', 191.92,10, 'A')

--Insertar registros en la tabla Cliente
Insert into cliente(idcliente,dni,nombre,apellido,email,estado) 
values ('CLI-001','12345678','Enrique','Lanchipa Valencia','elanchipa@hotmail.es','I')
Insert into cliente(idcliente,dni,nombre,apellido,email,estado) 
values ('CLI-002','87654321','Maria','Flores','mflores@upt.edu.pe','A')
Insert into cliente(idcliente,dni,nombre,apellido,email,estado)  
values ('CLI-003','11223344','Jony','Sanchez','jsanchez@yahoo.es','A')

--Insertar registros en la tabla Pedido
Insert into pedido(fecha,estado,idcliente) values ('2018-20-08','Realizado','CLI-001')
Insert into pedido(fecha,estado,idcliente) values ('2018-20-08','Realizado','CLI-002')
Insert into pedido(fecha,estado,idcliente) values ('2018-25-08','Realizado','CLI-003')
Insert into pedido(fecha,estado,idcliente) values ('2018-26-01','Anulado','CLI-003')

--Insertar registros en la tabla Detalle de Pedido
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (5,1,75,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (5,4,90,2)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (6,1,120,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (6,2,150,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (6,3,280,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (7,1,125,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (7,2,100,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (7,5,250,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (7,6,85,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (8,2,440,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (8,3,1,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (8,4,300,1)
Insert into detalle_pedido(idpedido,idproducto,precio,cantidad) values (8,5,130,1)

--Insertar registros en la tabla Empleado
Insert into empleado(dni,nombre,apellido,email,celular, direccion,estado) 
values ('12345678','Enrique','Lanchipa Valencia','elanchipa@upt.pe','952364852','Av. Bolognesi 15847','A')
Insert into empleado(dni,nombre,apellido,email,celular, direccion,estado) 
values ('22445566','Elard','Rodriguez Marca','erodriguez@virtual.upt.pe','970154895','Calle Deustua S/N','A')
Insert into empleado(dni,nombre,apellido,email,celular, direccion,estado) 
values ('12378925','Liliana','Vega Bernal','lvega@gmail.com','9985254852','AV. Capanique 18545','A')

--Insertar registros en la tabla Usuario
Insert into usuario(idempleado,nombre,clave,nivel,estado) 
values (1,'elanchipa','123456','Administrador', 1)
Insert into usuario(idempleado,nombre,clave,nivel,estado) 
values (2,'erodriguez','1234','Supervisor', 0)
Insert into usuario(idempleado,nombre,clave,nivel,estado) 
values (3,'lvega','1234','Usuario', 1)

--Listar todos los registros de las tablas
SELECT * FROM Empleado
GO
SELECT * FROM Usuario
GO
select * from Categoria
go
select * from Producto
go
select * from Cliente
go
select * from Pedido
go
select * from detalle_pedido
go