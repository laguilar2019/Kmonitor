using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

//TECLAS ctrl + R + E para encapsular un campo o propiedad
namespace DBM
{
    public class Consulta
    {
        String _Usuario;
        String _pinCode;
        String _campoFiltrado;
        String _filtro;
        Boolean _filtroExacto;
        
        public String campoFiltrado
        {
            get { return _campoFiltrado; }
            set { _campoFiltrado = value; }
        }
        public String filtro
        {
            get { return _filtro; }
            set { _filtro = value; }
        }
        public String pinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
        }
        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public Boolean filtroExacto
        {
            get { return _filtroExacto; }
            set { _filtroExacto= value; }
        }

        public enum Query
        {
            CONVERTIR_UTF8,
            VALIDAR_USUARIO,
            VALIDAR_USUARIO_ADMINISTRADOR,
            VALIDAR_USUARIO_MESERO,
            TODOS_LOS_USUARIOS,
            PERMISOS_OTORGADOS,
            PERMISOS_DISPONIBLES,
            EMPLEADOS_ENROLADOS,
            EMPLEADOS_SIN_ROLES
        }
        public DataTable Consultar(Query QuerySelected)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            // StringBuilder es para concatenar cadenas, se usa para cadenas complejas.
            switch (QuerySelected)
            {
                case Query.CONVERTIR_UTF8:
                    Sentencia.Append("SET NAMES 'utf8'");
                    break;
                case Query.VALIDAR_USUARIO:
                    Sentencia.Append("SELECT u.idUsuario, e.nombres, e.apellidos,u.idRol,u.pinCode FROM usuario u, empleado e where u.idUsuario = e.idEmpleado and u.pinCode=md5('" + _pinCode + "')");
                    break;
                case Query.VALIDAR_USUARIO_ADMINISTRADOR:
                    Sentencia.Append("SELECT u.idUsuario, e.nombres, e.apellidos,u.idRol,u.pinCode FROM usuario u, empleado e where u.idUsuario = e.idEmpleado and u.idRol = '1' and u.pinCode=md5('" + _pinCode + "')");
                    break;
                case Query.VALIDAR_USUARIO_MESERO:
                    Sentencia.Append("SELECT u.idUsuario, e.nombres, e.apellidos,u.idRol,u.pinCode FROM usuario u, empleado e where u.idUsuario = e.idEmpleado and u.idRol = '2' and u.pinCode=md5('" + _pinCode + "')");
                    break;

                case Query.PERMISOS_OTORGADOS:
                    Sentencia.Append("SELECT idComando, comando FROM comando c WHERE idComando IN (SELECT idComando FROM permiso p WHERE idRol=" + _filtro + ") order by idComando;");
                    break;
                case Query.PERMISOS_DISPONIBLES:
                    Sentencia.Append("SELECT idComando, comando FROM comando c WHERE idComando NOT IN (SELECT idComando FROM permiso p WHERE idRol=" + _filtro + ")  order by idComando;");
                    break;
                
                case Query.EMPLEADOS_ENROLADOS:
                    Sentencia.Append("SELECT idEmpleado, concat(nombres, ' ', apellidos) as nombreEmp FROM empleado e WHERE idEmpleado IN (SELECT idUsuario FROM usuario u WHERE idRol=" + _filtro + ");");
                    break;
                case Query.EMPLEADOS_SIN_ROLES:
                    Sentencia.Append("SELECT idEmpleado, concat(nombres, ' ', apellidos) as nombreEmp FROM empleado e WHERE idEmpleado NOT IN (SELECT idUsuario FROM usuario u)");
                    break;
                case Query.TODOS_LOS_USUARIOS:
                    Sentencia.Append("SELECT u.idUsuario, e.nombres,e.apellidos,e.direccion,e.email,e.telefono,e.DUI,e.NIT,e.sueldoBase,e.comision,r.rol FROM usuario u, empleado e, rol r where u.idEmpleado = e.idEmpleado and u.idRol= r.idRol ORDER BY e.nombres ASC;");
                    break;

            }
            DBM.CLS.QUERY objDatos = new DBM.CLS.QUERY ();
            Resultado = objDatos.Consultar(Sentencia.ToString());
            return Resultado;
        }
    }
}