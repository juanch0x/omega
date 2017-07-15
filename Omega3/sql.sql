-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-07-2017 a las 04:09:35
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `omega`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `tipo_documento` int(1) NOT NULL,
  `documento` int(15) NOT NULL,
  `razon_social` varchar(50) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `cod_provincia` int(2) NOT NULL,
  `localidad` varchar(50) NOT NULL,
  `cod_postal` varchar(6) NOT NULL,
  `contacto` varchar(50) NOT NULL,
  `mail_contacto` varchar(100) NOT NULL,
  `mail_factura` varchar(100) NOT NULL,
  `impositiva` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`tipo_documento`, `documento`, `razon_social`, `direccion`, `telefono`, `cod_provincia`, `localidad`, `cod_postal`, `contacto`, `mail_contacto`, `mail_factura`, `impositiva`) VALUES
(2, 2147483647, 'RAMOS ESTEBAN MANUEL', 'VALLE LOS MANANTIALES, MANZANA F 16', '2616987081', 7, 'Luzuriaga City', '5513', 'Nicolás Ramos', 'nico.ramos009@gmail.com', '', 'IVA RESPONSABLE INSCRIPTO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `condicion_frente_al_iva`
--

CREATE TABLE `condicion_frente_al_iva` (
  `id` int(11) NOT NULL,
  `condicion` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `condicion_frente_al_iva`
--

INSERT INTO `condicion_frente_al_iva` (`id`, `condicion`) VALUES
(1, 'MONOTRIBUTISTA'),
(2, 'IVA RESPONSABLE INSCRIPTO'),
(3, 'CONSUMIDOR FINAL'),
(4, 'IVA EXENTO'),
(5, 'IVA NO RESPONSABLE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura_x_condicion`
--

CREATE TABLE `factura_x_condicion` (
  `id_condicion` int(11) NOT NULL,
  `id_factura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura_x_condicion`
--

INSERT INTO `factura_x_condicion` (`id_condicion`, `id_factura`) VALUES
(1, 2),
(1, 7),
(1, 8),
(1, 9),
(2, 1),
(2, 3),
(2, 4),
(2, 5),
(3, 2),
(3, 7),
(3, 8),
(3, 9),
(4, 2),
(4, 7),
(4, 8),
(4, 9),
(5, 2),
(5, 7),
(5, 8),
(5, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `localidad`
--

CREATE TABLE `localidad` (
  `codigo_postal` int(5) NOT NULL,
  `localidad` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `localidad`
--

INSERT INTO `localidad` (`codigo_postal`, `localidad`) VALUES
(5500, 'Ciudad');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medio_de_pago`
--

CREATE TABLE `medio_de_pago` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(33) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medio_de_pago`
--

INSERT INTO `medio_de_pago` (`id`, `descripcion`) VALUES
(1, 'Efectivo'),
(2, 'Cuenta Corriente'),
(3, 'Tarjeta de Debito'),
(4, 'Tarjeta de Credito'),
(5, 'Cheque'),
(6, 'Efectivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `id_pedido` int(11) NOT NULL,
  `id_producto` bigint(200) NOT NULL,
  `cantidad` int(3) NOT NULL,
  `user_pedido` varchar(20) NOT NULL,
  `user_compra` varchar(20) NOT NULL,
  `fecha_pedido` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fecha_compra` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `cantidad_comprada` int(3) NOT NULL,
  `realizado` tinyint(1) NOT NULL,
  `id_proveedor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pedidos`
--

INSERT INTO `pedidos` (`id_pedido`, `id_producto`, `cantidad`, `user_pedido`, `user_compra`, `fecha_pedido`, `fecha_compra`, `cantidad_comprada`, `realizado`, `id_proveedor`) VALUES
(3, 0, 3, 'juanch0x', 'juanch0x', '2017-06-26 17:40:03', '2017-06-28 08:35:12', 0, 0, 0),
(4, 0, 3, 'juanch0x', '', '2017-06-15 23:15:51', '0000-00-00 00:00:00', 0, 0, 0),
(5, 0, 3, 'juanch0x', '', '2017-06-15 23:19:05', '0000-00-00 00:00:00', 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `cod_producto` bigint(200) NOT NULL,
  `producto` varchar(200) NOT NULL,
  `cantidad` int(10) NOT NULL,
  `precio_compra` decimal(10,2) NOT NULL,
  `precio_venta` decimal(10,2) NOT NULL,
  `stock_minimo` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`cod_producto`, `producto`, `cantidad`, `precio_compra`, `precio_venta`, `stock_minimo`) VALUES
(0, 'pepe en patinetas', 0, '292.20', '994.20', 1919),
(1, 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa', 1, '1.00', '1.00', 1),
(20, 'Huevada', 0, '200.00', '25.15', 0),
(77, 'asd', 6, '123.00', '4.00', 1),
(89, '98', 98, '89.00', '98.00', 98),
(111, 'aaa', 4, '141.00', '111.00', 1),
(444, 'nico', 1, '1.00', '1.00', 1),
(819, 'lkjad', 1, '8118.00', '181.00', 1),
(848, 'kjld', 2, '831.00', '18.00', 1),
(1377, 'juancho', 4, '189.00', '894.00', 84),
(8189, 'nocp', 48, '189.00', '12893.00', 81),
(81932989, 'julian', 49, '1412.12', '123.11', 85),
(89128932, 'JOrge', 14, '11231.00', '44181.00', 15),
(98199191, 'jldksjla', 1919, '1818.00', '1818.00', 1919),
(894189891, 'Hierba', 15, '15.15', '51.51', 10),
(6935364070854, 'ahorasi', 72, '27.00', '72.00', 72);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `id_proveedor` int(30) NOT NULL,
  `proveedor` varchar(20) NOT NULL,
  `telefono` bigint(20) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `provincia` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `codigo_postal` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`id_proveedor`, `proveedor`, `telefono`, `direccion`, `provincia`, `email`, `codigo_postal`) VALUES
(2, 'Burger King', 4215819, 'Av Siempre Viva 1337', 'Tuíuman', 'burger@yahoo.com.ar', 5511),
(4, 'asdsad', 12313, 'assad', 'asdsad', 'asad', 555),
(5, 'hdhdhdh', 3454556, 'AHAHAH', 'SGSSH', 'ashdkjQ', 3777);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincia`
--

CREATE TABLE `provincia` (
  `id` smallint(2) NOT NULL,
  `provincia_nombre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `provincia`
--

INSERT INTO `provincia` (`id`, `provincia_nombre`) VALUES
(0, 'Ciudad Autonoma Buenos Aires'),
(1, 'Buenos Aires'),
(2, 'Catamarca'),
(3, 'Córdoba'),
(4, 'Corrientes'),
(5, 'Entre Ríos'),
(6, 'Jujuy'),
(7, 'Mendoza'),
(8, 'La Rioja'),
(9, 'Salta'),
(10, 'San Juan'),
(11, 'San Luis'),
(12, 'Santa Fé'),
(13, 'Santiago del Estero'),
(14, 'Tucumán'),
(16, 'Chaco'),
(17, 'Chubut'),
(18, 'Formosa'),
(19, 'Misiones'),
(20, 'Neuquén'),
(21, 'La Pampa'),
(22, 'Río Negro'),
(23, 'Santa Cruz'),
(24, 'Tierra del Fuego');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

CREATE TABLE `roles` (
  `id_rol` int(3) NOT NULL,
  `nombre_rol` varchar(10) NOT NULL,
  `descripcion_rol` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `roles`
--

INSERT INTO `roles` (`id_rol`, `nombre_rol`, `descripcion_rol`) VALUES
(1, 'Ventas', 'asdsaddsadsd');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_documento`
--

CREATE TABLE `tipo_documento` (
  `id` int(1) NOT NULL,
  `descripcion` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_documento`
--

INSERT INTO `tipo_documento` (`id`, `descripcion`) VALUES
(1, 'CUIT'),
(2, 'DNI'),
(3, 'CUIL');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_factura`
--

CREATE TABLE `tipo_factura` (
  `id` int(11) NOT NULL,
  `factura` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_factura`
--

INSERT INTO `tipo_factura` (`id`, `factura`) VALUES
(1, 'FACTURA A'),
(2, 'FACTURA B'),
(3, 'NOTA DE CREDITO A'),
(4, 'NOTA DE DEBITO A'),
(5, 'RECIBO A'),
(7, 'NOTA DE CREDITO B'),
(8, 'NOTA DE DEBITO B'),
(9, 'RECIBO B');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `id_rol` int(3) NOT NULL,
  `nombre` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `password`, `id_rol`, `nombre`) VALUES
('admin', 'admin', 1, 'administrador'),
('juanch0x', 'asdqwe123', 1, 'Juan Portugal');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`documento`);

--
-- Indices de la tabla `condicion_frente_al_iva`
--
ALTER TABLE `condicion_frente_al_iva`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `factura_x_condicion`
--
ALTER TABLE `factura_x_condicion`
  ADD PRIMARY KEY (`id_condicion`,`id_factura`);

--
-- Indices de la tabla `localidad`
--
ALTER TABLE `localidad`
  ADD PRIMARY KEY (`codigo_postal`);

--
-- Indices de la tabla `medio_de_pago`
--
ALTER TABLE `medio_de_pago`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`id_pedido`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`cod_producto`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id_proveedor`);

--
-- Indices de la tabla `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id_rol`);

--
-- Indices de la tabla `tipo_documento`
--
ALTER TABLE `tipo_documento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipo_factura`
--
ALTER TABLE `tipo_factura`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `condicion_frente_al_iva`
--
ALTER TABLE `condicion_frente_al_iva`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `medio_de_pago`
--
ALTER TABLE `medio_de_pago`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id_proveedor` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `roles`
--
ALTER TABLE `roles`
  MODIFY `id_rol` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tipo_documento`
--
ALTER TABLE `tipo_documento`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `tipo_factura`
--
ALTER TABLE `tipo_factura`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
