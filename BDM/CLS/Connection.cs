using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DBM.CLS
{
    public class Connection
    {
            protected MySqlConnection Conexion = new MySqlConnection();
        protected Boolean Conectar()
        {
            Boolean Resultado = false;
            Utilities cnxString = new Utilities();

            try
            {
                Conexion.ConnectionString = cnxString.GetConnectionString();
                Conexion.Open();
                Resultado = true;
            }
            catch
            {
                Resultado = false;
            }
            return Resultado;
        }
        protected void Desconectar()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch
            {

            }
        }
        public bool ValidarConexion(string connString)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
