-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: sql10.freesqldatabase.com
-- Generation Time: Jun 01, 2017 at 02:54 PM
-- Server version: 5.5.53-0ubuntu0.14.04.1
-- PHP Version: 5.3.28

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `sql10176067`
--

-- --------------------------------------------------------

--
-- Table structure for table `Productos`
--

CREATE TABLE IF NOT EXISTS `Productos` (
  `cod_producto` int(10) NOT NULL AUTO_INCREMENT,
  `producto` varchar(20) NOT NULL,
  `cantidad` int(3) NOT NULL,
  `precio_compra` decimal(6,4) NOT NULL,
  `precio_venta` decimal(6,4) NOT NULL,
  `stock_minimo` int(4) NOT NULL,
  PRIMARY KEY (`cod_producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Productos`
--

INSERT INTO `Productos` (`cod_producto`, `producto`, `cantidad`, `precio_compra`, `precio_venta`, `stock_minimo`) VALUES
(1, 'Wea', 2, '99.9999', '99.1110', 0),
(2, 'Wea', 2, '99.9999', '99.1110', 0),
(3, 'Wea', 2, '99.9999', '99.1110', 0);

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `usuario` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `id_rol` int(3) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `password`, `id_rol`, `nombre`) VALUES
('juanch0x', 'asdqwe123', 1, 'Juan Portugal');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
