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
    public partial class frmUsers : Form
    {
        private bool eventChange;
        private bool eventKeyPress;
        private bool eventLoad;
        
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            LlenarCboPerfil();
            LlenarGridPerfil();
        }

        //***************************************************************************************
        //* LLENAR TODOS LOS GRID VIEW y COMBOBOX
        //***************************************************************************************
        private void LlenarGrid()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DataTable DT = Query.GetRecordsFromTwoTable("empleado", "usuario", "idEmpleado", "idUsuario", "", "apellidos");
            DBM.CLS.Funciones.FillGridView(dgUsuario, DT);
        }
        private void LlenarCboPerfil()
        {
            DBM.CLS.Funciones.FillCombobox(cboPerfil, "Rol","idRol","Rol");
        }
        private void LlenarGridPerfil()
        {
            DBM.CLS.Funciones.FillCombobox(cboPerfil, "Rol", "idRol", "Rol");
        }
        //***************************************************************************************
        //* LIMPIAR
        //***************************************************************************************
        private void LimpiarForm()
        {
            groupBoxUsuario.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            groupBoxUsuario.Controls.OfType<CheckBox>().ToList().ForEach(o => o.Checked = false);
        }
        //************************************************************************
        // MANTENIMIENTO PRODUCCTO GRIDVIEW
        //************************************************************************
        
        //*****************************************************************************
        //* MANTENIMIENTO PRODUCTO INDIVIDUAL(SIN GRIDVIEW)
        //*****************************************************************************
        private void btnUsuarioNewSave_Click(object sender, EventArgs e)
        {
            int NewId = 0;
            if (btnUsuarioNewSave.Tag.ToString() == "1")
            {
                btnUsuarioNewSave.Tag = "2";
                btnUsuarioNewSave.Image = Resources.save;
                btnUsuarioEditCancel.Tag = "2";
                btnUsuarioEditCancel.Image = Properties.Resources.cancel;
                groupBoxUsuario.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdUsuario.ReadOnly = true;
                txtNombres.Focus();
                LimpiarForm();
                chkChangePassword.Visible = false;
            }
            else
            {
                if (txtNombres.TextLength > 0)
                {
                    DBM.CLS.QUERY query = new DBM.CLS.QUERY();
                    DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                    
                    List<string> campos = new List<string>();
                    campos.Add("idEmpleado");
                    campos.Add("nombres");
                    campos.Add("apellidos");
                    campos.Add("email");
                    campos.Add("telefono");
                    campos.Add("idRol");

                    List<string> valores = new List<string>();
                    if (txtIdUsuario.TextLength > 0)
                        valores.Add(txtIdUsuario.Text);
                    else
                    {
                        NewId = (Tabla.GetNewId("usuario", "idUsuario") > 0) ? Tabla.GetNewId("usuario", "idUsuario") : (Tabla.GetNewId("usuario", "idUsuario") + 1);
                        valores.Add(NewId.ToString());
                    }
                    valores.Add(txtNombres.Text);
                    valores.Add(txtEmail.Text);
                    valores.Add(txtTelefono.Text);
                    
                    valores.Add(cboPerfil.SelectedValue.ToString());
                    bool actualizacion, continuar=false;
                    int filaActual = 0;
                    if (txtIdUsuario.TextLength > 0)
                    {
                        actualizacion = true;
                        filaActual = dgUsuario.CurrentRow.Index;
                        if (chkChangePassword.Checked)
                        {
                            campos.Add("password");
                            valores.Add(query.GetSHA1FromString(txtPassword.Text));
                            continuar = ComprobarDatos();
                            if(continuar)
                            {
                                Tabla.Update("usuario", campos, valores, "idUsuario", txtIdUsuario.Text);
                            }
                        }
                        else
                        {
                            Tabla.Update("usuario", campos, valores, "idUsuario", txtIdUsuario.Text);
                            continuar = true;
                        }
                    }
                    else
                    {
                        campos.Add("password");
                        valores.Add(query.GetSHA1FromString(txtPassword.Text));
                        actualizacion = false;
                        if (continuar = ComprobarDatos())
                        {
                            Tabla.Insert("usuario", campos, valores);
                        }
                    }
                    if(continuar)
                    {
                        chkChangePassword.Checked = false;
                        btnUsuarioNewSave.Tag = "1";
                        btnUsuarioNewSave.Image = Properties.Resources.new_;
                        btnUsuarioEditCancel.Tag = "1";
                        btnUsuarioEditCancel.Image = Properties.Resources.edit;
                        groupBoxUsuario.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                        LlenarGrid();
                        if (actualizacion)
                            dgUsuario.CurrentCell = dgUsuario.Rows[filaActual].Cells[0];
                        else
                        {
                            filaActual = dgUsuario.Rows.Count - 1;
                            dgUsuario.CurrentCell = dgUsuario.Rows[dgUsuario.RowCount - 1].Cells[0];
                            //dgProducto.CurrentCell = dgProducto.Rows[filaActual].Cells[0];
                        }
                        LimpiarForm();
                        chkChangePassword.Visible = false;
                    }
                }
                else
                {
                    //MENSAJE VACIOS
                }
            }
        }

        private void btnUsuarioEditCancel_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (btnUsuarioEditCancel.Tag.ToString() == "1")
            {
                btnUsuarioEditCancel.Tag = "2";
                btnUsuarioEditCancel.Image = Properties.Resources.cancel;

                btnUsuarioNewSave.Tag = "2";
                btnUsuarioNewSave.Image = Resources.save;
                groupBoxUsuario.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = false);
                txtIdUsuario.ReadOnly = true;
                DataRow dr = Tabla.GetRecordByID("empleado", "idEmpleado", dgUsuario.CurrentRow.Cells["idEmpleado"].Value.ToString());

                txtIdUsuario.Text = dr["idUsuario"].ToString();
                txtNombres.Text = dr["nombres"].ToString();
                txtApellidos.Text = dr["apellidos"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtTelefono.Text = dr["telefono"].ToString();
                cboPerfil.SelectedValue = dr["idRol"].ToString();

                txtPassword.ReadOnly = true;
                txtPassword2.ReadOnly = true;

                chkChangePassword.Visible = true;

                txtNombres.Focus();

            }
            else
            {
                btnUsuarioEditCancel.Tag = "1";
                btnUsuarioEditCancel.Image = Properties.Resources.edit;

                btnUsuarioNewSave.Tag = "1";
                btnUsuarioNewSave.Image = Properties.Resources.new_;
                groupBoxUsuario.Controls.OfType<TextBox>().ToList().ForEach(o => o.ReadOnly = true);
                chkChangePassword.Checked = false;
                chkChangePassword.Visible = false;
                LimpiarForm();
            }
        }

        private void btnUsuarioDelete_Click(object sender, EventArgs e)
        {
            if (dgUsuario.RowCount > 0)
            {
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
                Tabla.Delete("empleado", "idEmpleado", dgUsuario.CurrentRow.Cells["idUsuario"].Value.ToString());
                LlenarGrid();
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIdUsuario.TextLength <= 0)
            {
                DBM.CLS.QUERY Tabla = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgUsuario, Tabla.GetRecordsFiltersLike("usuario", "nombre", txtNombres.Text));
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Table = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgUsuario, Table.GetRecordsFiltersLike("usuario", "nombre", txtFiltro.Text));
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            dgUsuario.CurrentCell = dgUsuario.Rows[dgUsuario.RowCount - 1].Cells[0];
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBM.CLS.Funciones.soloDigitos(sender, e);
        }

        private void groupBoxUsuario_Enter(object sender, EventArgs e)
        {

        }
        private Boolean ComprobarDatos()
        {
            Boolean OK = true;
            Notificador.Clear();
            /*
            if (txtNombre.Text.Length == 0)
            {
                Notificador.SetError(txtNombre, "Campo obligatorio");
                OK = false;
            }
            */
            if(! DBM.CLS.Funciones.CheckIgualValues(txtPassword.Text, txtPassword2.Text))
            {
                Notificador.SetError(txtPassword, "Las contraseñas no coinciden");
                OK = false;
            }
            return OK;
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangePassword.Checked)
            {
                txtPassword.ReadOnly = false;
                txtPassword2.ReadOnly = false;
            }else
            {
                txtPassword.ReadOnly = true;
                txtPassword2.ReadOnly = true;
            }
        }
    }
}
//dgProducto.Rows[dgProducto.RowCount - 1].Selected = true;