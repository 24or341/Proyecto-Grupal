-- Crear Base de Datos
CREATE DATABASE db_ventas
GO
--Poner Activa la Base de Datos
USE db_ventas
GO

-- Crear Tablas
-- Tabla Cliente
CREATE TABLE Cliente(
	IdCliente varchar(20) NOT NULL PRIMARY KEY,
	Dni char(8) NOT NULL UNIQUE,
	Nombre varchar(100) NOT NULL,
	Apellido varchar(150) NOT NULL,
	Email varchar(100) NOT NULL UNIQUE,
	Estado char(1) NOT NULL
)
GO
DROP TABLE Cliente

-- Tabla Empleado
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Empleado'))
CREATE TABLE Empleado(
	IdEmpleado int identity(1,1) NOT NULL PRIMARY KEY,
	Dni char(8) NOT NULL UNIQUE,
	Nombre varchar(100) NOT NULL,
	Apellido varchar(150) NOT NULL,
	Email varchar(100) NOT NULL UNIQUE,
	Celular varchar(11) NOT NULL,
	Direccion text NULL,
	Estado char(1) NOT NULL
)
GO
DROP TABLE Empleado

-- Tabla Usuario
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Usuario'))
CREATE TABLE Usuario(
	IdUsuario int identity(1,1) NOT NULL PRIMARY KEY,
	IdEmpleado int NOT NULL,
	Nombre varchar(30) NOT NULL UNIQUE,
	Clave varchar(100) NOT NULL,
	Nivel varchar(15) NOT NULL,
	Estado int NOT NULL
	FOREIGN KEY (IdEmpleado) REFERENCES Empleado
)
GO
DROP TABLE Usuario

-- Tabla Categoria
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Categoria'))
CREATE TABLE Categoria(
	IdCategoria int identity(1,1) NOT NULL, --AUTOINCREMENTABLE
	Nombre varchar(50) NOT NULL,
	Descripcion text NULL,
	Estado char(1) NOT NULL
	PRIMARY KEY(IdCategoria)
)
GO

DROP TABLE Categoria

-- Tabla Producto
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Producto'))
CREATE TABLE Producto
(
	IdProducto int identity(1,1) NOT NULL,
	IdCategoria int NOT NULL,
	Nombre varchar(50) NOT NULL,
	Descripcion text NULL,
	Marca varchar(50) NOT NULL,
	Precio decimal(10,2) NOT NULL,
	Stock int NOT NULL,
	Estado varchar(8)
	PRIMARY KEY (IdProducto),
	FOREIGN KEY (IdCategoria) REFERENCES Categoria
)
GO
DROP TABLE Producto

-- Tabla Pedido
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Pedido'))
CREATE TABLE Pedido(
	IdPedido int identity(1,1) NOT NULL, --AUTOINCREMENTABLE
	Fecha datetime NOT NULL,	
	Estado varchar(10) NOT NULL,
	IdCliente varchar(20) NOT NULL
	PRIMARY KEY(IdPedido),
	FOREIGN KEY(IdCliente) REFERENCES Cliente
)
GO
DROP TABLE Pedido

-- Tabla Detalle Pedido
IF (NOT EXISTS (SELECT 1 FROM sys.tables WHERE NAME = 'Detalle_Pedido'))
CREATE TABLE Detalle_Pedido(
	IdPedido int NOT NULL,
	IdProducto int NOT NULL,
	Precio decimal(10,2) NOT NULL,	
	Cantidad int NOT NULL	
	PRIMARY KEY(IdPedido, IdProducto),
	FOREIGN KEY(IdPedido) REFERENCES Pedido,
	FOREIGN KEY(IdProducto) REFERENCES Producto
)
GO
DROP TABLE Detalle_Pedido