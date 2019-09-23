using KMonitor.Properties;
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
    public partial class frmEgresoTipo : Form
    {
        public frmEgresoTipo()
        {
            InitializeComponent();
        }
        ColorDialog paleta = new ColorDialog();
        
        private void frmEstado_Load(object sender, EventArgs e)
        {
            LlenarGridTipoEgreso();
        }

        private void LlenarGridTipoEgreso()
        {
            DBM.CLS.Funciones.FillGridView(dgEgresoTipo, "egreso_tipo");
        }
        private void LimpiarForm()
        {
            groupBoxTipoEgreso.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");

        }
        //************************************************************************
        // MANTENIMIENTO ESTADO
        //************************************************************************
        private void btnNewSave_Click(object sender, EventArgs e)
        {
            if (btnNewSave.Tag.ToString() == "1")
            {
                btnNewSave.Tag = "2";
                btnNewSave.Image = Resources.save;
                btnEditCancel.Tag = "2";
                btnEditCancel.Image = Properties.Resources.cancel;
                txtEgresoTipo.ReadOnly = false;
                LimpiarForm();
            }
            else
            {
                if (txtEgresoTipo.TextLength > 0)
                {
                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idEgresoTipo");
                    campos.Add("egresoTipo");

                    List<string> valores = new List<string>();
                    if (txtIdEgresoTipo.TextLength > 0)
                        valores.Add(txtIdEgresoTipo.Text);
                    else
                        valores.Add((Tabla.GetNewId("egreso_tipo", "idEgresoTipo") > 0) ? Tabla.GetNewId("egreso_tipo", "idEgresoTipo").ToString() : (Tabla.GetNewId("egreso_tipo", "idEgresoTipo") + 1).ToString());

                    valores.Add(txtEgresoTipo.Text);

                    //valores.Add(chkCategoriaActiva.Checked ? "1" : "0");

                    btnNewSave.Tag = "1";
                    btnNewSave.Image = Properties.Resources.new_;

                    btnEditCancel.Tag = "1";
                    btnEditCancel.Image = Properties.Resources.edit;
                    txtEgresoTipo.ReadOnly = true;

                    if (txtIdEgresoTipo.TextLength > 0)
                    {
                        Tabla.Update("egreso_tipo", campos, valores, "idEgresoTipo", txtIdEgresoTipo.Text);
                    }
                    else
                    {
                        Tabla.Insert("egreso_tipo", campos, valores);
                    }
                    LimpiarForm();
                    LlenarGridTipoEgreso();
                    
                }

            }
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            if (btnEditCancel.Tag.ToString() == "1")
            {
                btnEditCancel.Tag = "2";
                btnEditCancel.Image = Properties.Resources.cancel;

                btnNewSave.Tag = "2";
                btnNewSave.Image = Resources.save;
                txtEgresoTipo.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("egreso_tipo", "idEgresoTipo", dgEgresoTipo.CurrentRow.Cells["idEgresoTipo"].Value.ToString());
                txtIdEgresoTipo.Text = dr["idEgresoTipo"].ToString();
                txtEgresoTipo.Text = dr["egresoTipo"].ToString();
                //lblColorSelector.BackColor = Color.FromName(dr["color"].ToString());
                //lblColorSelector.BackColor = Color.FromName(dr["color"].ToString());
                //    lblColorSelector.BackColor = Color.FromName("#"+dr["color"].ToString());

            }
            else
            {
                btnEditCancel.Tag = "1";
                btnEditCancel.Image = Properties.Resources.edit;

                btnNewSave.Tag = "1";
                btnNewSave.Image = Properties.Resources.new_;
                txtEgresoTipo.ReadOnly = true;
                LimpiarForm();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEgresoTipo.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("egreso_tipo", "idEgresoTipo", dgEgresoTipo.CurrentRow.Cells["idEgresoTipo"].Value.ToString());
                LlenarGridTipoEgreso();
            }
        }
        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEgresoTipo.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgEgresoTipo, Tabla.GetRecordsFiltersLike("egreso_tipo", "egresoTipo", txtEgresoTipo.Text));
            }
        }

        private void dgEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgEstado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (this.dgEstado.Columns[e.ColumnIndex].Name == "color")
                //MessageBox.Show(this.dgEstado.Rows[e.RowIndex].Cells["color"].Value.ToString());
//                e.CellStyle.BackColor = Color.FromName(this.dgEstado.Rows[e.RowIndex].Cells["color"].Value.ToString());
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            frmSelectState frm = new frmSelectState();
            frm.ShowDialog();
        }
    }
}
