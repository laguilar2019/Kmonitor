using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMonitor.GUI
{
    public partial class frmLogin : Form
    {
        DBM.CLS.Sesion _SESION = DBM.CLS.Sesion.Instancia;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtpinCode.Select();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean Validar()
        {
            Boolean Resultado = false;
            DBM.CLS.QUERY objConsulta = new DBM.CLS.QUERY();
            objConsulta.showErrorSQL = false;
            DataTable dtUser = new DataTable();

            dtUser = objConsulta.GetRecordsFilters("usuario","pinCode","MD5("+txtpinCode.Text+")");
            if (dtUser.Rows.Count>0)
            {
                DataRow dr = dtUser.Rows[0];
                DataRow drE;
                _SESION.Perfil = dr["idRol"].ToString();
                _SESION.idUsuario = dr["idUsuario"].ToString();
                
                DataTable DTE = objConsulta.GetRecordsFilters("empleado", "idEmpleado", _SESION.idUsuario);
                if (DTE.Rows.Count > 0)
                {
                    drE = DTE.Rows[0];
                    _SESION.Usuario = drE["nombres"].ToString();
                }
                
                Resultado = true;
            }
            return Resultado;
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpinCode.Focus();
            }
        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                lblMensaje.Text = "Usuario registrado... Bienvenido";
                GUI.frmMenu frm = new frmMenu();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                lblMensaje.Text = "Credenciales incorrectas.";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtpinCode.Text = txtpinCode.Text.Substring(1,  txtpinCode.TextLength - 1);
            txtpinCode.SelectionStart = txtpinCode.TextLength;
            txtpinCode.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "2"; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "3"; 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "4"; 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "5"; 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpinCode.Text += "0";
        }


        private void picLogo_Click(object sender, EventArgs e)
        {

            DBM.GUI.ConnectionString frm = new DBM.GUI.ConnectionString();
            frm.Show();
        }

        private void picLock_Click(object sender, EventArgs e)
        {
            DBM.GUI.ConnectionString frm = new DBM.GUI.ConnectionString();
            frm.Show();
        }

        private void txtpinCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.F4 == e.KeyData)
            {
                DBM.GUI.frmBackup frm = new DBM.GUI.frmBackup();
                frm.ShowDialog();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            GUI.configInicial frm = new configInicial();
            frm.ShowDialog();
        }

    }
}
