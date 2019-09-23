using KMonitor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMonitor.GUI
{
    public partial class frmProducto : Form
    {
        private bool eventChange;
        private bool eventKeyPress;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

            LlenarTodosLosCboProductos();

            LlenarGridCategoria();
            LlenarGridPresentacion();
            LlenarGridMarca();
            LlenarGridTipoProducto();
            LlenarGridProducto();
        }
        private void LlenarTodosLosCboProductos()
        {
            DBM.CLS.Funciones.FillCombobox(cboCategoria, "Familia", "idFamilia", "Familia");
            DBM.CLS.Funciones.FillCombobox(cboPresentacion, "unidadMedida", "idUnidad", "unidadMedida");
            //DBM.CLS.Funciones.FillCombobox(cboTipoProducto, "tipo_producto", "idTipo", "tipo_producto");
            //DBM.CLS.Funciones.FillCombobox(cboMarca, "marca", "idMarca", "marca");
        }
        //************************************************************************
        // MANTENIMIENTO Familia
        //************************************************************************
        private void btnCategoriaNewSave_Click(object sender, EventArgs e)
        {
            if (btnCategoriaNewSave.Tag.ToString() == "1")
            {
                btnCategoriaNewSave.Tag = "2";
                btnCategoriaNewSave.Image = Resources.save;
                btnCategoriaEditCancel.Tag = "2";
                btnCategoriaEditCancel.Image = Properties.Resources.cancel;
                txtCategoria.ReadOnly = false;
                LimpiarCategoryForm();
            }
            else
            {
                if (txtCategoria.TextLength > 0)
                {
                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("IdFamilia");
                    campos.Add("Familia");
                    campos.Add("activo");

                    List<string> valores = new List<string>();
                    if (txtIdCategoria.TextLength > 0)
                        valores.Add(txtIdCategoria.Text);
                    else
                        valores.Add((Tabla.GetNewId("Familia", "IdFamilia") > 0) ? Tabla.GetNewId("Familia", "IdFamilia").ToString() : (Tabla.GetNewId("Familia", "IdFamilia") + 1).ToString());

                    valores.Add(txtCategoria.Text);
                    valores.Add(chkCategoriaActiva.Checked ? "1" : "0");

                    btnCategoriaNewSave.Tag = "1";
                    btnCategoriaNewSave.Image = Properties.Resources.new_;

                    btnCategoriaEditCancel.Tag = "1";
                    btnCategoriaEditCancel.Image = Properties.Resources.edit;
                    txtCategoria.ReadOnly = true;

                    if (txtIdCategoria.TextLength > 0)
                    {
                        Tabla.Update("Familia", campos, valores, "IdFamilia", txtIdCategoria.Text);
                    }
                    else
                    {
                        Tabla.Insert("Familia", campos, valores);
                    }
                    LimpiarCategoryForm();
                    LlenarGridCategoria();
                    LlenarCboCategoria();
                }

            }
        }

        private void btnCategoriaEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();


            if (btnCategoriaEditCancel.Tag.ToString() == "1")
            {
                btnCategoriaEditCancel.Tag = "2";
                btnCategoriaEditCancel.Image = Properties.Resources.cancel;

                btnCategoriaNewSave.Tag = "2";
                btnCategoriaNewSave.Image = Resources.save;
                txtCategoria.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("Familia", "IdFamilia", dgCategoria.CurrentRow.Cells["IdFamilia"].Value.ToString());
                txtIdCategoria.Text = dr["IdFamilia"].ToString();
                txtCategoria.Text = dr["Familia"].ToString();
                chkCategoriaActiva.Checked = bool.Parse(dr["activo"].ToString()) ? true : false;
            }
            else
            {
                btnCategoriaEditCancel.Tag = "1";
                btnCategoriaEditCancel.Image = Properties.Resources.edit;

                btnCategoriaNewSave.Tag = "1";
                btnCategoriaNewSave.Image = Properties.Resources.new_;
                txtCategoria.ReadOnly = true;
                LimpiarCategoryForm();
            }
        }
        private void btnCategoriaDelete_Click(object sender, EventArgs e)
        {
            if (dgCategoria.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("Familia", "IdFamilia", dgCategoria.CurrentRow.Cells["IdFamilia"].Value.ToString());
                LlenarGridCategoria();
            }
        }
        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCategoria.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgCategoria, Tabla.GetRecordsFiltersLike("Familia", "Familia", txtCategoria.Text));
            }
        }
        //***************************************************************************************
        //* LLENAR TODOS LOS COMBOBOX
        //***************************************************************************************
        private void LlenarCboCategoria()
        {
            DBM.CLS.Funciones.FillCombobox(cboCategoria, "Familia", "IdFamilia", "Familia");
        }
        private void LlenarCboPresentacion()
        {
            DBM.CLS.Funciones.FillCombobox(cboPresentacion, "UnidadMedida", "idUnidad", "UnidadMedida");
        }
        private void LlenarCboMarca()
        {
            DBM.CLS.Funciones.FillCombobox(cboMarca, "marca", "idMarca", "marca");
        }
        private void LlenarCboTipoProducto()
        {
            DBM.CLS.Funciones.FillCombobox(cboTipoProducto, "tipo_producto", "idTipo", "tipo_producto");
        }
        //***************************************************************************************
        //* LLENAR TODOS LOS GRID VIEW
        //***************************************************************************************
        private void LlenarGridCategoria()
        {
            DBM.CLS.Funciones.FillGridView(dgCategoria, "Familia");
        }
        private void LlenarGridPresentacion()
        {
            DBM.CLS.Funciones.FillGridView(dgPresentacion, "UnidadMedida");
        }
        private void LlenarGridMarca()
        {
            DBM.CLS.Funciones.FillGridView(dgMarcas, "marca");
        }
        private void LlenarGridTipoProducto()
        {
            DBM.CLS.Funciones.FillGridView(dgTipoProducto, "tipo_producto");
        }
        private void LlenarGridProducto()
        {
            DBM.CLS.Funciones.FillGridView(dgProducto, "producto");
        }
        //***************************************************************************************
        //* LIMPIAR
        //***************************************************************************************
        private void LimpiarCategoryForm()
        {
            groupBoxCategoria.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            chkCategoriaActiva.Checked = false;
        }
        private void LimpiarPresentacionForm()
        {
            groupBoxPresentacion.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private void LimpiarMarcaForm()
        {
            groupBoxMarca.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private void LimpiarTipoProductoForm()
        {
            groupBoxTipoProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private void LimpiarProductoForm()
        {
            groupBoxProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            txtIdProducto.Clear();
            groupBoxProducto.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
        }

        private void btnCategoriaSearch_Click(object sender, EventArgs e)
        {
            LimpiarCategoryForm();
            txtCategoria.ReadOnly = false;
            txtCategoria.Focus();
        }
        //************************************************************************
        // MANTENIMIENTO UnidadMedida
        //************************************************************************
        private void btnPresentacionNewSave_Click(object sender, EventArgs e)
        {
            if (btnPresentacionNewSave.Tag.ToString() == "1")
            {
                btnPresentacionNewSave.Tag = "2";
                btnPresentacionNewSave.Image = Resources.save;
                btnPresentacionEditCancel.Tag = "2";
                btnPresentacionEditCancel.Image = Properties.Resources.cancel;
                txtPresentacion.ReadOnly = false;
                LimpiarPresentacionForm();
            }
            else
            {
                if (txtPresentacion.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idUnidad");
                    campos.Add("UnidadMedida");

                    List<string> valores = new List<string>();
                    if (txtIdPresentacion.TextLength > 0)
                        valores.Add(txtIdPresentacion.Text);
                    else
                        valores.Add((Tabla.GetNewId("UnidadMedida", "idUnidad") > 0) ? Tabla.GetNewId("UnidadMedida", "idUnidad").ToString() : (Tabla.GetNewId("UnidadMedida", "idUnidad") + 1).ToString());

                    valores.Add(txtPresentacion.Text);

                    btnPresentacionNewSave.Tag = "1";
                    btnPresentacionNewSave.Image = Properties.Resources.new_;

                    btnPresentacionEditCancel.Tag = "1";
                    btnPresentacionEditCancel.Image = Properties.Resources.edit;
                    txtPresentacion.ReadOnly = true;

                    if (txtIdPresentacion.TextLength > 0)
                    {
                        Tabla.Update("UnidadMedida", campos, valores, "idUnidad", txtIdPresentacion.Text);
                    }
                    else
                    {
                        Tabla.Insert("UnidadMedida", campos, valores);
                    }
                    LimpiarPresentacionForm();
                    LlenarGridPresentacion();
                    LlenarCboPresentacion();
                }
            }

        }

        private void btnPresentacionEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();


            if (btnPresentacionEditCancel.Tag.ToString() == "1")
            {
                btnPresentacionEditCancel.Tag = "2";
                btnPresentacionEditCancel.Image = Properties.Resources.cancel;

                btnPresentacionNewSave.Tag = "2";
                btnPresentacionNewSave.Image = Resources.save;
                txtPresentacion.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("UnidadMedida", "idUnidad", dgPresentacion.CurrentRow.Cells["idUnidad"].Value.ToString());
                txtIdPresentacion.Text = dr["idUnidad"].ToString();
                txtPresentacion.Text = dr["UnidadMedida"].ToString();
            }
            else
            {
                btnPresentacionEditCancel.Tag = "1";
                btnPresentacionEditCancel.Image = Properties.Resources.edit;

                btnPresentacionNewSave.Tag = "1";
                btnPresentacionNewSave.Image = Properties.Resources.new_;
                txtPresentacion.ReadOnly = true;
                LimpiarPresentacionForm();
            }
        }

        private void btnPresentacionDelete_Click(object sender, EventArgs e)
        {
            if (dgPresentacion.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("Presebtacion", "idUnidad", dgPresentacion.CurrentRow.Cells["idUnidad"].Value.ToString());
                LlenarGridPresentacion();
            }
        }

        private void btnPresentacionSearch_Click(object sender, EventArgs e)
        {
            LimpiarPresentacionForm();
            txtPresentacion.ReadOnly = false;
            txtPresentacion.Focus();
        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {
            if (txtIdPresentacion.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgPresentacion, Tabla.GetRecordsFiltersLike("UnidadMedida", "UnidadMedida", txtPresentacion.Text));
            }
        }
        //************************************************************************
        // MANTENIMIENTO MARCA
        //************************************************************************
        private void btnMarcaNewSave_Click(object sender, EventArgs e)
        {
            if (btnMarcaNewSave.Tag.ToString() == "1")
            {
                btnMarcaNewSave.Tag = "2";
                btnMarcaNewSave.Image = Resources.save;
                btnMarcaEditCancel.Tag = "2";
                btnMarcaEditCancel.Image = Properties.Resources.cancel;
                txtMarca.ReadOnly = false;
                LimpiarMarcaForm();
            }
            else
            {
                if (txtMarca.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idMarca");
                    campos.Add("Marca");

                    List<string> valores = new List<string>();
                    if (txtIdMarca.TextLength > 0)
                        valores.Add(txtIdMarca.Text);
                    else
                        valores.Add((Tabla.GetNewId("marca", "idMarca") > 0) ? Tabla.GetNewId("marca", "idMarca").ToString() : (Tabla.GetNewId("marca", "idMarca") + 1).ToString());

                    valores.Add(txtMarca.Text);

                    btnMarcaNewSave.Tag = "1";
                    btnMarcaNewSave.Image = Properties.Resources.new_;

                    btnMarcaEditCancel.Tag = "1";
                    btnMarcaEditCancel.Image = Properties.Resources.edit;
                    txtMarca.ReadOnly = true;

                    if (txtIdMarca.TextLength > 0)
                    {
                        Tabla.Update("marca", campos, valores, "idMarca", txtIdMarca.Text);
                    }
                    else
                    {
                        Tabla.Insert("marca", campos, valores);
                    }
                    LimpiarMarcaForm();
                    LlenarGridMarca();
                    LlenarCboMarca();
                }
            }

        }

        private void btnMarcaEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();


            if (btnMarcaEditCancel.Tag.ToString() == "1")
            {
                btnMarcaEditCancel.Tag = "2";
                btnMarcaEditCancel.Image = Properties.Resources.cancel;

                btnMarcaNewSave.Tag = "2";
                btnMarcaNewSave.Image = Resources.save;
                txtMarca.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("marca", "idMarca", dgMarcas.CurrentRow.Cells["idMarca"].Value.ToString());
                txtIdMarca.Text = dr["idMarca"].ToString();
                txtMarca.Text = dr["marca"].ToString();
            }
            else
            {
                btnMarcaEditCancel.Tag = "1";
                btnMarcaEditCancel.Image = Properties.Resources.edit;

                btnMarcaNewSave.Tag = "1";
                btnMarcaNewSave.Image = Properties.Resources.new_;
                txtMarca.ReadOnly = true;
                LimpiarMarcaForm();
            }
        }

        private void btnMarcaDelete_Click(object sender, EventArgs e)
        {
            if (dgMarcas.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("marca", "idMarca", dgMarcas.CurrentRow.Cells["idMarca"].Value.ToString());
                LlenarGridMarca();
            }
        }

        private void btnMarcaSearch_Click(object sender, EventArgs e)
        {
            LimpiarMarcaForm();
            txtMarca.ReadOnly = false;
            txtMarca.Focus();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtIdMarca.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgMarcas, Tabla.GetRecordsFiltersLike("marca", "marca", txtMarca.Text));
            }
        }

        //************************************************************************
        // MANTENIMIENTO TIPO DE PRODUCTO
        //************************************************************************
        private void btnTipoProductoNewSave_Click(object sender, EventArgs e)
        {
            if (btnTipoProductoNewSave.Tag.ToString() == "1")
            {
                btnTipoProductoNewSave.Tag = "2";
                btnTipoProductoNewSave.Image = Resources.save;
                btnTipoProductoEditCancel.Tag = "2";
                btnTipoProductoEditCancel.Image = Properties.Resources.cancel;
                txtTipoProducto.ReadOnly = false;
                LimpiarTipoProductoForm();
            }
            else
            {
                if (txtTipoProducto.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idTipo");
                    campos.Add("tipo_producto");

                    List<string> valores = new List<string>();
                    if (txtIdTipo.TextLength > 0)
                        valores.Add(txtIdTipo.Text);
                    else
                        valores.Add((Tabla.GetNewId("tipo_producto", "idTipo") > 0) ? Tabla.GetNewId("tipo_producto", "idTipo").ToString() : (Tabla.GetNewId("tipo_producto", "idTipo") + 1).ToString());

                    valores.Add(txtTipoProducto.Text);

                    btnTipoProductoNewSave.Tag = "1";
                    btnTipoProductoNewSave.Image = Properties.Resources.new_;

                    btnTipoProductoEditCancel.Tag = "1";
                    btnTipoProductoEditCancel.Image = Properties.Resources.edit;
                    txtTipoProducto.ReadOnly = true;

                    if (txtIdTipo.TextLength > 0)
                    {
                        Tabla.Update("tipo_producto", campos, valores, "idTipo", txtIdTipo.Text);
                    }
                    else
                    {
                        Tabla.Insert("tipo_producto", campos, valores);
                    }
                    LimpiarTipoProductoForm();
                    LlenarGridTipoProducto();
                    LlenarCboTipoProducto();
                }
            }

        }

        private void btnTipoProductoEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();


            if (btnTipoProductoEditCancel.Tag.ToString() == "1")
            {
                btnTipoProductoEditCancel.Tag = "2";
                btnTipoProductoEditCancel.Image = Properties.Resources.cancel;

                btnTipoProductoNewSave.Tag = "2";
                btnTipoProductoNewSave.Image = Resources.save;
                txtTipoProducto.ReadOnly = false;
                DataRow dr = Tabla.GetRecordByID("tipo_producto", "idTipo", dgTipoProducto.CurrentRow.Cells["idTipo"].Value.ToString());
                txtIdTipo.Text = dr["idTipo"].ToString();
                txtTipoProducto.Text = dr["tipo_producto"].ToString();
            }
            else
            {
                btnTipoProductoEditCancel.Tag = "1";
                btnTipoProductoEditCancel.Image = Properties.Resources.edit;

                btnTipoProductoNewSave.Tag = "1";
                btnTipoProductoNewSave.Image = Properties.Resources.new_;
                txtTipoProducto.ReadOnly = true;
                LimpiarTipoProductoForm();
            }
        }

        private void btnTipoProductoDelete_Click(object sender, EventArgs e)
        {
            if (dgTipoProducto.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("tipo_producto", "tipo_producto", dgTipoProducto.CurrentRow.Cells["idTipo"].Value.ToString());
                LlenarGridMarca();
            }
        }

        private void btnTipoProductoSearch_Click(object sender, EventArgs e)
        {
            LimpiarTipoProductoForm();
            txtTipoProducto.ReadOnly = false;
            txtTipoProducto.Focus();
        }

        private void txtTipoProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdTipo.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgTipoProducto, Tabla.GetRecordsFiltersLike("tipo_producto", "tipo_producto", txtTipoProducto.Text));
            }
        }
        //************************************************************************
        // MANTENIMIENTO PRODUCCTO GRIDVIEW
        //************************************************************************
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDecimal(sender, e, txtCosto.Text);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDecimal(sender, e, txtPrecio.Text);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

        private void dgProducto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //VALIDAR TextChange para CALCULOS

            if (this.dgProducto.CurrentCell.ColumnIndex >= 1 && this.dgProducto.CurrentCell.ColumnIndex <= 5)
            {
                if (!this.eventChange)
                {
                    e.Control.Validating += this.Cell_TextChanged;
                    this.eventChange = true;
                }
            }
            else
            {
                e.Control.Validating -= this.Cell_TextChanged;
                this.eventChange = false;
            }
            //VALIDAR KEYPRESS DE COSTO Y PRECIO
            if (this.dgProducto.CurrentCell.ColumnIndex >= 2 && this.dgProducto.CurrentCell.ColumnIndex <= 3)
            {
                if (!this.eventKeyPress)
                {
                    e.Control.KeyPress += this.Cell_KeyPressEventDecimales;
                    this.eventKeyPress = true;
                }
            }
            else
            {
                e.Control.KeyPress -= this.Cell_KeyPressEventDecimales;
                this.eventKeyPress = false;
            }

            //VALIDAR KEYPRESS DE STOCK Y STOCK MÍNIMO
            if (this.dgProducto.CurrentCell.ColumnIndex >= 4 && this.dgProducto.CurrentCell.ColumnIndex <= 5)
            {
                if (!this.eventKeyPress)
                {
                    e.Control.KeyPress += this.Cell_KeyPressEventDigitos;
                    this.eventKeyPress = true;
                }
            }
            else
            {
                e.Control.KeyPress -= this.Cell_KeyPressEventDigitos;
                this.eventKeyPress = false;
            }
        }

        private void Cell_TextChanged(object sender, EventArgs e)
        {
            if (dgProducto.CurrentRow.Cells["idProducto"].Value != null && dgProducto.CurrentRow.Cells["idProducto"].Value.ToString().Length > 0 && int.Parse(dgProducto.CurrentRow.Cells["idProducto"].Value.ToString()) > 0)
            {
                dgProducto.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idProducto");
                campos.Add("descripcion");
                campos.Add("precio");
                campos.Add("costo");
                campos.Add("stock");
                campos.Add("stockMinimo");
                campos.Add("inventariable");
                campos.Add("activo");

                List<string> valores = new List<string>();
                valores.Add(dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());
                valores.Add(dgProducto.CurrentRow.Cells["descripcion"].Value.ToString());
                valores.Add(dgProducto.CurrentRow.Cells["precio"].Value.ToString());
                valores.Add(dgProducto.CurrentRow.Cells["costo"].Value.ToString());
                valores.Add(dgProducto.CurrentRow.Cells["stock"].Value.ToString());
                valores.Add(dgProducto.CurrentRow.Cells["stockMinimo"].Value.ToString());
                valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["inventariable"].EditedFormattedValue)) ? "1" : "0");
                valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["activoprod"].EditedFormattedValue)) ? "1" : "0");

                Tabla.Update("producto", campos, valores, "idProducto", dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());

            }

            /*
            CLS.NotaAsignatura objNotas = new CLS.NotaAsignatura();
            objNotas.idNotaAsignatura = int.Parse(dgProducto.CurrentRow.Cells["idNotaAsignatura"].Value.ToString());
            objNotas.A1 = dgProducto.CurrentRow.Cells["actividad1"].Value.ToString();
            objNotas.A2 = dgProducto.CurrentRow.Cells["actividad2"].Value.ToString();
            objNotas.A3 = dgProducto.CurrentRow.Cells["actividad3"].Value.ToString();

            double p1 = double.Parse(float.Parse(txtPa1.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture).ToString("F2").Replace(",", ".")) / 100;
            double p2 = double.Parse(float.Parse(txtPa2.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture).ToString("F2").Replace(",", ".")) / 100;
            double p3 = double.Parse(float.Parse(txtPa3.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture).ToString("F2").Replace(",", ".")) / 100;

            objNotas.PA1 = p1.ToString("N2");
            objNotas.PA2 = p2.ToString("N2");
            objNotas.PA3 = p3.ToString("N2");
            objNotas.Promedio = objNotas.GetPromedio();

            dgProducto.CurrentRow.Cells["promedio"].Value = objNotas.GetPromedio();
            //objNotas.UpdateNotas(int.Parse(cboPeriodo.SelectedValue.ToString()));
            */
        }

        private void Cell_KeyPressEventDigitos(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }
        private void Cell_KeyPressEventDecimales(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDecimal(sender, e, dgProducto.CurrentCell.EditedFormattedValue.ToString());
        }

        private void dgProducto_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dgProducto.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int NewId = 0;
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idProducto");
                campos.Add("descripcion");
                campos.Add("precio");
                campos.Add("costo");
                campos.Add("stock");
                campos.Add("stockMinimo");
                campos.Add("inventariable");
                campos.Add("activo");

                List<string> valores = new List<string>();
                if (dgProducto.CurrentRow.Cells["idProducto"].Value != null && dgProducto.CurrentRow.Cells["idProducto"].Value.ToString().Length > 0)
                {
                    valores.Add(dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());
                }
                else
                {
                    NewId = (Tabla.GetNewId("producto", "idProducto") > 0) ? Tabla.GetNewId("producto", "idProducto") : (Tabla.GetNewId("producto", "idProducto") + 1);
                    //(Tabla.GetNewId("producto", "idProducto") > 0) ? Tabla.GetNewId("producto", "idProducto").ToString() : (Tabla.GetNewId("producto", "idProducto") + 1).ToString()
                    valores.Add(NewId.ToString());
                    //dgProducto.CurrentRow.Cells["idProducto"].Value = NewId;
                    valores.Add(dgProducto.CurrentRow.Cells["descripcion"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["precio"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["costo"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["stock"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["stockMinimo"].Value.ToString());

                    valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["inventariable"].EditedFormattedValue)) ? "1" : "0");
                    valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["activoprod"].EditedFormattedValue)) ? "1" : "0");
                }
                if (dgProducto.CurrentRow.Cells["idProducto"].Value == null || dgProducto.CurrentRow.Cells["idProducto"].Value.ToString().Length == 0)
                {
                    if (dgProducto.CurrentRow.Cells["descripcion"].Value.ToString().Length > 0 && dgProducto.CurrentRow.Cells["costo"].Value.ToString().Length > 0 && dgProducto.CurrentRow.Cells["precio"].Value.ToString().Length > 0)
                    {

                        Tabla.Insert("Producto", campos, valores);
                        dgProducto.CurrentRow.Cells["idProducto"].Value = NewId;
                        LlenarGridProducto();

                        dgProducto.CurrentCell = dgProducto.Rows[dgProducto.RowCount - 1].Cells[0];
                        dgProducto.CurrentCell.ReadOnly = false;
                        dgProducto.BeginEdit(true);
                        dgProducto.EndEdit();
                        dgProducto.CurrentCell.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            dgProducto.CurrentCell = dgProducto.Rows[dgProducto.RowCount - 1].Cells[0];
        }
        private void dgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)//set your checkbox column index instead of 2
            {
                dgProducto.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (dgProducto.CurrentRow.Cells["idProducto"].Value.ToString().Length > 0 && int.Parse(dgProducto.CurrentRow.Cells["idProducto"].Value.ToString()) > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idProducto");
                    campos.Add("descripcion");
                    campos.Add("precio");
                    campos.Add("costo");
                    campos.Add("stock");
                    campos.Add("stockMinimo");
                    campos.Add("inventariable");
                    campos.Add("activo");

                    List<string> valores = new List<string>();
                    valores.Add(dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["descripcion"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["precio"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["costo"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["stock"].Value.ToString());
                    valores.Add(dgProducto.CurrentRow.Cells["stockMinimo"].Value.ToString());
                    valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["inventariable"].EditedFormattedValue)) ? "1" : "0");
                    valores.Add((Convert.ToBoolean(dgProducto.CurrentRow.Cells["activoprod"].EditedFormattedValue)) ? "1" : "0");

                    Tabla.Update("producto", campos, valores, "idProducto", dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());
                }
            }

        }
        //*****************************************************************************
        //* MANTENIMIENTO PRODUCTO INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        

        private void btnProductoNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnProductoNewSave.Tag.ToString() == "1")
            {
                btnProductoNewSave.Tag = "2";
                btnProductoNewSave.Image = Resources.save;
                btnProductoEditCancel.Tag = "2";
                btnProductoEditCancel.Image = Properties.Resources.cancel;
                groupBoxProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly =false);
                LimpiarProductoForm();
            }
            else
            {
                if (txtDescripcion.TextLength > 0 && txtPrecio.TextLength > 0 && txtCosto.TextLength > 0 && txtStock.TextLength > 0 && txtStockMinimo.TextLength > 0)
                {
                    
                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idProducto");

                    campos.Add("IdFamilia");
                    campos.Add("idUnidad");
                    campos.Add("idTipo");
                    campos.Add("idMarca");

                    campos.Add("descripcion");
                    campos.Add("precio");
                    campos.Add("costo");
                    campos.Add("stock");
                    campos.Add("stockMinimo");
                    campos.Add("inventariable");
                    campos.Add("activo");

                    List<string> valores = new List<string>();
                    if (txtIdProducto.TextLength > 0)
                        valores.Add(txtIdProducto.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("producto", "idProducto") > 0) ? Tabla.GetNewId("producto", "idProducto") : (Tabla.GetNewId("producto", "idProducto") + 1);
                        valores.Add(NewId.ToString());
                    }
                    valores.Add(cboCategoria.SelectedValue.ToString());
                    valores.Add(cboPresentacion.SelectedValue.ToString());
                    valores.Add(cboTipoProducto.SelectedValue.ToString());
                    valores.Add(cboMarca.SelectedValue.ToString());

                    valores.Add(txtDescripcion.Text);
                    valores.Add(txtPrecio.Text);
                    valores.Add(txtCosto.Text);
                    valores.Add(txtStock.Text);
                    valores.Add(txtStockMinimo.Text);
                    valores.Add(chkInventariable.Checked ? "1" : "0");
                    valores.Add(chkMostrar.Checked ? "1" : "0");

                    btnProductoNewSave.Tag = "1";
                    btnProductoNewSave.Image = Properties.Resources.new_;

                    btnProductoEditCancel.Tag = "1";
                    btnProductoEditCancel.Image = Properties.Resources.edit;
                    groupBoxProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);

                    bool actualizacion;
                    int filaActual = 0;
                    if (txtIdProducto.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgProducto.CurrentRow.Index;
                        Tabla.Update("producto", campos, valores, "idProducto", txtIdProducto.Text);
                    }
                    else
                    {
                        actualizacion = false;
                        
                        Tabla.Insert("producto", campos, valores);
                    }

                    LlenarGridProducto();
                    dgProducto.Refresh();

                    if (actualizacion)
                        dgProducto.CurrentCell = dgProducto.Rows[filaActual].Cells[0];
                    else
                    {
                        filaActual = dgProducto.Rows.Count - 1;
                        dgProducto.CurrentCell = dgProducto.Rows[dgProducto.RowCount - 1].Cells[0];
                        //dgProducto.CurrentCell = dgProducto.Rows[filaActual].Cells[0];
                    }
                    LimpiarProductoForm();
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnProductoEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnProductoEditCancel.Tag.ToString() == "1")
            {
                btnProductoEditCancel.Tag = "2";
                btnProductoEditCancel.Image = Properties.Resources.cancel;

                btnProductoNewSave.Tag = "2";
                btnProductoNewSave.Image = Resources.save;
                groupBoxProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                DataRow dr = Tabla.GetRecordByID("producto", "idProducto", dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());

                txtIdProducto.Text = dr["idProducto"].ToString();


                if(dr["IdFamilia"].ToString().Length>0)
                    cboCategoria.SelectedValue = dr["IdFamilia"].ToString();
                if (dr["idUnidad"].ToString().Length > 0)
                    cboPresentacion.SelectedValue = dr["idUnidad"].ToString();
                if (dr["idTipo"].ToString().Length > 0)
                    cboTipoProducto.SelectedValue = dr["idTipo"].ToString();
                if (dr["idMarca"].ToString().Length > 0)
                    cboMarca.SelectedValue = dr["idMarca"].ToString();

                txtDescripcion.Text = dr["descripcion"].ToString();
                txtPrecio.Text = dr["precio"].ToString();
                txtCosto.Text = dr["costo"].ToString();
                txtStock.Text = dr["stock"].ToString();
                txtStockMinimo.Text = dr["stockMinimo"].ToString();
                chkInventariable.Checked = Convert.ToBoolean(dr["inventariable"].ToString());
                chkMostrar.Checked = Convert.ToBoolean(dr["activo"].ToString());

            }
            else
            {
                btnProductoEditCancel.Tag = "1";
                btnProductoEditCancel.Image = Properties.Resources.edit;

                btnProductoNewSave.Tag = "1";
                btnProductoNewSave.Image = Properties.Resources.new_;
                groupBoxProducto.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                LimpiarProductoForm();
            }
        }

        private void btnProductoDelete_Click(object sender, EventArgs e)
        {
            if (dgProducto.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("producto", "idProducto", dgProducto.CurrentRow.Cells["idProducto"].Value.ToString());
                LlenarGridProducto();
            }
        }

        private void btnProductoSearch_Click(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgProducto, Table.GetRecordsFiltersLike("producto", "descripcion", txtFiltroProducto.Text));
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProducto.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgProducto, Tabla.GetRecordsFiltersLike("producto", "descripcion", txtDescripcion.Text));
            }
        }


    }
}
//dgProducto.Rows[dgProducto.RowCount - 1].Selected = true;