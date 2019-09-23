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
    public partial class configInicial : Form
    {
        public configInicial()
        {
            InitializeComponent();
        }

        private void btnReoaraListo_Click(object sender, EventArgs e)
        {
            CLS.ConfigBD config = new CLS.ConfigBD();
            if (config.cambiosTablaPedido())
            {
                edtLogFile.Items.Add("La tabla pedido se ha modificado exitosamente ");
                edtLogFile.Items.Add("  El campo listo: nuevo ancho a TINYINT(2)" + "Ok");
            }
        }

        private void btnCnx_Click(object sender, EventArgs e)
        {
            DBM.GUI.ConnectionString frm = new DBM.GUI.ConnectionString();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            CLS.ConfigBD config = new CLS.ConfigBD();
            if (config.crearTablaEgresoTipo())
            {
                edtLogFile.Items.Add("La tabla egreso_tipo se ha creado exitosamente ");
                edtLogFile.Items.Add("Las tablas egreso y egreso_tipo se han relacionado exitosamente ");
            }
        }

        private void btnPrivilegios_Click(object sender, EventArgs e)
        {
            GUI.frmPermisos frm = new GUI.frmPermisos();
            frm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            GUI.frmUsers frm = new GUI.frmUsers();
            frm.Show();
        }

        private void btnCambiosEnPedidoDetalle_Click(object sender, EventArgs e)
        {
            CLS.ConfigBD config = new CLS.ConfigBD();
            if (config.cambiosTablaPedido_detalle())
            {
                edtLogFile.Items.Add("La tabla pedido_detale se ha modificado exitosamente ");
            }
        }
    }
}
