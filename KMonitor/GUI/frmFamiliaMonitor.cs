using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KMonitor.GUI
{
    public partial class frmFamiliaMonitor : Form
    {
        public frmFamiliaMonitor()
        {
            InitializeComponent();
        }

        private void frmFamiliaMonitor_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\xml\\archivo.xml"))
                llenarGridXml();
            else
                llenarGrid();

        }
        private void llenarGrid()
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgFamilia,Query.Consultar("select idFamilia,familia,'1' as enMonitor from familia order by familia"));
        }
        private void llenarGridXml()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\xml\\archivo.xml"))
            {
                XmlDataDocument xmlData = new XmlDataDocument();
                xmlData.DataSet.ReadXml(Application.StartupPath+"\\xml\\archivo.xml");
                dgFamilia.DataSource = xmlData.DataSet;
                dgFamilia.DataMember = "Categoría";
            } 

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            DBM.CLS.Transaccion Trans = new DBM.CLS.Transaccion();
            string sql = "";    
            foreach (DataGridViewRow dr in dgFamilia.Rows) {
                sql = "UPDATE familia SET enMonitor = " + dr.Cells[2].Value.ToString() + " WHERE idFamilia= " + dr.Cells[0].Value.ToString();
                Trans.CreateTransaction(sql);
            }
            MessageBox.Show("Los datos se actualizaron con éxito",ProductName,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnXmlSave_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("Categorías");
            doc.AppendChild(raiz);

            XmlElement categoría;
            XmlElement idFamilia;
            XmlElement familia;
            XmlElement enMonitor;
            foreach (DataGridViewRow dr in dgFamilia.Rows)
            {
                categoría = doc.CreateElement("Categoría");
                raiz.AppendChild(categoría);

                idFamilia = doc.CreateElement("idFamilia");
                idFamilia.AppendChild(doc.CreateTextNode(dr.Cells[0].Value.ToString()));
                categoría.AppendChild(idFamilia);

                familia = doc.CreateElement("familia");
                familia.AppendChild(doc.CreateTextNode(dr.Cells[1].Value.ToString()));
                categoría.AppendChild(familia);

                enMonitor = doc.CreateElement("enMonitor");
                enMonitor.AppendChild(doc.CreateTextNode(dr.Cells[2].Value.ToString()));
                categoría.AppendChild(enMonitor);
            }



            // OTRA CATEGORÍA
            if (System.IO.Directory.Exists(Application.StartupPath + "\\xml"))
            {
                doc.Save(Application.StartupPath + "\\xml\\archivo.xml");
                MessageBox.Show("Datos almacenados con éxito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\xml");
                doc.Save(Application.StartupPath + "\\xml\\archivo.xml");
                MessageBox.Show("Datos almacenados con éxito", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();

        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            DBM.CLS.QUERY Query = new DBM.CLS.QUERY();
            DBM.CLS.Funciones.FillGridView(dgFamilia, Query.Consultar("select idFamilia,familia,'1' as enMonitor from familia order by familia"));
        }
    }
}
