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
    public partial class frmEstado : Form
    {
        public frmEstado()
        {
            InitializeComponent();
        }
        ColorDialog paleta = new ColorDialog();
        
        private void frmEstado_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            FillComboColors();
        }

        private void FillComboColors()
        {
            CboColorPicker.Items.Add(Color.AliceBlue);
            CboColorPicker.Items.Add(Color.Yellow);
            CboColorPicker.Items.Add(Color.Green);
            CboColorPicker.Items.Add(Color.GreenYellow);
            CboColorPicker.Items.Add(Color.Red);
            CboColorPicker.Items.Add(Color.Blue );
            CboColorPicker.Items.Add(Color.LightGray);
            CboColorPicker.Items.Add(Color.Black);
            CboColorPicker.Items.Add(Color.Brown);
            CboColorPicker.Items.Add(Color.Gold);
            CboColorPicker.Items.Add(Color.White);
            CboColorPicker.Items.Add(Color.LightBlue);
            CboColorPicker.Items.Add(Color.LightSeaGreen);

        }
        private void LlenarGrid()
        {
            DBM.CLS.Funciones.FillGridView(dgEstado, "estado");
            MostrarColor();
        }
        private void MostrarColor()
        {
            /*
            for (int i = 0; i < dgEstado.Rows.Count;i++)
            {
                
                if (dgEstado.CurrentRow.Cells["color"].ColumnIndex == 2)
                {
                    //dgEstado.Rows[i].DefaultCellStyle.BackColor = Color.FromName(dgEstado.Rows[i].Cells["color"].Value.ToString());
                    dgEstado.Rows[i].Cells["color"].Style.BackColor = Color.FromName(dgEstado.Rows[i].Cells["color"].Value.ToString());
                }
            }
            */
            foreach (DataGridViewRow   row in dgEstado.Rows )
            {
                if (row.Cells["color"].ColumnIndex==2)
                {
                    row.Cells["color"].Style.BackColor = Color.FromName(row.Cells["color"].Value.ToString());
                }
            }
        }
        private void LimpiarForm()
        {
            groupBoxCategoria.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");

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
                txtEstado.ReadOnly = false;
                LimpiarForm();
            }
            else
            {
                if (txtEstado.TextLength > 0)
                {
                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idEstado");
                    campos.Add("estado");
                    campos.Add("color");
                    campos.Add("indexColor");

                    List<string> valores = new List<string>();
                    if (txtIdEstado.TextLength > 0)
                        valores.Add(txtIdEstado.Text);
                    else
                        valores.Add((Tabla.GetNewId("estado", "idEstado") > 0) ? Tabla.GetNewId("estado", "idEstado").ToString() : (Tabla.GetNewId("estado", "idEstado") + 1).ToString());

                    valores.Add(txtEstado.Text);
                    valores.Add(CboColorPicker.Text);
                    valores.Add(CboColorPicker.SelectedIndex.ToString());

                    //valores.Add(chkCategoriaActiva.Checked ? "1" : "0");

                    btnNewSave.Tag = "1";
                    btnNewSave.Image = Properties.Resources.new_;

                    btnEditCancel.Tag = "1";
                    btnEditCancel.Image = Properties.Resources.edit;
                    txtEstado.ReadOnly = true;

                    if (txtIdEstado.TextLength > 0)
                    {
                        Tabla.Update("Estado", campos, valores, "idEstado", txtIdEstado.Text);
                    }
                    else
                    {
                        Tabla.Insert("Estado", campos, valores);
                    }
                    LimpiarForm();
                    LlenarGrid();
                    
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
                txtEstado.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("Estado", "idEstado", dgEstado.CurrentRow.Cells["idEstado"].Value.ToString());
                txtIdEstado.Text = dr["idEstado"].ToString();
                txtEstado.Text = dr["Estado"].ToString();
                CboColorPicker.SelectedIndex= int.Parse(dr["indexColor"].ToString());
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
                txtEstado.ReadOnly = true;
                LimpiarForm();
                MostrarColor();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEstado.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("Estado", "idEstado", dgEstado.CurrentRow.Cells["idEstado"].Value.ToString());
                LlenarGrid();
            }
        }
        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEstado.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgEstado, Tabla.GetRecordsFiltersLike("Estado", "Estado", txtEstado.Text));
            }
        }

        private void cmb_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb == null) return;
            if (e.Index < 0) return;
            if (!(cmb.Items[e.Index] is Color)) return;
            Color color = (Color)cmb.Items[e.Index];
            // Dibujamos el fondo
            e.DrawBackground();
            // Creamos los objetos GDI+
            Brush brush = new SolidBrush(color);
            Pen forePen = new Pen(e.ForeColor);
            Brush foreBrush = new SolidBrush(e.ForeColor);
            // Dibujamos el borde del rectángulo
            e.Graphics.DrawRectangle(
                forePen,
                new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 19,
                    e.Bounds.Size.Height - 4));
            // Rellenamos el rectángulo con el Color seleccionado
            // en la combo
            e.Graphics.FillRectangle(brush,
                new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18,
                    e.Bounds.Size.Height - 5));
            // Dibujamos el nombre del color
            e.Graphics.DrawString(color.Name, cmb.Font,
                foreBrush, e.Bounds.Left + 25, e.Bounds.Top + 2);
            // Eliminamos objetos GDI+
            brush.Dispose();
            forePen.Dispose();
            foreBrush.Dispose();
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
