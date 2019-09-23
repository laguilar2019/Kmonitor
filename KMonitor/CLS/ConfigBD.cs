using DBM.CLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMonitor.CLS
{
    class ConfigBD
    {
        DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
        public bool crearTablaEgresoTipo()
        {
            bool result = true;
            string sql1 = "CREATE TABLE IF NOT EXISTS `egreso_tipo` (`idEgresoTipo` int(3) NOT NULL,`egresoTipo` varchar(255) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = latin1";
            string sql2 = "ALTER TABLE `egreso_tipo` ADD PRIMARY KEY if NOT EXISTS(`idEgresoTipo`)";
            if(!Trans.CreateTransaction(sql1, sql2))
                result= false;
            string sql3 = "ALTER TABLE `egreso` ADD IF NOT EXISTS `idEgresoTipo` INT(3) NULL AFTER `idEgreso`";
            string sql4 = "ALTER TABLE `egreso` ADD IF NOT EXISTS `nReferencia` VARCHAR(20) NOT NULL AFTER `cantidad`";
            string sql5 = "ALTER TABLE `egreso` ADD INDEX IF NOT EXISTS `Fk_egreso_tipo` (`idEgresoTipo`) USING BTREE";
            string sql6 = "ALTER TABLE `egreso` DROP FOREIGN KEY IF EXISTS `Fk_egreso_tipo`"; //SI DA PROBLEMAS PUEDES ELIMINAR ESTA LÌNEA Y PROBAR
            string sql7 = "ALTER TABLE `egreso` ADD CONSTRAINT `Fk_egreso_tipo` FOREIGN KEY IF NOT EXISTS(`idEgresoTipo`) REFERENCES `servicexpress`.`egreso_tipo`(`idEgresoTipo`) ON DELETE SET NULL ON UPDATE CASCADE";
            if (!Trans.CreateTransaction(sql3, sql4, sql5, sql6, sql7))
            {
                result = false;
                string sql3a = "UPDATE `egreso` SET `idEgresoTipo` = NULL";
                if (!Trans.CreateTransaction(sql3a, sql3, sql4, sql5, sql6, sql7))
                    result = false;
            }
            return result;
        }
        public bool cambiosTablaPedido()
        {
            StringBuilder sqlStatement = new StringBuilder();
            sqlStatement.Append("ALTER TABLE `pedido` CHANGE `listo` `listo` TINYINT(2) NULL DEFAULT NULL; ");
            return Trans.CreateTransaction(sqlStatement.ToString());
        }
        public bool cambiosTablaPedido_detalle()
        {
            StringBuilder sqlStatement1 = new StringBuilder();
            sqlStatement1.Append("ALTER TABLE `pedido_detalle` ");
            sqlStatement1.Append("ADD IF NOT EXISTS `cantidadAnterior` INT(3) ");
            sqlStatement1.Append("NOT NULL AFTER `grupo`");

            StringBuilder sqlStatement2 = new StringBuilder();
            sqlStatement2.Append("CREATE TRIGGER IF NOT EXISTS `cambios` BEFORE UPDATE ON `pedido_detalle` ");
            sqlStatement2.Append("FOR EACH ROW ");
            sqlStatement2.Append("BEGIN ");
            sqlStatement2.Append("SET NEW.cantidadAnterior = OLD.cantidad; ");
            sqlStatement2.Append("END; ");
            return Trans.CreateTransaction(sqlStatement1.ToString(), sqlStatement2.ToString());
        }
        public bool crearVistaKardex()
        {
            StringBuilder sqlStatement = new StringBuilder();
            sqlStatement.Append("CREATE OR REPLACE ");
            sqlStatement.Append("ALGORITHM = UNDEFINED ");
            sqlStatement.Append("DEFINER = `kardex`@`%` ");
            sqlStatement.Append("SQL SECURITY INVOKER ");
            sqlStatement.Append("VIEW `kardex` AS ");
            sqlStatement.Append(@"Select v.fecha as fecha,IF(v.nFactura IS NULL or v.nFactura = '', v.idPedido, v.nFactura) as Documento, p.idProducto as idProducto,p.nombre as Descripcion, 'Venta' as Tipo ,0 as Entradas,sum(vd.cantidad) as Salidas, p.costo,p.stock,
            CANTIDADINI(`p`.`idProducto`) AS `ini` from producto p ");
            sqlStatement.Append("inner join pedido_detalle vd ON(p.idProducto = vd.idProducto) ");
            sqlStatement.Append("inner join pedido v ON(v.idPedido = vd.idPedido) ");
            sqlStatement.Append("group by v.idPedido,vd.idProducto ");
            sqlStatement.Append("UNION ALL ");
            sqlStatement.Append(@"Select c.fecha as fecha, c.ncOMPROBANTE as Documento,p.idProducto as idProducto, p.nombre as Descripcion, 'Compra' as Tipo,sum(cd.cantidad) as Entradas,0 as Salidas, p.costo,p.stock,
        CANTIDADINI(`p`.`idProducto`) AS `ini` from producto p ");
            sqlStatement.Append("inner join compra_detalle cd ON(p.idProducto = cd.idProducto) ");
            sqlStatement.Append("inner join compra c ON(cd.idCompra = c.idCompra) ");
            sqlStatement.Append("group by c.idCompra,cd.idProducto ");
            sqlStatement.Append("UNION all ");
            sqlStatement.Append(@"Select a.fecha as fecha, a.idAjuste as Documento,p.idProducto as idProducto, p.nombre as Descripcion ,'Ajuste Stock' as Tipo,IF(a.tipoAjuste = 'INCREMENTAR', a.cantidad, 0) as Entradas,IF(a.tipoAjuste = 'DECREMENTAR', a.cantidad, 0) as Salidas, p.costo,p.stock,
        CANTIDADINI(`p`.`idProducto`) AS `ini` from producto p ");
            sqlStatement.Append("inner join ajuste_stock a ON(p.idProducto = a.idProducto) ");
            sqlStatement.Append("group by a.idAjuste,a.idProducto ");
            return Trans.CreateTransaction(sqlStatement.ToString());
        }
    }
}
