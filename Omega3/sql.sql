-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-09-2017 a las 04:16:03
-- Versión del servidor: 10.1.25-MariaDB
-- Versión de PHP: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
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
  `documento` bigint(15) NOT NULL,
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
(0, 0, 'dddd', 'dddddd', '33333', 0, 'ffddff', '445', 'ddffdd', 'ddddddf', '', 'MONOTRIBUTISTA'),
(0, 1, 'sasdsa', 'assadsdsa', '111', 0, 'asds', '444', 'dddsa', '444', '', 'MONOTRIBUTISTA'),
(0, 36859019, 'Juan Portugal', 'Espejo 232 3º Piso', '4251860', 7, 'Mendoza', '5500', 'Juan Portugal', 'thejuasz@gmail.com', '', 'IVA EXENTO'),
(0, 20068955670, 'adsaa', 'asdasdsd', '123', 0, 'asdsda', '11', 'asdsas', 'asdas', '', 'CONSUMIDOR FINAL'),
(0, 20068955671, 'SABATINI LUIS RODOLFO', 'B¿¿ UJEMVI MZNA 5 CASA 19', '5555', 7, 'saddsad', '5539', 'ffff', '1123123', '', 'MONOTRIBUTISTA'),
(0, 30687307123, 'CINEMARK ARGENTINA SOCIEDAD DE RESPONSABILIDAD LIM', 'BERUTI 3399 Piso:5', '75848498', 0, 'Godoy Cruz', '1425', 'Jorge Perez', 'asd@hotmail.com', '', 'CONSUMIDOR FINAL');

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
-- Estructura de tabla para la tabla `detalle_presupuesto`
--

CREATE TABLE `detalle_presupuesto` (
  `id_presupuesto` int(10) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `codigo` bigint(20) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `producto` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_presupuesto`
--

INSERT INTO `detalle_presupuesto` (`id_presupuesto`, `cantidad`, `codigo`, `precio`, `producto`) VALUES
(1, 10, 0, '300.00', 'pepe en patineta'),
(1, 3, 20, '50.00', 'huevada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_venta`
--

CREATE TABLE `detalle_venta` (
  `id_venta` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `codigo` bigint(200) NOT NULL,
  `lista` int(11) NOT NULL,
  `iva` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_venta`
--

INSERT INTO `detalle_venta` (`id_venta`, `cantidad`, `codigo`, `lista`, `iva`) VALUES
(17, 1, 0, 10, 21),
(17, 1, 0, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(18, 1, 111, 10, 21),
(3, 15, 0, 10, 21);

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
(5, 'Cheque');

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
(3, 0, 3, 'juanch0x', 'juanch0x', '2017-06-26 20:40:03', '2017-06-28 11:35:12', 0, 0, 0),
(4, 0, 3, 'juanch0x', '', '2017-06-16 02:15:51', '0000-00-00 00:00:00', 0, 0, 0),
(5, 0, 3, 'juanch0x', '', '2017-06-16 02:19:05', '0000-00-00 00:00:00', 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presupuestos`
--

CREATE TABLE `presupuestos` (
  `id` int(10) NOT NULL,
  `cliente_documento` bigint(20) NOT NULL,
  `total` decimal(20,2) NOT NULL,
  `fecha_presupuesto` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `presupuestos`
--

INSERT INTO `presupuestos` (`id`, `cliente_documento`, `total`, `fecha_presupuesto`) VALUES
(1, 36859019, '300.00', '2017-08-17 00:33:14'),
(2, 0, '500.00', '2017-08-17 00:33:20');

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
  `nombre` varchar(30) NOT NULL,
  `meta_mensual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `password`, `id_rol`, `nombre`, `meta_mensual`) VALUES
('admin', 'admin', 1, 'administrador', 0),
('juanch0x', 'asdqwe123', 1, 'Juan Portugal', 5000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `id` int(11) NOT NULL,
  `cliente_documento` bigint(20) NOT NULL,
  `medio_de_pago` int(11) NOT NULL,
  `vencimiento` timestamp NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP,
  `nro_factura` varchar(20) NOT NULL DEFAULT '0',
  `tipo_factura` int(11) NOT NULL,
  `fecha_venta` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `usuario` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id`, `cliente_documento`, `medio_de_pago`, `vencimiento`, `nro_factura`, `tipo_factura`, `fecha_venta`, `usuario`) VALUES
(1, 0, 0, '2017-09-04 01:19:15', '0', 0, '0000-00-00 00:00:00', 'juanch0x'),
(2, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-15 03:50:03', ''),
(3, 0, 4, '2017-09-04 01:19:21', '0', 0, '2017-08-15 03:50:30', 'juanch0x'),
(4, 36859019, 4, '0000-00-00 00:00:00', '0', 0, '2017-08-15 03:52:20', ''),
(5, 36859019, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-15 03:52:44', ''),
(6, 0, 4, '0000-00-00 00:00:00', '0', 0, '2017-08-15 04:03:25', ''),
(7, 0, 4, '2017-09-01 04:04:55', '0', 0, '2017-08-15 04:05:09', ''),
(8, 0, 4, '2017-09-02 04:12:15', '0', 0, '2017-08-15 04:12:26', ''),
(9, 36859019, 3, '0000-00-00 00:00:00', '0', 0, '2017-08-15 04:16:08', ''),
(10, 30687307123, 4, '2017-09-07 05:37:43', '0', 0, '2017-08-15 05:38:07', ''),
(11, 36859019, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 01:51:57', ''),
(12, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 01:54:51', ''),
(13, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:05:39', ''),
(14, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:08:10', ''),
(15, 20068955671, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:08:48', ''),
(16, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:09:38', ''),
(17, 0, 0, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:11:25', ''),
(18, 20068955671, 1, '0000-00-00 00:00:00', '0', 0, '2017-08-16 02:14:06', '');

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
-- Indices de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  ADD PRIMARY KEY (`id`);

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
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `presupuestos`
--
ALTER TABLE `presupuestos`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
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
--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
