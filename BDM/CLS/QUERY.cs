using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBM.CLS
{
    public class QUERY:Connection
    {
        MySqlCommand Comando = new MySqlCommand();
        MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        public bool showErrorSQL = true;
        private DataTable EjecutarConsulta(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    Comando.CommandText = pConsulta;
                    Comando.Connection = base.Conexion;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);

                }
            }
            catch (MySqlException e)
            {
                if(showErrorSQL)
                    MessageBox.Show("¡Ocurrió un error en la consulta SQL de la clase QUERY! : " + e.Message + " mira esto: " + pConsulta);
                Resultado = new DataTable();
            }
            finally
            {
                base.Desconectar();
            }
            return Resultado;
        }
        public DataTable Consultar(String pConsulta)
        {
            return EjecutarConsulta(pConsulta);
        }

        /// <summary>
        /// Filtra registro de una tabla que cumplen con la condición dada
        /// </summary>
        /// <param name="tableName">Nombre de la tabla a filtrar</param>
        /// <param name="field">campo</param>
        /// <param name="condition"> condición tipo string</param>
        /// <returns>Retorna un DataTabe con los registros que cumplen la condición</returns>
        public DataTable GetRecordsFiltersLike(string tableName, string field, string condition)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field + " like '%" + condition + "%';");
            return EjecutarConsulta(sentencia.ToString());
        }
        /// <summary>
        /// Filtra registro de una tabla que cumplen con las condiciones dadas
        /// </summary>
        /// <param name="tableName">Nombre de la tabla a filtrar</param>
        /// <param name="field">campo</param>
        /// <param name="condition"> condición (Like) tipo string</param>
        /// <param name="field2">campo 2</param>
        /// <param name="condition2">segunda condición</param>
        /// <returns>Retorna un DataTabe con los registros que cumplen las condiciones dadas.</returns>
        public DataTable GetRecordsFiltersLike(string tableName, string field, string condition, string field2, string condition2)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field + " like '%" + condition + "%' and " + field2 + " = " + condition2 + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        /// <summary>
        /// Filtra registro de una tabla que cumplen con las condiciones dadas
        /// </summary>
        /// <param name="tableName">Nombre de la tabla a filtrar</param>
        /// <param name="field">campo</param>
        /// <param name="condition"> condición (Like) tipo string</param>
        /// <param name="field2">campo 2</param>
        /// <param name="operador"> espeficique el operador </param>
        /// <param name="condition2">Segunda condición </param>
        /// <returns>Retorna un DataTabe con los registros que cumplen las condiciones dadas.</returns>        
        public DataTable GetRecordsFiltersLike(string tableName, string field, string condition, string field2, string operador, string condition2)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field + " like '%" + condition + "%' and " + field2 + " " + operador + " " + condition2 + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecordsFilters(string tableName, string field, string condition)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field + " = " + condition + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecordsFilters(string tableName, string field, string operador, string condition)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field + " " + operador + " " + condition + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecordsFilters(string tableName, string field1, string operador1, string condition1, string field2, string operador2, string condition2)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + field1 + " " + operador1 + " " + condition1 +" and "+ field2 + " " + operador2 + " " + condition2 + ";");

            return EjecutarConsulta(sentencia.ToString());
        }

        public DataTable GetRecordsFromTwoTable(string Table1, string Table2, string IndexTable1, string IndexTable2, string conditions, string orderBy)
        {
            StringBuilder sentencia = new StringBuilder();
            if (conditions.Length > 0)
                sentencia.Append("Select a.*, b.* from " + Table1 + " a inner join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ")   where " + conditions + " order by " + orderBy + " ;");
            else
                sentencia.Append("Select a.*, b.* from " + Table1 + " a inner join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ") order by " + orderBy + " ;");

            // MessageBox.Show(sentencia.ToString());
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecordsFromTwoTableLEFTJOIN(string Table1, string Table2, string IndexTable1, string IndexTable2, string conditions, string orderBy)
        {
            StringBuilder sentencia = new StringBuilder();
            if (conditions.Length > 0)
                sentencia.Append("Select a.*, b.* from " + Table1 + " a left join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ")   where " + conditions + " order by " + orderBy + " ;");
            else
                sentencia.Append("Select a.*, b.* from " + Table1 + " a left join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ") order by " + orderBy + " ;");

            // MessageBox.Show(sentencia.ToString());
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecordsFromTwoTableRIGHTJOIN(string Table1, string Table2, string IndexTable1, string IndexTable2, string conditions, string orderBy)
        {
            StringBuilder sentencia = new StringBuilder();
            if (conditions.Length > 0)
                sentencia.Append("Select a.*, b.* from " + Table1 + " a right  join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ")   where " + conditions + " order by " + orderBy + " ;");
            else
                sentencia.Append("Select a.*, b.* from " + Table1 + " a right join " + Table2 + " b on(a." + IndexTable1 + "= b." + IndexTable2 + ") order by " + orderBy + " ;");

            // MessageBox.Show(sentencia.ToString());
            return EjecutarConsulta(sentencia.ToString());
        }

        public DataTable GetRecords(string tableName)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataTable GetRecords(string tableName, string fieldSorted)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " ORDER BY " + fieldSorted + ";");
            
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataRow GetUniqueRecord(string tableName, string fieldPrimary, string fieldCondition)
        {
            DataTable DT = new DataTable();
            DataRow Resultado = DT.NewRow();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " where " + fieldPrimary + " = '" + fieldCondition + "';");
            try
            {
                Resultado = EjecutarConsulta(sentencia.ToString()).Rows[0];
                return Resultado;
            }
            catch
            {
                return null;
            }

        }
        public string GetSHA1FromString(string cadena)
        {
            DataTable DT = new DataTable();
            string resul = "";
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string query = @"SELECT SHA1(?Cadena) as NewString";
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    Comando.Parameters.AddWithValue("?Cadena", cadena);
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(DT);
                    if (DT.Rows.Count > 0)
                        resul = DT.Rows[0]["NewString"].ToString();
                    base.Desconectar();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
            }
            finally
            {
                base.Desconectar();
            }
            return resul;
        }
        public int MaximoValor(string campo, string tabla, string campoCondicion, string valorCondicion)
        {
            int resul = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string query = @"SELECT MAX("+campo+") from "+ tabla+" where "+campoCondicion+" = "+valorCondicion;
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    resul=  Convert.ToInt32(Comando.ExecuteScalar());
                    base.Desconectar();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
            }
            finally
            {
                base.Desconectar();
            }
            return resul;
        }
        public int GetContadorVistas()
        {
            int resul = 0;
            base.Conectar();
            DBM.CLS.Utilities con = new Utilities();
            
            try
            {
                using (base.Conexion)
                {
                    string query = @"SELECT COUNT(*) AS count FROM information_schema.VIEWS WHERE table_schema = '"+ con.GetMySQL_DatabaseName() + "'";
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    resul = Convert.ToInt32(Comando.ExecuteScalar());
                    base.Desconectar();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
            }
            finally
            {
                base.Desconectar();
            }
            return resul;
        }
        
        public DataRow GetRecordTop(string tableName)
        {
            DataTable DT = new DataTable();
            DataRow Resultado = DT.NewRow();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT * from " + tableName + " LIMIT 1;");            
            try
            {
                Resultado = EjecutarConsulta(sentencia.ToString()).Rows[0];

                return Resultado;
            }
            catch
            {
                return null;
            }

        }
        public DataTable GetColumnsName(string tableName)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SHOW COLUMNS FROM " + tableName + ";");
            return EjecutarConsulta(sentencia.ToString());
        }
        public DataRow GetColumnWidth(string tableName, string field)
        {
            Transaccion trans = new Transaccion();
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("SELECT COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name ='" + tableName + "' AND column_name = '" + field + "';");
            return EjecutarConsulta(sentencia.ToString()).Rows[0]; 
        }
    }
}
