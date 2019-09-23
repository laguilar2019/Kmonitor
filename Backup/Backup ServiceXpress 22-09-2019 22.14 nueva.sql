-- MySqlBackup.NET 2.0.12
-- Dump Time: 2019-09-22 22:14:48
-- --------------------------------------
-- Server version 10.1.16-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of admin
-- 

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `gender` char(1) NOT NULL,
  `dob` date NOT NULL,
  `relationship` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `mobile` varchar(11) NOT NULL,
  `login_id` varchar(255) NOT NULL,
  `pwd` varchar(32) NOT NULL,
  `lastlogin` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`login_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table admin
-- 

/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin`(`id`,`name`,`gender`,`dob`,`relationship`,`department`,`address`,`mobile`,`login_id`,`pwd`,`lastlogin`) VALUES
(1,'admin','M','1994-01-01 00:00:00','unmarried','developer','globsyn kolkata','18003004000','tusolutionweb','tusolutionweb','0001-01-01 00:00:00');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;

-- 
-- Definition of ajuste_stock
-- 

DROP TABLE IF EXISTS `ajuste_stock`;
CREATE TABLE IF NOT EXISTS `ajuste_stock` (
  `idAjuste` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(6) DEFAULT NULL,
  `idIngrediente` int(4) DEFAULT NULL,
  `tipoAjuste` enum('INCREMENTAR','DECREMENTAR') NOT NULL,
  `cantidad` decimal(10,2) NOT NULL,
  `justificacion` varchar(300) NOT NULL,
  `fecha` date NOT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  PRIMARY KEY (`idAjuste`),
  KEY `idx_ajuste_producto` (`idProducto`),
  KEY `idx_ajuste_ingrediente` (`idIngrediente`) USING BTREE,
  KEY `idx_ajuste_usuario` (`idUsuario`) USING BTREE,
  CONSTRAINT `fk_ajusteStock_ingrediente` FOREIGN KEY (`idIngrediente`) REFERENCES `ingrediente` (`idIngrediente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ajusteStock_producto` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ajusteStock_usuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table ajuste_stock
-- 

/*!40000 ALTER TABLE `ajuste_stock` DISABLE KEYS */;
INSERT INTO `ajuste_stock`(`idAjuste`,`idProducto`,`idIngrediente`,`tipoAjuste`,`cantidad`,`justificacion`,`fecha`,`idUsuario`) VALUES
(1,119,NULL,'DECREMENTAR',1.00,'producto vencido','2019-08-18 00:00:00',1),
(2,38,NULL,'DECREMENTAR',10.00,'producto vencido ','2019-08-31 00:00:00',1),
(3,46,NULL,'INCREMENTAR',100.00,'Bono','2019-08-31 00:00:00',1);
/*!40000 ALTER TABLE `ajuste_stock` ENABLE KEYS */;

-- 
-- Definition of atm
-- 

DROP TABLE IF EXISTS `atm`;
CREATE TABLE IF NOT EXISTS `atm` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cust_name` varchar(255) NOT NULL,
  `account_no` int(10) NOT NULL,
  `atm_status` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table atm
-- 

/*!40000 ALTER TABLE `atm` DISABLE KEYS */;
INSERT INTO `atm`(`id`,`cust_name`,`account_no`,`atm_status`) VALUES
(15,'Rashid feroz',34,'ISSUED'),
(16,'ricardo gonzoles',44,'ISSUED');
/*!40000 ALTER TABLE `atm` ENABLE KEYS */;

-- 
-- Definition of beneficiary1
-- 

DROP TABLE IF EXISTS `beneficiary1`;
CREATE TABLE IF NOT EXISTS `beneficiary1` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `sender_id` int(10) NOT NULL,
  `sender_name` varchar(255) NOT NULL,
  `reciever_id` int(10) NOT NULL,
  `reciever_name` varchar(255) NOT NULL,
  `status` varchar(15) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table beneficiary1
-- 

/*!40000 ALTER TABLE `beneficiary1` DISABLE KEYS */;
INSERT INTO `beneficiary1`(`id`,`sender_id`,`sender_name`,`reciever_id`,`reciever_name`,`status`) VALUES
(21,34,'Rashid feroz',35,'Deepak rajwar','ACTIVE'),
(22,34,'Rashid feroz',36,'Shailesh kumar','ACTIVE'),
(23,36,'Shailesh kumar',34,'Rashid feroz','ACTIVE'),
(24,35,'Deepak rajwar',34,'Rashid feroz','ACTIVE'),
(25,34,'Rashid feroz',38,'isha dey','ACTIVE'),
(26,34,'Rashid feroz',44,'ricardo gonzoles','ACTIVE');
/*!40000 ALTER TABLE `beneficiary1` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table caja
-- 

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
INSERT INTO `caja`(`idCaja`,`idCajero`,`estado`,`fechaApertura`,`fechaCierre`,`saldoInicial`,`efectivo`,`saldo`) VALUES
(1,1,0,'2019-05-26 18:09:11','2019-09-22 21:40:41',50.00,2150.83,1978.15),
(2,32,0,'2019-09-22 21:41:03','2019-09-22 21:52:41',10.00,330.65,190.65),
(3,32,0,'2019-09-22 21:53:32','2019-09-22 21:57:00',20.00,535.33,455.33),
(4,32,1,'2019-09-22 22:14:20','0001-01-01 00:00:00',100.00,0.00,100.00);
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;

-- 
-- Definition of cheque_book
-- 

DROP TABLE IF EXISTS `cheque_book`;
CREATE TABLE IF NOT EXISTS `cheque_book` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cust_name` varchar(255) NOT NULL,
  `account_no` int(10) NOT NULL,
  `cheque_book_status` varchar(25) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table cheque_book
-- 

/*!40000 ALTER TABLE `cheque_book` DISABLE KEYS */;
INSERT INTO `cheque_book`(`id`,`cust_name`,`account_no`,`cheque_book_status`) VALUES
(8,'Rashid feroz',34,'ISSUED');
/*!40000 ALTER TABLE `cheque_book` ENABLE KEYS */;

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
(4,'M&M Solutions','San Salvador','solutions@yaoo.es','24510101','0212121','21212'),
(10,'Varios','Varios',NULL,NULL,NULL,NULL),
(11,'Centro Integral SA de CV','Sonsonate','centrosintegrales@elsalvador.com.sv','21454545','4512-126385-101-5','4455485555');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- 
-- Definition of cocinero
-- 

DROP TABLE IF EXISTS `cocinero`;
CREATE TABLE IF NOT EXISTS `cocinero` (
  `idCocinero` int(3) NOT NULL AUTO_INCREMENT,
  `tiempoOcuapdo` double NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=96 DEFAULT CHARSET=latin1;

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
(15,'Administrar categorÃ­as'),
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
(43,'AdministraciÃ³n cuentas'),
(50,'Empleados'),
(51,'Roles'),
(52,'Asignar roles'),
(53,'Comandos del sistema'),
(54,'Permisos'),
(55,'Visor de eventos '),
(56,'Administrar sesiones'),
(60,'Reportes avanzados y financieros'),
(61,'Reportes bÃ¡sicos'),
(62,'Reportes de Ventas diarias'),
(70,'Respaldo de BD'),
(71,'Restaurar respaldos'),
(72,'Vaciar BD'),
(80,'ConfiguraciÃ³n TPV'),
(81,'Administrar datos de la empresa'),
(82,'Configurar tickets'),
(83,'Tiraje de factura'),
(90,'Cambiar usuario'),
(91,'Monitor de cocina'),
(92,'Kardex'),
(93,'Flujo de efectivo'),
(94,'Configuraciones'),
(95,'Egresos');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table compra
-- 

/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra`(`idCompra`,`tipoCompra`,`idProveedor`,`idComprobante`,`nComprobante`,`idUsuario`,`fecha`,`total`,`descuento`,`iva`,`totalPago`) VALUES
(1,'PRODUCTOS',1,1,'1',1,'2019-07-13 11:53:39',9.90,0.00,0.00,9.90),
(2,'PRODUCTOS',1,1,'01',1,'2019-07-13 11:53:39',42.00,0.00,0.00,42.00),
(3,'PRODUCTOS',1,1,'2508',32,'2019-08-25 11:11:41',70.00,0.00,0.00,70.00),
(4,'PRODUCTOS',1,1,'2508-1',32,'2019-08-25 11:25:15',3.50,0.00,0.00,3.50),
(5,'PRODUCTOS',1,1,'2508-2',32,'2019-08-25 11:54:16',3.50,0.00,0.00,3.50),
(6,'PRODUCTOS',1,1,'2508-3',32,'2019-08-25 22:25:40',70.00,0.00,0.00,70.00),
(7,'PRODUCTOS',1,1,'10-09-5',32,'2019-09-10 21:32:44',1698.00,0.00,0.00,1698.00),
(8,'PRODUCTOS',1,1,'1109',32,'2019-09-11 09:45:34',284.70,0.00,0.00,284.70),
(9,'PRODUCTOS',1,1,'1109-1',32,'2019-09-11 09:48:38',350.00,0.00,0.00,350.00),
(10,'PRODUCTOS',1,1,'2009',32,'2019-09-20 15:57:35',3.50,0.00,0.00,3.50),
(11,'PRODUCTOS',1,1,'2009-1',32,'2019-09-20 16:01:18',3.50,0.00,0.00,3.50),
(12,'PRODUCTOS',1,1,'00023',32,'2019-09-22 14:19:17',70.00,0.00,0.00,70.00),
(13,'PRODUCTOS',1,1,'00234',32,'2019-09-22 21:47:45',70.00,0.00,0.00,70.00);
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table compra_detalle
-- 

/*!40000 ALTER TABLE `compra_detalle` DISABLE KEYS */;
INSERT INTO `compra_detalle`(`idDetalleCompra`,`idCompra`,`idProducto`,`idIngrediente`,`cantidad`,`precio`,`subTotal`) VALUES
(1,1,119,NULL,3,3.30,9.90),
(2,2,119,NULL,12,3.50,42.00),
(3,3,38,NULL,200,0.35,70.00),
(4,4,38,NULL,10,0.35,3.50),
(5,5,46,NULL,10,0.35,3.50),
(6,6,38,NULL,200,0.35,70.00),
(7,7,6,NULL,200,8.49,1698.00),
(8,8,7,NULL,30,9.49,284.70),
(9,9,7,NULL,100,3.50,350.00),
(10,10,38,NULL,10,0.35,3.50),
(11,11,38,NULL,10,0.35,3.50),
(12,12,38,NULL,200,0.35,70.00),
(13,13,119,NULL,200,0.35,70.00);
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
(1,1,1,10.00,1,13,5,0,'EPSON TM-U220 Receipt','WorkCentre 6605DN-55CBD6 PS','Microsoft Print to PDF',1,0,1);
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
(1,'Ventas en efectivo','4850000',3074.92),
(2,'Ventas tarjeta de credito','155550020221',0.00),
(3,'Pagos Mixtos(Efectivo + Tarjeta de CrÃ©dito)','55251515',0.00);
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

-- 
-- Definition of customer
-- 

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `gender` char(1) NOT NULL,
  `dob` date NOT NULL,
  `nominee` varchar(255) NOT NULL,
  `account` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `mobile` varchar(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `branch` varchar(255) NOT NULL,
  `ifsc` varchar(255) NOT NULL,
  `lastlogin` datetime NOT NULL,
  `accstatus` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table customer
-- 

/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer`(`id`,`name`,`gender`,`dob`,`nominee`,`account`,`address`,`mobile`,`email`,`password`,`branch`,`ifsc`,`lastlogin`,`accstatus`) VALUES
(34,'Rashid feroz','M','1993-12-30 00:00:00','ramu','savings','agapara','9999955555','rashid@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','KOLKATA','K421A','2018-03-10 01:07:54','ACTIVE'),
(35,'Deepak rajwar','M','1990-12-26 00:00:00','ramu','savings','agarpara','9999955556','deepak@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','DELHI','D30AC','2015-01-11 10:11:07','ACTIVE'),
(36,'Shailesh kumar','M','1993-06-26 00:00:00','ramu','savings','sodepur','9999955556','shailesh@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','BANGALORE','B6A9E','0001-01-01 00:00:00','ACTIVE'),
(37,'Ravi nandan','M','0001-01-01 00:00:00','ramu','savings','durgapur','9999955556','ravi@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','DELHI','D30AC','2015-01-11 10:18:57','ACTIVE'),
(38,'Isha dey','F','1990-12-26 00:00:00','ramu','savings','agarpara','9999955556','isha@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','KOLKATA','K421A','0001-01-01 00:00:00','ACTIVE'),
(39,'sunny kumar','M','2015-01-14 00:00:00','ramu','savings','agarpara','9804381248','sunny@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','DELHI','D30AC','2015-01-11 10:09:36','ACTIVE'),
(40,'Pankaj kumar','M','1996-02-18 00:00:00','Deepak','savings','agarpara','8956231245','pankaj@gmail.com','28a1b310b43643306f560bb161ff6b67f763c576','DELHI','D30AC','2015-01-11 09:42:43','ACTIVE'),
(41,'Sharique hassan','M','1993-12-26 00:00:00','ramu','savings','sodepur','8956231245','sarik@gmail.com','b638866443ed874cd5a9449a090cb8dce66e4a3a','KOLKATA','K421A','2015-01-11 10:27:48','ACTIVE'),
(42,'Alvan','F','0001-01-01 00:00:00','dhjh','savings','ff 65fv g6fkh','4590345678','cus@gmail.com','47757b7e69443b285397e078733f7caf187543bf','DELHI','D30AC','0001-01-01 00:00:00','ACTIVE'),
(43,'paul','M','0001-01-01 00:00:00','20','savings','gfgki fyh jf ','35853265','paul@gmail.com','a9b655984accdfd38498b2eb04be8ba65d033fd7','KOLKATA','K421A','0001-01-01 00:00:00','ACTIVE'),
(44,'ricardo gonzoles','M','2018-03-08 00:00:00','2222','ahorros','av panamericana','912233412','ricardo@gmail.com','b6ddbd11de1412952d8d2b8a756bafb1627a70af','KOLKATA','K421A','2018-03-10 01:05:19','ACTIVE');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;

-- 
-- Definition of egreso
-- 

DROP TABLE IF EXISTS `egreso`;
CREATE TABLE IF NOT EXISTS `egreso` (
  `idEgreso` int(11) NOT NULL AUTO_INCREMENT,
  `idEgresoTipo` int(3) DEFAULT NULL,
  `idCaja` int(11) DEFAULT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `cantidad` decimal(11,2) DEFAULT NULL,
  `nReferencia` varchar(20) NOT NULL,
  PRIMARY KEY (`idEgreso`),
  KEY `FK_idCaja2_idx` (`idCaja`),
  KEY `Fk_usr_egreso` (`idUsuario`) USING BTREE,
  KEY `Fk_egreso_tipo` (`idEgresoTipo`),
  CONSTRAINT `FK_idCaja2` FOREIGN KEY (`idCaja`) REFERENCES `caja` (`idCaja`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fk_egreso_tipo` FOREIGN KEY (`idEgresoTipo`) REFERENCES `egreso_tipo` (`idEgresoTipo`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `Fk_usr_egreso` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table egreso
-- 

/*!40000 ALTER TABLE `egreso` DISABLE KEYS */;
INSERT INTO `egreso`(`idEgreso`,`idEgresoTipo`,`idCaja`,`idUsuario`,`fecha`,`descripcion`,`cantidad`,`nReferencia`) VALUES
(1,2,1,1,'2019-06-07 22:27:04','Compra de azucar',2.50,''),
(2,3,1,1,'2019-06-07 22:50:37','ADELANTE SALARIAL PARA OSCAR SANCHEZ',20.00,''),
(3,1,1,1,'2019-06-07 23:00:06','ADELANTO DANIEL',15.20,''),
(4,3,1,1,'2019-06-09 10:53:11','SOLICITADO POR GABIREL',5.00,''),
(5,2,1,1,'2019-06-15 10:09:02','COMPRA DE VASOS DESECHABLES',2.00,''),
(6,4,1,1,'2019-06-15 10:09:50','RECIBO DE AGUA JUNIO',6.00,''),
(7,1,1,1,'2019-06-22 11:20:19','RICIBO DE LUZ',31.40,''),
(8,1,1,1,'2019-06-22 11:27:48','COMPRA DE CARNE ',20.00,''),
(9,2,1,1,'2019-06-22 11:29:24','COMPRA DE PAN ',10.00,''),
(10,4,1,1,'2019-07-13 09:34:03','PAGO DE LUZ',30.35,''),
(11,1,1,32,'2019-09-10 13:50:18','DSFSD',10.00,'324'),
(12,4,1,1,'2019-09-16 19:48:28','PAGO DE LUZ',20.00,'125'),
(13,3,1,1,'2019-09-16 19:49:17','EDENILSON',50.23,'154'),
(14,1,2,32,'2019-09-22 21:50:53','PAGOS',150.00,'27138'),
(15,4,3,32,'2019-09-22 21:56:15','LUZ',70.00,''),
(16,3,3,32,'2019-09-22 21:56:32','PEEDRO',30.00,'');
/*!40000 ALTER TABLE `egreso` ENABLE KEYS */;

-- 
-- Definition of egreso_tipo
-- 

DROP TABLE IF EXISTS `egreso_tipo`;
CREATE TABLE IF NOT EXISTS `egreso_tipo` (
  `idEgresoTipo` int(3) NOT NULL,
  `egresoTipo` varchar(255) NOT NULL,
  PRIMARY KEY (`idEgresoTipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table egreso_tipo
-- 

/*!40000 ALTER TABLE `egreso_tipo` DISABLE KEYS */;
INSERT INTO `egreso_tipo`(`idEgresoTipo`,`egresoTipo`) VALUES
(1,'SALARIOS'),
(2,'COMPRAS'),
(3,'ADELANTO DE SALARIO'),
(4,'PAGO DE SERVICIOS'),
(5,'PRUEBA');
/*!40000 ALTER TABLE `egreso_tipo` ENABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

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
(30,'Josseline','GÃ³mez','','','70707070','','',0.00,0.00),
(31,'JOSELINE','G','','','42564356','','',0.00,0.00),
(32,'Edenilson ','Siciliano','sonsonate','edenilson.sic@gmail.com','76630125','43243424','32134242344',500.00,20.00),
(33,'Luis','Aguilar','abc','laguilar@kmonitor.com.sv','12349875','1928374892','',300.00,100.00),
(34,'Gloria ','Aguilar','sonsonate','gloria@gmail.com','324255534','32142342','3242342',500.00,0.00);
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
(1,5,'AÃºcar',100.000,2.30);
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
) ENGINE=InnoDB AUTO_INCREMENT=268 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table logfile
-- 

/*!40000 ALTER TABLE `logfile` DISABLE KEYS */;
INSERT INTO `logfile`(`idLog`,`idSesion`,`idUsuario`,`fecha`,`log`,`estado`) VALUES
(1,3011,32,'2019-08-18 13:30:33','Vaciar la tabla LogFile completamente','Satisfactorio'),
(2,3011,32,'2019-08-18 13:47:31','Cierre de sesión','Satisfactorio'),
(5,3013,32,'2019-08-18 13:47:51','Inicio de sesión','Satisfactorio'),
(6,3013,32,'2019-08-18 13:47:55','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(7,3013,32,'2019-08-18 13:48:05','Cerró todas las sesiones activas','Satisfactorio'),
(8,3013,32,'2019-08-18 13:48:20','Eliminar registros LogFile','Satisfactorio'),
(9,3013,32,'2019-08-18 13:48:25','Eliminar registros LogFile','Satisfactorio'),
(10,3013,32,'2019-08-18 13:50:47','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(11,3013,32,'2019-08-18 13:51:02','Cierre de sesión','Satisfactorio'),
(12,3014,32,'2019-08-18 13:51:13','Inicio de sesión','Satisfactorio'),
(13,3014,32,'2019-08-18 13:51:18','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(14,3014,32,'2019-08-18 13:51:58','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(15,3014,32,'2019-08-18 14:06:54','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(16,3014,32,'2019-08-18 14:08:34','Ingreso a TPV','Satisfactorio'),
(17,3014,32,'2019-08-18 14:08:51','Agregar nueva venta con ID= 22','Satisfactorio'),
(18,3014,32,'2019-08-18 14:12:25','Ingreso a TPV','Satisfactorio'),
(19,3014,32,'2019-08-18 14:12:40','Agregar nueva venta con ID= 23','Satisfactorio'),
(20,3014,32,'2019-08-18 14:13:38','Todo el proceso de pago del pedido con ID: 23 ha finalizado','Satisfactorio'),
(21,3014,32,'2019-08-18 14:17:57','Agregar nueva venta con ID= 24','Satisfactorio'),
(22,3014,32,'2019-08-18 14:24:42','Todo el proceso de pago del pedido con ID: 24 ha finalizado','Satisfactorio'),
(23,3014,32,'2019-08-18 14:24:57','Agregar nueva venta con ID= 25','Satisfactorio'),
(24,3014,32,'2019-08-18 14:25:14','Todo el proceso de pago del pedido con ID: 25 ha finalizado','Satisfactorio'),
(25,3014,32,'2019-08-18 14:25:29','Agregar nueva venta con ID= 26','Satisfactorio'),
(26,3014,32,'2019-08-18 14:25:40','Todo el proceso de pago del pedido con ID: 26 ha finalizado','Satisfactorio'),
(27,3015,32,'2019-08-18 20:00:55','Inicio de sesión','Satisfactorio'),
(28,3015,32,'2019-08-18 20:01:01','Ingreso a TPV','Satisfactorio'),
(29,3015,32,'2019-08-18 20:01:11','Agregar nueva venta con ID= 27','Satisfactorio'),
(30,3015,32,'2019-08-18 20:02:04','Todo el proceso de pago del pedido con ID: 27 ha finalizado','Satisfactorio'),
(31,3015,32,'2019-08-18 20:02:45','Agregar nueva venta con ID= 28','Satisfactorio'),
(32,3015,32,'2019-08-18 20:03:30','Todo el proceso de pago del pedido con ID: 27 ha finalizado','Satisfactorio'),
(33,3015,32,'2019-08-18 20:04:26','Todo el proceso de pago del pedido con ID: 28 ha finalizado','Satisfactorio'),
(34,3015,32,'2019-08-18 20:25:01','Ingreso a TPV','Satisfactorio'),
(35,3015,32,'2019-08-18 20:25:29','Agregar nueva venta con ID= 29','Satisfactorio'),
(36,3015,32,'2019-08-18 21:16:31','Crear un perfil de usuario','Satisfactorio'),
(37,3015,32,'2019-08-18 21:18:04','Crear cuenta de usuario: Luis','Satisfactorio'),
(38,3015,32,'2019-08-18 21:18:17','Ingreso a la administración de permisos ','Satisfactorio'),
(39,3015,32,'2019-08-18 21:18:37','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(40,3015,32,'2019-08-18 21:20:40','Enrolar empleado: 33 Rol: 1','Satisfactorio'),
(41,3015,32,'2019-08-18 21:20:41','Otorgar permiso al comando: Luis Aguilar','Satisfactorio'),
(42,3015,32,'2019-08-18 21:20:58','Ingreso a la administración de permisos ','Satisfactorio'),
(43,3015,32,'2019-08-18 21:22:06','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(44,3015,32,'2019-08-18 21:22:41','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(45,3015,32,'2019-08-18 21:23:04','Ingreso a la administración de permisos ','Satisfactorio'),
(46,3015,32,'2019-08-18 21:26:16','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(47,3015,32,'2019-08-18 21:26:24','Ingreso a la administración de permisos ','Satisfactorio'),
(48,3015,32,'2019-08-18 21:26:48','Ingreso a la administración de comandos ','Satisfactorio'),
(49,3015,32,'2019-08-18 21:27:24','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(50,3015,32,'2019-08-18 21:27:31','Ingreso a la administración de comandos ','Satisfactorio'),
(51,3015,32,'2019-08-18 21:28:10','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(52,3015,32,'2019-08-18 21:30:59','Ingreso a la administración de permisos ','Satisfactorio'),
(53,3015,32,'2019-08-18 21:31:08','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(54,3015,32,'2019-08-18 21:31:15','Eliminar cuenta de usuario','Satisfactorio'),
(55,3015,32,'2019-08-18 21:31:15','Desenrolar usuario: Luis Aguilar','Satisfactorio'),
(56,3015,32,'2019-08-18 21:31:48','Enrolar empleado: 33 Rol: 4','Satisfactorio'),
(57,3015,32,'2019-08-18 21:31:48','Otorgar permiso al comando: Luis Aguilar','Satisfactorio'),
(58,3015,32,'2019-08-18 21:31:53','Ingreso a la administración de permisos ','Satisfactorio'),
(59,3015,32,'2019-08-18 21:33:25','Ingreso a la administración de comandos ','Satisfactorio'),
(60,3015,32,'2019-08-18 21:34:03','Agregar comando de sistema nuevo: Monitor de cocina','Satisfactorio'),
(61,3015,32,'2019-08-18 21:34:11','Agregar comando de sistema nuevo: Kardex','Satisfactorio'),
(62,3015,32,'2019-08-18 21:34:19','Agregar comando de sistema nuevo: Flujo de efectivo','Satisfactorio'),
(63,3015,32,'2019-08-18 21:34:24','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(64,3015,32,'2019-08-18 21:34:30','Ingreso a la administración de permisos ','Satisfactorio'),
(65,3015,32,'2019-08-18 21:34:51','Otorgar permiso al comando: Monitor de cocina','Satisfactorio'),
(66,3015,32,'2019-08-18 21:36:05','Ingreso a TPV','Satisfactorio'),
(67,3015,32,'2019-08-18 21:49:04','Ingreso a productos','Satisfactorio'),
(68,3015,32,'2019-08-18 21:49:17','Ingreso a productos','Satisfactorio'),
(69,3015,32,'2019-08-18 21:51:36','Ingreso a la administración de permisos ','Satisfactorio'),
(70,3015,32,'2019-08-18 21:51:43','Otorgar permiso al comando: Monitor de cocina','Satisfactorio'),
(71,3015,32,'2019-08-18 21:51:46','Otorgar permiso al comando: Kardex','Satisfactorio'),
(72,3015,32,'2019-08-18 21:51:48','Otorgar permiso al comando: Flujo de efectivo','Satisfactorio'),
(73,3015,32,'2019-08-18 21:52:26','Ingreso a la administración de permisos ','Satisfactorio'),
(74,3015,32,'2019-08-18 21:52:31','Ingreso a la administración de comandos ','Satisfactorio'),
(75,3015,32,'2019-08-18 21:52:58','Agregar comando de sistema nuevo: Configuraciones','Satisfactorio'),
(76,3015,32,'2019-08-18 21:53:09','Ingreso a la administración de permisos ','Satisfactorio'),
(77,3015,32,'2019-08-18 21:53:12','Otorgar permiso al comando: Configuraciones','Satisfactorio'),
(78,3015,32,'2019-08-18 21:55:23','Ingreso a la administración de comandos ','Satisfactorio'),
(79,3015,32,'2019-08-18 21:55:31','Agregar comando de sistema nuevo: Egresos','Satisfactorio'),
(80,3015,32,'2019-08-18 21:55:37','Ingreso a la administración de permisos ','Satisfactorio'),
(81,3015,32,'2019-08-18 21:55:39','Otorgar permiso al comando: Egresos','Satisfactorio'),
(82,3016,32,'2019-08-19 14:00:08','Inicio de sesión','Satisfactorio'),
(83,3016,32,'2019-08-19 14:00:12','Ingreso a TPV','Satisfactorio'),
(84,3016,32,'2019-08-19 14:00:24','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(85,3016,32,'2019-08-19 14:24:49','Ingreso a TPV','Satisfactorio'),
(86,3017,32,'2019-08-23 18:54:56','Inicio de sesión','Satisfactorio'),
(87,3017,32,'2019-08-23 18:55:07','Ingreso a TPV','Satisfactorio'),
(88,3017,32,'2019-08-23 18:55:20','Agregar nueva venta con ID= 30','Satisfactorio'),
(89,3017,32,'2019-08-23 19:16:11','Todo el proceso de pago del pedido con ID: 30 ha finalizado','Satisfactorio'),
(90,3017,32,'2019-08-23 19:17:22','Todo el proceso de pago del pedido con ID: 19 ha finalizado','Satisfactorio'),
(91,3017,32,'2019-08-23 19:18:44','Todo el proceso de pago del pedido con ID: 22 ha finalizado','Satisfactorio'),
(92,3017,32,'2019-08-23 19:19:42','Agregar nueva venta con ID= 31','Satisfactorio'),
(93,3017,32,'2019-08-23 19:20:57','Todo el proceso de pago del pedido con ID: 31 ha finalizado','Satisfactorio'),
(94,3017,32,'2019-08-23 19:22:57','Crear cuenta de usuario: Gloria ','Satisfactorio'),
(95,3017,32,'2019-08-23 19:23:24','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(96,3017,32,'2019-08-23 19:24:08','Enrolar empleado: 34 Rol: 5','Satisfactorio'),
(97,3017,32,'2019-08-23 19:24:08','Otorgar permiso al comando: Gloria  Aguilar','Satisfactorio'),
(98,3017,32,'2019-08-23 19:24:14','Ingreso a la administración de permisos ','Satisfactorio'),
(99,3017,32,'2019-08-23 19:25:56','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(100,3017,32,'2019-08-23 19:26:51','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(101,3017,32,'2019-08-23 19:26:57','Ingreso a la administración de comandos ','Satisfactorio'),
(102,3017,32,'2019-08-23 19:27:12','Ingreso a la administración de permisos ','Satisfactorio'),
(103,3017,32,'2019-08-23 19:27:32','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(104,3017,32,'2019-08-23 19:28:18','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(105,3017,32,'2019-08-23 19:29:24','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(106,3018,34,'2019-08-23 19:29:46','Inicio de sesión','Satisfactorio'),
(107,3017,32,'2019-08-23 19:29:46','Cerrar sesión','Satisfactorio'),
(108,3018,34,'2019-08-23 19:30:42','Cierre de sesión','Satisfactorio'),
(109,3019,32,'2019-08-23 19:31:00','Inicio de sesión','Satisfactorio'),
(110,3019,32,'2019-08-23 19:33:23','Ingreso a la administración de sesiones de usuarios ','Satisfactorio'),
(111,3019,32,'2019-08-23 19:33:30','Ingreso a la administración de permisos ','Satisfactorio'),
(112,3019,32,'2019-08-23 19:33:41','Ingreso a la administración de enrolar usuarios','Satisfactorio'),
(113,3019,32,'2019-08-23 19:33:47','Ingreso a la administración de permisos ','Satisfactorio'),
(114,3019,32,'2019-08-23 19:34:21','Otorgar permiso al comando: Cambiar usuario','Satisfactorio'),
(115,3020,34,'2019-08-23 19:34:41','Inicio de sesión','Satisfactorio'),
(116,3019,32,'2019-08-23 19:34:41','Cerrar sesión','Satisfactorio'),
(117,3021,32,'2019-08-23 19:34:53','Inicio de sesión','Satisfactorio'),
(118,3020,34,'2019-08-23 19:34:53','Cerrar sesión','Satisfactorio'),
(119,3021,32,'2019-08-23 19:45:15','Cierre de sesión','Satisfactorio'),
(120,3022,32,'2019-08-24 10:13:08','Inicio de sesión','Satisfactorio'),
(121,3022,32,'2019-08-24 10:13:22','Ingreso a TPV','Satisfactorio'),
(122,3022,32,'2019-08-24 10:13:36','Agregar nueva venta con ID= 32','Satisfactorio'),
(123,3022,32,'2019-08-24 10:15:51','Agregar nueva venta con ID= 33','Satisfactorio'),
(124,3022,32,'2019-08-24 12:21:19','Cierre de sesión','Satisfactorio'),
(125,3023,32,'2019-08-24 18:11:44','Inicio de sesión','Satisfactorio'),
(126,3023,32,'2019-08-24 18:11:47','Ingreso a TPV','Satisfactorio'),
(127,3023,32,'2019-08-24 18:12:14','Todo el proceso de pago del pedido con ID: 20 ha finalizado','Satisfactorio'),
(128,3023,32,'2019-08-24 18:12:39','Agregar nueva venta con ID= 34','Satisfactorio'),
(129,3023,32,'2019-08-24 21:07:46','Todo el proceso de pago del pedido con ID: 34 ha finalizado','Satisfactorio'),
(130,3023,32,'2019-08-24 21:08:07','Todo el proceso de pago del pedido con ID: 21 ha finalizado','Satisfactorio'),
(131,3023,32,'2019-08-24 21:08:37','Todo el proceso de pago del pedido con ID: 29 ha finalizado','Satisfactorio'),
(132,3023,32,'2019-08-24 21:08:57','Todo el proceso de pago del pedido con ID: 32 ha finalizado','Satisfactorio'),
(133,3023,32,'2019-08-24 21:09:12','Todo el proceso de pago del pedido con ID: 33 ha finalizado','Satisfactorio'),
(134,3023,32,'2019-08-24 21:28:44','Cierre de sesión','Satisfactorio'),
(135,3024,32,'2019-08-25 11:06:22','Inicio de sesión','Satisfactorio'),
(136,3024,32,'2019-08-25 11:06:57','Ingreso a TPV','Satisfactorio'),
(137,3024,32,'2019-08-25 11:07:05','Agregar nueva venta con ID= 35','Satisfactorio'),
(138,3024,32,'2019-08-25 11:10:01','Todo el proceso de pago del pedido con ID: 35 ha finalizado','Satisfactorio'),
(139,3024,32,'2019-08-25 11:54:05','Ingreso a TPV','Satisfactorio'),
(140,3025,32,'2019-08-25 22:25:34','Inicio de sesión','Satisfactorio'),
(141,3025,32,'2019-08-25 22:27:56','Ingreso a TPV','Satisfactorio'),
(142,3025,32,'2019-08-25 22:28:10','Agregar nueva venta con ID= 36','Satisfactorio'),
(143,3025,32,'2019-08-25 22:28:19','Todo el proceso de pago del pedido con ID: 36 ha finalizado','Satisfactorio'),
(144,3025,32,'2019-08-25 22:42:50','Agregar nueva venta con ID= 37','Satisfactorio'),
(145,3025,32,'2019-08-25 22:46:07','Todo el proceso de pago del pedido con ID: 37 ha finalizado','Satisfactorio'),
(146,3026,32,'2019-08-31 10:14:30','Inicio de sesión','Satisfactorio'),
(147,3027,32,'2019-08-31 11:37:11','Inicio de sesión','Satisfactorio'),
(148,3027,32,'2019-08-31 11:37:26','Ingreso a TPV','Satisfactorio'),
(149,3027,32,'2019-08-31 11:37:37','Agregar nueva venta con ID= 38','Satisfactorio'),
(150,3028,32,'2019-09-10 13:09:11','Inicio de sesión','Satisfactorio'),
(151,3028,32,'2019-09-10 13:10:52','Ingreso a TPV','Satisfactorio'),
(152,3028,32,'2019-09-10 13:27:18','Agregar nueva venta con ID= 39','Satisfactorio'),
(153,3019,32,'2019-09-10 21:30:46','Ingreso a productos','Satisfactorio'),
(154,3029,32,'2019-09-11 09:45:26','Inicio de sesión','Satisfactorio'),
(155,3029,32,'2019-09-11 09:46:53','Ingreso a productos','Satisfactorio'),
(156,3029,32,'2019-09-11 09:49:56','Ingreso a productos','Satisfactorio'),
(157,3029,32,'2019-09-11 09:57:57','Ingreso a productos','Satisfactorio'),
(158,3029,32,'2019-09-11 12:18:35','Cierre de sesión','Satisfactorio'),
(159,3030,32,'2019-09-12 11:23:44','Inicio de sesión','Satisfactorio'),
(160,3030,32,'2019-09-12 14:08:36','Ingreso a TPV','Satisfactorio'),
(161,3030,32,'2019-09-12 15:55:17','Cierre de sesión','Satisfactorio'),
(162,3031,32,'2019-09-12 19:47:44','Inicio de sesión','Satisfactorio'),
(163,3031,32,'2019-09-12 19:54:20','Ingreso a productos','Satisfactorio'),
(164,3031,32,'2019-09-12 19:56:26','Ingreso a TPV','Satisfactorio'),
(165,3031,32,'2019-09-12 19:56:36','Agregar nueva venta con ID= 40','Satisfactorio'),
(166,3031,32,'2019-09-12 20:19:33','Cierre de sesión','Satisfactorio'),
(167,3032,32,'2019-09-13 22:05:16','Inicio de sesión','Satisfactorio'),
(168,3032,32,'2019-09-13 22:05:24','Ingreso a TPV','Satisfactorio'),
(169,3032,32,'2019-09-13 22:05:48','Todo el proceso de pago del pedido con ID: 40 ha finalizado','Satisfactorio'),
(170,3032,32,'2019-09-14 00:19:07','Ingreso a TPV','Satisfactorio'),
(171,3032,32,'2019-09-14 00:19:24','Ingreso a TPV','Satisfactorio'),
(172,3032,32,'2019-09-14 00:19:35','Ingreso a TPV','Satisfactorio'),
(173,3032,32,'2019-09-14 00:19:57','Agregar nueva venta con ID= 41','Satisfactorio'),
(174,3032,32,'2019-09-14 00:51:39','Agregar nueva venta con ID= 42','Satisfactorio'),
(175,3032,32,'2019-09-14 00:59:46','Ingreso a TPV','Satisfactorio'),
(176,3032,32,'2019-09-14 01:00:01','Ingreso a TPV','Satisfactorio'),
(177,3032,32,'2019-09-14 01:12:45','Ingreso a TPV','Satisfactorio'),
(178,3032,32,'2019-09-14 01:12:58','Agregar nueva venta con ID= 43','Satisfactorio'),
(179,3032,32,'2019-09-14 01:38:55','Agregar nueva venta con ID= 44','Satisfactorio'),
(180,3032,32,'2019-09-14 03:29:57','Cierre de sesión','Satisfactorio'),
(181,3033,32,'2019-09-14 11:12:29','Inicio de sesión','Satisfactorio'),
(182,3033,32,'2019-09-14 11:12:34','Ingreso a TPV','Satisfactorio'),
(183,3033,32,'2019-09-14 11:12:52','Agregar nueva venta con ID= 45','Satisfactorio'),
(184,3033,32,'2019-09-14 11:15:40','Agregar nueva venta con ID= 46','Satisfactorio'),
(185,3033,32,'2019-09-14 11:21:47','Ingreso a TPV','Satisfactorio'),
(186,3033,32,'2019-09-14 11:22:13','Todo el proceso de pago del pedido con ID: 41 ha finalizado','Satisfactorio'),
(187,3033,32,'2019-09-14 11:46:52','Cierre de sesión','Satisfactorio'),
(188,3034,32,'2019-09-15 10:06:38','Inicio de sesión','Satisfactorio'),
(189,3034,32,'2019-09-15 10:06:45','Ingreso a productos','Satisfactorio'),
(190,3034,32,'2019-09-15 10:53:21','Ingreso a TPV','Satisfactorio'),
(191,3034,32,'2019-09-15 10:53:37','Agregar nueva venta con ID= 47','Satisfactorio'),
(192,3034,32,'2019-09-15 10:54:01','Todo el proceso de pago del pedido con ID: 47 ha finalizado','Satisfactorio'),
(193,3034,32,'2019-09-15 11:13:08','Ingreso a productos','Satisfactorio'),
(194,3034,32,'2019-09-15 11:13:16','Ingreso a productos','Satisfactorio'),
(195,3034,32,'2019-09-15 19:35:58','Ingreso a productos','Satisfactorio'),
(196,3034,32,'2019-09-15 19:36:07','Ingreso a TPV','Satisfactorio'),
(197,3034,32,'2019-09-15 19:36:18','Agregar nueva venta con ID= 48','Satisfactorio'),
(198,3034,32,'2019-09-15 19:36:40','Todo el proceso de pago del pedido con ID: 48 ha finalizado','Satisfactorio'),
(199,3034,32,'2019-09-15 21:36:35','Agregar nueva venta con ID= 49','Satisfactorio'),
(200,3034,32,'2019-09-15 21:36:44','Todo el proceso de pago del pedido con ID: 49 ha finalizado','Satisfactorio'),
(201,3034,32,'2019-09-15 21:36:58','Agregar nueva venta con ID= 50','Satisfactorio'),
(202,3034,32,'2019-09-15 21:37:09','Todo el proceso de pago del pedido con ID: 50 ha finalizado','Satisfactorio'),
(203,3034,32,'2019-09-15 22:30:55','Cierre de sesión','Satisfactorio'),
(204,3035,32,'2019-09-16 15:43:11','Inicio de sesión','Satisfactorio'),
(205,3035,32,'2019-09-16 15:43:13','Ingreso a TPV','Satisfactorio'),
(206,3035,32,'2019-09-16 15:47:01','Agregar nueva venta con ID= 51','Satisfactorio'),
(207,3035,32,'2019-09-16 15:52:56','Todo el proceso de pago del pedido con ID: 51 ha finalizado','Satisfactorio'),
(208,3035,32,'2019-09-16 15:56:28','Todo el proceso de pago del pedido con ID: 42 ha finalizado','Satisfactorio'),
(209,3035,32,'2019-09-16 15:56:49','Todo el proceso de pago del pedido con ID: 43 ha finalizado','Satisfactorio'),
(210,3035,32,'2019-09-16 15:57:05','Todo el proceso de pago del pedido con ID: 44 ha finalizado','Satisfactorio'),
(211,3035,32,'2019-09-16 15:57:26','Todo el proceso de pago del pedido con ID: 45 ha finalizado','Satisfactorio'),
(212,3035,32,'2019-09-16 15:57:42','Todo el proceso de pago del pedido con ID: 46 ha finalizado','Satisfactorio'),
(213,3035,32,'2019-09-16 15:58:06','Todo el proceso de pago del pedido con ID: 39 ha finalizado','Satisfactorio'),
(214,3035,32,'2019-09-16 15:58:45','Todo el proceso de pago del pedido con ID: 38 ha finalizado','Satisfactorio'),
(215,3035,32,'2019-09-16 16:27:36','Cierre de sesión','Satisfactorio'),
(216,3036,32,'2019-09-16 19:02:49','Inicio de sesión','Satisfactorio'),
(217,3036,32,'2019-09-16 19:05:30','Ingreso a TPV','Satisfactorio'),
(218,3036,32,'2019-09-16 19:05:56','Agregar nueva venta con ID= 52','Satisfactorio'),
(219,3020,32,'2019-09-16 19:16:11','Cierre de sesión','Satisfactorio'),
(220,3037,32,'2019-09-16 19:16:20','Inicio de sesión','Satisfactorio'),
(221,3037,32,'2019-09-16 19:16:24','Ingreso a TPV','Satisfactorio'),
(222,3037,32,'2019-09-16 19:20:19','Todo el proceso de pago del pedido con ID: 52 ha finalizado','Satisfactorio'),
(223,3037,32,'2019-09-16 21:55:18','Cierre de sesión','Satisfactorio'),
(224,3038,32,'2019-09-17 22:02:52','Inicio de sesión','Satisfactorio'),
(225,3038,32,'2019-09-17 22:04:00','Ingreso a TPV','Satisfactorio'),
(226,3038,32,'2019-09-17 22:04:10','Agregar nueva venta con ID= 53','Satisfactorio'),
(227,3038,32,'2019-09-17 22:08:05','Agregar nueva venta con ID= 54','Satisfactorio'),
(228,3038,32,'2019-09-17 22:10:12','Agregar nueva venta con ID= 55','Satisfactorio'),
(229,3038,32,'2019-09-17 22:17:31','Agregar nueva venta con ID= 56','Satisfactorio'),
(230,3038,32,'2019-09-17 22:28:01','Cierre de sesión','Satisfactorio'),
(231,3039,32,'2019-09-20 15:52:30','Inicio de sesión','Satisfactorio'),
(232,3039,32,'2019-09-20 15:52:34','Ingreso a productos','Satisfactorio'),
(233,3039,32,'2019-09-20 15:52:39','Ingreso a productos','Satisfactorio'),
(234,3039,32,'2019-09-20 15:52:53','Ingreso a productos','Satisfactorio'),
(235,3039,32,'2019-09-20 15:53:23','Ingreso a productos','Satisfactorio'),
(236,3039,32,'2019-09-20 15:53:28','Ingreso a productos','Satisfactorio'),
(237,3039,32,'2019-09-20 15:55:03','Ingreso a la administración de cuentas','Satisfactorio'),
(238,3039,32,'2019-09-20 15:55:18','Ingreso a Reportes','Satisfactorio'),
(239,3040,32,'2019-09-20 15:56:23','Inicio de sesión','Satisfactorio'),
(240,3040,32,'2019-09-20 15:59:18','Ingreso a TPV','Satisfactorio'),
(241,3040,32,'2019-09-20 15:59:25','Agregar nueva venta con ID= 57','Satisfactorio'),
(242,3040,32,'2019-09-20 15:59:38','Todo el proceso de pago del pedido con ID: 57 ha finalizado','Satisfactorio'),
(243,3040,32,'2019-09-20 16:04:31','Ingreso a TPV','Satisfactorio'),
(244,3040,32,'2019-09-20 16:04:41','Agregar nueva venta con ID= 58','Satisfactorio'),
(245,3041,32,'2019-09-21 11:46:47','Inicio de sesión','Satisfactorio'),
(246,3041,32,'2019-09-21 11:46:52','Ingreso a TPV','Satisfactorio'),
(247,3041,32,'2019-09-21 11:46:57','Cierre de sesión','Satisfactorio'),
(248,3042,32,'2019-09-22 11:07:58','Inicio de sesión','Satisfactorio'),
(249,3042,32,'2019-09-22 14:54:25','Cierre de sesión','Satisfactorio'),
(250,3043,32,'2019-09-22 21:35:22','Inicio de sesión','Satisfactorio'),
(251,3043,32,'2019-09-22 21:40:49','Cierre de caja','Satisfactorio'),
(252,3043,32,'2019-09-22 21:41:16','Apertura de caja','Satisfactorio'),
(253,3043,32,'2019-09-22 21:44:04','Ingreso a TPV','Satisfactorio'),
(254,3043,32,'2019-09-22 21:44:13','Agregar nueva venta con ID= 59','Satisfactorio'),
(255,3043,32,'2019-09-22 21:45:09','Todo el proceso de pago del pedido con ID: 59 ha finalizado','Satisfactorio'),
(256,3043,32,'2019-09-22 21:45:27','Agregar nueva venta con ID= 60','Satisfactorio'),
(257,3043,32,'2019-09-22 21:47:29','Todo el proceso de pago del pedido con ID: 60 ha finalizado','Satisfactorio'),
(258,3043,32,'2019-09-22 21:53:25','Cierre de caja','Satisfactorio'),
(259,3043,32,'2019-09-22 21:53:56','Apertura de caja','Satisfactorio'),
(260,3043,32,'2019-09-22 21:54:18','Ingreso a TPV','Satisfactorio'),
(261,3043,32,'2019-09-22 21:54:25','Agregar nueva venta con ID= 61','Satisfactorio'),
(262,3043,32,'2019-09-22 21:54:53','Todo el proceso de pago del pedido con ID: 61 ha finalizado','Satisfactorio'),
(263,3043,32,'2019-09-22 21:55:14','Agregar nueva venta con ID= 62','Satisfactorio'),
(264,3043,32,'2019-09-22 21:55:47','Todo el proceso de pago del pedido con ID: 62 ha finalizado','Satisfactorio'),
(265,3043,32,'2019-09-22 21:57:05','Cierre de caja','Satisfactorio'),
(266,3043,32,'2019-09-22 21:57:19','Ingreso a la administración de cuentas','Satisfactorio'),
(267,3043,32,'2019-09-22 22:14:29','Apertura de caja','Satisfactorio');
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table mesa
-- 

/*!40000 ALTER TABLE `mesa` DISABLE KEYS */;
INSERT INTO `mesa`(`idMesa`,`numero`,`nombre`,`capacidad`,`disponible`,`idSalon`) VALUES
(1,1,'Mesa 1',0,0,2),
(2,2,'Mesa 2',0,0,2),
(3,3,'Mesa 3',0,0,2),
(4,4,'Mesa 4',0,0,2),
(5,5,'Mesa 5',0,0,2),
(6,6,'Mesa 6',0,1,2),
(7,7,'Mesa 7',0,1,2),
(8,8,'Mesa 8',0,1,2),
(9,9,'Mesa 9',0,1,2),
(10,10,'Mesa 10',0,1,2);
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

/*!40000 ALTER TABLE `pago_mixto` ENABLE KEYS */;

-- 
-- Definition of passbook34
-- 

DROP TABLE IF EXISTS `passbook34`;
CREATE TABLE IF NOT EXISTS `passbook34` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook34
-- 

/*!40000 ALTER TABLE `passbook34` DISABLE KEYS */;
INSERT INTO `passbook34`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-08 00:00:00','Rashid feroz','KOLKATA','K421A',13000,0,13000,'Account Open'),
(9,'2015-01-09 00:00:00','Rashid feroz','KOLKATA','K421A',0,500,12500,'TO Deepak rajwar'),
(10,'2015-01-10 00:00:00','Rashid feroz','KOLKATA','K421A',100,0,12600,'BY Deepak rajwar'),
(11,'2015-01-10 00:00:00','Rashid feroz','KOLKATA','K421A',2593,0,15193,'BY Deepak rajwar'),
(12,'2018-03-09 00:00:00','Rashid feroz','KOLKATA','K421A',0,1193,14000,'TO Shailesh kumar'),
(13,'2018-03-10 00:00:00','Rashid feroz','KOLKATA','K421A',0,10000,4000,'TO ricardo gonzoles');
/*!40000 ALTER TABLE `passbook34` ENABLE KEYS */;

-- 
-- Definition of passbook35
-- 

DROP TABLE IF EXISTS `passbook35`;
CREATE TABLE IF NOT EXISTS `passbook35` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook35
-- 

/*!40000 ALTER TABLE `passbook35` DISABLE KEYS */;
INSERT INTO `passbook35`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-09 00:00:00','Deepak rajwar','DELHI','D30AC',10002,0,10002,'Account Open'),
(7,'2015-01-09 00:00:00','Deepak rajwar','DELHI','D30AC',500,0,10502,'BY Rashid feroz'),
(8,'2015-01-10 00:00:00','Deepak rajwar','DELHI','D30AC',0,100,10402,'TO Rashid feroz'),
(9,'2015-01-10 00:00:00','Deepak rajwar','DELHI','D30AC',0,2593,7809,'TO Rashid feroz');
/*!40000 ALTER TABLE `passbook35` ENABLE KEYS */;

-- 
-- Definition of passbook36
-- 

DROP TABLE IF EXISTS `passbook36`;
CREATE TABLE IF NOT EXISTS `passbook36` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook36
-- 

/*!40000 ALTER TABLE `passbook36` DISABLE KEYS */;
INSERT INTO `passbook36`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-09 00:00:00','Shailesh kumar','BANGALORE','B6A9E',95621,0,95621,'Account Open'),
(2,'2018-03-09 00:00:00','Shailesh kumar','BANGALORE','B6A9E',1193,0,96814,'BY Rashid feroz');
/*!40000 ALTER TABLE `passbook36` ENABLE KEYS */;

-- 
-- Definition of passbook37
-- 

DROP TABLE IF EXISTS `passbook37`;
CREATE TABLE IF NOT EXISTS `passbook37` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook37
-- 

/*!40000 ALTER TABLE `passbook37` DISABLE KEYS */;
INSERT INTO `passbook37`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-09 00:00:00','Ravi nandan','DELHI','D30AC',9000,0,9000,'Account Open');
/*!40000 ALTER TABLE `passbook37` ENABLE KEYS */;

-- 
-- Definition of passbook38
-- 

DROP TABLE IF EXISTS `passbook38`;
CREATE TABLE IF NOT EXISTS `passbook38` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook38
-- 

/*!40000 ALTER TABLE `passbook38` DISABLE KEYS */;
INSERT INTO `passbook38`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-09 00:00:00','Isha dey','KOLKATA','K421A',10000,0,10000,'Account Open');
/*!40000 ALTER TABLE `passbook38` ENABLE KEYS */;

-- 
-- Definition of passbook39
-- 

DROP TABLE IF EXISTS `passbook39`;
CREATE TABLE IF NOT EXISTS `passbook39` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook39
-- 

/*!40000 ALTER TABLE `passbook39` DISABLE KEYS */;
INSERT INTO `passbook39`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-10 00:00:00','sunny kumar','DELHI','D30AC',1000,0,1000,'Account Open');
/*!40000 ALTER TABLE `passbook39` ENABLE KEYS */;

-- 
-- Definition of passbook40
-- 

DROP TABLE IF EXISTS `passbook40`;
CREATE TABLE IF NOT EXISTS `passbook40` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook40
-- 

/*!40000 ALTER TABLE `passbook40` DISABLE KEYS */;
INSERT INTO `passbook40`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-11 00:00:00','Pankaj kumar','DELHI','D30AC',1000,0,1000,'Account Open');
/*!40000 ALTER TABLE `passbook40` ENABLE KEYS */;

-- 
-- Definition of passbook41
-- 

DROP TABLE IF EXISTS `passbook41`;
CREATE TABLE IF NOT EXISTS `passbook41` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook41
-- 

/*!40000 ALTER TABLE `passbook41` DISABLE KEYS */;
INSERT INTO `passbook41`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2015-01-11 00:00:00','Sharique hassan','KOLKATA','K421A',1000,0,1000,'Account Open');
/*!40000 ALTER TABLE `passbook41` ENABLE KEYS */;

-- 
-- Definition of passbook42
-- 

DROP TABLE IF EXISTS `passbook42`;
CREATE TABLE IF NOT EXISTS `passbook42` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook42
-- 

/*!40000 ALTER TABLE `passbook42` DISABLE KEYS */;
INSERT INTO `passbook42`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2017-06-09 00:00:00','Alvan','DELHI','D30AC',1000,0,1000,'Account Open');
/*!40000 ALTER TABLE `passbook42` ENABLE KEYS */;

-- 
-- Definition of passbook43
-- 

DROP TABLE IF EXISTS `passbook43`;
CREATE TABLE IF NOT EXISTS `passbook43` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook43
-- 

/*!40000 ALTER TABLE `passbook43` DISABLE KEYS */;
INSERT INTO `passbook43`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2017-08-04 00:00:00','paul','KOLKATA','K421A',1000,0,1000,'Account Open');
/*!40000 ALTER TABLE `passbook43` ENABLE KEYS */;

-- 
-- Definition of passbook44
-- 

DROP TABLE IF EXISTS `passbook44`;
CREATE TABLE IF NOT EXISTS `passbook44` (
  `transactionid` int(5) NOT NULL AUTO_INCREMENT,
  `transactiondate` date DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `ifsc` varchar(255) DEFAULT NULL,
  `credit` int(10) DEFAULT NULL,
  `debit` int(10) DEFAULT NULL,
  `amount` float(10,2) DEFAULT NULL,
  `narration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transactionid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table passbook44
-- 

/*!40000 ALTER TABLE `passbook44` DISABLE KEYS */;
INSERT INTO `passbook44`(`transactionid`,`transactiondate`,`name`,`branch`,`ifsc`,`credit`,`debit`,`amount`,`narration`) VALUES
(1,'2018-03-09 00:00:00','ricardo gonzoles','KOLKATA','K421A',1000,0,1000,'Account Open'),
(2,'2018-03-10 00:00:00','ricardo gonzoles','KOLKATA','K421A',10000,0,11000,'BY Rashid feroz');
/*!40000 ALTER TABLE `passbook44` ENABLE KEYS */;

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
  `listo` tinyint(2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `descuento` decimal(10,2) DEFAULT NULL,
  `iva` decimal(10,2) NOT NULL,
  `propina` decimal(10,2) NOT NULL,
  `totalPago` decimal(10,2) NOT NULL,
  `idTiraje` int(5) DEFAULT NULL,
  `nFactura` varchar(15) NOT NULL,
  `anular` tinyint(1) NOT NULL DEFAULT '0',
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
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido
-- 

/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido`(`idPedido`,`idCliente`,`idMesa`,`idCuenta`,`idMesero`,`cancelado`,`fecha`,`listo`,`total`,`descuento`,`iva`,`propina`,`totalPago`,`idTiraje`,`nFactura`,`anular`) VALUES
(1,NULL,NULL,1,NULL,0,'2019-04-14 19:05:07',2,10.75,0.00,1.40,1.08,13.23,NULL,'',0),
(2,NULL,NULL,1,NULL,0,'2019-04-16 13:54:33',2,12.00,0.00,0.00,0.00,0.00,NULL,'',0),
(3,NULL,NULL,1,NULL,1,'2019-04-17 10:46:07',2,19.99,0.00,2.60,2.00,24.59,NULL,'',0),
(4,3,NULL,1,NULL,0,'2019-04-16 14:16:25',2,2.75,0.00,0.00,0.00,0.00,NULL,'',0),
(5,NULL,NULL,1,NULL,1,'2019-04-17 10:46:28',2,5.50,0.00,0.72,0.55,6.77,NULL,'',0),
(6,NULL,NULL,1,NULL,1,'2019-04-17 10:46:54',2,11.00,0.00,1.43,1.10,13.53,NULL,'',0),
(7,NULL,NULL,1,NULL,0,'2019-04-17 10:20:57',2,32.71,0.00,0.00,0.00,0.00,NULL,'',0),
(8,NULL,NULL,1,NULL,0,'2019-04-17 10:21:55',2,32.48,0.00,0.00,0.00,0.00,NULL,'',0),
(9,NULL,NULL,1,NULL,0,'2019-04-17 10:47:00',2,8.00,0.00,0.00,0.00,0.00,NULL,'',0),
(10,NULL,1,1,NULL,1,'2019-06-22 11:19:53',0,90.93,0.00,11.82,9.09,111.84,NULL,'',0),
(11,NULL,2,1,NULL,1,'2019-06-22 11:27:02',2,23.48,0.00,3.05,2.35,28.88,NULL,'',0),
(12,NULL,3,1,NULL,1,'2019-06-23 12:00:48',2,7.00,0.00,0.91,0.70,8.61,NULL,'',0),
(13,NULL,4,1,NULL,1,'2019-07-12 22:04:57',0,2.75,0.00,0.36,0.28,3.39,NULL,'',0),
(14,NULL,4,1,NULL,1,'2019-07-12 22:05:25',0,9.49,0.00,1.23,0.95,11.67,NULL,'',0),
(16,NULL,3,1,NULL,1,'2019-07-13 11:37:52',1,8.99,0.00,1.17,0.90,11.06,NULL,'',0),
(19,NULL,3,1,NULL,1,'2019-08-23 19:17:22',2,19.98,0.00,2.60,2.00,24.58,NULL,'',0),
(20,NULL,1,1,NULL,1,'2019-08-24 18:12:14',2,33.00,0.00,4.29,3.30,40.59,NULL,'',0),
(21,NULL,4,1,NULL,1,'2019-08-24 21:08:07',2,22.98,0.00,2.99,2.30,28.27,NULL,'',0),
(22,NULL,2,1,NULL,1,'2019-08-23 19:18:44',2,15.25,0.00,1.98,1.53,18.76,NULL,'',0),
(23,NULL,5,1,NULL,1,'2019-08-18 14:13:38',2,31.00,0.00,4.03,3.10,38.13,NULL,'',0),
(24,NULL,5,1,NULL,1,'2019-08-18 14:24:41',0,55.94,0.00,7.27,5.59,68.80,NULL,'',0),
(25,NULL,5,1,NULL,1,'2019-08-18 14:25:13',0,71.43,0.00,9.29,7.14,87.86,NULL,'',0),
(26,NULL,5,1,NULL,1,'2019-08-18 14:25:39',1,34.96,0.00,4.54,3.50,43.00,NULL,'',0),
(27,NULL,5,1,NULL,1,'2019-08-18 20:03:30',1,24.73,0.00,3.21,2.47,30.41,NULL,'',0),
(28,NULL,5,1,NULL,1,'2019-08-18 20:04:26',1,6.00,0.00,0.78,0.60,7.38,NULL,'',0),
(29,NULL,5,1,NULL,1,'2019-08-24 21:08:36',2,398.39,0.00,51.79,39.84,490.02,NULL,'',0),
(30,NULL,6,1,NULL,1,'2019-08-23 19:16:11',2,53.25,0.00,6.92,5.33,65.50,NULL,'',0),
(31,NULL,6,1,NULL,1,'2019-08-23 19:20:56',2,4.00,0.00,0.52,0.40,4.92,NULL,'',0),
(32,NULL,6,1,NULL,1,'2019-08-24 21:08:57',2,47.95,0.00,6.23,4.80,58.98,NULL,'',0),
(33,NULL,7,1,NULL,1,'2019-08-24 21:09:12',2,16.97,0.00,2.21,1.70,20.88,NULL,'',0),
(34,NULL,1,1,NULL,1,'2019-08-24 21:07:46',1,130.00,0.00,16.90,13.00,159.90,NULL,'',0),
(35,NULL,1,1,NULL,1,'2019-08-25 11:10:00',0,2.00,0.00,0.26,0.20,2.46,NULL,'',0),
(36,NULL,6,1,NULL,1,'2019-08-25 22:28:19',0,4.00,0.00,0.52,0.40,4.92,NULL,'',0),
(37,NULL,1,1,NULL,1,'2019-08-25 22:46:07',1,3.00,0.00,0.39,0.30,3.69,NULL,'',0),
(38,NULL,1,1,NULL,1,'2019-09-16 15:58:44',2,37.96,0.00,4.93,3.80,46.69,NULL,'',0),
(39,NULL,2,1,NULL,1,'2019-09-16 15:58:05',2,106.50,0.00,13.85,10.65,131.00,NULL,'',0),
(40,NULL,3,1,NULL,1,'2019-09-13 22:05:47',2,47.99,0.00,6.24,4.80,59.03,NULL,'',0),
(41,NULL,3,1,NULL,1,'2019-09-14 11:22:13',2,11.00,0.00,1.43,1.10,13.53,NULL,'',0),
(42,NULL,4,1,NULL,1,'2019-09-16 15:56:28',2,33.97,0.00,4.42,3.40,41.79,NULL,'',0),
(43,NULL,5,1,NULL,1,'2019-09-16 15:56:49',2,121.90,0.00,15.85,12.19,149.94,NULL,'',0),
(44,NULL,6,1,NULL,1,'2019-09-16 15:57:04',2,131.94,0.00,17.15,13.19,162.28,NULL,'',0),
(45,NULL,7,1,NULL,1,'2019-09-16 15:57:26',2,10.99,0.00,1.43,1.10,13.52,NULL,'',0),
(46,NULL,8,1,NULL,1,'2019-09-16 15:57:42',2,3.00,0.00,0.39,0.30,3.69,NULL,'',0),
(47,NULL,3,1,NULL,1,'2019-09-15 10:54:00',0,3.00,0.00,0.39,0.30,3.69,NULL,'',0),
(48,NULL,3,1,NULL,1,'2019-09-15 19:36:39',0,10.00,0.00,1.30,1.00,12.30,NULL,'',0),
(49,NULL,3,1,NULL,1,'2019-09-15 21:36:43',0,2.00,0.00,0.26,0.20,2.46,NULL,'',0),
(50,NULL,3,1,NULL,1,'2019-09-15 21:37:08',0,4.00,0.00,0.52,0.40,4.92,NULL,'',0),
(51,NULL,3,1,NULL,1,'2019-09-16 15:52:56',2,33.96,0.00,4.41,3.40,41.77,NULL,'',0),
(52,NULL,1,1,NULL,1,'2019-09-16 19:20:18',2,45.96,0.00,5.97,4.60,56.53,NULL,'',0),
(53,NULL,1,1,NULL,0,'2019-09-17 22:04:05',2,14.98,0.00,0.00,0.00,0.00,NULL,'',0),
(54,NULL,2,1,NULL,0,'2019-09-17 22:08:00',2,22.48,0.00,0.00,0.00,0.00,NULL,'',0),
(55,NULL,3,1,NULL,0,'2019-09-17 22:10:08',2,22.48,0.00,0.00,0.00,0.00,NULL,'',0),
(56,NULL,4,1,NULL,0,'2019-09-17 22:17:27',2,18.48,0.00,0.00,0.00,0.00,NULL,'',0),
(57,NULL,5,1,NULL,1,'2019-09-20 15:59:38',0,5.00,0.00,0.65,0.50,6.15,NULL,'',0),
(58,NULL,5,1,NULL,0,'2019-09-20 16:04:34',0,5.00,0.00,0.00,0.00,0.00,NULL,'',0),
(59,NULL,6,1,NULL,1,'2019-09-22 21:45:09',0,165.82,0.00,21.56,16.58,203.96,NULL,'',0),
(60,NULL,6,1,NULL,1,'2019-09-22 21:47:29',0,103.00,0.00,13.39,10.30,126.69,NULL,'',0),
(61,NULL,6,1,NULL,1,'2019-09-22 21:54:52',0,98.93,0.00,12.86,9.89,121.68,NULL,'',0),
(62,NULL,6,1,NULL,1,'2019-09-22 21:55:47',0,336.30,0.00,43.72,33.63,413.65,NULL,'',0);
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
  `grupo` varchar(2) NOT NULL,
  `cantidadAnterior` int(3) NOT NULL,
  PRIMARY KEY (`idDetalle`),
  KEY `FK8EC261C66039B36F_idx` (`idProducto`),
  KEY `FK8EC261C6B9DECED7_idx` (`idCocinero`),
  KEY `fk_pedido_detalle_pedido1_idx` (`idPedido`),
  CONSTRAINT `FK8EC261C66039B36F` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`),
  CONSTRAINT `FK8EC261C6B9DECED7` FOREIGN KEY (`idCocinero`) REFERENCES `cocinero` (`idCocinero`),
  CONSTRAINT `fk_pedido_detalle_pedido1` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=297 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido_detalle
-- 

/*!40000 ALTER TABLE `pedido_detalle` DISABLE KEYS */;
INSERT INTO `pedido_detalle`(`idDetalle`,`cocinando`,`extras`,`horaEntregado`,`horaPedido`,`idCocinero`,`idProducto`,`idPedido`,`cantidad`,`precio`,`subTotal`,`grupo`,`cantidadAnterior`) VALUES
(1,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,49,1,5,0.75,3.75,'',0),
(2,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,48,1,1,1.00,1.00,'',0),
(3,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,46,1,1,1.00,1.00,'',0),
(4,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,38,1,5,1.00,5.00,'',0),
(5,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,38,2,10,1.00,10.00,'',0),
(6,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,44,2,1,1.00,1.00,'',0),
(7,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,45,2,1,1.00,1.00,'',0),
(8,1,'','2019-04-16 14:16:16','2019-04-16 14:16:16',NULL,119,3,2,6.00,12.00,'',0),
(9,1,'','2019-04-16 14:16:16','2019-04-16 14:16:16',NULL,9,3,1,7.99,7.99,'',0),
(10,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,38,4,1,1.00,1.00,'',0),
(11,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,49,4,1,0.75,0.75,'',0),
(12,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,48,4,1,1.00,1.00,'',0),
(13,1,'','2019-04-16 14:16:32','2019-04-16 14:16:32',NULL,63,5,1,2.50,2.50,'',0),
(14,1,'','2019-04-16 14:16:32','2019-04-16 14:16:32',NULL,58,5,1,3.00,3.00,'',0),
(15,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,64,6,1,3.00,3.00,'',0),
(16,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,63,6,1,2.50,2.50,'',0),
(17,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,59,6,1,3.00,3.00,'',0),
(18,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,65,6,1,2.50,2.50,'',0),
(19,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,117,7,1,7.99,7.99,'',0),
(20,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,7,7,2,9.49,18.98,'',0),
(21,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,4,7,1,3.49,3.49,'',0),
(22,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,67,7,1,1.00,1.00,'',0),
(23,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,111,7,1,1.25,1.25,'',0),
(24,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,64,8,1,3.00,3.00,'',0),
(25,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,65,8,3,2.50,7.50,'',0),
(26,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,16,8,2,10.99,21.98,'',0),
(27,1,'','2019-04-17 10:47:00','2019-04-17 10:47:00',NULL,111,9,4,1.25,5.00,'',0),
(28,1,'','2019-04-17 10:47:00','2019-04-17 10:47:00',NULL,67,9,3,1.00,3.00,'',0),
(29,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,46,10,1,1.00,1.00,'',0),
(30,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,38,10,1,1.00,1.00,'',0),
(31,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,40,10,1,1.00,1.00,'',0),
(32,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,56,10,1,2.50,2.50,'',0),
(33,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,52,10,1,1.50,1.50,'',0),
(34,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,123,10,1,24.00,24.00,'',0),
(35,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,54,10,1,2.50,2.50,'',0),
(36,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,22,10,1,6.99,6.99,'',0),
(37,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,19,10,1,5.99,5.99,'',0),
(38,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,14,10,1,7.99,7.99,'',0),
(39,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,13,10,1,5.99,5.99,'',0),
(40,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,11,10,1,9.99,9.99,'',0),
(41,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,12,10,1,10.99,10.99,'',0),
(42,1,'','2019-06-22 11:18:11','2019-06-22 11:18:11',NULL,15,10,1,9.49,9.49,'',0),
(43,1,'','2019-06-22 11:26:14','2019-06-22 11:26:14',NULL,46,11,1,1.00,1.00,'',0),
(44,1,'','2019-06-22 11:26:14','2019-06-22 11:26:14',NULL,117,11,1,7.99,7.99,'',0),
(45,1,'','2019-06-22 11:26:14','2019-06-22 11:26:14',NULL,7,11,1,9.49,9.49,'',0),
(46,1,'','2019-06-22 11:26:14','2019-06-22 11:26:14',NULL,56,11,1,2.50,2.50,'',0),
(47,1,'','2019-06-22 11:26:14','2019-06-22 11:26:14',NULL,54,11,1,2.50,2.50,'',0),
(48,1,'','2019-06-23 12:00:28','2019-06-23 12:00:28',NULL,47,12,1,1.00,1.00,'',0),
(49,1,'','2019-06-23 12:00:28','2019-06-23 12:00:28',NULL,46,12,1,1.00,1.00,'',0),
(50,1,'','2019-06-23 12:00:28','2019-06-23 12:00:28',NULL,54,12,1,2.50,2.50,'',0),
(51,1,'','2019-06-23 12:00:28','2019-06-23 12:00:28',NULL,56,12,1,2.50,2.50,'',0),
(60,1,'','2019-07-12 21:57:48','2019-07-12 21:57:48',NULL,38,13,1,1.00,1.00,'',0),
(61,1,'','2019-07-12 21:57:48','2019-07-12 21:57:48',NULL,49,13,1,0.75,0.75,'',0),
(62,1,'','2019-07-12 21:57:48','2019-07-12 21:57:48',NULL,48,13,1,1.00,1.00,'',0),
(64,1,'','2019-07-12 21:57:48','2019-07-12 21:57:48',NULL,7,14,1,9.49,9.49,'',0),
(68,1,'','2019-07-13 11:37:36','2019-07-13 11:37:36',NULL,46,16,1,1.00,1.00,'',0),
(69,1,'','2019-07-13 11:37:36','2019-07-13 11:37:36',NULL,117,16,1,7.99,7.99,'',0),
(77,1,'','2019-08-10 11:00:02','2019-08-10 11:00:02',NULL,9,19,1,7.99,7.99,'',0),
(78,1,'','2019-08-10 11:00:02','2019-08-10 11:00:02',NULL,45,19,1,1.00,1.00,'',0),
(79,1,'','2019-08-10 11:00:02','2019-08-10 11:00:02',NULL,18,19,1,10.99,10.99,'',0),
(80,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,45,20,1,1.00,1.00,'',0),
(81,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,40,20,1,1.00,1.00,'',0),
(82,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,123,20,1,24.00,24.00,'',0),
(83,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,56,20,1,2.50,2.50,'',0),
(84,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,57,20,1,2.50,2.50,'',0),
(85,1,'','2019-08-10 14:26:06','2019-08-10 14:26:06',NULL,53,20,1,2.00,2.00,'',0),
(86,1,'','2019-08-10 18:01:10','2019-08-10 18:01:10',NULL,66,21,1,1.00,1.00,'',0),
(87,1,'','2019-08-10 18:01:10','2019-08-10 18:01:10',NULL,18,21,1,10.99,10.99,'',0),
(88,1,'','2019-08-10 18:01:10','2019-08-10 18:01:10',NULL,17,21,1,10.99,10.99,'',0),
(89,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,49,22,1,0.75,0.75,'',0),
(90,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,40,22,1,1.00,1.00,'',0),
(91,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,108,22,1,1.00,1.00,'',0),
(92,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,56,22,1,2.50,2.50,'',0),
(93,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,57,22,1,2.50,2.50,'',0),
(94,1,'','2019-08-18 14:08:37','2019-08-18 14:08:37',NULL,53,22,1,2.00,2.00,'',0),
(95,1,'','2019-08-18 14:12:32','2019-08-18 14:12:32',NULL,56,23,1,2.50,2.50,'',0),
(96,1,'','2019-08-18 14:12:32','2019-08-18 14:12:32',NULL,52,23,1,1.50,1.50,'',0),
(97,1,'','2019-08-18 14:12:32','2019-08-18 14:12:32',NULL,122,23,1,24.00,24.00,'',0),
(98,1,'','2019-08-18 14:12:32','2019-08-18 14:12:32',NULL,51,23,1,1.50,1.50,'',0),
(101,1,'','2019-08-18 14:12:32','2019-08-18 14:12:32',NULL,49,23,2,0.75,1.50,'',0),
(102,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,6,24,1,8.49,8.49,'',0),
(103,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,117,24,1,7.99,7.99,'',0),
(104,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,7,24,1,9.49,9.49,'',0),
(105,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,119,24,1,6.00,6.00,'',0),
(106,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,10,24,1,7.99,7.99,'',0),
(107,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,9,24,1,7.99,7.99,'',0),
(108,1,'','2019-08-18 14:16:24','2019-08-18 14:16:24',NULL,8,24,1,7.99,7.99,'',0),
(109,1,'','2019-08-18 14:24:51','2019-08-18 14:24:51',NULL,16,25,2,10.99,21.98,'',0),
(110,1,'','2019-08-18 14:24:51','2019-08-18 14:24:51',NULL,18,25,2,10.99,21.98,'',0),
(111,1,'','2019-08-18 14:24:51','2019-08-18 14:24:51',NULL,17,25,1,10.99,10.99,'',0),
(112,1,'','2019-08-18 14:24:51','2019-08-18 14:24:51',NULL,6,25,1,8.49,8.49,'',0),
(113,1,'','2019-08-18 14:24:51','2019-08-18 14:24:51',NULL,117,25,1,7.99,7.99,'',0),
(114,1,'','2019-08-18 14:25:24','2019-08-18 14:25:24',NULL,119,26,1,6.00,6.00,'',0),
(115,1,'','2019-08-18 14:25:24','2019-08-18 14:25:24',NULL,10,26,1,7.99,7.99,'',0),
(116,1,'','2019-08-18 14:25:24','2019-08-18 14:25:24',NULL,8,26,1,7.99,7.99,'',0),
(117,1,'','2019-08-18 14:25:24','2019-08-18 14:25:24',NULL,22,26,1,6.99,6.99,'',0),
(118,1,'','2019-08-18 14:25:24','2019-08-18 14:25:24',NULL,20,26,1,5.99,5.99,'',0),
(119,1,'','2019-08-18 20:01:05','2019-08-18 20:01:05',NULL,60,27,1,3.00,3.00,'',0),
(120,1,'','2019-08-18 20:01:05','2019-08-18 20:01:05',NULL,64,27,1,3.00,3.00,'',0),
(121,1,'','2019-08-18 20:01:05','2019-08-18 20:01:05',NULL,61,27,1,2.00,2.00,'',0),
(122,1,'','2019-08-18 20:01:05','2019-08-18 20:01:05',NULL,22,27,1,6.99,6.99,'',0),
(123,1,'','2019-08-18 20:01:05','2019-08-18 20:01:05',NULL,21,27,1,6.99,6.99,'',0),
(124,1,'','2019-08-18 20:02:37','2019-08-18 20:02:37',NULL,46,28,1,1.00,1.00,'',0),
(125,1,'','2019-08-18 20:02:37','2019-08-18 20:02:37',NULL,49,27,1,0.75,0.75,'',0),
(126,1,'','2019-08-18 20:02:37','2019-08-18 20:02:37',NULL,48,27,1,1.00,1.00,'',0),
(127,1,'','2019-08-18 20:02:37','2019-08-18 20:02:37',NULL,40,27,1,1.00,1.00,'',0),
(128,1,'','2019-08-18 20:03:52','2019-08-18 20:03:52',NULL,56,28,1,2.50,2.50,'',0),
(129,1,'','2019-08-18 20:03:52','2019-08-18 20:03:52',NULL,54,28,1,2.50,2.50,'',0),
(130,1,'','2019-08-18 20:25:09','2019-08-18 20:25:09',NULL,16,29,2,10.99,21.98,'',0),
(131,1,'','2019-08-18 20:25:09','2019-08-18 20:25:09',NULL,18,29,3,10.99,32.97,'',0),
(132,1,'','2019-08-18 20:25:09','2019-08-18 20:25:09',NULL,17,29,4,10.99,43.96,'',0),
(133,1,'','2019-08-18 20:25:09','2019-08-18 20:25:09',NULL,56,29,7,2.50,17.50,'',0),
(134,1,'','2019-08-18 20:25:09','2019-08-18 20:25:09',NULL,123,29,6,24.00,144.00,'',0),
(135,1,'','2019-08-18 21:36:08','2019-08-18 21:36:08',NULL,122,29,5,24.00,120.00,'',0),
(136,1,'','2019-08-18 21:36:08','2019-08-18 21:36:08',NULL,51,29,1,1.50,1.50,'',0),
(137,1,'','2019-08-19 14:24:52','2019-08-19 14:24:52',NULL,6,29,1,8.49,8.49,'',0),
(138,1,'','2019-08-19 14:24:52','2019-08-19 14:24:52',NULL,117,29,1,7.99,7.99,'',0),
(139,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,67,30,1,1.00,1.00,'',0),
(140,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,68,30,1,1.25,1.25,'',0),
(141,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,64,30,1,3.00,3.00,'',0),
(142,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,60,30,2,3.00,6.00,'',0),
(143,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,62,30,1,2.50,2.50,'',0),
(144,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,63,30,1,2.50,2.50,'',0),
(145,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,58,30,1,3.00,3.00,'',0),
(146,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,52,30,1,1.50,1.50,'',0),
(147,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,56,30,1,2.50,2.50,'',0),
(148,1,'','2019-08-23 18:55:16','2019-08-23 18:55:16',NULL,124,30,1,30.00,30.00,'',0),
(149,1,'','2019-08-23 19:18:14','2019-08-23 19:18:14',NULL,65,22,1,2.50,2.50,'',0),
(150,1,'','2019-08-23 19:18:14','2019-08-23 19:18:14',NULL,59,22,1,3.00,3.00,'',0),
(151,1,'','2019-08-23 19:19:38','2019-08-23 19:19:38',NULL,38,31,2,1.00,2.00,'',0),
(152,1,'','2019-08-23 19:19:38','2019-08-23 19:19:38',NULL,44,31,1,1.00,1.00,'',0),
(153,1,'','2019-08-23 19:19:38','2019-08-23 19:19:38',NULL,41,31,1,1.00,1.00,'',0),
(154,1,'','2019-08-24 10:13:26','2019-08-24 10:13:26',NULL,16,32,1,10.99,10.99,'',0),
(155,1,'','2019-08-24 10:13:26','2019-08-24 10:13:26',NULL,18,32,1,10.99,10.99,'',0),
(156,1,'','2019-08-24 10:13:26','2019-08-24 10:13:26',NULL,6,32,1,8.49,8.49,'',0),
(157,1,'','2019-08-24 10:13:26','2019-08-24 10:13:26',NULL,117,32,1,7.99,7.99,'',0),
(158,1,'','2019-08-24 10:13:26','2019-08-24 10:13:26',NULL,7,32,1,9.49,9.49,'',0),
(159,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,46,33,1,1.00,1.00,'',0),
(160,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,45,33,1,1.00,1.00,'',0),
(161,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,50,33,1,1.00,1.00,'',0),
(162,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,30,33,1,6.99,6.99,'',0),
(163,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,113,33,1,3.49,3.49,'',0),
(164,1,'','2019-08-24 10:15:46','2019-08-24 10:15:46',NULL,32,33,1,3.49,3.49,'',0),
(165,1,'','2019-08-24 18:12:25','2019-08-24 18:12:25',NULL,122,34,5,24.00,120.00,'',0),
(166,1,'','2019-08-24 18:12:25','2019-08-24 18:12:25',NULL,56,34,1,2.50,2.50,'',0),
(167,1,'','2019-08-24 18:12:25','2019-08-24 18:12:25',NULL,57,34,2,2.50,5.00,'',0),
(168,1,'','2019-08-24 18:12:25','2019-08-24 18:12:25',NULL,54,34,1,2.50,2.50,'',0),
(169,1,'','2019-08-25 11:07:00','2019-08-25 11:07:00',NULL,38,35,2,1.00,2.00,'',0),
(170,1,'','2019-08-25 22:28:04','2019-08-25 22:28:04',NULL,38,36,4,1.00,4.00,'',0),
(171,1,'','2019-08-25 22:42:43','2019-08-25 22:42:43',NULL,38,37,2,1.00,2.00,'',0),
(172,1,'','2019-08-25 22:42:43','2019-08-25 22:42:43',NULL,40,37,1,1.00,1.00,'',0),
(173,1,'','2019-08-31 11:37:30','2019-08-31 11:37:30',NULL,6,38,1,8.49,8.49,'',0),
(174,1,'','2019-08-31 11:37:30','2019-08-31 11:37:30',NULL,117,38,1,7.99,7.99,'',0),
(175,1,'','2019-08-31 11:37:30','2019-08-31 11:37:30',NULL,7,38,2,9.49,18.98,'',0),
(176,1,'','2019-08-31 11:37:30','2019-08-31 11:37:30',NULL,56,38,1,2.50,2.50,'',0),
(177,1,'','2019-09-10 13:26:01','2019-09-10 13:26:01',NULL,52,39,3,1.50,4.50,'',2),
(178,1,'','2019-09-10 13:26:01','2019-09-10 13:26:01',NULL,56,39,8,2.50,20.00,'',7),
(179,1,'','2019-09-10 13:26:01','2019-09-10 13:26:01',NULL,123,39,3,24.00,72.00,'',2),
(180,1,'','2019-09-10 13:26:01','2019-09-10 13:26:01',NULL,127,39,1,10.00,10.00,'',0),
(181,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,119,40,4,6.00,24.00,'',3),
(182,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,67,40,4,1.00,4.00,'',3),
(183,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,18,40,1,10.99,10.99,'',0),
(184,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,52,40,1,1.50,1.50,'',0),
(185,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,56,40,1,2.50,2.50,'',0),
(186,1,'','2019-09-12 19:56:31','2019-09-12 19:56:31',NULL,55,40,2,2.50,5.00,'',1),
(187,1,'','2019-09-14 00:19:53','2019-09-14 00:19:53',NULL,66,41,3,1.00,3.00,'',2),
(188,1,'','2019-09-14 00:19:53','2019-09-14 00:19:53',NULL,67,41,3,1.00,3.00,'',2),
(189,1,'','2019-09-14 00:19:53','2019-09-14 00:19:53',NULL,68,41,4,1.25,5.00,'',3),
(190,1,'','2019-09-14 00:51:34','2019-09-14 00:51:34',NULL,46,42,1,1.00,1.00,'',0),
(191,1,'','2019-09-14 00:51:34','2019-09-14 00:51:34',NULL,16,42,3,10.99,32.97,'',2),
(192,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,16,43,3,10.99,32.97,'',2),
(193,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,60,43,1,3.00,3.00,'',0),
(195,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,117,43,2,7.99,15.98,'',1),
(196,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,22,43,3,6.99,20.97,'',2),
(197,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,19,43,2,5.99,11.98,'',1),
(198,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,107,43,1,2.00,2.00,'',0),
(199,1,'','2019-09-14 01:12:53','2019-09-14 01:12:53',NULL,86,43,1,35.00,35.00,'',0),
(200,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,16,44,1,10.99,10.99,'',0),
(201,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,20,44,2,5.99,11.98,'',1),
(202,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,52,44,1,1.50,1.50,'',0),
(203,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,133,44,1,11.00,11.00,'',0),
(204,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,117,44,1,7.99,7.99,'',0),
(205,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,86,44,1,35.00,35.00,'',2),
(206,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,107,44,2,2.00,4.00,'',1),
(207,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,102,44,1,25.00,25.00,'',0),
(208,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,99,44,1,5.00,5.00,'',0),
(209,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,11,44,1,9.99,9.99,'',0),
(210,1,'','2019-09-14 01:38:35','2019-09-14 01:38:35',NULL,15,44,1,9.49,9.49,'',0),
(212,1,'','2019-09-14 11:12:42','2019-09-14 11:12:42',NULL,16,45,1,10.99,10.99,'',0),
(213,1,'','2019-09-14 11:15:35','2019-09-14 11:15:35',NULL,60,46,1,3.00,3.00,'',0),
(214,1,'','2019-09-15 10:53:30','2019-09-15 10:53:30',NULL,38,47,3,1.00,3.00,'',4),
(215,1,'','2019-09-15 19:36:13','2019-09-15 19:36:13',NULL,38,48,10,1.00,10.00,'',9),
(216,1,'','2019-09-15 21:36:31','2019-09-15 21:36:31',NULL,38,49,2,1.00,2.00,'',1),
(217,1,'','2019-09-15 21:36:54','2019-09-15 21:36:54',NULL,38,50,4,1.00,4.00,'',3),
(218,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,16,51,1,10.99,10.99,'',0),
(219,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,56,51,3,2.50,7.50,'',2),
(221,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,22,51,1,6.99,6.99,'',0),
(222,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,3,51,1,3.49,3.49,'',0),
(223,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,51,51,1,1.50,1.50,'',0),
(224,1,'','2019-09-16 15:43:30','2019-09-16 15:43:30',NULL,4,51,1,3.49,3.49,'',2),
(225,1,'','2019-09-16 19:05:38','2019-09-16 19:05:38',NULL,16,52,1,10.99,10.99,'',2),
(226,1,'','2019-09-16 19:05:38','2019-09-16 19:05:38',NULL,52,52,2,1.50,3.00,'',1),
(227,1,'','2019-09-16 19:16:27','2019-09-16 19:16:27',NULL,49,52,4,0.75,3.00,'',3),
(228,1,'','2019-09-16 19:16:27','2019-09-16 19:16:27',NULL,38,52,2,1.00,2.00,'',1),
(229,1,'','2019-09-16 19:16:27','2019-09-16 19:16:27',NULL,40,52,2,1.00,2.00,'',1),
(230,1,'','2019-09-16 19:16:27','2019-09-16 19:16:27',NULL,6,52,2,8.49,16.98,'',1),
(231,1,'','2019-09-16 19:16:27','2019-09-16 19:16:27',NULL,117,52,1,7.99,7.99,'',0),
(232,1,'','2019-09-17 22:04:05','2019-09-17 22:04:05',NULL,46,53,1,1.00,1.00,'',0),
(233,1,'','2019-09-17 22:04:05','2019-09-17 22:04:05',NULL,38,53,1,1.00,1.00,'',0),
(234,1,'','2019-09-17 22:04:05','2019-09-17 22:04:05',NULL,22,53,1,6.99,6.99,'',0),
(235,1,'','2019-09-17 22:04:05','2019-09-17 22:04:05',NULL,20,53,1,5.99,5.99,'',0),
(236,1,'','2019-09-17 22:08:00','2019-09-17 22:08:00',NULL,6,54,2,8.49,16.98,'',1),
(237,1,'','2019-09-17 22:08:00','2019-09-17 22:08:00',NULL,60,54,1,3.00,3.00,'',0),
(238,1,'','2019-09-17 22:08:00','2019-09-17 22:08:00',NULL,65,54,1,2.50,2.50,'',0),
(239,1,'','2019-09-17 22:10:08','2019-09-17 22:10:08',NULL,64,55,2,3.00,6.00,'',1),
(240,1,'','2019-09-17 22:10:08','2019-09-17 22:10:08',NULL,6,55,1,8.49,8.49,'',0),
(241,1,'','2019-09-17 22:10:08','2019-09-17 22:10:08',NULL,117,55,1,7.99,7.99,'',0),
(242,1,'','2019-09-17 22:17:27','2019-09-17 22:17:27',NULL,46,56,1,1.00,1.00,'',0),
(243,1,'','2019-09-17 22:17:27','2019-09-17 22:17:27',NULL,38,56,1,1.00,1.00,'',0),
(244,1,'','2019-09-17 22:17:27','2019-09-17 22:17:27',NULL,6,56,1,8.49,8.49,'',0),
(245,1,'','2019-09-17 22:17:27','2019-09-17 22:17:27',NULL,117,56,1,7.99,7.99,'',0),
(246,1,'','2019-09-20 15:59:21','2019-09-20 15:59:21',NULL,38,57,5,1.00,5.00,'',6),
(247,1,'','2019-09-20 16:04:34','2019-09-20 16:04:34',NULL,38,58,5,1.00,5.00,'',4),
(248,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,46,59,7,1.00,7.00,'',6),
(249,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,38,59,10,1.00,10.00,'',9),
(250,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,51,59,7,1.50,10.50,'',6),
(251,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,94,59,4,3.00,12.00,'',3),
(252,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,4,59,4,3.49,13.96,'',3),
(253,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,23,59,1,4.99,4.99,'',0),
(254,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,29,59,1,5.99,5.99,'',0),
(255,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,28,59,1,5.99,5.99,'',0),
(256,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,24,59,1,4.99,4.99,'',0),
(257,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,11,59,1,9.99,9.99,'',0),
(258,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,12,59,3,10.99,32.97,'',2),
(259,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,13,59,3,5.99,17.97,'',2),
(260,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,15,59,1,9.49,9.49,'',0),
(261,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,137,59,1,7.99,7.99,'',0),
(262,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,92,59,1,7.99,7.99,'',0),
(263,1,'','2019-09-22 21:44:09','2019-09-22 21:44:09',NULL,93,59,1,4.00,4.00,'',0),
(264,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,66,60,2,1.00,2.00,'',1),
(265,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,71,60,2,1.25,2.50,'',1),
(266,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,70,60,2,1.25,2.50,'',1),
(267,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,60,60,2,3.00,6.00,'',1),
(268,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,110,60,5,10.00,50.00,'',4),
(269,1,'','2019-09-22 21:45:24','2019-09-22 21:45:24',NULL,109,60,8,5.00,40.00,'',7),
(270,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,60,61,1,3.00,3.00,'',0),
(271,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,64,61,2,3.00,6.00,'',1),
(272,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,59,61,2,3.00,6.00,'',1),
(273,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,65,61,2,2.50,5.00,'',1),
(274,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,58,61,1,3.00,3.00,'',0),
(275,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,63,61,2,2.50,5.00,'',1),
(276,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,61,61,2,2.00,4.00,'',1),
(277,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,62,61,2,2.50,5.00,'',1),
(278,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,119,61,1,6.00,6.00,'',0),
(279,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,10,61,2,7.99,15.98,'',1),
(280,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,8,61,2,7.99,15.98,'',1),
(281,1,'','2019-09-22 21:54:22','2019-09-22 21:54:22',NULL,9,61,3,7.99,23.97,'',2),
(282,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,16,62,5,10.99,54.95,'',4),
(283,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,18,62,8,10.99,87.92,'',7),
(284,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,17,62,7,10.99,76.93,'',6),
(285,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,52,62,1,1.50,1.50,'',0),
(286,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,56,62,1,2.50,2.50,'',0),
(287,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,123,62,1,24.00,24.00,'',0),
(288,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,57,62,1,2.50,2.50,'',0),
(289,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,124,62,1,30.00,30.00,'',0),
(290,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,122,62,1,24.00,24.00,'',0),
(291,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,51,62,1,1.50,1.50,'',0),
(292,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,55,62,1,2.50,2.50,'',0),
(293,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,53,62,1,2.00,2.00,'',0),
(294,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,118,62,1,8.00,8.00,'',0),
(295,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,115,62,1,8.00,8.00,'',0),
(296,1,'','2019-09-22 21:55:09','2019-09-22 21:55:09',NULL,125,62,1,10.00,10.00,'',0);
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
(3,1,'2017-07-17 00:00:00'),
(4,91,'2019-08-18 00:00:00'),
(1,91,'2019-08-18 00:00:00'),
(1,92,'2019-08-18 00:00:00'),
(1,93,'2019-08-18 00:00:00'),
(1,94,'2019-08-18 00:00:00'),
(1,95,'2019-08-18 00:00:00'),
(5,91,'0001-01-01 00:00:00'),
(5,90,'2019-08-23 00:00:00');
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
(3,26,1,'DESAYUNO E. CON VEGETALES','DESAYUNO E. CON VEGETALES',3.49,0.00,'VEGETALES.png',0,0,-101,0,1),
(4,26,1,'DESAYUNO E. CON JAMON','DESAYUNO E. CON JAMON',3.49,0.00,'huevos con jamon.jpg',0,0,-127,0,1),
(5,26,1,'DESAYUNO RANCHERO','DESAYUNO RANCHERO',3.99,0.00,'thVIDR5HF5.jpg',0,0,-109,0,1),
(6,27,1,'CHURRASCO ARGENTINO','CHURRASCO ARGENTINO',8.49,4.50,'CHURRASCO.jpg',1,0,34,0,1),
(7,27,1,'TIPICO B.A','TIPICO B.A',9.49,0.00,'TIPICO.jpg',1,0,-49,0,1),
(8,28,1,'PECHUGA EN SALSA BARBACOA','PECHUGA EN SALSA BARBACOA',7.99,0.00,'pechuga a la barbacoa 023.JPG',1,0,-12,0,1),
(9,28,1,'PECHUGA A LA PLANCHA','PECHUGA A LA PLANCHA',7.99,0.00,'PLANCHA.jpg',1,0,-46,0,1),
(10,28,1,'P. EN SALSA DE HONGOS','P. EN SALSA DE HONGOS',7.99,0.00,'thOG1JF1A3.jpg',1,0,-102,0,1),
(11,29,1,'MARISCADA NATURAL','MARISCADA NATURAL',9.99,0.00,'NATURAL.jpg',1,0,-19,0,1),
(12,29,1,'MARISCADA CON CREMA','MARISCADA CON CREMA',10.99,0.00,'NATURAL.jpg',1,0,-39,0,1),
(13,29,1,'PESCADO PEQUEÃ‘O','PESCADO PEQUEÃ‘O',5.99,0.00,'thA3FONYEV.jpg',1,0,-16,0,1),
(14,29,1,'PESCADO GRANDE','PESCADO GRANDE',7.99,0.00,'thA3FONYEV.jpg',1,0,-2,0,1),
(15,29,1,'PESCADO B.A','PESCADO B.A',9.49,0.00,'pargo-fresco.jpg',1,0,-7,0,1),
(16,30,1,'CAMARONES A LA MEXICANA','CAMARONES A LA MEXICANA',10.99,0.00,'MEXICANA.jpg',1,0,-8,0,1),
(17,30,1,'CAMARONES AL AJILLO','CAMARONES AL AJILLO',10.99,0.00,'thDOD86NEQ.jpg',1,0,-39,0,1),
(18,30,1,'CAMARONES A LA PLANCHA','CAMARONES A LA PLANCHA',10.99,0.00,'PLANCHA.png',1,0,-35,0,1),
(19,31,1,'COCTEL DE CONCHA','COCTEL DE CONCHA',5.99,0.00,'coctel_de_concha.jpg',1,0,-20,0,1),
(20,31,1,'COCTEL CAMARON NATURAL','COCTEL CAMARON NATURAL',5.99,0.00,'coctel-de-camarones.jpg',1,0,-32,0,1),
(21,31,1,'COCTEL CAMARON S.R','COCTEL CAMARON S.R',6.99,0.00,'CocktailCamarones.jpg',1,0,-38,0,1),
(22,31,1,'COCTEL MIXTO','COCTEL MIXTO',6.99,0.00,'coctel-de-camarones.jpg',1,0,-16,0,1),
(23,32,1,'SANDWICH DE POLLO','SANDWICH DE POLLO',4.99,0.00,'thDWSIPJWL.jpg',0,0,-52,0,1),
(24,32,1,'SANDWICH DE JAMON','SANDWICH DE JAMON',4.99,0.00,'thDWSIPJWL.jpg',0,0,-18,0,1),
(25,32,1,'HAMBURGUESA','HAMBURGUESA',5.99,0.00,'BK_300x270_hamburguesa_deluxe_queso.png',1,0,-52,0,1),
(26,32,1,'PASTA ALFREDO CON POLLO','PASTA ALFREDO CON POLLO',6.99,0.00,'Spaghetti Alfredo 2.jpg',1,0,-13,0,1),
(27,32,1,'PASTA A. CON CAMARONES','PASTA A. CON CAMARONES',6.99,0.00,'light-fettucine-alfredo.jpg',1,0,-4,0,1),
(28,32,1,'PINCHOS DE POLLO','PINCHOS DE POLLO',5.99,0.00,'th9VZQVY8K.jpg',1,0,-7,0,1),
(29,32,1,'PINCHOS DE CARNE','PINCHOS DE CARNE ',5.99,0.00,'maxresdefault.jpg',1,0,-10,0,1),
(30,33,1,'ENSALADA FRESCA CON ATUN','ENSALADA FRESCA CON ATUN',6.99,0.00,'Ensalada-con-atÃºn.jpg',0,0,-3,0,1),
(31,33,1,'ENSALADA CON POLLO','ENSALADA CON POLLO',5.99,0.00,'ensalada.jpg',0,0,-40,0,1),
(32,33,1,'ENSALADA FRESCA','ENSALADA FRESCA',3.49,0.00,'ensalada_14.jpg',0,0,-6,0,1),
(33,34,1,'SORBETE','SORBETE',1.24,0.00,'sorbete-de-pina-e1301363574168.jpg',1,0,-44,0,1),
(34,34,1,'TRES LECHES','TRES LECHES',2.49,0.00,'tres-leches-cake.jpg',1,0,-13,0,1),
(35,34,1,'BUDIN','BUDIN',2.49,0.00,'thLR3V091F.jpg',1,0,-130,0,1),
(36,34,1,'QUESADILLA','QUESADILLA',2.49,0.00,'quesadilla-salvadoreÃ±a-receta.jpg',1,0,-209,0,1),
(37,34,1,'CHEESECAKE','CHEESECAKE',2.49,0.00,'thSF3OP0GU.jpg',1,0,-62,0,1),
(38,35,1,'COCA-COLA','COCA-COLA',1.00,0.00,'coca-cola.jpg',1,0,390,0,1),
(39,35,1,'SPRITE','SPRITE',1.00,0.00,'th3MVWSHXB.jpg',1,0,-16,0,1),
(40,35,1,'FRESA','FRESA',1.00,0.00,'tropical.png',1,0,-16,0,1),
(41,35,1,'FRESCA','FRESCA',1.00,0.00,'fresca_banner.jpg',1,0,-31,0,1),
(42,35,1,'SUPERCHAMPAN','SUPERCHAMPAN',1.00,0.00,'th59IFH6F2.jpg',1,0,-13,0,1),
(43,35,1,'UVA','UVA',1.00,0.00,'thBU54H9FD.jpg',1,0,-44,0,1),
(44,35,1,'CREMA SODA','CREMA SODA',1.00,0.00,'cremasoda.png',1,0,-46,0,1),
(45,35,1,'FANTA','FANTA',1.00,0.00,'fanta.png',1,0,-74,0,1),
(46,35,1,'COCA ZERO','COCA ZERO',1.00,0.00,'thHQVQXPUA.jpg',1,0,96,0,1),
(47,35,1,'COCA LIGHT','COCA LIGHT',1.00,0.00,'thDSHKTBQG.jpg',1,0,4,0,1),
(48,35,1,'AGUA MINERAL','AGUA MINERAL',1.00,0.00,'thBX4HO3FU.jpg',1,0,-26,0,1),
(49,35,1,'AGUA','AGUA',0.75,0.00,'thC1NDDPNZ.jpg',1,0,-65,0,1),
(50,35,1,'FUZE TEA','FUZE TEA',1.00,0.00,'thK7PZA7HD.jpg',1,0,13,0,1),
(51,37,1,'PILSENER','PILSENER',1.50,0.00,'pilsener-logo-F398838DC9-seeklogo.com.gif.jpg',1,0,-45,0,1),
(52,37,1,'GOLDEN','GOLDEN',1.50,0.00,'178058303_ae23122bff.jpg',1,0,-28,0,1),
(53,37,1,'SUPREMA','SUPREMA',2.00,0.00,'th7KCS3B62.jpg',1,0,-82,0,1),
(54,37,1,'CORONA','CORONA',2.50,0.00,'thHBP0L15S.jpg',1,0,-54,0,1),
(55,37,1,'SMIRNOFF','SMIRNOFF',2.50,0.00,'Smirnoff-_ice_sabores.jpg',1,0,10,0,1),
(56,37,1,'HEYNEKEN','HEYNEKEN',2.50,0.00,'thYSMTB77V.jpg',1,0,102,0,1),
(57,37,1,'MODELO','MODELO',2.50,0.00,'thDASHQ7MM.jpg',1,0,62,0,1),
(58,41,1,'FROZEN DE FRESA','FROZEN DE FRESA',3.00,0.00,'thDT9R1D2Q.jpg',1,0,-67,0,1),
(59,41,1,'FROZEN DE COCO ','FROZEN DE COCO',3.00,0.00,'thJ109J02A.jpg',1,0,-28,0,1),
(60,41,1,'FROZEN DE SANDIA ','FROZEN DE SANDIA',3.00,0.00,'th.jpg',1,0,-42,0,1),
(61,41,1,'LIMONADA ESPECIAL','LIMONADA ESPECIAL',2.00,0.00,'thXZMD5F9G.jpg',0,0,-189,0,1),
(62,41,1,'LICUADO DE GUINEO','LICUADO DE GUINEO',2.50,0.00,'untitled.png',1,0,-45,0,1),
(63,41,1,'LICUADO DE FRESA','LICUADO DE FRESA ',2.50,0.00,'thGIEYJX3Y.jpg',1,0,-36,0,1),
(64,41,1,'JUGO DE NARANJA','JUGO DE NARANJA',3.00,0.00,'th38DAKPHQ.jpg',0,0,-143,0,1),
(65,41,1,'CAFE CON HELADO','CAFE CON HELADO',2.50,0.00,'thJYSS9NOR.jpg',0,0,-41,0,1),
(66,36,1,'CHOCOLATE','CHOCOLATE',1.00,0.00,'thU4GDHPV9.jpg',1,0,-274,0,1),
(67,36,1,'CAFE','CAFE',1.00,0.00,'th9E80TPUM.jpg',1,0,-433,0,1),
(68,36,1,'CAFE CON LECHE','CAFE CON LECHE',1.25,0.00,'thB4HM8JB6.jpg',1,0,-105,0,1),
(69,36,1,'LECHE','LECHE',1.00,0.00,'thB4HM8JB6.jpg',1,0,-24,0,1),
(70,36,1,'TE VERDE','TE VERDE',1.25,0.00,'th32ARK324.jpg',1,0,-23,0,1),
(71,36,1,'TE DE MANZANILLA','TE DE MANZANILLA',1.25,0.00,'th32ARK324.jpg',1,0,-39,0,1),
(72,36,1,'CAPUCHINO','CAPUCHINO',2.00,0.00,'thJYSS9NOR.jpg',0,0,-89,0,1),
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
(86,40,1,'HABITACION 1','HABITACION 1',35.00,0.00,'',0,0,-9,0,1),
(87,40,1,'HABITACION 2','HABITACION 2',45.00,0.00,'',0,0,0,0,1),
(88,40,1,'HABITACION 3','HABITACION 3',45.00,0.00,'',0,0,-1,0,1),
(89,40,1,'HABITACION 4','HABITACION 4',50.00,0.00,'',0,0,-1,0,1),
(90,40,1,'HABITACION 5','HABITACION 5',45.00,0.00,'',0,0,-1,0,1),
(91,40,1,'HABITACION 6','HABITACION 6',35.00,0.00,'',0,0,-2,0,1),
(92,45,1,'SOPA DE GALLINA ','SOPA DE GALLINA',7.99,0.00,'thYBN3KS5M.jpg',0,0,-191,0,1),
(93,45,1,'SOPA SOLA','SOPA SOLA',4.00,0.00,'thAW530FB6.jpg',0,0,-5,0,1),
(94,26,1,'PAN CAKE','PAN CAKE',3.00,0.00,'buttermilk_pancake_image.jpg',0,0,-9,0,1),
(95,38,1,'MOJITO','MOJITO',5.00,0.00,'th4MB97Z7R.jpg',0,0,-16,0,1),
(96,38,1,'MICHELADA CON PILSENER','MICHELADA CON PILSENER',3.00,0.00,'MicheladaPreparada.jpg',1,0,-3,0,1),
(97,38,1,'MICHELADA GOLDEN','MICHELADA GOLDEN',3.00,0.00,'MicheladaPreparada.jpg',1,0,-6,0,1),
(98,38,1,'MICHELADA SUPREMA','MICHELADA SUPREMA',3.50,0.00,'MicheladaPreparada.jpg',1,0,-3,0,1),
(99,38,1,'COPA VINO','COPA VINO',5.00,0.00,'thW4GAFG63.jpg',1,0,-10,0,1),
(100,38,1,'CUBALIBRE','CUBALIBRE',5.00,0.00,'thAGASQ38B.jpg',1,0,0,0,1),
(101,38,1,'BOTELLA VINO A','BOTELLA VINO A',20.00,0.00,'BOTELLA 1866 LARIOS.bmp',1,0,-2,0,1),
(102,38,1,'BOTELLA VINO B','BOTELLA VINO B',25.00,0.00,'BOTELLA JHONIE WALKER NEGRO.bmp',1,0,-1,0,1),
(103,38,1,'DESCORCHE','DESCORCHE',5.00,0.00,'buttermilk_pancake_image.jpg',1,0,-3,0,1),
(104,38,1,'HIELO','HIELO',1.00,0.00,'buttermilk_pancake_image.jpg',1,0,0,0,1),
(105,44,1,'ORD.LIMON','ORD.LIMON',0.50,0.00,'buttermilk_pancake_image.jpg',1,0,0,0,1),
(107,46,1,'USO DE PISCINA','USO DE PISCINA',2.00,0.00,'untitled.png',0,0,-18,0,1),
(108,35,1,'HORCHATA','HORCHATA',1.00,0.00,'horchata.jpg',0,0,-44,0,1),
(109,47,1,'PLATO DE BOCA PEQUEÃ‘O','',5.00,0.00,'atun1.jpg',0,0,-30,0,1),
(110,47,1,'PLATO DE BOCA MEDIA','PLATO DE BOCA MEDIANO',10.00,0.00,'carta_laconGallego.jpg',0,0,-8,0,1),
(111,36,1,'CHOCOLATE CON LECHE','CHOCOLATE CON LECHE',1.25,0.00,'thVIW8K0CU.jpg',0,0,-40,0,1),
(112,44,1,'ORDEN DE CHORIZO','ORDEN DE CHORIZO',1.00,0.00,'croquetas2.gif',0,0,-8,0,1),
(113,33,1,'ENSALADA DE VEGETALES','ENSALADA DE VEGETALES',3.49,0.00,'raviolis_con_cebollino.jpg',0,0,-8,0,1),
(114,44,1,'PAN CON AJO','PAN CON AJO',0.50,0.00,'',0,0,-13,0,1),
(115,37,1,'VALDE DE PILSENER','VALDE DE PILSENER',8.00,0.00,'',0,0,-18,0,1),
(116,38,1,'MICHELADA MIX','MICHELADA MIX',3.75,0.00,'',0,0,-8,0,1),
(117,27,1,'COSTILLON B.A','COSTILLON B.A',7.99,0.00,'carta_costillas.jpg',1,0,8,0,1),
(118,37,1,'VALDE GOLDEN','VALDE GOLDEN',8.00,0.00,'',1,0,-20,0,1),
(119,28,9,'ALITAS SBBQ','ALITAS SBBQ',6.00,0.00,'',1,0,196,0,1),
(120,34,1,'PASTEL DE CHOCOLATE','PASTEL DE CHOCOLATE',2.49,0.00,'',1,0,-10,0,1),
(122,37,1,'HIELERAZO GOLDEN','HIELERAZO GOLDEN ',24.00,0.00,'',1,0,-13,0,1),
(123,37,1,'HIELERAZO','HIELERAZO',24.00,0.00,'thB4HM8JB6.jpg',1,0,-15,0,1),
(124,37,1,'HIELERAZO.B','HIELERAZO.B',30.00,0.00,'thB4HM8JB6.jpg',1,0,-12,0,1),
(125,37,1,'VALDE DE MODELO ','VALDE DE MODELO',10.00,0.00,'',1,0,-1,0,1),
(126,37,1,'VALDE MODELO 5','VALDE  MODELO 5',10.00,0.00,'',1,0,-1,0,1),
(127,37,1,'BALDE SUPREMA','BALDE SUPREMA',10.00,0.00,'',1,0,-4,0,1),
(128,38,1,'MARGARITA','',5.00,0.00,'',1,0,-5,0,1),
(129,38,1,'TEQUILA','SENCILLO',5.00,0.00,'',1,0,-1,0,1),
(130,38,1,'TEQUILA DOBLE','',10.00,0.00,'',1,0,-4,0,1),
(131,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,0,0,0),
(132,28,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,0,0,0),
(133,37,1,'5 CORONAS','5 CORONAS',11.00,0.00,'',1,0,-5,0,1),
(134,44,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,-1,0,1),
(135,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,-1,0,1),
(136,44,1,'ORDEN DE CARNE','',3.00,0.00,'',1,0,-1,0,1),
(137,45,1,'COSTILLA DE CERDO AHUMADA','',7.99,0.00,'',1,0,-9,0,1),
(142,51,1,'CROQUETAS DE COLIFLOR','',3.75,0.00,'Croquetas de coliflor.jpg',0,0,-2,0,1),
(143,51,1,'MATAMBRE ARROLADO','',3.85,0.00,'Matambre arrollado.jpg',0,0,-1,0,1),
(144,51,1,'TARTA DE ATÃšN','',2.90,0.00,'Tarta de atÃºn.jpg',0,0,0,0,1),
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
(1,'Maxi despensa','','','0000','90','','');
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table rol
-- 

/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol`(`idRol`,`rol`) VALUES
(1,'Administrador'),
(2,'Mesero'),
(3,'Cajero'),
(4,'Cocinero'),
(5,'BAR');
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table salon
-- 

/*!40000 ALTER TABLE `salon` DISABLE KEYS */;
INSERT INTO `salon`(`idSalon`,`nombre`,`fondo`,`nMesas`) VALUES
(1,'prueba','',0),
(2,'prueba1','',10);
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
) ENGINE=InnoDB AUTO_INCREMENT=3044 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sesion
-- 

/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;
INSERT INTO `sesion`(`idSesion`,`idUsuario`,`fecha`,`fechaFin`,`estadoSesion`) VALUES
(2633,1,'2018-05-04 16:36:55','0001-01-01 00:00:00','0'),
(2634,1,'2018-05-04 17:22:28','0001-01-01 00:00:00','0'),
(2635,1,'2018-05-04 17:23:52','0001-01-01 00:00:00','0'),
(2636,1,'2018-05-04 17:31:18','0001-01-01 00:00:00','0'),
(2637,1,'2018-05-04 17:33:01','0001-01-01 00:00:00','0'),
(2638,1,'2018-05-04 17:51:23','0001-01-01 00:00:00','0'),
(2641,1,'2018-06-23 11:18:38','0001-01-01 00:00:00','0'),
(2642,1,'2018-06-23 11:38:28','0001-01-01 00:00:00','0'),
(2647,1,'2018-06-23 11:58:38','0001-01-01 00:00:00','0'),
(2648,1,'2018-06-23 12:00:56','0001-01-01 00:00:00','0'),
(2649,1,'2018-06-23 12:03:56','0001-01-01 00:00:00','0'),
(2650,1,'2018-06-23 12:07:11','0001-01-01 00:00:00','0'),
(2651,1,'2018-06-23 12:10:28','0001-01-01 00:00:00','0'),
(2652,1,'2018-06-23 12:14:27','0001-01-01 00:00:00','0'),
(2653,1,'2018-06-23 12:16:24','0001-01-01 00:00:00','0'),
(2654,1,'2018-06-23 12:23:22','0001-01-01 00:00:00','0'),
(2655,1,'2018-06-23 12:25:28','0001-01-01 00:00:00','0'),
(2656,1,'2018-06-23 12:29:37','0001-01-01 00:00:00','0'),
(2657,1,'2018-06-23 12:30:29','0001-01-01 00:00:00','0'),
(2659,1,'2018-06-24 11:18:10','0001-01-01 00:00:00','0'),
(2660,1,'2018-06-24 11:19:10','0001-01-01 00:00:00','0'),
(2661,1,'2018-06-24 11:27:37','0001-01-01 00:00:00','0'),
(2662,1,'2018-06-24 11:33:37','0001-01-01 00:00:00','0'),
(2663,1,'2018-06-24 11:36:40','0001-01-01 00:00:00','0'),
(2664,1,'2018-06-24 11:48:03','0001-01-01 00:00:00','0'),
(2665,1,'2018-06-24 11:52:00','0001-01-01 00:00:00','0'),
(2666,1,'2018-06-24 11:53:36','0001-01-01 00:00:00','0'),
(2667,1,'2018-06-24 11:56:24','0001-01-01 00:00:00','0'),
(2668,1,'2018-06-24 11:58:31','0001-01-01 00:00:00','0'),
(2669,1,'2018-06-24 12:11:27','0001-01-01 00:00:00','0'),
(2670,1,'2018-06-24 12:30:45','0001-01-01 00:00:00','0'),
(2671,1,'2018-06-24 12:31:28','0001-01-01 00:00:00','0'),
(2672,1,'2018-06-24 12:36:12','0001-01-01 00:00:00','0'),
(2673,1,'2018-06-24 13:54:43','0001-01-01 00:00:00','0'),
(2674,1,'2018-06-24 13:55:17','0001-01-01 00:00:00','0'),
(2675,1,'2018-06-24 13:55:52','0001-01-01 00:00:00','0'),
(2676,1,'2018-06-24 13:56:27','0001-01-01 00:00:00','0'),
(2677,1,'2018-06-24 13:57:57','0001-01-01 00:00:00','0'),
(2678,1,'2018-06-24 13:58:29','0001-01-01 00:00:00','0'),
(2680,1,'2018-06-24 14:22:32','0001-01-01 00:00:00','0'),
(2681,1,'2018-06-24 14:23:42','0001-01-01 00:00:00','0'),
(2682,1,'2018-06-24 14:24:51','0001-01-01 00:00:00','0'),
(2683,1,'2018-06-24 14:25:17','0001-01-01 00:00:00','0'),
(2684,1,'2018-06-24 14:43:08','0001-01-01 00:00:00','0'),
(2685,1,'2018-06-24 14:45:27','0001-01-01 00:00:00','0'),
(2686,1,'2018-06-24 14:48:30','0001-01-01 00:00:00','0'),
(2687,1,'2018-06-26 16:02:54','0001-01-01 00:00:00','0'),
(2688,1,'2018-06-26 16:03:24','0001-01-01 00:00:00','0'),
(2689,1,'2018-06-26 16:03:45','0001-01-01 00:00:00','0'),
(2690,1,'2018-06-26 16:05:24','0001-01-01 00:00:00','0'),
(2691,1,'2018-06-26 16:13:42','0001-01-01 00:00:00','0'),
(2692,1,'2018-06-26 16:15:33','0001-01-01 00:00:00','0'),
(2693,1,'2018-06-26 16:17:40','0001-01-01 00:00:00','0'),
(2694,1,'2018-06-26 16:27:12','0001-01-01 00:00:00','0'),
(2695,1,'2018-06-26 16:36:34','0001-01-01 00:00:00','0'),
(2696,1,'2018-06-26 16:40:24','0001-01-01 00:00:00','0'),
(2697,1,'2018-06-26 16:44:55','0001-01-01 00:00:00','0'),
(2698,1,'2018-06-26 16:45:34','0001-01-01 00:00:00','0'),
(2699,1,'2018-06-26 16:46:08','0001-01-01 00:00:00','0'),
(2700,1,'2018-06-26 17:06:55','0001-01-01 00:00:00','0'),
(2702,1,'2018-06-26 19:03:08','0001-01-01 00:00:00','0'),
(2703,1,'2018-06-26 19:11:32','0001-01-01 00:00:00','0'),
(2704,1,'2018-06-26 19:14:59','0001-01-01 00:00:00','0'),
(2705,1,'2018-06-26 19:17:32','0001-01-01 00:00:00','0'),
(2706,1,'2018-06-26 19:24:31','0001-01-01 00:00:00','0'),
(2707,1,'2018-06-26 19:25:35','0001-01-01 00:00:00','0'),
(2709,1,'2018-06-26 19:42:39','0001-01-01 00:00:00','0'),
(2710,1,'2018-06-27 10:19:31','0001-01-01 00:00:00','0'),
(2711,1,'2018-06-27 10:27:21','0001-01-01 00:00:00','0'),
(2712,1,'2018-06-27 10:29:12','0001-01-01 00:00:00','0'),
(2714,1,'2018-06-27 10:38:29','0001-01-01 00:00:00','0'),
(2715,1,'2018-06-27 10:44:49','0001-01-01 00:00:00','0'),
(2716,1,'2018-06-27 10:45:55','0001-01-01 00:00:00','0'),
(2717,1,'2018-06-27 10:57:58','0001-01-01 00:00:00','0'),
(2718,1,'2018-06-27 11:22:22','0001-01-01 00:00:00','0'),
(2719,1,'2018-06-27 11:27:41','0001-01-01 00:00:00','0'),
(2720,1,'2018-06-27 11:32:13','0001-01-01 00:00:00','0'),
(2721,1,'2018-06-27 11:40:05','0001-01-01 00:00:00','0'),
(2722,1,'2018-06-27 11:42:06','0001-01-01 00:00:00','0'),
(2723,1,'2018-06-27 11:42:36','0001-01-01 00:00:00','0'),
(2724,1,'2018-06-27 11:43:47','0001-01-01 00:00:00','0'),
(2725,1,'2018-06-27 11:45:02','0001-01-01 00:00:00','0'),
(2726,1,'2018-06-27 11:46:53','0001-01-01 00:00:00','0'),
(2727,1,'2018-06-27 11:48:10','0001-01-01 00:00:00','0'),
(2732,1,'2018-06-29 08:48:40','0001-01-01 00:00:00','0'),
(2733,1,'2018-06-29 09:41:31','0001-01-01 00:00:00','0'),
(2734,1,'2018-06-29 09:45:29','0001-01-01 00:00:00','0'),
(2735,1,'2018-06-29 09:47:47','0001-01-01 00:00:00','0'),
(2736,1,'2018-06-29 09:48:40','0001-01-01 00:00:00','0'),
(2737,1,'2018-06-29 09:50:14','0001-01-01 00:00:00','0'),
(2738,1,'2018-06-29 09:51:44','0001-01-01 00:00:00','0'),
(2739,1,'2018-06-29 09:53:06','0001-01-01 00:00:00','0'),
(2740,1,'2018-06-29 09:57:30','0001-01-01 00:00:00','0'),
(2741,1,'2018-06-29 09:58:03','0001-01-01 00:00:00','0'),
(2742,1,'2018-06-29 10:02:26','0001-01-01 00:00:00','0'),
(2744,1,'2018-06-29 11:26:39','0001-01-01 00:00:00','0'),
(2745,1,'2018-06-29 11:28:08','0001-01-01 00:00:00','0'),
(2746,1,'2018-06-29 11:30:13','0001-01-01 00:00:00','0'),
(2750,1,'2018-07-09 10:01:20','0001-01-01 00:00:00','0'),
(2751,1,'2018-07-09 10:15:01','0001-01-01 00:00:00','0'),
(2752,1,'2018-07-09 10:27:55','0001-01-01 00:00:00','0'),
(2753,1,'2018-07-09 10:31:50','0001-01-01 00:00:00','0'),
(2754,1,'2018-07-09 10:36:29','0001-01-01 00:00:00','0'),
(2755,1,'2018-07-09 10:40:45','0001-01-01 00:00:00','0'),
(2756,1,'2018-07-09 10:52:50','0001-01-01 00:00:00','0'),
(2757,1,'2018-07-09 10:53:43','0001-01-01 00:00:00','0'),
(2758,1,'2018-07-09 11:00:11','0001-01-01 00:00:00','0'),
(2759,1,'2018-07-09 11:09:03','0001-01-01 00:00:00','0'),
(2760,1,'2018-07-09 11:12:44','0001-01-01 00:00:00','0'),
(2761,1,'2018-07-09 11:13:47','0001-01-01 00:00:00','0'),
(2762,1,'2018-07-09 11:15:55','0001-01-01 00:00:00','0'),
(2763,1,'2018-07-09 11:23:11','0001-01-01 00:00:00','0'),
(2764,1,'2018-07-09 11:27:35','0001-01-01 00:00:00','0'),
(2765,1,'2018-07-09 11:28:29','0001-01-01 00:00:00','0'),
(2766,1,'2018-07-09 11:37:56','0001-01-01 00:00:00','0'),
(2767,1,'2018-07-09 11:41:50','0001-01-01 00:00:00','0'),
(2768,1,'2018-07-09 11:45:49','0001-01-01 00:00:00','0'),
(2770,1,'2018-07-10 22:12:36','0001-01-01 00:00:00','0'),
(2771,1,'2018-07-10 22:14:00','0001-01-01 00:00:00','0'),
(2772,1,'2018-07-10 22:15:12','0001-01-01 00:00:00','0'),
(2773,1,'2018-07-10 22:19:34','0001-01-01 00:00:00','0'),
(2774,1,'2018-07-10 22:20:48','0001-01-01 00:00:00','0'),
(2777,1,'2018-07-11 20:20:06','0001-01-01 00:00:00','0'),
(2778,1,'2018-07-11 20:22:32','0001-01-01 00:00:00','0'),
(2779,1,'2018-07-11 20:23:58','0001-01-01 00:00:00','0'),
(2780,1,'2018-07-11 20:26:31','0001-01-01 00:00:00','0'),
(2785,1,'2018-07-13 17:05:56','0001-01-01 00:00:00','0'),
(2786,1,'2018-07-13 17:08:52','0001-01-01 00:00:00','0'),
(2787,1,'2018-07-19 18:58:13','0001-01-01 00:00:00','0'),
(2789,1,'2018-07-19 19:17:28','0001-01-01 00:00:00','0'),
(2791,1,'2018-07-19 20:06:04','0001-01-01 00:00:00','0'),
(2793,1,'2018-07-19 22:08:24','0001-01-01 00:00:00','0'),
(2795,1,'2018-07-20 10:54:33','0001-01-01 00:00:00','0'),
(2796,1,'2018-07-20 12:39:46','0001-01-01 00:00:00','0'),
(2797,1,'2018-07-20 12:42:50','0001-01-01 00:00:00','0'),
(2814,1,'2018-08-09 11:42:22','0001-01-01 00:00:00','0'),
(2815,1,'2018-08-09 11:46:20','0001-01-01 00:00:00','0'),
(2816,1,'2018-08-09 11:53:00','0001-01-01 00:00:00','0'),
(2817,1,'2018-08-13 10:49:20','0001-01-01 00:00:00','0'),
(2818,1,'2018-08-13 10:57:27','0001-01-01 00:00:00','0'),
(2819,1,'2018-08-13 11:01:49','0001-01-01 00:00:00','0'),
(2820,1,'2018-08-13 11:04:10','0001-01-01 00:00:00','0'),
(2821,1,'2018-08-13 11:05:32','0001-01-01 00:00:00','0'),
(2822,1,'2018-08-13 11:09:59','0001-01-01 00:00:00','0'),
(2823,1,'2018-08-13 11:16:34','0001-01-01 00:00:00','0'),
(2824,1,'2018-08-13 11:18:44','0001-01-01 00:00:00','0'),
(2825,1,'2018-08-13 11:20:23','0001-01-01 00:00:00','0'),
(2826,1,'2018-08-13 11:21:38','0001-01-01 00:00:00','0'),
(2827,1,'2018-08-13 11:30:36','0001-01-01 00:00:00','0'),
(2828,1,'2018-08-13 11:34:44','0001-01-01 00:00:00','0'),
(2829,1,'2018-08-13 11:40:33','0001-01-01 00:00:00','0'),
(2830,1,'2018-08-13 11:46:57','0001-01-01 00:00:00','0'),
(2831,1,'2018-08-13 11:49:03','0001-01-01 00:00:00','0'),
(2832,1,'2018-08-13 11:50:26','0001-01-01 00:00:00','0'),
(2833,1,'2018-08-13 11:51:24','0001-01-01 00:00:00','0'),
(2834,1,'2018-08-13 11:54:23','0001-01-01 00:00:00','0'),
(2835,1,'2018-08-13 11:55:17','0001-01-01 00:00:00','0'),
(2836,1,'2018-08-13 11:56:09','0001-01-01 00:00:00','0'),
(2837,1,'2018-08-13 12:00:06','0001-01-01 00:00:00','0'),
(2838,1,'2018-08-13 15:04:09','0001-01-01 00:00:00','0'),
(2839,1,'2018-08-13 15:05:24','0001-01-01 00:00:00','0'),
(2840,1,'2018-08-13 15:19:29','0001-01-01 00:00:00','0'),
(2841,1,'2018-08-13 15:29:28','0001-01-01 00:00:00','0'),
(2842,1,'2018-08-13 15:34:06','0001-01-01 00:00:00','0'),
(2843,1,'2018-08-13 16:19:48','0001-01-01 00:00:00','0'),
(2844,1,'2018-08-13 16:21:01','0001-01-01 00:00:00','0'),
(2845,1,'2018-08-13 16:25:24','0001-01-01 00:00:00','0'),
(2846,1,'2018-08-13 16:26:52','0001-01-01 00:00:00','0'),
(2847,1,'2018-08-13 16:28:26','0001-01-01 00:00:00','0'),
(2848,1,'2018-08-13 16:34:19','0001-01-01 00:00:00','0'),
(2849,1,'2018-08-13 16:36:09','0001-01-01 00:00:00','0'),
(2850,1,'2018-08-13 16:41:35','0001-01-01 00:00:00','0'),
(2851,1,'2018-08-13 16:43:09','0001-01-01 00:00:00','0'),
(2852,1,'2018-08-13 16:44:46','0001-01-01 00:00:00','0'),
(2853,1,'2018-08-13 16:47:29','0001-01-01 00:00:00','0'),
(2854,1,'2018-08-13 16:52:17','0001-01-01 00:00:00','0'),
(2855,1,'2018-08-13 16:53:33','0001-01-01 00:00:00','0'),
(2856,1,'2018-08-13 16:59:08','0001-01-01 00:00:00','0'),
(2857,1,'2018-08-13 17:08:38','0001-01-01 00:00:00','0'),
(2858,1,'2018-08-13 17:10:21','0001-01-01 00:00:00','0'),
(2859,1,'2018-08-13 17:18:50','0001-01-01 00:00:00','0'),
(2860,1,'2018-08-13 17:19:46','0001-01-01 00:00:00','0'),
(2861,1,'2018-08-13 17:20:51','0001-01-01 00:00:00','0'),
(2862,1,'2018-08-13 17:21:38','0001-01-01 00:00:00','0'),
(2863,1,'2018-08-13 17:22:31','0001-01-01 00:00:00','0'),
(2864,1,'2018-08-13 17:23:30','0001-01-01 00:00:00','0'),
(2865,1,'2018-08-13 17:24:21','0001-01-01 00:00:00','0'),
(2866,1,'2018-08-13 17:26:34','0001-01-01 00:00:00','0'),
(2867,1,'2018-08-13 17:27:46','0001-01-01 00:00:00','0'),
(2868,1,'2018-08-13 17:28:55','0001-01-01 00:00:00','0'),
(2869,1,'2018-08-13 17:29:58','0001-01-01 00:00:00','0'),
(2873,1,'2018-08-13 22:00:10','0001-01-01 00:00:00','0'),
(2874,1,'2018-08-13 22:11:51','0001-01-01 00:00:00','0'),
(2875,1,'2018-08-13 22:38:50','0001-01-01 00:00:00','0'),
(2876,1,'2018-08-13 22:54:53','0001-01-01 00:00:00','0'),
(2877,1,'2018-08-13 22:56:14','0001-01-01 00:00:00','0'),
(2878,1,'2018-08-13 23:05:32','0001-01-01 00:00:00','0'),
(2879,1,'2018-08-13 23:06:21','0001-01-01 00:00:00','0'),
(2880,1,'2018-08-13 23:10:41','0001-01-01 00:00:00','0'),
(2881,1,'2018-08-13 23:12:44','0001-01-01 00:00:00','0'),
(2884,1,'2018-08-14 10:02:10','0001-01-01 00:00:00','0'),
(2885,1,'2018-08-14 10:05:58','0001-01-01 00:00:00','0'),
(2887,1,'2018-08-14 10:09:46','0001-01-01 00:00:00','0'),
(2889,1,'2018-08-14 10:24:52','0001-01-01 00:00:00','0'),
(2890,1,'2018-08-14 10:29:36','0001-01-01 00:00:00','0'),
(2891,1,'2018-08-14 10:41:54','0001-01-01 00:00:00','0'),
(2892,1,'2018-08-14 10:45:52','0001-01-01 00:00:00','0'),
(2893,1,'2018-08-14 10:51:52','0001-01-01 00:00:00','0'),
(2894,1,'2018-08-14 10:54:01','0001-01-01 00:00:00','0'),
(2895,1,'2018-08-14 11:01:29','0001-01-01 00:00:00','0'),
(2896,1,'2018-08-14 11:05:06','0001-01-01 00:00:00','0'),
(2897,1,'2018-08-14 11:06:45','0001-01-01 00:00:00','0'),
(2898,1,'2018-08-14 11:10:29','0001-01-01 00:00:00','0'),
(2904,1,'2019-04-12 21:51:04','0001-01-01 00:00:00','0'),
(2910,1,'2019-04-13 20:36:40','0001-01-01 00:00:00','0'),
(2918,1,'2019-04-13 21:43:37','0001-01-01 00:00:00','0'),
(2920,1,'2019-04-13 21:47:13','0001-01-01 00:00:00','0'),
(2925,1,'2019-04-13 21:56:04','0001-01-01 00:00:00','0'),
(2932,1,'2019-04-13 22:18:00','0001-01-01 00:00:00','0'),
(2933,1,'2019-04-13 22:20:31','0001-01-01 00:00:00','0'),
(2938,1,'2019-04-13 22:31:27','0001-01-01 00:00:00','0'),
(2939,1,'2019-04-13 22:40:21','0001-01-01 00:00:00','0'),
(2941,1,'2019-04-14 08:55:47','0001-01-01 00:00:00','0'),
(2943,1,'2019-04-14 08:59:00','0001-01-01 00:00:00','0'),
(2944,1,'2019-04-14 09:00:07','0001-01-01 00:00:00','0'),
(2945,1,'2019-04-14 09:00:52','0001-01-01 00:00:00','0'),
(2947,1,'2019-04-14 09:10:40','0001-01-01 00:00:00','0'),
(2950,1,'2019-04-14 09:28:24','0001-01-01 00:00:00','0'),
(2951,1,'2019-04-14 09:31:26','0001-01-01 00:00:00','0'),
(2952,1,'2019-04-14 09:33:26','0001-01-01 00:00:00','0'),
(2954,1,'2019-04-14 09:38:11','0001-01-01 00:00:00','0'),
(2955,1,'2019-04-14 09:39:04','0001-01-01 00:00:00','0'),
(2957,1,'2019-04-14 09:47:09','0001-01-01 00:00:00','0'),
(2958,1,'2019-04-14 09:47:48','0001-01-01 00:00:00','0'),
(2959,1,'2019-04-14 09:48:21','0001-01-01 00:00:00','0'),
(2961,1,'2019-04-14 09:50:15','0001-01-01 00:00:00','0'),
(2962,1,'2019-04-14 09:50:55','0001-01-01 00:00:00','0'),
(2963,1,'2019-04-14 09:53:15','0001-01-01 00:00:00','0'),
(2965,1,'2019-04-14 09:54:39','0001-01-01 00:00:00','0'),
(2966,1,'2019-04-14 09:56:40','0001-01-01 00:00:00','0'),
(2967,1,'2019-04-14 09:57:25','0001-01-01 00:00:00','0'),
(2972,1,'2019-04-14 12:37:11','0001-01-01 00:00:00','0'),
(2973,1,'2019-04-14 12:42:02','0001-01-01 00:00:00','0'),
(2974,1,'2019-04-14 12:48:59','0001-01-01 00:00:00','0'),
(2977,1,'2019-04-14 15:07:06','0001-01-01 00:00:00','0'),
(2978,1,'2019-04-14 15:10:44','0001-01-01 00:00:00','0'),
(2979,1,'2019-04-14 15:19:10','0001-01-01 00:00:00','0'),
(2983,1,'2019-04-14 15:27:45','0001-01-01 00:00:00','0'),
(2984,1,'2019-04-14 15:30:46','0001-01-01 00:00:00','0'),
(2985,1,'2019-04-14 18:05:34','0001-01-01 00:00:00','0'),
(2986,1,'2019-04-14 18:13:48','0001-01-01 00:00:00','0'),
(2987,1,'2019-04-14 18:17:41','0001-01-01 00:00:00','0'),
(2988,1,'2019-04-14 18:56:49','2019-04-17 10:59:52','0'),
(2989,1,'2019-04-14 19:01:26','0001-01-01 00:00:00','0'),
(2990,1,'2019-04-14 19:05:53','2019-04-14 19:08:20','0'),
(2991,1,'2019-04-16 13:54:30','0001-01-01 00:00:00','0'),
(2992,1,'2019-04-16 23:56:05','2019-04-16 23:57:57','0'),
(2993,1,'2019-04-17 10:09:16','0001-01-01 00:00:00','0'),
(2994,1,'2019-04-17 10:20:53','0001-01-01 00:00:00','0'),
(2995,1,'2019-05-26 18:09:05','2019-05-26 18:11:18','0'),
(2996,1,'2019-05-26 19:35:58','2019-05-26 19:36:02','0'),
(2997,1,'2019-06-09 11:35:08','2019-06-09 11:35:14','0'),
(2998,1,'2019-06-09 11:36:09','2019-06-09 11:36:12','0'),
(2999,1,'2019-06-15 10:25:55','2019-06-15 10:26:32','0'),
(3000,1,'2019-06-22 11:15:17','2019-06-22 12:16:25','0'),
(3001,1,'2019-06-23 11:58:37','0001-01-01 00:00:00','0'),
(3002,1,'2019-06-29 15:07:23','0001-01-01 00:00:00','0'),
(3003,1,'2019-07-12 21:42:36','0001-01-01 00:00:00','0'),
(3004,1,'2019-07-13 09:48:36','2019-07-13 10:19:22','0'),
(3005,1,'2019-07-13 11:33:55','0001-01-01 00:00:00','0'),
(3006,1,'2019-07-20 09:52:46','0001-01-01 00:00:00','0'),
(3007,1,'2019-08-10 10:56:43','2019-08-10 11:26:51','0'),
(3008,1,'2019-08-10 14:04:05','0001-01-01 00:00:00','0'),
(3009,1,'2019-08-10 18:00:58','0001-01-01 00:00:00','0'),
(3010,1,'2019-08-18 13:16:47','2019-08-18 13:29:38','0'),
(3011,32,'2019-08-18 13:29:51','2019-08-18 13:47:31','0'),
(3012,1,'2019-08-18 13:47:38','2019-08-18 13:47:43','0'),
(3013,32,'2019-08-18 13:47:50','2019-08-18 13:51:02','0'),
(3014,32,'2019-08-18 13:51:13',NULL,'1'),
(3015,32,'2019-08-18 20:00:55',NULL,'1'),
(3016,32,'2019-08-19 14:00:08',NULL,'1'),
(3017,32,'2019-08-23 18:54:56','2019-08-23 19:29:46','0'),
(3018,34,'2019-08-23 19:29:45','2019-08-23 19:30:42','0'),
(3019,32,'2019-08-23 19:31:00','2019-08-23 19:34:41','0'),
(3020,34,'2019-08-23 19:34:40','2019-09-16 19:16:11','0'),
(3021,32,'2019-08-23 19:34:53','2019-08-23 19:45:15','0'),
(3022,32,'2019-08-24 10:13:08','2019-08-24 12:21:18','0'),
(3023,32,'2019-08-24 18:11:44','2019-08-24 21:28:44','0'),
(3024,32,'2019-08-25 11:06:22',NULL,'1'),
(3025,32,'2019-08-25 22:25:34',NULL,'1'),
(3026,32,'2019-08-31 10:14:30',NULL,'1'),
(3027,32,'2019-08-31 11:37:11',NULL,'1'),
(3028,32,'2019-09-10 13:09:10',NULL,'1'),
(3029,32,'2019-09-11 09:45:25','2019-09-11 12:18:34','0'),
(3030,32,'2019-09-12 11:23:44','2019-09-12 15:55:17','0'),
(3031,32,'2019-09-12 19:47:43','2019-09-12 20:19:32','0'),
(3032,32,'2019-09-13 22:05:16','2019-09-14 03:29:57','0'),
(3033,32,'2019-09-14 11:12:28','2019-09-14 11:46:52','0'),
(3034,32,'2019-09-15 10:06:38','2019-09-15 22:30:55','0'),
(3035,32,'2019-09-16 15:43:11','2019-09-16 16:27:36','0'),
(3036,32,'2019-09-16 19:02:49',NULL,'1'),
(3037,32,'2019-09-16 19:16:20','2019-09-16 21:55:17','0'),
(3038,32,'2019-09-17 22:02:52','2019-09-17 22:28:01','0'),
(3039,32,'2019-09-20 15:52:30',NULL,'1'),
(3040,32,'2019-09-20 15:56:23',NULL,'1'),
(3041,32,'2019-09-21 11:46:47','2019-09-21 11:46:57','0'),
(3042,32,'2019-09-22 11:07:58','2019-09-22 14:54:25','0'),
(3043,32,'2019-09-22 21:35:22',NULL,'1');
/*!40000 ALTER TABLE `sesion` ENABLE KEYS */;

-- 
-- Definition of staff
-- 

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `dob` date NOT NULL,
  `relationship` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `doj` date NOT NULL,
  `address` varchar(255) NOT NULL,
  `mobile` varchar(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `pwd` varchar(32) NOT NULL,
  `gender` char(1) NOT NULL,
  `lastlogin` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table staff
-- 

/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff`(`id`,`name`,`dob`,`relationship`,`department`,`doj`,`address`,`mobile`,`email`,`pwd`,`gender`,`lastlogin`) VALUES
(1,'sunil','1990-05-05 00:00:00','married','revenue','1999-11-11 00:00:00','kestopur12','sunil@gmail','tusolutionweb@gmail.com','tusolutionweb','M','2018-03-10 01:09:17'),
(2,'akash','1998-08-21 00:00:00','unmarried','revenue','2013-08-03 00:00:00','kolkata','9635722546','akash@gmail.com','125','M','2015-01-10 21:22:59'),
(4,'pankaj','1989-05-31 00:00:00','married','revenue','2015-01-04 00:00:00','bhagalpur13','pankaj@gmai','pankaj@gmail.com','789','M','0001-01-01 00:00:00'),
(5,'sharma','1980-04-21 00:00:00','married','revenue','1991-01-01 00:00:00','khidirpur','9876543210','sharma@gmail.com','sharma','M','0001-01-01 00:00:00');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;

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
  `tipoFactura` enum('CONSUMIDOR FINAL','CRÃ‰DITO FISCAL') NOT NULL,
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
(8,'1/4 Galón'),
(9,'1 Galón'),
(10,'Botella'),
(11,'Lata'),
(12,'1/2 Galón'),
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
(31,2,'8f2f470bb9d82081f256a839f1cc8f6c'),
(32,1,'008bd5ad93b754d500338c253d9c1770'),
(33,4,'fdbd31f2027f20378b1a80125fc862db'),
(34,5,'9078f2a8254704bd760460f027072e52');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `kardex`;
DROP VIEW IF EXISTS `kardex`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY INVOKER VIEW `kardex` AS select `v`.`fecha` AS `fecha`,if((isnull(`v`.`nFactura`) or (`v`.`nFactura` = '')),`v`.`idPedido`,`v`.`nFactura`) AS `Documento`,`p`.`idProducto` AS `idProducto`,`p`.`nombre` AS `Descripcion`,'Venta' AS `Tipo`,0 AS `Entradas`,sum(`vd`.`cantidad`) AS `Salidas`,`p`.`costo` AS `costo`,`p`.`stock` AS `stock` from ((`producto` `p` join `pedido_detalle` `vd` on((`p`.`idProducto` = `vd`.`idProducto`))) join `pedido` `v` on((`v`.`idPedido` = `vd`.`idPedido`))) group by `v`.`idPedido`,`vd`.`idProducto` union all select `c`.`fecha` AS `fecha`,`c`.`nComprobante` AS `Documento`,`p`.`idProducto` AS `idProducto`,`p`.`nombre` AS `Descripcion`,'Compra' AS `Tipo`,sum(`cd`.`cantidad`) AS `Entradas`,0 AS `Salidas`,`p`.`costo` AS `costo`,`p`.`stock` AS `stock` from ((`producto` `p` join `compra_detalle` `cd` on((`p`.`idProducto` = `cd`.`idProducto`))) join `compra` `c` on((`cd`.`idCompra` = `c`.`idCompra`))) group by `c`.`idCompra`,`cd`.`idProducto` union all select `a`.`fecha` AS `fecha`,`a`.`idAjuste` AS `Documento`,`p`.`idProducto` AS `idProducto`,`p`.`nombre` AS `Descripcion`,'Ajuste Stock' AS `Tipo`,if((`a`.`tipoAjuste` = 'INCREMENTAR'),`a`.`cantidad`,0) AS `Entradas`,if((`a`.`tipoAjuste` = 'DECREMENTAR'),`a`.`cantidad`,0) AS `Salidas`,`p`.`costo` AS `costo`,`p`.`stock` AS `stock` from (`producto` `p` join `ajuste_stock` `a` on((`p`.`idProducto` = `a`.`idProducto`))) group by `a`.`idAjuste`,`a`.`idProducto`;


-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `cambios`;
DELIMITER |
CREATE TRIGGER IF NOT EXISTS `cambios` BEFORE UPDATE ON `pedido_detalle` FOR EACH ROW BEGIN SET NEW.cantidadAnterior = OLD.cantidad; END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2019-09-22 22:14:50
-- Total time: 0:0:0:2:108 (d:h:m:s:ms)
