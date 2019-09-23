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
    public partial class frmSelectState : Form
    {
        public string idPlanEstudio_, idGrado_, idAsignatura_, nombreAsignatura_;
        public bool cambioMesero = false;

        public frmSelectState()
        {
            InitializeComponent();
        }
        private void frmSelectState_Load(object sender, EventArgs e)
        {
            filtrarMaterias();
        }
        private void filtrarMaterias()
        {
            try
            {
                DBM.CLS.QUERY Query = new DBM.CLS.QUERY();

                DataTable dtMateria = new DataTable();
                DataRow dr;
                dtMateria = Query.GetRecords("estado");

                for (int i = 0; i < dtMateria.Rows.Count; i++)
                {
                    dr = dtMateria.Rows[i];

                    DBM.CLS.Metodos.myButton MyButton = new DBM.CLS.Metodos.myButton();
                    MyButton.Width = 200;
                    MyButton.Height = 80;
                    MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular);
                    MyButton.BackColor = Color.FromName(dr["color"].ToString());
                    
                    //MyButton.ForeColor = Color.White;
                    MyButton.campo1 = dr["idEstado"].ToString();
                    MyButton.campo2 = dr["estado"].ToString();
                    MyButton.Text = dr["estado"].ToString();

                    MyButton.Click_ConIndice += myButton_Click;
                    MyPanel.Controls.Add(MyButton);
                }
            }
            catch
            {

            }
        }
        private void myButton_Click(object sender, DBM.CLS.Metodos.IntEventArgs e)
        {
            MessageBox.Show(e.campo1 +  " " + e.campo2);
            //cambioMesero = true;
            //idAsignatura_ = e.campo1;
            //nombreAsignatura_ = e.campo2;

            this.Close();
        }
    }
}
