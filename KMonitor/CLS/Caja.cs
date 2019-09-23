using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMonitor.CLS
{
    class Caja
    {
        int _idCaja;
        int _idCajero;
        int _estado;
        String _fechaApertura;
        String _fechaCierre;
        String _saldoInicial;
        String _saldo;

        public Caja()
        {
            _idCaja = 0;
            _idCajero = 0;
            _estado = 0;
            _fechaApertura = "";
            _fechaCierre = "";
            _saldoInicial = "0";
            _saldo = "0";
        }

        public int idCaja
        {
            get { return _idCaja; }
            set { _idCaja = value; }
        }
        public int idCajero
        {
            get { return _idCajero; }
            set { _idCajero = value; }
        }
        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public String fechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }
        public String fechaCierre
        {
            get { return _fechaCierre; }
            set { _fechaCierre = value; }
        }
        public String saldoInicial
        {
            get { return _saldoInicial; }
            set { _saldoInicial = value; }
        }
        public String saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
        public string CambiarEstado(int codigoCaja, int nEstado)
        {
            String log = "";
            if (nEstado == 0)
                log = "Cierre de caja";
            else if (nEstado == 1)
                log = "Apertura de caja";
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("update caja set");
            sentencia.Append(" estado = '" + nEstado + "',");
            sentencia.Append(" fechaCierre = '" + _fechaCierre + "'");
            sentencia.Append("WHERE idCaja = '" + codigoCaja + "';");
            return sentencia.ToString();
        }

        public string AbonarCaja(String abono)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE caja SET ");
            sentencia.Append("saldo=saldo + '" + abono + "' ");
            sentencia.Append("WHERE estado= 1");
            return sentencia.ToString();
        }
        public string RetiroCaja(String retiro)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE caja SET ");
            sentencia.Append("saldo=saldo - '" + retiro + "' ");
            sentencia.Append("WHERE estado= 1");
            
            return sentencia.ToString();
        }
        public string AbonarEfectivoVenta(String abono)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("UPDATE caja SET ");
            sentencia.Append("efectivo=efectivo+ '" + abono + "' ");
            sentencia.Append("WHERE estado= 1");
            return sentencia.ToString();
        }
    }
}
