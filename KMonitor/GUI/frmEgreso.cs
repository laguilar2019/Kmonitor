using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using KMonitor.Properties;
using CrystalDecisions.CrystalReports.Engine;

namespace KMonitor.GUI
{
    public partial class frmEgreso : Form
    {
        private DataTable dataTableEgreso = new DataTable();
        private DataTable DTVentas = new DataTable();
        private DataTable DTEgresos = new DataTable();
        private DataSet DS = new DataSet();
        DBM.CLS.Sesion _SESION =  DBM.CLS.Sesion.Instancia;
        private DataRow drEmp;
        //private Boolean CajaAbierta = false;
        private String idCajaAbierta;
        private String cantidadOriginal="";
        private String filtro = "";

        public frmEgreso()
        {
            InitializeComponent();
        }
        private void frmEgreso_Load(object sender, EventArgs e)
        {
            lblEfectivoDisponible.Text = obtenerSaldoCaja().ToString();
            cargarGrid();
            LlenarGridTipoEgreso();
            LlenarCbo();
            drEmp = InfoEmpresa(); 
        }
        private DataRow InfoEmpresa()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DataRow drE = Query.GetRecordTop("empresa");
            return drE;
        }
        private void LlenarCbo()
        {
            DBM.CLS.Funciones.FillCombobox(cboTIpoEgreso,"egreso_tipo","idEgresoTipo","egresoTipo");
        }
        private Double obtenerSaldoCaja()
        {
            Double getSaldo=0.0;
            DBM.CLS.QUERY objQuery = new DBM.CLS.QUERY();
            dataTableEgreso = objQuery.GetRecordsFilters("caja", "estado", "1");
            if (dataTableEgreso.Rows.Count  > 0)
            {
                for (int i = 0; i < objQuery.GetRecordsFilters("caja", "estado", "1").Rows.Count ; i++)
                {
                    DataRow dr = dataTableEgreso.Rows[i];
                    getSaldo = Double.Parse(dr["saldo"].ToString());
                    idCajaAbierta = dr["idCaja"].ToString();
                }
            }
            txtIdCaja.Text = idCajaAbierta;
            txtUsuario.Text = _SESION.Usuario;
            return getSaldo;
        }

        private void cargarGrid()
        {
            DBM.CLS.QUERY objQuery = new DBM.CLS.QUERY();
            //DBM.CLS.Funciones.FillGridView(dgEgreso, objQuery.GetRecordsFilters("egreso", "idCaja", idCajaAbierta));
            DBM.CLS.Funciones.FillGridView(dgEgreso, objQuery.GetRecordsFromTwoTableLEFTJOIN("egreso","egreso_tipo","idEgresoTipo", "idEgresoTipo", "a.idCaja =" + idCajaAbierta, "a.idEgreso"));
        }
        private void cargarGridQuery()
        {
            //if (txtQueryIDCaja.TextLength > 0)
            //{
                filtro = " CAST(fecha AS DATE) BETWEEN '" + txtFecha1.Text + "' AND '" + txtFecha2.Text + "'";
                //String filtro = " CAST(fecha AS DATE)>='" + txtFecha1.Text + "' and CAST(fecha AS DATE) <='" + txtFecha2.Text+"'";
                DBM.CLS.QUERY objQuery = new DBM.CLS.QUERY();
                //DBM.CLS.Funciones.FillGridView(dgQuery, objQuery.GetRecordsFilters("egreso", "1", filtro));
                DBM.CLS.Funciones.FillGridView(dgQuery, objQuery.GetRecordsFromTwoTableLEFTJOIN("egreso", "egreso_tipo", "idEgresoTipo", "idEgresoTipo", filtro , "a.fecha"));
            //}
        }
        private void cargarGridQueryByIDCaja()
        {
            if (txtQueryIDCaja.TextLength > 0)
            {
                //String filtro = " CAST(fecha AS DATE)>='" + txtFecha1.Text + "' and CAST(fecha AS DATE) <='" + txtFecha2.Text+"'";
                DBM.CLS.QUERY objQuery = new DBM.CLS.QUERY();
                DBM.CLS.Funciones.FillGridView(dgQuery, objQuery.GetRecordsFilters("egreso", "idCaja", txtQueryIDCaja.Text));
            }
        }

        private void limpiar()
        {
            txtId.Clear();
            txtIdCaja.Text = idCajaAbierta;
            txtUsuario.Text = _SESION.Usuario; 
            txtFecha.Text = "";
            txtDescripcion.Clear();
            txtCantidad.Text = int.Parse("0").ToString();
            txtNreferencia.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgEgreso.RowCount > 0)
            {
                txtId.Text = dgEgreso.CurrentRow.Cells["idEgreso"].Value.ToString();
                txtFecha.Text = dgEgreso.CurrentRow.Cells["fecha2"].Value.ToString();
                txtDescripcion.Text = dgEgreso.CurrentRow.Cells["descripcion"].Value.ToString();
                txtCantidad.Text = dgEgreso.CurrentRow.Cells["cantidad"].Value.ToString();
                cantidadOriginal = float.Parse(dgEgreso.CurrentRow.Cells["cantidad"].Value.ToString().Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture).ToString("F2").Replace(",", ".");
                try
                {
                    cboTIpoEgreso.SelectedValue = dgEgreso.CurrentRow.Cells["idEgresoTipo2"].Value.ToString();
                }
                catch { }
                txtNreferencia.Text = dgEgreso.CurrentRow.Cells["nReferencia"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            DBM.CLS.CRUD objEgreso = new DBM.CLS.CRUD();
            string egresoID = dgEgreso.CurrentRow.Cells["idEgreso"].Value.ToString();
            string importe = dgEgreso.CurrentRow.Cells["cantidad"].Value.ToString();

            objEgreso.GetRecordByID("egreso","idEgreso",dgEgreso.CurrentRow.Cells["idEgreso"].Value.ToString());
                try
                {
                    if (Tabla.Delete("egreso","idEgreso", egresoID) >0)
                    {
                        MessageBox.Show("El registro se eliminó correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<string> campos =new List<string>();
                        List<string> valores= new List<string>();
                        campos.Add("saldo");
                        valores.Add("saldo + " + importe.Replace(",", "."));

                        Tabla.Update("caja",campos,valores,"estado","1");
                        lblEfectivoDisponible.Text = obtenerSaldoCaja().ToString();
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }catch(Exception)
                {
                    MessageBox.Show("No ha seleccionado un registro para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private Boolean ComprobarDatos()
        {
            Boolean OK = true;
            Notificador.Clear();

            if (txtIdCaja.Text.Length == 0)
            {
                Notificador.SetError(txtIdCaja, "Campo obligatorio");
                OK = false;
            }
            if (txtFecha.Text.Length == 0)
            {
                Notificador.SetError(txtFecha, "Campo obligatorio");
                OK = false;
            }
            if (txtCantidad.Text.Length == 0)
            {
                Notificador.SetError(txtCantidad, "Campo obligatorio");
                OK = false;
            }
            if (txtCantidad.TextLength > 0)
            {
                if (Double.Parse(txtCantidad.Text) <= 0)
                {
                    Notificador.SetError(txtCantidad, "Digite una cantidad mayor a '0'");
                    OK = false;
                }
            }
            if (txtDescripcion.Text.Length == 0)
            {
                Notificador.SetError(txtDescripcion, "Campo obligatorio");
                OK = false;
            }

            return OK;
        }



        private void temporizador_Tick(object sender, EventArgs e)
        {
            lblEfectivoDisponible.Text = obtenerSaldoCaja().ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
                DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                campos.Add("idEgreso");
                campos.Add("idEgresoTipo");
                campos.Add("idCaja");
                campos.Add("idUsuario");
                campos.Add("fecha");
                campos.Add("cantidad");
                campos.Add("descripcion");
                campos.Add("nReferencia");

                if (txtId.TextLength > 0)
                    valores.Add(txtId.Text);
                else
                    valores.Add((Tabla.GetNewId("egreso", "idEgreso") > 0) ? Tabla.GetNewId("egreso", "idEgreso").ToString() : (Tabla.GetNewId("egreso", "idEgreso") + 1).ToString());

                valores.Add(cboTIpoEgreso.SelectedValue.ToString());
                valores.Add(txtIdCaja.Text);
                valores.Add(_SESION.idUsuario);
                valores.Add(txtFecha.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                string _cantidad = float.Parse(txtCantidad.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture).ToString("F2").Replace(",", ".");
                valores.Add(_cantidad);
                valores.Add(txtDescripcion.Text);
                valores.Add(txtNreferencia.Text);

                if (txtId.Text.Length > 0)
                {

                    //objEgreso.estado = Boolean.Parse(dgCaja.CurrentRow.Cells["estado"].Value.ToString());
                    if (Tabla.Update("egreso",campos,valores,"idEgreso",txtId.Text)>0)
                    {
                        string QueryT="";
                        MessageBox.Show("El registro se actualizó correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (float.Parse(cantidadOriginal) < float.Parse(_cantidad))
                        {
                            //MessageBox.Show("Es mayor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            float excedente = (float.Parse(_cantidad, NumberStyles.Float, CultureInfo.InvariantCulture) - float.Parse(cantidadOriginal, NumberStyles.Float, CultureInfo.InvariantCulture));
                            CLS.Caja objCaja = new CLS.Caja();
                            QueryT = objCaja.RetiroCaja(excedente.ToString("F2").Replace(",", "."));                           
                        }
                        if (Double.Parse(cantidadOriginal) > Double.Parse(_cantidad))
                        {
                            //MessageBox.Show("Es menor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            float sobrante = (float.Parse(cantidadOriginal, NumberStyles.Float, CultureInfo.InvariantCulture) - float.Parse(_cantidad, NumberStyles.Float, CultureInfo.InvariantCulture));
                            CLS.Caja objCaja = new CLS.Caja();
                            QueryT = objCaja.AbonarCaja(sobrante.ToString("F2").Replace(",", "."));
                        }
                        if (QueryT.Length > 0)
                            Trans.CreateTransaction(QueryT);

                        cargarGrid();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (Tabla.Insert("egreso",campos,valores)>0)
                    {
                        MessageBox.Show("El registro se guardó correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CLS.Caja objCaja = new CLS.Caja();
                        Trans.CreateTransaction(objCaja.RetiroCaja(_cantidad));
                        cargarGrid();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                lblEfectivoDisponible.Text = obtenerSaldoCaja().ToString();
            }
            
        }

        private void btnQueryInforme_Click(object sender, EventArgs e)
        {

            imprimirReporteQuery(new REPORTS.crEgresos());
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            txtFecha1.Text = dateStart.Value.ToString("yyyy-MM-dd");
            cargarGridQuery();
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            txtFecha2.Text = dateEnd.Value.ToString("yyyy-MM-dd");
            cargarGridQuery();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQueryIDCaja_TextChanged(object sender, EventArgs e)
        {
            cargarGridQueryByIDCaja();
        }

        private void imprimirReporte()
        {

            String encabezado = "Reporte de egresos, fecha de impresión: " + txtFecha.Value.ToString("dd-MM-yyyy");
            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            frm.reporte = new REPORTS.crEgresos();
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;
            frm.Datos = dgEgreso.DataSource as DataTable;
            this.Visible=false;
            frm.ShowDialog();
            this.Visible = true;
            
        }
        private void imprimirReporteQuery(ReportDocument reporte)
        {
            String encabezado = "Reporte de egresos, fecha de impresión: " + txtFecha.Value.ToString("dd-MM-yyyy");
            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            frm.reporte = reporte;
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;
            frm.Datos = dgQuery.DataSource as DataTable;
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
       }
        private void imprimirReporteQuery(ReportDocument reporte,DataTable dt)
        {
            String encabezado = "Reporte de egresos, fecha de impresión: " + txtFecha.Value.ToString("dd-MM-yyyy");
            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            frm.reporte = reporte;
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;
            frm.Datos = dt;
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            //DBM.CLS.Funciones.soloDecimal((TextBox)sender,"");
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

            imprimirReporte();
        }


        //************************************************************************
        //TAB PARA TIPO DE EGRESO
        //************************************************************************
        private void LlenarGridTipoEgreso()
        {
            DBM.CLS.Funciones.FillGridView(dgEgresoTipo, "egreso_tipo");
        }
        private void LimpiarForm()
        {
            groupBoxTipoEgreso.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");

        }
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
            LlenarCbo();
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

        private void btnSalirTipoEgreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporteFechas_Click(object sender, EventArgs e)
        {
            DS.Reset();
            filtrarVentas();
            filtrarEgresos();
            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            try
            {
                DS.Tables.Add(DTVentas);
                DS.Tables.Add(DTEgresos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm.multiTables = true;
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.DatosDS = DS;

            String encabezado = "Flujo de efectivo. Fecha de impresión: " + txtFecha.Value.ToString("dd-MM-yyyy");
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;

            frm.reporte = new REPORTS.crCashFlowDetail();
            frm.Show();
        }

        private void btnFechasConsolidado_Click(object sender, EventArgs e)
        {
            DS.Reset();
            filtrarVentas();
            filtrarEgresos();
            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            try
            {
                DS.Tables.Add(DTVentas);
                DS.Tables.Add(DTEgresos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            frm.multiTables = true;
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.DatosDS = DS;

            String encabezado = "Flujo de efectivo. Fecha de impresión: " + txtFecha.Value.ToString("dd-MM-yyyy");
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;

            frm.reporte = new REPORTS.crCashFlowResumeV2();
            frm.Show();
        }
        private void filtrarVentas()
        {
            ///********************************************************
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            //string sql = "SELECT pd.idDetalle,pd.idPedido,pd.idProducto,p.nombre as producto,pd.cantidad,pd.precio,pd.subTotal,pd.grupo,pd.idCocinero,pd.extras,DATE_FORMAT(pd.horaPedido, '%Y-%m-%d %H:%i:%s') as horaPedido,DATE_FORMAT(pd.horaEntregado, '%Y-%m-%d %H:%i:%s') as horaEntregado,pe.fecha from pedido_detalle pd, producto p, pedido pe where pd.idProducto = p.idProducto and pd.idpedido = pe.idPedido " + _filtro + " ;";
            //Query.Consultar(sql);
            if (txtFecha1.TextLength > 0 && txtFecha2.TextLength > 0)
            {
                filtro = " CAST(fecha AS DATE)>='" + txtFecha1.Text + "' and CAST(fecha AS DATE) <='" + txtFecha2.Text + "' and anular=0";
            }
            if (txtFecha1.TextLength > 0 && txtFecha2.TextLength == 0)
            {
                filtro = " CAST(fecha AS DATE)='" + txtFecha1.Text + "' and anular=0";
            }

            ///********************************************************
            //string sql = "SELECT *,MONTH(a.fecha) as mes from pedido where " + filtro + ";";
            string sql = "SELECT *,Date_format(fecha,'%M') as mes from pedido where " + filtro + ";";
            try
            {
                if (filtro.Length > 0)
                    DTVentas = Query.Consultar(sql);
            }
            catch
            {

            }
        }
        private void filtrarEgresos()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            filtro = " CAST(fecha AS DATE) BETWEEN '" + txtFecha1.Text + "' AND '" + txtFecha2.Text + "'";
            //string sql = "Select a.*, b.*,MONTH(a.fecha) as mes from egreso  a left join egreso_tipo b on(a.idEgresoTipo= b.idEgresoTipo) where " + filtro + " order by a.fecha ";
            string sql = "Select a.*, b.*,Date_format(a.fecha,'%M') as mes from egreso  a left join egreso_tipo b on(a.idEgresoTipo= b.idEgresoTipo) where " + filtro + " order by a.fecha "; 
            try
            {
                    DTEgresos = Query.Consultar(sql);
            }
            catch
            {

            }
        }
    }
}
