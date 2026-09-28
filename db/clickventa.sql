-- ==========================================
-- 1. CREACIÓN DE LA BASE DE DATOS
-- ==========================================
USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'clickventa')
BEGIN
    ALTER DATABASE clickventa SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE clickventa;
END
GO

CREATE DATABASE clickventa;
GO

USE clickventa;
GO

-- ==========================================
-- 2. CREACIÓN DE TABLAS (DDL)
-- ==========================================

-- Tablas independientes (Sin llaves foráneas)
CREATE TABLE Categoria (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME,
    estado NVARCHAR(20) DEFAULT 'Activo'
);

CREATE TABLE Presentacion (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    estado NVARCHAR(20) DEFAULT 'Activo',
    descripcion NVARCHAR(255),
    nombre NVARCHAR(100) NOT NULL,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME
);

CREATE TABLE Proveedor (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    fechaBaja DATETIME,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    Cuit_Cuil NVARCHAR(20) UNIQUE NOT NULL,
    razonSocial NVARCHAR(150) NOT NULL,
    email NVARCHAR(100),
    telefono NVARCHAR(50),
    direccion NVARCHAR(255),
    web NVARCHAR(150),
    estado NVARCHAR(20) DEFAULT 'Activo'
);

CREATE TABLE Rol (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    estado NVARCHAR(20) DEFAULT 'Activo',
    fechaBaja DATETIME
);

CREATE TABLE TipoMovimiento (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    estado NVARCHAR(20) DEFAULT 'Activo',
    fechaBaja DATETIME
);

CREATE TABLE FormaPago (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    estado NVARCHAR(20) DEFAULT 'Activo',
    fechaBaja DATETIME
);

-- Tablas dependientes (Nivel 1)
CREATE TABLE Producto (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    categoriaId UNIQUEIDENTIFIER,
    presentacionId UNIQUEIDENTIFIER,
    estado NVARCHAR(20) DEFAULT 'Activo',
    descripcion NVARCHAR(255),
    codigoBarra NVARCHAR(50) UNIQUE,
    nombre NVARCHAR(150) NOT NULL,
    precioCompra DECIMAL(10,2) NOT NULL,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME,
    FOREIGN KEY (categoriaId) REFERENCES Categoria(id),
    FOREIGN KEY (presentacionId) REFERENCES Presentacion(id)
);

CREATE TABLE Empleado (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    DNI NVARCHAR(20) UNIQUE NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(255),
    telefono NVARCHAR(50),
    estado NVARCHAR(20) DEFAULT 'Activo',
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME
);

CREATE TABLE ProveedorProducto (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    proveedorId UNIQUEIDENTIFIER,
    productoId UNIQUEIDENTIFIER,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME,
    estado NVARCHAR(20) DEFAULT 'Activo',
    FOREIGN KEY (proveedorId) REFERENCES Proveedor(id),
    FOREIGN KEY (productoId) REFERENCES Producto(id)
);

CREATE TABLE Lote (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    productoId UNIQUEIDENTIFIER,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaVencimiento DATE,
    stock INT NOT NULL DEFAULT 0,
    precioVenta DECIMAL(10,2) NOT NULL,
    precioCompra DECIMAL(10,2) NOT NULL,
    fechaBaja DATETIME,
    estado NVARCHAR(20) DEFAULT 'Activo',
    FOREIGN KEY (productoId) REFERENCES Producto(id)
);

-- Tablas dependientes (Nivel 2)
CREATE TABLE Usuario (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    empleadoId UNIQUEIDENTIFIER,
    rolId UNIQUEIDENTIFIER,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME,
    nombreusuario NVARCHAR(50) UNIQUE NOT NULL,
    contrasena NVARCHAR(255) NOT NULL,
    estado NVARCHAR(20) DEFAULT 'Activo',
    FOREIGN KEY (empleadoId) REFERENCES Empleado(id),
    FOREIGN KEY (rolId) REFERENCES Rol(id)
);

CREATE TABLE Venta (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    usuarioId UNIQUEIDENTIFIER,
    nroTicket NVARCHAR(50) UNIQUE NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    fechaVenta DATETIME DEFAULT GETDATE(),
    estado NVARCHAR(20) DEFAULT 'Pagado',
    FOREIGN KEY (usuarioId) REFERENCES Usuario(id)
);

CREATE TABLE Movimiento (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    tipoMovimientoId UNIQUEIDENTIFIER,
    usuarioId UNIQUEIDENTIFIER,
    nombre NVARCHAR(100),
    estado NVARCHAR(20) DEFAULT 'Activo',
    descripcion NVARCHAR(255),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaBaja DATETIME,
    monto DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (tipoMovimientoId) REFERENCES TipoMovimiento(id),
    FOREIGN KEY (usuarioId) REFERENCES Usuario(id)
);

-- Tablas dependientes (Nivel 3)
CREATE TABLE DetalleVenta (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    productoId UNIQUEIDENTIFIER,
    ventaId UNIQUEIDENTIFIER,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    subTotal DECIMAL(10,2) NOT NULL,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (productoId) REFERENCES Producto(id),
    FOREIGN KEY (ventaId) REFERENCES Venta(id)
);

CREATE TABLE DetallePago (
    id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    formaPagoId UNIQUEIDENTIFIER,
    ventaId UNIQUEIDENTIFIER,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    estado NVARCHAR(20) DEFAULT 'Activo',
    fechaBaja DATETIME,
    FOREIGN KEY (formaPagoId) REFERENCES FormaPago(id),
    FOREIGN KEY (ventaId) REFERENCES Venta(id)
);
CREATE TABLE [dbo].[Menu](
	id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](50) NULL,
	[order] [int] NULL,
	[createdDate] [datetime] NULL,
	[finalDate] [datetime] NULL,
	[estado] [int] NULL
);
CREATE TABLE [dbo].[SubMenu](
	id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[menuId] [uniqueidentifier] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[description] [nvarchar](50) NULL,
	[formAssociation] [nvarchar](200) NULL,
	[order] [int] NULL,
	[createdDate] [datetime] NULL,
	[finalDate] [datetime] NULL,
	[estado] [int] NULL,
    FOREIGN KEY (menuId) REFERENCES Menu(id)
);
CREATE TABLE [dbo].[Permissions](
	id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[rolId] [uniqueidentifier] NOT NULL,
	[subMenuId] [uniqueidentifier] NOT NULL,
	[canRead] [bit] NULL,
	[canWrite] [bit] NULL,
	[createdDate] [datetime] NULL,
	[finalDate] [datetime] NULL,
	[estado] [int] NULL,
    FOREIGN KEY (subMenuId) REFERENCES SubMenu(id),
    FOREIGN KEY (rolId) REFERENCES Rol(id)
);
CREATE TABLE [dbo].[UserSubmenuPermissions](
	id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[usuarioId] [uniqueidentifier] NOT NULL,
	[subMenuId] [uniqueidentifier] NOT NULL,
	[estado] [int] NULL,
    FOREIGN KEY (usuarioId) REFERENCES Usuario(id),
    FOREIGN KEY (subMenuId) REFERENCES SubMenu(id)
);

GO