using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace KMonitor.GUI
{
    
    public partial class frmMenu : Form
    {
        DBM.CLS.Sesion _SESION = DBM.CLS.Sesion.Instancia;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.PositionFormMenu;
            this.Size = Properties.Settings.Default.SizeFormMenu;
            DBM.CLS.Funciones.habilitarPermisos(flowLayoutPanelMenu, int.Parse(_SESION.Perfil));
        }
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.PositionFormMenu = this.Location;
            Properties.Settings.Default.SizeFormMenu = this.Size;
            Properties.Settings.Default.Save();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            GUI.frmMonitor frm = new frmMonitor();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            GUI.frmEgreso frm = new GUI.frmEgreso();
            frm.ShowDialog();
        }

        private void btnCashFlow_Click(object sender, EventArgs e)
        {
            GUI.frmEgreso frm = new GUI.frmEgreso();
            frm.tabControl.SelectedIndex= 1;
            frm.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            GUI.configInicial frm = new configInicial();
            frm.ShowDialog();
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            GUI.Kardex frm = new GUI.Kardex();
            frm.ShowDialog();
        }
    }
}
