using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMonitor
{
    public partial class Form1 : Form
    {
        private string botonArrastrando = "";

        bool botonPresionado = false;
        int posMouseFormX, posMouseFormY, posMouseBotonX, posMouseBotonY, posActBotonX, posActBotonY;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            List<string> campos = new List<string>();
            campos.Add("idFamilia");
            campos.Add("familia");
            campos.Add("activo");
            

            List<string> valores = new List<string>();
            valores.Add(txtId.Text);
            valores.Add(TxtField1.Text);
            valores.Add("1");

            Tabla.Insert("familia",campos,valores);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            DataRow dr = Tabla.GetRecordByID("Familia", "idFamilia", txtId.Text);
            TxtField1.Text =  dr["familia"].ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();

            if (Tabla.Delete("Familia", "idFamilia", txtId.Text) > 0)
            {                
                txtId.ResetText();
                TxtField1.ResetText();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBM.CLS.CRUD Tabla = new DBM.CLS.CRUD();
            List<string> campos = new List<string>();
            List<string> valores = new List<string>();
            campos.Add("familia");
            valores.Add(TxtField1.Text);


            Tabla.Update("Familia",campos,valores,"idFamilia",txtId.Text);
            
            
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            DBM.GUI.ConnectionString frm = new DBM.GUI.ConnectionString();
            frm.Show();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            DBM.GUI.frmBackup frm = new DBM.GUI.frmBackup();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.frmProducto frm = new GUI.frmProducto();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.frmClienteProveedor frm = new GUI.frmClienteProveedor();
            frm.tabProveedor.Parent = null;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.frmClienteProveedor frm = new GUI.frmClienteProveedor();
            frm.tabCliente.Parent = null;

            //frm.tabCliente.Parent = frm.tabControlMain;
            //frm.tabControlMain.SelectedTab = frm.tabCliente

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUI.frmPermisos frm = new GUI.frmPermisos();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUI.frmUsers frm = new GUI.frmUsers();
            frm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            GUI.frmEstado frm = new GUI.frmEstado();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GUI.frmMonitor frm = new GUI.frmMonitor();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GUI.frmSettings frm = new GUI.frmSettings();
            frm.Show();
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Point l = this.PointToClient(Cursor.Position);
            if (((Button)sender).Name == botonArrastrando)
            {
                ((Button)sender).Location = l;
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            botonArrastrando = ((Button)sender).Name;
            botonPresionado = true;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            botonArrastrando = "";
            botonPresionado = false;
        }

    }
}
