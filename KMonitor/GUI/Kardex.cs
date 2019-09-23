using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMonitor.GUI
{
    public partial class Kardex : Form
    {
        private DataRow drEmp;

        public Kardex()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataRow InfoEmpresa()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DataRow drE = Query.GetRecordTop("empresa");
            return drE;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            if(Query.GetContadorVistas()<=0)
            {
                CLS.ConfigBD config = new CLS.ConfigBD();
                if(config.crearVistaKardex())
                    MessageBox.Show("La vista de datos ya fué crada con éxito, vuela a intentar mostrar los datos", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string filtro = "";
            if (picturekOk1.Visible && picturekOk2.Visible)
                filtro = " AND fecha >='" + dateStart.Value.ToString("yyyy-MM-dd") + "' and CAST(fecha AS DATE) <='" + dateEnd.Value.ToString("yyyy-MM-dd") + "' ";
            else if (picturekOk1.Visible)
                filtro = " AND fecha >='" + dateStart.Value.ToString("yyyy-MM-dd") + "' ";
            else if (picturekOk2.Visible)
                filtro = " AND fecha <='" + dateEnd.Value.ToString("yyyy-MM-dd") + "' ";
            else //mostrar todos
                filtro = "";

            if (chkFiltro.Checked)
            {
                GUI.bProducto frm = new GUI.bProducto();
                frm.ShowDialog();
                if (frm.id != null && frm.id.Length > 0)
                {
                    txtIdProducto.Text = frm.id;
                    txtProducto.Text = frm.nombreProducto;
                    DBM.CLS.Funciones.FillGridView(dgKardex, Query.GetRecordsFilters("kardex", "idProducto", txtIdProducto.Text  + filtro + " ORDER BY fecha DESC "));
                }
            }
            else
            {

                string sql = "SELECT *  from kardex where" + filtro;
                DBM.CLS.Funciones.FillGridView(dgKardex, Query.GetRecordsFilters("kardex", "1", "1" + filtro + " ORDER BY FECHA DESC"));

            }
            
            
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            drEmp = InfoEmpresa();
        }

        private void imprimirReporteQuery(ReportDocument reporte)
        {
            String encabezado = "";

            if (picturekOk1.Visible && picturekOk2.Visible)
                encabezado = "Reporte Kardex desde: " + dateStart.Value.ToString("yyyy-MM-dd") + " hasta: " + dateEnd.Value.ToString("yyyy-MM-dd");
            else if (picturekOk1.Visible)
                encabezado = "Reporte Kardex desde: " + dateStart.Value.ToString("yyyy-MM-dd");
            else if (picturekOk2.Visible)
                encabezado = "Reporte Kardex hasta: "+ dateEnd.Value.ToString("yyyy-MM-dd");
            else //mostrar todos
                encabezado = "Reporte Kardex";

            REPORTS.visorGenerico frm = new REPORTS.visorGenerico();
            frm.reporte = reporte;
            frm.empresa = drEmp["nombreEmpresa"].ToString();
            frm.slogan = drEmp["slogan"].ToString();
            frm.encabezado = encabezado;
            frm.Datos = dgKardex.DataSource as DataTable;
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
            /*
                Kardex General
                Kardex/Fecha
                Kardex/Producto
                Kardex/Fecha-Producto
             */ 
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cboTipoReporte.Text== "Kardex/Fecha")
                imprimirReporteQuery(new REPORTS.crKardexFecha());
            else if (cboTipoReporte.Text == "Kardex/Fecha-Producto")
                imprimirReporteQuery(new REPORTS.crKardexFechaProducto());
            else if(cboTipoReporte.Text == "Kardex/Producto")
                imprimirReporteQuery(new REPORTS.crKardexProducto());
            else if (cboTipoReporte.Text == "Kardex/Producto-Fecha")
                imprimirReporteQuery(new REPORTS.crKardexProductoFecha());
            else
                imprimirReporteQuery(new REPORTS.crKardex());
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            //txtFecha1.Text = dateStart.Value.Date.ToShortDateString();
            picturekOk1.Visible = true;
            btnQuitarFiltroFechas.Visible = true;
        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            //txtFecha2.Text = dateEnd.Value.Date.ToShortDateString();            
            picturekOk2.Visible = true;
            btnQuitarFiltroFechas.Visible = true;
        }

        private void btnQuitarFiltroFechas_Click(object sender, EventArgs e)
        {
            dateStart.ResetText();
            dateEnd.ResetText();
            txtFecha1.Clear();
            txtFecha2.Clear();
            picturekOk1.Visible = false;
            picturekOk2.Visible = false;
            btnQuitarFiltroFechas.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
