USE [master]
GO
/****** Object:  Database [Lenco]    Script Date: 23/6/2021 13:13:16 ******/
CREATE DATABASE [Lenco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lenco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lenco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Lenco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Lenco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Lenco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lenco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lenco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lenco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lenco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lenco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lenco] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lenco] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Lenco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lenco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lenco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lenco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lenco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lenco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lenco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lenco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lenco] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Lenco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lenco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lenco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lenco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lenco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lenco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lenco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lenco] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lenco] SET  MULTI_USER 
GO
ALTER DATABASE [Lenco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lenco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lenco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lenco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Lenco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Lenco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Lenco] SET QUERY_STORE = OFF
GO
USE [Lenco]
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colores](
	[idColor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
 CONSTRAINT [Colores_pk] PRIMARY KEY CLUSTERED 
(
	[idColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[num_comprobante] [int] NULL,
	[fecha_compra] [datetime] NOT NULL,
	[idProveedor] [int] NULL,
 CONSTRAINT [Compras_pk] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesCompra]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesCompra](
	[idDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NOT NULL,
	[precioUnit] [money] NULL,
	[cantidadUnit] [int] NOT NULL,
	[idCompra] [int] NOT NULL,
 CONSTRAINT [DetallesCompra_pk] PRIMARY KEY CLUSTERED 
(
	[idDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesDevolucion]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesDevolucion](
	[idDetalleDev] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NOT NULL,
	[idDevolucion] [int] NOT NULL,
 CONSTRAINT [detallesDevolucion_pk] PRIMARY KEY CLUSTERED 
(
	[idDetalleDev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesSalida]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesSalida](
	[idDetalleSalida] [int] IDENTITY(1,1) NOT NULL,
	[idTipoSalida] [int] NOT NULL,
	[idProducto] [int] NULL,
	[idDevolucion] [int] NOT NULL,
	[monto] [money] NULL,
 CONSTRAINT [PK_DetallesSalidas] PRIMARY KEY CLUSTERED 
(
	[idDetalleSalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesVenta]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesVenta](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NOT NULL,
	[precioUnit] [money] NULL,
	[cantidadUnit] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
 CONSTRAINT [DetallesVenta_pk] PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devoluciones]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devoluciones](
	[idDevolucion] [int] IDENTITY(1,1) NOT NULL,
	[fecha_devolucion] [datetime] NOT NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [Devoluciones_pk] PRIMARY KEY CLUSTERED 
(
	[idDevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[idFormaPago] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[idInteres] [int] NULL,
 CONSTRAINT [FormasPago_pk] PRIMARY KEY CLUSTERED 
(
	[idFormaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Intereses]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intereses](
	[idInteres] [int] NOT NULL,
	[porcentaje] [int] NOT NULL,
 CONSTRAINT [PK_Intereses] PRIMARY KEY CLUSTERED 
(
	[idInteres] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventarios]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventarios](
	[inventarioID] [int] IDENTITY(1,1) NOT NULL,
	[idSucursal] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [Inventarios_pk] PRIMARY KEY CLUSTERED 
(
	[inventarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
 CONSTRAINT [Marcas_pk] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentaciones]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentaciones](
	[idPresentacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [Presentaciones_pk] PRIMARY KEY CLUSTERED 
(
	[idPresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[codigoProv] [varchar](50) NOT NULL,
	[idMarca] [int] NOT NULL,
	[idRubro] [int] NOT NULL,
	[articulo] [int] NOT NULL,
	[idTalle] [int] NOT NULL,
	[idColor] [int] NOT NULL,
	[idPresentacion] [int] NOT NULL,
	[descripcion] [varchar](150) NOT NULL,
	[precioVenta] [money] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [Productos_pk] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](200) NULL,
	[telefono] [varchar](100) NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [Proveedores_pk] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [Roles_pk] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles_Usuarios]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles_Usuarios](
	[idRolUsuario] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idRol] [int] NOT NULL,
 CONSTRAINT [Roles_Usuarios_pk] PRIMARY KEY CLUSTERED 
(
	[idRolUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubros]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubros](
	[idRubro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
 CONSTRAINT [Rubros_pk] PRIMARY KEY CLUSTERED 
(
	[idRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursales](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[telefono] [varchar](100) NOT NULL,
 CONSTRAINT [Sucursales_pk] PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Talles]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Talles](
	[idTalle] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](4) NOT NULL,
 CONSTRAINT [Talles_pk] PRIMARY KEY CLUSTERED 
(
	[idTalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposSalida]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposSalida](
	[idTipoSalida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposSalida] PRIMARY KEY CLUSTERED 
(
	[idTipoSalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[password] [varchar](15) NOT NULL,
	[idRol] [int] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [Usuarios_pk] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 23/6/2021 13:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[fecha_venta] [datetime] NOT NULL,
	[idSucursal] [int] NULL,
	[montoDescuento] [money] NULL,
	[idFormaPago] [int] NOT NULL,
 CONSTRAINT [Ventas_pk] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Colores] ON 

INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (1, N'N/D')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (2, N'Blanco')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (3, N'Gris')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (4, N'Negro')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (5, N'Rojo')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (6, N'Rosa')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (7, N'Violeta')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (8, N'Amarillo')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (9, N'Naranja')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (10, N'Verde')
INSERT [dbo].[Colores] ([idColor], [nombre]) VALUES (11, N'Marron')
SET IDENTITY_INSERT [dbo].[Colores] OFF
GO
SET IDENTITY_INSERT [dbo].[Compras] ON 

INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (20, 12345, CAST(N'2021-06-02T16:19:54.273' AS DateTime), 2)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (21, 1111, CAST(N'2021-06-06T23:37:18.407' AS DateTime), 3)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (22, 1234, CAST(N'2021-06-07T10:54:20.613' AS DateTime), 5)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (23, 1235, CAST(N'2021-06-15T16:14:24.593' AS DateTime), 3)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (24, 49548, CAST(N'2021-06-15T17:50:18.327' AS DateTime), 8)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (25, 1, CAST(N'2021-06-20T17:54:52.863' AS DateTime), 2)
INSERT [dbo].[Compras] ([idCompra], [num_comprobante], [fecha_compra], [idProveedor]) VALUES (26, 4234, CAST(N'2021-06-22T11:43:08.267' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[Compras] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesCompra] ON 

INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (24, 5, 450.0000, 15, 20)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (25, 5, 250.0000, 15, 21)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (26, 13, 145.9900, 5, 22)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (27, 14, 1230.0000, 5, 23)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (28, 15, 500.0000, 10, 24)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (29, 16, 200.0000, 3, 25)
INSERT [dbo].[DetallesCompra] ([idDetalleCompra], [idProducto], [precioUnit], [cantidadUnit], [idCompra]) VALUES (30, 18, 200.0000, 5, 26)
SET IDENTITY_INSERT [dbo].[DetallesCompra] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesVenta] ON 

INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (51, 13, NULL, 3, 40)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (52, 13, NULL, 3, 41)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (53, 13, NULL, 3, 42)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (54, 5, NULL, 5, 43)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (55, 13, NULL, 2, 43)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (56, 5, NULL, 9, 44)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (57, 13, NULL, 1, 44)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (58, 5, NULL, 1, 45)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (59, 13, NULL, 1, 45)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (60, 1, NULL, 10, 46)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (61, 5, NULL, 10, 47)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (62, 5, NULL, 2, 48)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (63, 12, NULL, 1, 49)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (64, 12, NULL, 3, 50)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (65, 5, NULL, 1, 51)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (66, 3, 0.0000, 5, 53)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (67, 3, 0.0000, 5, 54)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (68, 3, 3000.0000, 3, 56)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (69, 3, 4000.0000, 2, 57)
INSERT [dbo].[DetallesVenta] ([idDetalleVenta], [idProducto], [precioUnit], [cantidadUnit], [idVenta]) VALUES (70, 3, 4000.0000, 2, 58)
SET IDENTITY_INSERT [dbo].[DetallesVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[FormasPago] ON 

INSERT [dbo].[FormasPago] ([idFormaPago], [nombre], [idInteres]) VALUES (1, N'Efectivo', 1)
INSERT [dbo].[FormasPago] ([idFormaPago], [nombre], [idInteres]) VALUES (2, N'Tarjeta credito', 1)
INSERT [dbo].[FormasPago] ([idFormaPago], [nombre], [idInteres]) VALUES (3, N'Tarjeta credito', 2)
INSERT [dbo].[FormasPago] ([idFormaPago], [nombre], [idInteres]) VALUES (4, N'Tarjeta credito ', 3)
INSERT [dbo].[FormasPago] ([idFormaPago], [nombre], [idInteres]) VALUES (5, N'Tarjeta debito', 1)
SET IDENTITY_INSERT [dbo].[FormasPago] OFF
GO
INSERT [dbo].[Intereses] ([idInteres], [porcentaje]) VALUES (1, 0)
INSERT [dbo].[Intereses] ([idInteres], [porcentaje]) VALUES (2, 10)
INSERT [dbo].[Intereses] ([idInteres], [porcentaje]) VALUES (3, 20)
GO
SET IDENTITY_INSERT [dbo].[Inventarios] ON 

INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (21, 3, 5, 4)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (22, 1, 5, 20)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (23, 2, 5, 18)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (24, 1, 3, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (25, 2, 3, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (26, 3, 13, 10)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (27, 1, 12, 10)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (28, 2, 12, 20)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (29, 1, 1, 30)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (30, 2, 1, 30)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (31, 3, 12, 15)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (32, 3, 3, 8)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (33, 3, 1, 10)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (34, 3, 14, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (35, 3, 15, 10)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (36, 3, 16, 3)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (37, 3, 18, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (38, 2, 13, 4)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (39, 1, 13, 14)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (40, 2, 14, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (41, 1, 14, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (42, 2, 15, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (43, 1, 15, 2)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (44, 2, 16, 1)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (45, 1, 16, 8)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (46, 2, 18, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (47, 1, 18, 3)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (48, 1, 17, 5)
INSERT [dbo].[Inventarios] ([inventarioID], [idSucursal], [idProducto], [cantidad]) VALUES (49, 2, 17, 3)
SET IDENTITY_INSERT [dbo].[Inventarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (1, N'Andressa')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (2, N'Apogeo')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (3, N'Aretha')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (4, N'Arlen')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (5, N'Belen')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (6, N'Fiorina')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (7, N'Lody')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (8, N'Lyon Dor')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (9, N'Marc. Koury')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (10, N'Mora')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (11, N'Perlea')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (12, N'Peter Pan')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (13, N'Selu')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (14, N'Sweet Lady')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (15, N'Sweet Victorian')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (16, N'Tutta la fruta')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (17, N'Almendra')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (18, N'Ana grant')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (19, N'Anais')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (20, N'Anana')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (21, N'Dime quien eres')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (22, N'Cocot')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (23, N'Kaury')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (24, N'Lara')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (25, N'Andros')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (26, N'Opositor')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (27, N'XY')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (28, N'Sigri')
INSERT [dbo].[Marcas] ([idMarca], [nombre]) VALUES (29, N'Scala')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Presentaciones] ON 

INSERT [dbo].[Presentaciones] ([idPresentacion], [nombre]) VALUES (1, N'Individual')
INSERT [dbo].[Presentaciones] ([idPresentacion], [nombre]) VALUES (2, N'Pack')
SET IDENTITY_INSERT [dbo].[Presentaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (1, N'119458', 10, 1, 1629, 1, 4, 1, N'Short Talle 1/2 Negro Individual', 1250.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (3, N'50840303', 10, 2, 5084, 18, 4, 1, N'Corpiño Talle 90 Negro', 4000.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (5, N'50840404', 9, 2, 5084, 18, 2, 1, N'Corpiño Talle 90 Blanco', 1900.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (12, N'123BS', 1, 1, 123, 11, 2, 1, N'Bombacha Talle S Blanca Individual', 899.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (13, N'1001BM', 1, 1, 1001, 13, 11, 1, N'Bombacha Talle L Marron', 795.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (14, N'8009Blanco', 1, 1, 8009, 5, 2, 1, N'Bombacha Talle 5 Blanca Individual', 1893.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (15, N'1002D', 1, 1, 1002, 15, 2, 1, N'No posee', 123.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (16, N'1234566', 3, 1, 465, 1, 2, 1, N'Bombacha Talle 1 Blanca Individual', 450.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (17, N'4560', 2, 3, 4560, 18, 7, 1, N'Conjunto Talle 90 Violeta Individual', 490.0000, 1)
INSERT [dbo].[Productos] ([idProducto], [codigoProv], [idMarca], [idRubro], [articulo], [idTalle], [idColor], [idPresentacion], [descripcion], [precioVenta], [activo]) VALUES (18, N'1643', 2, 1, 123, 1, 1, 1, N'No posee', 755.0000, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (2, N'Selu', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (3, N'Peter Pan', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (4, N'Perlea', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (5, N'Dime quien eres', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (6, N'Aretha', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (7, N'Arlen', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (8, N'Monimar', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (9, N'3 Hermanos', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (10, N'Mora', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (11, N'Bianca Secret', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (13, N'Papillon', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (14, N'Marisabel', NULL, NULL, 1)
INSERT [dbo].[Proveedores] ([idProveedor], [nombre], [direccion], [telefono], [activo]) VALUES (15, N'Jalinet', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([idRol], [nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Roles] ([idRol], [nombre]) VALUES (2, N'Moderador')
INSERT [dbo].[Roles] ([idRol], [nombre]) VALUES (3, N'Usuario')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Rubros] ON 

INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (1, N'Bombacha')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (2, N'Corpiño')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (3, N'Conjunto')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (4, N'Media')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (5, N'Pijama')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (6, N'Pantufla')
INSERT [dbo].[Rubros] ([idRubro], [nombre]) VALUES (7, N'Bretel')
SET IDENTITY_INSERT [dbo].[Rubros] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursales] ON 

INSERT [dbo].[Sucursales] ([idSucursal], [nombre], [direccion], [telefono]) VALUES (1, N'Nana 1', N'24 de Septiembre 1331', N'4860820')
INSERT [dbo].[Sucursales] ([idSucursal], [nombre], [direccion], [telefono]) VALUES (2, N'Nana 2', N'Altolaguirre 2123', N'4533078')
INSERT [dbo].[Sucursales] ([idSucursal], [nombre], [direccion], [telefono]) VALUES (3, N'Deposito', N'Araoz de lamadrid 365', N'8827751')
SET IDENTITY_INSERT [dbo].[Sucursales] OFF
GO
SET IDENTITY_INSERT [dbo].[Talles] ON 

INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (1, N'1')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (2, N'2')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (3, N'3')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (4, N'4')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (5, N'5')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (6, N'6')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (7, N'7')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (8, N'8')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (9, N'U')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (10, N'XS')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (11, N'S')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (12, N'M')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (13, N'L')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (14, N'XL')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (15, N'XXL')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (16, N'80')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (17, N'85')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (18, N'90')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (19, N'95')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (20, N'100')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (21, N'110')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (22, N'115')
INSERT [dbo].[Talles] ([idTalle], [nombre]) VALUES (23, N'120')
SET IDENTITY_INSERT [dbo].[Talles] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposSalida] ON 

INSERT [dbo].[TiposSalida] ([idTipoSalida], [nombre]) VALUES (1, N'Producto')
INSERT [dbo].[TiposSalida] ([idTipoSalida], [nombre]) VALUES (2, N'Nota de credito')
SET IDENTITY_INSERT [dbo].[TiposSalida] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [password], [idRol], [activo]) VALUES (1, N'sergio', N'Unidad', 1, 1)
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [password], [idRol], [activo]) VALUES (2, N'franco', N'1234', 2, 1)
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [password], [idRol], [activo]) VALUES (3, N'g_nana24', N'negocio24', 3, 1)
INSERT [dbo].[Usuarios] ([idUsuario], [usuario], [password], [idRol], [activo]) VALUES (4, N'g_nanayofre', N'negocioYofre', 3, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (40, CAST(N'2021-06-15T00:00:00.000' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (41, CAST(N'2021-06-15T12:05:52.087' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (42, CAST(N'2021-06-15T12:14:45.903' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (43, CAST(N'2021-06-15T12:18:42.733' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (44, CAST(N'2021-06-15T12:23:17.967' AS DateTime), 3, 523.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (45, CAST(N'2021-06-15T12:27:09.000' AS DateTime), 3, 723.0000, 4)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (46, CAST(N'2021-06-15T16:13:30.633' AS DateTime), 3, 500.0000, 4)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (47, CAST(N'2021-06-15T17:47:14.443' AS DateTime), 3, 200.0000, 4)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (48, CAST(N'2021-06-08T00:00:00.000' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (49, CAST(N'2021-06-20T17:51:13.750' AS DateTime), 3, 10.0000, 3)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (50, CAST(N'2021-06-20T18:12:18.927' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (51, CAST(N'2021-06-21T12:37:57.980' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (52, CAST(N'2021-06-21T14:50:13.983' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (53, CAST(N'2021-06-21T14:50:46.457' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (54, CAST(N'2021-06-21T14:54:48.463' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (55, CAST(N'2021-06-21T14:56:02.563' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (56, CAST(N'2021-06-21T14:57:34.900' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (57, CAST(N'2021-06-21T15:00:21.803' AS DateTime), 3, 0.0000, 1)
INSERT [dbo].[Ventas] ([idVenta], [fecha_venta], [idSucursal], [montoDescuento], [idFormaPago]) VALUES (58, CAST(N'2021-06-22T11:45:23.510' AS DateTime), 3, 500.0000, 4)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [Compras_Proveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [Compras_Proveedores]
GO
ALTER TABLE [dbo].[DetallesCompra]  WITH CHECK ADD  CONSTRAINT [DetallesCompra_Compras] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compras] ([idCompra])
GO
ALTER TABLE [dbo].[DetallesCompra] CHECK CONSTRAINT [DetallesCompra_Compras]
GO
ALTER TABLE [dbo].[DetallesCompra]  WITH CHECK ADD  CONSTRAINT [DetallesCompra_Productos] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[DetallesCompra] CHECK CONSTRAINT [DetallesCompra_Productos]
GO
ALTER TABLE [dbo].[DetallesDevolucion]  WITH CHECK ADD  CONSTRAINT [detallesDevolucion_Devoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[Devoluciones] ([idDevolucion])
GO
ALTER TABLE [dbo].[DetallesDevolucion] CHECK CONSTRAINT [detallesDevolucion_Devoluciones]
GO
ALTER TABLE [dbo].[DetallesDevolucion]  WITH CHECK ADD  CONSTRAINT [detallesDevolucion2_Productos] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[DetallesDevolucion] CHECK CONSTRAINT [detallesDevolucion2_Productos]
GO
ALTER TABLE [dbo].[DetallesSalida]  WITH CHECK ADD  CONSTRAINT [FK_DetallesSalidas_Devoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[Devoluciones] ([idDevolucion])
GO
ALTER TABLE [dbo].[DetallesSalida] CHECK CONSTRAINT [FK_DetallesSalidas_Devoluciones]
GO
ALTER TABLE [dbo].[DetallesSalida]  WITH CHECK ADD  CONSTRAINT [FK_DetallesSalidas_TiposSalida] FOREIGN KEY([idTipoSalida])
REFERENCES [dbo].[TiposSalida] ([idTipoSalida])
GO
ALTER TABLE [dbo].[DetallesSalida] CHECK CONSTRAINT [FK_DetallesSalidas_TiposSalida]
GO
ALTER TABLE [dbo].[DetallesVenta]  WITH CHECK ADD  CONSTRAINT [DetallesVenta_Productos] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[DetallesVenta] CHECK CONSTRAINT [DetallesVenta_Productos]
GO
ALTER TABLE [dbo].[DetallesVenta]  WITH CHECK ADD  CONSTRAINT [DetallesVenta_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[DetallesVenta] CHECK CONSTRAINT [DetallesVenta_Ventas]
GO
ALTER TABLE [dbo].[FormasPago]  WITH CHECK ADD  CONSTRAINT [FK_FormasPago_Intereses] FOREIGN KEY([idInteres])
REFERENCES [dbo].[Intereses] ([idInteres])
GO
ALTER TABLE [dbo].[FormasPago] CHECK CONSTRAINT [FK_FormasPago_Intereses]
GO
ALTER TABLE [dbo].[Inventarios]  WITH CHECK ADD  CONSTRAINT [Inventarios_Productos] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[Inventarios] CHECK CONSTRAINT [Inventarios_Productos]
GO
ALTER TABLE [dbo].[Inventarios]  WITH CHECK ADD  CONSTRAINT [Inventarios_Sucursales] FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursales] ([idSucursal])
GO
ALTER TABLE [dbo].[Inventarios] CHECK CONSTRAINT [Inventarios_Sucursales]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Colores] FOREIGN KEY([idColor])
REFERENCES [dbo].[Colores] ([idColor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Colores]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Marcas] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marcas] ([idMarca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Marcas]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Presentaciones] FOREIGN KEY([idPresentacion])
REFERENCES [dbo].[Presentaciones] ([idPresentacion])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Presentaciones]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Rubros] FOREIGN KEY([idRubro])
REFERENCES [dbo].[Rubros] ([idRubro])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Rubros]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Talles] FOREIGN KEY([idTalle])
REFERENCES [dbo].[Talles] ([idTalle])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Talles]
GO
ALTER TABLE [dbo].[Roles_Usuarios]  WITH CHECK ADD  CONSTRAINT [Roles_Usuarios_Roles] FOREIGN KEY([idRol])
REFERENCES [dbo].[Roles] ([idRol])
GO
ALTER TABLE [dbo].[Roles_Usuarios] CHECK CONSTRAINT [Roles_Usuarios_Roles]
GO
ALTER TABLE [dbo].[Roles_Usuarios]  WITH CHECK ADD  CONSTRAINT [Roles_Usuarios_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Roles_Usuarios] CHECK CONSTRAINT [Roles_Usuarios_Usuarios]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_FormasPago] FOREIGN KEY([idFormaPago])
REFERENCES [dbo].[FormasPago] ([idFormaPago])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_FormasPago]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [Ventas_Sucursales] FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursales] ([idSucursal])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [Ventas_Sucursales]
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleVenta]    Script Date: 23/6/2021 13:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertarDetalleVenta]
@idProducto int,
@precioVenta money,
@cantidad int,
@idVenta int
AS
BEGIN
	INSERT INTO DetallesVenta VALUES (@idProducto,@precioVenta,@cantidad,@idVenta)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarVenta]    Script Date: 23/6/2021 13:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertarVenta]
@fechaVenta datetime,
@idSucursal int,
@montoDescuento money,
@idFormaPago int
AS
BEGIN
	INSERT INTO Ventas VALUES (@fechaVenta,@idSucursal,@montoDescuento,@idFormaPago)
END
GO
/****** Object:  StoredProcedure [dbo].[stockPorSucursal]    Script Date: 23/6/2021 13:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stockPorSucursal]
@idProducto int,
@idSucursal int
AS
BEGIN
SELECT inv.cantidad 'Stock'
FROM Productos p 
RIGHT JOIN Inventarios inv ON p.idProducto = inv.idProducto
RIGHT JOIN Sucursales s ON inv.idSucursal = s.idSucursal
WHERE p.idProducto = @idProducto and s.idSucursal = @idSucursal
END
GO
/****** Object:  StoredProcedure [dbo].[TodosLosProductosActivos]    Script Date: 23/6/2021 13:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TodosLosProductosActivos]
AS
BEGIN
SELECT p.idProducto 'ID', p.codigoProv 'Cod Producto', r.idRubro 'Rubro', m.nombre 'Marca', p.articulo 'Articulo', t.idTalle 'Talle', pr.nombre 'Presentacion', c.idColor 'Color', p.descripcion 'Descripcion', CAST((p.precioVenta) AS decimal(7,2)) 'Precio', inv.cantidad 'Stock', suc.nombre 'Negocio'
FROM Productos p 
JOIN Marcas m ON p.idMarca = m.idMarca 
JOIN Presentaciones pr ON p.idPresentacion = pr.idPresentacion
JOIN Talles t ON p.idTalle = t.idTalle
JOIN Colores c ON p.idColor = c.idColor
JOIN Rubros r ON p.idRubro = r.idRubro
LEFT JOIN Inventarios inv ON p.idProducto = inv.idProducto
LEFT JOIN Sucursales suc ON inv.idSucursal = suc.idSucursal
WHERE p.activo = 1
END
GO
USE [master]
GO
ALTER DATABASE [Lenco] SET  READ_WRITE 
GO
