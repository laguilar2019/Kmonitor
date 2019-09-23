-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2018-11-25 21:20:33
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
-- Definition of ajuste_stock
-- 

DROP TABLE IF EXISTS `ajuste_stock`;
CREATE TABLE IF NOT EXISTS `ajuste_stock` (
  `idAjuste` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(11) DEFAULT NULL,
  `idMateriaPrima` int(3) DEFAULT NULL,
  `tipoAjuste` enum('INCREMENTAR','DECREMENTAR') NOT NULL,
  `cantidad` decimal(10,2) NOT NULL,
  `justificacion` varchar(300) NOT NULL,
  `fecha` date NOT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  PRIMARY KEY (`idAjuste`),
  KEY `idx_producto1` (`idProducto`),
  KEY `idx_materiaPrima1` (`idMateriaPrima`) USING BTREE,
  KEY `idx_usuario1` (`idUsuario`) USING BTREE,
  CONSTRAINT `fk_materiaPrima1` FOREIGN KEY (`idMateriaPrima`) REFERENCES `materia_prima` (`idMateriaPrima`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_producto1` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
  KEY `idx_cajero1` (`idCajero`),
  CONSTRAINT `fk_usuario2` FOREIGN KEY (`idCajero`) REFERENCES `usuario` (`idUsuario`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table caja
-- 

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;

/*!40000 ALTER TABLE `caja` ENABLE KEYS */;

-- 
-- Definition of categoria
-- 

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `idCategoria` int(3) NOT NULL AUTO_INCREMENT,
  `activo` tinyint(1) NOT NULL,
  `categoria` varchar(255) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table categoria
-- 

/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria`(`idCategoria`,`activo`,`categoria`) VALUES
(2,1,'DESAYUNOS KJ'),
(3,1,'CARNES'),
(4,1,'AVES'),
(5,1,'CARNES '),
(6,1,'EMBUTIDOS  BLANCOS'),
(7,1,'CARNES FRESCAS'),
(8,1,'ELECTRODOMÉSTICOS'),
(9,1,'ZAPATOS'),
(10,0,'HOGAR'),
(11,0,'MUEBLES'),
(12,0,'FONTANERIA'),
(13,0,'HERRAMIENTAS'),
(14,0,'EQUIPO DE CÓMPUTO'),
(15,0,'MULTIMEDIA');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;

-- 
-- Definition of cliente
-- 

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(70) DEFAULT NULL,
  `direccion` varchar(70) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `NIT` varchar(45) DEFAULT NULL,
  `NRC` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table cliente
-- 

/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente`(`idCliente`,`nombre`,`direccion`,`email`,`telefono`,`NIT`,`NRC`) VALUES
(1,'ILIANA MARIA','PAULA ROSA','usuario@yahoo.es','24510305','0308-141485-102-2','6071-5'),
(2,'COMPAÑÍA AZUCARERA SALVADOREÑA S.A. DE C.V.','CANTON HUSICOYOLATE KM 62 1/2 CARRTERA HACIA SONSONATE ','admin@grupocassa.com','24298935','0126-142536-412-8','7845-9'),
(3,'JUAN ANTONIO MELARA','SONSONATE','','24510101','',''),
(4,'OSCAR ALBERTO GOMEZ','SONSONATE','compras@yahoo.es','545155155','1245-859696-415-4','4512-8');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- 
-- Definition of comando
-- 

DROP TABLE IF EXISTS `comando`;
CREATE TABLE IF NOT EXISTS `comando` (
  `idComando` int(2) NOT NULL AUTO_INCREMENT,
  `comando` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idComando`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table comando
-- 

/*!40000 ALTER TABLE `comando` DISABLE KEYS */;
INSERT INTO `comando`(`idComando`,`comando`) VALUES
(1,'COMANDO1'),
(2,'COMANDO2'),
(5,'COMANDO3'),
(6,'COMANDO4'),
(7,'COMANDO5'),
(8,'NUEVO');
/*!40000 ALTER TABLE `comando` ENABLE KEYS */;

-- 
-- Definition of compra
-- 

DROP TABLE IF EXISTS `compra`;
CREATE TABLE IF NOT EXISTS `compra` (
  `idCompra` int(11) NOT NULL AUTO_INCREMENT,
  `tipoCompra` enum('PRODUCTOS','INGREDIENTES') NOT NULL,
  `idProveedor` int(4) NOT NULL,
  `idComprobante` int(2) NOT NULL,
  `nComprobante` varchar(20) NOT NULL,
  `idUsuario` int(3) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `iva` decimal(10,2) NOT NULL,
  `totalPago` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `idx_usuario3` (`idUsuario`),
  KEY `idx_proveedor1` (`idProveedor`),
  KEY `idx_comprobante1` (`idComprobante`),
  CONSTRAINT `fk_comprobante1` FOREIGN KEY (`idComprobante`) REFERENCES `comprobante` (`idComprobante`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_proveedor1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario3` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
  `idMateriaPrima` int(4) DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `subTotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idDetalleCompra`),
  KEY `idx_producto2` (`idProducto`),
  KEY `idx_compra1` (`idCompra`),
  KEY `idx_materiaPrima2` (`idMateriaPrima`),
  CONSTRAINT `fk_compra1` FOREIGN KEY (`idCompra`) REFERENCES `compra` (`idCompra`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_materiPrima2` FOREIGN KEY (`idMateriaPrima`) REFERENCES `materia_prima` (`idMateriaPrima`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_producto2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table comprobante
-- 

/*!40000 ALTER TABLE `comprobante` DISABLE KEYS */;

/*!40000 ALTER TABLE `comprobante` ENABLE KEYS */;

-- 
-- Definition of configuracion
-- 

DROP TABLE IF EXISTS `configuracion`;
CREATE TABLE IF NOT EXISTS `configuracion` (
  `idConfiguracion` int(2) NOT NULL AUTO_INCREMENT,
  `controlStock` tinyint(1) DEFAULT NULL,
  `incluirImpuesto` tinyint(1) DEFAULT NULL,
  `iva` double(10,2) DEFAULT NULL,
  `autorizarDesc` tinyint(1) NOT NULL,
  `printerComanda` varchar(75) DEFAULT NULL,
  `printerFactura` varchar(75) DEFAULT NULL,
  `printerInformes` varchar(75) DEFAULT NULL,
  `alertaCaja` tinyint(1) DEFAULT NULL,
  `multisesion` tinyint(1) NOT NULL,
  `numSesiones` int(11) NOT NULL,
  PRIMARY KEY (`idConfiguracion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table configuracion
-- 

/*!40000 ALTER TABLE `configuracion` DISABLE KEYS */;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table cuenta
-- 

/*!40000 ALTER TABLE `cuenta` DISABLE KEYS */;

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
  KEY `idx_caja1` (`idCaja`),
  KEY `idx_usuario4` (`idUsuario`) USING BTREE,
  CONSTRAINT `fk_caja1` FOREIGN KEY (`idCaja`) REFERENCES `caja` (`idCaja`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario4` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table egreso
-- 

/*!40000 ALTER TABLE `egreso` DISABLE KEYS */;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table empleado
-- 

/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table empresa
-- 

/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;

/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;

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
  KEY `idx_usuario6` (`idUsuario`),
  KEY `idx_sesion1` (`idSesion`),
  CONSTRAINT `fk_sesion1` FOREIGN KEY (`idSesion`) REFERENCES `sesion` (`idSesion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_usuario6` FOREIGN KEY (`idUsuario`) REFERENCES `empleado` (`idEmpleado`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table logfile
-- 

/*!40000 ALTER TABLE `logfile` DISABLE KEYS */;

/*!40000 ALTER TABLE `logfile` ENABLE KEYS */;

-- 
-- Definition of marca
-- 

DROP TABLE IF EXISTS `marca`;
CREATE TABLE IF NOT EXISTS `marca` (
  `idMarca` int(3) NOT NULL AUTO_INCREMENT,
  `marca` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table marca
-- 

/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca`(`idMarca`,`marca`) VALUES
(1,'N/A'),
(2,'SONY'),
(3,'LG'),
(4,'CETRON'),
(5,'OSTER'),
(6,'SANYO'),
(7,'SAMUNG'),
(8,'HP'),
(9,'DELL'),
(10,'ASUS'),
(11,'ARTESANAL'),
(12,'INDUFON'),
(13,'CANON'),
(14,'EPSON');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;

-- 
-- Definition of materia_prima
-- 

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `idMateriaPrima` int(4) NOT NULL AUTO_INCREMENT,
  `idPresentacion` int(3) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `stock` decimal(8,3) unsigned NOT NULL,
  `precio` decimal(8,2) NOT NULL,
  PRIMARY KEY (`idMateriaPrima`),
  KEY `idx_presentacion1` (`idPresentacion`),
  CONSTRAINT `fk_presentacion1` FOREIGN KEY (`idPresentacion`) REFERENCES `presentacion` (`idPresentacion`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table materia_prima
-- 

/*!40000 ALTER TABLE `materia_prima` DISABLE KEYS */;

/*!40000 ALTER TABLE `materia_prima` ENABLE KEYS */;

-- 
-- Definition of pago_mixto
-- 

DROP TABLE IF EXISTS `pago_mixto`;
CREATE TABLE IF NOT EXISTS `pago_mixto` (
  `idPago` int(11) NOT NULL,
  `idVenta` int(11) DEFAULT NULL,
  `idTarjeta` int(3) DEFAULT NULL,
  `pagoEfectivo` decimal(10,2) DEFAULT NULL,
  `pagoTarjeta` decimal(10,2) DEFAULT NULL,
  `totalPago` decimal(10,2) DEFAULT NULL,
  `voucher` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idPago`),
  KEY `idx_venta2` (`idVenta`),
  KEY `idx_tarjeta1` (`idTarjeta`),
  CONSTRAINT `fk_tarjeta1` FOREIGN KEY (`idTarjeta`) REFERENCES `tarjeta_credito` (`idTarjeta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_venta2` FOREIGN KEY (`idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table pago_mixto
-- 

/*!40000 ALTER TABLE `pago_mixto` DISABLE KEYS */;

/*!40000 ALTER TABLE `pago_mixto` ENABLE KEYS */;

-- 
-- Definition of perfil
-- 

DROP TABLE IF EXISTS `perfil`;
CREATE TABLE IF NOT EXISTS `perfil` (
  `idPerfil` int(2) NOT NULL AUTO_INCREMENT,
  `perfil` varchar(30) NOT NULL,
  PRIMARY KEY (`idPerfil`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table perfil
-- 

/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil`(`idPerfil`,`perfil`) VALUES
(1,'ADMINISTRADOR'),
(2,'VENDEDOR'),
(3,'CAJERO'),
(4,'OTROS');
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;

-- 
-- Definition of permiso
-- 

DROP TABLE IF EXISTS `permiso`;
CREATE TABLE IF NOT EXISTS `permiso` (
  `idPerfil` int(2) NOT NULL,
  `idComando` int(2) NOT NULL,
  `fechaCreacion` date DEFAULT NULL,
  KEY `idx_perfil2` (`idPerfil`),
  KEY `idx_comando1` (`idComando`),
  CONSTRAINT `fk_comando1` FOREIGN KEY (`idComando`) REFERENCES `comando` (`idComando`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_perfil2` FOREIGN KEY (`idPerfil`) REFERENCES `perfil` (`idPerfil`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table permiso
-- 

/*!40000 ALTER TABLE `permiso` DISABLE KEYS */;
INSERT INTO `permiso`(`idPerfil`,`idComando`,`fechaCreacion`) VALUES
(3,2,'0001-01-01 00:00:00'),
(2,1,'0001-01-01 00:00:00'),
(3,1,'0001-01-01 00:00:00'),
(1,2,'0001-01-01 00:00:00'),
(1,5,'0001-01-01 00:00:00'),
(1,6,'0001-01-01 00:00:00'),
(1,7,'0001-01-01 00:00:00'),
(1,8,'0001-01-01 00:00:00'),
(2,8,'0001-01-01 00:00:00');
/*!40000 ALTER TABLE `permiso` ENABLE KEYS */;

-- 
-- Definition of presentacion
-- 

DROP TABLE IF EXISTS `presentacion`;
CREATE TABLE IF NOT EXISTS `presentacion` (
  `idPresentacion` int(3) NOT NULL AUTO_INCREMENT,
  `presentacion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idPresentacion`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table presentacion
-- 

/*!40000 ALTER TABLE `presentacion` DISABLE KEYS */;
INSERT INTO `presentacion`(`idPresentacion`,`presentacion`) VALUES
(1,'UNIDAD'),
(2,'LIBRA'),
(3,'ONZAS'),
(4,'GALÓN'),
(5,'CAJA'),
(6,'1/4 GALÓN'),
(7,'QUINTAL');
/*!40000 ALTER TABLE `presentacion` ENABLE KEYS */;

-- 
-- Definition of producto
-- 

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `idProducto` int(11) NOT NULL AUTO_INCREMENT,
  `idCategoria` int(3) DEFAULT NULL,
  `idPresentacion` int(3) DEFAULT NULL,
  `idTipo` int(3) DEFAULT NULL,
  `idMarca` int(3) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `inventariable` tinyint(1) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `idx_tipo1` (`idTipo`),
  KEY `idx_categoria1` (`idCategoria`),
  KEY `idx_presentacion2` (`idPresentacion`),
  KEY `idx_marca1` (`idMarca`),
  CONSTRAINT `fk_categoria1` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_marca1` FOREIGN KEY (`idMarca`) REFERENCES `marca` (`idMarca`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_presentacion2` FOREIGN KEY (`idPresentacion`) REFERENCES `presentacion` (`idPresentacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipo1` FOREIGN KEY (`idTipo`) REFERENCES `tipo_producto` (`idTipo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table producto
-- 

/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto`(`idProducto`,`idCategoria`,`idPresentacion`,`idTipo`,`idMarca`,`descripcion`,`precio`,`costo`,`foto`,`inventariable`,`stock`,`stockMinimo`,`activo`) VALUES
(1,8,1,1,4,'REFRIGERADORA',500.58,350.00,NULL,1,152,5,1),
(2,8,1,1,3,'LAVADORA',500.00,400.00,NULL,1,0,0,1),
(3,8,1,1,5,'PLANCHA',35.00,15.00,NULL,1,10,5,1),
(4,NULL,NULL,NULL,NULL,'COMEDOR',50.00,20.00,NULL,1,0,0,0),
(5,10,1,1,11,'PANERA',150.00,50.00,NULL,1,10,0,1),
(6,NULL,NULL,NULL,NULL,'COMEDOR',90.00,35.00,NULL,0,0,0,1),
(7,8,1,1,5,'MAQUINA DE CORTAR CABELLO',75.82,32.60,NULL,1,100,5,1),
(8,8,1,1,12,'CAMA ERGONÓMICA INDUFON 2 X 2 MTS',275.00,150.00,NULL,1,10,2,1),
(9,NULL,NULL,NULL,NULL,'COMEDOR PARA 4 PERSONAS',575.00,350.00,NULL,0,10,2,1),
(10,NULL,NULL,NULL,NULL,'CHINERO ITALIANO',325.00,250.78,NULL,1,200,10,1),
(11,NULL,NULL,NULL,NULL,'CHINERO FRANCES',175.00,50.00,NULL,0,23,10,0),
(12,10,1,1,1,'CHINERO MEXICANO',1000.00,950.00,NULL,1,10,1,1),
(13,NULL,NULL,NULL,NULL,'CAMAROTE',189.00,130.00,NULL,1,1,1,1),
(14,11,1,1,11,'COMEDOR 6 PERSONAS MADERA A',389.00,200.00,NULL,0,15,2,0),
(15,11,1,1,11,'COMEDOR FAMILIAR',589.00,400.00,NULL,0,15,5,0),
(16,NULL,NULL,NULL,NULL,'TEATRO EN CASA',500.00,200.00,NULL,0,15,1,0),
(17,10,1,1,1,'CAMAROTE TIPO A',300.00,178.00,NULL,1,10,2,1),
(18,NULL,NULL,NULL,NULL,'CAMAROTE TIPO B',189.00,150.00,NULL,0,10,1,0),
(20,8,1,1,3,'LAVADORA 35 LIBRAS',5600.00,750.00,NULL,0,41,10,0),
(21,NULL,NULL,NULL,NULL,'LAVADORA 40 LIBRAS',3561.00,3514.00,NULL,1,12,1,1),
(22,NULL,NULL,NULL,NULL,'LAVADORA 15 LIBRAS ',250.00,200.00,NULL,0,10,10,0),
(23,14,1,1,14,'IMPRESORA EPSON L 300',300.00,250.00,NULL,1,10,10,1),
(24,14,1,1,14,'IMPRESORA EPSON L355',350.00,325.00,NULL,1,10,2,0),
(25,14,1,1,13,'IMPRESORA CANON 201',250.00,200.00,NULL,1,10,20,1),
(26,14,1,1,13,'IMPRESORA CANON 210',200.00,260.00,NULL,1,10,30,1),
(27,NULL,NULL,NULL,NULL,'LICUADORA LG',250.00,350.00,NULL,1,10,5,0),
(28,NULL,NULL,NULL,NULL,'LICUADROA RCA',300.00,250.00,NULL,0,0,0,0),
(29,NULL,NULL,NULL,NULL,'LICUADORA QL',250.00,200.00,NULL,1,10,10,1),
(42,NULL,NULL,NULL,NULL,'SILLLON MADERA',157.25,150.00,NULL,1,10,3,1),
(43,NULL,NULL,NULL,NULL,'SILLA REDONDA',75.00,50.00,NULL,1,0,0,0),
(44,NULL,NULL,NULL,NULL,'MESA DE SALA',45.50,10.00,NULL,0,12,0,0),
(45,NULL,NULL,NULL,NULL,'ALETAS PASEO',45.00,45.00,NULL,0,12,1,0),
(46,2,1,1,1,'TALADRO',45.00,25.00,NULL,0,12,10,0),
(47,NULL,NULL,NULL,NULL,'CAMA PARA NIÑO',40.00,25.00,NULL,0,1,1,0),
(48,NULL,NULL,NULL,NULL,'ELIMINAR ESTE',455.00,45.00,NULL,0,0,0,0),
(49,NULL,NULL,NULL,NULL,'ELIMNAR TOO',100.00,75.00,NULL,1,1,1,0),
(50,NULL,NULL,NULL,NULL,'QUIZAS DELETE',10.00,10.00,NULL,1,1,1,0),
(51,NULL,NULL,NULL,NULL,'CAFETERA OSTER',75.00,50.58,NULL,0,10,5,0),
(52,NULL,NULL,NULL,NULL,'CAFETERA SANYO',78.98,60.00,NULL,0,10,5,0),
(53,NULL,NULL,NULL,NULL,'CHINERO AMERICANO',150.00,125.00,NULL,0,10,5,0),
(54,2,1,1,1,'CHINERO DE MADERA COMPRIMIDA',450.00,350.00,NULL,1,5,5,0),
(55,NULL,NULL,NULL,NULL,'CHINERO METALICO',500.00,350.00,NULL,0,10,5,1),
(56,NULL,NULL,NULL,NULL,'CHINERO DOBLE CARA',350.00,300.00,NULL,1,10,0,1),
(57,NULL,NULL,NULL,NULL,'COLCHONETA INDUFON',300.00,275.00,NULL,0,0,0,1),
(58,NULL,NULL,NULL,NULL,'COLCHONETA PEQUEÑA',150.00,100.00,NULL,1,10,5,1),
(59,15,1,1,14,'PROYECTOR POWER LITE X24',520.00,500.00,NULL,1,10,2,1),
(60,15,1,1,14,'PROYECTOR POWER LITE S500',700.00,650.00,NULL,1,10,0,0);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;

-- 
-- Definition of producto_compuesto
-- 

DROP TABLE IF EXISTS `producto_compuesto`;
CREATE TABLE IF NOT EXISTS `producto_compuesto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idProducto` int(11) NOT NULL,
  `idMateriaPrima` int(4) NOT NULL,
  `cantidad` decimal(8,3) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idx_producto3` (`idProducto`),
  KEY `idx_materiaPrima3` (`idMateriaPrima`),
  CONSTRAINT `fk_materiaPrima3` FOREIGN KEY (`idMateriaPrima`) REFERENCES `materia_prima` (`idMateriaPrima`) ON UPDATE CASCADE,
  CONSTRAINT `fk_producto3` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table producto_compuesto
-- 

/*!40000 ALTER TABLE `producto_compuesto` DISABLE KEYS */;

/*!40000 ALTER TABLE `producto_compuesto` ENABLE KEYS */;

-- 
-- Definition of proveedor
-- 

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE IF NOT EXISTS `proveedor` (
  `idProveedor` int(4) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(70) NOT NULL,
  `direccion` varchar(70) NOT NULL,
  `email` varchar(45) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `NIT` varchar(45) NOT NULL,
  `NRC` varchar(25) NOT NULL,
  `contacto` varchar(45) NOT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table proveedor
-- 

/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor`(`idProveedor`,`nombre`,`direccion`,`email`,`telefono`,`NIT`,`NRC`,`contacto`) VALUES
(1,'OPERADORA DEL SUR MAXI DESPENSA','SONSONATE','alguien@operador.com','24511414','4512-451263-586-9','4512-9','Oscar Sanchez'),
(2,'LA MEGA BOUTIQUE','SONZACATE','ALGUIENMAS@YAHOO.MK','5451252','4512-451245-102-9','4512-9','SAUL VALLE');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;

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
  KEY `idx_usuario5` (`idUsuario`),
  CONSTRAINT `fk_usuario5` FOREIGN KEY (`idUsuario`) REFERENCES `empleado` (`idEmpleado`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table sesion
-- 

/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tarjeta_credito
-- 

/*!40000 ALTER TABLE `tarjeta_credito` DISABLE KEYS */;

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
  `fontSize` int(2) NOT NULL,
  `fontName` varchar(75) NOT NULL,
  PRIMARY KEY (`idTicket`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table ticket
-- 

/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;

/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;

-- 
-- Definition of tipo_producto
-- 

DROP TABLE IF EXISTS `tipo_producto`;
CREATE TABLE IF NOT EXISTS `tipo_producto` (
  `idTipo` int(3) NOT NULL AUTO_INCREMENT,
  `tipo_producto` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idTipo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tipo_producto
-- 

/*!40000 ALTER TABLE `tipo_producto` DISABLE KEYS */;
INSERT INTO `tipo_producto`(`idTipo`,`tipo_producto`) VALUES
(1,'TERMINADO'),
(2,'COMPUESTO');
/*!40000 ALTER TABLE `tipo_producto` ENABLE KEYS */;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tiraje_factura
-- 

/*!40000 ALTER TABLE `tiraje_factura` DISABLE KEYS */;

/*!40000 ALTER TABLE `tiraje_factura` ENABLE KEYS */;

-- 
-- Definition of usuario
-- 

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idUsuario` int(3) NOT NULL,
  `idPerfil` int(2) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `telefono` varchar(25) DEFAULT NULL,
  `login` varchar(35) NOT NULL,
  `password` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idUsuario`),
  KEY `idx_perfil1` (`idPerfil`),
  CONSTRAINT `fk_perfil1` FOREIGN KEY (`idPerfil`) REFERENCES `perfil` (`idPerfil`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table usuario
-- 

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario`(`idUsuario`,`idPerfil`,`nombre`,`email`,`telefono`,`login`,`password`) VALUES
(1,1,'ELMER ISRAEL GALDAMEZ PÉREZ','elmer.galdamez@yahoo.es','24510101','elmer','e15abbd05b363e543814e20fdbe099e167a6e903'),
(2,3,'OSCAR ARNULFO MARTINEZ QUEVEDO','oscar.martinez@yahoo.es','24510101','oscar','d033e22ae348aeb5660fc2140aec35850c4da997'),
(3,2,'JUAN JOSE ANTONIO','juan.melara@yahoo.es','1111','jj','d033e22ae348aeb5660fc2140aec35850c4da997'),
(4,2,'MIGUEL ADALBERTO','','2451414','miguelito','a9993e364706816aba3e25717850c26c9cd0d89d'),
(5,4,'JUAN JOSE','ada','24511111','juan','da39a3ee5e6b4b0d3255bfef95601890afd80709'),
(6,2,'OSWALDO AMILCAR CIENFUEGOS','amilcar@yahoo.es','24510101','amilcar','da39a3ee5e6b4b0d3255bfef95601890afd80709'),
(7,4,'NOE ANTONIO','noeamaya@yahoo.es','24510101','noeamaya','d033e22ae348aeb5660fc2140aec35850c4da997');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- 
-- Definition of venta
-- 

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `idVenta` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) DEFAULT NULL,
  `idSucursal` int(4) DEFAULT NULL,
  `idCuenta` int(2) DEFAULT NULL,
  `idVendedor` int(3) DEFAULT NULL,
  `cancelado` tinyint(1) NOT NULL,
  `fecha` datetime NOT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `descuento` decimal(10,2) DEFAULT NULL,
  `iva` decimal(10,2) NOT NULL,
  `totalPago` decimal(10,2) NOT NULL,
  `idTiraje` int(5) DEFAULT NULL,
  `nFactura` varchar(15) NOT NULL,
  `anular` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idVenta`),
  KEY `idx_cuenta1` (`idCuenta`),
  KEY `idx_cliente1` (`idCliente`),
  KEY `idx_usuario7` (`idVendedor`) USING BTREE,
  KEY `idx_tiraje_factura1` (`idTiraje`),
  CONSTRAINT `fk_cliente1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_cuenta1` FOREIGN KEY (`idCuenta`) REFERENCES `cuenta` (`idCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tiraje_factura1` FOREIGN KEY (`idTiraje`) REFERENCES `tiraje_factura` (`idTiraje`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_usuario7` FOREIGN KEY (`idVendedor`) REFERENCES `usuario` (`idUsuario`) ON DELETE SET NULL ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table venta
-- 

/*!40000 ALTER TABLE `venta` DISABLE KEYS */;

/*!40000 ALTER TABLE `venta` ENABLE KEYS */;

-- 
-- Definition of venta_detalle
-- 

DROP TABLE IF EXISTS `venta_detalle`;
CREATE TABLE IF NOT EXISTS `venta_detalle` (
  `idDetalle` int(11) NOT NULL AUTO_INCREMENT,
  `idVenta` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `subTotal` decimal(10,2) NOT NULL,
  `grupo` varchar(2) NOT NULL,
  `extras` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idDetalle`),
  KEY `idx_producto4` (`idProducto`),
  KEY `idx_venta1` (`idVenta`),
  CONSTRAINT `fk_producto4` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`),
  CONSTRAINT `fk_venta1` FOREIGN KEY (`idVenta`) REFERENCES `venta` (`idVenta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table venta_detalle
-- 

/*!40000 ALTER TABLE `venta_detalle` DISABLE KEYS */;

/*!40000 ALTER TABLE `venta_detalle` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-11-25 21:20:35
-- Total time: 0:0:0:1:734 (d:h:m:s:ms)
