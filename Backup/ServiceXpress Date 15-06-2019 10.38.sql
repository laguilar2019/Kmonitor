-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2019-06-15 10:40:26
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table caja
-- 

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
INSERT INTO `caja`(`idCaja`,`idCajero`,`estado`,`fechaApertura`,`fechaCierre`,`saldoInicial`,`efectivo`,`saldo`) VALUES
(1,1,1,'2019-05-26 18:09:11','0001-01-01 00:00:00',50.00,0.00,-0.70);
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
(1,'Ventas en efectivo','4850000',58.11),
(2,'Ventas tarjeta de credito','155550020221',0.00),
(3,'Pagos Mixtos(Efectivo + Tarjeta de CrÃ©dito)','55251515',0.00);
/*!40000 ALTER TABLE `cuenta` ENABLE KEYS */;

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
  PRIMARY KEY (`idEgreso`),
  KEY `FK_idCaja2_idx` (`idCaja`),
  KEY `Fk_usr_egreso` (`idUsuario`) USING BTREE,
  KEY `Fk_egreso_tipo` (`idEgresoTipo`),
  CONSTRAINT `FK_idCaja2` FOREIGN KEY (`idCaja`) REFERENCES `caja` (`idCaja`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fk_egreso_tipo` FOREIGN KEY (`idEgresoTipo`) REFERENCES `egreso_tipo` (`idEgresoTipo`),
  CONSTRAINT `Fk_usr_egreso` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table egreso
-- 

/*!40000 ALTER TABLE `egreso` DISABLE KEYS */;
INSERT INTO `egreso`(`idEgreso`,`idEgresoTipo`,`idCaja`,`idUsuario`,`fecha`,`descripcion`,`cantidad`) VALUES
(1,2,1,1,'2019-06-07 22:27:04','Compra de azucar',2.50),
(2,3,1,1,'2019-06-07 22:50:37','ADELANTE SALARIAL PARA OSCAR SANCHEZ',20.00),
(3,1,1,1,'2019-06-07 23:00:06','ADELANTO DANIEL',15.20),
(4,3,1,1,'2019-06-09 10:53:11','SOLICITADO POR GABIREL',5.00),
(5,2,1,1,'2019-06-15 10:09:02','COMPRA DE VASOS DESECHABLES',2.00),
(6,4,1,1,'2019-06-15 10:09:50','RECIBO DE AGUA JUNIO',6.00);
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
(1,'SALARÍOS'),
(2,'COMPRAS Ñ'),
(3,'ADELANTO DE SALARIO'),
(4,'PAGO DE SERVICIOS');
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
(30,'Josseline','GÃ³mez','','','70707070','','',0.00,0.00),
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
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table logfile
-- 

/*!40000 ALTER TABLE `logfile` DISABLE KEYS */;
INSERT INTO `logfile`(`idLog`,`idSesion`,`idUsuario`,`fecha`,`log`,`estado`) VALUES
(1,2989,1,'2019-04-14 19:01:54','Ingreso a TPV','Satisfactorio'),
(2,2989,1,'2019-04-14 19:02:03','Agregar nueva venta con ID= 1','Satisfactorio'),
(3,2989,1,'2019-04-14 19:03:03','Ingreso a TPP','Satisfactorio'),
(4,2990,1,'2019-04-14 19:05:53','Inicio de sesiÃ³n','Satisfactorio'),
(5,2990,1,'2019-04-14 19:06:10','Ingreso a la administraciÃ³n de cuentas','Satisfactorio'),
(6,2990,1,'2019-04-14 19:06:25','Ingreso a TPP','Satisfactorio'),
(7,2990,1,'2019-04-14 19:06:59','Ingreso a productos','Satisfactorio'),
(8,2990,1,'2019-04-14 19:07:23','Ingreso a TPV','Satisfactorio'),
(9,2990,1,'2019-04-14 19:07:38','Agregar nueva venta con ID= 2','Satisfactorio'),
(10,2990,1,'2019-04-14 19:08:20','Cierre de sesiÃ³n','Satisfactorio'),
(11,2991,1,'2019-04-16 13:54:30','Inicio de sesiÃ³n','Satisfactorio'),
(12,2991,1,'2019-04-16 13:54:33','Ingreso a TPV','Satisfactorio'),
(13,2991,1,'2019-04-16 13:54:39','Agregar nueva venta con ID= 2','Satisfactorio'),
(14,2991,1,'2019-04-16 13:57:18','Ingreso a TPP','Satisfactorio'),
(15,2991,1,'2019-04-16 14:16:18','Agregar nueva venta con ID= 3','Satisfactorio'),
(16,2991,1,'2019-04-16 14:16:25','Ingreso a TPV','Satisfactorio'),
(17,2991,1,'2019-04-16 14:16:28','Agregar nueva venta con ID= 4','Satisfactorio'),
(18,2991,1,'2019-04-16 14:16:32','Ingreso a TPV','Satisfactorio'),
(19,2991,1,'2019-04-16 14:16:36','Agregar nueva venta con ID= 5','Satisfactorio'),
(20,2992,1,'2019-04-16 23:56:05','Inicio de sesiÃ³n','Satisfactorio'),
(21,2992,1,'2019-04-16 23:56:08','Ingreso a TPV','Satisfactorio'),
(22,2992,1,'2019-04-16 23:57:57','Cierre de sesiÃ³n','Satisfactorio'),
(23,2993,1,'2019-04-17 10:09:16','Inicio de sesiÃ³n','Satisfactorio'),
(24,2993,1,'2019-04-17 10:09:18','Ingreso a TPV','Satisfactorio'),
(25,2993,1,'2019-04-17 10:09:22','Agregar nueva venta con ID= 6','Satisfactorio'),
(26,2994,1,'2019-04-17 10:20:53','Inicio de sesiÃ³n','Satisfactorio'),
(27,2994,1,'2019-04-17 10:20:56','Ingreso a TPV','Satisfactorio'),
(28,2994,1,'2019-04-17 10:21:01','Agregar nueva venta con ID= 7','Satisfactorio'),
(29,2994,1,'2019-04-17 10:21:55','Ingreso a TPV','Satisfactorio'),
(30,2994,1,'2019-04-17 10:21:58','Agregar nueva venta con ID= 8','Satisfactorio'),
(31,2988,1,'2019-04-17 10:45:42','Ingreso a TPP','Satisfactorio'),
(32,2988,1,'2019-04-17 10:49:17','Agregar nueva venta con ID= 9','Satisfactorio'),
(33,2988,1,'2019-04-17 10:59:52','Cierre de sesión','Satisfactorio'),
(34,2995,1,'2019-05-26 18:09:05','Inicio de sesión','Satisfactorio'),
(35,2995,1,'2019-05-26 18:09:16','Apertura de caja','Satisfactorio'),
(36,2995,1,'2019-05-26 18:11:18','Cierre de sesión','Satisfactorio'),
(37,2996,1,'2019-05-26 19:35:58','Inicio de sesión','Satisfactorio'),
(38,2996,1,'2019-05-26 19:36:02','Cierre de sesión','Satisfactorio'),
(39,2997,1,'2019-06-09 11:35:08','Inicio de sesión','Satisfactorio'),
(40,2997,1,'2019-06-09 11:35:14','Cierre de sesión','Satisfactorio'),
(41,2998,1,'2019-06-09 11:36:09','Inicio de sesión','Satisfactorio'),
(42,2998,1,'2019-06-09 11:36:12','Cierre de sesión','Satisfactorio'),
(43,2999,1,'2019-06-15 10:25:55','Inicio de sesión','Satisfactorio'),
(44,2999,1,'2019-06-15 10:26:00','Ingreso a Datos de la Empresa','Satisfactorio'),
(45,2999,1,'2019-06-15 10:26:32','Cierre de sesión','Satisfactorio');
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table mesa
-- 

/*!40000 ALTER TABLE `mesa` DISABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido
-- 

/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido`(`idPedido`,`idCliente`,`idMesa`,`idCuenta`,`idMesero`,`cancelado`,`fecha`,`listo`,`total`,`descuento`,`iva`,`propina`,`totalPago`,`idTiraje`,`nFactura`,`anular`) VALUES
(1,NULL,NULL,1,NULL,0,'2019-04-14 19:05:07',0,10.75,0.00,1.40,1.08,13.23,NULL,'',0),
(2,NULL,NULL,1,NULL,0,'2019-04-16 13:54:33',2,12.00,0.00,0.00,0.00,0.00,NULL,'',0),
(3,NULL,NULL,1,NULL,1,'2019-04-17 10:46:07',2,19.99,0.00,2.60,2.00,24.59,NULL,'',0),
(4,3,NULL,1,NULL,0,'2019-04-16 14:16:25',2,2.75,0.00,0.00,0.00,0.00,NULL,'',0),
(5,NULL,NULL,1,NULL,1,'2019-04-17 10:46:28',2,5.50,0.00,0.72,0.55,6.77,NULL,'',0),
(6,NULL,NULL,1,NULL,1,'2019-04-17 10:46:54',2,11.00,0.00,1.43,1.10,13.53,NULL,'',0),
(7,NULL,NULL,1,NULL,0,'2019-04-17 10:20:57',2,32.71,0.00,0.00,0.00,0.00,NULL,'',0),
(8,NULL,NULL,1,NULL,0,'2019-04-17 10:21:55',2,32.48,0.00,0.00,0.00,0.00,NULL,'',0),
(9,NULL,NULL,1,NULL,0,'2019-04-17 10:47:00',2,8.00,0.00,0.00,0.00,0.00,NULL,'',0);
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
  PRIMARY KEY (`idDetalle`),
  KEY `FK8EC261C66039B36F_idx` (`idProducto`),
  KEY `FK8EC261C6B9DECED7_idx` (`idCocinero`),
  KEY `fk_pedido_detalle_pedido1_idx` (`idPedido`),
  CONSTRAINT `FK8EC261C66039B36F` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`),
  CONSTRAINT `FK8EC261C6B9DECED7` FOREIGN KEY (`idCocinero`) REFERENCES `cocinero` (`idCocinero`),
  CONSTRAINT `fk_pedido_detalle_pedido1` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table pedido_detalle
-- 

/*!40000 ALTER TABLE `pedido_detalle` DISABLE KEYS */;
INSERT INTO `pedido_detalle`(`idDetalle`,`cocinando`,`extras`,`horaEntregado`,`horaPedido`,`idCocinero`,`idProducto`,`idPedido`,`cantidad`,`precio`,`subTotal`,`grupo`) VALUES
(1,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,49,1,5,0.75,3.75,''),
(2,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,48,1,1,1.00,1.00,''),
(3,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,46,1,1,1.00,1.00,''),
(4,1,'','2019-04-14 19:01:55','2019-04-14 19:01:55',NULL,38,1,5,1.00,5.00,''),
(5,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,38,2,10,1.00,10.00,''),
(6,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,44,2,1,1.00,1.00,''),
(7,1,'','2019-04-16 13:54:33','2019-04-16 13:54:33',NULL,45,2,1,1.00,1.00,''),
(8,1,'','2019-04-16 14:16:16','2019-04-16 14:16:16',NULL,119,3,2,6.00,12.00,''),
(9,1,'','2019-04-16 14:16:16','2019-04-16 14:16:16',NULL,9,3,1,7.99,7.99,''),
(10,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,38,4,1,1.00,1.00,''),
(11,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,49,4,1,0.75,0.75,''),
(12,1,'','2019-04-16 14:16:25','2019-04-16 14:16:25',NULL,48,4,1,1.00,1.00,''),
(13,1,'','2019-04-16 14:16:32','2019-04-16 14:16:32',NULL,63,5,1,2.50,2.50,''),
(14,1,'','2019-04-16 14:16:32','2019-04-16 14:16:32',NULL,58,5,1,3.00,3.00,''),
(15,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,64,6,1,3.00,3.00,''),
(16,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,63,6,1,2.50,2.50,''),
(17,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,59,6,1,3.00,3.00,''),
(18,1,'','2019-04-17 10:09:18','2019-04-17 10:09:18',NULL,65,6,1,2.50,2.50,''),
(19,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,117,7,1,7.99,7.99,''),
(20,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,7,7,2,9.49,18.98,''),
(21,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,4,7,1,3.49,3.49,''),
(22,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,67,7,1,1.00,1.00,''),
(23,1,'','2019-04-17 10:20:57','2019-04-17 10:20:57',NULL,111,7,1,1.25,1.25,''),
(24,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,64,8,1,3.00,3.00,''),
(25,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,65,8,3,2.50,7.50,''),
(26,1,'','2019-04-17 10:21:55','2019-04-17 10:21:55',NULL,16,8,2,10.99,21.98,''),
(27,1,'','2019-04-17 10:47:00','2019-04-17 10:47:00',NULL,111,9,4,1.25,5.00,''),
(28,1,'','2019-04-17 10:47:00','2019-04-17 10:47:00',NULL,67,9,3,1.00,3.00,'');
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
(4,26,1,'DESAYUNO E. CON JAMON','DESAYUNO E. CON JAMON',3.49,0.00,'huevos con jamon.jpg',0,0,-122,0,1),
(5,26,1,'DESAYUNO RANCHERO','DESAYUNO RANCHERO',3.99,0.00,'thVIDR5HF5.jpg',0,0,-109,0,1),
(6,27,1,'CHURRASCO ARGENTINO','CHURRASCO ARGENTINO',8.49,0.00,'CHURRASCO.jpg',1,0,-155,0,1),
(7,27,1,'TIPICO B.A','TIPICO B.A',9.49,0.00,'TIPICO.jpg',1,0,-173,0,1),
(8,28,1,'PECHUGA EN SALSA BARBACOA','PECHUGA EN SALSA BARBACOA',7.99,0.00,'pechuga a la barbacoa 023.JPG',1,0,-8,0,1),
(9,28,1,'PECHUGA A LA PLANCHA','PECHUGA A LA PLANCHA',7.99,0.00,'PLANCHA.jpg',1,0,-41,0,1),
(10,28,1,'P. EN SALSA DE HONGOS','P. EN SALSA DE HONGOS',7.99,0.00,'thOG1JF1A3.jpg',1,0,-98,0,1),
(11,29,1,'MARISCADA NATURAL','MARISCADA NATURAL',9.99,0.00,'NATURAL.jpg',1,0,-16,0,1),
(12,29,1,'MARISCADA CON CREMA','MARISCADA CON CREMA',10.99,0.00,'NATURAL.jpg',1,0,-35,0,1),
(13,29,1,'PESCADO PEQUEÃ‘O','PESCADO PEQUEÃ‘O',5.99,0.00,'thA3FONYEV.jpg',1,0,-12,0,1),
(14,29,1,'PESCADO GRANDE','PESCADO GRANDE',7.99,0.00,'thA3FONYEV.jpg',1,0,-1,0,1),
(15,29,1,'PESCADO B.A','PESCADO B.A',9.49,0.00,'pargo-fresco.jpg',1,0,-4,0,1),
(16,30,1,'CAMARONES A LA MEXICANA','CAMARONES A LA MEXICANA',10.99,0.00,'MEXICANA.jpg',1,0,12,0,1),
(17,30,1,'CAMARONES AL AJILLO','CAMARONES AL AJILLO',10.99,0.00,'thDOD86NEQ.jpg',1,0,-26,0,1),
(18,30,1,'CAMARONES A LA PLANCHA','CAMARONES A LA PLANCHA',10.99,0.00,'PLANCHA.png',1,0,-18,0,1),
(19,31,1,'COCTEL DE CONCHA','COCTEL DE CONCHA',5.99,0.00,'coctel_de_concha.jpg',1,0,-17,0,1),
(20,31,1,'COCTEL CAMARON NATURAL','COCTEL CAMARON NATURAL',5.99,0.00,'coctel-de-camarones.jpg',1,0,-28,0,1),
(21,31,1,'COCTEL CAMARON S.R','COCTEL CAMARON S.R',6.99,0.00,'CocktailCamarones.jpg',1,0,-37,0,1),
(22,31,1,'COCTEL MIXTO','COCTEL MIXTO',6.99,0.00,'coctel-de-camarones.jpg',1,0,-8,0,1),
(23,32,1,'SANDWICH DE POLLO','SANDWICH DE POLLO',4.99,0.00,'thDWSIPJWL.jpg',0,0,-51,0,1),
(24,32,1,'SANDWICH DE JAMON','SANDWICH DE JAMON',4.99,0.00,'thDWSIPJWL.jpg',0,0,-17,0,1),
(25,32,1,'HAMBURGUESA','HAMBURGUESA',5.99,0.00,'BK_300x270_hamburguesa_deluxe_queso.png',1,0,-52,0,1),
(26,32,1,'PASTA ALFREDO CON POLLO','PASTA ALFREDO CON POLLO',6.99,0.00,'Spaghetti Alfredo 2.jpg',1,0,-13,0,1),
(27,32,1,'PASTA A. CON CAMARONES','PASTA A. CON CAMARONES',6.99,0.00,'light-fettucine-alfredo.jpg',1,0,-4,0,1),
(28,32,1,'PINCHOS DE POLLO','PINCHOS DE POLLO',5.99,0.00,'th9VZQVY8K.jpg',1,0,-6,0,1),
(29,32,1,'PINCHOS DE CARNE','PINCHOS DE CARNE ',5.99,0.00,'maxresdefault.jpg',1,0,-9,0,1),
(30,33,1,'ENSALADA FRESCA CON ATUN','ENSALADA FRESCA CON ATUN',6.99,0.00,'Ensalada-con-atÃºn.jpg',0,0,-2,0,1),
(31,33,1,'ENSALADA CON POLLO','ENSALADA CON POLLO',5.99,0.00,'ensalada.jpg',0,0,-40,0,1),
(32,33,1,'ENSALADA FRESCA','ENSALADA FRESCA',3.49,0.00,'ensalada_14.jpg',0,0,-5,0,1),
(33,34,1,'SORBETE','SORBETE',1.24,0.00,'sorbete-de-pina-e1301363574168.jpg',1,0,-44,0,1),
(34,34,1,'TRES LECHES','TRES LECHES',2.49,0.00,'tres-leches-cake.jpg',1,0,-13,0,1),
(35,34,1,'BUDIN','BUDIN',2.49,0.00,'thLR3V091F.jpg',1,0,-130,0,1),
(36,34,1,'QUESADILLA','QUESADILLA',2.49,0.00,'quesadilla-salvadoreÃ±a-receta.jpg',1,0,-209,0,1),
(37,34,1,'CHEESECAKE','CHEESECAKE',2.49,0.00,'thSF3OP0GU.jpg',1,0,-62,0,1),
(38,35,1,'COCA-COLA','COCA-COLA',1.00,0.00,'coca-cola.jpg',1,0,-175,0,1),
(39,35,1,'SPRITE','SPRITE',1.00,0.00,'th3MVWSHXB.jpg',1,0,-16,0,1),
(40,35,1,'FRESA','FRESA',1.00,0.00,'tropical.png',1,0,-9,0,1),
(41,35,1,'FRESCA','FRESCA',1.00,0.00,'fresca_banner.jpg',1,0,-30,0,1),
(42,35,1,'SUPERCHAMPAN','SUPERCHAMPAN',1.00,0.00,'th59IFH6F2.jpg',1,0,-13,0,1),
(43,35,1,'UVA','UVA',1.00,0.00,'thBU54H9FD.jpg',1,0,-44,0,1),
(44,35,1,'CREMA SODA','CREMA SODA',1.00,0.00,'cremasoda.png',1,0,-45,0,1),
(45,35,1,'FANTA','FANTA',1.00,0.00,'fanta.png',1,0,-71,0,1),
(46,35,1,'COCA ZERO','COCA ZERO',1.00,0.00,'thHQVQXPUA.jpg',1,0,2,0,1),
(47,35,1,'COCA LIGHT','COCA LIGHT',1.00,0.00,'thDSHKTBQG.jpg',1,0,5,0,1),
(48,35,1,'AGUA MINERAL','AGUA MINERAL',1.00,0.00,'thBX4HO3FU.jpg',1,0,-24,0,1),
(49,35,1,'AGUA','AGUA',0.75,0.00,'thC1NDDPNZ.jpg',1,0,-56,0,1),
(50,35,1,'FUZE TEA','FUZE TEA',1.00,0.00,'thK7PZA7HD.jpg',1,0,14,0,1),
(51,37,1,'PILSENER','PILSENER',1.50,0.00,'pilsener-logo-F398838DC9-seeklogo.com.gif.jpg',1,0,-34,0,1),
(52,37,1,'GOLDEN','GOLDEN',1.50,0.00,'178058303_ae23122bff.jpg',1,0,-17,0,1),
(53,37,1,'SUPREMA','SUPREMA',2.00,0.00,'th7KCS3B62.jpg',1,0,-79,0,1),
(54,37,1,'CORONA','CORONA',2.50,0.00,'thHBP0L15S.jpg',1,0,-49,0,1),
(55,37,1,'SMIRNOFF','SMIRNOFF',2.50,0.00,'Smirnoff-_ice_sabores.jpg',1,0,13,0,1),
(56,37,1,'HEYNEKEN','HEYNEKEN',2.50,0.00,'thYSMTB77V.jpg',1,0,132,0,1),
(57,37,1,'MODELO','MODELO',2.50,0.00,'thDASHQ7MM.jpg',1,0,67,0,1),
(58,41,1,'FROZEN DE FRESA','FROZEN DE FRESA',3.00,0.00,'thDT9R1D2Q.jpg',1,0,-65,0,1),
(59,41,1,'FROZEN DE COCO ','FROZEN DE COCO',3.00,0.00,'thJ109J02A.jpg',1,0,-25,0,1),
(60,41,1,'FROZEN DE SANDIA ','FROZEN DE SANDIA',3.00,0.00,'th.jpg',1,0,-33,0,1),
(61,41,1,'LIMONADA ESPECIAL','LIMONADA ESPECIAL',2.00,0.00,'thXZMD5F9G.jpg',0,0,-186,0,1),
(62,41,1,'LICUADO DE GUINEO','LICUADO DE GUINEO',2.50,0.00,'untitled.png',1,0,-42,0,1),
(63,41,1,'LICUADO DE FRESA','LICUADO DE FRESA ',2.50,0.00,'thGIEYJX3Y.jpg',1,0,-33,0,1),
(64,41,1,'JUGO DE NARANJA','JUGO DE NARANJA',3.00,0.00,'th38DAKPHQ.jpg',0,0,-137,0,1),
(65,41,1,'CAFE CON HELADO','CAFE CON HELADO',2.50,0.00,'thJYSS9NOR.jpg',0,0,-37,0,1),
(66,36,1,'CHOCOLATE','CHOCOLATE',1.00,0.00,'thU4GDHPV9.jpg',1,0,-268,0,1),
(67,36,1,'CAFE','CAFE',1.00,0.00,'th9E80TPUM.jpg',1,0,-425,0,1),
(68,36,1,'CAFE CON LECHE','CAFE CON LECHE',1.25,0.00,'thB4HM8JB6.jpg',1,0,-100,0,1),
(69,36,1,'LECHE','LECHE',1.00,0.00,'thB4HM8JB6.jpg',1,0,-24,0,1),
(70,36,1,'TE VERDE','TE VERDE',1.25,0.00,'th32ARK324.jpg',1,0,-21,0,1),
(71,36,1,'TE DE MANZANILLA','TE DE MANZANILLA',1.25,0.00,'th32ARK324.jpg',1,0,-37,0,1),
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
(108,35,1,'HORCHATA','HORCHATA',1.00,0.00,'horchata.jpg',0,0,-43,0,1),
(109,47,1,'PLATO DE BOCA PEQUEÃ‘O','',5.00,0.00,'atun1.jpg',0,0,-22,0,1),
(110,47,1,'PLATO DE BOCA MEDIA','PLATO DE BOCA MEDIANO',10.00,0.00,'carta_laconGallego.jpg',0,0,-3,0,1),
(111,36,1,'CHOCOLATE CON LECHE','CHOCOLATE CON LECHE',1.25,0.00,'thVIW8K0CU.jpg',0,0,-40,0,1),
(112,44,1,'ORDEN DE CHORIZO','ORDEN DE CHORIZO',1.00,0.00,'croquetas2.gif',0,0,-8,0,1),
(113,33,1,'ENSALADA DE VEGETALES','ENSALADA DE VEGETALES',3.49,0.00,'raviolis_con_cebollino.jpg',0,0,-7,0,1),
(114,44,1,'PAN CON AJO','PAN CON AJO',0.50,0.00,'',0,0,-13,0,1),
(115,37,1,'VALDE DE PILSENER','VALDE DE PILSENER',8.00,0.00,'',0,0,-17,0,1),
(116,38,1,'MICHELADA MIX','MICHELADA MIX',3.75,0.00,'',0,0,-8,0,1),
(117,27,1,'COSTILLON B.A','COSTILLON B.A',7.99,0.00,'carta_costillas.jpg',1,0,21,0,1),
(118,37,1,'VALDE GOLDEN','VALDE GOLDEN',8.00,0.00,'',1,0,-19,0,1),
(119,28,9,'ALITAS SBBQ','ALITAS SBBQ',6.00,0.00,'',1,0,-11,0,1),
(120,34,1,'PASTEL DE CHOCOLATE','PASTEL DE CHOCOLATE',2.49,0.00,'',1,0,-10,0,1),
(122,37,1,'HIELERAZO GOLDEN','HIELERAZO GOLDEN ',24.00,0.00,'',1,0,-1,0,1),
(123,37,1,'HIELERAZO','HIELERAZO',24.00,0.00,'thB4HM8JB6.jpg',1,0,-3,0,1),
(124,37,1,'HIELERAZO.B','HIELERAZO.B',30.00,0.00,'thB4HM8JB6.jpg',1,0,-10,0,1),
(125,37,1,'VALDE DE MODELO ','VALDE DE MODELO',10.00,0.00,'',1,0,0,0,1),
(126,37,1,'VALDE MODELO 5','VALDE  MODELO 5',10.00,0.00,'',1,0,-1,0,1),
(127,37,1,'BALDE SUPREMA','BALDE SUPREMA',10.00,0.00,'',1,0,-3,0,1),
(128,38,1,'MARGARITA','',5.00,0.00,'',1,0,-5,0,1),
(129,38,1,'TEQUILA','SENCILLO',5.00,0.00,'',1,0,-1,0,1),
(130,38,1,'TEQUILA DOBLE','',10.00,0.00,'',1,0,-4,0,1),
(131,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,0,0,0),
(132,28,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,0,0,0),
(133,37,1,'5 CORONAS','5 CORONAS',11.00,0.00,'',1,0,-4,0,1),
(134,44,1,'PORCION DE GALLINA','PORCION DE GALLINA',4.49,0.00,'',1,0,-1,0,1),
(135,44,1,'ORDEN DE CAMARONES','ORDEN DE CAMARONES',5.49,0.00,'',1,0,-1,0,1),
(136,44,1,'ORDEN DE CARNE','',3.00,0.00,'',1,0,-1,0,1),
(137,45,1,'COSTILLA DE CERDO AHUMADA','',7.99,0.00,'',1,0,-8,0,1),
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table salon
-- 

/*!40000 ALTER TABLE `salon` DISABLE KEYS */;

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
) ENGINE=InnoDB AUTO_INCREMENT=3000 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table sesion
-- 

/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;
INSERT INTO `sesion`(`idSesion`,`idUsuario`,`fecha`,`fechaFin`,`estadoSesion`) VALUES
(2633,1,'2018-05-04 16:36:55',NULL,'1'),
(2634,1,'2018-05-04 17:22:28',NULL,'1'),
(2635,1,'2018-05-04 17:23:52',NULL,'1'),
(2636,1,'2018-05-04 17:31:18',NULL,'1'),
(2637,1,'2018-05-04 17:33:01',NULL,'1'),
(2638,1,'2018-05-04 17:51:23',NULL,'1'),
(2641,1,'2018-06-23 11:18:38',NULL,'1'),
(2642,1,'2018-06-23 11:38:28',NULL,'1'),
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
(2702,1,'2018-06-26 19:03:08',NULL,'1'),
(2703,1,'2018-06-26 19:11:32',NULL,'1'),
(2704,1,'2018-06-26 19:14:59',NULL,'1'),
(2705,1,'2018-06-26 19:17:32',NULL,'1'),
(2706,1,'2018-06-26 19:24:31',NULL,'1'),
(2707,1,'2018-06-26 19:25:35',NULL,'1'),
(2709,1,'2018-06-26 19:42:39',NULL,'1'),
(2710,1,'2018-06-27 10:19:31',NULL,'1'),
(2711,1,'2018-06-27 10:27:21',NULL,'1'),
(2712,1,'2018-06-27 10:29:12',NULL,'1'),
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
(2744,1,'2018-06-29 11:26:39',NULL,'1'),
(2745,1,'2018-06-29 11:28:08',NULL,'1'),
(2746,1,'2018-06-29 11:30:13',NULL,'1'),
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
(2770,1,'2018-07-10 22:12:36',NULL,'1'),
(2771,1,'2018-07-10 22:14:00',NULL,'1'),
(2772,1,'2018-07-10 22:15:12',NULL,'1'),
(2773,1,'2018-07-10 22:19:34',NULL,'1'),
(2774,1,'2018-07-10 22:20:48',NULL,'1'),
(2777,1,'2018-07-11 20:20:06',NULL,'1'),
(2778,1,'2018-07-11 20:22:32',NULL,'1'),
(2779,1,'2018-07-11 20:23:58',NULL,'1'),
(2780,1,'2018-07-11 20:26:31',NULL,'1'),
(2785,1,'2018-07-13 17:05:56',NULL,'1'),
(2786,1,'2018-07-13 17:08:52',NULL,'1'),
(2787,1,'2018-07-19 18:58:13',NULL,'1'),
(2789,1,'2018-07-19 19:17:28',NULL,'1'),
(2791,1,'2018-07-19 20:06:04',NULL,'1'),
(2793,1,'2018-07-19 22:08:24',NULL,'1'),
(2795,1,'2018-07-20 10:54:33',NULL,'1'),
(2796,1,'2018-07-20 12:39:46',NULL,'1'),
(2797,1,'2018-07-20 12:42:50',NULL,'1'),
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
(2873,1,'2018-08-13 22:00:10',NULL,'1'),
(2874,1,'2018-08-13 22:11:51',NULL,'1'),
(2875,1,'2018-08-13 22:38:50',NULL,'1'),
(2876,1,'2018-08-13 22:54:53',NULL,'1'),
(2877,1,'2018-08-13 22:56:14',NULL,'1'),
(2878,1,'2018-08-13 23:05:32',NULL,'1'),
(2879,1,'2018-08-13 23:06:21',NULL,'1'),
(2880,1,'2018-08-13 23:10:41',NULL,'1'),
(2881,1,'2018-08-13 23:12:44',NULL,'1'),
(2884,1,'2018-08-14 10:02:10',NULL,'1'),
(2885,1,'2018-08-14 10:05:58',NULL,'1'),
(2887,1,'2018-08-14 10:09:46',NULL,'1'),
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
(2904,1,'2019-04-12 21:51:04',NULL,'1'),
(2910,1,'2019-04-13 20:36:40',NULL,'1'),
(2918,1,'2019-04-13 21:43:37',NULL,'1'),
(2920,1,'2019-04-13 21:47:13',NULL,'1'),
(2925,1,'2019-04-13 21:56:04',NULL,'1'),
(2932,1,'2019-04-13 22:18:00',NULL,'1'),
(2933,1,'2019-04-13 22:20:31',NULL,'1'),
(2938,1,'2019-04-13 22:31:27',NULL,'1'),
(2939,1,'2019-04-13 22:40:21',NULL,'1'),
(2941,1,'2019-04-14 08:55:47',NULL,'1'),
(2943,1,'2019-04-14 08:59:00',NULL,'1'),
(2944,1,'2019-04-14 09:00:07',NULL,'1'),
(2945,1,'2019-04-14 09:00:52',NULL,'1'),
(2947,1,'2019-04-14 09:10:40',NULL,'1'),
(2950,1,'2019-04-14 09:28:24',NULL,'1'),
(2951,1,'2019-04-14 09:31:26',NULL,'1'),
(2952,1,'2019-04-14 09:33:26',NULL,'1'),
(2954,1,'2019-04-14 09:38:11',NULL,'1'),
(2955,1,'2019-04-14 09:39:04',NULL,'1'),
(2957,1,'2019-04-14 09:47:09',NULL,'1'),
(2958,1,'2019-04-14 09:47:48',NULL,'1'),
(2959,1,'2019-04-14 09:48:21',NULL,'1'),
(2961,1,'2019-04-14 09:50:15',NULL,'1'),
(2962,1,'2019-04-14 09:50:55',NULL,'1'),
(2963,1,'2019-04-14 09:53:15',NULL,'1'),
(2965,1,'2019-04-14 09:54:39',NULL,'1'),
(2966,1,'2019-04-14 09:56:40',NULL,'1'),
(2967,1,'2019-04-14 09:57:25',NULL,'1'),
(2972,1,'2019-04-14 12:37:11',NULL,'1'),
(2973,1,'2019-04-14 12:42:02',NULL,'1'),
(2974,1,'2019-04-14 12:48:59',NULL,'1'),
(2977,1,'2019-04-14 15:07:06',NULL,'1'),
(2978,1,'2019-04-14 15:10:44',NULL,'1'),
(2979,1,'2019-04-14 15:19:10',NULL,'1'),
(2983,1,'2019-04-14 15:27:45',NULL,'1'),
(2984,1,'2019-04-14 15:30:46',NULL,'1'),
(2985,1,'2019-04-14 18:05:34',NULL,'1'),
(2986,1,'2019-04-14 18:13:48',NULL,'1'),
(2987,1,'2019-04-14 18:17:41',NULL,'1'),
(2988,1,'2019-04-14 18:56:49','2019-04-17 10:59:52','0'),
(2989,1,'2019-04-14 19:01:26',NULL,'1'),
(2990,1,'2019-04-14 19:05:53','2019-04-14 19:08:20','0'),
(2991,1,'2019-04-16 13:54:30',NULL,'1'),
(2992,1,'2019-04-16 23:56:05','2019-04-16 23:57:57','0'),
(2993,1,'2019-04-17 10:09:16',NULL,'1'),
(2994,1,'2019-04-17 10:20:53',NULL,'1'),
(2995,1,'2019-05-26 18:09:05','2019-05-26 18:11:18','0'),
(2996,1,'2019-05-26 19:35:58','2019-05-26 19:36:02','0'),
(2997,1,'2019-06-09 11:35:08','2019-06-09 11:35:14','0'),
(2998,1,'2019-06-09 11:36:09','2019-06-09 11:36:12','0'),
(2999,1,'2019-06-15 10:25:55','2019-06-15 10:26:32','0');
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
(8,'1/4 GalÃƒÂ³n'),
(9,'1 GalÃƒÂ³n'),
(10,'Botella'),
(11,'Lata'),
(12,'1/2 GalÃƒÂ³n'),
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


-- Dump completed on 2019-06-15 10:40:27
-- Total time: 0:0:0:0:325 (d:h:m:s:ms)
