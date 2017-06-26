-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 26, 2017 at 04:49 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `omega`
--

-- --------------------------------------------------------

--
-- Table structure for table `localidad`
--

CREATE TABLE `localidad` (
  `codigo_postal` int(5) NOT NULL,
  `localidad` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `localidad`
--

INSERT INTO `localidad` (`codigo_postal`, `localidad`) VALUES
(5500, 'Ciudad');

-- --------------------------------------------------------

--
-- Table structure for table `pedidos`
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
-- Dumping data for table `pedidos`
--

INSERT INTO `pedidos` (`id_pedido`, `id_producto`, `cantidad`, `user_pedido`, `user_compra`, `fecha_pedido`, `fecha_compra`, `cantidad_comprada`, `realizado`, `id_proveedor`) VALUES
(2, 444, 3, 'juanch0x', 'prueba ', '2017-06-23 12:33:20', '0000-00-00 00:00:00', 0, 0, 1),
(3, 1, 3, 'juanch0x', '', '2017-06-22 12:24:58', '0000-00-00 00:00:00', 0, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `productos`
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
-- Dumping data for table `productos`
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
-- Table structure for table `proveedores`
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
-- Dumping data for table `proveedores`
--

INSERT INTO `proveedores` (`id_proveedor`, `proveedor`, `telefono`, `direccion`, `provincia`, `email`, `codigo_postal`) VALUES
(1, 'McDonalds', 4258169, 'Av San Martin 585', 'Mendoza', 'mcdonalds@hotmail.com', 0),
(2, 'Burger King', 4215819, 'Av Siempre Viva 1337', 'Tuíuman', 'burger@yahoo.com.ar', 0);

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `id_rol` int(3) NOT NULL,
  `nombre_rol` varchar(10) NOT NULL,
  `descripcion_rol` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`id_rol`, `nombre_rol`, `descripcion_rol`) VALUES
(1, 'Ventas', 'asdsaddsadsd');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `id_rol` int(3) NOT NULL,
  `nombre` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `password`, `id_rol`, `nombre`) VALUES
('admin', 'admin', 1, 'Administrador'),
('juanch0x', 'asdqwe123', 1, 'Juan Portugal');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `localidad`
--
ALTER TABLE `localidad`
  ADD PRIMARY KEY (`codigo_postal`);

--
-- Indexes for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`id_pedido`);

--
-- Indexes for table `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`cod_producto`);

--
-- Indexes for table `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id_proveedor`);

--
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id_rol`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id_proveedor` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `roles`
--
ALTER TABLE `roles`
  MODIFY `id_rol` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
