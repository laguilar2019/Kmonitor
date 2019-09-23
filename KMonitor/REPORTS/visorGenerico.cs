using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMonitor.REPORTS
{
    public partial class visorGenerico : Form
    {
        public bool multiTables = false;
        DataTable _Datos = new DataTable();
        DataSet _DatosDS = new DataSet();
        String _empresa = "", _slogan = "", _encabezado = "",myReport="",_direcctor="", _registroAcademico= "", _firma = "", _firmaRA = "";
        public ReportDocument reporte;
        public DataTable Datos
        {
            get { return _Datos; }
            set { _Datos = value; }
        }
        public DataSet DatosDS
        {
            get { return _DatosDS; }
            set { _DatosDS = value; }
        }

        public String empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        public String slogan
        {
            get { return _slogan; }
            set { _slogan = value; }
        }
        public String encabezado
        {
            get { return _encabezado; }
            set { _encabezado = value; }
        }
        public String director
        {
            get { return _direcctor; }
            set { _direcctor = value; }
        }
        public String firma
        {
            get { return _firma; }
            set { _firma = value; }
        }
        public String registroAcademico
        {
            get { return _registroAcademico; }
            set { _registroAcademico = value; }
        }

        public String firmaRegistroAcademico
        {
            get { return _firmaRA; }
            set { _firmaRA = value; }
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (multiTables)
            {
                reporte.SetDataSource(_DatosDS);                
                try
                {
                    reporte.Database.Tables["tmpdetalle"].SetDataSource(_DatosDS.Tables[0]);
                }
                catch { }
                try
                {
                    reporte.Database.Tables["tmpEgreso"].SetDataSource(_DatosDS.Tables[1]);
                }
                catch { }
            }
            else
                reporte.SetDataSource(_Datos);


            //para el parameterFiled() de Crystal Report
            reporte.SetParameterValue("empresa", empresa);
            reporte.SetParameterValue("slogan", slogan);
            reporte.SetParameterValue("encabezado", encabezado);

            if (director.Length > 0 ) {
                try
                {
                    reporte.SetParameterValue("director", director);
                }
                catch (Exception ex)
                {

                }
            }
            if (registroAcademico.Length > 0)
            {
                try
                {
                    reporte.SetParameterValue("regAcad", registroAcademico);
                }
                catch (Exception ex)
                {

                }
            }
            if (firma.Length > 0)
            {
                try
                {
                    reporte.SetParameterValue("RutaFirma", firma);
                }
                catch (Exception ex)
                {

                }
            }
            if (firmaRegistroAcademico.Length > 0)
            {
                try
                {
                    reporte.SetParameterValue("RutaFirmaRA", firmaRegistroAcademico);
                }
                catch (Exception ex)
                {

                }
            }

            crystalReportViewer1.ReportSource = reporte;
        }

        public visorGenerico()
        {
            InitializeComponent();
        }

        private void visorGenerico_Load(object sender, EventArgs e)
        {

        }
    }
}
