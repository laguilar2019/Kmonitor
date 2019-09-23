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
    public partial class frmPermisos : Form
    {
        private bool eventChange;
        private bool eventKeyPress;
        DateTime fecha = new DateTime();
        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            LlenarCboPerfil();
            LlenarGridPerfil();
            LlenarGridComando();
            //CargarPermisosDisponibles();
        }

        //***************************************************************************************
        //* LLENAR TODOS LOS COMBOBOX
        //***************************************************************************************
        private void LlenarCboPerfil()
        {
            DBM.CLS.Funciones.FillCombobox(cboPerfil, "Rol","idRol","Rol");
        }

        //***************************************************************************************
        //* LLENAR TODOS LOS GRID VIEW
        //***************************************************************************************
        private void LlenarGridPerfil()
        {
            DBM.CLS.Funciones.FillGridView(dgPerfil, "Rol");
        }
        private void LlenarGridComando()
        {
            DBM.CLS.Funciones.FillGridView(dgComando, "comando");
        }
        
        //***************************************************************************************
        //* LIMPIAR DATOS DE FORMULARIO
        //***************************************************************************************
        private void LimpiarPerfilForm()
        {
            groupBoxPerfil.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }
        private void LimpiarComandoForm()
        {
            groupBoxComando.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }



        //***************************************************************************************
        //* MANTENIMIENTO Rol
        //***************************************************************************************

        private void dgPerfil_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //VALIDAR TextChange 

            if (this.dgPerfil.CurrentCell.ColumnIndex ==1)
            {
                if (!this.eventChange)
                {
                    e.Control.Validating += this.Cell_TextChangedPerfil;
                    this.eventChange = true;
                }
            }
            else
            {
                e.Control.Validating -= this.Cell_TextChangedPerfil;
                this.eventChange = false;
            }
        }
        private void Cell_TextChangedPerfil(object sender, EventArgs e)
        {
            if (dgPerfil.CurrentRow.Cells["idRol"].Value != null && dgPerfil.CurrentRow.Cells["idRol"].Value.ToString().Length > 0 && int.Parse(dgPerfil.CurrentRow.Cells["idRol"].Value.ToString()) > 0)
            {
                dgPerfil.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idRol");
                campos.Add("Rol");
                
                List<string> valores = new List<string>();
                valores.Add(dgPerfil.CurrentRow.Cells["idRol"].Value.ToString());
                valores.Add(dgPerfil.CurrentRow.Cells["Rol"].Value.ToString());

                Tabla.Update("Rol", campos, valores, "idRol", dgPerfil.CurrentRow.Cells["idRol"].Value.ToString());
                LlenarCboPerfil();

            }
        }

        private void CellGrid_KeyPressEventDigitos(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

        private void dgPerfil_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgPerfil.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int NewId = 0;
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idRol");
                campos.Add("Rol");

                List<string> valores = new List<string>();
                if (dgPerfil.CurrentRow.Cells["idRol"].Value != null && dgPerfil.CurrentRow.Cells["idRol"].Value.ToString().Length > 0)
                {
                    valores.Add(dgPerfil.CurrentRow.Cells["idRol"].Value.ToString());
                }
                else
                {
                    NewId = (Tabla.GetNewId("Rol", "idRol") > 0) ? Tabla.GetNewId("Rol", "idRol") : (Tabla.GetNewId("Rol", "idRol") + 1);
                    valores.Add(NewId.ToString());
                    valores.Add(dgPerfil.CurrentRow.Cells["Rol"].Value.ToString());

                    if (dgPerfil.CurrentRow.Cells["idRol"].Value == null || dgPerfil.CurrentRow.Cells["idRol"].Value.ToString().Length == 0)
                    {
                        if (dgPerfil.CurrentRow.Cells["Rol"].Value.ToString().Length > 0)
                        {

                            Tabla.Insert("Rol", campos, valores);
                            dgPerfil.CurrentRow.Cells["idRol"].Value = NewId;
                            LlenarGridPerfil();
                            LlenarCboPerfil();

                            dgPerfil.CurrentCell = dgPerfil.Rows[dgPerfil.RowCount - 1].Cells[0];
                            dgPerfil.CurrentCell.ReadOnly = false;
                            dgPerfil.BeginEdit(true);
                            dgPerfil.EndEdit();
                            dgPerfil.CurrentCell.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        //*****************************************************************************
        //* MANTENIMIENTO Rol INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        private void btnPerfilNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnPerfilNewSave.Tag.ToString() == "1")
            {
                btnPerfilNewSave.Tag = "2";
                btnPerfilNewSave.Image = Properties.Resources.save;
                btnPerfilEditCancel.Tag = "2";
                btnPerfilEditCancel.Image = Properties.Resources.cancel;

                groupBoxPerfil.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdPerfil.ReadOnly = true;

                LimpiarPerfilForm();
                txtPerfil.Focus();
            }
            else
            {
                if (txtPerfil.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idRol");
                    campos.Add("Rol");

                    List<string> valores = new List<string>();
                    if (txtIdPerfil.TextLength > 0)
                        valores.Add(txtIdPerfil.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("Rol", "idRol") > 0) ? Tabla.GetNewId("Rol", "idRol") : (Tabla.GetNewId("Rol", "idRol") + 1);
                        valores.Add(NewId.ToString());
                    }
                    valores.Add(txtPerfil.Text);

                    btnPerfilNewSave.Tag = "1";
                    btnPerfilNewSave.Image = Properties.Resources.new_;
                    btnPerfilEditCancel.Tag = "1";
                    btnPerfilEditCancel.Image = Properties.Resources.edit;
                    groupBoxPerfil.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);

                    bool actualizacion;
                    int filaActual = 0;
                    if (txtIdPerfil.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgPerfil.CurrentRow.Index;
                        Tabla.Update("Rol", campos, valores, "idRol", txtIdPerfil.Text);
                    }
                    else
                    {
                        actualizacion = false;
                        Tabla.Insert("Rol", campos, valores);
                    }

                    LlenarGridPerfil();

                    if (actualizacion)
                        dgPerfil.CurrentCell = dgPerfil.Rows[filaActual].Cells[0];
                    else
                    {
                        filaActual = dgPerfil.Rows.Count - 1;
                        dgPerfil.CurrentCell = dgPerfil.Rows[dgPerfil.RowCount - 1].Cells[0];
                    }
                    LimpiarPerfilForm();
                    LlenarCboPerfil();
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnPerfilEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnPerfilEditCancel.Tag.ToString() == "1")
            {
                btnPerfilEditCancel.Tag = "2";
                btnPerfilEditCancel.Image = Properties.Resources.cancel;

                btnPerfilNewSave.Tag = "2";
                btnPerfilNewSave.Image = Resources.save;
                groupBoxPerfil.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdPerfil.ReadOnly = true;

                DataRow dr = Tabla.GetRecordByID("Rol", "idRol", dgPerfil.CurrentRow.Cells["idRol"].Value.ToString());

                txtIdPerfil.Text = dr["idRol"].ToString();
                txtPerfil.Text = dr["Rol"].ToString();
                txtPerfil.Focus();

            }
            else
            {
                btnPerfilEditCancel.Tag = "1";
                btnPerfilEditCancel.Image = Properties.Resources.edit;

                btnPerfilNewSave.Tag = "1";
                btnPerfilNewSave.Image = Properties.Resources.new_;
                groupBoxPerfil.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                LimpiarPerfilForm();
            }
        }

        private void btnPerfilDelete_Click(object sender, EventArgs e)
        {
            if (dgPerfil.RowCount > 1)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("Rol", "idRol", dgPerfil.CurrentRow.Cells["idRol"].Value.ToString());
                LlenarGridPerfil();
            }
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            if (txtIdPerfil.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgPerfil, Tabla.GetRecordsFiltersLike("Rol", "Rol", txtPerfil.Text));
            }
        }

        private void txtPerfilFiltro_TextChanged(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgPerfil, Tabla.GetRecordsFiltersLike("Rol", "Rol", txtPerfilFiltro.Text));
        }

        //***************************************************************************************
        //* MANTENIMIENTO COMANDO
        //***************************************************************************************

        private void dgComando_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //VALIDAR TextChange 

            if (this.dgComando.CurrentCell.ColumnIndex == 1)
            {
                if (!this.eventChange)
                {
                    e.Control.Validating += this.Cell_TextChangedComando;
                    this.eventChange = true;
                }
            }
            else
            {
                e.Control.Validating -= this.Cell_TextChangedComando;
                this.eventChange = false;
            }
        }
        private void Cell_TextChangedComando(object sender, EventArgs e)
        {
            if (dgComando.CurrentRow.Cells["idComando"].Value != null && dgComando.CurrentRow.Cells["idComando"].Value.ToString().Length > 0 && int.Parse(dgComando.CurrentRow.Cells["idComando"].Value.ToString()) > 0)
            {
                dgComando.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idComando");
                campos.Add("comando");

                List<string> valores = new List<string>();
                valores.Add(dgComando.CurrentRow.Cells["idComando"].Value.ToString());
                valores.Add(dgComando.CurrentRow.Cells["comando"].Value.ToString());

                Tabla.Update("comando", campos, valores, "idComando", dgComando.CurrentRow.Cells["idComando"].Value.ToString());

                CargarPermisosOtorgados();
                CargarPermisosDisponibles();

            }
        }

        private void dgComando_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgComando.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int NewId = 0;
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                campos.Add("idComando");
                campos.Add("comando");

                List<string> valores = new List<string>();
                if (dgComando.CurrentRow.Cells["idComando"].Value != null && dgComando.CurrentRow.Cells["idComando"].Value.ToString().Length > 0)
                {
                    valores.Add(dgComando.CurrentRow.Cells["idComando"].Value.ToString());
                }
                else
                {
                    NewId = (Tabla.GetNewId("comando", "idComando") > 0) ? Tabla.GetNewId("comando", "idComando") : (Tabla.GetNewId("comando", "idComando") + 1);
                    valores.Add(NewId.ToString());
                    valores.Add(dgComando.CurrentRow.Cells["comando"].Value.ToString());

                    if (dgComando.CurrentRow.Cells["idComando"].Value == null || dgComando.CurrentRow.Cells["idComando"].Value.ToString().Length == 0)
                    {
                        if (dgComando.CurrentRow.Cells["comando"].Value.ToString().Length > 0)
                        {

                            Tabla.Insert("Comando", campos, valores);
                            dgComando.CurrentRow.Cells["idComando"].Value = NewId;
                            LlenarGridComando();
                            CargarPermisosOtorgados();
                            CargarPermisosDisponibles();

                            dgComando.CurrentCell = dgComando.Rows[dgComando.RowCount - 1].Cells[0];
                            dgComando.CurrentCell.ReadOnly = false;
                            dgComando.BeginEdit(true);
                            dgComando.EndEdit();
                            dgComando.CurrentCell.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        //*****************************************************************************
        //* MANTENIMIENTO PRODUCTO INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        private void btnComandoNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnComandoNewSave.Tag.ToString() == "1")
            {
                btnComandoNewSave.Tag = "2";
                btnComandoNewSave.Image = Properties.Resources.save;
                btnComandoEditCancel.Tag = "2";
                btnComandoEditCancel.Image = Properties.Resources.cancel;

                groupBoxComando.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdComando.ReadOnly = true;

                LimpiarComandoForm();
                txtComando.Focus();
            }
            else
            {
                if (txtComando.TextLength > 0)
                {

                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    List<string> campos = new List<string>();
                    campos.Add("idComando");
                    campos.Add("comando");

                    List<string> valores = new List<string>();
                    if (txtIdComando.TextLength > 0)
                        valores.Add(txtIdComando.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("comando", "idComando") > 0) ? Tabla.GetNewId("comando", "idComando") : (Tabla.GetNewId("comando", "idComando") + 1);
                        valores.Add(NewId.ToString());
                    }
                    valores.Add(txtComando.Text);

                    btnComandoNewSave.Tag = "1";
                    btnComandoNewSave.Image = Properties.Resources.new_;
                    btnComandoEditCancel.Tag = "1";
                    btnComandoEditCancel.Image = Properties.Resources.edit;
                    groupBoxComando.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);

                    bool actualizacion;
                    int filaActual = 0;
                    if (txtIdComando.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgComando.CurrentRow.Index;
                        Tabla.Update("comando", campos, valores, "idComando", txtIdComando.Text);
                    }
                    else
                    {
                        actualizacion = false;
                        Tabla.Insert("comando", campos, valores);
                    }

                    LlenarGridComando();

                    if (actualizacion)
                        dgComando.CurrentCell = dgComando.Rows[filaActual].Cells[0];
                    else
                    {
                        filaActual = dgComando.Rows.Count - 1;
                        dgComando.CurrentCell = dgComando.Rows[dgComando.RowCount - 1].Cells[0];
                    }
                    LimpiarComandoForm();
                    CargarPermisosOtorgados();
                    CargarPermisosDisponibles();
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnComandoEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnComandoEditCancel.Tag.ToString() == "1")
            {
                btnComandoEditCancel.Tag = "2";
                btnComandoEditCancel.Image = Properties.Resources.cancel;

                btnComandoNewSave.Tag = "2";
                btnComandoNewSave.Image = Resources.save;
                groupBoxComando.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdComando.ReadOnly = true;

                DataRow dr = Tabla.GetRecordByID("comando", "idComando", dgComando.CurrentRow.Cells["idComando"].Value.ToString());

                txtIdComando.Text = dr["idComando"].ToString();
                txtComando.Text = dr["comando"].ToString();
                txtComando.Focus();

            }
            else
            {
                btnComandoEditCancel.Tag = "1";
                btnComandoEditCancel.Image = Properties.Resources.edit;

                btnComandoNewSave.Tag = "1";
                btnComandoNewSave.Image = Properties.Resources.new_;
                groupBoxComando.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                LimpiarComandoForm();
            }
        }

        private void btnComandoDelete_Click(object sender, EventArgs e)
        {
            if (dgComando.RowCount > 1)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("comando", "idComando", dgComando.CurrentRow.Cells["idComando"].Value.ToString());
                LlenarGridComando();
            }
        }

        private void txtComando_TextChanged(object sender, EventArgs e)
        {
            if (txtIdComando.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgComando, Tabla.GetRecordsFiltersLike("comando", "comando", txtComando.Text));
            }
        }

        private void txtComandoFiltro_TextChanged(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgComando, Tabla.GetRecordsFiltersLike("comando", "comando", txtComandoFiltro.Text));
        }


        //************************************************************************************
        //FORMULARIO PERMISOS
        //************************************************************************************
        private void CargarPermisosDisponibles()
        {
            try
            {
                int.Parse(cboPerfil.SelectedValue.ToString());
                DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgDisponibles, Query.GetRecordsFilters("Comando", "idComando", " NOT IN(", "SELECT idComando FROM permiso p WHERE idRol = " + cboPerfil.SelectedValue.ToString() + ") "));
            }
            catch { }
        }
        private void CargarPermisosOtorgados()
        {
            try
            {
                int.Parse(cboPerfil.SelectedValue.ToString());
                DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgOtorgados, Query.GetRecordsFilters("Comando", "idComando", " IN(", "SELECT idComando FROM permiso p WHERE idRol = " + cboPerfil.SelectedValue.ToString() + ") "));
            }
            catch { }
        }

        private void cboPerfil_SelectedValueChanged(object sender, EventArgs e)
        {
                CargarPermisosDisponibles();
                CargarPermisosOtorgados();
        }

        private void btnOtorgar_Click(object sender, EventArgs e)
        {
            try
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();
                campos.Add("idRol");
                campos.Add("idComando");
                campos.Add("fechaCreacion");


                valores.Add(cboPerfil.SelectedValue.ToString());
                valores.Add(dgDisponibles.CurrentRow.Cells["idComandoDisponible"].Value.ToString());
                valores.Add(DateTime.Now.ToString("yyyy-mm-dd"));
                Tabla.Insert("permiso",campos,valores);

                CargarPermisosDisponibles();
                CargarPermisosOtorgados();
                //Variables.cambioSesionUsuario = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnRevocar_Click(object sender, EventArgs e)
        {
            try
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("permiso","idRol", cboPerfil.SelectedValue.ToString() + " and idComando = " + dgOtorgados.CurrentRow.Cells["idComandoOtorgado"].Value.ToString());
                CargarPermisosDisponibles();
                CargarPermisosOtorgados();
                //.cambioSesionUsuario = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
