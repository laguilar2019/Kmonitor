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
    public partial class bProducto : Form
    {

        public bProducto()
        {
            InitializeComponent();
        }
        
        //Pra busquedas de prodcutos
        public String id;
        public String nombreProducto;  


        private void llenarCboFamilia()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            Query.showErrorSQL =false;
            DBM.CLS.Funciones.FillCombobox(cboFamilia_Query,"familia","idFamilia","familia");
        }


        private void rbtnProducto_CheckedChanged(object sender, EventArgs e)
        {
            txtnombreQuery.Visible = true;
            cboFamilia_Query.Visible = false;
            txtnombreQuery.Focus();
            txtnombreQuery.Text = "";
        }

        private void rbtnFamilia_CheckedChanged(object sender, EventArgs e)
        {
            txtnombreQuery.Visible = false;
            cboFamilia_Query.Visible = true;
            
        }


        private void bProducto_Load(object sender, EventArgs e)
        {
            llenarCboFamilia();
            cargarProductos();
        }

        private void txtnombreQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtnombreQuery.TextLength == 0)
                cargarProductos();
            else
                filtrarProducto();
        }
        private void filtrarProducto()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgProducto, Query.GetRecordsFromTwoTableLEFTJOIN("producto", "familia", "idFamilia", "idFamilia", "nombre like '%" + txtnombreQuery.Text + "%'", "familia"));
        }
        private void filtrarProductoByCboFamilia()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            dgProducto.AutoGenerateColumns= false;
            DBM.CLS.Funciones.FillGridView(dgProducto, Query.GetRecordsFromTwoTableLEFTJOIN("producto", "familia", "idFamilia", "idFamilia","b.idFamilia="+cboFamilia_Query.SelectedValue.ToString(), "familia"));
        }
        private void cargarProductos()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgProducto, Query.GetRecordsFromTwoTableLEFTJOIN("producto","familia","idFamilia","idFamilia","","familia"));
        }

        private void cboFamilia_Query_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnFamilia.Checked)
                filtrarProductoByCboFamilia();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            id = dgProducto.CurrentRow.Cells["idProducto"].Value.ToString();
            nombreProducto = dgProducto.CurrentRow.Cells["nombre"].Value.ToString() + "  [" + dgProducto.CurrentRow.Cells["familia"].Value.ToString() + "]";
            this.Close();
        }

        private void dgProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProducto.RowCount > 0)
            {
                id = dgProducto.CurrentRow.Cells["idProducto"].Value.ToString();
                nombreProducto = dgProducto.CurrentRow.Cells["nombre"].Value.ToString() + "  [" + dgProducto.CurrentRow.Cells["familia"].Value.ToString() + "]";
                this.Close();
            }
        }

    }
}
