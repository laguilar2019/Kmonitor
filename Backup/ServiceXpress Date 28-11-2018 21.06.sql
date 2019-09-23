-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2018-11-28 21:07:13
-- --------------------------------------
-- Server version 5.6.35-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of ajuste_stock
-- 

DROP TABLE IF EXISTS `ajuste_stock`;
CREATE TABLE IF NOT EXISTS `ajuste_stock` (
  `idAjuste` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(6) DEFAULT NULL,
  `idIngrediente` int(4) DEFAULT NULL,
  `tipoAjuste` enum('INCREMENTAR','DECREMENTAR') DEFAULT NULL,
  `cantidad` decimal(10,2) DEFAULT NULL,
  `justificacion` varchar(300) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  PRIMARY KEY (`idAjuste`),
  KEY `idx_ajuste_producto` (`idProducto`),
  KEY `idx_ajuste_ingrediente` (`idIngrediente`) USING BTREE,
  KEY `idx_ajuste_usuario` (`idUsuario`) USING BTREE,
  CONSTRAINT `fk_ajusteStock_ingrediente` FOREIGN KEY (`idIngrediente`) REFERENCES `ingrediente` (`idIngrediente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ajusteStock_producto` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ajusteStock_usuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table ajuste_stock
-- 

/*!40000 ALTER TABLE `ajuste_stock` DISABLE KEYS */;

/*!40000 ALTER TABLE `ajuste_stock` ENABLE KEYS */;

-- 
-- Definition of caja
-- 

DROP TABLE IF EXISTS `caja`;
CREATE TABLE IF NOT EXISTS `caja` (
  `idCaja` int(11) NOT NULL AUTO_INCREMENT,
  `idCajero` int(3) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `fechaApertura` datetime DEFAULT NULL,
  `fechaCierre` datetime DEFAULT NULL,
  `saldoInicial` decimal(10,2) NOT NULL,
  `efectivo` decimal(11,2) NOT NULL,
  `saldo` decimal(11,2) DEFAULT NULL,
  PRIMARY KEY (`idCaja`),
  KEY `FK_idCajero1_idx` (`idCajero`),
  CONSTRAINT `FK_idCajero1` FOREIGN KEY (`idCajero`) REFERENCES `usuario` (`idUsuario`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table caja
-- 

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
INSERT INTO `caja`(`idCaja`,`idCajero`,`estado`,`fechaApertura`,`fechaCierre`,`saldoInicial`,`efectivo`,`saldo`) VALUES
(1,16,0,'2017-08-12 11:03:52','2017-08-12 21:50:39',95.53,617.48,613.56),
(2,16,0,'2017-08-13 09:36:01','2017-08-13 20:56:33',95.53,849.31,688.84),
(3,16,0,'2017-08-14 11:03:54','2017-08-14 21:19:29',100.00,41.77,140.77),
(4,16,0,'2017-08-15 10:42:15','2017-08-15 21:56:14',100.00,304.45,353.60),
(5,16,0,'2017-08-16 11:14:19','2017-08-17 09:21:53',100.00,128.55,228.55),
(6,16,0,'2017-08-17 09:24:38','2017-08-17 22:45:24',100.00,179.60,184.62),
(7,16,0,'2017-08-18 09:18:08','2017-08-18 22:48:13',100.00,295.03,142.23),
(8,16,0,'2017-08-19 08:37:07','2017-08-19 23:06:28',100.00,578.16,604.47),
(9,16,0,'2017-08-20 09:41:14','2017-08-20 22:08:53',100.00,891.13,976.93),
(10,16,0,'2017-08-21 10:38:05','2017-08-21 21:07:55',100.00,10.43,110.43),
(11,16,0,'2017-08-22 16:40:38','2017-08-22 20:43:07',100.00,51.66,151.66),
(12,16,0,'2017-08-23 13:22:18','2017-08-23 20:56:06',100.00,74.03,151.23),
(13,16,0,'2017-08-24 12:09:27','2017-08-25 09:11:35',100.00,15.12,36.35),
(14,16,0,'2017-08-25 12:00:51','2017-08-25 20:55:30',100.00,114.83,111.91),
(15,16,0,'2017-08-26 11:52:45','2017-08-26 23:24:53',100.00,603.28,680.23),
(16,16,0,'2017-08-27 10:04:58','2017-08-27 23:11:14',100.00,1153.19,1231.79),
(17,16,0,'2017-08-28 12:08:57','2017-08-28 20:52:03',100.00,36.27,129.62),
(18,16,0,'2017-08-29 12:10:11','2017-08-29 21:28:35',100.00,74.15,174.15),
(19,16,0,'2017-08-30 10:15:40','2017-08-30 21:28:43',100.00,144.26,215.36),
(20,16,0,'2017-08-31 10:35:29','2017-08-31 22:53:37',100.00,80.22,108.82),
(21,16,0,'2017-09-01 11:32:11','2017-09-01 22:12:02',100.00,94.79,127.42),
(22,16,0,'2017-09-02 11:06:21','2017-09-02 23:09:50',100.00,441.74,488.29),
(23,16,0,'2017-09-03 08:56:29','2017-09-03 22:30:42',100.00,1047.57,1081.82),
(24,16,0,'2017-09-04 12:28:30','2017-09-04 21:21:39',100.00,214.87,314.87),
(25,16,0,'2017-09-05 11:58:24','2017-09-05 21:06:17',100.00,150.84,226.84),
(26,16,0,'2017-09-06 10:55:53','2017-09-06 23:02:30',100.00,117.07,100.27),
(27,16,0,'2017-09-07 13:02:55','2017-09-08 01:27:43',100.00,772.40,813.46),
(28,16,0,'2017-09-08 08:47:43','2017-09-08 21:21:52',100.00,351.51,289.63),
(29,16,0,'2017-09-09 13:10:35','2017-09-10 08:33:03',100.00,300.55,400.55),
(30,16,0,'2017-09-10 08:33:23','2017-09-10 21:36:51',100.00,850.75,913.65),
(31,16,0,'2017-09-11 10:17:42','2017-09-11 22:09:53',100.00,40.91,140.91),
(32,16,0,'2017-09-12 12:13:21','2017-09-12 20:58:35',100.00,74.18,157.88),
(33,16,0,'2017-09-13 08:50:55','2017-09-13 22:32:06',100.00,97.29,179.29),
(34,16,0,'2017-09-14 16:17:09','2017-09-14 22:38:42',100.00,54.14,66.54),
(35,16,0,'2017-09-15 10:46:50','2017-09-15 23:26:59',100.00,1015.56,1023.41),
(36,16,0,'2017-09-16 09:03:40','2017-09-17 00:15:17',100.00,719.95,770.70),
(37,16,0,'2017-09-17 08:36:23','2017-09-17 21:11:55',100.00,882.28,974.08),
(38,16,0,'2017-09-18 14:13:35','2017-09-18 20:54:34',100.00,89.58,189.58),
(39,16,0,'2017-09-19 10:16:03','2017-09-19 19:53:00',100.00,12.63,99.88),
(40,16,0,'2017-09-20 12:12:21','2017-09-20 20:10:52',100.00,339.86,423.86),
(41,16,0,'2017-09-21 14:01:50','2017-09-21 20:57:22',100.00,93.68,159.34),
(42,16,0,'2017-09-22 12:38:59','2017-09-22 22:18:53',100.00,89.58,62.29),
(43,16,0,'2017-09-23 11:02:41','2017-09-24 00:49:10',67.50,423.76,454.26),
(44,16,0,'2017-09-24 08:22:45','2017-09-25 17:15:20',100.00,754.24,843.74),
(45,16,0,'2017-09-25 17:15:35','2017-09-25 20:02:28',100.00,10.43,110.43),
(46,16,0,'2017-09-26 14:22:55','2017-09-26 20:03:33',100.00,64.02,152.92),
(47,16,0,'2017-09-27 15:32:53','2017-09-27 21:43:44',100.00,156.63,256.63),
(48,16,0,'2017-09-28 16:20:25','2017-09-28 21:44:02',100.00,89.01,159.42),
(49,16,0,'2017-09-29 09:58:35','2017-09-29 21:29:30',100.00,51.09,94.65),
(50,16,0,'2017-09-30 09:31:11','2017-09-30 22:48:44',100.00,183.51,232.76),
(51,16,0,'2017-10-01 08:40:20','2017-10-01 23:11:15',100.00,879.36,977.86),
(52,16,0,'2017-10-02 09:13:39','2017-10-02 21:05:04',100.00,143.15,213.35),
(53,16,0,'2017-10-03 20:31:35','2017-10-03 20:36:52',100.00,17.59,117.59),
(54,16,0,'2017-10-04 12:12:49','2017-10-04 21:56:29',50.00,58.51,72.11),
(55,16,0,'2017-10-05 11:58:59','2017-10-05 21:04:57',100.00,92.87,154.98),
(56,16,0,'2017-10-06 15:16:21','2017-10-07 10:35:05',73.28,229.80,303.08),
(57,16,0,'2017-10-07 10:35:46','2017-10-08 00:46:27',100.00,285.99,366.34),
(58,16,0,'2017-10-08 08:21:30','2017-10-08 21:26:12',100.00,304.27,389.27),
(59,16,0,'2017-10-09 09:56:56','2017-10-09 21:06:22',100.00,0.00,100.00),
(60,16,0,'2017-10-10 11:52:36','2017-10-10 21:04:12',100.00,39.02,126.87),
(61,16,0,'2017-10-11 11:24:01','2017-10-11 21:20:37',100.00,7.68,107.68),
(62,16,0,'2017-10-12 12:43:50','2017-10-12 19:57:24',100.00,81.33,141.58),
(63,16,0,'2017-10-13 10:54:36','2017-10-13 22:43:11',100.00,101.37,146.67),
(64,16,0,'2017-10-14 10:37:30','2017-10-14 23:10:45',100.00,425.41,355.51),
(65,16,0,'2017-10-15 08:18:14','2017-10-15 22:57:13',100.00,1310.67,1377.17),
(66,16,0,'2017-10-16 10:24:00','2017-10-16 20:13:11',100.00,93.15,193.15),
(67,16,1,'2017-10-17 13:20:55','0001-01-01 00:00:00',100.00,1044.84,1144.84);
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;

-- 
-- Definition of cliente
-- 

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `NIT` varchar(45) DEFAULT NULL,
  `regContable` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cliente
-- 

/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente`(`idCliente`,`nombre`,`direccion`,`email`,`telefono`,`NIT`,`regContable`) VALUES
(1,'Empresas I&CL','Sonsonate','correo@empresaslc.com','24525556','116515156','1561561561561'),
(2,'Elmer Israel','Sonsonate','Galdamez','2451001001','1553','5153413515855'),
(3,'Oscar Francisco','Sonsonate','Oscar@yhoo.es','2551515','515153135153','153153153'),
(4,'M&M SOLUTIONS','San Salvador','solutions@yaoo.es','24510101','0212121','21212'),
(10,'Varios','Varios',NULL,NULL,NULL,NULL),
(11,'CENTRO INTEGRAL S.A. DE C.V.','Sonsonate','centrosintegrales@elsalvador.com.sv','21454545','4512-126385-101-5','4455485555');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- 
-- Definition of cocinero
-- 

DROP TABLE IF EXISTS `cocinero`;
CREATE TABLE IF NOT EXISTS `cocinero` (
  `idCocinero` int(3) NOT NULL AUTO_INCREMENT,
  `tiempoOcuapdo` double DEFAULT NULL,
  `idEmpleado` int(3) NOT NULL,
  PRIMARY KEY (`idCocinero`),
  KEY `fk_cocinero_empleado1_idx` (`idEmpleado`),
  CONSTRAINT `fk_cocinero_empleado1` FOREIGN KEY (`idEmpleado`) REFERENCES `empleado` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cocinero
-- 

/*!40000 ALTER TABLE `cocinero` DISABLE KEYS */;

/*!40000 ALTER TABLE `cocinero` ENABLE KEYS */;

-- 
-- Definition of comando
-- 

DROP TABLE IF EXISTS `comando`;
CREATE TABLE IF NOT EXISTS `comando` (
  `idComando` int(2) NOT NULL AUTO_INCREMENT,
  `comando` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idComando`)
) ENGINE=InnoDB AUTO_INCREMENT=91 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table comando
-- 

/*!40000 ALTER TABLE `comando` DISABLE KEYS */;
INSERT INTO `comando`(`idComando`,`comando`) VALUES
(1,'TPV - Ventas'),
(2,'TPV - Pagos'),
(3,'Administrar Clientes'),
(4,'Tickets procesados'),
(10,'Administrar productos'),
(11,'Consultar productos'),
(12,'Administrar ingredientes'),
(13,'Consultar ingredientes'),
(14,'Administrar Recetas'),
(15,'Administrar categorías'),
(16,'Administrar unidades de medida'),
(17,'Ajustar stock'),
(20,'Compras'),
(21,'Proveedores'),
(22,'Consultar proveedores'),
(23,'Administrar Comprobantes de compra'),
(30,'Salones y mesas'),
(40,'Apertura de caja'),
(41,'Cerrar caja'),
(42,'Administrar salida de efectivo'),
(43,'Administración cuentas'),
(50,'Empleados'),
(51,'Roles'),
(52,'Asignar roles'),
(53,'Comandos del sistema'),
(54,'Permisos'),
(55,'Visor de eventos '),
(56,'Administrar sesiones'),
(60,'Reportes avanzados y financieros'),
(61,'Reportes básicos'),
(62,'Reportes de Ventas diarias'),
(70,'Respaldo de BD'),
(71,'Restaurar respaldos'),
(72,'Vaciar BD'),
(80,'Configuración TPV'),
(81,'Administrar datos de la empresa'),
(82,'Configurar tickets'),
(83,'Tiraje de factura'),
(90,'Cambiar usuario');
/*!40000 ALTER TABLE `comando` ENABLE KEYS */;

-- 
-- Definition of compra
-- 

DROP TABLE IF EXISTS `compra`;
CREATE TABLE IF NOT EXISTS `compra` (
  `idCompra` int(11) NOT NULL AUTO_INCREMENT,
  `tipoCompra` enum('PRODUCTOS','INGREDIENTES') NOT NULL,
  `idProveedor` int(11) NOT NULL,
  `idComprobante` int(2) NOT NULL,
  `nComprobante` varchar(20) NOT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `iva` decimal(10,2) NOT NULL,
  `totalPago` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `fk_pedido_mesero1_idx` (`idUsuario`),
  KEY `fk_pedido_proveedor1_idx` (`idProveedor`),
  KEY `fk_compra_comprobante_1_idx` (`idComprobante`),
  CONSTRAINT `fk_compra_comprobante_1` FOREIGN KEY (`idComprobante`) REFERENCES `comprobante` (`idComprobante`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_compra_proveedor1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_compra_usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table compra
-- 

/*!40000 ALTER TABLE `compra` DISABLE KEYS */;

/*!40000 ALTER TABLE `compra` ENABLE KEYS */;

-- 
-- Definition of compra_detalle
-- 

DROP TABLE IF EXISTS `compra_detalle`;
CREATE TABLE IF NOT EXISTS `compra_detalle` (
  `idDetalleCompra` int(11) NOT NULL AUTO_INCREMENT,
  `idCompra` int(11) NOT NULL,
  `idProducto` int(6) DEFAULT NULL,
  `idIngrediente` int(4) DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `subTotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idDetalleCompra`),
  KEY `fk_detalle_producto_idx` (`idProducto`),
  KEY `fk_detalle_compra_idx` (`idCompra`),
  KEY `fk_detalle_ingrediente_idx` (`idIngrediente`),
  CONSTRAINT `fk_detalle_compra` FOREIGN KEY (`idCompra`) REFERENCES `compra` (`idCompra`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_detalle_ingrediente` FOREIGN KEY (`idIngrediente`) REFERENCES `ingrediente` (`idIngrediente`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_detalle_producto` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table compra_detalle
-- 

/*!40000 ALTER TABLE `compra_detalle` DISABLE KEYS */;

/*!40000 ALTER TABLE `compra_detalle` ENABLE KEYS */;

-- 
-- Definition of comprobante
-- 

DROP TABLE IF EXISTS `comprobante`;
CREATE TABLE IF NOT EXISTS `comprobante` (
  `idComprobante` int(2) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idComprobante`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table comprobante
-- 

/*!40000 ALTER TABLE `comprobante` DISABLE KEYS */;
INSERT INTO `comprobante`(`idComprobante`,`Tipo`) VALUES
(1,'FACTURA'),
(2,'PEDIDO'),
(3,'N/A');
/*!40000 ALTER TABLE `comprobante` ENABLE KEYS */;

-- 
-- Definition of configuracion
-- 

DROP TABLE IF EXISTS `configuracion`;
CREATE TABLE IF NOT EXISTS `configuracion` (
  `idConfiguracion` int(2) NOT NULL AUTO_INCREMENT,
  `controlStock` tinyint(1) DEFAULT NULL,
  `incluirPropina` tinyint(1) DEFAULT NULL,
  `propina` decimal(10,2) DEFAULT NULL,
  `incluirImpuesto` tinyint(1) DEFAULT NULL,
  `iva` double(10,2) DEFAULT NULL,
  `mesaVIP` double(10,2) DEFAULT NULL,
  `autorizarDescProp` tinyint(1) NOT NULL,
  `printerComanda` varchar(75) DEFAULT NULL,
  `printerFactura` varchar(75) DEFAULT NULL,
  `printerInformes` varchar(75) DEFAULT NULL,
  `alertaCaja` tinyint(1) DEFAULT NULL,
  `multisesion` tinyint(1) NOT NULL,
  `numSesiones` int(11) NOT NULL,
  PRIMARY KEY (`idConfiguracion`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table configuracion
-- 

/*!40000 ALTER TABLE `configuracion` DISABLE KEYS */;
INSERT INTO `configuracion`(`idConfiguracion`,`controlStock`,`incluirPropina`,`propina`,`incluirImpuesto`,`iva`,`mesaVIP`,`autorizarDescProp`,`printerComanda`,`printerFactura`,`printerInformes`,`alertaCaja`,`multisesion`,`numSesiones`) VALUES
(1,1,1,10.00,0,13,5,0,'EPSON TM-U220 Receipt','WorkCentre 6605DN-55CBD6 PS','Microsoft Print to PDF',1,0,1);
/*!40000 ALTER TABLE `configuracion` ENABLE KEYS */;

-- 
-- Definition of cuenta
-- 

DROP TABLE IF EXISTS `cuenta`;
CREATE TABLE IF NOT EXISTS `cuenta` (
  `idCuenta` int(2) NOT NULL AUTO_INCREMENT,
  `nombreCuenta` varchar(45) DEFAULT NULL,
  `numero` varchar(25) DEFAULT NULL,
  `saldo` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`idCuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cuenta
-- 

/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;
INSERT INTO `cuenta`(`idCuenta`,`nombreCuenta`,`numero`,`saldo`) VALUES
(1,'Ventas en efectivo','4850000',465.51),
(2,'Ventas tarjeta de credito','155550020221',609.85),
(3,'Pagos Mixtos(Efectivo + Tarjeta de Crédito)','55251515',0.00);
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

-- 
-- Definition of egreso
-- 

DROP TABLE IF EXISTS `egreso`;
CREATE TABLE IF NOT EXISTS `egreso` (
  `idEgreso` int(11) NOT NULL AUTO_INCREMENT,
  `idCaja` int(11) DEFAULT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `cantidad` decimal(11,2) DEFAULT NULL,
  PRIMARY KEY (`idEgreso`),
  KEY `FK_idCaja2_idx` (`idCaja`),
  KEY `Fk_usr_egreso` (`idUsuario`) USING BTREE,
  CONSTRAINT `FK_idCaja2` FOREIGN KEY (`idCaja`) REFERENCES `caja` (`idCaja`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fk_usr_egreso` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=223 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table egreso
-- 

/*!40000 ALTER TABLE `egreso` DISABLE KEYS */;
INSERT INTO `egreso`(`idEgreso`,`idCaja`,`idUsuario`,`fecha`,`descripcion`,`cantidad`) VALUES
(1,1,16,'2017-08-12 11:21:21','GASOLINA',15.00),
(2,1,16,'2017-08-12 11:21:59','MOLINO',0.35),
(3,1,16,'2017-08-12 11:32:39','CAFE',30.00),
(4,1,16,'2017-08-12 12:06:12','HIELO',9.15),
(5,1,16,'2017-08-12 17:23:48','2 TAMBON DE GAZ',20.80),
(6,1,16,'2017-08-12 19:51:39','MORAS, ',1.00),
(7,1,16,'2017-08-12 19:52:34','LIBRA DE QUESO',3.50),
(8,1,16,'2017-08-12 19:53:00','MARGARINA, SHAMPON',4.65),
(9,1,16,'2017-08-12 21:49:45','PAN FRANCES',10.00),
(10,1,16,'2017-08-12 21:50:09','SANDIA',5.00),
(11,2,16,'2017-08-13 09:45:07','MERCADO',19.50),
(12,2,16,'2017-08-13 12:26:10','MOLINO',0.50),
(13,2,16,'2017-08-13 18:16:58','JOSE TORRETO',15.00),
(14,2,16,'2017-08-13 18:17:34','ANDERSON',24.00),
(15,2,16,'2017-08-13 19:39:44','JOHANA',21.00),
(16,2,16,'2017-08-13 20:25:19','RONY',25.00),
(17,2,16,'2017-08-13 20:40:50','ANDREA',26.00),
(18,2,16,'2017-08-13 20:42:15','LINCEY',43.00),
(19,2,16,'2017-08-13 20:42:40','DANIEL',82.00),
(20,3,16,'2017-08-14 19:04:05','LIJA',1.00),
(21,4,16,'2017-08-15 11:04:24','CARTON DE HUEVO ',3.75),
(22,4,16,'2017-08-15 11:05:15','HUEVO',1.70),
(23,4,16,'2017-08-15 11:05:59','QUESO Y CREMA',30.00),
(24,4,16,'2017-08-15 21:14:39','QUESILLO',12.90),
(25,4,16,'2017-08-15 21:55:17','PAN FRANCES',2.50),
(30,6,16,'2017-08-17 22:41:48','HUEVOS',3.25),
(31,6,16,'2017-08-17 22:42:29','JABON Y CEBOLLA',1.25),
(32,6,16,'2017-08-17 22:42:51','AXBEN',86.23),
(33,6,16,'2017-08-17 22:43:39','HUEVOS',4.25),
(36,7,16,'2017-08-18 11:33:58','COUMERSAL',16.70),
(37,7,16,'2017-08-18 12:29:02','LECHE SALUD',14.25),
(38,7,16,'2017-08-18 22:23:57','ALPINA',11.00),
(39,7,16,'2017-08-18 22:25:45','BIMBO',10.00),
(40,7,16,'2017-08-18 22:26:17','HIELO',9.15),
(41,7,16,'2017-08-18 22:26:48','CARLOS MERCADO',46.50),
(42,7,16,'2017-08-18 22:31:28','TONY',27.60),
(43,7,16,'2017-08-18 22:45:10','GALLINAS',52.00),
(44,7,16,'2017-08-18 22:46:39','TIENDA SAN JOSE',65.60),
(45,8,16,'2017-08-19 08:37:28','PAN FRANCES',5.00),
(46,8,16,'2017-08-19 09:35:53','PASAJE DIEGO',1.00),
(47,8,16,'2017-08-19 09:36:37','MOLINO',2.00),
(48,8,16,'2017-08-19 10:15:35','MARISCOS',30.00),
(49,8,16,'2017-08-19 10:52:11','SELECTOS',30.44),
(50,8,16,'2017-08-19 11:31:52','MASA',0.25),
(51,8,16,'2017-08-19 22:52:28','PAN FRANCES',5.00),
(52,9,16,'2017-08-20 09:44:27','GAS',10.40),
(54,9,16,'2017-08-20 10:56:16','SANDIA',3.00),
(55,9,16,'2017-08-20 11:11:19','DIARIO',0.50),
(56,9,16,'2017-08-20 11:34:09','MOLINO',0.30),
(57,12,16,'2017-08-23 13:30:53','QUESILLO ',10.00),
(58,12,16,'2017-08-23 13:31:25','GAS',10.40),
(59,12,16,'2017-08-23 13:31:57','CONSOME DE POLLO',2.40),
(60,13,16,'2017-08-24 12:11:57','MERCASDO',3.00),
(61,13,16,'2017-08-24 12:12:30','MOLINO',0.30),
(62,13,16,'2017-08-24 13:45:02','POLLO INDIO',22.52),
(63,13,16,'2017-08-24 15:27:41','DISTRIBUIDORA AXBEN',29.85),
(64,13,16,'2017-08-25 09:08:28','FERRETERIA',23.10),
(65,14,16,'2017-08-25 12:52:11','3LB PAPAS',13.80),
(66,14,16,'2017-08-25 13:04:50','LECHE SALUD',16.40),
(67,14,16,'2017-08-25 16:45:47','BIMBO',5.37),
(68,14,16,'2017-08-25 19:48:11','TIENDA SAN JOSE',67.35),
(69,15,16,'2017-08-26 11:53:17','MOLINO',0.50),
(70,15,16,'2017-08-26 11:53:47','SIETE BOLSAS DE HIELO',6.65),
(71,15,16,'2017-08-26 11:56:13','UN PAQUETE DE AGUA',2.50),
(72,15,16,'2017-08-26 14:12:51','GAS',10.40),
(73,15,16,'2017-08-26 18:27:07','MASA',2.00),
(74,15,16,'2017-08-26 19:25:29','GUINEO',1.00),
(75,16,16,'2017-08-27 10:05:36','TOMATE',2.00),
(76,16,16,'2017-08-27 10:06:03','AGUACATE',1.00),
(77,16,16,'2017-08-27 10:06:24','MEDIO GALON DE MAYONESA',2.50),
(78,16,16,'2017-08-27 10:07:28','UNA TIRA DE CANELA',1.30),
(79,16,16,'2017-08-27 10:07:56','DOS CREMAS DE HONGOS',1.30),
(80,16,16,'2017-08-27 10:08:52','CANELA MOLIDA',0.30),
(81,16,16,'2017-08-27 10:09:15','UNA LIBRA DE QUESO',3.00),
(82,16,16,'2017-08-27 10:12:05','PAN FRANCES',10.00),
(83,17,16,'2017-08-28 12:09:54','HIELO',6.65),
(84,19,16,'2017-08-30 10:17:38','GAS',5.90),
(85,19,16,'2017-08-30 10:24:39','QUESO',21.00),
(86,19,16,'2017-08-30 18:42:03','AGUACATE',2.00),
(87,20,16,'2017-08-31 13:34:14','POLLO',15.00),
(88,20,16,'2017-08-31 16:12:20','GASTO DE TIENDA SAN JOSE',47.60),
(89,20,16,'2017-08-31 17:26:41','AGUA ALPINA',8.80),
(90,21,16,'2017-09-01 14:18:00','PAN DE HAMBURGUESA',2.32),
(91,21,16,'2017-09-01 14:41:19','LECHE GALON',14.25),
(92,21,16,'2017-09-01 15:26:36','BIGONES DE ACEITE ,PAPEL TOALLA',49.80),
(93,21,16,'2017-09-01 17:56:20','PAN FRANCES',1.00),
(94,22,16,'2017-09-02 11:53:03','HIELO',9.15),
(95,22,16,'2017-09-02 14:08:05','TRES BOTELLAS DE CREMA',9.00),
(96,22,16,'2017-09-02 14:08:50','TRES LIBRAS DE QUESILLO ESPECIAL',6.45),
(97,22,16,'2017-09-02 14:09:25','CINCO LIBRAS DE QUESO DURO',15.00),
(98,22,16,'2017-09-02 14:10:00','GAS',11.10),
(99,22,16,'2017-09-02 16:49:44','CORTINA DE BAÑO',2.75),
(100,23,16,'2017-09-03 10:55:03','MARISCOS',38.00),
(101,23,16,'2017-09-03 13:35:05','DOS VIDONES DE AGUA',24.00),
(102,23,16,'2017-09-03 15:16:33','MASA',0.75),
(103,23,16,'2017-09-03 15:22:21','AGUACATE',3.00),
(104,25,16,'2017-09-05 12:20:28','QUESO',24.00),
(105,26,16,'2017-09-06 12:58:06','CAFE',36.25),
(106,26,16,'2017-09-06 15:40:11','LECHE ',5.20),
(107,26,16,'2017-09-06 15:40:36','CONSTANCIA ',24.95),
(108,26,16,'2017-09-06 16:13:51','PEGALOCA',1.05),
(109,26,16,'2017-09-06 17:46:49','GAS',11.10),
(110,26,16,'2017-09-06 22:12:43','QUESILLO',38.25),
(111,27,16,'2017-09-07 14:58:14','CHORIZO ARGENTINO ',21.09),
(112,27,16,'2017-09-07 21:20:14','BANDEJA DESECHABLE',2.00),
(113,27,16,'2017-09-07 21:20:53','GALLETA LIDO',2.20),
(114,27,16,'2017-09-07 21:21:29','LECHE SALUD',5.20),
(115,27,16,'2017-09-07 22:24:04','GAS',26.50),
(116,27,16,'2017-09-07 23:14:04','VASOS DESECHABLES',1.95),
(119,28,16,'2017-09-08 11:31:51','GUMERSAL',47.30),
(120,28,16,'2017-09-08 12:29:35','PAN',2.00),
(121,28,16,'2017-09-08 12:42:36','SEIS PAPAS',27.60),
(122,28,16,'2017-09-08 12:43:17','UNA COSTILLA',17.00),
(123,28,16,'2017-09-08 12:54:19','SERVILLETA LUCCA',11.24),
(124,28,16,'2017-09-08 13:46:17','GASOLINA',3.10),
(125,28,16,'2017-09-08 13:47:48','BIMBO',7.69),
(126,28,16,'2017-09-08 13:52:30','TRES GALONES DE LECHE',14.25),
(127,28,16,'2017-09-08 14:13:44','VERDURA',28.25),
(128,28,16,'2017-09-08 16:55:17','PERIODICO',0.25),
(129,28,16,'2017-09-08 19:46:31','ATUN ASPIRALES',0.65),
(130,28,16,'2017-09-08 19:47:21','CANDELA',1.50),
(131,28,16,'2017-09-08 19:47:59','SODA CAUSTICA',1.05),
(132,30,16,'2017-09-10 10:28:56','TRES BOTELLAS DE CREMA',9.00),
(133,30,16,'2017-09-10 10:30:04','DOS LIBRAS DE QUESO DURO BLANDO',6.00),
(134,30,16,'2017-09-10 11:35:03','DIARTIO',0.50),
(135,30,16,'2017-09-10 11:36:18','TRES ESCOBAS',9.50),
(136,30,16,'2017-09-10 17:45:03','GAS',11.10),
(137,30,16,'2017-09-10 18:36:52','JABON DE TRASTE',1.00),
(138,32,16,'2017-09-12 20:57:57','constancia',16.30),
(139,33,16,'2017-09-13 14:34:57','LEÑA',18.00),
(140,34,16,'2017-09-14 17:20:14','TIENDA SAN JOSE',70.00),
(141,34,16,'2017-09-14 22:09:01','AGUA CRISTAL',17.60),
(142,35,16,'2017-09-15 23:21:54','MASECA',3.00),
(143,35,16,'2017-09-15 23:22:16','GAS',22.20),
(144,35,16,'2017-09-15 23:22:39','HUEVOS',12.00),
(145,35,16,'2017-09-15 23:23:04','FOSFOROS',1.00),
(146,35,16,'2017-09-15 23:23:23','CHOCOLATE',5.00),
(147,35,16,'2017-09-15 23:23:43','QUESO',26.00),
(148,35,16,'2017-09-15 23:24:17','PAPAS',13.80),
(149,35,16,'2017-09-15 23:24:55','HIELO',9.15),
(150,36,16,'2017-09-16 12:00:57','MOLINO',3.00),
(151,36,16,'2017-09-16 12:30:57','CURTIDO',2.00),
(152,36,16,'2017-09-16 13:45:47','GAS',11.10),
(153,36,16,'2017-09-16 17:24:17','TRES BOTELLAS DE CREMA',9.00),
(154,36,16,'2017-09-16 17:24:39','CINCO LIBRAS DE QUESO DURO',15.00),
(155,36,16,'2017-09-16 18:11:34','SIETE BOLSAS DE HIELO',6.65),
(156,36,16,'2017-09-16 18:12:20','UN PAQUETE DE AGUA',2.50),
(157,37,16,'2017-09-17 08:36:49','PAN',5.00),
(158,37,16,'2017-09-17 11:37:49','MASA',0.50),
(159,37,16,'2017-09-17 12:37:07','DIARIO',0.50),
(160,37,16,'2017-09-17 14:50:12','DOS PAQUETES GALLETA SALADINA',2.20),
(161,39,16,'2017-09-19 12:46:12','FERRETERIA',12.75),
(162,40,16,'2017-09-20 20:10:09','verduras',16.00),
(163,41,16,'2017-09-21 20:55:59','ambex',34.34),
(164,42,16,'2017-09-22 12:39:14','LECHE SALUD',14.25),
(165,42,16,'2017-09-22 12:40:24','HIELO',9.15),
(166,42,16,'2017-09-22 16:49:09','ALPINA',22.00),
(167,42,16,'2017-09-22 16:49:54','BIMBO',4.29),
(168,42,16,'2017-09-22 21:32:29','QUESO',27.00),
(169,42,16,'2017-09-22 21:32:43','TIENDA',50.60),
(170,43,16,'2017-09-23 12:34:39','CATORCE LIBRAS DE CAFE',35.00),
(171,43,16,'2017-09-24 00:35:04','MOLINO',2.00),
(172,44,16,'2017-09-24 08:23:42','PAN',10.00),
(173,44,16,'2017-09-24 12:21:18','DIARIO',0.50),
(174,46,16,'2017-09-26 20:03:10','GAS',11.10),
(175,48,16,'2017-09-28 16:51:36','POLLO INDIO',27.59),
(176,48,16,'2017-09-28 16:51:57','MASA',2.00),
(177,49,16,'2017-09-29 21:27:08','alpina',11.00),
(178,49,16,'2017-09-29 21:27:23','ESMIRNOFF',29.99),
(179,49,16,'2017-09-29 21:27:57','PECHUGA',9.50),
(180,49,16,'2017-09-29 21:28:19','BIMBO',5.95),
(181,50,16,'2017-09-30 13:59:08','UN CIENTO DE NARANJA',7.00),
(182,50,16,'2017-09-30 17:55:13','QUESOS',43.75),
(183,51,16,'2017-10-01 11:08:35','CEBOLLA',1.00),
(184,51,16,'2017-10-01 11:11:50','MOLINO',0.50),
(185,52,16,'2017-10-02 21:03:06','pago de personal y otros gastos',29.80),
(186,54,16,'2017-10-04 18:00:05','insumos',36.40),
(187,55,16,'2017-10-05 12:14:17','gas',11.85),
(188,55,16,'2017-10-05 14:18:43','pollo indio',26.04),
(189,57,16,'2017-10-07 11:12:10','MOLINO',0.50),
(190,57,16,'2017-10-07 12:17:47','HIELO',9.15),
(191,57,16,'2017-10-07 18:00:51','POLLO',10.00),
(192,58,16,'2017-10-08 08:27:55','PAN',10.00),
(194,58,16,'2017-10-08 08:46:36','BANANO',1.00),
(195,58,16,'2017-10-08 09:01:58','SANDIA',2.00),
(196,58,16,'2017-10-08 11:30:49','MOLINO',0.50),
(197,58,16,'2017-10-08 11:48:25','DIARIO',0.50),
(198,58,16,'2017-10-08 18:16:43','JABON',1.00),
(199,60,16,'2017-10-10 20:31:43','TUBO',4.15),
(200,60,16,'2017-10-10 20:32:17','BARTENDER',8.00),
(201,62,16,'2017-10-12 12:44:17','molino',0.50),
(203,62,16,'2017-10-12 19:07:23','materiales',21.25),
(205,62,16,'2017-10-12 19:33:47','carne',18.00),
(206,63,16,'2017-10-13 11:51:50','arroz',21.24),
(207,63,16,'2017-10-13 13:09:49','leche',9.50),
(208,63,16,'2017-10-13 13:26:22','pan',8.11),
(210,63,16,'2017-10-13 16:11:44','verdura',9.25),
(211,63,16,'2017-10-13 22:16:46','agua',6.60),
(212,64,16,'2017-10-14 12:04:13','DIEGO',20.00),
(213,64,16,'2017-10-14 12:14:49','CAFE',36.25),
(214,64,16,'2017-10-14 12:27:15','HIELO',9.15),
(215,64,16,'2017-10-14 16:37:18','COCACOLA',80.55),
(216,64,16,'2017-10-14 19:49:19','MOLINO',0.25),
(217,64,16,'2017-10-14 21:52:15','GAS',23.70),
(218,65,16,'2017-10-15 08:18:26','PAN',5.00),
(220,65,16,'2017-10-15 11:12:27','GASOLINA',20.00),
(221,65,16,'2017-10-15 11:12:50','GASTOS',8.00),
(222,65,16,'2017-10-15 11:34:54','DIARIO',0.50);
/*!40000 ALTER TABLE `egreso` ENABLE KEYS */;

-- 
-- Definition of empleado
-- 

DROP TABLE IF EXISTS `empleado`;
CREATE TABLE IF NOT EXISTS `empleado` (
  `idEmpleado` int(3) NOT NULL AUTO_INCREMENT,
  `nombres` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `DUI` varchar(15) DEFAULT NULL,
  `NIT` varchar(45) DEFAULT NULL,
  `sueldoBase` decimal(5,2) DEFAULT NULL,
  `comision` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table empleado
-- 

/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado`(`idEmpleado`,`nombres`,`apellidos`,`direccion`,`email`,`telefono`,`DUI`,`NIT`,`sueldoBase`,`comision`) VALUES
(1,'Elmer','Galdamez','Sonsonate','elmer@yahoo.es','21452525','11515315','5315315315',600.00,5.00),
(15,'.DANIEL','RAMIREZ','','','12345678','','',0.00,0.00),
(16,'ADMINISTRADOR','RAMIREZ','','','12345678','','',0.00,0.00),
(17,'ANTONIO','HERNANDEZ','','','23134553','','',0.00,0.00),
(20,'ALEX','MEJIA','','','56848698','','',0.00,0.00),
(21,'ANDERSON ','MENDOZA','','','76585423','','',0.00,0.00),
(22,'ANDREA ','MEJIA','','','42345342','','',0.00,0.00),
(23,'LINCEY','TORRENTO','','','65746576','','',0.00,0.00),
(24,'RONY','A','','','22467876','','',0.00,0.00),
(25,'JOSE','TORRENTO','','','09876746','','',0.00,0.00),
(26,'FERNANDO','ROBERTO','','','23453567','','',0.00,0.00),
(27,'JOSUE','G','','','78685524','','',0.00,0.00),
(28,'LESLY','VASQUEZ','','','24431461','','',0.00,0.00),
(29,'LESLY','VASQUEZ','','','34256786','','',0.00,0.00),
(30,'Josseline','Gómez','','','70707070','','',0.00,0.00),
(31,'JOSELINE','G','','','42564356','','',0.00,0.00);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;

-- 
-- Definition of empresa
-- 

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `idEmpresa` int(2) NOT NULL AUTO_INCREMENT,
  `nombreEmpresa` varchar(70) DEFAULT NULL,
  `slogan` varchar(70) DEFAULT NULL,
  `direccion` varchar(75) NOT NULL,
  `telefono` varchar(12) NOT NULL,
  `logo` varchar(100) DEFAULT NULL,
  `firma` varchar(100) DEFAULT NULL,
  `sello` varchar(100) DEFAULT NULL,
  `saludo` varchar(100) NOT NULL,
  `NRC` varchar(20) NOT NULL,
  `NIT` varchar(20) NOT NULL,
  `numAutorizacion` varchar(20) NOT NULL,
  PRIMARY KEY (`idEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table empresa
-- 

/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa`(`idEmpresa`,`nombreEmpresa`,`slogan`,`direccion`,`telefono`,`logo`,`firma`,`sello`,`saludo`,`NRC`,`NIT`,`numAutorizacion`) VALUES
(1,'RESTAURANTE Y HOSTAL BUENOS AIRES','',' 2 AVE NORTE, FINCA BUENOS AIRES ATACO','2450-5034','','','','','0000','0000','0000');
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;

-- 
-- Definition of estado
-- 

DROP TABLE IF EXISTS `estado`;
CREATE TABLE IF NOT EXISTS `estado` (
  `idEstado` int(11) NOT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `color` varchar(45) DEFAULT NULL,
  `indexColor` int(2) DEFAULT NULL,
  PRIMARY KEY (`idEstado`),
  KEY `idEstado_idx1` (`idEstado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table estado
-- 

/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado`(`idEstado`,`estado`,`color`,`indexColor`) VALUES
(1,'RECIBIDO','White',10),
(2,'PREPARANDO','Yellow',1),
(3,'COCINANDO','GreenYellow',3),
(4,'DESPACHADO','Red',4);
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;

-- 
-- Definition of familia
-- 

DROP TABLE IF EXISTS `familia`;
CREATE TABLE IF NOT EXISTS `familia` (
  `idFamilia` int(3) NOT NULL AUTO_INCREMENT,
  `activo` tinyint(1) NOT NULL,
  `familia` varchar(255) NOT NULL,
  `grupoPrinter` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idFamilia`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table familia
-- 

/*!40000 ALTER TABLE `familia` DISABLE KEYS */;
INSERT INTO `familia`(`idFamilia`,`activo`,`familia`,`grupoPrinter`) VALUES
(26,1,'DESAYUNOS','COCINA'),
(27,1,'CARNES','COCINA'),
(28,1,'AVES','COCINA'),
(29,1,'MARISCOS','COCINA'),
(30,1,'CAMARONES','COCINA'),
(31,1,'COCTELES','COCINA'),
(32,1,'INFANTILES','COCINA'),
(33,1,'ENSALADAS','COCINA'),
(34,1,'POSTRES','BARRA'),
(35,1,'BEBIDAS FRIAS','BARRA'),
(36,1,'BEBIDAS CALIENTES','BARRA'),
(37,1,'CERVEZAS','BARRA'),
(38,1,'TRAGOS','BARRA'),
(40,1,'HOSTAL','HABITACIONES'),
(41,1,'BEBIDAS PREPARADAS','BARRA'),
(44,1,'ORDENES EXTRAS','COCINA'),
(45,1,'SOPA DE GALLINA','COCINA'),
(46,1,'PISCINA','ALQUILER'),
(47,1,'PLATOS DE BOCA','COCINA'),
(51,1,'ENTRADAS','COCINA');
/*!40000 ALTER TABLE `familia` ENABLE KEYS */;

-- 
-- Definition of ingrediente
-- 

DROP TABLE IF EXISTS `ingrediente`;
CREATE TABLE IF NOT EXISTS `ingrediente` (
  `idIngrediente` int(4) NOT NULL AUTO_INCREMENT,
  `idUnidad` int(3) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `stock` decimal(8,3) unsigned NOT NULL,
  `precio` decimal(8,2) NOT NULL,
  PRIMARY KEY (`idIngrediente`),
  KEY `FK_unidad2_idx` (`idUnidad`),
  CONSTRAINT `FK_unidad2` FOREIGN KEY (`idUnidad`) REFERENCES `unidadmedida` (`idUnidad`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table ingrediente
-- 

/*!40000 ALTER TABLE `ingrediente` DISABLE KEYS */;
INSERT INTO `ingrediente`(`idIngrediente`,`idUnidad`,`nombre`,`stock`,`precio`) VALUES
(1,5,'Aúcar',100.000,2.30);
/*!40000 ALTER TABLE `ingrediente` ENABLE KEYS */;

-- 
-- Definition of ingrediente_producto
-- 

DROP TABLE IF EXISTS `ingrediente_producto`;
CREATE TABLE IF NOT EXISTS `ingrediente_producto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idIngrediente` int(4) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `cantidad` decimal(8,3) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idProducto_dx` (`idProducto`),
  KEY `idIngrediente_dx` (`idIngrediente`),
  CONSTRAINT `ingrediente_producto_ibfk_1` FOREIGN KEY (`idIngrediente`) REFERENCES `ingrediente` (`idIngrediente`) ON UPDATE CASCADE,
  CONSTRAINT `ingrediente_producto_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table ingrediente_producto
-- 

/*!40000 ALTER TABLE `ingrediente_producto` DISABLE KEYS */;

/*!40000 ALTER TABLE `ingrediente_producto` ENABLE KEYS */;

-- 
-- Definition of logfile
-- 

DROP TABLE IF EXISTS `logfile`;
CREATE TABLE IF NOT EXISTS `logfile` (
  `idLog` int(11) NOT NULL AUTO_INCREMENT,
  `idSesion` int(11) NOT NULL,
  `idUsuario` int(3) NOT NULL,
  `fecha` datetime NOT NULL,
  `log` varchar(100) NOT NULL,
  `estado` varchar(25) NOT NULL,
  PRIMARY KEY (`idLog`),
  KEY `usuarioLod_idx` (`idUsuario`),
  KEY `usuarioSesio_idx` (`idSesion`),
  CONSTRAINT `FK_logUsuario` FOREIGN KEY (`idUsuario`) REFERENCES `empleado` (`idEmpleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_sesionUsuario` FOREIGN KEY (`idSesion`) REFERENCES `sesion` (`idSesion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=809 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table logfile
-- 

/*!40000 ALTER TABLE `logfile` DISABLE KEYS */;
INSERT INTO `logfile`(`idLog`,`idSesion`,`idUsuario`,`fecha`,`log`,`estado`) VALUES
(1,2633,1,'2018-05-04 16:39:06','Vaciar la tabla LogFile completamente','Se produjo un error'),
(2,2634,1,'2018-05-04 17:22:28','Inicio de sesión','Satisfactorio'),
(3,2634,1,'2018-05-04 17:22:32','Ingreso a productos','Satisfactorio'),
(4,2634,1,'2018-05-04 17:22:53','Ingreso a productos','Satisfactorio'),
(5,2635,1,'2018-05-04 17:23:52','Inicio de sesión','Satisfactorio'),
(6,2635,1,'2018-05-04 17:23:55','Ingreso a productos','Satisfactorio'),
(7,2636,1,'2018-05-04 17:31:18','Inicio de sesión','Satisfactorio'),
(8,2636,1,'2018-05-04 17:31:21','Ingreso a productos','Satisfactorio'),
(9,2637,1,'2018-05-04 17:33:01','Inicio de sesión','Satisfactorio'),
(10,2637,1,'2018-05-04 17:33:17','Ingreso a productos','Satisfactorio'),
(11,2637,1,'2018-05-04 17:33:30','Ingreso a productos','Satisfactorio'),
(12,2638,1,'2018-05-04 17:51:23','Inicio de sesión','Satisfactorio'),
(13,2639,1,'2018-05-04 17:57:49','Inicio de sesión','Satisfactorio'),
(14,2639,1,'2018-05-04 17:58:21','Ingreso a TPV','Satisfactorio'),
(15,2639,1,'2018-05-04 17:59:12','Cierre de sesión','Satisfactorio'),
(16,2640,1,'2018-06-23 11:17:04','Inicio de sesión','Satisfactorio'),
(17,2640,1,'2018-06-23 11:17:07','Ingreso a TPV','Satisfactorio'),
(18,2640,1,'2018-06-23 11:18:32','Cierre de sesión','Satisfactorio'),
(19,2641,1,'2018-06-23 11:18:38','Inicio de sesión','Satisfactorio'),
(20,2641,1,'2018-06-23 11:18:40','Ingreso a TPV','Satisfactorio'),
(21,2642,1,'2018-06-23 11:38:28','Inicio de sesión','Satisfactorio'),
(22,2642,1,'2018-06-23 11:38:30','Ingreso a TPV','Satisfactorio'),
(23,2643,1,'2018-06-23 11:50:36','Inicio de sesión','Satisfactorio'),
(24,2643,1,'2018-06-23 11:50:37','Ingreso a TPV','Satisfactorio'),
(25,2643,1,'2018-06-23 11:51:19','Cierre de sesión','Satisfactorio'),
(26,2644,1,'2018-06-23 11:52:13','Inicio de sesión','Satisfactorio'),
(27,2644,1,'2018-06-23 11:52:15','Ingreso a TPV','Satisfactorio'),
(28,2644,1,'2018-06-23 11:55:39','Cierre de sesión','Satisfactorio'),
(29,2645,1,'2018-06-23 11:56:05','Inicio de sesión','Satisfactorio'),
(30,2645,1,'2018-06-23 11:56:06','Ingreso a TPV','Satisfactorio'),
(31,2645,1,'2018-06-23 11:56:28','Cierre de sesión','Satisfactorio'),
(32,2646,1,'2018-06-23 11:57:43','Inicio de sesión','Satisfactorio'),
(33,2646,1,'2018-06-23 11:57:44','Ingreso a TPV','Satisfactorio'),
(34,2646,1,'2018-06-23 11:58:04','Cierre de sesión','Satisfactorio'),
(35,2647,1,'2018-06-23 11:58:38','Inicio de sesión','Satisfactorio'),
(36,2647,1,'2018-06-23 11:58:39','Ingreso a TPV','Satisfactorio'),
(37,2648,1,'2018-06-23 12:00:56','Inicio de sesión','Satisfactorio'),
(38,2648,1,'2018-06-23 12:00:58','Ingreso a TPV','Satisfactorio'),
(39,2649,1,'2018-06-23 12:03:56','Inicio de sesión','Satisfactorio'),
(40,2649,1,'2018-06-23 12:03:58','Ingreso a TPV','Satisfactorio'),
(41,2650,1,'2018-06-23 12:07:11','Inicio de sesión','Satisfactorio'),
(42,2650,1,'2018-06-23 12:07:13','Ingreso a TPV','Satisfactorio'),
(43,2651,1,'2018-06-23 12:10:28','Inicio de sesión','Satisfactorio'),
(44,2651,1,'2018-06-23 12:10:30','Ingreso a TPV','Satisfactorio'),
(45,2652,1,'2018-06-23 12:14:27','Inicio de sesión','Satisfactorio'),
(46,2652,1,'2018-06-23 12:14:36','Ingreso a TPV','Satisfactorio'),
(47,2653,1,'2018-06-23 12:16:24','Inicio de sesión','Satisfactorio'),
(48,2653,1,'2018-06-23 12:16:28','Ingreso a TPV','Satisfactorio'),
(49,2654,1,'2018-06-23 12:23:22','Inicio de sesión','Satisfactorio'),
(50,2654,1,'2018-06-23 12:23:24','Ingreso a TPV','Satisfactorio'),
(51,2655,1,'2018-06-23 12:25:28','Inicio de sesión','Satisfactorio'),
(52,2655,1,'2018-06-23 12:25:30','Ingreso a TPV','Satisfactorio'),
(53,2656,1,'2018-06-23 12:29:37','Inicio de sesión','Satisfactorio'),
(54,2656,1,'2018-06-23 12:29:38','Ingreso a TPV','Satisfactorio'),
(55,2657,1,'2018-06-23 12:30:29','Inicio de sesión','Satisfactorio'),
(56,2657,1,'2018-06-23 12:30:30','Ingreso a TPV','Satisfactorio'),
(57,2658,1,'2018-06-23 14:55:48','Inicio de sesión','Satisfactorio'),
(58,2658,1,'2018-06-23 14:55:50','Ingreso a TPV','Satisfactorio'),
(59,2658,1,'2018-06-23 14:56:52','Cierre de sesión','Satisfactorio'),
(60,2659,1,'2018-06-24 11:18:10','Inicio de sesión','Satisfactorio'),
(61,2659,1,'2018-06-24 11:18:12','Ingreso a TPV','Satisfactorio'),
(62,2660,1,'2018-06-24 11:19:10','Inicio de sesión','Satisfactorio'),
(63,2660,1,'2018-06-24 11:19:12','Ingreso a TPV','Satisfactorio'),
(64,2661,1,'2018-06-24 11:27:37','Inicio de sesión','Satisfactorio'),
(65,2661,1,'2018-06-24 11:27:38','Ingreso a TPV','Satisfactorio'),
(66,2662,1,'2018-06-24 11:33:37','Inicio de sesión','Satisfactorio'),
(67,2662,1,'2018-06-24 11:33:38','Ingreso a TPV','Satisfactorio'),
(68,2663,1,'2018-06-24 11:36:40','Inicio de sesión','Satisfactorio'),
(69,2663,1,'2018-06-24 11:36:42','Ingreso a TPV','Satisfactorio'),
(70,2664,1,'2018-06-24 11:48:03','Inicio de sesión','Satisfactorio'),
(71,2664,1,'2018-06-24 11:48:05','Ingreso a TPV','Satisfactorio'),
(72,2665,1,'2018-06-24 11:52:00','Inicio de sesión','Satisfactorio'),
(73,2665,1,'2018-06-24 11:52:01','Ingreso a TPV','Satisfactorio'),
(74,2666,1,'2018-06-24 11:53:36','Inicio de sesión','Satisfactorio'),
(75,2666,1,'2018-06-24 11:53:37','Ingreso a TPV','Satisfactorio'),
(76,2667,1,'2018-06-24 11:56:24','Inicio de sesión','Satisfactorio'),
(77,2667,1,'2018-06-24 11:56:26','Ingreso a TPV','Satisfactorio'),
(78,2668,1,'2018-06-24 11:58:31','Inicio de sesión','Satisfactorio'),
(79,2668,1,'2018-06-24 11:58:32','Ingreso a TPV','Satisfactorio'),
(80,2669,1,'2018-06-24 12:11:27','Inicio de sesión','Satisfactorio'),
(81,2669,1,'2018-06-24 12:11:29','Ingreso a TPV','Satisfactorio'),
(82,2669,1,'2018-06-24 12:13:11','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(83,2669,1,'2018-06-24 12:13:26','Actualización de configuraciones del sistema','Satisfactorio'),
(84,2669,1,'2018-06-24 12:13:31','Ingreso a TPV','Satisfactorio'),
(85,2670,1,'2018-06-24 12:30:45','Inicio de sesión','Satisfactorio'),
(86,2670,1,'2018-06-24 12:30:47','Ingreso a TPV','Satisfactorio'),
(87,2671,1,'2018-06-24 12:31:28','Inicio de sesión','Satisfactorio'),
(88,2671,1,'2018-06-24 12:31:30','Ingreso a TPV','Satisfactorio'),
(89,2672,1,'2018-06-24 12:36:12','Inicio de sesión','Satisfactorio'),
(90,2672,1,'2018-06-24 12:36:14','Ingreso a TPV','Satisfactorio'),
(91,2673,1,'2018-06-24 13:54:43','Inicio de sesión','Satisfactorio'),
(92,2673,1,'2018-06-24 13:54:45','Ingreso a TPV','Satisfactorio'),
(93,2674,1,'2018-06-24 13:55:17','Inicio de sesión','Satisfactorio'),
(94,2674,1,'2018-06-24 13:55:18','Ingreso a TPV','Satisfactorio'),
(95,2675,1,'2018-06-24 13:55:52','Inicio de sesión','Satisfactorio'),
(96,2675,1,'2018-06-24 13:55:54','Ingreso a TPV','Satisfactorio'),
(97,2676,1,'2018-06-24 13:56:27','Inicio de sesión','Satisfactorio'),
(98,2676,1,'2018-06-24 13:56:28','Ingreso a TPV','Satisfactorio'),
(99,2677,1,'2018-06-24 13:57:57','Inicio de sesión','Satisfactorio'),
(100,2677,1,'2018-06-24 13:57:59','Ingreso a TPV','Satisfactorio'),
(101,2678,1,'2018-06-24 13:58:29','Inicio de sesión','Satisfactorio'),
(102,2678,1,'2018-06-24 13:58:31','Ingreso a TPV','Satisfactorio'),
(103,2679,1,'2018-06-24 14:05:16','Inicio de sesión','Satisfactorio'),
(104,2679,1,'2018-06-24 14:05:17','Ingreso a TPV','Satisfactorio'),
(105,2679,1,'2018-06-24 14:07:12','Cierre de sesión','Satisfactorio'),
(106,2680,1,'2018-06-24 14:22:32','Inicio de sesión','Satisfactorio'),
(107,2680,1,'2018-06-24 14:22:33','Ingreso a TPV','Satisfactorio'),
(108,2681,1,'2018-06-24 14:23:42','Inicio de sesión','Satisfactorio'),
(109,2681,1,'2018-06-24 14:23:44','Ingreso a TPV','Satisfactorio'),
(110,2682,1,'2018-06-24 14:24:51','Inicio de sesión','Satisfactorio'),
(111,2682,1,'2018-06-24 14:24:52','Ingreso a TPV','Satisfactorio'),
(112,2683,1,'2018-06-24 14:25:17','Inicio de sesión','Satisfactorio'),
(113,2683,1,'2018-06-24 14:25:19','Ingreso a TPV','Satisfactorio'),
(114,2684,1,'2018-06-24 14:43:08','Inicio de sesión','Satisfactorio'),
(115,2684,1,'2018-06-24 14:43:09','Ingreso a TPV','Satisfactorio'),
(116,2685,1,'2018-06-24 14:45:27','Inicio de sesión','Satisfactorio'),
(117,2685,1,'2018-06-24 14:45:29','Ingreso a TPV','Satisfactorio'),
(118,2686,1,'2018-06-24 14:48:30','Inicio de sesión','Satisfactorio'),
(119,2686,1,'2018-06-24 14:48:32','Ingreso a TPV','Satisfactorio'),
(120,2687,1,'2018-06-26 16:02:54','Inicio de sesión','Satisfactorio'),
(121,2687,1,'2018-06-26 16:02:56','Ingreso a TPV','Satisfactorio'),
(122,2688,1,'2018-06-26 16:03:24','Inicio de sesión','Satisfactorio'),
(123,2688,1,'2018-06-26 16:03:26','Ingreso a TPV','Satisfactorio'),
(124,2689,1,'2018-06-26 16:03:45','Inicio de sesión','Satisfactorio'),
(125,2689,1,'2018-06-26 16:03:46','Ingreso a TPV','Satisfactorio'),
(126,2690,1,'2018-06-26 16:05:24','Inicio de sesión','Satisfactorio'),
(127,2690,1,'2018-06-26 16:05:26','Ingreso a TPV','Satisfactorio'),
(128,2691,1,'2018-06-26 16:13:43','Inicio de sesión','Satisfactorio'),
(129,2691,1,'2018-06-26 16:13:49','Ingreso a TPV','Satisfactorio'),
(130,2692,1,'2018-06-26 16:15:33','Inicio de sesión','Satisfactorio'),
(131,2692,1,'2018-06-26 16:15:34','Ingreso a TPV','Satisfactorio'),
(132,2693,1,'2018-06-26 16:17:40','Inicio de sesión','Satisfactorio'),
(133,2693,1,'2018-06-26 16:17:42','Ingreso a TPV','Satisfactorio'),
(134,2694,1,'2018-06-26 16:27:12','Inicio de sesión','Satisfactorio'),
(135,2694,1,'2018-06-26 16:27:13','Ingreso a TPV','Satisfactorio'),
(136,2695,1,'2018-06-26 16:36:34','Inicio de sesión','Satisfactorio'),
(137,2695,1,'2018-06-26 16:36:36','Ingreso a TPV','Satisfactorio'),
(138,2696,1,'2018-06-26 16:40:24','Inicio de sesión','Satisfactorio'),
(139,2696,1,'2018-06-26 16:40:26','Ingreso a TPV','Satisfactorio'),
(140,2697,1,'2018-06-26 16:44:56','Inicio de sesión','Satisfactorio'),
(141,2697,1,'2018-06-26 16:44:57','Ingreso a TPV','Satisfactorio'),
(142,2698,1,'2018-06-26 16:45:34','Inicio de sesión','Satisfactorio'),
(143,2698,1,'2018-06-26 16:45:36','Ingreso a TPV','Satisfactorio'),
(144,2699,1,'2018-06-26 16:46:08','Inicio de sesión','Satisfactorio'),
(145,2699,1,'2018-06-26 16:46:09','Ingreso a TPV','Satisfactorio'),
(146,2700,1,'2018-06-26 17:06:55','Inicio de sesión','Satisfactorio'),
(147,2700,1,'2018-06-26 17:06:57','Ingreso a TPV','Satisfactorio'),
(148,2701,1,'2018-06-26 17:10:53','Inicio de sesión','Satisfactorio'),
(149,2701,1,'2018-06-26 17:10:54','Ingreso a TPV','Satisfactorio'),
(150,2701,1,'2018-06-26 17:14:52','Cierre de sesión','Satisfactorio'),
(151,2702,1,'2018-06-26 19:03:08','Inicio de sesión','Satisfactorio'),
(152,2702,1,'2018-06-26 19:03:10','Ingreso a TPV','Satisfactorio'),
(153,2703,1,'2018-06-26 19:11:32','Inicio de sesión','Satisfactorio'),
(154,2703,1,'2018-06-26 19:11:34','Ingreso a TPV','Satisfactorio'),
(155,2704,1,'2018-06-26 19:14:59','Inicio de sesión','Satisfactorio'),
(156,2704,1,'2018-06-26 19:15:00','Ingreso a TPV','Satisfactorio'),
(157,2705,1,'2018-06-26 19:17:32','Inicio de sesión','Satisfactorio'),
(158,2705,1,'2018-06-26 19:17:33','Ingreso a TPV','Satisfactorio'),
(159,2706,1,'2018-06-26 19:24:31','Inicio de sesión','Satisfactorio'),
(160,2706,1,'2018-06-26 19:24:33','Ingreso a TPV','Satisfactorio'),
(161,2707,1,'2018-06-26 19:25:35','Inicio de sesión','Satisfactorio'),
(162,2707,1,'2018-06-26 19:25:39','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(163,2707,1,'2018-06-26 19:26:02','Actualización de configuraciones del sistema','Satisfactorio'),
(164,2707,1,'2018-06-26 19:26:10','Ingreso a TPV','Satisfactorio'),
(165,2707,1,'2018-06-26 19:28:46','Agregar nueva venta con ID= 13','Satisfactorio'),
(166,2708,1,'2018-06-26 19:31:26','Inicio de sesión','Satisfactorio'),
(167,2708,1,'2018-06-26 19:31:27','Ingreso a TPV','Satisfactorio'),
(168,2708,1,'2018-06-26 19:41:26','Cierre de sesión','Satisfactorio'),
(169,2709,1,'2018-06-26 19:42:40','Inicio de sesión','Satisfactorio'),
(170,2709,1,'2018-06-26 19:42:42','Ingreso a TPV','Satisfactorio'),
(171,2710,1,'2018-06-27 10:19:31','Inicio de sesión','Satisfactorio'),
(172,2710,1,'2018-06-27 10:19:32','Ingreso a TPV','Satisfactorio'),
(173,2711,1,'2018-06-27 10:27:21','Inicio de sesión','Satisfactorio'),
(174,2711,1,'2018-06-27 10:27:23','Ingreso a TPV','Satisfactorio'),
(175,2712,1,'2018-06-27 10:29:13','Inicio de sesión','Satisfactorio'),
(176,2712,1,'2018-06-27 10:29:15','Ingreso a TPV','Satisfactorio'),
(177,2713,1,'2018-06-27 10:32:23','Inicio de sesión','Satisfactorio'),
(178,2713,1,'2018-06-27 10:32:25','Ingreso a TPV','Satisfactorio'),
(179,2713,1,'2018-06-27 10:33:16','Cierre de sesión','Satisfactorio'),
(180,2714,1,'2018-06-27 10:38:29','Inicio de sesión','Satisfactorio'),
(181,2714,1,'2018-06-27 10:38:31','Ingreso a TPV','Satisfactorio'),
(182,2715,1,'2018-06-27 10:44:49','Inicio de sesión','Satisfactorio'),
(183,2715,1,'2018-06-27 10:44:51','Ingreso a TPV','Satisfactorio'),
(184,2716,1,'2018-06-27 10:45:55','Inicio de sesión','Satisfactorio'),
(185,2716,1,'2018-06-27 10:45:57','Ingreso a TPV','Satisfactorio'),
(186,2716,1,'2018-06-27 10:51:25','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(187,2717,1,'2018-06-27 10:57:58','Inicio de sesión','Satisfactorio'),
(188,2717,1,'2018-06-27 10:58:12','Ingreso a TPV','Satisfactorio'),
(189,2718,1,'2018-06-27 11:22:22','Inicio de sesión','Satisfactorio'),
(190,2718,1,'2018-06-27 11:22:24','Ingreso a TPV','Satisfactorio'),
(191,2719,1,'2018-06-27 11:27:41','Inicio de sesión','Satisfactorio'),
(192,2719,1,'2018-06-27 11:27:42','Ingreso a TPV','Satisfactorio'),
(193,2720,1,'2018-06-27 11:32:13','Inicio de sesión','Satisfactorio'),
(194,2720,1,'2018-06-27 11:32:15','Ingreso a TPV','Satisfactorio'),
(195,2720,1,'2018-06-27 11:32:26','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(196,2721,1,'2018-06-27 11:40:06','Inicio de sesión','Satisfactorio'),
(197,2721,1,'2018-06-27 11:40:07','Ingreso a TPV','Satisfactorio'),
(198,2721,1,'2018-06-27 11:40:31','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(199,2721,1,'2018-06-27 11:40:36','Actualización de configuraciones del sistema','Satisfactorio'),
(200,2721,1,'2018-06-27 11:40:40','Ingreso a TPV','Satisfactorio'),
(201,2721,1,'2018-06-27 11:40:51','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(202,2721,1,'2018-06-27 11:40:56','Actualización de configuraciones del sistema','Satisfactorio'),
(203,2721,1,'2018-06-27 11:41:02','Ingreso a TPV','Satisfactorio'),
(204,2722,1,'2018-06-27 11:42:06','Inicio de sesión','Satisfactorio'),
(205,2722,1,'2018-06-27 11:42:07','Ingreso a TPV','Satisfactorio'),
(206,2723,1,'2018-06-27 11:42:36','Inicio de sesión','Satisfactorio'),
(207,2723,1,'2018-06-27 11:42:38','Ingreso a TPV','Satisfactorio'),
(208,2724,1,'2018-06-27 11:43:47','Inicio de sesión','Satisfactorio'),
(209,2724,1,'2018-06-27 11:43:49','Ingreso a TPV','Satisfactorio'),
(210,2724,1,'2018-06-27 11:44:02','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(211,2724,1,'2018-06-27 11:44:07','Actualización de configuraciones del sistema','Satisfactorio'),
(212,2724,1,'2018-06-27 11:44:10','Ingreso a TPV','Satisfactorio'),
(213,2725,1,'2018-06-27 11:45:02','Inicio de sesión','Satisfactorio'),
(214,2725,1,'2018-06-27 11:45:04','Ingreso a TPV','Satisfactorio'),
(215,2726,1,'2018-06-27 11:46:53','Inicio de sesión','Satisfactorio'),
(216,2726,1,'2018-06-27 11:46:54','Ingreso a TPV','Satisfactorio'),
(217,2727,1,'2018-06-27 11:48:10','Inicio de sesión','Satisfactorio'),
(218,2727,1,'2018-06-27 11:48:12','Ingreso a TPV','Satisfactorio'),
(219,2727,1,'2018-06-27 11:49:29','Ingreso a Datos de la Empresa','Satisfactorio'),
(220,2727,1,'2018-06-27 11:49:44','Actualización de configuraciones del sistema','Satisfactorio'),
(221,2727,1,'2018-06-27 11:49:46','Ingreso a TPV','Satisfactorio'),
(222,2728,1,'2018-06-27 11:54:06','Inicio de sesión','Satisfactorio'),
(223,2728,1,'2018-06-27 11:54:09','Ingreso a TPV','Satisfactorio'),
(224,2728,1,'2018-06-27 11:54:53','Cierre de sesión','Satisfactorio'),
(225,2729,1,'2018-06-27 15:44:15','Inicio de sesión','Satisfactorio'),
(226,2729,1,'2018-06-27 15:44:52','Ingreso a TPV','Satisfactorio'),
(227,2729,1,'2018-06-27 15:45:20','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(228,2729,1,'2018-06-27 15:45:36','Actualización de datos de la empresa','Satisfactorio'),
(229,2729,1,'2018-06-27 15:45:55','Actualización de datos de la empresa','Satisfactorio'),
(230,2729,1,'2018-06-27 15:50:19','Ingreso a TPV','Satisfactorio'),
(231,2729,1,'2018-06-27 15:54:36','Cierre de sesión','Satisfactorio'),
(232,2730,1,'2018-06-27 16:24:58','Inicio de sesión','Satisfactorio'),
(233,2730,1,'2018-06-27 16:27:17','Ingreso a TPV','Satisfactorio'),
(234,2730,1,'2018-06-27 16:30:45','Ingreso a TPV','Satisfactorio'),
(235,2730,1,'2018-06-27 16:36:24','Cierre de sesión','Satisfactorio'),
(236,2731,1,'2018-06-28 07:17:53','Inicio de sesión','Satisfactorio'),
(237,2731,1,'2018-06-28 07:18:24','Cierre de sesión','Satisfactorio'),
(238,2732,1,'2018-06-29 08:48:40','Inicio de sesión','Satisfactorio'),
(239,2732,1,'2018-06-29 08:48:43','Ingreso a TPV','Satisfactorio'),
(240,2733,1,'2018-06-29 09:41:31','Inicio de sesión','Satisfactorio'),
(241,2733,1,'2018-06-29 09:41:32','Ingreso a TPV','Satisfactorio'),
(242,2734,1,'2018-06-29 09:45:30','Inicio de sesión','Satisfactorio'),
(243,2734,1,'2018-06-29 09:45:31','Ingreso a TPV','Satisfactorio'),
(244,2735,1,'2018-06-29 09:47:47','Inicio de sesión','Satisfactorio'),
(245,2735,1,'2018-06-29 09:47:49','Ingreso a TPV','Satisfactorio'),
(246,2736,1,'2018-06-29 09:48:40','Inicio de sesión','Satisfactorio'),
(247,2736,1,'2018-06-29 09:48:41','Ingreso a TPV','Satisfactorio'),
(248,2737,1,'2018-06-29 09:50:14','Inicio de sesión','Satisfactorio'),
(249,2737,1,'2018-06-29 09:50:15','Ingreso a TPV','Satisfactorio'),
(250,2738,1,'2018-06-29 09:51:44','Inicio de sesión','Satisfactorio'),
(251,2738,1,'2018-06-29 09:51:46','Ingreso a TPV','Satisfactorio'),
(252,2739,1,'2018-06-29 09:53:07','Inicio de sesión','Satisfactorio'),
(253,2739,1,'2018-06-29 09:53:08','Ingreso a TPV','Satisfactorio'),
(254,2740,1,'2018-06-29 09:57:30','Inicio de sesión','Satisfactorio'),
(255,2740,1,'2018-06-29 09:57:32','Ingreso a TPV','Satisfactorio'),
(256,2741,1,'2018-06-29 09:58:04','Inicio de sesión','Satisfactorio'),
(257,2741,1,'2018-06-29 09:58:05','Ingreso a TPV','Satisfactorio'),
(258,2742,1,'2018-06-29 10:02:26','Inicio de sesión','Satisfactorio'),
(259,2742,1,'2018-06-29 10:02:29','Ingreso a TPV','Satisfactorio'),
(260,2743,1,'2018-06-29 10:26:35','Inicio de sesión','Satisfactorio'),
(261,2743,1,'2018-06-29 10:26:38','Ingreso a TPV','Satisfactorio'),
(262,2743,1,'2018-06-29 11:05:22','Cierre de sesión','Satisfactorio'),
(263,2744,1,'2018-06-29 11:26:39','Inicio de sesión','Satisfactorio'),
(264,2744,1,'2018-06-29 11:26:40','Ingreso a TPV','Satisfactorio'),
(265,2745,1,'2018-06-29 11:28:08','Inicio de sesión','Satisfactorio'),
(266,2745,1,'2018-06-29 11:28:10','Ingreso a TPV','Satisfactorio'),
(267,2746,1,'2018-06-29 11:30:13','Inicio de sesión','Satisfactorio'),
(268,2746,1,'2018-06-29 11:30:14','Ingreso a TPV','Satisfactorio'),
(269,2747,1,'2018-06-29 11:31:54','Inicio de sesión','Satisfactorio'),
(270,2747,1,'2018-06-29 11:31:56','Ingreso a TPV','Satisfactorio'),
(271,2747,1,'2018-06-29 11:34:17','Cierre de sesión','Satisfactorio'),
(272,2748,1,'2018-06-29 16:36:07','Inicio de sesión','Satisfactorio'),
(273,2748,1,'2018-06-29 16:36:19','Cierre de sesión','Satisfactorio'),
(274,2749,1,'2018-07-06 15:56:27','Inicio de sesión','Satisfactorio'),
(275,2749,1,'2018-07-06 16:02:56','Ingreso a TPV','Satisfactorio'),
(276,2749,1,'2018-07-06 16:05:24','Cierre de sesión','Satisfactorio'),
(277,2750,1,'2018-07-09 10:01:20','Inicio de sesión','Satisfactorio'),
(278,2750,1,'2018-07-09 10:01:22','Ingreso a TPV','Satisfactorio'),
(279,2751,1,'2018-07-09 10:15:01','Inicio de sesión','Satisfactorio'),
(280,2751,1,'2018-07-09 10:15:03','Ingreso a TPV','Satisfactorio'),
(281,2752,1,'2018-07-09 10:27:55','Inicio de sesión','Satisfactorio'),
(282,2752,1,'2018-07-09 10:27:59','Ingreso a productos','Satisfactorio'),
(283,2752,1,'2018-07-09 10:28:42','Ingreso a productos','Satisfactorio'),
(284,2752,1,'2018-07-09 10:28:46','Ingreso a productos','Satisfactorio'),
(285,2752,1,'2018-07-09 10:29:00','Ingreso a productos','Satisfactorio'),
(286,2752,1,'2018-07-09 10:29:03','Ingreso a productos','Satisfactorio'),
(287,2752,1,'2018-07-09 10:29:11','Ingreso a productos','Satisfactorio'),
(288,2752,1,'2018-07-09 10:29:15','Ingreso a productos','Satisfactorio'),
(289,2752,1,'2018-07-09 10:29:20','Ingreso a productos','Satisfactorio'),
(290,2752,1,'2018-07-09 10:29:22','Ingreso a productos','Satisfactorio'),
(291,2752,1,'2018-07-09 10:29:27','Ingreso a productos','Satisfactorio'),
(292,2752,1,'2018-07-09 10:29:36','Ingreso a productos','Satisfactorio'),
(293,2752,1,'2018-07-09 10:29:39','Ingreso a productos','Satisfactorio'),
(294,2752,1,'2018-07-09 10:29:50','Ingreso a productos','Satisfactorio'),
(295,2753,1,'2018-07-09 10:31:50','Inicio de sesión','Satisfactorio'),
(296,2753,1,'2018-07-09 10:31:52','Ingreso a TPV','Satisfactorio'),
(297,2754,1,'2018-07-09 10:36:29','Inicio de sesión','Satisfactorio'),
(298,2754,1,'2018-07-09 10:36:31','Ingreso a TPV','Satisfactorio'),
(299,2755,1,'2018-07-09 10:40:45','Inicio de sesión','Satisfactorio'),
(300,2755,1,'2018-07-09 10:40:47','Ingreso a TPV','Satisfactorio'),
(301,2755,1,'2018-07-09 10:42:00','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(302,2755,1,'2018-07-09 10:42:04','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(303,2756,1,'2018-07-09 10:52:50','Inicio de sesión','Satisfactorio'),
(304,2756,1,'2018-07-09 10:52:51','Ingreso a TPV','Satisfactorio'),
(305,2757,1,'2018-07-09 10:53:43','Inicio de sesión','Satisfactorio'),
(306,2757,1,'2018-07-09 10:53:44','Ingreso a TPV','Satisfactorio'),
(307,2758,1,'2018-07-09 11:00:11','Inicio de sesión','Satisfactorio'),
(308,2758,1,'2018-07-09 11:00:12','Ingreso a TPV','Satisfactorio'),
(309,2759,1,'2018-07-09 11:09:03','Inicio de sesión','Satisfactorio'),
(310,2759,1,'2018-07-09 11:09:08','Ingreso a TPV','Satisfactorio'),
(311,2760,1,'2018-07-09 11:12:44','Inicio de sesión','Satisfactorio'),
(312,2760,1,'2018-07-09 11:12:46','Ingreso a TPV','Satisfactorio'),
(313,2761,1,'2018-07-09 11:13:48','Inicio de sesión','Satisfactorio'),
(314,2761,1,'2018-07-09 11:13:50','Ingreso a TPV','Satisfactorio'),
(315,2762,1,'2018-07-09 11:15:55','Inicio de sesión','Satisfactorio'),
(316,2762,1,'2018-07-09 11:15:56','Ingreso a TPV','Satisfactorio'),
(317,2763,1,'2018-07-09 11:23:11','Inicio de sesión','Satisfactorio'),
(318,2763,1,'2018-07-09 11:23:13','Ingreso a TPV','Satisfactorio'),
(319,2764,1,'2018-07-09 11:27:35','Inicio de sesión','Satisfactorio'),
(320,2764,1,'2018-07-09 11:27:36','Ingreso a TPV','Satisfactorio'),
(321,2765,1,'2018-07-09 11:28:29','Inicio de sesión','Satisfactorio'),
(322,2765,1,'2018-07-09 11:28:30','Ingreso a TPV','Satisfactorio'),
(323,2766,1,'2018-07-09 11:37:56','Inicio de sesión','Satisfactorio'),
(324,2766,1,'2018-07-09 11:37:59','Ingreso a TPV','Satisfactorio'),
(325,2767,1,'2018-07-09 11:41:50','Inicio de sesión','Satisfactorio'),
(326,2767,1,'2018-07-09 11:41:51','Ingreso a TPV','Satisfactorio'),
(327,2768,1,'2018-07-09 11:45:49','Inicio de sesión','Satisfactorio'),
(328,2768,1,'2018-07-09 11:45:51','Ingreso a TPV','Satisfactorio'),
(329,2769,1,'2018-07-09 11:48:22','Inicio de sesión','Satisfactorio'),
(330,2769,1,'2018-07-09 11:48:24','Ingreso a TPV','Satisfactorio'),
(331,2769,1,'2018-07-09 11:54:48','Cierre de sesión','Satisfactorio'),
(332,2770,1,'2018-07-10 22:12:36','Inicio de sesión','Satisfactorio'),
(333,2770,1,'2018-07-10 22:12:38','Ingreso a TPV','Satisfactorio'),
(334,2771,1,'2018-07-10 22:14:01','Inicio de sesión','Satisfactorio'),
(335,2771,1,'2018-07-10 22:14:02','Ingreso a TPV','Satisfactorio'),
(336,2772,1,'2018-07-10 22:15:12','Inicio de sesión','Satisfactorio'),
(337,2773,1,'2018-07-10 22:19:34','Inicio de sesión','Satisfactorio'),
(338,2773,1,'2018-07-10 22:19:41','Ingreso a TPV','Satisfactorio'),
(339,2774,1,'2018-07-10 22:20:48','Inicio de sesión','Satisfactorio'),
(340,2774,1,'2018-07-10 22:20:49','Ingreso a TPV','Satisfactorio'),
(341,2775,1,'2018-07-11 20:10:57','Inicio de sesión','Satisfactorio'),
(342,2775,1,'2018-07-11 20:10:59','Ingreso a TPV','Satisfactorio'),
(343,2775,1,'2018-07-11 20:11:59','Cierre de sesión','Satisfactorio'),
(344,2776,1,'2018-07-11 20:12:35','Inicio de sesión','Satisfactorio'),
(345,2776,1,'2018-07-11 20:12:40','Ingreso a TPV','Satisfactorio'),
(346,2776,1,'2018-07-11 20:13:20','Cierre de sesión','Satisfactorio'),
(347,2777,1,'2018-07-11 20:20:07','Inicio de sesión','Satisfactorio'),
(348,2777,1,'2018-07-11 20:20:25','Ingreso a productos','Satisfactorio'),
(349,2777,1,'2018-07-11 20:20:28','Ingreso a productos','Satisfactorio'),
(350,2777,1,'2018-07-11 20:20:31','Ingreso a productos','Satisfactorio'),
(351,2777,1,'2018-07-11 20:20:34','Ingreso a productos','Satisfactorio'),
(352,2777,1,'2018-07-11 20:20:40','Ingreso a productos','Satisfactorio'),
(353,2777,1,'2018-07-11 20:20:54','Ingreso a productos','Satisfactorio'),
(354,2777,1,'2018-07-11 20:20:57','Ingreso a productos','Satisfactorio'),
(355,2777,1,'2018-07-11 20:21:00','Ingreso a productos','Satisfactorio'),
(356,2777,1,'2018-07-11 20:21:06','Ingreso a productos','Satisfactorio'),
(357,2777,1,'2018-07-11 20:21:10','Ingreso a productos','Satisfactorio'),
(358,2777,1,'2018-07-11 20:21:17','Ingreso a productos','Satisfactorio'),
(359,2777,1,'2018-07-11 20:21:20','Ingreso a productos','Satisfactorio'),
(360,2778,1,'2018-07-11 20:22:32','Inicio de sesión','Satisfactorio'),
(361,2778,1,'2018-07-11 20:22:35','Ingreso a productos','Satisfactorio'),
(362,2779,1,'2018-07-11 20:23:58','Inicio de sesión','Satisfactorio'),
(363,2779,1,'2018-07-11 20:24:01','Ingreso a productos','Satisfactorio'),
(364,2779,1,'2018-07-11 20:24:08','Ingreso a productos','Satisfactorio'),
(365,2780,1,'2018-07-11 20:26:32','Inicio de sesión','Satisfactorio'),
(366,2780,1,'2018-07-11 20:26:35','Ingreso a productos','Satisfactorio'),
(367,2780,1,'2018-07-11 20:26:46','Ingreso a productos','Satisfactorio'),
(368,2781,1,'2018-07-11 20:28:54','Inicio de sesión','Satisfactorio'),
(369,2781,1,'2018-07-11 20:28:58','Ingreso a productos','Satisfactorio'),
(370,2781,1,'2018-07-11 20:29:00','Ingreso a productos','Satisfactorio'),
(371,2781,1,'2018-07-11 20:29:03','Ingreso a productos','Satisfactorio'),
(372,2781,1,'2018-07-11 20:29:06','Ingreso a productos','Satisfactorio'),
(373,2781,1,'2018-07-11 20:29:09','Ingreso a productos','Satisfactorio'),
(374,2781,1,'2018-07-11 20:29:12','Ingreso a productos','Satisfactorio'),
(375,2781,1,'2018-07-11 20:29:15','Ingreso a productos','Satisfactorio'),
(376,2781,1,'2018-07-11 20:29:25','Cierre de sesión','Satisfactorio'),
(377,2782,1,'2018-07-11 20:39:04','Inicio de sesión','Satisfactorio'),
(378,2782,1,'2018-07-11 20:39:08','Ingreso a productos','Satisfactorio'),
(379,2782,1,'2018-07-11 20:39:12','Ingreso a productos','Satisfactorio'),
(380,2782,1,'2018-07-11 20:39:15','Ingreso a productos','Satisfactorio'),
(381,2782,1,'2018-07-11 20:39:28','Ingreso a TPV','Satisfactorio'),
(382,2782,1,'2018-07-11 20:41:05','Cierre de sesión','Satisfactorio'),
(383,2783,1,'2018-07-13 14:49:57','Inicio de sesión','Satisfactorio'),
(384,2783,1,'2018-07-13 14:50:07','Ingreso a TPV','Satisfactorio'),
(385,2783,1,'2018-07-13 14:51:08','Cierre de sesión','Satisfactorio'),
(386,2784,1,'2018-07-13 15:07:20','Inicio de sesión','Satisfactorio'),
(387,2784,1,'2018-07-13 15:07:22','Ingreso a TPV','Satisfactorio'),
(388,2784,1,'2018-07-13 16:05:15','Cierre de sesión','Satisfactorio'),
(389,2785,1,'2018-07-13 17:05:56','Inicio de sesión','Satisfactorio'),
(390,2785,1,'2018-07-13 17:05:57','Ingreso a TPV','Satisfactorio'),
(391,2785,1,'2018-07-13 17:06:07','Ingreso a productos','Satisfactorio'),
(392,2785,1,'2018-07-13 17:06:12','Ingreso a productos','Satisfactorio'),
(393,2786,1,'2018-07-13 17:08:52','Inicio de sesión','Satisfactorio'),
(394,2786,1,'2018-07-13 17:08:55','Ingreso a productos','Satisfactorio'),
(395,2786,1,'2018-07-13 17:08:58','Ingreso a productos','Satisfactorio'),
(396,2786,1,'2018-07-13 17:09:01','Ingreso a productos','Satisfactorio'),
(397,2787,1,'2018-07-19 18:58:13','Inicio de sesión','Satisfactorio'),
(398,2787,1,'2018-07-19 18:58:25','Ingreso a TPV','Satisfactorio'),
(399,2787,1,'2018-07-19 18:59:05','Todo el proceso de pago del pedido con ID: 14 ha finalizado','Satisfactorio'),
(400,2788,1,'2018-07-19 19:00:12','Inicio de sesión','Satisfactorio'),
(401,2788,1,'2018-07-19 19:00:13','Ingreso a TPV','Satisfactorio'),
(402,2788,1,'2018-07-19 19:00:51','Todo el proceso de pago del pedido con ID: 1 ha finalizado','Satisfactorio'),
(403,2788,1,'2018-07-19 19:01:29','Ingreso a la administración de cuentas','Satisfactorio'),
(404,2788,1,'2018-07-19 19:02:02','Apertura de cuenta para gestión de fondos','Satisfactorio'),
(405,2788,1,'2018-07-19 19:02:08','Ingreso a TPV','Satisfactorio'),
(406,2788,1,'2018-07-19 19:03:12','Todo el proceso de pago del pedido con ID: 13 ha finalizado','Satisfactorio'),
(407,2788,1,'2018-07-19 19:03:24','Ingreso a la administración de cuentas','Satisfactorio'),
(408,2788,1,'2018-07-19 19:03:45','Ingreso a TPV','Satisfactorio'),
(409,2788,1,'2018-07-19 19:05:01','Cierre de sesión','Satisfactorio'),
(410,2789,1,'2018-07-19 19:17:28','Inicio de sesión','Satisfactorio'),
(411,2789,1,'2018-07-19 19:17:31','Ingreso a TPV','Satisfactorio'),
(412,2789,1,'2018-07-19 19:17:48','Ingreso a la administración de cuentas','Satisfactorio'),
(413,2789,1,'2018-07-19 19:18:26','Ingreso a TPV','Satisfactorio'),
(414,2789,1,'2018-07-19 19:18:37','Todo el proceso de pago del pedido con ID: 2 ha finalizado','Satisfactorio'),
(415,2789,1,'2018-07-19 19:20:31','Ingreso a la administración de cuentas','Satisfactorio'),
(416,2790,1,'2018-07-19 19:49:14','Inicio de sesión','Satisfactorio'),
(417,2790,1,'2018-07-19 19:49:15','Ingreso a TPV','Satisfactorio'),
(418,2790,1,'2018-07-19 19:50:26','Ingreso a la administración de cuentas','Satisfactorio'),
(419,2790,1,'2018-07-19 19:50:57','Ingreso a TPV','Satisfactorio'),
(420,2790,1,'2018-07-19 19:51:09','Todo el proceso de pago del pedido con ID: 3 ha finalizado','Satisfactorio'),
(421,2790,1,'2018-07-19 19:51:35','Ingreso a la administración de cuentas','Satisfactorio'),
(422,2790,1,'2018-07-19 19:52:13','Ingreso a la administración de cuentas','Satisfactorio'),
(423,2790,1,'2018-07-19 19:52:28','Ingreso a TPV','Satisfactorio'),
(424,2790,1,'2018-07-19 19:53:05','Todo el proceso de pago del pedido con ID: 6 ha finalizado','Satisfactorio'),
(425,2790,1,'2018-07-19 19:53:58','Ingreso a la administración de cuentas','Satisfactorio'),
(426,2790,1,'2018-07-19 19:54:18','Ingreso a la administración de cuentas','Satisfactorio'),
(427,2790,1,'2018-07-19 19:54:42','Ingreso a TPV','Satisfactorio'),
(428,2790,1,'2018-07-19 19:55:46','Todo el proceso de pago del pedido con ID: 4 ha finalizado','Satisfactorio'),
(429,2790,1,'2018-07-19 19:56:23','Ingreso a la administración de cuentas','Satisfactorio'),
(430,2790,1,'2018-07-19 19:57:40','Actualización de tajeta de crédito','Satisfactorio'),
(431,2790,1,'2018-07-19 19:57:49','Actualización de tajeta de crédito','Satisfactorio'),
(432,2790,1,'2018-07-19 19:57:53','Ingreso a la administración de cuentas','Satisfactorio'),
(433,2790,1,'2018-07-19 19:57:56','Ingreso a la administración de cuentas','Satisfactorio'),
(434,2790,1,'2018-07-19 19:58:05','Ingreso a TPV','Satisfactorio'),
(435,2790,1,'2018-07-19 19:58:31','Todo el proceso de pago del pedido con ID: 7 ha finalizado','Satisfactorio'),
(436,2790,1,'2018-07-19 19:58:56','Todo el proceso de pago del pedido con ID: 5 ha finalizado','Satisfactorio'),
(437,2790,1,'2018-07-19 20:00:36','Todo el proceso de pago del pedido con ID: 8 ha finalizado','Satisfactorio'),
(438,2790,1,'2018-07-19 20:03:39','Ingreso a la administración de cuentas','Satisfactorio'),
(439,2790,1,'2018-07-19 20:03:50','Ingreso a Reportes','Satisfactorio'),
(440,2790,1,'2018-07-19 20:05:31','Cierre de sesión','Satisfactorio'),
(441,2791,1,'2018-07-19 20:06:04','Inicio de sesión','Satisfactorio'),
(442,2792,1,'2018-07-19 22:05:33','Inicio de sesión','Satisfactorio'),
(443,2792,1,'2018-07-19 22:05:40','Cierre de sesión','Satisfactorio'),
(444,2793,1,'2018-07-19 22:08:24','Inicio de sesión','Satisfactorio'),
(445,2793,1,'2018-07-19 22:08:26','Ingreso a TPV','Satisfactorio'),
(446,2793,1,'2018-07-19 22:09:00','Ingreso a TPV','Satisfactorio'),
(447,2793,1,'2018-07-19 22:10:35','Actualizó el tiraje de factura','Satisfactorio'),
(448,2793,1,'2018-07-19 22:10:54','Ingreso a TPV','Satisfactorio'),
(449,2793,1,'2018-07-19 22:11:17','Todo el proceso de pago del pedido con ID: 9 ha finalizado','Satisfactorio'),
(450,2794,1,'2018-07-19 22:11:49','Inicio de sesión','Satisfactorio'),
(451,2794,1,'2018-07-19 22:11:53','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(452,2794,1,'2018-07-19 22:12:07','Actualización de configuraciones del sistema','Satisfactorio'),
(453,2794,1,'2018-07-19 22:12:16','Ingreso a TPV','Satisfactorio'),
(454,2794,1,'2018-07-19 22:12:26','Agregar nueva venta con ID= 15','Satisfactorio'),
(455,2794,1,'2018-07-19 22:12:41','Todo el proceso de pago del pedido con ID: 15 ha finalizado','Satisfactorio'),
(456,2794,1,'2018-07-19 22:12:47','Extender factura de pedido','Satisfactorio'),
(457,2794,1,'2018-07-19 22:12:47','Intento de asignar número de factura al pedido','Se produjo un error'),
(458,2794,1,'2018-07-19 22:15:05','Cierre de sesión','Satisfactorio'),
(459,2795,1,'2018-07-20 10:54:33','Inicio de sesión','Satisfactorio'),
(460,2795,1,'2018-07-20 12:34:29','Ingreso a TPV','Satisfactorio'),
(461,2795,1,'2018-07-20 12:34:35','Agregar nueva venta con ID= 16','Satisfactorio'),
(462,2796,1,'2018-07-20 12:39:46','Inicio de sesión','Satisfactorio'),
(463,2796,1,'2018-07-20 12:39:47','Ingreso a TPV','Satisfactorio'),
(464,2796,1,'2018-07-20 12:39:55','Agregar nueva venta con ID= 17','Satisfactorio'),
(465,2797,1,'2018-07-20 12:42:50','Inicio de sesión','Satisfactorio'),
(466,2797,1,'2018-07-20 12:42:52','Ingreso a TPV','Satisfactorio'),
(467,2797,1,'2018-07-20 12:43:04','Agregar nueva venta con ID= 18','Satisfactorio'),
(468,2797,1,'2018-07-20 12:43:45','Todo el proceso de pago del pedido con ID: 18 ha finalizado','Satisfactorio'),
(469,2798,1,'2018-07-20 12:49:11','Inicio de sesión','Satisfactorio'),
(470,2798,1,'2018-07-20 12:49:13','Ingreso a TPV','Satisfactorio'),
(471,2798,1,'2018-07-20 12:49:20','Agregar nueva venta con ID= 19','Satisfactorio'),
(472,2798,1,'2018-07-20 12:49:43','Todo el proceso de pago del pedido con ID: 19 ha finalizado','Satisfactorio'),
(473,2798,1,'2018-07-20 12:51:39','Agregar nueva venta con ID= 20','Satisfactorio'),
(474,2798,1,'2018-07-20 12:52:02','Todo el proceso de pago del pedido con ID: 20 ha finalizado','Satisfactorio'),
(475,2798,1,'2018-07-20 12:55:22','Cierre de sesión','Satisfactorio'),
(476,2799,1,'2018-07-20 16:24:26','Inicio de sesión','Satisfactorio'),
(477,2799,1,'2018-07-20 16:24:30','Ingreso a productos','Satisfactorio'),
(478,2799,1,'2018-07-20 16:24:36','Ingreso a TPV','Satisfactorio'),
(479,2799,1,'2018-07-20 16:24:54','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(480,2799,1,'2018-07-20 16:25:09','Actualización de configuraciones del sistema','Satisfactorio'),
(481,2799,1,'2018-07-20 16:25:12','Ingreso a TPV','Satisfactorio'),
(482,2799,1,'2018-07-20 16:26:01','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(483,2799,1,'2018-07-20 16:26:08','Actualización de configuraciones del sistema','Satisfactorio'),
(484,2799,1,'2018-07-20 16:26:11','Ingreso a TPV','Satisfactorio'),
(485,2799,1,'2018-07-20 16:26:27','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(486,2799,1,'2018-07-20 16:26:39','Actualización de configuraciones del sistema','Satisfactorio'),
(487,2799,1,'2018-07-20 16:26:42','Actualización de configuraciones del sistema','Satisfactorio'),
(488,2799,1,'2018-07-20 16:26:45','Ingreso a TPV','Satisfactorio'),
(489,2799,1,'2018-07-20 16:34:27','Cierre de sesión','Satisfactorio'),
(490,2800,1,'2018-07-20 16:36:20','Inicio de sesión','Satisfactorio'),
(491,2800,1,'2018-07-20 16:36:21','Ingreso a TPV','Satisfactorio'),
(492,2800,1,'2018-07-20 16:36:59','Cierre de sesión','Satisfactorio'),
(493,2801,1,'2018-07-20 16:52:24','Inicio de sesión','Satisfactorio'),
(494,2801,1,'2018-07-20 16:52:32','Ingreso a TPV','Satisfactorio'),
(495,2801,1,'2018-07-20 16:52:38','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(496,2801,1,'2018-07-20 16:52:56','Ingreso a TPV','Satisfactorio'),
(497,2801,1,'2018-07-20 16:53:04','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(498,2801,1,'2018-07-20 16:53:54','Actualización de configuraciones del sistema','Satisfactorio'),
(499,2801,1,'2018-07-20 16:53:58','Ingreso a TPV','Satisfactorio'),
(500,2801,1,'2018-07-20 16:54:03','Agregar nueva venta con ID= 21','Satisfactorio'),
(501,2801,1,'2018-07-20 16:54:28','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(502,2801,1,'2018-07-20 16:54:40','Actualización de configuraciones del sistema','Satisfactorio'),
(503,2801,1,'2018-07-20 16:54:42','Ingreso a TPV','Satisfactorio'),
(504,2801,1,'2018-07-20 16:55:58','Todo el proceso de pago del pedido con ID: 21 ha finalizado','Satisfactorio'),
(505,2801,1,'2018-07-20 16:56:07','Agregar nueva venta con ID= 22','Satisfactorio'),
(506,2801,1,'2018-07-20 16:56:26','Todo el proceso de pago del pedido con ID: 22 ha finalizado','Satisfactorio'),
(507,2801,1,'2018-07-20 16:56:40','Extender factura de pedido','Satisfactorio'),
(508,2801,1,'2018-07-20 16:56:40','Intento de asignar número de factura al pedido','Se produjo un error'),
(509,2801,1,'2018-07-20 16:58:15','Cierre de sesión','Satisfactorio'),
(510,2802,1,'2018-07-20 17:24:34','Inicio de sesión','Satisfactorio'),
(511,2802,1,'2018-07-20 17:25:57','Ingreso a TPV','Satisfactorio'),
(512,2802,1,'2018-07-20 17:27:11','Cierre de sesión','Satisfactorio'),
(513,2803,1,'2018-07-25 20:53:59','Inicio de sesión','Satisfactorio'),
(514,2803,1,'2018-07-25 20:54:01','Ingreso a TPV','Satisfactorio'),
(515,2803,1,'2018-07-25 20:54:14','Agregar nueva venta con ID= 23','Satisfactorio'),
(516,2803,1,'2018-07-25 20:54:37','Cierre de sesión','Satisfactorio'),
(517,2804,1,'2018-07-25 20:54:44','Inicio de sesión','Satisfactorio'),
(518,2804,1,'2018-07-25 20:54:46','Ingreso a TPV','Satisfactorio'),
(519,2804,1,'2018-07-25 20:55:13','Cierre de sesión','Satisfactorio'),
(520,2805,1,'2018-07-31 13:37:50','Inicio de sesión','Satisfactorio'),
(521,2805,1,'2018-07-31 13:37:55','Ingreso a productos','Satisfactorio'),
(522,2805,1,'2018-07-31 13:44:26','Ingreso a productos','Satisfactorio'),
(523,2805,1,'2018-07-31 13:47:55','Cierre de sesión','Satisfactorio'),
(524,2806,1,'2018-07-31 13:51:40','Inicio de sesión','Satisfactorio'),
(525,2806,1,'2018-07-31 13:51:45','Ingreso a productos','Satisfactorio'),
(526,2806,1,'2018-07-31 13:52:26','Cierre de sesión','Satisfactorio'),
(527,2807,1,'2018-07-31 13:52:39','Inicio de sesión','Satisfactorio'),
(528,2807,1,'2018-07-31 13:52:44','Ingreso a productos','Satisfactorio'),
(529,2807,1,'2018-07-31 13:55:42','Ingreso a TPV','Satisfactorio'),
(530,2807,1,'2018-07-31 13:56:00','Agregar nueva venta con ID= 24','Satisfactorio'),
(531,2807,1,'2018-07-31 13:56:26','Cierre de sesión','Satisfactorio'),
(532,2808,1,'2018-07-31 13:59:15','Inicio de sesión','Satisfactorio'),
(533,2808,1,'2018-07-31 13:59:29','Ingreso a productos','Satisfactorio'),
(534,2808,1,'2018-07-31 13:59:50','Cierre de sesión','Satisfactorio'),
(535,2809,1,'2018-07-31 14:00:03','Inicio de sesión','Satisfactorio'),
(536,2809,1,'2018-07-31 14:00:06','Ingreso a productos','Satisfactorio'),
(537,2809,1,'2018-07-31 14:00:23','Cierre de sesión','Satisfactorio'),
(538,2810,1,'2018-07-31 14:00:35','Inicio de sesión','Satisfactorio'),
(539,2810,1,'2018-07-31 14:00:38','Ingreso a productos','Satisfactorio'),
(540,2810,1,'2018-07-31 14:00:55','Ingreso a productos','Satisfactorio'),
(541,2810,1,'2018-07-31 14:01:48','Ingreso a productos','Satisfactorio'),
(542,2810,1,'2018-07-31 14:02:04','Cierre de sesión','Satisfactorio'),
(543,2811,1,'2018-07-31 14:02:19','Inicio de sesión','Satisfactorio'),
(544,2811,1,'2018-07-31 14:02:22','Ingreso a productos','Satisfactorio'),
(545,2811,1,'2018-07-31 14:02:55','Ingreso a productos','Satisfactorio'),
(546,2811,1,'2018-07-31 14:03:04','Cierre de sesión','Satisfactorio'),
(547,2812,1,'2018-07-31 14:03:20','Inicio de sesión','Satisfactorio'),
(548,2812,1,'2018-07-31 14:03:23','Ingreso a productos','Satisfactorio'),
(549,2812,1,'2018-07-31 14:05:29','Ingreso a TPV','Satisfactorio'),
(550,2812,1,'2018-07-31 14:05:42','Agregar nueva venta con ID= 24','Satisfactorio'),
(551,2812,1,'2018-07-31 14:06:25','Agregar nueva venta con ID= 25','Satisfactorio'),
(552,2812,1,'2018-07-31 14:06:55','Todo el proceso de pago del pedido con ID: 24 ha finalizado','Satisfactorio'),
(553,2812,1,'2018-07-31 14:07:20','Todo el proceso de pago del pedido con ID: 25 ha finalizado','Satisfactorio'),
(554,2812,1,'2018-07-31 14:07:47','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(555,2812,1,'2018-07-31 14:30:50','Cierre de sesión','Satisfactorio'),
(556,2813,1,'2018-08-09 10:35:12','Inicio de sesión','Satisfactorio'),
(557,2813,1,'2018-08-09 10:35:29','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(558,2813,1,'2018-08-09 11:19:04','Actualización de configuraciones del sistema','Satisfactorio'),
(559,2813,1,'2018-08-09 11:19:07','Ingreso a TPV','Satisfactorio'),
(560,2813,1,'2018-08-09 11:19:14','Agregar nueva venta con ID= 26','Satisfactorio'),
(561,2813,1,'2018-08-09 11:19:28','Todo el proceso de pago del pedido con ID: 26 ha finalizado','Satisfactorio'),
(562,2813,1,'2018-08-09 11:26:37','Cierre de sesión','Satisfactorio'),
(563,2814,1,'2018-08-09 11:42:22','Inicio de sesión','Satisfactorio'),
(564,2814,1,'2018-08-09 11:42:24','Ingreso a TPV','Satisfactorio'),
(565,2814,1,'2018-08-09 11:43:30','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(566,2814,1,'2018-08-09 11:44:18','Ingreso a TPV','Satisfactorio'),
(567,2814,1,'2018-08-09 11:44:23','Agregar nueva venta con ID= 27','Satisfactorio'),
(568,2815,1,'2018-08-09 11:46:20','Inicio de sesión','Satisfactorio'),
(569,2815,1,'2018-08-09 11:46:23','Ingreso a TPV','Satisfactorio'),
(570,2815,1,'2018-08-09 11:47:10','Agregar nueva venta con ID= 28','Satisfactorio'),
(571,2816,1,'2018-08-09 11:53:00','Inicio de sesión','Satisfactorio'),
(572,2816,1,'2018-08-09 11:53:08','Ingreso a TPV','Satisfactorio'),
(573,2817,1,'2018-08-13 10:49:20','Inicio de sesión','Satisfactorio'),
(574,2817,1,'2018-08-13 10:49:23','Ingreso a TPV','Satisfactorio'),
(575,2818,1,'2018-08-13 10:57:28','Inicio de sesión','Satisfactorio'),
(576,2818,1,'2018-08-13 10:57:30','Ingreso a TPV','Satisfactorio'),
(577,2819,1,'2018-08-13 11:01:49','Inicio de sesión','Satisfactorio'),
(578,2819,1,'2018-08-13 11:01:53','Ingreso a TPV','Satisfactorio'),
(579,2820,1,'2018-08-13 11:04:10','Inicio de sesión','Satisfactorio'),
(580,2820,1,'2018-08-13 11:04:14','Ingreso a TPV','Satisfactorio'),
(581,2821,1,'2018-08-13 11:05:33','Inicio de sesión','Satisfactorio'),
(582,2821,1,'2018-08-13 11:05:35','Ingreso a TPV','Satisfactorio'),
(583,2822,1,'2018-08-13 11:10:00','Inicio de sesión','Satisfactorio'),
(584,2822,1,'2018-08-13 11:10:02','Ingreso a TPV','Satisfactorio'),
(585,2823,1,'2018-08-13 11:16:34','Inicio de sesión','Satisfactorio'),
(586,2823,1,'2018-08-13 11:17:24','Ingreso a TPV','Satisfactorio'),
(587,2824,1,'2018-08-13 11:18:44','Inicio de sesión','Satisfactorio'),
(588,2824,1,'2018-08-13 11:18:46','Ingreso a TPV','Satisfactorio'),
(589,2825,1,'2018-08-13 11:20:23','Inicio de sesión','Satisfactorio'),
(590,2825,1,'2018-08-13 11:20:25','Ingreso a TPV','Satisfactorio'),
(591,2826,1,'2018-08-13 11:21:38','Inicio de sesión','Satisfactorio'),
(592,2826,1,'2018-08-13 11:21:42','Ingreso a TPV','Satisfactorio'),
(593,2827,1,'2018-08-13 11:30:36','Inicio de sesión','Satisfactorio'),
(594,2827,1,'2018-08-13 11:30:38','Ingreso a TPV','Satisfactorio'),
(595,2828,1,'2018-08-13 11:34:44','Inicio de sesión','Satisfactorio'),
(596,2828,1,'2018-08-13 11:34:47','Ingreso a TPV','Satisfactorio'),
(597,2829,1,'2018-08-13 11:40:33','Inicio de sesión','Satisfactorio'),
(598,2829,1,'2018-08-13 11:40:37','Ingreso a TPV','Satisfactorio'),
(599,2830,1,'2018-08-13 11:46:57','Inicio de sesión','Satisfactorio'),
(600,2830,1,'2018-08-13 11:46:59','Ingreso a TPV','Satisfactorio'),
(601,2831,1,'2018-08-13 11:49:04','Inicio de sesión','Satisfactorio'),
(602,2831,1,'2018-08-13 11:49:06','Ingreso a TPV','Satisfactorio'),
(603,2832,1,'2018-08-13 11:50:26','Inicio de sesión','Satisfactorio'),
(604,2832,1,'2018-08-13 11:50:29','Ingreso a TPV','Satisfactorio'),
(605,2833,1,'2018-08-13 11:51:24','Inicio de sesión','Satisfactorio'),
(606,2833,1,'2018-08-13 11:51:26','Ingreso a TPV','Satisfactorio'),
(607,2834,1,'2018-08-13 11:54:23','Inicio de sesión','Satisfactorio'),
(608,2834,1,'2018-08-13 11:54:27','Ingreso a TPV','Satisfactorio'),
(609,2835,1,'2018-08-13 11:55:18','Inicio de sesión','Satisfactorio'),
(610,2835,1,'2018-08-13 11:55:22','Ingreso a TPV','Satisfactorio'),
(611,2836,1,'2018-08-13 11:56:09','Inicio de sesión','Satisfactorio'),
(612,2836,1,'2018-08-13 11:56:12','Ingreso a TPV','Satisfactorio'),
(613,2837,1,'2018-08-13 12:00:06','Inicio de sesión','Satisfactorio'),
(614,2837,1,'2018-08-13 12:00:09','Ingreso a TPV','Satisfactorio'),
(615,2838,1,'2018-08-13 15:04:09','Inicio de sesión','Satisfactorio'),
(616,2838,1,'2018-08-13 15:04:13','Ingreso a TPV','Satisfactorio'),
(617,2839,1,'2018-08-13 15:05:24','Inicio de sesión','Satisfactorio'),
(618,2839,1,'2018-08-13 15:05:26','Ingreso a TPV','Satisfactorio'),
(619,2840,1,'2018-08-13 15:19:29','Inicio de sesión','Satisfactorio'),
(620,2840,1,'2018-08-13 15:19:32','Ingreso a TPV','Satisfactorio'),
(621,2841,1,'2018-08-13 15:29:28','Inicio de sesión','Satisfactorio'),
(622,2841,1,'2018-08-13 15:29:31','Ingreso a TPV','Satisfactorio'),
(623,2842,1,'2018-08-13 15:34:06','Inicio de sesión','Satisfactorio'),
(624,2842,1,'2018-08-13 15:34:08','Ingreso a TPV','Satisfactorio'),
(625,2843,1,'2018-08-13 16:19:48','Inicio de sesión','Satisfactorio'),
(626,2843,1,'2018-08-13 16:19:51','Ingreso a TPV','Satisfactorio'),
(627,2844,1,'2018-08-13 16:21:01','Inicio de sesión','Satisfactorio'),
(628,2844,1,'2018-08-13 16:21:05','Ingreso a TPV','Satisfactorio'),
(629,2845,1,'2018-08-13 16:25:24','Inicio de sesión','Satisfactorio'),
(630,2845,1,'2018-08-13 16:25:26','Ingreso a TPV','Satisfactorio'),
(631,2846,1,'2018-08-13 16:26:52','Inicio de sesión','Satisfactorio'),
(632,2846,1,'2018-08-13 16:26:55','Ingreso a TPV','Satisfactorio'),
(633,2847,1,'2018-08-13 16:28:26','Inicio de sesión','Satisfactorio'),
(634,2847,1,'2018-08-13 16:28:44','Ingreso a TPV','Satisfactorio'),
(635,2848,1,'2018-08-13 16:34:20','Inicio de sesión','Satisfactorio'),
(636,2848,1,'2018-08-13 16:34:23','Ingreso a TPV','Satisfactorio'),
(637,2849,1,'2018-08-13 16:36:09','Inicio de sesión','Satisfactorio'),
(638,2849,1,'2018-08-13 16:36:11','Ingreso a TPV','Satisfactorio'),
(639,2850,1,'2018-08-13 16:41:35','Inicio de sesión','Satisfactorio'),
(640,2850,1,'2018-08-13 16:41:43','Ingreso a TPV','Satisfactorio'),
(641,2851,1,'2018-08-13 16:43:09','Inicio de sesión','Satisfactorio'),
(642,2851,1,'2018-08-13 16:43:12','Ingreso a TPV','Satisfactorio'),
(643,2852,1,'2018-08-13 16:44:46','Inicio de sesión','Satisfactorio'),
(644,2852,1,'2018-08-13 16:44:56','Ingreso a TPV','Satisfactorio'),
(645,2853,1,'2018-08-13 16:47:29','Inicio de sesión','Satisfactorio'),
(646,2853,1,'2018-08-13 16:47:31','Ingreso a TPV','Satisfactorio'),
(647,2854,1,'2018-08-13 16:52:18','Inicio de sesión','Satisfactorio'),
(648,2854,1,'2018-08-13 16:52:21','Ingreso a TPV','Satisfactorio'),
(649,2855,1,'2018-08-13 16:53:33','Inicio de sesión','Satisfactorio'),
(650,2855,1,'2018-08-13 16:53:36','Ingreso a TPV','Satisfactorio'),
(651,2856,1,'2018-08-13 16:59:08','Inicio de sesión','Satisfactorio'),
(652,2856,1,'2018-08-13 16:59:12','Ingreso a TPV','Satisfactorio'),
(653,2857,1,'2018-08-13 17:08:38','Inicio de sesión','Satisfactorio'),
(654,2857,1,'2018-08-13 17:08:41','Ingreso a TPV','Satisfactorio'),
(655,2858,1,'2018-08-13 17:10:21','Inicio de sesión','Satisfactorio'),
(656,2858,1,'2018-08-13 17:10:25','Ingreso a TPV','Satisfactorio'),
(657,2859,1,'2018-08-13 17:18:50','Inicio de sesión','Satisfactorio'),
(658,2859,1,'2018-08-13 17:18:52','Ingreso a TPV','Satisfactorio'),
(659,2860,1,'2018-08-13 17:19:46','Inicio de sesión','Satisfactorio'),
(660,2860,1,'2018-08-13 17:19:49','Ingreso a TPV','Satisfactorio'),
(661,2861,1,'2018-08-13 17:20:51','Inicio de sesión','Satisfactorio'),
(662,2861,1,'2018-08-13 17:20:53','Ingreso a TPV','Satisfactorio'),
(663,2862,1,'2018-08-13 17:21:39','Inicio de sesión','Satisfactorio'),
(664,2862,1,'2018-08-13 17:21:42','Ingreso a TPV','Satisfactorio'),
(665,2863,1,'2018-08-13 17:22:31','Inicio de sesión','Satisfactorio'),
(666,2863,1,'2018-08-13 17:22:33','Ingreso a TPV','Satisfactorio'),
(667,2864,1,'2018-08-13 17:23:30','Inicio de sesión','Satisfactorio'),
(668,2864,1,'2018-08-13 17:23:34','Ingreso a TPV','Satisfactorio'),
(669,2865,1,'2018-08-13 17:24:21','Inicio de sesión','Satisfactorio'),
(670,2865,1,'2018-08-13 17:24:28','Ingreso a TPV','Satisfactorio'),
(671,2866,1,'2018-08-13 17:26:34','Inicio de sesión','Satisfactorio'),
(672,2866,1,'2018-08-13 17:26:38','Ingreso a TPV','Satisfactorio'),
(673,2867,1,'2018-08-13 17:27:46','Inicio de sesión','Satisfactorio'),
(674,2867,1,'2018-08-13 17:27:50','Ingreso a TPV','Satisfactorio'),
(675,2868,1,'2018-08-13 17:28:56','Inicio de sesión','Satisfactorio'),
(676,2868,1,'2018-08-13 17:28:58','Ingreso a TPV','Satisfactorio'),
(677,2869,1,'2018-08-13 17:29:58','Inicio de sesión','Satisfactorio'),
(678,2869,1,'2018-08-13 17:30:01','Ingreso a TPV','Satisfactorio'),
(679,2870,1,'2018-08-13 17:34:13','Inicio de sesión','Satisfactorio'),
(680,2870,1,'2018-08-13 17:34:16','Ingreso a TPV','Satisfactorio'),
(681,2870,1,'2018-08-13 17:36:14','Cierre de sesión','Satisfactorio'),
(682,2871,1,'2018-08-13 17:44:52','Inicio de sesión','Satisfactorio'),
(683,2871,1,'2018-08-13 17:44:54','Ingreso a TPV','Satisfactorio'),
(684,2871,1,'2018-08-13 17:45:04','Ingreso a Configuración de Tickets','Satisfactorio'),
(685,2871,1,'2018-08-13 17:45:18','Actualización de datos de la empresa','Satisfactorio'),
(686,2871,1,'2018-08-13 17:45:22','Ingreso a TPV','Satisfactorio'),
(687,2871,1,'2018-08-13 17:46:37','Cierre de sesión','Satisfactorio'),
(688,2872,1,'2018-08-13 17:48:47','Inicio de sesión','Satisfactorio'),
(689,2872,1,'2018-08-13 17:48:49','Ingreso a TPV','Satisfactorio'),
(690,2872,1,'2018-08-13 17:49:11','Ingreso a Configuración de Tickets','Satisfactorio'),
(691,2872,1,'2018-08-13 17:49:17','Actualización de datos de la empresa','Satisfactorio'),
(692,2872,1,'2018-08-13 17:49:23','Cierre de sesión','Satisfactorio'),
(693,2873,1,'2018-08-13 22:00:10','Inicio de sesión','Satisfactorio'),
(694,2873,1,'2018-08-13 22:00:14','Ingreso a Configuración de Tickets','Satisfactorio'),
(695,2873,1,'2018-08-13 22:00:49','Actualización de datos de la empresa','Satisfactorio'),
(696,2873,1,'2018-08-13 22:00:52','Ingreso a Configuración de Tickets','Satisfactorio'),
(697,2874,1,'2018-08-13 22:11:51','Inicio de sesión','Satisfactorio'),
(698,2874,1,'2018-08-13 22:11:56','Ingreso a Configuración de Tickets','Satisfactorio'),
(699,2874,1,'2018-08-13 22:12:03','Actualización de datos de la empresa','Satisfactorio'),
(700,2874,1,'2018-08-13 22:12:05','Ingreso a TPV','Satisfactorio'),
(701,2874,1,'2018-08-13 22:12:44','Ingreso a Configuración de Tickets','Satisfactorio'),
(702,2874,1,'2018-08-13 22:12:51','Actualización de datos de la empresa','Satisfactorio'),
(703,2874,1,'2018-08-13 22:12:57','Actualización de datos de la empresa','Satisfactorio'),
(704,2874,1,'2018-08-13 22:13:01','Ingreso a TPV','Satisfactorio'),
(705,2874,1,'2018-08-13 22:14:15','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(706,2874,1,'2018-08-13 22:14:36','Actualización de configuraciones del sistema','Satisfactorio'),
(707,2874,1,'2018-08-13 22:14:38','Actualización de configuraciones del sistema','Satisfactorio'),
(708,2874,1,'2018-08-13 22:14:41','Ingreso a TPV','Satisfactorio'),
(709,2875,1,'2018-08-13 22:38:50','Inicio de sesión','Satisfactorio'),
(710,2875,1,'2018-08-13 22:38:54','Ingreso a TPV','Satisfactorio'),
(711,2875,1,'2018-08-13 22:40:01','Agregar nueva venta con ID= 29','Satisfactorio'),
(712,2876,1,'2018-08-13 22:54:53','Inicio de sesión','Satisfactorio'),
(713,2876,1,'2018-08-13 22:54:55','Ingreso a TPV','Satisfactorio'),
(714,2877,1,'2018-08-13 22:56:14','Inicio de sesión','Satisfactorio'),
(715,2877,1,'2018-08-13 22:56:16','Ingreso a TPV','Satisfactorio'),
(716,2877,1,'2018-08-13 22:58:29','Todo el proceso de pago del pedido con ID: 27 ha finalizado','Satisfactorio'),
(717,2878,1,'2018-08-13 23:05:32','Inicio de sesión','Satisfactorio'),
(718,2879,1,'2018-08-13 23:06:21','Inicio de sesión','Satisfactorio'),
(719,2879,1,'2018-08-13 23:06:23','Ingreso a TPV','Satisfactorio'),
(720,2879,1,'2018-08-13 23:08:19','Ingreso a TPV','Satisfactorio'),
(721,2879,1,'2018-08-13 23:09:03','Ingreso a TPV','Satisfactorio'),
(722,2880,1,'2018-08-13 23:10:41','Inicio de sesión','Satisfactorio'),
(723,2880,1,'2018-08-13 23:11:12','Ingreso a TPV','Satisfactorio'),
(724,2881,1,'2018-08-13 23:12:44','Inicio de sesión','Satisfactorio'),
(725,2882,1,'2018-08-13 23:17:19','Inicio de sesión','Satisfactorio'),
(726,2882,1,'2018-08-13 23:19:15','Cierre de sesión','Satisfactorio'),
(727,2883,1,'2018-08-14 08:46:31','Inicio de sesión','Satisfactorio'),
(728,2883,1,'2018-08-14 08:46:34','Ingreso a TPV','Satisfactorio'),
(729,2883,1,'2018-08-14 08:46:40','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(730,2883,1,'2018-08-14 08:47:13','Actualización de configuraciones del sistema','Satisfactorio'),
(731,2883,1,'2018-08-14 08:47:28','Actualización de configuraciones del sistema','Satisfactorio'),
(732,2883,1,'2018-08-14 08:47:32','Ingreso a TPV','Satisfactorio'),
(733,2883,1,'2018-08-14 08:47:59','Todo el proceso de pago del pedido con ID: 28 ha finalizado','Satisfactorio'),
(734,2883,1,'2018-08-14 08:48:12','Agregar nueva venta con ID= 30','Satisfactorio'),
(735,2883,1,'2018-08-14 08:50:35','Cierre de sesión','Satisfactorio'),
(736,2884,1,'2018-08-14 10:02:11','Inicio de sesión','Satisfactorio'),
(737,2885,1,'2018-08-14 10:05:59','Inicio de sesión','Satisfactorio'),
(738,2886,1,'2018-08-14 10:09:01','Inicio de sesión','Satisfactorio'),
(739,2886,1,'2018-08-14 10:09:39','Cierre de sesión','Satisfactorio'),
(740,2887,1,'2018-08-14 10:09:46','Inicio de sesión','Satisfactorio'),
(741,2888,1,'2018-08-14 10:10:14','Inicio de sesión','Satisfactorio'),
(742,2888,1,'2018-08-14 10:10:17','Cierre de sesión','Satisfactorio'),
(743,2889,1,'2018-08-14 10:24:52','Inicio de sesión','Satisfactorio'),
(744,2890,1,'2018-08-14 10:29:36','Inicio de sesión','Satisfactorio'),
(745,2891,1,'2018-08-14 10:41:54','Inicio de sesión','Satisfactorio'),
(746,2892,1,'2018-08-14 10:45:52','Inicio de sesión','Satisfactorio'),
(747,2893,1,'2018-08-14 10:51:52','Inicio de sesión','Satisfactorio'),
(748,2894,1,'2018-08-14 10:54:01','Inicio de sesión','Satisfactorio'),
(749,2895,1,'2018-08-14 11:01:30','Inicio de sesión','Satisfactorio'),
(750,2896,1,'2018-08-14 11:05:06','Inicio de sesión','Satisfactorio'),
(751,2897,1,'2018-08-14 11:06:46','Inicio de sesión','Satisfactorio'),
(752,2898,1,'2018-08-14 11:10:29','Inicio de sesión','Satisfactorio'),
(753,2899,1,'2018-08-14 11:12:59','Inicio de sesión','Satisfactorio'),
(754,2899,1,'2018-08-14 11:16:13','Ingreso a TPV','Satisfactorio'),
(755,2899,1,'2018-08-14 11:16:32','Ingreso a TPV','Satisfactorio'),
(756,2899,1,'2018-08-14 11:17:05','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(757,2899,1,'2018-08-14 11:17:19','Actualización de configuraciones del sistema','Satisfactorio'),
(758,2899,1,'2018-08-14 11:18:34','Actualización de datos de la empresa','Satisfactorio'),
(759,2899,1,'2018-08-14 11:18:57','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(760,2899,1,'2018-08-14 11:19:03','Actualización de configuraciones del sistema','Satisfactorio'),
(761,2899,1,'2018-08-14 11:19:35','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(762,2899,1,'2018-08-14 11:19:39','Ingreso a TPV','Satisfactorio'),
(763,2899,1,'2018-08-14 11:19:54','Cierre de sesión','Satisfactorio'),
(764,2900,1,'2018-08-20 08:36:54','Inicio de sesión','Satisfactorio'),
(765,2900,1,'2018-08-20 08:38:41','Ingreso a TPV','Satisfactorio'),
(766,2900,1,'2018-08-20 08:39:43','Todo el proceso de pago del pedido con ID: 29 ha finalizado','Satisfactorio'),
(767,2900,1,'2018-08-20 08:39:56','Extender factura de pedido','Satisfactorio'),
(768,2900,1,'2018-08-20 08:39:56','Intento de asignar número de factura al pedido','Se produjo un error'),
(769,2900,1,'2018-08-20 08:40:46','Cierre de sesión','Satisfactorio'),
(770,2901,1,'2018-11-20 21:33:59','Inicio de sesión','Satisfactorio'),
(771,2901,1,'2018-11-20 21:34:01','Ingreso a TPV','Satisfactorio'),
(772,2901,1,'2018-11-20 21:34:05','Agregar nueva venta con ID= 31','Satisfactorio'),
(773,2901,1,'2018-11-20 21:35:37','Todo el proceso de pago del pedido con ID: 31 ha finalizado','Satisfactorio'),
(774,2901,1,'2018-11-20 21:37:52','Cierre de sesión','Satisfactorio'),
(775,2902,1,'2018-11-20 21:38:04','Inicio de sesión','Satisfactorio'),
(778,2903,1,'2018-11-20 21:54:02','Inicio de sesión','Satisfactorio'),
(779,2903,1,'2018-11-20 21:54:05','Ingreso a TPV','Satisfactorio'),
(780,2903,1,'2018-11-20 21:54:10','Agregar nueva venta con ID= 32','Satisfactorio'),
(781,2903,1,'2018-11-20 21:54:13','Agregar nueva venta con ID= 32','Satisfactorio'),
(782,2903,1,'2018-11-20 21:54:20','Agregar nueva venta con ID= 32','Satisfactorio'),
(783,2903,1,'2018-11-20 21:58:17','Agregar nueva venta con ID= 32','Satisfactorio'),
(784,2903,1,'2018-11-20 21:59:41','Agregar nueva venta con ID= 32','Satisfactorio'),
(785,2903,1,'2018-11-20 21:59:53','Agregar nueva venta con ID= 33','Satisfactorio'),
(786,2903,1,'2018-11-20 22:00:01','Agregar nueva venta con ID= 34','Satisfactorio'),
(787,2903,1,'2018-11-20 22:00:10','Agregar nueva venta con ID= 34','Satisfactorio'),
(788,2903,1,'2018-11-20 22:00:23','Cierre de sesión','Satisfactorio'),
(789,2904,1,'2018-11-20 22:01:16','Inicio de sesión','Satisfactorio'),
(790,2904,1,'2018-11-20 22:01:20','Ingreso a Configuración de Tickets','Satisfactorio'),
(791,2904,1,'2018-11-20 22:02:15','Cierre de sesión','Satisfactorio'),
(792,2905,1,'2018-11-20 22:03:52','Inicio de sesión','Satisfactorio'),
(793,2905,1,'2018-11-20 22:04:12','Ingreso a Configuración de Tickets','Satisfactorio'),
(794,2906,1,'2018-11-20 22:06:37','Inicio de sesión','Satisfactorio'),
(795,2906,1,'2018-11-20 22:06:39','Ingreso a TPV','Satisfactorio'),
(796,2906,1,'2018-11-20 22:06:44','Agregar nueva venta con ID= 35','Satisfactorio'),
(797,2906,1,'2018-11-20 22:07:25','Todo el proceso de pago del pedido con ID: 32 ha finalizado','Satisfactorio'),
(798,2906,1,'2018-11-20 22:07:39','Cierre de sesión','Satisfactorio'),
(799,2907,1,'2018-11-20 22:07:56','Inicio de sesión','Satisfactorio'),
(800,2907,1,'2018-11-20 22:08:01','Ingreso a Configuración de Tickets','Satisfactorio'),
(801,2907,1,'2018-11-20 22:09:14','Ingreso a TPP','Satisfactorio'),
(802,2907,1,'2018-11-20 22:10:55','Ingreso a productos','Satisfactorio'),
(803,2907,1,'2018-11-20 22:11:02','Ingreso a productos','Satisfactorio'),
(804,2907,1,'2018-11-20 22:11:13','Ingreso a productos','Satisfactorio'),
(805,2907,1,'2018-11-20 22:11:58','Realizar cambios en el comando de sistema: FACTURA','Satisfactorio'),
(806,2907,1,'2018-11-20 22:12:43','Ingreso a Configuraciones de la empresa','Satisfactorio'),
(807,2907,1,'2018-11-20 22:12:49','Ingreso a TPV','Satisfactorio'),
(808,2907,1,'2018-11-20 22:13:40','Cierre de sesión','Satisfactorio');
/*!40000 ALTER TABLE `logfile` ENABLE KEYS */;

-- 
-- Definition of mesa
-- 

DROP TABLE IF EXISTS `mesa`;
CREATE TABLE IF NOT EXISTS `mesa` (
  `idMesa` int(4) NOT NULL AUTO_INCREMENT,
  `numero` int(5) DEFAULT NULL,
  `nombre` varchar(35) NOT NULL,
  `capacidad` int(5) NOT NULL,
  `disponible` tinyint(1) NOT NULL,
  `idSalon` int(2) NOT NULL,
  PRIMARY KEY (`idMesa`),
  KEY `FKSalon1_idx` (`idSalon`),
  CONSTRAINT `FKSalon1` FOREIGN KEY (`idSalon`) REFERENCES `salon` (`idSalon`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=93 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table mesa
-- 

/*!40000 ALTER TABLE `mesa` DISABLE KEYS */;
INSERT INTO `mesa`(`idMesa`,`numero`,`nombre`,`capacidad`,`disponible`,`idSalon`) VALUES
(1,1,'R1',0,1,1),
(2,2,'R2',0,1,1),
(3,3,'R3',0,1,1),
(4,4,'R4',0,1,1),
(5,5,'R5',0,1,1),
(6,6,'R6',0,0,1),
(7,7,'R7',0,1,1),
(8,8,'R8',0,1,1),
(9,9,'R9',0,1,1),
(10,10,'R10',0,0,1),
(11,11,'R11',0,0,1),
(12,12,'R12',0,1,1),
(13,1,'J1',0,1,2),
(14,2,'J2',0,1,2),
(15,3,'J3',0,1,2),
(16,4,'J4',0,1,2),
(17,5,'J5',0,1,2),
(18,6,'J6',0,1,2),
(19,7,'J7',0,1,2),
(20,8,'J8',0,1,2),
(21,9,'J9',0,1,2),
(22,10,'J10',0,1,2),
(23,11,'J11',0,1,2),
(24,12,'J12',0,1,2),
(25,13,'J13',0,1,2),
(26,14,'J14',0,1,2),
(27,15,'Mesa 15',0,1,2),
(28,1,'P1',0,1,3),
(29,2,'P2',0,1,3),
(30,3,'P3',0,1,3),
(31,4,'P4',0,1,3),
(32,5,'Mesa 5',0,1,3),
(48,13,'Mesa 13',0,0,1),
(49,1,'M1',0,0,5),
(50,2,'M2',0,1,5),
(51,3,'M3',0,1,5),
(52,4,'M4',0,1,5),
(53,5,'M5',0,1,5),
(54,6,'Mesa 6',0,1,5),
(55,1,'S1',0,1,6),
(56,2,'S2',0,1,6),
(57,3,'S3',0,1,6),
(58,4,'S4',0,1,6),
(59,5,'S5',0,1,6),
(60,6,'S6',0,1,6),
(61,7,'S7',0,1,6),
(62,8,'S8',0,1,6),
(63,9,'S9',0,1,6),
(64,10,'S10',0,1,6),
(65,11,'Mesa 11',0,1,6),
(66,1,'HABITACION 1',0,0,7),
(67,2,'HABITACION 2',0,1,7),
(68,3,'HABITACION 3',0,1,7),
(69,4,'HABITACION 4',0,0,7),
(70,5,'HABITACION 5',0,1,7),
(71,6,'HABITACION 6',0,1,7),
(72,7,'Mesa 7',0,1,7),
(73,1,'Mesa 1',0,1,8),
(74,2,'Mesa 2',0,1,8),
(75,3,'Mesa 3',0,1,8),
(76,4,'Mesa 4',0,1,8),
(77,5,'Mesa 5',0,1,8),
(78,6,'Mesa 6',0,1,8),
(79,7,'Mesa 7',0,1,8),
(80,8,'Mesa 8',0,1,8),
(81,9,'Mesa 9',0,1,8),
(82,10,'Mesa 10',0,1,8),
(83,11,'Mesa 11',0,1,8),
(84,12,'Mesa 12',0,1,8),
(85,13,'Mesa 13',0,1,8),
(86,14,'Mesa 14',0,1,8),
(87,15,'Mesa 15',0,1,8),
(88,16,'Mesa 16',0,1,8),
(89,17,'Mesa 17',0,1,8),
(90,18,'Mesa 18',0,1,8),
(91,19,'Mesa 19',0,1,8),
(92,20,'Mesa 20',0,1,8);
/*!40000 ALTER TABLE `mesa` ENABLE KEYS */;

-- 
-- Definition of pago_mixto
-- 

DROP TABLE IF EXISTS `pago_mixto`;
CREATE TABLE IF NOT EXISTS `pago_mixto` (
  `idPago` int(11) NOT NULL,
  `idPedido` int(11) DEFAULT NULL,
  `idTarjeta` int(3) DEFAULT NULL,
  `pagoEfectivo` decimal(10,2) DEFAULT NULL,
  `pagoTarjeta` decimal(10,2) DEFAULT NULL,
  `totalPago` decimal(10,2) DEFAULT NULL,
  `voucher` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idPedido_5idx` (`idPedido`),
  KEY `idTarjeta_1idx` (`idTarjeta`),
  CONSTRAINT `idPedido_fk_5idx` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idTarjeta_fk_1idx` FOREIGN KEY (`idTarjeta`) REFERENCES `tarjeta_credito` (`idTarjeta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pago_mixto
-- 

/*!40000 ALTER TABLE `pago_mixto` DISABLE KEYS */;
INSERT INTO `pago_mixto`(`idPago`,`idPedido`,`idTarjeta`,`pagoEfectivo`,`pagoTarjeta`,`totalPago`,`voucher`) VALUES
(0,17,1,44.87,15.00,59.87,'11515'),
(1,18,1,20.00,33.83,53.83,'5555'),
(2,19,1,0.00,20.87,20.87,'02121'),
(3,20,2,0.00,48.36,48.36,'51623'),
(4,21,2,0.00,30.49,30.49,'45445'),
(5,26,2,0.00,4.40,4.40,'4'),
(6,28,2,0.00,62.67,62.67,'59622323'),
(7,29,1,15.00,33.91,48.91,'15355'),
(8,31,1,0.00,7.70,7.70,'503'),
(9,32,1,10.00,32.86,42.86,'155151');
/*!40000 ALTER TABLE `pago_mixto` ENABLE KEYS */;

-- 
-- Definition of pedido
-- 

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE IF NOT EXISTS `pedido` (
  `idPedido` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) DEFAULT NULL,
  `idMesa` int(4) DEFAULT NULL,
  `idCuenta` int(2) DEFAULT NULL,
  `idMesero` int(3) DEFAULT NULL,
  `cancelado` tinyint(1) NOT NULL,
  `fecha` datetime NOT NULL,
  `listo` tinyint(1) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `descuento` decimal(10,2) DEFAULT NULL,
  `iva` decimal(10,2) DEFAULT NULL,
  `propina` decimal(10,2) DEFAULT NULL,
  `totalPago` decimal(10,2) DEFAULT NULL,
  `idTiraje` int(5) DEFAULT NULL,
  `nFactura` varchar(15) DEFAULT NULL,
  `anular` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`idPedido`),
  KEY `fk_pedido_mesa1_idx` (`idMesa`),
  KEY `fk_pedido_cuenta1_idx` (`idCuenta`),
  KEY `fk_pedido_cliente1_idx` (`idCliente`),
  KEY `fk_pedido_mesero1_idx` (`idMesero`) USING BTREE,
  KEY `fk_tiraje_factura` (`idTiraje`),
  CONSTRAINT `fk_pedido_cliente1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_pedido_cuenta1` FOREIGN KEY (`idCuenta`) REFERENCES `cuenta` (`idCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedido_mesa11` FOREIGN KEY (`idMesa`) REFERENCES `mesa` (`idMesa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`idMesero`) REFERENCES `usuario` (`idUsuario`) ON DELETE SET NULL ON UPDATE NO ACTION,
  CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`idTiraje`) REFERENCES `tiraje_factura` (`idTiraje`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido
-- 

/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido`(`idPedido`,`idCliente`,`idMesa`,`idCuenta`,`idMesero`,`cancelado`,`fecha`,`listo`,`total`,`descuento`,`iva`,`propina`,`totalPago`,`idTiraje`,`nFactura`,`anular`) VALUES
(1,NULL,1,1,17,1,'2018-07-19 19:00:51',0,120.26,0.00,0.00,12.03,132.29,NULL,'',0),
(2,NULL,3,1,31,1,'2018-07-19 19:18:37',0,14.00,0.00,0.00,1.40,15.40,NULL,'',0),
(3,NULL,5,1,NULL,1,'2018-07-19 19:51:09',0,10.98,0.00,0.00,1.10,12.08,NULL,'',0),
(4,NULL,7,3,NULL,1,'2018-07-19 19:55:46',0,25.00,0.00,0.00,2.50,27.50,NULL,'',0),
(5,NULL,9,2,31,1,'2018-07-19 19:58:56',0,3.00,0.00,0.00,0.30,3.30,NULL,'',0),
(6,NULL,12,2,23,1,'2018-07-19 19:53:05',0,60.94,0.00,0.00,6.09,67.03,NULL,'',0),
(7,NULL,7,2,NULL,1,'2018-07-19 19:58:30',0,15.98,0.00,0.00,1.60,17.58,NULL,'',0),
(8,NULL,48,3,23,1,'2018-07-19 20:00:36',0,38.97,0.00,0.00,3.90,42.87,NULL,'',0),
(9,NULL,13,1,23,1,'2018-07-19 22:11:16',0,1.00,0.00,0.00,0.10,1.10,1,'1',0),
(10,NULL,66,1,1,0,'2018-03-02 14:34:02',0,13.99,0.00,0.00,1.40,15.39,NULL,'',0),
(11,NULL,69,1,1,0,'2018-03-02 14:34:28',0,6.00,0.00,0.00,0.60,6.60,NULL,'',0),
(12,NULL,10,1,NULL,1,'2018-03-14 15:46:53',0,5.00,0.00,0.00,0.50,5.50,NULL,'',0),
(13,NULL,2,2,NULL,1,'2018-07-19 19:03:12',0,91.83,0.00,0.00,9.18,101.01,NULL,'',0),
(14,NULL,1,1,17,1,'2018-07-19 18:58:52',0,76.18,0.00,0.00,7.62,83.80,NULL,'',0),
(15,NULL,48,1,NULL,1,'2018-07-19 22:12:41',0,47.94,0.00,0.00,4.79,52.73,1,'2',0),
(16,NULL,1,3,NULL,1,'2018-07-20 12:35:39',0,51.46,0.00,0.00,5.15,56.61,NULL,'',0),
(17,NULL,3,3,NULL,1,'2018-07-20 12:40:23',0,54.43,0.00,0.00,5.44,59.87,NULL,'',0),
(18,NULL,6,3,NULL,1,'2018-07-20 12:43:44',0,48.94,0.00,0.00,4.89,53.83,NULL,'',0),
(19,NULL,1,2,NULL,1,'2018-07-20 12:49:43',0,18.97,0.00,0.00,1.90,20.87,NULL,'',0),
(20,NULL,13,2,NULL,1,'2018-07-20 12:52:01',0,43.96,0.00,0.00,4.40,48.36,NULL,'',0),
(21,NULL,1,2,NULL,1,'2018-07-20 16:55:57',0,27.72,0.00,0.00,2.77,30.49,NULL,'',0),
(22,NULL,1,1,NULL,1,'2018-07-20 16:56:25',0,12.99,0.00,0.00,1.30,14.29,1,'3',0),
(23,NULL,49,1,NULL,0,'2018-07-25 20:54:08',0,3.25,0.00,0.00,0.00,0.00,NULL,'',0),
(24,NULL,4,1,NULL,1,'2018-07-31 14:06:55',0,41.35,0.00,0.00,4.14,45.49,NULL,'',0),
(25,NULL,6,1,NULL,1,'2018-07-31 14:07:19',0,25.96,0.00,0.00,0.00,25.96,NULL,'',0),
(26,NULL,16,2,NULL,1,'2018-08-09 11:19:27',0,4.00,0.00,0.00,0.40,4.40,NULL,'',0),
(27,NULL,1,1,NULL,1,'2018-08-13 22:58:28',0,43.96,0.00,0.00,4.40,48.36,NULL,'',0),
(28,NULL,11,2,NULL,1,'2018-08-14 08:47:58',0,56.97,0.00,0.00,5.70,62.67,NULL,'',0),
(29,NULL,3,3,NULL,1,'2018-08-20 08:39:42',0,44.46,0.00,0.00,4.45,48.91,1,'4',0),
(30,NULL,6,1,NULL,0,'2018-08-14 08:48:08',0,34.71,0.00,0.00,0.00,0.00,NULL,'',0),
(31,NULL,12,2,NULL,1,'2018-11-20 21:35:36',0,7.00,0.00,0.00,0.70,7.70,NULL,'',0),
(32,NULL,1,3,NULL,1,'2018-11-20 22:07:24',0,38.96,0.00,0.00,3.90,42.86,NULL,NULL,0),
(33,NULL,10,1,NULL,0,'2018-11-20 21:59:51',0,21.98,0.00,NULL,NULL,NULL,NULL,NULL,0),
(34,NULL,11,1,NULL,0,'2018-11-20 22:00:08',0,3.00,0.00,NULL,NULL,NULL,NULL,NULL,0),
(35,NULL,48,1,NULL,0,'2018-11-20 22:06:42',0,32.97,0.00,NULL,NULL,NULL,NULL,NULL,0);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;

-- 
-- Definition of pedido_detalle
-- 

DROP TABLE IF EXISTS `pedido_detalle`;
CREATE TABLE IF NOT EXISTS `pedido_detalle` (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `cocinando` tinyint(1) DEFAULT NULL,
  `extras` varchar(255) DEFAULT NULL,
  `horaEntregado` datetime DEFAULT NULL,
  `horaPedido` datetime DEFAULT NULL,
  `idCocinero` int(11) DEFAULT NULL,
  `idProducto` int(11) NOT NULL,
  `idPedido` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `subTotal` decimal(10,2) NOT NULL,
  `grupo` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`idDetalle`),
  KEY `FK8EC261C66039B36F_idx` (`idProducto`),
  KEY `FK8EC261C6B9DECED7_idx` (`idCocinero`),
  KEY `fk_pedido_detalle_pedido1_idx` (`idPedido`),
  CONSTRAINT `FK8EC261C66039B36F` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`),
  CONSTRAINT `FK8EC261C6B9DECED7` FOREIGN KEY (`idCocinero`) REFERENCES `cocinero` (`idCocinero`),
  CONSTRAINT `fk_pedido_detalle_pedido1` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=165 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido_detalle
-- 

/*!40000 ALTER TABLE `pedido_detalle` DISABLE KEYS */;
INSERT INTO `pedido_detalle`(`idDetalle`,`cocinando`,`extras`,`horaEntregado`,`horaPedido`,`idCocinero`,`idProducto`,`idPedido`,`cantidad`,`precio`,`subTotal`,`grupo`) VALUES
(4,1,'','2017-10-24 20:00:22','2017-10-24 20:00:22',NULL,119,2,2,6.00,12.00,''),
(5,1,'','2017-10-24 20:00:22','2017-10-24 20:00:22',NULL,69,2,2,1.00,2.00,''),
(6,1,'','2017-10-24 20:00:46','2017-10-24 20:00:46',NULL,5,3,2,3.99,7.98,''),
(7,1,'','2017-10-24 20:00:46','2017-10-24 20:00:46',NULL,94,3,1,3.00,3.00,''),
(9,1,'','2017-10-24 20:01:02','2017-10-24 20:01:02',NULL,103,4,2,5.00,10.00,''),
(10,1,'','2017-10-24 20:01:02','2017-10-24 20:01:02',NULL,128,4,3,5.00,15.00,''),
(11,1,'','2017-10-24 20:01:34','2017-10-24 20:01:34',NULL,64,5,1,3.00,3.00,''),
(12,1,'','2017-10-24 20:06:57','2017-10-24 20:06:57',NULL,16,6,1,10.99,10.99,''),
(13,1,'','2017-10-24 20:06:57','2017-10-24 20:06:57',NULL,18,6,2,10.99,21.98,''),
(14,1,'','2017-10-24 20:06:57','2017-10-24 20:06:57',NULL,17,6,2,10.99,21.98,''),
(15,1,'','2017-10-24 20:06:57','2017-10-24 20:06:57',NULL,20,6,1,5.99,5.99,''),
(16,1,'','2017-10-24 20:01:02','2017-10-24 20:01:02',NULL,137,7,2,7.99,15.98,''),
(17,1,'','2017-10-27 15:59:02','2017-10-27 15:59:02',NULL,64,8,5,3.00,15.00,''),
(18,1,'','2017-10-27 15:59:18','2017-10-27 15:59:18',NULL,67,9,1,1.00,1.00,''),
(19,1,'','2018-03-02 14:34:02','2018-03-02 14:34:02',NULL,119,10,1,6.00,6.00,''),
(20,1,'','2018-03-02 14:34:04','2018-03-02 14:34:04',NULL,10,10,1,7.99,7.99,''),
(21,1,'','2018-03-02 14:34:28','2018-03-02 14:34:28',NULL,119,11,1,6.00,6.00,''),
(22,1,'','2018-03-14 15:44:37','2018-03-14 15:44:37',NULL,38,12,2,1.00,2.00,''),
(23,1,'','2018-03-14 15:44:37','2018-03-14 15:44:37',NULL,108,12,2,1.00,2.00,''),
(24,1,'','2018-03-14 15:44:37','2018-03-14 15:44:37',NULL,41,12,1,1.00,1.00,''),
(25,1,'','2018-06-24 14:22:50','2018-06-24 14:22:50',NULL,6,1,6,8.49,50.94,''),
(26,1,'','2018-06-26 19:24:35','2018-06-26 19:24:35',NULL,4,1,5,3.49,17.45,''),
(28,1,'','2018-06-26 19:24:35','2018-06-26 19:24:35',NULL,5,1,13,3.99,51.87,''),
(30,1,'','2018-06-26 19:28:43','2018-06-26 19:28:43',NULL,4,13,3,3.49,10.47,''),
(31,1,'','2018-06-26 19:28:43','2018-06-26 19:28:43',NULL,3,13,5,3.49,17.45,''),
(32,1,'','2018-06-26 19:28:43','2018-06-26 19:28:43',NULL,5,13,2,3.99,7.98,''),
(45,1,'','2018-06-27 15:50:22','2018-06-27 15:50:22',NULL,10,13,2,7.99,15.98,''),
(46,1,'','2018-06-27 15:50:22','2018-06-27 15:50:22',NULL,9,13,5,7.99,39.95,''),
(47,1,'','2018-06-26 19:26:49','2018-06-26 19:26:49',NULL,18,14,1,10.99,10.99,''),
(48,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,41,14,1,1.00,1.00,''),
(49,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,50,14,1,1.00,1.00,''),
(50,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,108,14,1,1.00,1.00,''),
(51,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,39,14,2,1.00,2.00,''),
(52,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,43,14,3,1.00,3.00,''),
(53,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,42,14,1,1.00,1.00,''),
(54,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,49,14,1,0.75,0.75,''),
(55,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,48,14,1,1.00,1.00,''),
(56,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,47,14,1,1.00,1.00,''),
(57,1,'','2018-06-26 19:43:06','2018-06-26 19:43:06',NULL,7,14,5,9.49,47.45,''),
(58,1,'','2018-07-06 16:02:58','2018-07-06 16:02:58',NULL,20,14,1,5.99,5.99,''),
(59,1,'','2018-07-19 19:59:34','2018-07-19 19:59:34',NULL,10,8,1,7.99,7.99,''),
(60,1,'','2018-07-19 19:59:34','2018-07-19 19:59:34',NULL,9,8,1,7.99,7.99,''),
(61,1,'','2018-07-19 19:59:34','2018-07-19 19:59:34',NULL,8,8,1,7.99,7.99,''),
(62,1,'','2018-07-19 22:12:23','2018-07-19 22:12:23',NULL,9,15,5,7.99,39.95,''),
(63,1,'','2018-07-19 22:12:23','2018-07-19 22:12:23',NULL,8,15,1,7.99,7.99,''),
(64,1,'','2018-07-20 12:34:31','2018-07-20 12:34:31',NULL,4,16,1,3.49,3.49,''),
(65,1,'','2018-07-20 12:34:31','2018-07-20 12:34:31',NULL,3,16,1,3.49,3.49,''),
(66,1,'','2018-07-20 12:34:31','2018-07-20 12:34:31',NULL,31,16,1,5.99,5.99,''),
(67,1,'','2018-07-20 12:34:31','2018-07-20 12:34:31',NULL,113,16,1,3.49,3.49,''),
(68,1,'','2018-07-20 12:34:31','2018-07-20 12:34:31',NULL,86,16,1,35.00,35.00,''),
(69,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,119,17,1,6.00,6.00,''),
(70,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,10,17,1,7.99,7.99,''),
(71,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,9,17,1,7.99,7.99,''),
(72,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,20,17,1,5.99,5.99,''),
(73,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,21,17,1,6.99,6.99,''),
(74,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,19,17,1,5.99,5.99,''),
(75,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,31,17,1,5.99,5.99,''),
(76,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,113,17,1,3.49,3.49,''),
(77,1,'','2018-07-20 12:39:54','2018-07-20 12:39:54',NULL,41,17,4,1.00,4.00,''),
(78,1,'','2018-07-20 12:42:56','2018-07-20 12:42:56',NULL,38,18,2,1.00,2.00,''),
(79,1,'','2018-07-20 12:42:56','2018-07-20 12:42:56',NULL,44,18,2,1.00,2.00,''),
(80,1,'','2018-07-20 12:42:56','2018-07-20 12:42:56',NULL,45,18,2,1.00,2.00,''),
(81,1,'','2018-07-20 12:43:24','2018-07-20 12:43:24',NULL,18,18,1,10.99,10.99,''),
(82,1,'','2018-07-20 12:43:24','2018-07-20 12:43:24',NULL,20,18,2,5.99,11.98,''),
(83,1,'','2018-07-20 12:43:24','2018-07-20 12:43:24',NULL,21,18,2,6.99,13.98,''),
(84,1,'','2018-07-20 12:43:24','2018-07-20 12:43:24',NULL,19,18,1,5.99,5.99,''),
(85,1,'','2018-07-20 12:49:17','2018-07-20 12:49:17',NULL,28,19,2,5.99,11.98,''),
(86,1,'','2018-07-20 12:49:17','2018-07-20 12:49:17',NULL,24,19,1,4.99,4.99,''),
(87,1,'','2018-07-20 12:49:17','2018-07-20 12:49:17',NULL,50,19,1,1.00,1.00,''),
(88,1,'','2018-07-20 12:49:17','2018-07-20 12:49:17',NULL,108,19,1,1.00,1.00,''),
(89,1,'','2018-07-20 12:51:37','2018-07-20 12:51:37',NULL,119,20,2,6.00,12.00,''),
(90,1,'','2018-07-20 12:51:37','2018-07-20 12:51:37',NULL,10,20,1,7.99,7.99,''),
(91,1,'','2018-07-20 12:51:37','2018-07-20 12:51:37',NULL,8,20,3,7.99,23.97,''),
(92,1,'','2018-07-20 16:54:00','2018-07-20 16:54:00',NULL,10,21,2,7.99,15.98,''),
(93,1,'','2018-07-20 16:54:00','2018-07-20 16:54:00',NULL,8,21,1,7.99,7.99,''),
(94,1,'','2018-07-20 16:54:00','2018-07-20 16:54:00',NULL,111,21,1,1.25,1.25,''),
(95,1,'','2018-07-20 16:54:00','2018-07-20 16:54:00',NULL,71,21,1,1.25,1.25,''),
(96,1,'','2018-07-20 16:54:00','2018-07-20 16:54:00',NULL,70,21,1,1.25,1.25,''),
(97,1,'','2018-07-20 16:56:03','2018-07-20 16:56:03',NULL,38,22,1,1.00,1.00,''),
(98,1,'','2018-07-20 16:56:03','2018-07-20 16:56:03',NULL,44,22,4,1.00,4.00,''),
(99,1,'','2018-07-20 16:56:03','2018-07-20 16:56:03',NULL,117,22,1,7.99,7.99,''),
(100,1,'','2018-07-25 20:54:08','2018-07-25 20:54:08',NULL,71,23,1,1.25,1.25,''),
(101,1,'','2018-07-25 20:54:08','2018-07-25 20:54:08',NULL,44,23,1,1.00,1.00,''),
(102,1,'','2018-07-25 20:54:08','2018-07-25 20:54:08',NULL,50,23,1,1.00,1.00,''),
(105,1,'','2018-07-31 14:05:34','2018-07-31 14:05:34',NULL,142,24,2,3.75,7.50,''),
(106,1,'','2018-07-31 14:05:34','2018-07-31 14:05:34',NULL,143,24,1,3.85,3.85,''),
(107,1,'','2018-07-31 14:05:34','2018-07-31 14:05:34',NULL,123,24,1,24.00,24.00,''),
(108,1,'','2018-07-31 14:05:34','2018-07-31 14:05:34',NULL,45,24,5,1.00,5.00,''),
(109,1,'','2018-07-31 14:05:34','2018-07-31 14:05:34',NULL,38,24,1,1.00,1.00,''),
(110,1,'','2018-07-31 14:06:22','2018-07-31 14:06:22',NULL,38,25,1,1.00,1.00,''),
(111,1,'','2018-07-31 14:06:22','2018-07-31 14:06:22',NULL,44,25,1,1.00,1.00,''),
(112,1,'','2018-07-31 14:06:22','2018-07-31 14:06:22',NULL,16,25,1,10.99,10.99,''),
(113,1,'','2018-07-31 14:06:22','2018-07-31 14:06:22',NULL,31,25,1,5.99,5.99,''),
(114,1,'','2018-07-31 14:06:22','2018-07-31 14:06:22',NULL,113,25,2,3.49,6.98,''),
(115,1,'','2018-08-09 11:19:11','2018-08-09 11:19:11',NULL,38,26,1,1.00,1.00,''),
(116,1,'','2018-08-09 11:19:11','2018-08-09 11:19:11',NULL,44,26,1,1.00,1.00,''),
(117,1,'','2018-08-09 11:19:11','2018-08-09 11:19:11',NULL,45,26,1,1.00,1.00,''),
(118,1,'','2018-08-09 11:19:11','2018-08-09 11:19:11',NULL,108,26,1,1.00,1.00,''),
(119,1,'','2018-08-09 11:44:21','2018-08-09 11:44:21',NULL,38,27,1,1.00,1.00,''),
(120,1,'','2018-08-09 11:44:21','2018-08-09 11:44:21',NULL,44,27,1,1.00,1.00,''),
(121,1,'','2018-08-09 11:47:07','2018-08-09 11:47:07',NULL,65,28,1,2.50,2.50,''),
(122,1,'','2018-08-09 11:47:07','2018-08-09 11:47:07',NULL,64,28,5,3.00,15.00,''),
(123,1,'','2018-08-13 11:49:08','2018-08-13 11:49:08',NULL,38,28,1,1.00,1.00,''),
(124,1,'','2018-08-13 11:49:08','2018-08-13 11:49:08',NULL,44,28,1,1.00,1.00,''),
(125,1,'','2018-08-13 11:49:08','2018-08-13 11:49:08',NULL,45,28,1,1.00,1.00,''),
(126,1,'','2018-08-13 11:49:08','2018-08-13 11:49:08',NULL,47,28,1,1.00,1.00,''),
(127,1,'','2018-08-13 22:14:43','2018-08-13 22:14:43',NULL,8,27,1,7.99,7.99,''),
(128,1,'','2018-08-13 22:14:43','2018-08-13 22:14:43',NULL,66,27,1,1.00,1.00,''),
(129,1,'','2018-08-13 22:14:43','2018-08-13 22:14:43',NULL,16,27,2,10.99,21.98,''),
(130,1,'','2018-08-13 22:14:43','2018-08-13 22:14:43',NULL,18,27,1,10.99,10.99,''),
(131,1,'','2018-08-13 22:16:43','2018-08-13 22:16:43',NULL,16,28,2,10.99,21.98,''),
(132,1,'','2018-08-13 22:16:43','2018-08-13 22:16:43',NULL,18,28,1,10.99,10.99,''),
(133,1,'','2018-08-13 22:16:43','2018-08-13 22:16:43',NULL,56,28,1,2.50,2.50,''),
(134,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,49,29,2,0.75,1.50,''),
(135,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,48,29,1,1.00,1.00,''),
(136,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,38,29,1,1.00,1.00,''),
(137,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,16,29,1,10.99,10.99,''),
(138,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,18,29,2,10.99,21.98,''),
(139,1,'','2018-08-13 22:39:57','2018-08-13 22:39:57',NULL,117,29,1,7.99,7.99,''),
(140,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,38,30,1,1.00,1.00,''),
(141,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,49,30,1,0.75,0.75,''),
(142,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,50,30,1,1.00,1.00,''),
(143,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,117,30,2,7.99,15.98,''),
(144,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,8,30,1,7.99,7.99,''),
(145,1,'','2018-08-14 08:48:08','2018-08-14 08:48:08',NULL,9,30,1,7.99,7.99,''),
(146,1,'','2018-11-20 21:34:03','2018-11-20 21:34:03',NULL,38,31,1,1.00,1.00,''),
(147,1,'','2018-11-20 21:34:03','2018-11-20 21:34:03',NULL,41,31,2,1.00,2.00,''),
(148,1,'','2018-11-20 21:34:03','2018-11-20 21:34:03',NULL,50,31,2,1.00,2.00,''),
(149,1,'','2018-11-20 21:34:03','2018-11-20 21:34:03',NULL,42,31,1,1.00,1.00,''),
(150,1,'','2018-11-20 21:34:03','2018-11-20 21:34:03',NULL,43,31,1,1.00,1.00,''),
(152,1,'','2018-11-20 21:59:39','2018-11-20 21:59:39',NULL,16,32,1,10.99,10.99,NULL),
(153,1,'','2018-11-20 21:59:39','2018-11-20 21:59:39',NULL,18,32,1,10.99,10.99,NULL),
(154,1,'','2018-11-20 21:59:39','2018-11-20 21:59:39',NULL,17,32,1,10.99,10.99,NULL),
(155,1,'','2018-11-20 21:59:39','2018-11-20 21:59:39',NULL,20,32,1,5.99,5.99,NULL),
(156,1,'','2018-11-20 21:59:51','2018-11-20 21:59:51',NULL,119,33,1,6.00,6.00,NULL),
(157,1,'','2018-11-20 21:59:51','2018-11-20 21:59:51',NULL,10,33,1,7.99,7.99,NULL),
(158,1,'','2018-11-20 21:59:51','2018-11-20 21:59:51',NULL,9,33,1,7.99,7.99,NULL),
(160,1,'','2018-11-20 22:00:08','2018-11-20 22:00:08',NULL,67,34,2,1.00,2.00,NULL),
(161,1,'','2018-11-20 22:00:08','2018-11-20 22:00:08',NULL,69,34,1,1.00,1.00,NULL),
(162,1,'','2018-11-20 22:06:42','2018-11-20 22:06:42',NULL,16,35,1,10.99,10.99,NULL),
(163,1,'','2018-11-20 22:06:42','2018-11-20 22:06:42',NULL,18,35,1,10.99,10.99,NULL),
(164,1,'','2018-11-20 22:06:42','2018-11-20 22:06:42',NULL,17,35,1,10.99,10.99,NULL);
/*!40000 ALTER TABLE `pedido_detalle` ENABLE KEYS */;

-- 
-- Definition of permiso
-- 

DROP TABLE IF EXISTS `permiso`;
CREATE TABLE IF NOT EXISTS `permiso` (
  `idRol` int(2) NOT NULL,
  `idComando` int(2) NOT NULL,
  `fechaCreacion` date DEFAULT NULL,
  KEY `FK9481C4FEC6F99584_idx` (`idRol`),
  KEY `FK9481C4FEC6F99121_idx` (`idComando`),
  CONSTRAINT `FK9481C4FEC6F99121` FOREIGN KEY (`idComando`) REFERENCES `comando` (`idComando`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK9481C4FEC6F99584` FOREIGN KEY (`idRol`) REFERENCES `rol` (`idRol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table permiso
-- 

/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
INSERT INTO `permiso`(`idRol`,`idComando`,`fechaCreacion`) VALUES
(2,11,'2016-02-16 00:00:00'),
(1,14,'2016-02-16 00:00:00'),
(1,16,'2016-02-16 00:00:00'),
(2,15,'2016-02-16 00:00:00'),
(3,2,'2016-02-16 00:00:00'),
(2,10,'2016-02-17 00:00:00'),
(2,21,'2016-02-19 00:00:00'),
(1,15,'2016-02-19 00:00:00'),
(2,22,'2016-02-23 00:00:00'),
(2,30,'2016-02-29 00:00:00'),
(1,40,'2016-05-27 00:00:00'),
(1,41,'2016-05-27 00:00:00'),
(1,30,'2016-06-17 00:00:00'),
(1,42,'2016-06-17 00:00:00'),
(1,43,'2016-06-18 00:00:00'),
(1,10,'2017-02-28 00:00:00'),
(1,11,'2017-02-28 00:00:00'),
(1,2,'2017-03-20 00:00:00'),
(1,12,'2017-05-06 00:00:00'),
(1,13,'2017-05-06 00:00:00'),
(1,70,'2017-05-06 00:00:00'),
(1,71,'2017-05-06 00:00:00'),
(1,50,'2017-05-06 00:00:00'),
(1,51,'2017-05-06 00:00:00'),
(1,20,'2017-05-06 00:00:00'),
(1,21,'2017-05-06 00:00:00'),
(1,22,'2017-05-06 00:00:00'),
(1,23,'2017-05-06 00:00:00'),
(1,54,'2017-05-06 00:00:00'),
(1,56,'2017-05-06 00:00:00'),
(1,60,'2017-05-06 00:00:00'),
(1,72,'2017-05-06 00:00:00'),
(1,80,'2017-05-06 00:00:00'),
(1,81,'2017-05-06 00:00:00'),
(1,82,'2017-05-06 00:00:00'),
(1,90,'2017-05-06 00:00:00'),
(1,53,'2017-05-06 00:00:00'),
(1,52,'2017-05-06 00:00:00'),
(1,55,'2017-05-06 00:00:00'),
(3,40,'2017-05-06 00:00:00'),
(3,41,'2017-05-06 00:00:00'),
(3,90,'2017-05-06 00:00:00'),
(1,1,'2017-06-14 00:00:00'),
(1,4,'2017-07-14 00:00:00'),
(1,17,'2017-07-14 00:00:00'),
(1,61,'2017-07-14 00:00:00'),
(1,62,'2017-07-14 00:00:00'),
(1,83,'2017-07-14 00:00:00'),
(2,1,'2017-07-14 00:00:00'),
(2,12,'2017-07-14 00:00:00'),
(2,13,'2017-07-14 00:00:00'),
(2,16,'2017-07-14 00:00:00'),
(2,14,'2017-07-14 00:00:00'),
(2,61,'2017-07-14 00:00:00'),
(2,90,'2017-07-14 00:00:00'),
(2,80,'2017-07-14 00:00:00'),
(3,4,'2017-07-14 00:00:00'),
(3,42,'2017-07-14 00:00:00'),
(3,61,'2017-07-14 00:00:00'),
(3,62,'2017-07-14 00:00:00'),
(3,82,'2017-07-14 00:00:00'),
(3,83,'2017-07-14 00:00:00'),
(1,3,'2017-07-14 00:00:00'),
(2,3,'2017-07-14 00:00:00'),
(2,2,'2017-07-17 00:00:00'),
(3,1,'2017-07-17 00:00:00');
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;

-- 
-- Definition of producto
-- 

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `idFamilia` int(11) NOT NULL,
  `idUnidad` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `inventariable` tinyint(1) DEFAULT NULL,
  `conIngrediente` tinyint(1) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `fk_plato_tipoplato1_idx` (`idFamilia`),
  KEY `fk_unidadMedida_idx` (`idUnidad`),
  CONSTRAINT `fk_familia1` FOREIGN KEY (`idFamilia`) REFERENCES `familia` (`idFamilia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_unidadMedida1` FOREIGN KEY (`idUnidad`) REFERENCES `unidadmedida` (`idUnidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=146 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table producto
-- 

/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto`(`idProducto`,`idFamilia`,`idUnidad`,`nombre`,`descripcion`,`precio`,`costo`,`foto`,`inventariable`,`conIngrediente`,`stock`,`stockMinimo`,`activo`) VALUES
(3,26,1,'DESAYUNO E. CON VEGETALES','DESAYUNO E. CON VEGETALES',3.49,0.00,'VEGETALES.png',0,0,-100,0,1),
(4,26,1,'DESAYUNO E. CON JAMON','DESAYUNO E. CON JAMON',3.49,0.00,'huevos con jamon.jpg',0,0,-121,0,1),
(5,26,1,'DESAYUNO RANCHERO','DESAYUNO RANCHERO',3.99,0.00,'thVIDR5HF5.jpg',0,0,-109,0,1),
(6,27,1,'CHURRASCO ARGENTINO','CHURRASCO ARGENTINO',8.49,0.00,'CHURRASCO.jpg',1,0,-154,0,1),
(7,27,1,'TIPICO B.A','TIPICO B.A',9.49,0.00,'TIPICO.jpg',1,0,-171,0,1),
(8,28,1,'PECHUGA EN SALSA BARBACOA','PECHUGA EN SALSA BARBACOA',7.99,0.00,'pechuga a la barbacoa 023.JPG',1,0,-6,0,1),
(9,28,1,'PECHUGA A LA PLANCHA','PECHUGA A LA PLANCHA',7.99,0.00,'PLANCHA.jpg',1,0,-39,0,1),
(10,28,1,'P. EN SALSA DE HONGOS','P. EN SALSA DE HONGOS',7.99,0.00,'thOG1JF1A3.jpg',1,0,-97,0,1),
(11,29,1,'MARISCADA NATURAL','MARISCADA NATURAL',9.99,0.00,'NATURAL.jpg',1,0,-16,0,1),
(12,29,1,'MARISCADA CON CREMA','MARISCADA CON CREMA',10.99,0.00,'NATURAL.jpg',1,0,-35,0,1),
(13,29,1,'PESCADO PEQUEÑO','PESCADO PEQUEÑO',5.99,0.00,'thA3FONYEV.jpg',1,0,-11,0,1),
(14,29,1,'PESCADO GRANDE','PESCADO GRANDE',7.99,0.00,'thA3FONYEV.jpg',1,0,-1,0,1),
(15,29,1,'PESCADO B.A','PESCADO B.A',9.49,0.00,'pargo-fresco.jpg',1,0,-4,0,1),
(16,30,1,'CAMARONES A LA MEXICANA','CAMARONES A LA MEXICANA',10.99,0.00,'MEXICANA.jpg',1,0,20,0,1),
(17,30,1,'CAMARONES AL AJILLO','CAMARONES AL AJILLO',10.99,0.00,'thDOD86NEQ.jpg',1,0,-26,0,1),
(18,30,1,'CAMARONES A LA PLANCHA','CAMARONES A LA PLANCHA',10.99,0.00,'PLANCHA.png',1,0,-18,0,1),
(19,31,1,'COCTEL DE CONCHA','COCTEL DE CONCHA',5.99,0.00,'coctel_de_concha.jpg',1,0,-17,0,1),
(20,31,1,'COCTEL CAMARON NATURAL','COCTEL CAMARON NATURAL',5.99,0.00,'coctel-de-camarones.jpg',1,0,-29,0,1),
(21,31,1,'COCTEL CAMARON S.R','COCTEL CAMARON S.R',6.99,0.00,'CocktailCamarones.jpg',1,0,-37,0,1),
(22,31,1,'COCTEL MIXTO','COCTEL MIXTO',6.99,0.00,'coctel-de-camarones.jpg',1,0,-8,0,1),
(23,32,1,'SANDWICH DE POLLO','SANDWICH DE POLLO',4.99,0.00,'thDWSIPJWL.jpg',0,0,-51,0,1),
(24,32,1,'SANDWICH DE JAMON','SANDWICH DE JAMON',4.99,0.00,'thDWSIPJWL.jpg',0,0,-17,0,1),
(25,32,1,'HAMBURGUESA','HAMBURGUESA',5.99,0.00,'BK_300x270_hamburguesa_deluxe_queso.png',1,0,-52,0,1),
(26,32,1,'PASTA ALFREDO CON POLLO','PASTA ALFREDO CON POLLO',6.99,0.00,'Spaghetti Alfredo 2.jpg',1,0,-13,0,1),
(27,32,1,'PASTA A. CON CAMARONES','PASTA A. CON CAMARONES',6.99,0.00,'light-fettucine-alfredo.jpg',1,0,-4,0,1),
(28,32,1,'PINCHOS DE POLLO','PINCHOS DE POLLO',5.99,0.00,'th9VZQVY8K.jpg',1,0,-6,0,1),
(29,32,1,'PINCHOS DE CARNE','PINCHOS DE CARNE ',5.99,0.00,'maxresdefault.jpg',1,0,-9,0,1),
(30,33,1,'ENSALADA FRESCA CON ATUN','ENSALADA FRESCA CON ATUN',6.99,0.00,'Ensalada-con-atún.jpg',0,0,-2,0,1),
(31,33,1,'ENSALADA CON POLLO','ENSALADA CON POLLO',5.99,0.00,'ensalada.jpg',0,0,-39,0,1),
(32,33,1,'ENSALADA FRESCA','ENSALADA FRESCA',3.49,0.00,'ensalada_14.jpg',0,0,-5,0,1),
(33,34,1,'SORBETE','SORBETE',1.24,0.00,'sorbete-de-pina-e1301363574168.jpg',1,0,-44,0,1),
(34,34,1,'TRES LECHES','TRES LECHES',2.49,0.00,'tres-leches-cake.jpg',1,0,-13,0,1),
(35,34,1,'BUDIN','BUDIN',2.49,0.00,'thLR3V091F.jpg',1,0,-130,0,1),
(36,34,1,'QUESADILLA','QUESADILLA',2.49,0.00,'quesadilla-salvadoreña-receta.jpg',1,0,-209,0,1),
(37,34,1,'CHEESECAKE','CHEESECAKE',2.49,0.00,'thSF3OP0GU.jpg',1,0,-62,0,1),
(38,35,1,'COCA-COLA','COCA-COLA',1.00,0.00,'coca-cola.jpg',1,0,-139,0,1),
(39,35,1,'SPRITE','SPRITE',1.00,0.00,'th3MVWSHXB.jpg',1,0,-15,0,1),
(40,35,1,'FRESA','FRESA',1.00,0.00,'tropical.png',1,0,-6,0,1),
(41,35,1,'FRESCA','FRESCA',1.00,0.00,'fresca_banner.jpg',1,0,-22,0,1),
(42,35,1,'SUPERCHAMPAN','SUPERCHAMPAN',1.00,0.00,'th59IFH6F2.jpg',1,0,-12,0,1),
(43,35,1,'UVA','UVA',1.00,0.00,'thBU54H9FD.jpg',1,0,-38,0,1),
(44,35,1,'CREMA SODA','CREMA SODA',1.00,0.00,'cremasoda.png',1,0,-35,0,1),
(45,35,1,'FANTA','FANTA',1.00,0.00,'fanta.png',1,0,-64,0,1),
(46,35,1,'COCA ZERO','COCA ZERO',1.00,0.00,'thHQVQXPUA.jpg',1,0,6,0,1),
(47,35,1,'COCA LIGHT','COCA LIGHT',1.00,0.00,'thDSHKTBQG.jpg',1,0,8,0,1),
(48,35,1,'AGUA MINERAL','AGUA MINERAL',1.00,0.00,'thBX4HO3FU.jpg',1,0,-17,0,1),
(49,35,1,'AGUA','AGUA',0.75,0.00,'thC1NDDPNZ.jpg',1,0,-26,0,1),
(50,35,1,'FUZE TEA','FUZE TEA',1.00,0.00,'thK7PZA7HD.jpg',1,0,17,0,1),
(51,37,1,'PILSENER','PILSENER',1.50,0.00,'pilsener-logo-F398838DC9-seeklogo.com.gif.jpg',1,0,-33,0,1),
(52,37,1,'GOLDEN','GOLDEN',1.50,0.00,'178058303_ae23122bff.jpg',1,0,-16,0,1),
(53,37,1,'SUPREMA','SUPREMA',2.00,0.00,'th7KCS3B62.jpg',1,0,-79,0,1),
(54,37,1,'CORONA','CORONA',2.50,0.00,'thHBP0L15S.jpg',1,0,-44,0,1),
(55,37,1,'SMIRNOFF','SMIRNOFF',2.50,0.00,'Smirnoff-_ice_sabores.jpg',1,0,13,0,1),
(56,37,1,'HEYNEKEN','HEYNEKEN',2.50,0.00,'thYSMTB77V.jpg',1,0,134,0,1),
(57,37,1,'MODELO','MODELO',2.50,0.00,'thDASHQ7MM.jpg',1,0,67,0,1),
(58,41,1,'FROZEN DE FRESA','FROZEN DE FRESA',3.00,0.00,'thDT9R1D2Q.jpg',1,0,-58,0,1),
(59,41,1,'FROZEN DE COCO ','FROZEN DE COCO',3.00,0.00,'thJ109J02A.jpg',1,0,-20,0,1),
(60,41,1,'FROZEN DE SANDIA ','FROZEN DE SANDIA',3.00,0.00,'th.jpg',1,0,-20,0,1),
(61,41,1,'LIMONADA ESPECIAL','LIMONADA ESPECIAL',2.00,0.00,'thXZMD5F9G.jpg',0,0,-170,0,1),
(62,41,1,'LICUADO DE GUINEO','LICUADO DE GUINEO',2.50,0.00,'untitled.png',1,0,-29,0,1),
(63,41,1,'LICUADO DE FRESA','LICUADO DE FRESA ',2.50,0.00,'thGIEYJX3Y.jpg',1,0,-19,0,1),
(64,41,1,'JUGO DE NARANJA','JUGO DE NARANJA',3.00,0.00,'th38DAKPHQ.jpg',0,0,-112,0,1),
(65,41,1,'CAFE CON HELADO','CAFE CON HELADO',2.50,0.00,'thJYSS9NOR.jpg',0,0,-17,0,1),
(66,36,1,'CHOCOLATE','CHOCOLATE',1.00,0.00,'thU4GDHPV9.jpg',1,0,-251,0,1),
(67,36,1,'CAFE','CAFE',1.00,0.00,'th9E80TPUM.jpg',1,0,-394,0,1),
(68,36,1,'CAFE CON LECHE','CAFE CON LECHE',1.25,0.00,'thB4HM8JB6.jpg',1,0,-93,0,1),
(69,36,1,'LECHE','LECHE',1.00,0.00,'thB4HM8JB6.jpg',1,0,-25,0,1),
(70,36,1,'TE VERDE','TE VERDE',1.25,0.00,'th32ARK324.jpg',1,0,-12,0,1),
(71,36,1,'TE DE MANZANILLA','TE DE MANZANILLA',1.25,0.00,'th32ARK324.jpg',1,0,-30,0,1),
(72,36,1,'CAPUCHINO','CAPUCHINO',2.00,0.00,'thJYSS9NOR.jpg',0,0,-79,0,1),
(74,44,1,'ORDEN DE TORTILLA','ORDEN DE TORTILLA',0.50,0.00,'th342BUHE5.jpg',0,0,-39,0,1),
(75,44,1,'ORDEN DE PAN FRANCES','ORDEN DE PAN FRANCES',0.50,0.00,'th.jpg',0,0,-33,0,1),
(76,44,1,'ORDEN DE QUESO','ORDEN DE QUESO',1.00,0.00,'queso.jpg',0,0,-27,0,1),
(77,44,1,'ORDEN DE AGUACATE','ORDEN DE AGUACATE',1.00,0.00,'aguacate.jpg',0,0,-17,0,1),
(78,44,1,'ORDEN DE PAPA FRITA','ORDEN DE PAPA FRITA',2.00,0.00,'untitled.png',0,0,-61,0,1),
(79,44,1,'PALOMITAS DE MAIZ','PALOMITAS DE MAIZ',2.00,0.00,'untitled.png',1,0,-1,0,1),
(80,44,1,'ORDEN DE ARROZ','ORDEN DE ARROZ',1.00,0.00,'thXMIPO81Z.jpg',0,0,-1,0,1),
(81,44,1,'ORDEN DE FRIJOL','ORDEN DE FRIJOL',1.00,0.00,'thXMIPO81Z.jpg',0,0,-6,0,1),
(82,44,1,'ORDEN DE TORTILLA FRITA','ORDEN DE TORTILLA FRITA',0.50,0.00,'thMP18DAIB.jpg',0,0,-14,0,1),
(83,44,1,'ORDEN DE NACHO','ORDEN DE NACHO',2.00,0.00,'Flickr_jennerosity_3399911471--Nachos.jpg',0,0,-5,0,1),
(84,44,1,'ORDEN DE CREMA','ORDEN DE CREMA',1.00,0.00,'th85EA23FF.jpg',0,0,-11,0,1),
(85,44,1,'ORDEN DE PLATANO FRITO','ORDEN DE PLATANO FRITO',1.00,0.00,'th0PFI4JQ2.jpg',0,0,-17,0,1),
(86,40,1,'HABITACION 1','HABITACION 1',35.00,0.00,'',0,0,-7,0,1),
(87,40,1,'HABITACION 2','HABITACION 2',45.00,0.00,'',0,0,0,0,1),
(88,40,1,'HABITACION 3','HABITACION 3',45.00,0.00,'',0,0,-1,0,1),
(89,40,1,'HABITACION 4','HABITACION 4',50.00,0.00,'',0,0,-1,0,1),
(90,40,1,'HABITACION 5','HABITACION 5',45.00,0.00,'',0,0,-1,0,1),
(91,40,1,'HABITACION 6','HABITACION 6',35.00,0.00,'',0,0,-2,0,1),
(92,45,1,'SOPA DE GALLINA ','SOPA DE GALLINA',7.99,0.00,'thYBN3KS5M.jpg',0,0,-190,0,1),
(93,45,1,'SOPA SOLA','SOPA SOLA',4.00,0.00,'thAW530FB6.jpg',0,0,-4,0,1),
(94,26,1,'PAN CAKE','PAN CAKE',3.00,0.00,'buttermilk_pancake_image.jpg',0,0,-5,0,1),
(95,38,1,'MOJITO','MOJITO',5.00,0.00,'th4MB97Z7R.jpg',0,0,-16,0,1),
(96,38,1,'MICHELADA CON PILSENER','MICHELADA CON PILSENER',3.00,0.00,'MicheladaPreparada.jpg',1,0,-3,0,1),
(97,38,1,'MICHELADA GOLDEN','MICHELADA GOLDEN',3.00,0.00,'MicheladaPreparada.jpg',1,0,-6,0,1),
(98,38,1,'MICHELADA SUPREMA','MICHELADA SUPREMA',3.50,0.00,'MicheladaPreparada.jpg',1,0,-3,0,1),
(99,38,1,'COPA VINO','COPA VINO',5.00,0.00,'thW4GAFG63.jpg',1,0,-9,0,1),
(100,38,1,'CUBALIBRE','CUBALIBRE',5.00,0.00,'thAGASQ38B.jpg',1,0,0,0,1),
(101,38,1,'BOTELLA VINO A','BOTELLA VINO A',20.00,0.00,'BOTELLA 1866 LARIOS.bmp',1,0,-2,0,1),
(102,38,1,'BOTELLA VINO B','BOTELLA VINO B',25.00,0.00,'BOTELLA JHONIE WALKER NEGRO.bmp',1,0,0,0,1),
(103,38,1,'DESCORCHE','DESCORCHE',5.00,0.00,'buttermilk_pancake_image.jpg',1,0,-3,0,1),
(104,38,1,'HIELO','HIELO',1.00,0.00,'buttermilk_pancake_image.jpg',1,0,0,0,1),
(105,44,1,'ORD.LIMON','ORD.LIMON',0.50,0.00,'buttermilk_pancake_image.jpg',1,0,0,0,1),
(107,46,1,'USO DE PISCINA','USO DE PISCINA',2.00,0.00,'untitled.png',0,0,-15,0,1),
(108,35,1,'HORCHATA','HORCHATA',1.00,0.00,'horchata.jpg',0,0,-37,0,1),
(109,47,1,'PLATO DE BOCA PEQUEÑO','',5.00,0.00,'atun1.jpg',0,0,-22,0,1),
(110,47,1,'PLATO DE BOCA MEDIA','PLATO DE BOCA MEDIANO',10.00,0.00,'carta_laconGallego.jpg',0,0,-3,0,1),
(111,36,1,'CHOCOLATE CON LECHE','CHOCOLATE CON LECHE',1.25,0.00,'thVIW8K0CU.jpg',0,0,-20,0,1),
(112,44,1,'ORDEN DE CHORIZO','ORDEN DE CHORIZO',1.00,0.00,'croquetas2.gif',0,0,-8,0,1),
(113,33,1,'ENSALADA DE VEGETALES','ENSALADA DE VEGETALES',3.49,0.00,'raviolis_con_cebollino.jpg',0,0,-7,0,1),
(114,44,1,'PAN CON AJO','PAN CON AJO',0.50,0.00,'',0,0,-13,0,1),
(115,37,1,'VALDE DE PILSENER','VALDE DE PILSENER',8.00,0.00,'',0,0,-17,0,1),
(116,38,1,'MICHELADA MIX','MICHELADA MIX',3.75,0.00,'',0,0,-8,0,1),
(117,27,1,'COSTILLON B.A','COSTILLON B.A',7.99,0.00,'carta_costillas.jpg',1,0,23,0,1),
(118,37,1,'VALDE GOLDEN','VALDE GOLDEN',8.00,0.00,'',1,0,-19,0,1),
(119,28,9,'ALITAS SBBQ','ALITAS SBBQ',6.00,0.00,'',1,0,-10,0,1),
(120,34,1,'PASTEL DE CHOCOLATE','PASTEL DE CHOCOLATE',2.49,0.00,'',1,0,-10,0,1),
(122,37,1,'HIELERAZO GOLDEN','HIELERAZO GOLDEN ',24.00,0.00,'',1,0,-1,0,1),
(123,37,1,'HIELERAZO','HIELERAZO',24.00,0.00,'thB4HM8JB6.jpg',1,0,-3,0,1),
(124,37,1,'HIELERAZO.B','HIELERAZO.B',30.00,0.00,'thB4HM8JB6.jpg',1,0,-1,0,1),
(125,37,1,'VALDE DE MODELO ','VALDE DE MODELO',10.00,0.00,'',1,0,0,0,1),
(126,37,1,'VALDE MODELO 5','VALDE  MODELO 5',10.00,0.00,'',1,0,-1,0,1),
(127,37,1,'BALDE SUPREMA','BALDE SUPREMA',10.00,0.00,'',1,0,-3,0,1),
(128,38,1,'MARGARITA','',5.00,0.00,'',1,0,-5,0,1),
(129,38,1,'TEQUILA','SENCILLO',5.00,0.00,'',1,0,-1,0,1),
(130,38,1,'TEQUILA DOBLE','',10.00,0.00,'',1,0,-4,0,1),
(131,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,0,0,0),
(132,28,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,0,0,0),
(133,37,1,'5 CORONAS','5 CORONAS',11.00,0.00,'',1,0,-2,0,1),
(134,44,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,-1,0,1),
(135,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,-1,0,1),
(136,44,1,'ORDEN DE CARNE','',3.00,0.00,'',1,0,-1,0,1),
(137,45,1,'COSTILLA DE CERDO AHUMADA','',7.99,0.00,'',1,0,-8,0,1),
(142,51,1,'CROQUETAS DE COLIFLOR','',3.75,0.00,'Croquetas de coliflor.jpg',0,0,-2,0,1),
(143,51,1,'MATAMBRE ARROLADO','',3.85,0.00,'Matambre arrollado.jpg',0,0,-1,0,1),
(144,51,1,'TARTA DE ATÚN','',2.90,0.00,'Tarta de atún.jpg',0,0,0,0,1),
(145,51,1,'PASTEL DE POLLO','',2.75,0.00,'Pastel de pollo.jpg',0,0,0,0,1);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;

-- 
-- Definition of proveedor
-- 

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE IF NOT EXISTS `proveedor` (
  `idProveedor` int(4) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `NIT` varchar(45) NOT NULL,
  `regContable` varchar(25) NOT NULL,
  `contacto` varchar(45) NOT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table proveedor
-- 

/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor`(`idProveedor`,`nombre`,`direccion`,`email`,`telefono`,`NIT`,`regContable`,`contacto`) VALUES
(1,'MAXI DESPENSA','SONSONATE','alguien@yahoo.es','0000','90','0000000112','juan');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;

-- 
-- Definition of reserva
-- 

DROP TABLE IF EXISTS `reserva`;
CREATE TABLE IF NOT EXISTS `reserva` (
  `idReserva` int(11) NOT NULL AUTO_INCREMENT,
  `DUI` varchar(25) NOT NULL,
  `fecha` datetime NOT NULL,
  `numerosdemesa` tinyblob NOT NULL,
  `idMesa` int(11) NOT NULL,
  PRIMARY KEY (`idReserva`),
  KEY `fk_reserva_mesa1_idx` (`idMesa`),
  CONSTRAINT `fk_reserva_mesa1` FOREIGN KEY (`idMesa`) REFERENCES `mesa` (`idMesa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table reserva
-- 

/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;

/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;

-- 
-- Definition of rol
-- 

DROP TABLE IF EXISTS `rol`;
CREATE TABLE IF NOT EXISTS `rol` (
  `idRol` int(2) NOT NULL AUTO_INCREMENT,
  `rol` varchar(30) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table rol
-- 

/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol`(`idRol`,`rol`) VALUES
(1,'Administrador'),
(2,'Mesero'),
(3,'Cajero');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;

-- 
-- Definition of salon
-- 

DROP TABLE IF EXISTS `salon`;
CREATE TABLE IF NOT EXISTS `salon` (
  `idSalon` int(2) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `fondo` varchar(45) DEFAULT NULL,
  `nMesas` int(11) NOT NULL,
  PRIMARY KEY (`idSalon`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table salon
-- 

/*!40000 ALTER TABLE `salon` DISABLE KEYS */;
INSERT INTO `salon`(`idSalon`,`nombre`,`fondo`,`nMesas`) VALUES
(1,'RESTAURANTE','',13),
(2,'JARDIN','',15),
(3,'PERGOLA','',5),
(5,'MIRADOR','',6),
(6,'SALON','',11),
(7,'HOSTAL','',7),
(8,'Prueba','',20);
/*!40000 ALTER TABLE `salon` ENABLE KEYS */;

-- 
-- Definition of sesion
-- 

DROP TABLE IF EXISTS `sesion`;
CREATE TABLE IF NOT EXISTS `sesion` (
  `idSesion` int(11) NOT NULL AUTO_INCREMENT,
  `idUsuario` int(3) NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `fechaFin` datetime DEFAULT NULL,
  `estadoSesion` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idSesion`),
  KEY `idUsuario_dx` (`idUsuario`),
  CONSTRAINT `sesionUsuario_FK` FOREIGN KEY (`idUsuario`) REFERENCES `empleado` (`idEmpleado`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2908 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sesion
-- 

/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;
INSERT INTO `sesion`(`idSesion`,`idUsuario`,`fecha`,`fechaFin`,`estadoSesion`) VALUES
(2519,1,'2017-10-24 10:38:48','0001-01-01 00:00:00','0'),
(2521,1,'2017-10-24 15:21:34','0001-01-01 00:00:00','0'),
(2523,1,'2017-10-24 19:04:54','0001-01-01 00:00:00','0'),
(2524,1,'2017-10-24 19:58:49','2017-10-24 20:07:32','0'),
(2525,1,'2017-10-24 20:11:00','0001-01-01 00:00:00','0'),
(2526,1,'2017-10-24 20:13:32','2017-10-24 20:17:37','0'),
(2527,1,'2017-10-27 09:57:52','0001-01-01 00:00:00','0'),
(2528,1,'2017-10-27 09:58:02','0001-01-01 00:00:00','0'),
(2529,1,'2017-10-27 10:50:47','0001-01-01 00:00:00','0'),
(2530,1,'2017-10-27 10:52:56','0001-01-01 00:00:00','0'),
(2531,1,'2017-10-27 10:54:05','0001-01-01 00:00:00','0'),
(2532,1,'2017-10-27 10:58:44','0001-01-01 00:00:00','0'),
(2533,1,'2017-10-27 13:47:33','2017-10-27 13:47:36','0'),
(2534,1,'2017-10-27 13:47:45','2017-10-27 13:48:00','0'),
(2535,1,'2017-10-27 13:48:20','0001-01-01 00:00:00','0'),
(2536,1,'2017-10-27 13:48:56','0001-01-01 00:00:00','0'),
(2537,1,'2017-10-27 13:49:15','0001-01-01 00:00:00','0'),
(2538,1,'2017-10-27 13:51:44','0001-01-01 00:00:00','0'),
(2539,1,'2017-10-27 13:52:55','0001-01-01 00:00:00','0'),
(2540,1,'2017-10-27 13:58:52','0001-01-01 00:00:00','0'),
(2541,1,'2017-10-27 13:59:12','0001-01-01 00:00:00','0'),
(2542,1,'2017-10-27 14:02:46','2017-10-27 14:03:29','0'),
(2543,1,'2017-10-27 14:03:38','0001-01-01 00:00:00','0'),
(2544,1,'2017-10-27 14:11:51','0001-01-01 00:00:00','0'),
(2545,1,'2017-10-27 14:14:38','0001-01-01 00:00:00','0'),
(2546,1,'2017-10-27 14:15:30','0001-01-01 00:00:00','0'),
(2547,1,'2017-10-27 14:16:22','0001-01-01 00:00:00','0'),
(2548,1,'2017-10-27 14:16:49','2017-10-27 14:17:23','0'),
(2549,1,'2017-10-27 14:17:32','0001-01-01 00:00:00','0'),
(2550,1,'2017-10-27 14:50:35','2017-10-27 14:50:54','0'),
(2551,1,'2017-10-27 14:51:06','0001-01-01 00:00:00','0'),
(2552,1,'2017-10-27 15:54:19','2017-10-27 15:54:25','0'),
(2553,1,'2017-10-27 15:54:38','0001-01-01 00:00:00','0'),
(2554,1,'2017-10-27 15:56:01','0001-01-01 00:00:00','0'),
(2555,1,'2017-10-27 15:58:47','2017-10-27 15:59:38','0'),
(2556,1,'2017-10-28 11:01:28','2017-10-28 11:11:25','0'),
(2557,1,'2017-10-30 15:27:59','2017-10-30 15:28:11','0'),
(2558,1,'2017-10-30 15:35:48','0001-01-01 00:00:00','0'),
(2559,1,'2017-10-30 15:38:47','0001-01-01 00:00:00','0'),
(2560,1,'2017-10-30 15:39:11','0001-01-01 00:00:00','0'),
(2561,1,'2017-10-30 15:39:38','0001-01-01 00:00:00','0'),
(2562,1,'2017-10-30 15:40:16','0001-01-01 00:00:00','0'),
(2563,1,'2017-10-30 15:43:23','0001-01-01 00:00:00','0'),
(2564,1,'2017-10-30 15:44:27','0001-01-01 00:00:00','0'),
(2565,1,'2017-10-31 18:33:46','2017-10-31 18:34:04','0'),
(2566,1,'2017-11-08 10:27:19','2017-11-08 10:29:52','0'),
(2567,1,'2017-11-08 10:29:58','2017-11-08 10:31:23','0'),
(2568,1,'2017-11-13 12:36:00','2017-11-13 12:36:39','0'),
(2569,1,'2017-11-13 12:37:56','0001-01-01 00:00:00','0'),
(2570,1,'2017-11-13 12:38:16','2017-11-13 12:38:21','0'),
(2571,1,'2017-11-13 12:43:12','0001-01-01 00:00:00','0'),
(2572,1,'2017-11-13 12:45:49','2017-11-13 12:46:02','0'),
(2573,1,'2017-11-13 12:47:06','2017-11-13 12:47:19','0'),
(2574,1,'2017-11-13 12:47:30','0001-01-01 00:00:00','0'),
(2575,1,'2017-11-13 12:48:04','2017-11-13 12:48:08','0'),
(2576,1,'2017-11-13 12:50:38','0001-01-01 00:00:00','0'),
(2577,1,'2017-11-13 12:52:36','2017-11-13 12:52:49','0'),
(2578,1,'2017-11-13 13:53:13','2017-11-13 13:53:28','0'),
(2579,1,'2017-11-13 14:00:43','2017-11-13 14:01:46','0'),
(2580,1,'2017-11-13 23:18:54','2017-11-13 23:20:30','0'),
(2581,1,'2017-11-16 10:10:15','0001-01-01 00:00:00','0'),
(2582,1,'2017-11-16 11:30:57','0001-01-01 00:00:00','0'),
(2583,1,'2017-11-16 12:48:28','2017-11-16 12:48:35','0'),
(2584,1,'2017-11-16 13:06:50','2017-11-16 13:07:48','0'),
(2585,1,'2017-11-16 13:17:56','0001-01-01 00:00:00','0'),
(2586,1,'2017-11-16 13:19:25','2017-11-16 13:25:24','0'),
(2587,1,'2017-11-16 13:29:43','0001-01-01 00:00:00','0'),
(2588,1,'2017-11-16 13:30:12','2017-11-16 13:30:40','0'),
(2589,1,'2017-11-16 13:31:01','2017-11-16 13:31:21','0'),
(2590,1,'2017-11-16 13:50:21','0001-01-01 00:00:00','0'),
(2591,1,'2017-11-16 13:51:08','2017-11-16 13:51:24','0'),
(2592,1,'2017-11-16 13:51:30','0001-01-01 00:00:00','0'),
(2593,1,'2017-11-16 13:52:07','2017-11-16 13:52:25','0'),
(2594,1,'2017-11-16 13:52:53','2017-11-16 13:53:52','0'),
(2595,1,'2017-11-16 14:05:13','2017-11-16 14:05:17','0'),
(2596,1,'2017-11-18 11:27:24','2017-11-18 12:26:12','0'),
(2597,1,'2017-11-19 12:26:24','2017-11-19 12:26:40','0'),
(2598,1,'2017-11-24 17:10:32','2017-11-24 17:10:56','0'),
(2599,1,'2017-11-24 17:13:25','0001-01-01 00:00:00','0'),
(2600,1,'2017-11-24 17:27:30','2017-11-24 17:32:25','0'),
(2601,1,'2017-11-24 17:36:21','0001-01-01 00:00:00','0'),
(2602,1,'2017-11-24 18:03:38','2017-11-24 18:03:55','0'),
(2603,1,'2017-11-24 18:04:05','0001-01-01 00:00:00','0'),
(2604,1,'2017-11-24 18:10:29','2017-11-24 18:10:45','0'),
(2605,1,'2017-11-24 18:10:58','0001-01-01 00:00:00','0'),
(2606,1,'2017-11-24 18:22:47','0001-01-01 00:00:00','0'),
(2607,1,'2017-11-24 18:25:58','2017-11-24 18:27:15','0'),
(2608,1,'2018-03-14 09:49:29','2018-03-14 09:50:28','0'),
(2609,1,'2018-03-14 09:53:17','0001-01-01 00:00:00','0'),
(2610,1,'2018-03-14 15:41:13','0001-01-01 00:00:00','0'),
(2611,1,'2018-03-14 15:52:57','0001-01-01 00:00:00','0'),
(2612,1,'2018-03-14 15:54:25','0001-01-01 00:00:00','0'),
(2613,1,'2018-03-14 15:57:47','0001-01-01 00:00:00','0'),
(2614,1,'2018-03-14 16:16:23','2018-03-14 16:19:59','0'),
(2615,1,'2018-03-14 16:20:11','2018-03-14 16:23:35','0'),
(2616,1,'2018-05-04 11:44:10','0001-01-01 00:00:00','0'),
(2617,1,'2018-05-04 12:05:58','0001-01-01 00:00:00','0'),
(2618,1,'2018-05-04 12:07:59','2018-05-04 12:16:05','0'),
(2619,1,'2018-05-04 12:31:43','0001-01-01 00:00:00','0'),
(2620,1,'2018-05-04 12:41:45','2018-05-04 12:42:42','0'),
(2621,1,'2018-05-04 12:44:38','2018-05-04 12:44:43','0'),
(2622,1,'2018-05-04 12:54:06','0001-01-01 00:00:00','0'),
(2623,1,'2018-05-04 15:17:13','2018-05-04 15:17:34','0'),
(2624,1,'2018-05-04 15:17:41','2018-05-04 15:18:42','0'),
(2625,1,'2018-05-04 15:18:48','2018-05-04 15:18:54','0'),
(2626,1,'2018-05-04 15:19:34','2018-05-04 15:19:51','0'),
(2627,1,'2018-05-04 15:19:58','2018-05-04 15:20:02','0'),
(2628,1,'2018-05-04 15:20:19','0001-01-01 00:00:00','0'),
(2629,1,'2018-05-04 15:20:34','0001-01-01 00:00:00','0'),
(2630,1,'2018-05-04 15:20:46','2018-05-04 15:20:49','0'),
(2631,1,'2018-05-04 15:20:56','2018-05-04 15:20:59','0'),
(2632,1,'2018-05-04 15:21:06','2018-05-04 15:21:09','0'),
(2633,1,'2018-05-04 16:36:55',NULL,'1'),
(2634,1,'2018-05-04 17:22:28',NULL,'1'),
(2635,1,'2018-05-04 17:23:52',NULL,'1'),
(2636,1,'2018-05-04 17:31:18',NULL,'1'),
(2637,1,'2018-05-04 17:33:01',NULL,'1'),
(2638,1,'2018-05-04 17:51:23',NULL,'1'),
(2639,1,'2018-05-04 17:57:49','2018-05-04 17:59:12','0'),
(2640,1,'2018-06-23 11:17:04','2018-06-23 11:18:32','0'),
(2641,1,'2018-06-23 11:18:38',NULL,'1'),
(2642,1,'2018-06-23 11:38:28',NULL,'1'),
(2643,1,'2018-06-23 11:50:36','2018-06-23 11:51:19','0'),
(2644,1,'2018-06-23 11:52:13','2018-06-23 11:55:39','0'),
(2645,1,'2018-06-23 11:56:04','2018-06-23 11:56:28','0'),
(2646,1,'2018-06-23 11:57:43','2018-06-23 11:58:04','0'),
(2647,1,'2018-06-23 11:58:38',NULL,'1'),
(2648,1,'2018-06-23 12:00:56',NULL,'1'),
(2649,1,'2018-06-23 12:03:56',NULL,'1'),
(2650,1,'2018-06-23 12:07:11',NULL,'1'),
(2651,1,'2018-06-23 12:10:28',NULL,'1'),
(2652,1,'2018-06-23 12:14:27',NULL,'1'),
(2653,1,'2018-06-23 12:16:24',NULL,'1'),
(2654,1,'2018-06-23 12:23:22',NULL,'1'),
(2655,1,'2018-06-23 12:25:28',NULL,'1'),
(2656,1,'2018-06-23 12:29:37',NULL,'1'),
(2657,1,'2018-06-23 12:30:29',NULL,'1'),
(2658,1,'2018-06-23 14:55:48','2018-06-23 14:56:52','0'),
(2659,1,'2018-06-24 11:18:10',NULL,'1'),
(2660,1,'2018-06-24 11:19:10',NULL,'1'),
(2661,1,'2018-06-24 11:27:37',NULL,'1'),
(2662,1,'2018-06-24 11:33:37',NULL,'1'),
(2663,1,'2018-06-24 11:36:40',NULL,'1'),
(2664,1,'2018-06-24 11:48:03',NULL,'1'),
(2665,1,'2018-06-24 11:52:00',NULL,'1'),
(2666,1,'2018-06-24 11:53:36',NULL,'1'),
(2667,1,'2018-06-24 11:56:24',NULL,'1'),
(2668,1,'2018-06-24 11:58:31',NULL,'1'),
(2669,1,'2018-06-24 12:11:27',NULL,'1'),
(2670,1,'2018-06-24 12:30:45',NULL,'1'),
(2671,1,'2018-06-24 12:31:28',NULL,'1'),
(2672,1,'2018-06-24 12:36:12',NULL,'1'),
(2673,1,'2018-06-24 13:54:43',NULL,'1'),
(2674,1,'2018-06-24 13:55:17',NULL,'1'),
(2675,1,'2018-06-24 13:55:52',NULL,'1'),
(2676,1,'2018-06-24 13:56:27',NULL,'1'),
(2677,1,'2018-06-24 13:57:57',NULL,'1'),
(2678,1,'2018-06-24 13:58:29',NULL,'1'),
(2679,1,'2018-06-24 14:05:16','2018-06-24 14:07:12','0'),
(2680,1,'2018-06-24 14:22:32',NULL,'1'),
(2681,1,'2018-06-24 14:23:42',NULL,'1'),
(2682,1,'2018-06-24 14:24:51',NULL,'1'),
(2683,1,'2018-06-24 14:25:17',NULL,'1'),
(2684,1,'2018-06-24 14:43:08',NULL,'1'),
(2685,1,'2018-06-24 14:45:27',NULL,'1'),
(2686,1,'2018-06-24 14:48:30',NULL,'1'),
(2687,1,'2018-06-26 16:02:54',NULL,'1'),
(2688,1,'2018-06-26 16:03:24',NULL,'1'),
(2689,1,'2018-06-26 16:03:45',NULL,'1'),
(2690,1,'2018-06-26 16:05:24',NULL,'1'),
(2691,1,'2018-06-26 16:13:42',NULL,'1'),
(2692,1,'2018-06-26 16:15:33',NULL,'1'),
(2693,1,'2018-06-26 16:17:40',NULL,'1'),
(2694,1,'2018-06-26 16:27:12',NULL,'1'),
(2695,1,'2018-06-26 16:36:34',NULL,'1'),
(2696,1,'2018-06-26 16:40:24',NULL,'1'),
(2697,1,'2018-06-26 16:44:55',NULL,'1'),
(2698,1,'2018-06-26 16:45:34',NULL,'1'),
(2699,1,'2018-06-26 16:46:08',NULL,'1'),
(2700,1,'2018-06-26 17:06:55',NULL,'1'),
(2701,1,'2018-06-26 17:10:53','2018-06-26 17:14:52','0'),
(2702,1,'2018-06-26 19:03:08',NULL,'1'),
(2703,1,'2018-06-26 19:11:32',NULL,'1'),
(2704,1,'2018-06-26 19:14:59',NULL,'1'),
(2705,1,'2018-06-26 19:17:32',NULL,'1'),
(2706,1,'2018-06-26 19:24:31',NULL,'1'),
(2707,1,'2018-06-26 19:25:35',NULL,'1'),
(2708,1,'2018-06-26 19:31:26','2018-06-26 19:41:26','0'),
(2709,1,'2018-06-26 19:42:39',NULL,'1'),
(2710,1,'2018-06-27 10:19:31',NULL,'1'),
(2711,1,'2018-06-27 10:27:21',NULL,'1'),
(2712,1,'2018-06-27 10:29:12',NULL,'1'),
(2713,1,'2018-06-27 10:32:23','2018-06-27 10:33:16','0'),
(2714,1,'2018-06-27 10:38:29',NULL,'1'),
(2715,1,'2018-06-27 10:44:49',NULL,'1'),
(2716,1,'2018-06-27 10:45:55',NULL,'1'),
(2717,1,'2018-06-27 10:57:58',NULL,'1'),
(2718,1,'2018-06-27 11:22:22',NULL,'1'),
(2719,1,'2018-06-27 11:27:41',NULL,'1'),
(2720,1,'2018-06-27 11:32:13',NULL,'1'),
(2721,1,'2018-06-27 11:40:05',NULL,'1'),
(2722,1,'2018-06-27 11:42:06',NULL,'1'),
(2723,1,'2018-06-27 11:42:36',NULL,'1'),
(2724,1,'2018-06-27 11:43:47',NULL,'1'),
(2725,1,'2018-06-27 11:45:02',NULL,'1'),
(2726,1,'2018-06-27 11:46:53',NULL,'1'),
(2727,1,'2018-06-27 11:48:10',NULL,'1'),
(2728,1,'2018-06-27 11:54:06','2018-06-27 11:54:53','0'),
(2729,1,'2018-06-27 15:44:15','2018-06-27 15:54:36','0'),
(2730,1,'2018-06-27 16:24:58','2018-06-27 16:36:24','0'),
(2731,1,'2018-06-28 07:17:53','2018-06-28 07:18:24','0'),
(2732,1,'2018-06-29 08:48:40',NULL,'1'),
(2733,1,'2018-06-29 09:41:31',NULL,'1'),
(2734,1,'2018-06-29 09:45:29',NULL,'1'),
(2735,1,'2018-06-29 09:47:47',NULL,'1'),
(2736,1,'2018-06-29 09:48:40',NULL,'1'),
(2737,1,'2018-06-29 09:50:14',NULL,'1'),
(2738,1,'2018-06-29 09:51:44',NULL,'1'),
(2739,1,'2018-06-29 09:53:06',NULL,'1'),
(2740,1,'2018-06-29 09:57:30',NULL,'1'),
(2741,1,'2018-06-29 09:58:03',NULL,'1'),
(2742,1,'2018-06-29 10:02:26',NULL,'1'),
(2743,1,'2018-06-29 10:26:35','2018-06-29 11:05:22','0'),
(2744,1,'2018-06-29 11:26:39',NULL,'1'),
(2745,1,'2018-06-29 11:28:08',NULL,'1'),
(2746,1,'2018-06-29 11:30:13',NULL,'1'),
(2747,1,'2018-06-29 11:31:54','2018-06-29 11:34:17','0'),
(2748,1,'2018-06-29 16:36:07','2018-06-29 16:36:19','0'),
(2749,1,'2018-07-06 15:56:27','2018-07-06 16:05:24','0'),
(2750,1,'2018-07-09 10:01:20',NULL,'1'),
(2751,1,'2018-07-09 10:15:01',NULL,'1'),
(2752,1,'2018-07-09 10:27:55',NULL,'1'),
(2753,1,'2018-07-09 10:31:50',NULL,'1'),
(2754,1,'2018-07-09 10:36:29',NULL,'1'),
(2755,1,'2018-07-09 10:40:45',NULL,'1'),
(2756,1,'2018-07-09 10:52:50',NULL,'1'),
(2757,1,'2018-07-09 10:53:43',NULL,'1'),
(2758,1,'2018-07-09 11:00:11',NULL,'1'),
(2759,1,'2018-07-09 11:09:03',NULL,'1'),
(2760,1,'2018-07-09 11:12:44',NULL,'1'),
(2761,1,'2018-07-09 11:13:47',NULL,'1'),
(2762,1,'2018-07-09 11:15:55',NULL,'1'),
(2763,1,'2018-07-09 11:23:11',NULL,'1'),
(2764,1,'2018-07-09 11:27:35',NULL,'1'),
(2765,1,'2018-07-09 11:28:29',NULL,'1'),
(2766,1,'2018-07-09 11:37:56',NULL,'1'),
(2767,1,'2018-07-09 11:41:50',NULL,'1'),
(2768,1,'2018-07-09 11:45:49',NULL,'1'),
(2769,1,'2018-07-09 11:48:22','2018-07-09 11:54:48','0'),
(2770,1,'2018-07-10 22:12:36',NULL,'1'),
(2771,1,'2018-07-10 22:14:00',NULL,'1'),
(2772,1,'2018-07-10 22:15:12',NULL,'1'),
(2773,1,'2018-07-10 22:19:34',NULL,'1'),
(2774,1,'2018-07-10 22:20:48',NULL,'1'),
(2775,1,'2018-07-11 20:10:57','2018-07-11 20:11:59','0'),
(2776,1,'2018-07-11 20:12:35','2018-07-11 20:13:19','0'),
(2777,1,'2018-07-11 20:20:06',NULL,'1'),
(2778,1,'2018-07-11 20:22:32',NULL,'1'),
(2779,1,'2018-07-11 20:23:58',NULL,'1'),
(2780,1,'2018-07-11 20:26:31',NULL,'1'),
(2781,1,'2018-07-11 20:28:54','2018-07-11 20:29:25','0'),
(2782,1,'2018-07-11 20:39:04','2018-07-11 20:41:05','0'),
(2783,1,'2018-07-13 14:49:57','2018-07-13 14:51:08','0'),
(2784,1,'2018-07-13 15:07:20','2018-07-13 16:05:14','0'),
(2785,1,'2018-07-13 17:05:56',NULL,'1'),
(2786,1,'2018-07-13 17:08:52',NULL,'1'),
(2787,1,'2018-07-19 18:58:13',NULL,'1'),
(2788,1,'2018-07-19 19:00:12','2018-07-19 19:05:01','0'),
(2789,1,'2018-07-19 19:17:28',NULL,'1'),
(2790,1,'2018-07-19 19:49:14','2018-07-19 20:05:31','0'),
(2791,1,'2018-07-19 20:06:04',NULL,'1'),
(2792,1,'2018-07-19 22:05:33','2018-07-19 22:05:40','0'),
(2793,1,'2018-07-19 22:08:24',NULL,'1'),
(2794,1,'2018-07-19 22:11:49','2018-07-19 22:15:05','0'),
(2795,1,'2018-07-20 10:54:33',NULL,'1'),
(2796,1,'2018-07-20 12:39:46',NULL,'1'),
(2797,1,'2018-07-20 12:42:50',NULL,'1'),
(2798,1,'2018-07-20 12:49:11','2018-07-20 12:55:22','0'),
(2799,1,'2018-07-20 16:24:26','2018-07-20 16:34:27','0'),
(2800,1,'2018-07-20 16:36:20','2018-07-20 16:36:59','0'),
(2801,1,'2018-07-20 16:52:24','2018-07-20 16:58:14','0'),
(2802,1,'2018-07-20 17:24:34','2018-07-20 17:27:11','0'),
(2803,1,'2018-07-25 20:53:59','2018-07-25 20:54:37','0'),
(2804,1,'2018-07-25 20:54:44','2018-07-25 20:55:13','0'),
(2805,1,'2018-07-31 13:37:50','2018-07-31 13:47:55','0'),
(2806,1,'2018-07-31 13:51:40','2018-07-31 13:52:26','0'),
(2807,1,'2018-07-31 13:52:39','2018-07-31 13:56:26','0'),
(2808,1,'2018-07-31 13:59:15','2018-07-31 13:59:50','0'),
(2809,1,'2018-07-31 14:00:03','2018-07-31 14:00:23','0'),
(2810,1,'2018-07-31 14:00:35','2018-07-31 14:02:04','0'),
(2811,1,'2018-07-31 14:02:19','2018-07-31 14:03:04','0'),
(2812,1,'2018-07-31 14:03:20','2018-07-31 14:30:50','0'),
(2813,1,'2018-08-09 10:35:12','2018-08-09 11:26:37','0'),
(2814,1,'2018-08-09 11:42:22',NULL,'1'),
(2815,1,'2018-08-09 11:46:20',NULL,'1'),
(2816,1,'2018-08-09 11:53:00',NULL,'1'),
(2817,1,'2018-08-13 10:49:20',NULL,'1'),
(2818,1,'2018-08-13 10:57:27',NULL,'1'),
(2819,1,'2018-08-13 11:01:49',NULL,'1'),
(2820,1,'2018-08-13 11:04:10',NULL,'1'),
(2821,1,'2018-08-13 11:05:32',NULL,'1'),
(2822,1,'2018-08-13 11:09:59',NULL,'1'),
(2823,1,'2018-08-13 11:16:34',NULL,'1'),
(2824,1,'2018-08-13 11:18:44',NULL,'1'),
(2825,1,'2018-08-13 11:20:23',NULL,'1'),
(2826,1,'2018-08-13 11:21:38',NULL,'1'),
(2827,1,'2018-08-13 11:30:36',NULL,'1'),
(2828,1,'2018-08-13 11:34:44',NULL,'1'),
(2829,1,'2018-08-13 11:40:33',NULL,'1'),
(2830,1,'2018-08-13 11:46:57',NULL,'1'),
(2831,1,'2018-08-13 11:49:03',NULL,'1'),
(2832,1,'2018-08-13 11:50:26',NULL,'1'),
(2833,1,'2018-08-13 11:51:24',NULL,'1'),
(2834,1,'2018-08-13 11:54:23',NULL,'1'),
(2835,1,'2018-08-13 11:55:17',NULL,'1'),
(2836,1,'2018-08-13 11:56:09',NULL,'1'),
(2837,1,'2018-08-13 12:00:06',NULL,'1'),
(2838,1,'2018-08-13 15:04:09',NULL,'1'),
(2839,1,'2018-08-13 15:05:24',NULL,'1'),
(2840,1,'2018-08-13 15:19:29',NULL,'1'),
(2841,1,'2018-08-13 15:29:28',NULL,'1'),
(2842,1,'2018-08-13 15:34:06',NULL,'1'),
(2843,1,'2018-08-13 16:19:48',NULL,'1'),
(2844,1,'2018-08-13 16:21:01',NULL,'1'),
(2845,1,'2018-08-13 16:25:24',NULL,'1'),
(2846,1,'2018-08-13 16:26:52',NULL,'1'),
(2847,1,'2018-08-13 16:28:26',NULL,'1'),
(2848,1,'2018-08-13 16:34:19',NULL,'1'),
(2849,1,'2018-08-13 16:36:09',NULL,'1'),
(2850,1,'2018-08-13 16:41:35',NULL,'1'),
(2851,1,'2018-08-13 16:43:09',NULL,'1'),
(2852,1,'2018-08-13 16:44:46',NULL,'1'),
(2853,1,'2018-08-13 16:47:29',NULL,'1'),
(2854,1,'2018-08-13 16:52:17',NULL,'1'),
(2855,1,'2018-08-13 16:53:33',NULL,'1'),
(2856,1,'2018-08-13 16:59:08',NULL,'1'),
(2857,1,'2018-08-13 17:08:38',NULL,'1'),
(2858,1,'2018-08-13 17:10:21',NULL,'1'),
(2859,1,'2018-08-13 17:18:50',NULL,'1'),
(2860,1,'2018-08-13 17:19:46',NULL,'1'),
(2861,1,'2018-08-13 17:20:51',NULL,'1'),
(2862,1,'2018-08-13 17:21:38',NULL,'1'),
(2863,1,'2018-08-13 17:22:31',NULL,'1'),
(2864,1,'2018-08-13 17:23:30',NULL,'1'),
(2865,1,'2018-08-13 17:24:21',NULL,'1'),
(2866,1,'2018-08-13 17:26:34',NULL,'1'),
(2867,1,'2018-08-13 17:27:46',NULL,'1'),
(2868,1,'2018-08-13 17:28:55',NULL,'1'),
(2869,1,'2018-08-13 17:29:58',NULL,'1'),
(2870,1,'2018-08-13 17:34:13','2018-08-13 17:36:13','0'),
(2871,1,'2018-08-13 17:44:52','2018-08-13 17:46:37','0'),
(2872,1,'2018-08-13 17:48:46','2018-08-13 17:49:23','0'),
(2873,1,'2018-08-13 22:00:10',NULL,'1'),
(2874,1,'2018-08-13 22:11:51',NULL,'1'),
(2875,1,'2018-08-13 22:38:50',NULL,'1'),
(2876,1,'2018-08-13 22:54:53',NULL,'1'),
(2877,1,'2018-08-13 22:56:14',NULL,'1'),
(2878,1,'2018-08-13 23:05:32',NULL,'1'),
(2879,1,'2018-08-13 23:06:21',NULL,'1'),
(2880,1,'2018-08-13 23:10:41',NULL,'1'),
(2881,1,'2018-08-13 23:12:44',NULL,'1'),
(2882,1,'2018-08-13 23:17:19','2018-08-13 23:19:15','0'),
(2883,1,'2018-08-14 08:46:31','2018-08-14 08:50:35','0'),
(2884,1,'2018-08-14 10:02:10',NULL,'1'),
(2885,1,'2018-08-14 10:05:58',NULL,'1'),
(2886,1,'2018-08-14 10:09:01','2018-08-14 10:09:39','0'),
(2887,1,'2018-08-14 10:09:46',NULL,'1'),
(2888,1,'2018-08-14 10:10:14','2018-08-14 10:10:17','0'),
(2889,1,'2018-08-14 10:24:52',NULL,'1'),
(2890,1,'2018-08-14 10:29:36',NULL,'1'),
(2891,1,'2018-08-14 10:41:54',NULL,'1'),
(2892,1,'2018-08-14 10:45:52',NULL,'1'),
(2893,1,'2018-08-14 10:51:52',NULL,'1'),
(2894,1,'2018-08-14 10:54:01',NULL,'1'),
(2895,1,'2018-08-14 11:01:29',NULL,'1'),
(2896,1,'2018-08-14 11:05:06',NULL,'1'),
(2897,1,'2018-08-14 11:06:45',NULL,'1'),
(2898,1,'2018-08-14 11:10:29',NULL,'1'),
(2899,1,'2018-08-14 11:12:59','2018-08-14 11:19:54','0'),
(2900,1,'2018-08-20 08:36:54','2018-08-20 08:40:46','0'),
(2901,1,'2018-11-20 21:33:59','2018-11-20 21:37:52','0'),
(2902,1,'2018-11-20 21:38:04',NULL,'1'),
(2903,1,'2018-11-20 21:54:02','2018-11-20 22:00:23','0'),
(2904,1,'2018-11-20 22:01:16','2018-11-20 22:02:15','0'),
(2905,1,'2018-11-20 22:03:52',NULL,'1'),
(2906,1,'2018-11-20 22:06:37','2018-11-20 22:07:39','0'),
(2907,1,'2018-11-20 22:07:56','2018-11-20 22:13:40','0');
/*!40000 ALTER TABLE `sesion` ENABLE KEYS */;

-- 
-- Definition of tarjeta_credito
-- 

DROP TABLE IF EXISTS `tarjeta_credito`;
CREATE TABLE IF NOT EXISTS `tarjeta_credito` (
  `idTarjeta` int(3) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  `tipo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idTarjeta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tarjeta_credito
-- 

/*!40000 ALTER TABLE `tarjeta_credito` DISABLE KEYS */;
INSERT INTO `tarjeta_credito`(`idTarjeta`,`descripcion`,`tipo`) VALUES
(1,'VISA','LOCAL'),
(2,'MASTERCARD','LOCAL'),
(3,'American EXpress','Internacional');
/*!40000 ALTER TABLE `tarjeta_credito` ENABLE KEYS */;

-- 
-- Definition of ticket
-- 

DROP TABLE IF EXISTS `ticket`;
CREATE TABLE IF NOT EXISTS `ticket` (
  `idTicket` int(2) NOT NULL AUTO_INCREMENT,
  `showEmpresa` tinyint(1) DEFAULT NULL,
  `showSlogan` tinyint(1) DEFAULT NULL,
  `showDireccion` tinyint(1) DEFAULT NULL,
  `showTelefono` tinyint(1) DEFAULT NULL,
  `showSaludo` tinyint(1) DEFAULT NULL,
  `showNRC` tinyint(1) DEFAULT NULL,
  `showNIT` tinyint(1) DEFAULT NULL,
  `numAutorizacion` tinyint(1) DEFAULT NULL,
  `extraLine` tinyint(1) NOT NULL,
  `header1` varchar(75) NOT NULL,
  `header2` varchar(75) NOT NULL,
  `header3` varchar(75) NOT NULL,
  `footer1` varchar(75) NOT NULL,
  `footer2` varchar(75) NOT NULL,
  `footer3` varchar(75) NOT NULL,
  `seCortePapel` varchar(75) NOT NULL,
  `leftMargin` int(2) NOT NULL,
  `nCaracteres` int(2) NOT NULL,
  PRIMARY KEY (`idTicket`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table ticket
-- 

/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket`(`idTicket`,`showEmpresa`,`showSlogan`,`showDireccion`,`showTelefono`,`showSaludo`,`showNRC`,`showNIT`,`numAutorizacion`,`extraLine`,`header1`,`header2`,`header3`,`footer1`,`footer2`,`footer3`,`seCortePapel`,`leftMargin`,`nCaracteres`) VALUES
(1,1,1,1,1,0,1,1,1,0,'','','','Nuestros precios incluyen IVA','','Gracias por tu visita','',0,42);
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;

-- 
-- Definition of tiraje_factura
-- 

DROP TABLE IF EXISTS `tiraje_factura`;
CREATE TABLE IF NOT EXISTS `tiraje_factura` (
  `idTiraje` int(5) NOT NULL AUTO_INCREMENT,
  `tipoFactura` enum('CONSUMIDOR FINAL','CRÉDITO FISCAL') NOT NULL,
  `serie` varchar(15) NOT NULL,
  `inicio` int(6) NOT NULL,
  `fin` int(6) NOT NULL,
  `actual` int(6) NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`idTiraje`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tiraje_factura
-- 

/*!40000 ALTER TABLE `tiraje_factura` DISABLE KEYS */;
INSERT INTO `tiraje_factura`(`idTiraje`,`tipoFactura`,`serie`,`inicio`,`fin`,`actual`,`activo`) VALUES
(1,'CONSUMIDOR FINAL','SKLS7',1,5000,4,1);
/*!40000 ALTER TABLE `tiraje_factura` ENABLE KEYS */;

-- 
-- Definition of unidadmedida
-- 

DROP TABLE IF EXISTS `unidadmedida`;
CREATE TABLE IF NOT EXISTS `unidadmedida` (
  `idUnidad` int(3) NOT NULL AUTO_INCREMENT,
  `unidadMedida` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table unidadmedida
-- 

/*!40000 ALTER TABLE `unidadmedida` DISABLE KEYS */;
INSERT INTO `unidadmedida`(`idUnidad`,`unidadMedida`) VALUES
(1,'Unidad'),
(2,'Onzas'),
(3,'Caja'),
(5,'Libras'),
(6,'Litros'),
(7,'Bidon'),
(8,'1/4 GalÃ³n'),
(9,'1 GalÃ³n'),
(10,'Botella'),
(11,'Lata'),
(12,'1/2 GALÓN'),
(13,'Bolsa'),
(14,'Bote'),
(15,'Paquete');
/*!40000 ALTER TABLE `unidadmedida` ENABLE KEYS */;

-- 
-- Definition of usuario
-- 

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int(3) NOT NULL,
  `idRol` int(2) NOT NULL,
  `pinCode` varchar(35) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `fk_empl_usr` (`idUsuario`),
  KEY `fk_rol_usr_1` (`idRol`),
  CONSTRAINT `fk_empl_usr` FOREIGN KEY (`idUsuario`) REFERENCES `empleado` (`idEmpleado`) ON UPDATE CASCADE,
  CONSTRAINT `fk_rol_usr_1` FOREIGN KEY (`idRol`) REFERENCES `rol` (`idRol`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table usuario
-- 

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario`(`idUsuario`,`idRol`,`pinCode`) VALUES
(1,1,'1e8c391abfde9abea82d75a2d60278d4'),
(15,2,'8004d637b6236202217be3dfcdd8ce59'),
(16,1,'67ad4113ae200c56e74d7177b37d9469'),
(17,2,'3f088ebeda03513be71d34d214291986'),
(20,2,'3b92d18aa7a6176dd37d372bc2f1eb71'),
(21,2,'8844c5f00372df2c3c4ee857c2451b45'),
(22,2,'07dbd9a180c7cc69cada7b982c5ae82c'),
(23,2,'82039d16dce0aab3913b6a7ac73deff7'),
(24,2,'4a08142c38dbe374195d41c04562d9f8'),
(26,2,'dd7970532bfa1449085b8f43fc39a7d5'),
(27,2,'97d98119037c5b8a9663cb21fb8ebf47'),
(29,2,'8b5700012be65c9da25f49408d959ca0'),
(31,2,'8f2f470bb9d82081f256a839f1cc8f6c');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-11-28 21:07:14
-- Total time: 0:0:0:0:389 (d:h:m:s:ms)
