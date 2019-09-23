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
    public partial class frmClienteProveedor : Form
    {
        private bool eventChange;
        private bool eventKeyPress;
        public frmClienteProveedor()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LlenarGridCliente();
            LlenarGridProveedor();
        }

        //***************************************************************************************
        //* LLENAR TODOS LOS GRID VIEW
        //***************************************************************************************

        private void LlenarGridCliente()
        {
            DBM.CLS.Funciones.FillGridView(dgCliente, "cliente");
        }

        private void LlenarGridProveedor()
        {
            DBM.CLS.Funciones.FillGridView(dgProveedor, "proveedor");
        }
        //***************************************************************************************
        //* LIMPIAR
        //***************************************************************************************
        private void LimpiarClienteForm()
        {
            groupBoxCliente.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            groupBoxCliente.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
        }
        private void LimpiarProveedorForm()
        {
            groupBoxProveedor.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            groupBoxProveedor.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
        }
        //************************************************************************
        // MANTENIMIENTO CLIENTE GRIDVIEW
        //************************************************************************
        
        private void dgCliente_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //VALIDAR TextChange para actualizaciones

            if (this.dgCliente.CurrentCell.ColumnIndex >= 1 && this.dgCliente.CurrentCell.ColumnIndex <= 6)
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


            //VALIDAR KEYPRESS DE STOCK Y STOCK MÍNIMO
            if (this.dgCliente.CurrentCell.ColumnIndex == 3)
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
            if (dgCliente.CurrentRow.Cells["idCliente"].Value != null && dgCliente.CurrentRow.Cells["idCliente"].Value.ToString().Length > 0 && int.Parse(dgCliente.CurrentRow.Cells["idCliente"].Value.ToString()) > 0)
            {
                dgCliente.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idCliente");
                campos.Add("nombre");
                campos.Add("direccion");
                campos.Add("email");
                campos.Add("telefono");
                campos.Add("NIT");
                //campos.Add("NRC");

                List<string> valores = new List<string>();
                valores.Add(dgCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                valores.Add(dgCliente.CurrentRow.Cells["nombre"].Value.ToString());
                valores.Add(dgCliente.CurrentRow.Cells["direccion"].Value.ToString());
                valores.Add(dgCliente.CurrentRow.Cells["email"].Value.ToString());
                valores.Add(dgCliente.CurrentRow.Cells["telefono"].Value.ToString());
                valores.Add(dgCliente.CurrentRow.Cells["NIT"].Value.ToString());
                //valores.Add(dgCliente.CurrentRow.Cells["NRC"].Value.ToString());

                Tabla.Update("cliente", campos, valores, "idCliente", dgCliente.CurrentRow.Cells["idCliente"].Value.ToString());

            }
        }

        private void Cell_KeyPressEventDigitos(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }
        private void dgCliente_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dgCliente.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int NewId = 0;
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idCliente");
                campos.Add("nombre");
                campos.Add("direccion");
                campos.Add("email");
                campos.Add("telefono");
                campos.Add("NIT");
                //campos.Add("NRC");

                List<string> valores = new List<string>();
                if (dgCliente.CurrentRow.Cells["idCliente"].Value != null && dgCliente.CurrentRow.Cells["idCliente"].Value.ToString().Length > 0)
                {
                    valores.Add(dgCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                }
                else
                {
                    NewId = (Tabla.GetNewId("cliente", "idCliente") > 0) ? Tabla.GetNewId("cliente", "idCliente") : (Tabla.GetNewId("cliente", "idCliente") + 1);
                    valores.Add(NewId.ToString());
                    valores.Add(dgCliente.CurrentRow.Cells["nombre"].Value.ToString());
                    valores.Add(dgCliente.CurrentRow.Cells["direccion"].Value.ToString());
                    valores.Add(dgCliente.CurrentRow.Cells["email"].Value.ToString());
                    valores.Add(dgCliente.CurrentRow.Cells["telefono"].Value.ToString());
                    valores.Add(dgCliente.CurrentRow.Cells["NIT"].Value.ToString());
                  //  valores.Add(dgCliente.CurrentRow.Cells["NRC"].Value.ToString());
                }
                if (dgCliente.CurrentRow.Cells["idCliente"].Value == null || dgCliente.CurrentRow.Cells["idCliente"].Value.ToString().Length == 0)
                {
                    if (dgCliente.CurrentRow.Cells["nombre"].Value.ToString().Length > 0 && dgCliente.CurrentRow.Cells["direccion"].Value.ToString().Length > 0)
                    {

                        Tabla.Insert("cliente", campos, valores);
                        dgCliente.CurrentRow.Cells["idCliente"].Value = NewId;
                        LlenarGridCliente();

                        dgCliente.CurrentCell = dgCliente.Rows[dgCliente.RowCount - 1].Cells[0];
                        dgCliente.CurrentCell.ReadOnly = false;
                        dgCliente.BeginEdit(true);
                        dgCliente.EndEdit();
                        dgCliente.CurrentCell.ReadOnly = true;
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
            dgCliente.CurrentCell = dgCliente.Rows[dgCliente.RowCount - 1].Cells[0];
        }

        //*****************************************************************************
        //* MANTENIMIENTO CLIENTE INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

        private void btnClienteNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnClienteNewSave.Tag.ToString() == "1")
            {
                btnClienteNewSave.Tag = "2";
                btnClienteNewSave.Image = Resources.save;
                btnClienteEditCancel.Tag = "2";
                btnClienteEditCancel.Image = Properties.Resources.cancel;
                groupBoxCliente.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdCliente.ReadOnly = true;
                LimpiarClienteForm();
            }
            else
            {
                if (txtNombre.TextLength > 0 && txtDireccion.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idCliente");
                    campos.Add("nombre");
                    campos.Add("direccion");
                    campos.Add("email");
                    campos.Add("telefono");
                    campos.Add("NIT");
                    //campos.Add("NRC");

                    List<string> valores = new List<string>();
                    if (txtIdCliente.TextLength > 0)
                        valores.Add(txtIdCliente.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("cliente", "idCliente") > 0) ? Tabla.GetNewId("cliente", "idCliente") : (Tabla.GetNewId("cliente", "idCliente") + 1);
                        valores.Add(NewId.ToString());
                    }


                    valores.Add(txtNombre.Text);
                    valores.Add(txtDireccion.Text);
                    valores.Add(txtEmail.Text);
                    valores.Add(txtTelefono.Text);
                    valores.Add(txtNIT.Text);
                    //valores.Add(txtNRC.Text);

                    btnClienteNewSave.Tag = "1";
                    btnClienteNewSave.Image = Properties.Resources.new_;

                    btnClienteEditCancel.Tag = "1";
                    btnClienteEditCancel.Image = Properties.Resources.edit;
                    groupBoxCliente.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);

                    bool actualizacion;
                    int filaActual = 0;
                    if (txtIdCliente.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgCliente.CurrentRow.Index;
                        Tabla.Update("cliente", campos, valores, "idcliente", txtIdCliente.Text);
                    }
                    else
                    {
                        actualizacion = false;

                        Tabla.Insert("cliente", campos, valores);
                    }

                    LlenarGridCliente();
                    dgCliente.Refresh();

                    if (actualizacion)
                        dgCliente.CurrentCell = dgCliente.Rows[filaActual].Cells[0];
                    else
                    {
                        filaActual = dgCliente.Rows.Count - 1;
                        dgCliente.CurrentCell = dgCliente.Rows[dgCliente.RowCount - 1].Cells[0];
                        //dgProducto.CurrentCell = dgProducto.Rows[filaActual].Cells[0];
                    }
                    LimpiarClienteForm();
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnClienteEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnClienteEditCancel.Tag.ToString() == "1")
            {
                btnClienteEditCancel.Tag = "2";
                btnClienteEditCancel.Image = Properties.Resources.cancel;

                btnClienteNewSave.Tag = "2";
                btnClienteNewSave.Image = Resources.save;
                groupBoxCliente.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdCliente.ReadOnly = true;
                DataRow dr = Tabla.GetRecordByID("cliente", "idCliente", dgCliente.CurrentRow.Cells["idCliente"].Value.ToString());

                txtIdCliente.Text = dr["idCliente"].ToString();
                txtNombre.Text = dr["nombre"].ToString();
                txtDireccion.Text = dr["direccion"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtTelefono.Text = dr["telefono"].ToString();
                txtNIT.Text = dr["NIT"].ToString();
                //txtNRC.Text = dr["NRC"].ToString();

            }
            else
            {
                btnClienteEditCancel.Tag = "1";
                btnClienteEditCancel.Image = Properties.Resources.edit;

                btnClienteNewSave.Tag = "1";
                btnClienteNewSave.Image = Properties.Resources.new_;
                groupBoxCliente.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                LimpiarClienteForm();
            }
        }

        private void btnClienteDelete_Click(object sender, EventArgs e)
        {
            if (dgCliente.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("cliente", "idCliente", dgCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                LlenarGridCliente();
            }
        }

        private void btnClienteSearch_Click(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgCliente, Table.GetRecordsFiltersLike("cliente", "nombre", txtFiltroCliente.Text));
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgCliente, Tabla.GetRecordsFiltersLike("cliente", "nombre", txtNombre.Text));
            }
        }

        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgCliente, Table.GetRecordsFiltersLike("cliente", "nombre", txtFiltroCliente.Text));
        }




        //************************************************************************
        // MANTENIMIENTO PROVEEDORES GRIDVIEW PESTAÑA 2
        //************************************************************************

        private void dgProveedor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgProveedor.CurrentCell.ColumnIndex >= 1 && dgProveedor.CurrentCell.ColumnIndex <= 7)
            {
                if (!this.eventChange)
                {
                    e.Control.Validating += this.Cell_TextChangedProv;
                    this.eventChange = true;
                }
            }
            else
            {
                e.Control.Validating -= this.Cell_TextChangedProv;
                this.eventChange = false;
            }


            //VALIDAR KEYPRESS DE STOCK Y STOCK MÍNIMO
            if (this.dgProveedor.CurrentCell.ColumnIndex == 3)
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

        private void Cell_TextChangedProv(object sender, EventArgs e)
        {
            if (dgProveedor.CurrentRow.Cells["idProveedor"].Value != null && dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString().Length > 0 && int.Parse(dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString()) > 0)
            {
                dgProveedor.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idProveedor");
                campos.Add("nombre");
                campos.Add("direccion");
                campos.Add("email");
                campos.Add("telefono");
                campos.Add("NIT");
                campos.Add("regContable");
                campos.Add("contacto");

                List<string> valores = new List<string>();
                valores.Add(dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["nombreProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["direccionProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["emailProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["telefonoProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["NITProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["NRCProv"].Value.ToString());
                valores.Add(dgProveedor.CurrentRow.Cells["contacto"].Value.ToString());

                Tabla.Update("Proveedor", campos, valores, "idProveedor", dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString());

            }
        }

        private void dgProveedor_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgProveedor.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int NewId = 0;
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idProveedor");
                campos.Add("nombre");
                campos.Add("direccion");
                campos.Add("email");
                campos.Add("telefono");
                campos.Add("NIT");
                campos.Add("regContable");
                campos.Add("contacto");

                List<string> valores = new List<string>();
                if (dgProveedor.CurrentRow.Cells["idProveedor"].Value != null && dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString().Length > 0)
                {
                    valores.Add(dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString());
                }
                else
                {
                    NewId = (Tabla.GetNewId("proveedor", "idProveedor") > 0) ? Tabla.GetNewId("proveedor", "idProveedor") : (Tabla.GetNewId("proveedor", "idProveedor") + 1);
                    valores.Add(NewId.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["nombreProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["direccionProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["emailProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["telefonoProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["NITProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["NRCProv"].Value.ToString());
                    valores.Add(dgProveedor.CurrentRow.Cells["contacto"].Value.ToString());
                }
                if (dgProveedor.CurrentRow.Cells["idProveedor"].Value == null || dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString().Length == 0)
                {
                    if (dgProveedor.CurrentRow.Cells["nombreProv"].Value.ToString().Length > 0 && dgProveedor.CurrentRow.Cells["direccionProv"].Value.ToString().Length > 0)
                    {

                        Tabla.Insert("proveedor", campos, valores);
                        dgProveedor.CurrentRow.Cells["idProveedor"].Value = NewId;
                        LlenarGridProveedor();

                        dgProveedor.CurrentCell = dgProveedor.Rows[dgProveedor.RowCount - 1].Cells[0];
                        dgProveedor.CurrentCell.ReadOnly = false;
                        dgProveedor.BeginEdit(true);
                        dgProveedor.EndEdit();
                        dgProveedor.CurrentCell.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnFinalProv_Click(object sender, EventArgs e)
        {
            dgProveedor.CurrentCell = dgProveedor.Rows[dgProveedor.RowCount - 1].Cells[0];
        }

        //*****************************************************************************
        //* MANTENIMIENTO PROVEEDOR INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        
        private void btnProveedorNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnProveedorNewSave.Tag.ToString() == "1")
            {
                btnProveedorNewSave.Tag = "2";
                btnProveedorNewSave.Image = Resources.save;
                btnProveedorEditCancel.Tag = "2";
                btnProveedorEditCancel.Image = Properties.Resources.cancel;
                groupBoxProveedor.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtidProveedor.ReadOnly = true;
                LimpiarProveedorForm();
            }
            else
            {
                if (txtNombreProv.TextLength > 0 && txtDireccionProv.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idProveedor");
                    campos.Add("nombre");
                    campos.Add("direccion");
                    campos.Add("email");
                    campos.Add("telefono");
                    campos.Add("NIT");
                    campos.Add("regContable");
                    campos.Add("contacto");

                    List<string> valores = new List<string>();
                    if (txtidProveedor.TextLength > 0)
                        valores.Add(txtidProveedor.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("proveedor", "idProveedor") > 0) ? Tabla.GetNewId("proveedor", "idProveedor") : (Tabla.GetNewId("proveedor", "idProveedor") + 1);
                        valores.Add(NewId.ToString());
                    }


                    valores.Add(txtNombreProv.Text);
                    valores.Add(txtDireccionProv.Text);
                    valores.Add(txtEmailProv.Text);
                    valores.Add(txtTelefonoProv.Text);
                    valores.Add(txtNITProv.Text);
                    valores.Add(txtNRCProv.Text);
                    valores.Add(txtContactoProv.Text);

                    btnProveedorNewSave.Tag = "1";
                    btnProveedorNewSave.Image = Properties.Resources.new_;

                    btnProveedorEditCancel.Tag = "1";
                    btnProveedorEditCancel.Image = Properties.Resources.edit;
                    groupBoxProveedor.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);

                    bool actualizacion;
                    int filaActual = 0;
                    if (txtidProveedor.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgProveedor.CurrentRow.Index;
                        Tabla.Update("proveedor", campos, valores, "idProveedor", txtidProveedor.Text);
                    }
                    else
                    {
                        actualizacion = false;

                        Tabla.Insert("proveedor", campos, valores);
                    }

                    LlenarGridProveedor();
                    dgProveedor.Refresh();

                    if (actualizacion)
                        dgProveedor.CurrentCell = dgProveedor.Rows[filaActual].Cells[0];
                    else
                    {
                        filaActual = dgProveedor.Rows.Count - 1;
                        dgProveedor.CurrentCell = dgProveedor.Rows[dgProveedor.RowCount - 1].Cells[0];
                        //dgProducto.CurrentCell = dgProducto.Rows[filaActual].Cells[0];
                    }
                    LimpiarProveedorForm();
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnProveedorEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnProveedorEditCancel.Tag.ToString() == "1")
            {
                btnProveedorEditCancel.Tag = "2";
                btnProveedorEditCancel.Image = Properties.Resources.cancel;

                btnProveedorNewSave.Tag = "2";
                btnProveedorNewSave.Image = Resources.save;
                groupBoxProveedor.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtidProveedor.ReadOnly = true;
                DataRow dr = Tabla.GetRecordByID("proveedor", "idProveedor", dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString());

                txtidProveedor.Text = dr["idProveedor"].ToString();
                txtNombreProv.Text = dr["nombre"].ToString();
                txtDireccionProv.Text = dr["direccion"].ToString();
                txtEmailProv.Text = dr["email"].ToString();
                txtTelefonoProv.Text = dr["telefono"].ToString();
                txtNITProv.Text = dr["NIT"].ToString();
                txtNRCProv.Text = dr["regContable"].ToString();
                txtContactoProv.Text = dr["contacto"].ToString();
            }
            else
            {
                btnProveedorEditCancel.Tag = "1";
                btnProveedorEditCancel.Image = Properties.Resources.edit;

                btnProveedorNewSave.Tag = "1";
                btnProveedorNewSave.Image = Properties.Resources.new_;
                groupBoxProveedor.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                LimpiarProveedorForm();
            }
        }

        private void btnProveedorDelete_Click(object sender, EventArgs e)
        {
            if (dgProveedor.RowCount > 1)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("proveedor", "idProveedor", dgProveedor.CurrentRow.Cells["idProveedor"].Value.ToString());
                LlenarGridProveedor();
            }
        }

        private void btnProveedorSearch_Click(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgProveedor, Table.GetRecordsFiltersLike("proveedor", "nombre", txtFiltroProv.Text));
        }
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtidProveedor.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgProveedor, Tabla.GetRecordsFiltersLike("proveedor", "nombre", txtNombreProv.Text));
            }
        }

        private void txtFiltroProveedor_TextChanged(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgProveedor, Table.GetRecordsFiltersLike("proveedor", "nombre", txtFiltroProv.Text));
        }
        private void txtTelefonoProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

    }
}
//dgProducto.Rows[dgProducto.RowCount - 1].Selected = true;