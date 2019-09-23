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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CargarValores();
        }
        private void CargarValores()
        {
            txtAnchoSalon.Text = Properties.Settings.Default.sizeButtonSalon.Width.ToString();
            txtAltoSalon.Text = Properties.Settings.Default.sizeButtonSalon.Height.ToString();
            txtAlturaPanel.Text = Properties.Settings.Default.alturaPanelSalon.ToString();

            txtAnchoPedido.Text = Properties.Settings.Default.sizeButtonPedido.Width.ToString();
            txtAltoPedido.Text = Properties.Settings.Default.sizeButtonPedido.Height.ToString();
        }
        private void GuardarValores()
        {
            Properties.Settings.Default.sizeButtonSalon =  new Size(int.Parse(txtAnchoSalon.Text),int.Parse(txtAltoSalon.Text));
            Properties.Settings.Default.sizeButtonPedido = new Size(int.Parse(txtAnchoPedido.Text), int.Parse(txtAltoPedido.Text));
            Properties.Settings.Default.alturaPanelSalon = int.Parse(txtAlturaPanel.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Los valores se guardaron correctamente",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarValores();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtAnchoSalon_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender,e);
        }

        private void btnCnx_Click(object sender, EventArgs e)
        {
            DBM.GUI.ConnectionString frm = new DBM.GUI.ConnectionString();
            frm.ShowDialog();
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            DBM.GUI.frmBackup frm = new DBM.GUI.frmBackup();
            frm.ShowDialog();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI.frmEgreso frm = new GUI.frmEgreso();
            frm.ShowDialog();

        }

        private void btnReoaraListo_Click(object sender, EventArgs e)
        {
            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
            string query="";
            query = "ALTER TABLE `pedido` CHANGE `listo` `listo` TINYINT(2) NULL DEFAULT NULL;";

            if(Trans.CreateTransaction(query))
                MessageBox.Show("El campo LISTO ahora tiene un ancho de 2 " , Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            GUI.configInicial frm = new configInicial();
            frm.ShowDialog();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            GUI.frmFamiliaMonitor frm = new frmFamiliaMonitor();
            frm.ShowDialog();
        }
    }
}
