using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace DBM.CLS
{
    public class Transaccion
    {
        Utilities cnxString = new Utilities();
        public Boolean CreateTransaction(string Query1)
        {
            Boolean respuesta;
            
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                }

            }
            return respuesta;
        }

        public Boolean CreateTransaction(string Query1, string Query2)
        {
            Boolean respuesta;
            //DBA.Utilities cnxString = new DBA.Utilities();
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query2;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();

                }
            }
            return respuesta;
        }
        public Boolean CreateTransaction(string Query1, string Query2, string Query3)
        {
            Boolean respuesta;
            //DBA.Utilities cnxString = new DBA.Utilities();
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query2;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query3;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                }
            }
            return respuesta;
        }
        public Boolean CreateTransaction(string Query1, string Query2, string Query3, string Query4)
        {
            Boolean respuesta;
            //DBA.Utilities cnxString = new DBA.Utilities();
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query2;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query3;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query4;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                }
            }
            return respuesta;
        }
        public Boolean CreateTransaction(string Query1, string Query2, string Query3, string Query4, string Query5)
        {
            Boolean respuesta;
            //DBA.Utilities cnxString = new DBA.Utilities();
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query2;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query3;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query4;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query5;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                }
            }
            return respuesta;
        }
        public Boolean CreateTransaction(string Query1, string Query2, string Query3, string Query4, string Query5, string Query6)
        {
            Boolean respuesta;
            //DBA.Utilities cnxString = new DBA.Utilities();
            using (MySqlConnection myConnection = new MySqlConnection(cnxString.GetConnectionString()))
            {
                myConnection.Open();
                // Start a local transaction
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    myCommand.CommandText = Query1;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query2;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query3;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query4;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query5;
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = Query6;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    respuesta = true;
                }
                catch (Exception e)
                {
                    myTrans.Rollback();
                    MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    respuesta = false;
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                }
            }
            return respuesta;
        }
    }
}
