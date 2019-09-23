using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBM.GUI
{
    public partial class ConnectionString : Form
    {
        string saltoLinea = Environment.NewLine;

        public ConnectionString()
        {
            InitializeComponent();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            
            CLS.Utilities objCnx = new CLS.Utilities();
            txtServer.Text = objCnx.GetMySQL_ServerName();
            txtPort.Text = objCnx.GetMySQL_Port().ToString();
            txtBD.Text = objCnx.GetMySQL_DatabaseName();
            txtUser.Text = objCnx.GetMySQL_UserName();
            txtPass.Text = objCnx.GetMySQL_Password();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CLS.Connection cnxValidate = new CLS.Connection();

            CLS.Utilities objConx = new CLS.Utilities();
            string newString = null;
            newString = objConx.SetConnectionStringComplete(txtServer.Text,uint.Parse(txtPort.Text),txtBD.Text,txtUser.Text,txtPass.Text);
            if (chkVerify.Checked)
            {
                if (cnxValidate.ValidarConexion(newString))
                {
                    MessageBox.Show("Conexión exitosa","ConnectionSettings",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (newString != null)
                    {
                        objConx.SaveConnectionString(newString);
                        objConx.ProtectConnectionString();

                        DBM.CLS.QUERY Query_ = new DBM.CLS.QUERY();
                        Query_.GetColumnWidth("pedido", "listo");
                        if (Query_.GetColumnWidth("pedido", "listo")["COLUMN_TYPE"].ToString().Trim() == "tinyint(1)")
                        {
                            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
                            string query = "";
                            query = "ALTER TABLE `pedido` CHANGE `listo` `listo` TINYINT(2) NULL DEFAULT NULL;";

                            if (Trans.CreateTransaction(query))
                                MessageBox.Show("El campo LISTO ahora tiene un ancho de 2 ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }                        
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión con el servidor." + saltoLinea + "Para guardar los datos sin comprobar la conexión desactive la casilla de verificación", "ConnectionSettings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }else
            {
                if (newString != null)
                {
                    objConx.SaveConnectionString(newString);
                    objConx.ProtectConnectionString();
                }
                    
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarConexion(string connstring)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connstring))
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

        private void lblconnectionString_Click(object sender, EventArgs e)
        {

            frmCNX frm = new frmCNX();
            frm.Show();
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            CLS.Funciones.soloDigitos(sender,e);
        }
    }
}
