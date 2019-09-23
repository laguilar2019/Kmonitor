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
    public class CRUD:Connection
    {
        MySqlCommand Comando = new MySqlCommand();
        MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        
        private int EjecutarSentencia(String pSentencia)
        {
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    Comando.CommandText = pSentencia;
                    Comando.Connection = base.Conexion;
                    NumFilasAfectadas = Comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }

        //CREATE--> INSERT

        public int Insert(string tablaName, List<string> campos, List<string> valores)
        {
            string query="";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaValores = new List<string>();                     
                    if (campos.Count() == valores.Count())
                    {
                    
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            listaValores.Add("?Valor" + i.ToString());
                        }
                        string listaValores_ = string.Join(",", listaValores.ToArray());

                        query = "INSERT INTO " + tablaName + "(" + listaCampos +")values("+ listaValores_.ToString() + ")";
                        //Comando = new MySqlCommand(query, base.Conexion);
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor"+i.ToString(), valores[i]);                            
                        }
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message +" CADENA COMPLETA: "+   query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }
        //CREAD--> LEER
        public DataRow GetRecordByID(string tableName, string idField, string idValue)
        {
            DataTable DT = new DataTable();
            DataRow Resultado = DT.NewRow();
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string query = @"SELECT * FROM " + tableName + " WHERE " + idField + "= ?IdValue";
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    Comando.Parameters.AddWithValue("?IdValue", idValue);
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(DT);
                    if (DT.Rows.Count > 0)
                        Resultado = DT.Rows[0];
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
            return Resultado;
        }

        //UPDATE--> ACTUALIZAR
        public int Update(string tablaName, List<string> campos, List<string> valores, string fielCondition, string fieldConditionValue)
        {
            string query = "";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaCamposValores = new List<string>();
                    if (campos.Count() == valores.Count())
                    {
                        for (int i = 0; i < valores.Count(); i++)
                        {
                           listaCamposValores.Add(campos[i].ToString() + " = " + "?Valor" + i.ToString());
                        }
                        string campoValor = string.Join(",", listaCamposValores.ToArray());

                        query = "UPDATE " + tablaName + " SET " + campoValor.ToString() + " WHERE " + fielCondition +" = ?Condition";                        
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor" + i.ToString(), valores[i]);
                        }

                        Comando.Parameters.AddWithValue("?Condition", fieldConditionValue);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                        /*
                        if (NumFilasAfectadas > 0)
                            MessageBox.Show("Actualización aplicada correctamente. Registros afectados: " + NumFilasAfectadas.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                          */  
                    }else
                    {
                        MessageBox.Show("El número de campos (" + campos.Count().ToString() + ")" + " no coincide con el número de valores recibidos (" + valores.Count().ToString() +") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message + " CADENA COMPLETA: " + query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }
        
        public int Update(string tablaName, List<string> campos, List<string> valores, string fielCondition, string operador, string fieldConditionValue)
        {
            string query = "";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaCamposValores = new List<string>();
                    if (campos.Count() == valores.Count())
                    {
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            listaCamposValores.Add(campos[i].ToString() + " = " + "?Valor" + i.ToString());
                        }
                        string campoValor = string.Join(",", listaCamposValores.ToArray());

                        query = "UPDATE " + tablaName + " SET " + campoValor.ToString() + " WHERE " + fielCondition + " "+operador +" "+"?Condition";
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor" + i.ToString(), valores[i]);
                        }
                        Comando.Parameters.AddWithValue("?Condition", fieldConditionValue);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                        
                        //if (NumFilasAfectadas > 0)
                          //  MessageBox.Show("Actualización aplicada correctamente. Registros afectados: " + NumFilasAfectadas.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                    else
                    {
                        MessageBox.Show("El número de campos (" + campos.Count().ToString() + ")" + " no coincide con el número de valores recibidos (" + valores.Count().ToString() + ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message + " CADENA COMPLETA: " + query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }
        public int UpdateInOperador (string tablaName, List<string> campos, List<string> valores, string fielCondition, string fieldConditionValue)
        {
            string query = "";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaCamposValores = new List<string>();
                    if (campos.Count() == valores.Count())
                    {
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            listaCamposValores.Add(campos[i].ToString() + " = " + "?Valor" + i.ToString());
                        }
                        string campoValor = string.Join(",", listaCamposValores.ToArray());

                        query = "UPDATE " + tablaName + " SET " + campoValor.ToString() + " WHERE " + fielCondition + " In(" + " ?Condition )";
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor" + i.ToString(), valores[i]);
                        }
                        Comando.Parameters.AddWithValue("?Condition", fieldConditionValue);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();

                        //if (NumFilasAfectadas > 0)
                            //MessageBox.Show("Actualización aplicada correctamente. Registros afectados: " + NumFilasAfectadas.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("El número de campos (" + campos.Count().ToString() + ")" + " no coincide con el número de valores recibidos (" + valores.Count().ToString() + ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message + " CADENA COMPLETA: " + query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }

        public int Update(string tablaName, List<string> campos, List<string> valores, string fielCondition1, string fieldConditionValue1, string fielCondition2, string fieldConditionValue2)
        {
            string query = "";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaCamposValores = new List<string>();
                    if (campos.Count() == valores.Count())
                    {
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            listaCamposValores.Add(campos[i].ToString() + " = " + "?Valor" + i.ToString());
                        }
                        string campoValor = string.Join(",", listaCamposValores.ToArray());

                        query = "UPDATE " + tablaName + " SET " + campoValor.ToString() + " WHERE " + fielCondition1 + " = ?Condition1 AND " + fielCondition2  + " = ?Condition2"  ;
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor" + i.ToString(), valores[i]);
                        }
                        Comando.Parameters.AddWithValue("?Condition1", fieldConditionValue1);
                        Comando.Parameters.AddWithValue("?Condition2", fieldConditionValue2);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                        /*
                        if (NumFilasAfectadas > 0)
                            MessageBox.Show("Actualización aplicada correctamente. Registros afectados: " + NumFilasAfectadas.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            */
                    }
                    else
                    {
                        MessageBox.Show("El número de campos (" + campos.Count().ToString() + ")" + " no coincide con el número de valores recibidos (" + valores.Count().ToString() + ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message + " CADENA COMPLETA: " + query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }
        public int Update(string tablaName, List<string> campos, List<string> valores, string fielCondition1, string operador1, string fieldConditionValue1, string fielCondition2, string operador2, string fieldConditionValue2)
        {
            string query = "";
            Int32 NumFilasAfectadas = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string listaCampos = string.Join(",", campos.ToArray());
                    List<string> listaCamposValores = new List<string>();
                    if (campos.Count() == valores.Count())
                    {
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            listaCamposValores.Add(campos[i].ToString() + " = " + "?Valor" + i.ToString());
                        }
                        string campoValor = string.Join(",", listaCamposValores.ToArray());

                        query = "UPDATE " + tablaName + " SET " + campoValor.ToString() + " WHERE " + fielCondition1 + operador1+ " ?Condition1 AND " + fielCondition2 + operador2 +" ?Condition2";
                        Comando.CommandText = query;
                        Comando.Connection = base.Conexion;
                        for (int i = 0; i < valores.Count(); i++)
                        {
                            Comando.Parameters.AddWithValue("?Valor" + i.ToString(), valores[i]);
                        }
                        Comando.Parameters.AddWithValue("?Condition1", fieldConditionValue1);
                        Comando.Parameters.AddWithValue("?Condition2", fieldConditionValue2);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                        /*
                        if (NumFilasAfectadas > 0)
                            MessageBox.Show("Actualización aplicada correctamente. Registros afectados: " + NumFilasAfectadas.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            */
                    }
                    else
                    {
                        MessageBox.Show("El número de campos (" + campos.Count().ToString() + ")" + " no coincide con el número de valores recibidos (" + valores.Count().ToString() + ") ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message + " CADENA COMPLETA: " + query.ToString());
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;
        }
        public int Delete(string tableName, string field, string fieldValue)
        {
            if (MessageBox.Show("Desea eliminar el regsitro seleccionado (" + fieldValue.ToUpper() + ") de la tabla  "+ tableName.ToUpper() +" ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                base.Conectar();
                Int32 NumFilasAfectadas = 0;
                
                try
                {
                    using (base.Conexion)
                    {
                        string query = @"DELETE FROM " + tableName + " WHERE " + field + "= " + fieldValue;
                        Comando = new MySqlCommand(query, base.Conexion);
                        NumFilasAfectadas = Comando.ExecuteNonQuery();
                        base.Desconectar();
                        //if(NumFilasAfectadas>0)
                            //MessageBox.Show("El registro se eliminó correctamente ",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
                    NumFilasAfectadas = 0;
                }
                finally
                {
                    base.Desconectar();
                }
                return NumFilasAfectadas;
            }
            else
            {
                return 0;
            }
        }
        public int TrucarTablaSinTrigger(string tableName)
        {
            
            base.Conectar();
            Int32 NumFilasAfectadas = 0;
            try
            {
                using (base.Conexion)
                {
                    string query = @"TRUNCATE TABLE " + tableName +";";
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    NumFilasAfectadas = Comando.ExecuteNonQuery();
                    base.Desconectar();                    
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
                NumFilasAfectadas = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return NumFilasAfectadas;                    
        }

        public void TruncarTablaConTrigger(string tableName)
        {
            StringBuilder sentencia = new StringBuilder();
            sentencia.Append("DELETE FROM " + tableName + ";");
            sentencia.Append("ALTER TABLE " + tableName + " AUTO_INCREMENT = 1;");
            EjecutarSentencia(sentencia.ToString());
        }
        
        public int GetNewId(string tableName, string idField)
        {
            DataTable DT = new DataTable();
            DataRow Resultado = DT.NewRow();
            int ID = 0;
            base.Conectar();
            try
            {
                using (base.Conexion)
                {
                    string query = @"SELECT MAX(" + idField + ") + 1 AS ProximoId FROM " + tableName + ";";
                    Comando.CommandText = query;
                    Comando.Connection = base.Conexion;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(DT);
                    try
                    {
                        if (DT.Rows.Count > 0)
                        {
                            Resultado = DT.Rows[0];
                            ID = ID = Convert.ToInt16(Resultado["ProximoId"].ToString());
                        }
                    } catch(Exception ex) { 
                        ID = 1;
                    }
                    base.Desconectar();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("¡Ocurrió un error en la instrucción SQL! : " + e.Message);
                ID = 0;
            }
            finally
            {
                base.Desconectar();
            }
            return ID;
        }

    }
}
